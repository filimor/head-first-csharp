namespace ExploreTheHouse
{
    public class RoomWithDoor:Room,IHasExteriorDoor
    {
        public string DoorDescription => throw new System.NotImplementedException();

        public Location DoorLocation => throw new System.NotImplementedException();

        public RoomWithDoor(string name, string decoration) : base(name, decoration)
        {
        }
    }
}
