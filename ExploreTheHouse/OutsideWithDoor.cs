namespace ExploreTheHouse
{
    public class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription { get; }

        public Location DoorLocation { get; }

        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            DoorDescription = doorDescription;
        }
    }
}
