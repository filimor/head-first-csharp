using System;
using System.Collections.Generic;

namespace GoFish
{
    public class Deck
    {
        private List<Card> _cards;
        private readonly Random _random = new Random();

        public int Count => _cards.Count;

        /// <summary>
        /// Cria um baralho completo de 52 cartas.
        /// </summary>
        public Deck()
        {
            _cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    _cards.Add(new Card((Card.Suits)suit, (Card.Values)value));
                }
            }
        }

        /// <summary>
        /// Inicializa o baralho com base em uma matriz de cartas.
        /// </summary>
        /// <param name="initialCards">Matriz de cartas.</param>
        public Deck(Card[] initialCards)
        {
            _cards = new List<Card>(initialCards);
        }

        /// <summary>
        /// Adiciona uma carta ao baralho.
        /// </summary>
        /// <param name="cardToAdd">Carta a ser adicionada.</param>
        public void Add(Card cardToAdd)
        {
            _cards.Add(cardToAdd);
        }

        /// <summary>
        /// Permite espiar uma carta sem ter de pegá-la.
        /// </summary>
        /// <param name="cardNumber">Índice da carta no baralho.</param>
        /// <returns>Carta espiada.</returns>
        public Card Peek(int cardNumber)
        {
            return _cards[cardNumber];
        }

        /// <summary>
        /// Retira uma carta do topo do baralho.
        /// </summary>
        /// <returns>Referência para a carta retirada.</returns>
        public Card Deal()
        {
            return Deal(0);
        }

        /// <summary>
        /// Retira uma carta do baralho e retorna uma referência pra ela.
        /// </summary>
        /// <param name="index">Índice da carta no baralho.</param>
        /// <returns>Referência para a carta retirada.</returns>
        public Card Deal(int index)
        {
            Card cardToDeal = _cards[index];
            _cards.RemoveAt(index);
            return cardToDeal;
        }

        /// <summary>
        /// Embaralha as cartas.
        /// </summary>
        public void Shuffle()
        {
            var newCards = new List<Card>();
            while (_cards.Count > 0)
            {
                int cardToMove = _random.Next(_cards.Count);
                newCards.Add(_cards[cardToMove]);
                _cards.RemoveAt(cardToMove);
            }
            _cards = newCards;
        }

        /// <summary>
        /// Retorna um string array com o nome da cada carta.
        /// </summary>
        /// <returns>String Array com o nome das cartas.</returns>
        public string[] GetCardNames()
        {
            string[] cardNames = new string[_cards.Count];
            for (int i = 0; i < _cards.Count; i++)
            {
                cardNames[i] = _cards[i].Name;
            }
            return cardNames;
        }

        /// <summary>
        /// Procura por cartas de um valor pelo baralho.
        /// </summary>
        /// <param name="value">Valor da carta.</param>
        /// <returns>Retorna true se encontrar a carta.</returns>
        public bool ContainsValue(Card.Values value)
        {
            foreach (Card card in _cards)
            {
                if (card.Value == value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Procura por qualquer carta com determinado valor e tira-as do baralho.
        /// </summary>
        /// <param name="value">Valor da carta</param>
        /// <returns>Retorna um baralho novo sem aquelas cartas.</returns>
        public Deck PullOutValues(Card.Values value)
        {
            var deckToReturn = new Deck(Array.Empty<Card>());
            for (int i = _cards.Count - 1; i >= 0; i--)
            {
                if (_cards[i].Value == value)
                {
                    deckToReturn.Add(Deal(i));
                }
            }
            return deckToReturn;
        }

        /// <summary>
        /// Checa o baralho para ver se ele contém um livro de qualquer valor.
        /// </summary>
        /// <param name="value">Valor da carta</param>
        /// <returns>Retorna true se há um livro no baralho.</returns>
        public bool HasBook(Card.Values value)
        {
            int numberOfCards = 0;
            foreach (Card card in _cards)
            {
                if (card.Value == value)
                {
                    numberOfCards++;
                }
            }
            return numberOfCards == 4;
        }

        /// <summary>
        /// Ordena o baralho
        /// </summary>
        public void Sort()
        {
            _cards.Sort(new CardComparer_byValue());
        }
    }
}