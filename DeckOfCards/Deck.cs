using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {
        private List<Card> _cards;
        private Random _random = new Random();

        public int Count => _cards.Count;

        public Deck()
        {
            _cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    _cards.Add(new Card((Card.Suits)suit,(Card.Values)value));
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

        }

        public string[] GetCardNames()
        {

        }

        public void Sort()
        {
            _cards.Sort(new CardComparer_bySuit());
        }
    }
}
