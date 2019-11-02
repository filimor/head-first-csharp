using System;
using System.Windows.Forms;

namespace DeckOfCards
{
    public partial class FormDeck : Form
    {
        private Deck _deck1;
        private Deck _deck2;
        private Random _random = new Random();

        public FormDeck()
        {
            InitializeComponent();

            // Ao iniciar, o baralho 1 deve ter 10 cartas aleatórieas e o baralho 2
            // deve ser um baralho completo com 52 cartas, ambos ordenados por
            // naipe e valor

            ResetDeck(1);
            RedrawDeck(1);
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber)
        {
            // Esvazia e reinicializa o deck (1 com 10 ou 2 com 52 cartas)

            if (deckNumber == 1)
            {
                int numberOfCards = _random.Next(1, 11);
                _deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    _deck1.Add(new Card((Card.Suits)_random.Next(4),
                        (Card.Values)_random.Next(1, 14)));
                }
                _deck1.Sort();
            }
            else
            {
                _deck2 = new Deck();
            }
        }

        private void RedrawDeck()
        {
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                lstDeck1.Items.Clear();
                foreach (string cardName in _deck1.GetCardNames())
                {
                    lstDeck1.Items.Add(cardName);
                }
                lblDeck1.Text = $"Baralho 1 ({_deck1.Count} cartas)";
            }
            else
            {
                lstDeck2.Items.Clear();
                foreach (string cardName in _deck2.GetCardNames())
                {
                    lstDeck2.Items.Add(cardName);
                }
                lblDeck2.Text = $"Baralho 1 ({_deck2.Count} cartas)";
            }
        }

        private void BtnSortDeck1_Click(object sender, System.EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void BtnSortDeck2_Click(object sender, System.EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void BtnShuffleDeck1_Click(object sender, System.EventArgs e)
        {
            _deck1.Shuffle();
            RedrawDeck(1);
        }

        private void BtnShuffleDeck2_Click(object sender, System.EventArgs e)
        {
            _deck2.Shuffle();
            RedrawDeck(2);
        }

        private void BtnMoveToDeck1_Click(object sender, EventArgs e)
        {
            if (lstDeck2.SelectedIndex >= 0 && _deck2.Count > 0)
            {
                _deck1.Add(_deck2.Deal(lstDeck2.SelectedIndex));
                RedrawDeck();
            }
        }

        private void BtnMoveToDeck2_Click(object sender, EventArgs e)
        {
            if (lstDeck1.SelectedIndex >= 0 && _deck1.Count > 0)
            {
                _deck2.Add(_deck1.Deal(lstDeck1.SelectedIndex));
                RedrawDeck();
            }
        }
    }
}