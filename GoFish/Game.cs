using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GoFish
{
    public class Game
    {
        private List<Player> _players;
        private Dictionary<Card.Values, Player> _books;
        private Deck _stock;
        private TextBox _textBoxOnForm;

        public string[] PlayerCardNames => _players[0].CardNames;

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

        private void Deal()
        {
            // Será aqui o método A PARTIR DO QUAL o jogo começa - ele será chamado apenas no
            // início do jogo. Ele embaralha o monte, dá cinco cartas para cada jogador e
            // usa um laço foreach para chamar o método PullOutBooks() de cada um.
        }

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
        }

        public bool PullOutBooks(Player player)
        {
            // Monte um livro para um jogador. Retorne true seo jogador ficar sem cartas. Se
            // não for o caso, retorne false. Cada livro deve ser adicionado ao dicionário
            // _books. Um jogador fica sem cartas quando usar todas as suas restantes para
            // montar um livro - e assim tentar ganhar o jogo.
        }

        public string DescribeBooks()
        {
            // Retorna uma longa string que descreve os livros de todos, composta examinando
            // o dicionário _books. "João tem um livro de seis. (quebra de linha) Edu tem um
            // livro de Ases".
        }

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
        }
    }
}