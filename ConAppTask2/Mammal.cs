namespace ConAppTask2
{
    class Mammal : Animal
    {
    public string FurType { get; set; }

    public Mammal(string name, string habitat, int population, string furType)
        : base(name, habitat, population)
    {
        FurType = furType;
    }

    public override string GetDescription()
    {
        return $"Mammal: {Name}, Fur: {FurType}, Habitat: {Habitat}, Population: {Population}";
    }
   }
}
