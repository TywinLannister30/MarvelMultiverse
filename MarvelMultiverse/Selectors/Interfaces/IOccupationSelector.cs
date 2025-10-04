using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IOccupationSelector
{
    Occupation GetOccupation(string name);

    List<Occupation> GetOccupations();
}
