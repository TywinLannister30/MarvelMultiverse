using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors;

namespace MarvelMultiverse.Managers;

public class OccupationManager(IOccupationSelector occupationSelector) : IOccupationManager
{
    public List<Occupation> GetAll()
    {
        return occupationSelector.GetOccupations();
    }

    public List<string> GetAllNames()
    {
        return [.. occupationSelector.GetOccupations().Select(x => x.Name)];
    }

    public Occupation Get(string name)
    {
        return occupationSelector.GetOccupation(name);
    }
}
