namespace ExploreTheHouse
{
    public class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription { get; }

        public Location DoorLocation { get; set; }

        public override string Description => $"{base.Description} Você pode ver {DoorDescription} aqui.";

        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            DoorDescription = doorDescription;
        }
    }
}