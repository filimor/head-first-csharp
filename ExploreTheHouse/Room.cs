namespace ExploreTheHouse
{
    public class Room : Location
    {
        public string Decoration { get; }

        public override string Description => $"{base.Description} Você pode ver {Decoration} aqui.";

        public Room(string name, string decoration):base(name)
        {
            Decoration = decoration;
        }
    }
}
