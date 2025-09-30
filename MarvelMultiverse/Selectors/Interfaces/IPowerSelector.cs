using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSelector
{
    Power GetPower(string name, string specialization = null);

    public List<Power> GetPowers();
}
