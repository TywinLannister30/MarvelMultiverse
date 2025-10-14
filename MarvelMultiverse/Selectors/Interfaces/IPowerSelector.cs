using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSelector
{
    public Power GetPower(
        string name,
        bool isTech = false,
        bool isMagicItem = false,
        string specialization = null,
        string reminder = null);

    public List<Power> GetPowers();
}
