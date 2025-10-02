using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface ITraitSelector
{
    Trait GetTrait(string name, string specialization = null, string reminder = null);

    List<Trait> GetTraits();
}
