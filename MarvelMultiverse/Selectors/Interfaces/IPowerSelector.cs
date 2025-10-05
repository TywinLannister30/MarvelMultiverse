using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IPowerSelector
{
    public Power GetPower(
        string name,
        bool isTech = false,
        bool flySpeed = false,
        bool glideSpeed = false,
        bool swinglineSpeed = false,
        string specialization = null,
        string reminder = null,
        int? meleeDamageModifier = null,
        int? agilityDamageModifier = null);

    public List<Power> GetPowers();
}
