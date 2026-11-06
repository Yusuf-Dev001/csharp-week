using BottleSalesApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BottleSalesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrdersService _service;

    public OrdersController(IOrdersService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var order = await _service.GetByIdAsync(id);

        if(order == null)
            return NotFound();

        return Ok(order);
    }
}