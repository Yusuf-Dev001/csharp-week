using BottleSalesApi.DTOs.ProductDTOs;
using BottleSalesApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BottleSalesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    public readonly IProductsService _service;
    public ProductsController(IProductsService service)
    {
        _service = service;
    }

    [HttpGet("{id:int}", Name = "GetProductById")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var product = await _service.GetByIdAsync(id);
        if(product == null)
            return NotFound();
        
        return Ok(product);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateProductDto createProductDto)
    {
        var product = await _service.CreateAsync(createProductDto);
       return CreatedAtRoute(
        "GetProductById",
        new { id = product.Id },
        product
    );
        //StatusCode(201, product);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateProductDto updateProductDto)
    {
        var isUpdated = await _service.UpdateAsyc(id, updateProductDto);

        if(!isUpdated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var isDeleted = await _service.DeleteAsync(id);

        if(!isDeleted)
            return NotFound();

        return NoContent();
        
    }
}
