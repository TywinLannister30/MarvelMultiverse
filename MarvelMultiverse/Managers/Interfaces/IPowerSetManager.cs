using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface IPowerSetManager
{
    List<PowerSet> GetAll();

    List<string> GetAllNames();

    PowerSet Get(string name);
}
