namespace CommandLib.v2.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public List<CartItem> Items { get; set; } = new();
    public decimal Total { get; set; }
}