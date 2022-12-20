namespace CommandLib.v2;

public class ShoppingCartRepository : IShoppingCartRepository
{
    private readonly List<ShoppingCart> _shoppingCarts = new();

    public ShoppingCartRepository()
    {
        _shoppingCarts.Add(new ShoppingCart { Id = 1 });
        _shoppingCarts.Add(new ShoppingCart { Id = 2 });
    }

    public ShoppingCart? Get(int id)
    {
        return _shoppingCarts.FirstOrDefault(x => x.Id == id);
    }

    public void Add(ShoppingCart shoppingCart)
    {
        _shoppingCarts.Add(shoppingCart);
    }

    public void Remove(ShoppingCart shoppingCart)
    {
        _shoppingCarts.Remove(shoppingCart);
    }

    public void AddProduct(int shoppingCartId, Product product)
    {
        var shoppingCart = Get(shoppingCartId);
        if (shoppingCart == null)
        {
            throw new InvalidOperationException("Shopping cart not found");
        }

        var existingItem = shoppingCart.Items.FirstOrDefault(x => x?.Product.Id == product.Id);
        if (existingItem != null)
        {
            throw new InvalidOperationException("Product already exists in shopping cart");
        }

        shoppingCart.Items.Add(new CartItem { Product = product, Quantity = 1 });
    }

    public void IncreaseProductQuantity(int shoppingCartId, int productId)
    {
        var shoppingCart = Get(shoppingCartId);
        if (shoppingCart == null)
        {
            throw new InvalidOperationException("Shopping cart not found");
        }

        var existingItem = shoppingCart.Items.FirstOrDefault(x => x?.Product.Id == productId);
        if (existingItem == null)
        {
            throw new InvalidOperationException("Product not found in shopping cart");
        }

        existingItem.Quantity++;
    }
}