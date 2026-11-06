namespace BottleSalesApi.Models;

public class Order
{
    public Order(string customerName, DateTime orderDate, decimal totalAmount)
    {
        CustomerName = customerName;
        OrderDate = orderDate;
        TotalAmount = totalAmount;
    }

    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}