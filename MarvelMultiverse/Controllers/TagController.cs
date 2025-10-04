using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class TagController(ITagManager tagManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Tag>> Get()
    {
        return Ok(tagManager.GetAll());
    }

    [HttpGet("name")]
    public ActionResult<List<string>> GetNames()
    {
        return Ok(tagManager.GetAllNames());
    }

    [HttpGet("{name}")]
    public ActionResult<Tag> GetSingle(string name)
    {
        var tag = tagManager.Get(name);

        if (tag == null) return NotFound("No tag found.");

        return Ok(tag);
    }
}
