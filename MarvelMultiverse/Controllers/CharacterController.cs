using MarvelMultiverse.Managers;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMultiverse.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly ICharacterManager _characterManager;

    public CharacterController(ICharacterManager characterManager)
    {
        _characterManager = characterManager;
    }

    [HttpGet]
    public ActionResult<List<Character>> Get()
    {
        return Ok(_characterManager.GetAll());
    }

    [HttpGet("{name}")]
    public ActionResult<Character> GetSingle(string name)
    {
        var character = _characterManager.Get(name);

        if (character == null) return NotFound("No character found.");

        return Ok(character);
    }
}
