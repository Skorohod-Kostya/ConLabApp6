namespace ConAppTask1
{
    public class DairyProduct : Product
    {
        private string manufacturer;
        private string milkContent;

        public DairyProduct(string name, DateTime releaseDate, int shelfLifeDays,
                          string price, string manufacturer, string milkContent)
            : base(name, releaseDate, shelfLifeDays, price)
        {
            manufacturer = manufacturer;
            milkContent = milkContent;
        }

        public void SetManufacturer(string manufacturer) => manufacturer = manufacturer;
        public void SetMilkContent(double milkContent) => milkContent = milkContent;

        public override string CheckShelfLife()
        {
            DateTime expiryDate = releaseDate.AddDays(shelfLifeDays);
            string baseResult = base.CheckShelfLife();
            return $"{baseResult} Виробник: {manufacturer}, Массова частка молока: {milkContent}%.";
        }
        public override bool IsUsable()
        {
            DateTime expiryDate = releaseDate.AddDays(shelfLifeDays);
            bool isUsable = DateTime.Now <= expiryDate && milkContent >= 50;
            return isUsable;
        }

        public override string ToString()
        {
            return $"Молочний продукт: {name}, Виробник: {manufacturer}, " +
                   $"Масова частка молока: {milkContent}%, " +
                   $"Дата випуску: {releaseDate.ToShortDateString()}, " +
                   $"Термін придатності: {shelfLifeDays} днів, Ціна: {price:C}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            DairyProduct other = (DairyProduct)obj;
            return base.Equals(other) &&
                   manufacturer == other.manufacturer &&
                   milkContent == other.milkContent;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), manufacturer, milkContent);
        }
    }
}
