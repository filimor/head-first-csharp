namespace ExploreTheHouse
{
    public class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlaceName { get; }

        public override string Description => $"{base.Description} Alguém poderia estar escondido {HidingPlaceName}.";

        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }
    }
}