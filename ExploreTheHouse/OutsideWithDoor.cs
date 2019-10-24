namespace ExploreTheHouse
{
    public class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription => throw new System.NotImplementedException();

        public Location DoorLocation => throw new System.NotImplementedException();

        public OutsideWithDoor(string name, bool hot) : base(name, hot)
        {
        }
    }
}
