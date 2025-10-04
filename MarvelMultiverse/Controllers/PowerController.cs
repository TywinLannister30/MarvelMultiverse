using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PowerController(IPowerManager powerManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Power>> Get()
    {
        return Ok(powerManager.GetAll());
    }

    [HttpGet("name")]
    public ActionResult<List<string>> GetNames()
    {
        return Ok(powerManager.GetAllNames());
    }

    [HttpGet("{name}")]
    public ActionResult<Power> GetSingle(string name)
    {
        var power = powerManager.Get(name);

        if (power == null) return NotFound("No power found.");

        return Ok(power);
    }
}
