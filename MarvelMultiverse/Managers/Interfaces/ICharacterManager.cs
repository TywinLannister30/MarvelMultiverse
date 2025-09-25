using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface ICharacterManager
{
    List<Character> GetAll();

    Character Get(string name);
}
