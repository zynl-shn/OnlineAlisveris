﻿using Entities.Dtos;
using Microsoft.AspNetCore.Components;
using OnlineAlisveris.Web.Services.Contracts;
using OnlineAlisveris.Web.Services.Models;

namespace OnlineAlisveris.Web.Pages;

public class ProductDetailsBase : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] public IProductService ProductService { get; set; }

    [Inject] public ICartService CartService { get; set; }

    public DataResult<ProductDto> Product { get; set; } = new DataResult<ProductDto>() { Data = null, Message = null, Success = false };

    protected override async Task OnInitializedAsync()
    {
        Product = await ProductService.GetAllProductDtoByProductId(Id);
    }

    protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
    {
        var cartItemDto = await CartService.Add(cartItemToAddDto);
         
    }
}