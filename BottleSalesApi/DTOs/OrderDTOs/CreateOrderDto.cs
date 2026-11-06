using BottleSalesApi.DTOs.OrderItemDTOs;

namespace BottleSalesApi.DTOs.OrderDTOs;

public class CreateOrderDto
{
    public CreateOrderDto(string? customerName, List<CreateOrderItemDto>? orderItems)
    {
        CustomerName = customerName;
        OrderItems = orderItems;
    }

    public string? CustomerName { get; set; }
    public List<CreateOrderItemDto>? OrderItems { get; set; }
}