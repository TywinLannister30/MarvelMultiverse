using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class TraitManager(ITraitSelector originSelector) : ITraitManager
{
    public List<Trait> GetAll()
    {
        return originSelector.GetTraits();
    }

    public List<string> GetAllNames()
    {
        return [.. originSelector.GetTraits().Select(x => x.Name)];
    }

    public Trait Get(string name)
    {
        return originSelector.GetTrait(name);
    }
}
