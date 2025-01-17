using System;
using ArgentoApp.Shared.DTOs.Categories;
namespace ArgentoApp.Shared.DTOs.ProductDTOs;

public class ProductDto
{
public int Id { get; set; }
public string Name { get; set; }
public bool IsActive { get; set; }  
public string Url { get; set; }
public string Properties { get; set; }  
public decimal Price { get; set; }
public string ImageUrl { get; set; }
public bool IsHome { get; set; }    
public int CategoryId { get; set; }
    public ArgentoApp.Shared.DTOs.Categories.CategoryDto Category { get; set; }
}
