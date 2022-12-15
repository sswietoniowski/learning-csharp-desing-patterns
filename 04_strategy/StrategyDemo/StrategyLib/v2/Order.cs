namespace StrategyLib.v2
{
    public class Order
    {
        private readonly ITaxStrategy _taxStrategy;
        public User User { get; set; }

        public List<OrderItem> Items { get; set; }

        public Order(ITaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        public decimal GetTotalPrice(ITaxStrategy? taxStrategy = null)
        {
            taxStrategy ??= _taxStrategy;

            decimal totalPrice = 0;

            foreach (var item in Items)
            {
                var product = item.Product;

                var tax = taxStrategy.CalculateTax(product);

                totalPrice += (product.Price + tax) * item.Quantity;
            }

            return totalPrice;
        }
    }
}
