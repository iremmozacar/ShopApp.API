using System;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderItemCreateDto
{
public int ProductId { get; set; }
public decimal Price { get; set; }
public int Quantity { get; set; }
}