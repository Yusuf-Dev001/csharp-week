using ProductManagementApi.Models;
using ProductManagementApi.Repositories;

namespace ProductManagementApi.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    } 

    public async Task<List<Product>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Product> CreateAsync(Product product)
    {
        await _repository.AddAsync(product);
        return product;
    }

    public async Task<bool> UpdateAsync(int id, Product product)
    {
        var existing = await _repository.GetByIdAsync(id);

        if (existing == null)
            return false;
        
        existing.Name = product.Name;
        existing.Price = product.Price;

        await _repository.UpdateAsync(existing);
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var existing = await _repository.GetByIdAsync(id);

        if(existing == null)
            return false;

        await _repository.DeleteAsync(existing);
        return true;
    }
}
