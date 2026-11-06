using BottleSalesApi.Data;
using BottleSalesApi.DTOs.OrderDTOs;
using BottleSalesApi.DTOs.OrderItemDTOs;
using Microsoft.EntityFrameworkCore;

namespace BottleSalesApi.Services;

public class OrdersService : IOrdersService
{

    private readonly AppDbContext _context;

    public OrdersService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<OrderResponseDto?> GetByIdAsync(int id)
    {
        var order = await _context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).FirstOrDefaultAsync(o => o.Id == id);

        if(order == null) 
            return null;

        List<OrderItemResponseDto> items = order.OrderItems.Select(item => new OrderItemResponseDto(item.Id, item.Quantity, item.UnitPrice, item.ProductId, item.Product.Name, item.UnitPrice)).ToList();

        
        return new OrderResponseDto(order.Id, order.CustomerName, order.OrderDate, order.TotalAmount, items);
    }

    public Task<List<OrderResponseDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
    public Task<OrderResponseDto> CreateAsync(CreateOrderDto createOrderDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(int id, UpdateOrderDto updateOrderDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}