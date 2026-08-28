using Microsoft.AspNetCore.Mvc;
using EnterprisePlatform.API.Models;
using EnterprisePlatform.API.Services;

namespace EnterprisePlatform.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitizenController : ControllerBase
{
    private readonly ICitizenService _citizenService;

    public CitizenController(ICitizenService citizenService)
    {
        _citizenService = citizenService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Citizen>>> GetAll()
    {
        var citizens = await _citizenService.GetAllCitizensAsync();
        return Ok(citizens);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Citizen>> GetById(Guid id)
    {
        var citizen = await _citizenService.GetCitizenByIdAsync(id);
        if (citizen == null) return NotFound();
        return Ok(citizen);
    }

    [HttpPost]
    public async Task<ActionResult<Citizen>> Create(Citizen citizen)
    {
        var created = await _citizenService.CreateCitizenAsync(citizen);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, Citizen citizen)
    {
        var result = await _citizenService.UpdateCitizenAsync(id, citizen);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _citizenService.DeleteCitizenAsync(id);
        if (!result) return NotFound();
        return NoContent();
    }
}
