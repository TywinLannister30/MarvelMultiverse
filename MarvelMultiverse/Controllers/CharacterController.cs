using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CharacterController(ICharacterManager characterManager) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characterManager.GetAll());
    }

    [HttpGet("{name}")]
    public ActionResult<Character> GetSingle(string name)
    {
        var character = characterManager.Get(name);

        if (character == null) return NotFound("No character found.");

        return Ok(character);
    }
}
