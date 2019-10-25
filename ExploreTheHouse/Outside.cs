namespace ExploreTheHouse
{
    public class Outside : Location
    {
        public bool Hot { get; }

        public override string Description => Hot ? $"{base.Description} Está muito quente aqui." :
            base.Description;

        public Outside(string name, bool hot) : base(name)
        {
            Hot = hot;
        }
    }
}