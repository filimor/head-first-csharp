namespace BeehiveManager
{
    public interface INectarCollector
    {
        double Nectar { get; }

        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
