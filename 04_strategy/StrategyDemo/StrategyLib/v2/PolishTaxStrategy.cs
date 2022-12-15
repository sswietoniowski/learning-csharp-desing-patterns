namespace StrategyLib.v2
{
    public class PolishTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(Product product)
        {
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
            
            return product.Price * taxPercentage / 100.0m;
        }
    }
}
