using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class TraitManager(ITraitSelector traitSelector) : ITraitManager
{
    public List<Trait> GetAll()
    {
        return traitSelector.GetTraits();
    }

    public List<string> GetAllNames()
    {
        return [.. traitSelector.GetTraits().Select(x => x.Name)];
    }

    public Trait Get(string name)
    {
        return traitSelector.GetTrait(name);
    }
}
