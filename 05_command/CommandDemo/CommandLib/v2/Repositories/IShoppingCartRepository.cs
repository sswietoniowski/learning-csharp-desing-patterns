using CommandLib.v2.Models;

namespace CommandLib.v2.Repositories;

public interface IShoppingCartRepository
{
    ShoppingCart? Get(int id);
    void Add(ShoppingCart shoppingCart);
    void Remove(ShoppingCart shoppingCart);
    void AddProduct(int shoppingCartId, Product product);
    void IncreaseProductQuantity(int shoppingCartId, int productId);
    void RemoveProduct(int shoppingCartId, int productId);
    void DecreaseProductQuantity(int shoppingCartId, int productId);
}