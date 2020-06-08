using RacingDay.Properties;

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

        /// <summary>
        /// It returns a string that tells who bet, how much money bet and on which dog ("John bet 8
        /// on dog 4"). If the amount is zero, the bet was not placed ("John didn't bet").
        /// </summary>
        /// <returns>A string that describes the bet.</returns>
        public string GetDescription()
        {
            return Amount > 0 ? $"{Bettor.Name} {Resources.bet} {Amount} " +
                $"{Resources.betPlaced} {Dog}." : $"{Bettor.Name} {Resources.betNotPlaced}.";
        }

        /// <summary>
        /// The parameter gets the winner. If the dog won, it reveals the amount bet. If not, it
        /// returns a negative value equal to the bet amount.
        /// </summary>
        /// <param name="winner">The number of the bettor.</param>
        /// <returns>The amount bet.</returns>
        public int PayOut(int winner)
        {
            return Dog == winner ? Amount : -Amount;
        }
    }
}