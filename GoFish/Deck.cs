using System;
using System.Collections.Generic;

namespace GoFish
{
    public class Deck
    {
        private List<Card> _cards;
        private readonly Random _random = new Random();

        public int Count => _cards.Count;

        public Deck()
        {
            // Caso não seja passado um parâmetro, cria um baralho completo

            _cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    _cards.Add(new Card((Card.Suits)suit, (Card.Values)value));
                }
            }
        }

        public Deck(Card[] initialCards)
        {
            // Recebe um único parâmetro: uma matriz de cartas que carrega como
            // baralho inicial

            _cards = new List<Card>(initialCards);
        }

        public void Add(Card cardToAdd)
        {
            // Adiciona uma carta ao baralho.

            _cards.Add(cardToAdd);
        }

        public Card Peek(int cardNumber)
        {
            // Permite espiar uma carta sem ter de pegá-la.

            return _cards[cardNumber];
        }

        public Card Deal()
        {
            // Caso não seja passado nenhum parâmetro, dá a carta do topo do baralho.

            return Deal(0);
        }

        public Card Deal(int index)
        {
            // Retira uma carta do baralho e retorna uma referência pra ela.

            Card cardToDeal = _cards[index];
            _cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            // Embaralha as cartas

            var newCards = new List<Card>();
            while (_cards.Count > 0)
            {
                int cardToMove = _random.Next(_cards.Count);
                newCards.Add(_cards[cardToMove]);
                _cards.RemoveAt(cardToMove);
            }
            _cards = newCards;
        }

        public string[] GetCardNames()
        {
            // Retorna um string array com o nome da cada carta

            string[] cardNames = new string[_cards.Count];
            for (int i = 0; i < _cards.Count; i++)
            {
                cardNames[i] = _cards[i].Name;
            }
            return cardNames;
        }

        public bool ContainsValue(Card.Values value)
        {
            // Procura por cartas de um valor pelo baralho e retorna true se encontrar.

            foreach (Card card in _cards)
            {
                if (card.Value == value)
                {
                    return true;
                }
            }
            return false;
        }

        public Deck PullOutValues(Card.Values value)
        {
            // Procura por qualquer carta com determinado valor, tira-as do baralho e
            // retorna um baralho novo sem aquelas cartas.

            var deckToReturn = new Deck(new Card[] { });
            for (int i = _cards.Count - 1; i >= 0; i--)
            {
                if(_cards[i].Value == value)
                {
                    deckToReturn.Add(Deal(i));
                }
            }
            return deckToReturn;
        }

        public bool HasBook(Card.Values value)
        {
            // Checa o baralho para ver se ele contém um livro de qualquer valor.
            // Retorna true se existir um livro no baralho.

            int numberOfCards = 0;
            foreach (Card card in _cards)
            {
                if(card.Value == value)
                {
                    numberOfCards++;
                } 
            }
            return numberOfCards == 4;
        }

        public void Sort()
        {
            // Ordena o baralho

            _cards.Sort(new CardComparer_byValue());
        }
    }
}