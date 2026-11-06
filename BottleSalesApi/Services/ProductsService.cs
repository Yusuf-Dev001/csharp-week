using Microsoft.EntityFrameworkCore;
using BottleSalesApi.Models;
using BottleSalesApi.Data;
using BottleSalesApi.DTOs.ProductDTOs;

namespace BottleSalesApi.Services;

public class ProductsService : IProductsService
{
    private readonly AppDbContext _context; 

    public ProductsService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ProductResponseDto?> GetByIdAsync(int id)
    {
        //  return await _context.Products
        // .Where(p => p.Id == id)
        // .Select(p => new ProductResponseDto(
        //     p.Id,
        //     p.Name,
        //     p.Description,
        //     p.Price,
        //     p.StockQuantity,
        //     p.CategoryId,
        //     p.Category.Name
        // ))
        // .FirstOrDefaultAsync();

        var product = await _context.Products
                    .Include(p => p.Category)
                    .FirstOrDefaultAsync(p => p.Id == id);
                    
        if (product == null)
            return null;

        var productDto = new ProductResponseDto(
            product.Id, product.Name, product.Description, product.Price, product.StockQuantity, product.CategoryId, product.Category.Name
        );

        return productDto;

    }
    
    public async Task<List<ProductResponseDto>> GetAllAsync()
    {
        return await _context.Products.Select(p =>
                new ProductResponseDto(
                    p.Id, p.Name, p.Description, p.Price, p.StockQuantity, p.CategoryId, p.Category.Name
                )
            ).ToListAsync();
    }

    public async Task<ProductResponseDto> CreateAsync(CreateProductDto createProductDto)
    {
        var productToAdd = new Product(createProductDto.Name, createProductDto.Description, createProductDto.Price, createProductDto.StockQuantity, createProductDto.CategoryId);

        await _context.Products.AddAsync(productToAdd);
        await _context.SaveChangesAsync();

        await _context.Entry(productToAdd)
            .Reference(p => p.Category)
            .LoadAsync();
            
        return new ProductResponseDto(productToAdd.Id, productToAdd.Name, productToAdd.Description, productToAdd.Price, productToAdd.StockQuantity, productToAdd.CategoryId,  productToAdd.Category.Name);
    }

    public async Task<bool> UpdateAsyc(int id, UpdateProductDto updateProductDto)
    {
        var product = await _context.Products.FindAsync(id);

        if(product == null) 
            return false;

        product.Name = updateProductDto.Name;
        product.Price = updateProductDto.Price;
        product.StockQuantity = updateProductDto.StockQuantity;
        product.CategoryId = updateProductDto.CategoryId;

        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);

        if(product == null)
            return false;

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return true;
    }

}