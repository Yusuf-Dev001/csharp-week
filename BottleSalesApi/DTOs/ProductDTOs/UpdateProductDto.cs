namespace BottleSalesApi.DTOs.ProductDTOs;

public class UpdateProductDto
{
    public UpdateProductDto(string name, string? category, decimal price, int stockQuantity, int categoryId)
    {
        Name = name;
        Category = category;
        Price = price;
        StockQuantity = stockQuantity;
        CategoryId = categoryId;
    }

    public string Name { get; set; }
    public string? Category { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public int CategoryId { get; set; }
}