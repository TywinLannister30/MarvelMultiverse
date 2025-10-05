using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class PowerSetManager(IPowerSetSelector powerSetSelector) : IPowerSetManager
{
    public List<PowerSet> GetAll()
    {
        return powerSetSelector.GetPowerSets();
    }

    public List<string> GetAllNames()
    {
        return [.. powerSetSelector.GetPowerSets().Select(x => x.Name)];
    }

    public PowerSet Get(string name)
    {
        return powerSetSelector.GetPowerSet(name);
    }
}
