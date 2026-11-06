namespace BottleSalesApi.DTOs.OrderItemDTOs;

public class CreateOrderItemDto
{
    public CreateOrderItemDto(int quantity, int productId)
    {
        Quantity = quantity;
        ProductId = productId;
    }

    public int Quantity { get; set; }
    public int ProductId { get; set; }
    
}