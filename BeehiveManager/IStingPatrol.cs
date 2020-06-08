namespace BeehiveManager
{
    public interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLenght { get; set; }

        bool LookForEnemies();

        int SharpenStinger(int lenght);

        void Sting();
    }
}