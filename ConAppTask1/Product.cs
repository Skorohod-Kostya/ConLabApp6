namespace ConAppTask1
{
    public class Product
    {
        protected string name;
        protected DateTime releaseDate;
        protected int shelfLifeDays;
        protected string price;

        public Product(string name, DateTime releaseDate, int shelfLifeDays, string price)
        {
            name = name;
            releaseDate = releaseDate;
            shelfLifeDays = shelfLifeDays;
            price = price;
        }

        public void SetName(string name) => name = name;
        public void SetReleaseDate(DateTime date) => releaseDate = date;
        public void SetShelfLife(int days) => shelfLifeDays = days;
        public void SetPrice(string price) => price = price;

        public virtual string CheckShelfLife()
        {
            DateTime expiryDate = releaseDate.AddDays(shelfLifeDays);
            if (DateTime.Now <= expiryDate)
                return $"Продукт '{name}' придатний до {(expiryDate.ToShortDateString())}.";
            return $"Продукт '{name}' прострочений.";
        }
        public virtual bool IsUsable()
        {
            DateTime expiryDate = releaseDate.AddDays(shelfLifeDays);
            return DateTime.Now <= expiryDate;
        }

        public override string ToString()
        {
            return $"Продукт: {name}, Дата випуску: {releaseDate.ToShortDateString()}, " +
                   $"Термін придатності: {shelfLifeDays} днів, Ціна: {price:C}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Product other = (Product)obj;
            return name == other.name &&
                   releaseDate == other.releaseDate &&
                   shelfLifeDays == other.shelfLifeDays &&
                   price == other.price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, releaseDate, shelfLifeDays, price);
        }
    }
}
