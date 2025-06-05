namespace ConAppTask2
{

    abstract class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public int Population { get; set; }

        public Animal(string name, string habitat, int population)
        {
            Name = name;
            Habitat = habitat;
            Population = population >= 0 ? population : throw new ArgumentException("Population cannot be negative.");
        }

        public abstract string GetDescription();

        public override string ToString()
        {
            return $"Name: {Name}, Habitat: {Habitat}, Population: {Population}";
        }
    }
}