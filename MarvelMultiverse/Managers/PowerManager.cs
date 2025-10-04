using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class PowerManager(IPowerSelector powerSelector) : IPowerManager
{
    public List<Power> GetAll()
    {
        return powerSelector.GetPowers();
    }

    public List<string> GetAllNames()
    {
        return [.. powerSelector.GetPowers().Select(x => x.Name)];
    }

    public Power Get(string name)
    {
        return powerSelector.GetPower(name);
    }

    public List<Power> GetAllByPowerSet(string name)
    {
        if (name.Equals(PowerSetNames.Basic, StringComparison.CurrentCultureIgnoreCase))
            return [.. powerSelector.GetPowers().Where(x => x.PowerSets.Count == 0)];
        else
            return [.. powerSelector.GetPowers().Where(x => x.PowerSets.Any(p => p.Equals(name, StringComparison.OrdinalIgnoreCase)))];
    }

    public List<string> GetAllNamesByPowerSet(string name)
    {
        if (name.Equals(PowerSetNames.Basic, StringComparison.CurrentCultureIgnoreCase))
            return [.. powerSelector.GetPowers().Where(x => x.PowerSets.Count == 0).Select(x => x.Name)];
        else
            return [.. powerSelector.GetPowers().Where(x => x.PowerSets.Any(p => p.Equals(name, StringComparison.OrdinalIgnoreCase))).Select(x => x.Name)];
    }
}
