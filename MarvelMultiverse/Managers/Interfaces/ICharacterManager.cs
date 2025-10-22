using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface ICharacterManager
{
    List<Character> GetAll();

    List<string> GetAllNames();

    Character Get(string name);
}
