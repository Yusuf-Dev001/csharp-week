using BottleSalesApi.Data;
using BottleSalesApi.DTOs.CategoryDTOs;
using BottleSalesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BottleSalesApi.Services;

public class CategoriesService : ICategoriesService
{
    private readonly AppDbContext _context;

    public CategoriesService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<CategoryResponseDto?> GetByIdAsync(int id)
    {
        var category = await _context.Categories.FindAsync(id);

        if(category == null)
            return null;

        return new CategoryResponseDto(category.Id, category.Name, category.Description);
    }

    public async Task<List<CategoryResponseDto>> GetAllAsync()
    {
        var categories = await _context.Categories
                                        .Select(c => new CategoryResponseDto(c.Id, c.Name, c.Description)).ToListAsync();

        return categories;
    }

    public async Task<CategoryResponseDto> CreateAsync(CreateCategoryDto createCategoryDto)
    {
        var category = new Category(createCategoryDto.Name, createCategoryDto.Description);

        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return new CategoryResponseDto(category.Id, category.Name, category.Description);
    }

    public async Task<bool> UpdateAsync(int id, UpdateCategoryDto updateCategoryDto)
    {
        var category = await _context.Categories.FindAsync(id);

        if(category == null)
            return false;
        
        category.Name = updateCategoryDto.Name;
        category.Description = updateCategoryDto.Description;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var category = await _context.Categories.FindAsync(id);

        if(category == null) 
            return false;

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        return true;
    }
}