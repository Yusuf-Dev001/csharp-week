namespace BottleSalesApi.DTOs.ProductDTOs;

public class CreateProductDto
{
    public CreateProductDto(string name, string description, decimal price, int stockQuantity, int categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        StockQuantity = stockQuantity;
        CategoryId = categoryId;
    }

    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public int CategoryId { get; set; }
}