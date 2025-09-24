using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSelector
{
    Power GetPower(string name);

    public List<Power> GetPowers();
}
