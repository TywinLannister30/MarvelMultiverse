using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IIconicItemPowerSelector
{
	IconicItemPower GetIconicItemPower(string name, string reminder = null);

	List<IconicItemPower> GetIconicItemPowers();

	IconicItemPower GetPowersAsIconicItemPower(string name);
}
