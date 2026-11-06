public class Product
{
    public long Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product()
    {
        Name = "";
    }

    public Product(long id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}