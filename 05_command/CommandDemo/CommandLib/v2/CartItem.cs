﻿namespace CommandLib.v2;

public class CartItem
{
    public Product Product { get; set; } = default!;
    public int Quantity { get; set; }
}