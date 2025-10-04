using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public interface IOriginSelector
{
    Origin GetOrigin(string name);

    List<Origin> GetOrigins();
}
