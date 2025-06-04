namespace ConAppTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
            new Product("Хліб", new DateTime(2025, 6, 1), 7, 2.50),
            new DairyProduct("Молоко", new DateTime(2025, 5, 30), 10, 1.20, "Молокія", 3.2),
            new DairyProduct("Йогурт", new DateTime(2025, 6, 2), 14, 1.80, "Данон", 2.5),
            new Product("Яблука", new DateTime(2025, 5, 20), 30, 3.00)
            };

            Console.WriteLine("Інформація про продукти:");
            foreach (Product product in products)
            {
                Console.WriteLine("\n" + product.ToString());
                Console.WriteLine(product.CheckShelfLife());
            }

            Console.WriteLine("\nПеревірка Equals:");
            Product p1 = new Product("Хліб", new DateTime(2025, 6, 1), 7, 2.50);
            Product p2 = new Product("Хліб", new DateTime(2025, 6, 1), 7, 2.50);
            Console.WriteLine($"p1 == p2: {p1.Equals(p2)}");

            DairyProduct dp1 = new DairyProduct("Молоко", new DateTime(2025, 5, 30), 10, 1.20, "Молокія", 3.2);
            DairyProduct dp2 = new DairyProduct("Молоко", new DateTime(2025, 5, 30), 10, 1.20, "Молокія", 3.2);
            Console.WriteLine($"dp1 == dp2: {dp1.Equals(dp2)}");
            Console.WriteLine($"dp1 == p1: {dp1.Equals(p1)}");
        }
    }
}