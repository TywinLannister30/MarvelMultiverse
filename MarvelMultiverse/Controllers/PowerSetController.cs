using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PowerSetController(IPowerSetManager powerSetManager, IPowerManager powerManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<PowerSet>> Get()
    {
        return Ok(powerSetManager.GetAll());
    }

    [HttpGet("name")]
    public ActionResult<List<string>> GetNames()
    {
        return Ok(powerSetManager.GetAllNames());
    }

    [HttpGet("{name}")]
    public ActionResult<PowerSet> GetSingle(string name)
    {
        var powerSet = powerSetManager.Get(name);

        if (powerSet == null) return NotFound("No power set found.");

        return Ok(powerSet);
    }

    [HttpGet("{name}/power")]
    public ActionResult<List<Power>> Get(string name)
    {
        return Ok(powerManager.GetAllByPowerSet(name));
    }

    [HttpGet("{name}/power/name")]
    public ActionResult<List<string>> GetNames(string name)
    {
        return Ok(powerManager.GetAllNamesByPowerSet(name));
    }
}
