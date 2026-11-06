namespace BottleSalesApi.DTOs.OrderDTOs;

public class UpdateOrderDto
{
    public UpdateOrderDto(string? customerName)
    {
        CustomerName = customerName;
    }

    public string? CustomerName { get; set; }

}