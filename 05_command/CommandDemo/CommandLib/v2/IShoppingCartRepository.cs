﻿namespace CommandLib.v2;

public interface IShoppingCartRepository
{
    ShoppingCart? Get(int id);
    void Add(ShoppingCart shoppingCart);
    void Remove(ShoppingCart shoppingCart);
    public void AddProduct(int shoppingCartId, Product product);
    public void IncreaseProductQuantity(int shoppingCartId, int productId);
}