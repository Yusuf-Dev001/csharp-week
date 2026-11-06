using BottleSalesApi.DTOs.CategoryDTOs;

namespace BottleSalesApi.Services;

public interface ICategoriesService
{
    Task<CategoryResponseDto?> GetByIdAsync(int id);
    Task<List<CategoryResponseDto>> GetAllAsync();
    Task<CategoryResponseDto> CreateAsync(CreateCategoryDto createCategoryDto);
    Task<bool> UpdateAsync(int id, UpdateCategoryDto updateCategoryDto);
    Task<bool> DeleteAsync(int id);
}