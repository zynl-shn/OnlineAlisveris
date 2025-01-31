﻿namespace Entities.Dtos;

public class CartItemDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CartId { get; set; }
    public string ProductName { get; set; }
    public string ProductDesciption { get; set; }
    public string ProductImageURL { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; set; }
    public int Qty { get; set; }
}