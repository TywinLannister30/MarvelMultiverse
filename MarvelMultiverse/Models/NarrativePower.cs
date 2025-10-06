using MarvelMultiverse.Constants;

namespace MarvelMultiverse.Models;

public class NarrativePower 
{
    public NarrativePower()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

    public List<string> Effect { get; set; }

    public string Examples { get; set; }

    public string Source { get; set; }
}
