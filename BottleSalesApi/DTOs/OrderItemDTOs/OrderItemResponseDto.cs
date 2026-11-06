namespace BottleSalesApi.DTOs.OrderItemDTOs;

public class OrderItemResponseDto
{
    public OrderItemResponseDto(int id, int quantity, decimal unitPrice, int productId, string? productName, decimal subTotal)
    {
        Id = id;
        Quantity = quantity;
        UnitPrice = unitPrice;
        ProductId = productId;
        ProductName = productName;
        SubTotal = subTotal;
    }

    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public decimal SubTotal { get; set; }
}