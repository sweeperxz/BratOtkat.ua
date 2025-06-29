using BratOtkat.Core;
using BratOtkat.Domain;
using BratOtkat.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BratOtkat.WebApi;

[ApiController]
[Route("api/[controller]")]
public class PositionsController : ControllerBase
{
    private readonly PositionService _service;

    public PositionsController(PositionService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var positions = await _service.GetAllPositionsAsync();
        return Ok(positions);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var position = await _service.GetPositionByIdAsync(id);
        if (position == null) return NotFound();
        return Ok(position);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Position position)
    {
        await _service.AddPositionAsync(position);
        return CreatedAtAction(nameof(Get), new { id = position.Id }, position);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, Position position)
    {
        if (id != position.Id) return BadRequest();
        await _service.UpdatePositionAsync(position);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeletePositionAsync(id);
        return NoContent();
    }
}