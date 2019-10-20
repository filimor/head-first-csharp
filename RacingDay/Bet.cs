namespace RacingDay
{
    public class Bet
    {
        public int Amount { get; }
        public int Dog { get; }
        public Guy Bettor { get; }

        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }

        public string GetDescription()
        {
            // Retorna uma sequência de caracteres que diz quem fez a aposta,
            // quanto dinheiro foi apostado e em qual cão ("João apostou 8 no
            // cão 4"). Se a quantidade for zero, a aposta não foi feita
            // ("João não apostou")

            return Amount > 0 ? $"{Bettor.Name} apostou {Amount} reais no cão {Dog}." : $"{Bettor.Name} não apostou.";
        }

        public int PayOut(int winner)
        {
            // O parâmetro deve receber o vencedor da corrida. Se o cão venceu,
            // retorna a quantidade apostada. De outra forma, retorne um valor
            // negativo correspondente ao valor apostado

            return Dog == winner ? Amount : -Amount;
        }
    }
}