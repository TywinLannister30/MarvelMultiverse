using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface ITraitManager
{
    List<Trait> GetAll();

    List<string> GetAllNames();

    Trait Get(string name);
}
