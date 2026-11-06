using BottleSalesApi.DTOs.OrderItemDTOs;

namespace BottleSalesApi.Services;

public interface IOrderItemsService
{
    Task<OrderItemResponseDto> GetByIdAsync(int id);
    Task<List<OrderItemResponseDto>> GetAllAsync();
    Task<OrderItemResponseDto> CreateAsync(CreateOrderItemDto createOrderItemDto);
    Task<bool> DeleteAsync(int id);
}