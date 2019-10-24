namespace ExploreTheHouse
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; }
    }
}
