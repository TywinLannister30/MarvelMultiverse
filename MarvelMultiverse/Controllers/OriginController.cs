using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class OriginController(IOriginManager originManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Origin>> Get()
    {
        return Ok(originManager.GetAll());
    }

    [HttpGet("name")]
    public ActionResult<List<string>> GetNames()
    {
        return Ok(originManager.GetAllNames());
    }

    [HttpGet("{name}")]
    public ActionResult<Origin> GetSingle(string name)
    {
        var origin = originManager.Get(name);

        if (origin == null) return NotFound("No origin found.");

        return Ok(origin);
    }
}
