using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class OccupationController(IOccupationManager occupationManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Occupation>> Get()
    {
        return Ok(occupationManager.GetAll());
    }

    [HttpGet("name")]
    public ActionResult<List<string>> GetNames()
    {
        return Ok(occupationManager.GetAllNames());
    }

    [HttpGet("{name}")]
    public ActionResult<Occupation> GetSingle(string name)
    {
        var occupation = occupationManager.Get(name);

        if (occupation == null) return NotFound("No occupation found.");

        return Ok(occupation);
    }
}
