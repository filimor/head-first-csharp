namespace ExploreTheHouse
{
    public abstract class Location
    {
        public string Name { get; }
        public Location[] Exits { get; set; }

        public virtual string Description
        {
            get
            {
                string description = $"Você está no cômodo {Name}. " +
                    "Você vê saídas para os seguintes lugares:";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += $" {Exits[i].Name}";
                    if (i != Exits.Length - 1)
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
