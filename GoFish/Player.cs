using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoFish
{
    public class Player
    {
        private readonly Random _random;
        private readonly Deck _cards;
        private readonly TextBox _textBoxOnForm;

        public string Name { get; }
        public int CardCount => _cards.Count;

        public string[] GetCardNames()
        {
            return _cards.GetCardNames();
        }

        /// <summary>
        /// Inicializa os campos private e adiciona uma linha no controle TextBox.
        /// </summary>
        /// <param name="name">Nome do jogador.</param>
        /// <param name="random">Número aleatório.</param>
        /// <param name="textBoxOnForm">Caixa de texto no formulário.</param>
        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            // O construtor para a classe Player inicializa quatro campos private, e então adicionar
            // uma linha no controle TextBox do formulário que diz "João entrou no jogo" - mas use o
            // nome no campo privado e não se esqueça de adicionar uma quebra no fim de cada linha
            // adicionada na caixa de texto.

            Name = name;
            _random = random;
            _cards = new Deck(Array.Empty<Card>());
            _textBoxOnForm = textBoxOnForm;
            _textBoxOnForm.Text += $"{Name} entrou no jogo.\n";
        }

        /// <summary>
        /// Gera a lista de livros do jogador.
        /// </summary>
        /// <returns>Lista com os livros do jogador.</returns>
        public List<Card.Values> PullOutBooks()
        {
            var books = new List<Card.Values>();
            for (int i = 0; i <= 13; i++)
            {
                var value = (Card.Values)i;
                int howMany = 0;
                for (int card = 0; card < _cards.Count; card++)
                {
                    if (_cards.Peek(card).Value == value)
                    {
                        howMany++;
                    }
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = _cards.Count; card >= 0; card--)
                    {
                        _cards.Deal(card);
                    }
                }
            }
            return books;
        }

        /// <summary>
        /// Adiciona uma carta à mão do jogador.
        /// </summary>
        /// <param name="card">Carta a ser adicionada.</param>
        public void TakeCard(Card card)
        {
            _cards.Add(card);
        }

        /// <summary>
        /// Espia uma carta de um jogador sem retirá-la da mão.
        /// </summary>
        /// <param name="cardNumber">Índice da carta.</param>
        /// <returns>Carta espiada.</returns>
        public Card Peek(int cardNumber)
        {
            return _cards.Peek(cardNumber);
        }

        /// <summary>
        /// Organiza a mão do jogador.
        /// </summary>
        public void SortHand()
        {
            _cards.Sort();
        }

        /// <summary>
        /// Retorna um valor aleatório que exista no baralho.
        /// </summary>
        /// <returns>Valor de carta aleatório.</returns>
        public Card.Values GetRandomValue()
        {
            Card card = _cards.Peek(_random.Next(_cards.Count));
            return card.Value;
        }

        /// <summary>
        /// Um oponente pergunta se o jogador tem cartas de um certo valor.
        /// </summary>
        /// <param name="value">Valor a ser perguntado.</param>
        /// <returns>Retorna um baralho com as cartas pescadas.</returns>
        public Deck DoYouHaveAny(Card.Values value)
        {
            // Um oponente pergunta se o jogador tem cartas de um certo valor usando
            // Deck.PullOutValues() para retirar os valores. Adicione uma linha na caixa de texto
            // que diz "João tem 3 Seis" - use o novo método estático Card.Plural().

            Deck deck = _cards.PullOutValues(value);
            _textBoxOnForm.Text += $"{Name} tem {deck.Count} {Card.Plural(value)}.\n";
            return deck;
        }

        /// <summary>
        /// Pergunta por um valor aleatório
        /// </summary>
        /// <param name="players">Lista de oponentes.</param>
        /// <param name="myIndex">?</param>
        /// <param name="stock">Cartas no monte.</param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Uma sobrecarga de AskForACard() - escolha um valor aleatório do baralho usando
            // GetRandomValue() e pergunte por ele usando AskForACard().

            AskForACard(players, myIndex, stock, GetRandomValue());
        }

        /// <summary>
        /// Pergunta aos outros jogadores se eles tem um dado valor.
        /// </summary>
        /// <param name="players">Lista de oponentes.</param>
        /// <param name="myIndex">?</param>
        /// <param name="stock">Cartas do monte</param>
        /// <param name="value">Valor a ser perguntado.</param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Card.Values value)
        {
            // Pergunte para os outros jogadores se eles tem um dado valor. Primeiro adicione uma
            // linha na caixa de texto que diz "João pergunta se alguém tem alguma Rainha", por
            // exemplo. Então itere pela lista de jogadores passada como parâmetro e para cada um
            // deles pergunte se ele tem o valor (usando seu método DoYouHaveAny). Ele deve passar a
            // você um baralho - adicione este ao seu. Mantenha registro de quantas cartas foram
            // adicionadas. Se forem zero, teremos que pegar uma do monte (que também foi passado
            // como parâmetro), e nesse caso uma linha "João tem que pegar uma carta da pilha" deve
            // ser adicionada.

            int howMany = 0;
            _textBoxOnForm.Text += $"{Name} pergunta se alguém tem algum(a) {value}.\n";
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck cards = player.DoYouHaveAny(value);
                    howMany += cards.Count;
                    while (cards.Count > 0)
                    {
                        _cards.Add(cards.Deal());
                    }
                }
            }
            if (howMany == 0)
            {
                _textBoxOnForm.Text += $"{Name} tem que pegar uma carta do monte.\n";
                _cards.Add(stock.Deal());
            }
        }
    }
}