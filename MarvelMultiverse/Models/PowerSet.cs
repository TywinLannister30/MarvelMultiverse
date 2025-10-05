using MarvelMultiverse.Constants;

namespace MarvelMultiverse.Models;

public class PowerSet
{
    public PowerSet()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

    public List<string> Description { get; set; }

    public string Source { get; set; }
}
