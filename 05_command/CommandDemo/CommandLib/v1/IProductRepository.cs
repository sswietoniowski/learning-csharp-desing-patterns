namespace CommandLib.v1;

public interface IProductRepository
{
    Product? Get(int id);
    void Add(Product product);
    void Remove(Product product);
}