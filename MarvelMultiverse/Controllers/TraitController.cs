using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class TraitController(ITraitManager traitManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Trait>> Get()
    {
        return Ok(traitManager.GetAll());
    }

    [HttpGet("name")]
    public ActionResult<List<string>> GetNames()
    {
        return Ok(traitManager.GetAllNames());
    }

    [HttpGet("{name}")]
    public ActionResult<Trait> GetSingle(string name)
    {
        var trait = traitManager.Get(name);

        if (trait == null) return NotFound("No trait found.");

        return Ok(trait);
    }
}
