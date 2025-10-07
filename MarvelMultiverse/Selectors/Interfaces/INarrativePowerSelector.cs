using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface INarrativePowerSelector
{
	NarrativePower GetNarrativePower(string name, string reminder = null);

	List<NarrativePower> GetNarrativePowers();
}
