namespace CommandLib.v1;

public class ProductRepository : IProductRepository
{
    private List<Product> _products = new();

    public ProductRepository()
    {

        _products.Add(new Product { Id = 1, Name = "Product 1", Price = 10 });
        _products.Add(new Product { Id = 2, Name = "Product 2", Price = 20 });
        _products.Add(new Product { Id = 3, Name = "Product 3", Price = 30 });
    }

    public Product? Get(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Remove(Product product)
    {
        _products.Remove(product);
    }
}