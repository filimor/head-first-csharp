namespace ExploreTheHouse
{
    public abstract class Location
    {
        public string Name { get; }

        private Location[] _exits;

        public Location[] GetExits()
        {
            return _exits;
        }

        public void SetExits(Location[] value)
        {
            _exits = value;
        }

        public virtual string Description
        {
            get
            {
                string description = $"Você está no cômodo {Name}. " +
                    "Você vê saídas para os seguintes lugares:";
                for (int i = 0; i < GetExits().Length; i++)
                {
                    description += $" {GetExits()[i].Name}";
                    if (i != GetExits().Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }

        protected Location(string name)
        {
            Name = name;
        }
    }
}