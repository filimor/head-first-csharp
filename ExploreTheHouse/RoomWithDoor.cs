namespace ExploreTheHouse
{
    public class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescription { get; }

        public Location DoorLocation { get; set; }

        public RoomWithDoor(string name, string decoration, string hidingPlace, string doorDescription) : base(name, decoration, hidingPlace)
        {
            DoorDescription = doorDescription;
        }
    }
}