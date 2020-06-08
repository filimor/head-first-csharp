namespace TheMission
{
    public interface IPotion
    {
        // Se o jogador pegar uma poção no nível 2, usá-la e pegar outra no nível 4, o jogo criará
        // duas instâncias diferentes.
        bool Used { get; }
    }
}