using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSetSelector
{
    PowerSet GetPowerSet(string name);

    List<PowerSet> GetPowerSets();
}
