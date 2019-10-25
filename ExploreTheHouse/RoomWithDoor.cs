namespace ExploreTheHouse
{
    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription { get; }

        public Location DoorLocation { get; set; }

        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }
    }
}