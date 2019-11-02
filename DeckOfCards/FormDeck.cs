using System.Windows.Forms;

namespace DeckOfCards
{
    public partial class FormDeck : Form
    {
        private Deck _deck1 = new Deck();
        private Deck _deck2 = new Deck();

        public FormDeck()
        {
            InitializeComponent();

            // Ao iniciar, o baralho 1 deve ter 10 cartas aleatórieas e o baralho 2
            // deve ser um baralho completo com 52 cartas, ambos ordenados por
            // naipe e valor
        }

        private void ResetDeck(int deckNumber)
        {
            // Esvazia e reinicializa o deck (1 com 10 ou 2 com 52 cartas)
        }

        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                lstDeck1.Items.Clear();
                foreach(string cardName in _deck1.GetCardNames())
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
            RedrawDeck(1);
            ResetDeck(1);
        }

        private void BtnSortDeck2_Click(object sender, System.EventArgs e)
        {
            RedrawDeck(2);
            ResetDeck(2);
        }

        private void BtnShuffleDeck1_Click(object sender, System.EventArgs e)
        {
            _deck1.Shuffle();
            RedrawDeck(1);
        }

        private void btnShuffleDeck2_Click(object sender, System.EventArgs e)
        {
            _deck2.Shuffle();
            RedrawDeck(2);
        }
    }
}