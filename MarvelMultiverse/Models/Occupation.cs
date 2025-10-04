using MarvelMultiverse.Constants;

namespace MarvelMultiverse.Models;

public class Occupation
{
    public Occupation()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

    public List<string> Description { get; set; }

    public string Examples { get; set; }

    public string Tags { get; set; }

    public string Traits { get; set; }

    public string Source { get; set; }
}
