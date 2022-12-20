namespace CommandLib.v2;

public interface IProductRepository
{
    Product? Get(int id);
    void Add(Product product);
    void Remove(Product product);
}