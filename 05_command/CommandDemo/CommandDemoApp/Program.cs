// working with shopping cart and products with a Command pattern

using v1 = CommandLib.v1;

void PrintCartV1(v1.IShoppingCartRepository shoppingCartRepository, int shoppingCartId)
{
    var shoppingCart = shoppingCartRepository.Get(shoppingCartId);
    if (shoppingCart == null)
    {
        Console.WriteLine("Shopping cart not found");
        return;
    }

    Console.WriteLine($"Shopping cart {shoppingCart.Id}");
    foreach (var item in shoppingCart.Items)
    {
        Console.WriteLine($"Product: {item.Product.Name}, Quantity: {item.Quantity}");
    }
}

var shoppingCartRepository = new v1.ShoppingCartRepository();
var productRepository = new v1.ProductRepository();

var product = productRepository.Get(1);

shoppingCartRepository.AddProduct(1, product);
shoppingCartRepository.IncreaseProductQuantity(1, 1);
shoppingCartRepository.IncreaseProductQuantity(1, 1);
shoppingCartRepository.IncreaseProductQuantity(1, 1);

PrintCartV1(shoppingCartRepository, 1);