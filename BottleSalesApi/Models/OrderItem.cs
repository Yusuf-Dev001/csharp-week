namespace BottleSalesApi.Models;

public class OrderItem
{
    public OrderItem(int id, int quantity, decimal unitPrice, int productId, int orderId)
    {
        Id = id;
        Quantity = quantity;
        UnitPrice = unitPrice;
        ProductId = productId;
        OrderId = orderId;
    }

    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}