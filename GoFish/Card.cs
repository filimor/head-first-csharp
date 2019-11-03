namespace GoFish
{
    public class Card
    {
        public enum Suits
        {
            Espadas,
            Paus,
            Ouros,
            Copas
        }

        public enum Values
        {
            Às = 1,
            Dois = 2,
            Três = 3,
            Quatro = 4,
            Cinco = 5,
            Seis = 6,
            Sete = 7,
            Oito = 8,
            Nove = 9,
            Dez = 10,
            Valete = 11,
            Dama = 12,
            Rei = 13
        }

        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name => $"{Value.ToString()} de {Suit.ToString()}";

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public static string Plural(Values value)
        {
            return value == Values.Às
                ? "Ases"
                : value == Values.Dois || value == Values.Três || value == Values.Seis || value == Values.Dez
                ? value.ToString()
                : value.ToString() + "s";
        }
    }
}