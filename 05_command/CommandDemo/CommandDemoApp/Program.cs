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

if (product.Stock == 0)
{
    throw new InvalidOperationException("Product out of stock");
}
shoppingCartRepository.AddProduct(1, product);

shoppingCartRepository.IncreaseProductQuantity(1, 1);
productRepository.DecreaseStock(product.Id);

shoppingCartRepository.IncreaseProductQuantity(1, 1);
productRepository.DecreaseStock(product.Id);

shoppingCartRepository.IncreaseProductQuantity(1, 1);
productRepository.DecreaseStock(product.Id);

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

var addToCartCommand = new v2.Commands.AddToCartCommand(shoppingCartRepositoryV2, productRepositoryV2, 1, productV2);
var increaseQuantityCommand = new v2.Commands.ChangeQuantityCommand(v2.Commands.Operation.Increase, shoppingCartRepositoryV2, productRepositoryV2, 1, 1);

commandManager.Invoke(addToCartCommand);
commandManager.Invoke(increaseQuantityCommand);
commandManager.Invoke(increaseQuantityCommand);
commandManager.Invoke(increaseQuantityCommand);

PrintCartV2(shoppingCartRepositoryV2, 1);

commandManager.Undo(); // we could also use try-catching and call Undo() in case of an exception

PrintCartV2(shoppingCartRepositoryV2, 1);