namespace ExploreTheHouse
{
    public class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string PlaceToHide { get; }

        public RoomWithHidingPlace(string name, string decoration, string placeToHide) : base(name, decoration)
        {
            PlaceToHide = placeToHide;
        }
    }
}
