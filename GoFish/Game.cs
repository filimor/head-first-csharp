using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GoFish
{
    public class Game
    {
        private readonly List<Player> _players;
        private readonly Dictionary<Card.Values, Player> _books;
        private readonly Deck _stock;
        private readonly TextBox _textBoxOnForm;

        public string[] PlayerCardNames => _players[0].CardNames;

        /// <summary>
        /// Instância do jogo.
        /// </summary>
        /// <param name="playerName">Nome do jogador real.</param>
        /// <param name="opponentNames">Vetor com os oponentes.</param>
        /// <param name="textBoxOnForm">Caixa de texto no formulário.</param>
        public Game(string playerName, string[] opponentNames, TextBox textBoxOnForm)
        {
            var random = new Random();
            _textBoxOnForm = textBoxOnForm;
            _players = new List<Player>
            {
                new Player(playerName, random, textBoxOnForm)
            };
            foreach (string player in opponentNames)
            {
                _players.Add(new Player(player, random, textBoxOnForm));
            }
            _books = new Dictionary<Card.Values, Player>();
            _stock = new Deck();
            Deal();
            _players[0].SortHand();
        }

        /// <summary>
        /// Retorna uma string com a descrição da mão do jogador e das cartas do monte.
        /// </summary>
        /// <returns>Retorna uma string com a descrição.</returns>
        public string DescribePlayerHands()
        {
            var description = new StringBuilder();
            for (int i = 0; i < _players.Count; i++)
            {
                description.Append(_players[i].Name).Append(" tem ").Append(_players[i].CardCount);
                description.AppendLine(_players[i].CardCount == 1 ? "  carta." : " cartas.");
            }
            description.Append("O monte tem ").Append(_stock.Count).Append(" carta(s) restante(s).");
            return description.ToString();
        }

        /// <summary>
        /// Inicializa o jogo embaralhando as cartas, distribuindo as mãos e definindo os livros.
        /// </summary>
        private void Deal()
        {
            // Será aqui o método A PARTIR DO QUAL o jogo começa - ele será chamado apenas no
            // início do jogo. Ele embaralha o monte, dá cinco cartas para cada jogador e
            // usa um laço foreach para chamar o método PullOutBooks() de cada um.

            _stock.Shuffle();
            foreach (Player player in _players)
            {
                for (int i = 0; i < 5; i++)
                {
                    player.TakeCard(_stock.Deal());
                }
                PullOutBooks(player);
            }
        }

        /// <summary>
        /// Executa um turno do jogo.
        /// </summary>
        /// <param name="selectedPlayerCard">Carta que o jogador selecionou na sua mão.</param>
        /// <returns>Retorna true se o jogo acabou.</returns>
        public bool PlayOneRound(int selectedPlayerCard)
        {
            // Execute um turno do jogo. O parâmetro será a carta que o jogador selecionou
            // na sua mão - recupera seu valor. Então itere por todos os jogadores e chame o
            // método AskForACard() de cada um, começando pelo jogador humano (que deve
            // estar no índice zero na lista de jogadores. Certifique-se de que ele pergunte
            // pelo valor da carta que selecionou. Então chame PullOutBooks() - se ele retornar
            // true, o jogador ficou sem cartas e precisa comprar uma nova mão. Depois que todos
            // jogaram, ordene a mão do jogador humano (para que ela apareça bem arrumada no
            // formulário). Verifique se o monte ainda tem cartas. Se não tem, apague o texto
            // da caixa e escreva "O monte está sem cartas. O jogo acabou!" e retorne true.
            // Se não for o caso, o jogo ainda não acabou, logo retorne false.

            //_players[0].AskForACard(_players, selectedPlayerCard, _stock);
            for (int i = 0; i < _players.Count; i++)
            {
                Card.Values cardToAskFor = _players[0].Peek(selectedPlayerCard).Value;
                if (i == 0)
                {
                    _players[0].AskForACard(_players, 0, _stock, cardToAskFor);
                }
                else
                {
                    _players[0].AskForACard(_players, i, _stock);
                }
                if (PullOutBooks(_players[i]))
                {
                    _textBoxOnForm.Text += $"{_players[i].Name} fez uma nova mão\n";
                    int maxCards = _stock.Count < 5 ? _stock.Count : 5;
                    for (int j = 0; j < maxCards; j++)
                    {
                        _players[i].TakeCard(_stock.Deal());
                    }
                }
            }
            _players[0].SortHand();
            if (_stock.Count == 0)
            {
                _textBoxOnForm.Text = "O monte está sem cartas. O jogo acabou!";
                return true;
            }

            return false;
        }

        /// <summary>
        /// Monta um livro para o jogador.
        /// </summary>
        /// <param name="player">Jogador.</param>
        /// <returns>Retorna true se o jogador ficar sem cartas.</returns>
        public bool PullOutBooks(Player player)
        {
            // Monte um livro para um jogador. Retorne true se o jogador ficar sem cartas. Se
            // não for o caso, retorne false. Cada livro deve ser adicionado ao dicionário
            // _books. Um jogador fica sem cartas quando usar todas as suas restantes para
            // montar um livro - e assim tentar ganhar o jogo.

            foreach (Card.Values book in player.PullOutBooks())
            {
                _books.Add(book, player);
            }
            return player.CardCount == 0;
        }

        /// <summary>
        /// Descreve os livros de todos examinando o dicionário Books.
        /// </summary>
        /// <returns>Retorna uma string com os livros.</returns>
        public string DescribeBooks()
        {
            // Retorna uma longa string que descreve os livros de todos, composta examinando
            // o dicionário _books. "João tem um livro de seis. (quebra de linha) Edu tem um
            // livro de Ases".

            var description = new StringBuilder();
            foreach (KeyValuePair<Card.Values, Player> book in _books)
            {
                description.Append(book.Value.Name).Append(" tem um livro de ").Append(book.Key.ToString()).AppendLine(".");
            }
            //////foreach (Card.Values value in _books.Keys)
            //////{
            //////    description.Append(_books[value].Name).Append(" tem um livro de ").Append(Card.Plural(value)).AppendLine(".");
            //////}
            return description.ToString();
        }

        /// <summary>
        /// Determina o(s) nome(s) do(s) vencedor(es).
        /// </summary>
        /// <returns>Retorna uma string com a descrição dos vencedores.</returns>
        public string GetWinnerName()
        {
            // Este método será chamado no final do jogo. Ele usa seu próprio dicionário
            // Dictionary<string, int> winners) para determinar quantos livros cada jogador
            // acrescentou no dicionário _books. Primeiro ele usa um laço foreach em Book.Keys
            // foreach(Card.Values value in _books.Keys) - para povoar seu dicionário winners
            // (vencedores) com a quantidade de livros de cada um. Então ele itera por esse
            // dicionário para encontrar o maior número de livros, o que determina o vencedor.
            // E finalmente ele faz uma última passagem por winners para montar uma string
            // com o nome dos vencedores ("João e Edu", por exemplo). Se temos um único
            // vencedor, ele deve retornar uma string como "Edu com três livros". Se temos mais
            // de um, ele deve retornar algo como "um empate entre João e Beto com 2 livros".

            var winners = new Dictionary<string, int>();
            foreach (Card.Values value in _books.Keys)
            {
                string name = _books[value].Name;
                if (winners.ContainsKey(name))
                {
                    winners[name]++;
                }
                else
                {
                    winners.Add(name, 1);
                }
            }

            int maxBooks = 0;
            bool tie = false;
            var description = new StringBuilder();

            foreach (string name in winners.Keys)
            {
                if (winners[name] > maxBooks)
                {
                    maxBooks = winners[name];
                }
            }

            foreach (string name in winners.Keys)
            {
                if (winners[name] == maxBooks)
                {
                    if (!string.IsNullOrEmpty(description.ToString()))
                    {
                        description.Append(" e ");
                        tie = true;
                    }
                    description.Append(name);
                }
            }

            description.Append("com ").Append(maxBooks).Append(" livros.");

            return tie ? description.Insert(0, "Um empate entre ").ToString() : description.ToString();
        }
    }
}