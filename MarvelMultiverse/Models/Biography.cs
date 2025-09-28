using MarvelMultiverse.Enums;

namespace MarvelMultiverse.Models;

public class Biography
{
    public string RealName { get; set; }

    public List<Height> Heights { get; set; }

    public List<int> Weights { get; set; }

    public string Gender { get; set; }

    public string Eyes { get; set; }

    public string Hair { get; set; }

    public Size Size { get; set; }

    public string DistinguishingFeatures { get; set; }

    public List<string> Occupations { get; set; }

    public List<string> Origins { get; set; }

    public List<string> Teams { get; set; }

    public string Base { get; set; }

    public List<string> History { get; set; }

    public List<string> Personality { get; set; }
}
