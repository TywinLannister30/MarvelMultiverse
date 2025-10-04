using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface IOriginManager
{
    List<Origin> GetAll();

    List<string> GetAllNames();

    Origin Get(string name);
}
