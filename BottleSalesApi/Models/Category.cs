namespace BottleSalesApi.Models;

public class Category
{
    public Category(string name, string? description)
    {

        Name = name;
        Description = description;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}