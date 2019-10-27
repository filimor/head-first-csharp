namespace ExploreTheHouse
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName { get; }

        public override string Description => $"{base.Description} + Alguém poderia se econder {HidingPlaceName}.";

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }
    }
}