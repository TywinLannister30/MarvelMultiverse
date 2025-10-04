using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class TagManager(ITagSelector tagSelector) : ITagManager
{
    public List<Tag> GetAll()
    {
        return tagSelector.GetTags();
    }

    public List<string> GetAllNames()
    {
        return [.. tagSelector.GetTags().Select(x => x.Name)];
    }

    public Tag Get(string name)
    {
        return tagSelector.GetTag(name);
    }
}
