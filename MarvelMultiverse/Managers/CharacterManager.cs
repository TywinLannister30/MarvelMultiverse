using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class CharacterManager : ICharacterManager
{
    private readonly ICharacterSelector _characterSelector;

    public CharacterManager (ICharacterSelector characterSelector)
    {
        _characterSelector = characterSelector;
    }

    public List<Character> GetAll()
    {
        return _characterSelector.GetCharacters();
    }
}
