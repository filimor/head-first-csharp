namespace ExploreTheHouse
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string PlaceToHide { get; }

        public OutsideWithHidingPlace(string name, bool hot, string placeToHide) : base(name, hot)
        {
            PlaceToHide = placeToHide;
        }
    }
}
