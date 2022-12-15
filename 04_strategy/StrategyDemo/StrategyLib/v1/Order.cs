namespace StrategyLib.v1
{
    public class Order
    {
        public User User { get; set; }

        public List<OrderItem> Items { get; set; }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in Items)
            {
                var product = item.Product;

                var tax = 0m;
                var taxPercentage = 0;

                if (product.Category == ProductCategory.Food)
                {
                    taxPercentage = 5;
                }
                else if (product.Category == ProductCategory.Electronics)
                {
                    taxPercentage = 15;
                }
                else if (product.Category == ProductCategory.Clothes)
                {
                    taxPercentage = 10;
                }
                tax = product.Price * taxPercentage / 100;

                totalPrice += (product.Price + tax) * item.Quantity;
            }

            return totalPrice;
        }
    }
}
