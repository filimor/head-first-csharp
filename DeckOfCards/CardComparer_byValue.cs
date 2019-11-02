using System.Collections.Generic;

namespace DeckOfCards
{
    internal class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            return x.Value > y.Value ?
                1 : x.Value < y.Value ?
                -1 : x.Suit > y.Suit ?
                1 : x.Suit < y.Suit ?
                -1 : 0;
        }
    }
}