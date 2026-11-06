public class ProductService
{
    public List<Product> GetProduct()
    {
        return new List<Product>
        {
            new Product(1L, "Laptop", 1200),
            new Product(2L, "Phone", 800)
        };
    }
}