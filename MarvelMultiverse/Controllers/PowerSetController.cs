using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PowerSetController(IPowerManager powerManager) : ControllerBase
{
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

    //[HttpGet("{name}")]
    //public ActionResult<Power> GetSingle(string name)
    //{
    //    var power = powerManager.Get(name);

    //    if (power == null) return NotFound("No power found.");

    //    return Ok(power);
    //}
}
