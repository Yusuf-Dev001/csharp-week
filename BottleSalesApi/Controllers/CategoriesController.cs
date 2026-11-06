using BottleSalesApi.DTOs.CategoryDTOs;
using BottleSalesApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BottleSalesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoriesService _service;

    public CategoriesController(ICategoriesService service)
    {
        _service = service;
    }

    [HttpGet("{id}", Name = "GetCategoryById")]
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
        return  Ok(await _service.GetAllAsync());
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateCategoryDto createCategoryDto)
    {
        var category = await _service.CreateAsync(createCategoryDto);
        
        return CreatedAtRoute(
            "GetCategoryById",
            new { id = category.Id},
            category
        );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, UpdateCategoryDto updateCategoryDto)
    {
        var isUpdated = await _service.UpdateAsync(id, updateCategoryDto);

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