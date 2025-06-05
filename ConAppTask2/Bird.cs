namespace ConAppTask2
{
    class Bird : Animal
    {
        public bool CanFly { get; set; }

        public Bird(string name, string habitat, int population, bool canFly)
            : base(name, habitat, population)
        {
            CanFly = canFly;
        }

        public override string GetDescription()
        {
            return $"Bird: {Name}, Can Fly: {(CanFly ? "Yes" : "No")}, Habitat: {Habitat}, Population: {Population}";
        }
    }
}