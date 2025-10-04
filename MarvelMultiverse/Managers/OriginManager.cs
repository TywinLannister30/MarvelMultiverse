using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class OriginManager(IOriginSelector originSelector) : IOriginManager
{
    public List<Origin> GetAll()
    {
        return originSelector.GetOrigins();
    }

    public List<string> GetAllNames()
    {
        return [.. originSelector.GetOrigins().Select(x => x.Name)];
    }

    public Origin Get(string name)
    {
        return originSelector.GetOrigin(name);
    }
}
