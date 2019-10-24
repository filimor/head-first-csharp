namespace ExploreTheHouse
{
    public class Room : Location
    {
        public string Decoration { get; }

        public Room(string name, string decoration):base(name)
        {
            Decoration = decoration;
        }
    }
}
