using CommandLib.v2.Models;

namespace CommandLib.v2.Repositories;

public interface IProductRepository
{
    Product? Get(int id);
    void Add(Product product);
    void Remove(Product product);
}