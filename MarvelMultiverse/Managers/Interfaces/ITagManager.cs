using MarvelMultiverse.Models;

namespace MarvelMultiverse.Managers;

public interface ITagManager
{
    List<Tag> GetAll();

    List<string> GetAllNames();

    Tag Get(string name);
}
