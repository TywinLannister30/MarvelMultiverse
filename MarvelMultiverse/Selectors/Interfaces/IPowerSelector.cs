using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSelector
{
    Power GetPower(string name, bool isTech = false, string specialization = null);

    public List<Power> GetPowers();
}
