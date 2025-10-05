using MarvelMultiverse.Constants;

namespace MarvelMultiverse.Models;

public class Origin
{
    public Origin()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

    public List<string> Description { get; set; }

    public string Examples { get; set; }

    public string Tags { get; set; }

    public string SuggestedTags { get; set; }


    public string Traits { get; set; }

    public string SuggestedOccupation { get; set; }

    public string Powers { get; set; }

    public string NarrativePowers { get; set; }


    public int MinimumRank { get; set; }

    public string Limitation { get; set; }

    public string Source { get; set; }
}
