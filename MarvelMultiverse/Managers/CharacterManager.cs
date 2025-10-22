using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class CharacterManager(ICharacterSelector characterSelector) : ICharacterManager
{
    public List<Character> GetAll()
    {
        return characterSelector.GetCharacters();
    }

    public List<string> GetAllNames()
    {
        return [.. characterSelector.GetCharacters().Select(x => x.Name)];
    }

    public Character Get(string name)
    {
        return characterSelector.GetCharacter(name);
    }
}
