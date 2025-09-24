using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface ICharacterSelector
{
    Character GetCharacter(string name);

    List<Character> GetCharacters();
}
