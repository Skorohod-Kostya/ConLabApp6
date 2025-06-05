namespace ConAppTask2
{
    class Ungulate : Mammal
    {
        public int HoofCount { get; set; }

        public Ungulate(string name, string habitat, int population, string furType, int hoofCount)
            : base(name, habitat, population, furType)
        {
            HoofCount = hoofCount >= 2 ? hoofCount : throw new ArgumentException("Ungulates must have at least 2 hooves.");
        }

        public override string GetDescription()
        {
            return $"Ungulate: {Name}, Fur: {FurType}, Hooves: {HoofCount}, Habitat: {Habitat}, Population: {Population}";
        }
    }
}