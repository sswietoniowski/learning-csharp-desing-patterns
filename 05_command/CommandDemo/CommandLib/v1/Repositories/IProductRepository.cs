using CommandLib.v1.Models;

namespace CommandLib.v1.Repositories;

public interface IProductRepository
{
    Product? Get(int id);
    void Add(Product product);
    void Remove(Product product);
}