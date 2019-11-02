using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        private List<Card> _cards;
        private readonly Random _random = new Random();

        public int Count => _cards.Count;

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

        public Deck(Card[] initialCards)
        {
            _cards = new List<Card>(initialCards);
        }

        public void Add(Card cardToAdd)
        {
            _cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = _cards[index];
            _cards.RemoveAt(index);
            return cardToDeal;
        }

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

        public string[] GetCardNames()
        {
            string[] cardNames = new string[_cards.Count];
            for (int i = 0; i < _cards.Count; i++)
            {
                cardNames[i] = _cards[i].Name;
            }
            return cardNames;
        }

        public void Sort()
        {
            _cards.Sort(new CardComparer_bySuit());
        }
    }
}