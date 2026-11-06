namespace BottleSalesApi.DTOs.ProductDTOs;

public class ProductResponseDto
{

    public ProductResponseDto(int id, string name, string description, decimal price, int stockQuantity, int categoryId, string categoryName)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        StockQuantity = stockQuantity;
        CategoryId = categoryId;
        CategoryName = categoryName;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
}