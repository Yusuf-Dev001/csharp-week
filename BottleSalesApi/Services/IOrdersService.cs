using BottleSalesApi.DTOs.OrderDTOs;

namespace BottleSalesApi.Services;

public interface IOrdersService
{
    Task<OrderResponseDto?> GetByIdAsync(int id);
    Task<List<OrderResponseDto>> GetAllAsync();
    Task<OrderResponseDto> CreateAsync(CreateOrderDto createOrderDto);
    Task<bool> UpdateAsync(int id, UpdateOrderDto updateOrderDto);
    Task<bool> DeleteAsync(int id);
}