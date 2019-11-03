using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoFish
{
    public class Player
    {
        private Random _random;
        private Deck _cards;
        private TextBox _textBoxOnForm;

        public string Name { get; }
        public int CardCount => _cards.Count;
        public string[] CardNames => _cards.GetCardNames();

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            // O construtor para a classe Player inicializa quatro campos private, e então
            // adicionar uma linha no controle TextBox do formulário que diz "João entrou
            // no jogo" - mas use o nome no campo privado e não se esqueça de adicionar
            // uma quebra no fim de cada linha adicionada na caixa de texto.

            Name = name;
            _random = random;
            _cards = new Deck();
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

        }
        

        public Deck DoYouHaveAny(Card.Values value)
        {
            // Um oponente pergunta se o jogador tem cartas de um certo valor
            // usando Deck.PullOutValues() para retirar os valores. Adicione uma
            // linha na caixa de texto que diz "João tem 3 Seis" - use o novo
            // método estático Card.Plural().
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Uma sobrecarga de AskForACard() - escolha um valor aleatório do
            // baralho usando GetRandomValue() e pergunte por ele usando AskForACard().
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Card.Values value)
        {
            // Pergunte para os outros jogadores se eles tem um dado valor. Primeiro adicione
            // uma linha na caixa de texto que diz "João pergunta se alguém tem alguma Rainha",
            // por exemplo. Então itere pela lista de jogadores passada como parâmetro e para
            // cada um deles pergunte se ele tem o valor (usando seu método DoYouHaveAny).
            // Ele deve passar a você um baralho - adicione este ao seu. Mantenha registro
            // de quantas cartas foram adicionadas. Se forem zero, teremos que pegar uma do
            // monte (que também foir passado como parâmetro), e nesse caso uma linha
            // "João tem que pegar uma carta da pilha" deve ser adicionada.
        }
    }
}