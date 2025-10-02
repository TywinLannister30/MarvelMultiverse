namespace MarvelMultiverse.Models;

public class Height
{
    public int Feet { get; set; }

    public int Inches { get; set; }

    public bool IsVariable { get; set; }

    public bool IsUnknown { get; set; }

    public string GetString() 
    {
        var retVal = string.Empty;

        if (IsVariable)
            return "Varies";

        if (Feet > 0)
             retVal = $"{Feet}'";

        if (Inches > 0)
            retVal += $"{Inches}\"";

        return retVal ;
    }
}
