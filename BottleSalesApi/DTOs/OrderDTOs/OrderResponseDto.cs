using BottleSalesApi.DTOs.OrderItemDTOs;

namespace BottleSalesApi.DTOs.OrderDTOs;

public class OrderResponseDto
{
    public OrderResponseDto(int id, string? customerName, DateTime orderDate, decimal totalAmount, List<OrderItemResponseDto>? orderItems)
    {
        Id = id;
        CustomerName = customerName;
        OrderDate = orderDate;
        TotalAmount = totalAmount;
        OrderItems = orderItems;
    }

    public int Id { get; set; }
    public string? CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<OrderItemResponseDto>? OrderItems { get; set; }
}