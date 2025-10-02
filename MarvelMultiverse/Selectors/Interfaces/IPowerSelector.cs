using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSelector
{
    public Power GetPower(
        string name,
        bool isTech = false,
        bool swinglineSpeed = false,
        string specialization = null,
        int? meleeDamageModifier = null,
        int? agilityDamageModifier = null);

    public List<Power> GetPowers();
}
