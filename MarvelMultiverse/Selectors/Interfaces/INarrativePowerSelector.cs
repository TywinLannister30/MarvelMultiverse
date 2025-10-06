using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface INarrativePowerSelector
{
    NarrativePower GetNarrativePower(string name);

    List<NarrativePower> GetNarrativePowers();
}
