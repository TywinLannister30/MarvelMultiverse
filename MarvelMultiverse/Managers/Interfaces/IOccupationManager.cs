using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface IOccupationManager
{
    List<Occupation> GetAll();

    List<string> GetAllNames();

    Occupation Get(string name);
}
