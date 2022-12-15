namespace StrategyLib.v2
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(Product product);
    }
}
