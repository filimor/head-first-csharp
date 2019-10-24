namespace ExploreTheHouse
{
    public class Outside : Location
    {
        public bool Hot { get; }

        public Outside(string name, bool hot):base(name)
        {
            Hot = hot;
        }
    }
}
