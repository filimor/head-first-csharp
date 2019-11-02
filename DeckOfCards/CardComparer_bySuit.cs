using System.Collections.Generic;

namespace DeckOfCards
{
    public class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            return x.Suit > y.Suit ?
                1 : x.Suit < y.Suit ?
                -1 : x.Value > y.Value ?
                1 : x.Value < y.Value ?
                -1 : 0;
        }
    }
}