namespace StrategyLib.v2
{
    public class GermanTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(Product product)
        {
            var taxPercentage = 0;

            if (product.Category == ProductCategory.Food)
            {
                taxPercentage = 15;
            }
            else if (product.Category == ProductCategory.Electronics)
            {
                taxPercentage = 15;
            }
            else if (product.Category == ProductCategory.Clothes)
            {
                taxPercentage = 15;
            }

            return product.Price * taxPercentage / 100;
        }
    }
}
