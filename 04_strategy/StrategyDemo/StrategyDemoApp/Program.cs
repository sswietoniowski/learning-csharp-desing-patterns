// calculate total order cost without strategy pattern

using v1 = StrategyLib.v1;
using v2 = StrategyLib.v2;

var product1 = new v1.Product { Name = "Milk", Price = 2.5m, Category = v1.ProductCategory.Food };
var product2 = new v1.Product { Name = "Battery", Price = 10m, Category = v1.ProductCategory.Electronics };

var order = new v1.Order
{
    User = new v1.User { Name = "John Doe", Country = v1.Country.Poland, Email = "jdoe@unknown.pl" },
    Items = new List<v1.OrderItem>
    {
        new v1.OrderItem { Product = product1, Quantity = 3 },
        new v1.OrderItem { Product = product2, Quantity = 1 }
    }
};

Console.WriteLine($"Total price: {order.GetTotalPrice()}");

// calculate total order cost with strategy pattern

var product3 = new v2.Product { Name = "Milk", Price = 2.5m, Category = v2.ProductCategory.Food };
var product4 = new v2.Product { Name = "Battery", Price = 10m, Category = v2.ProductCategory.Electronics };

var taxStrategy = new v2.PolishTaxStrategy();
var order2 = new v2.Order(taxStrategy)
{
    User = new v2.User { Name = "John Doe", Country = v2.Country.Poland, Email = "jdoe@unknown.pl" },
    Items = new List<v2.OrderItem>
    {
        new v2.OrderItem { Product = product3, Quantity = 2 },
        new v2.OrderItem { Product = product4, Quantity = 1 }
    }
};

Console.WriteLine($"Total price: {order2.GetTotalPrice()}");

Console.WriteLine($"Total price: {order2.GetTotalPrice(new v2.GermanTaxStrategy())}");
