// working with shopping cart and products without a Command pattern

using v1 = CommandLib.v1;
using v2 = CommandLib.v2;

void PrintCartV1(v1.Repositories.IShoppingCartRepository shoppingCartRepository, int shoppingCartId)
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

var shoppingCartRepository = new v1.Repositories.ShoppingCartRepository();
var productRepository = new v1.Repositories.ProductRepository();

var product = productRepository.Get(1)!;

shoppingCartRepository.AddProduct(1, product);
shoppingCartRepository.IncreaseProductQuantity(1, 1);
shoppingCartRepository.IncreaseProductQuantity(1, 1);
shoppingCartRepository.IncreaseProductQuantity(1, 1);

PrintCartV1(shoppingCartRepository, 1);

// working with shopping cart and products with a Command pattern

void PrintCartV2(v2.Repositories.IShoppingCartRepository shoppingCartRepository, int shoppingCartId)
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

var shoppingCartRepositoryV2 = new v2.Repositories.ShoppingCartRepository();
var productRepositoryV2 = new v2.Repositories.ProductRepository();

var productV2 = productRepositoryV2.Get(1)!;

var commandManager = new v2.Commands.CommandManager();

commandManager.Invoke(new v2.Commands.AddToCartCommand(shoppingCartRepositoryV2, 1, productV2));
commandManager.Invoke(new v2.Commands.IncreaseQuantityCommand(shoppingCartRepositoryV2, 1, 1));
commandManager.Invoke(new v2.Commands.IncreaseQuantityCommand(shoppingCartRepositoryV2, 1, 1));
commandManager.Invoke(new v2.Commands.IncreaseQuantityCommand(shoppingCartRepositoryV2, 1, 1));

PrintCartV2(shoppingCartRepositoryV2, 1);

commandManager.Undo();

PrintCartV2(shoppingCartRepositoryV2, 1);