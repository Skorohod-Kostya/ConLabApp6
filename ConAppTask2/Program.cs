namespace ConAppTask2
{

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Animal[] animals = {
                new Mammal("Tiger", "Asia", 3200, "Striped"),
                new Mammal("Polar Bear", "Arctic", 20000, "White"),
                new Ungulate("Saiga Antelope", "Central Asia", 50000, "Short", 4),
                new Ungulate("Bison", "North America", 30000, "Thick", 4),
                new Bird("Bald Eagle", "North America", 70000, true),
                new Bird("Penguin", "Antarctica", 12000, false)
            };

            Console.WriteLine("Введіть мінімальну чисельність для зникаючих видів: ");
            if (!int.TryParse(Console.ReadLine(), out int minPopulation) || minPopulation < 0)
            {
                throw new ArgumentException("Введіть коректне невід'ємне число.");
            }

            var endangered = animals.Where(a => a.Population < minPopulation).ToList();

            if (endangered.Count == 0)
            {
                Console.WriteLine("Немає видів з чисельністю меншою за вказану.");
            }
            else
            {
                Console.WriteLine("\nЗникаючі види:");
                foreach (var animal in endangered)
                {
                    Console.WriteLine(animal.GetDescription());
                }
            }

            Console.WriteLine("\nУсі тварини:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetDescription());
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Невідома помилка: {ex.Message}");
        }
    }
}
}