using BottleSalesApi.DTOs.ProductDTOs;

namespace BottleSalesApi.Services;

public interface IProductsService
{
    Task<ProductResponseDto?> GetByIdAsync(int id);
    Task<List<ProductResponseDto>> GetAllAsync();
    Task<ProductResponseDto> CreateAsync(CreateProductDto product);
    Task<bool> UpdateAsyc(int id, UpdateProductDto product);
    Task<bool> DeleteAsync(int id);
}