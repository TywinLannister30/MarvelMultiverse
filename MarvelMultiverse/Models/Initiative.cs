namespace MarvelMultiverse.Models;

public class Initiative
{
    public int Modifier { get; set; }

    public bool HasEdge { get; set; }

    public string AsString()
    {
        return HasEdge ? $"+{Modifier}E" : $"+{Modifier}";
    }
}
