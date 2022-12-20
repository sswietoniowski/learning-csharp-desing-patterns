using CommandLib.v2.Models;

namespace CommandLib.v2.Repositories;

public class ProductRepository : IProductRepository
{
    private List<Product> _products = new();

    public ProductRepository()
    {

        _products.Add(new Product { Id = 1, Name = "Product 1", Price = 10, Stock = 5 });
        _products.Add(new Product { Id = 2, Name = "Product 2", Price = 20, Stock = 1 });
        _products.Add(new Product { Id = 3, Name = "Product 3", Price = 30, Stock = 2 });
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

    public void IncreaseStock(int productId)
    {
        var product = Get(productId);
        if (product == null)
        {
            throw new InvalidOperationException("Product not found");
        }

        product.Stock++;
    }

    public void DecreaseStock(int productId)
    {
        var product = Get(productId);
        if (product == null)
        {
            throw new InvalidOperationException("Product not found");
        }

        if (product.Stock == 0)
        {
            throw new InvalidOperationException("Product out of stock");
        }

        product.Stock--;
    }
}