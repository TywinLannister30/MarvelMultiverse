using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface ITraitSelector
{
    Trait GetTrait(string name, string specialization = null);

    List<Trait> GetTraits();
}
