using MarvelMultiverse.Constants;
using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class Tag : ICloneable
{
    public Tag()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

    public List<string> Effect { get; set; }

    public List<string> Restrictions { get; set; }

    [JsonIgnore]
    public string Specialization { get; set; }

    public string Source { get; set; }

    public object Clone()
    {
        return new Tag
        {
            Name = this.Name,
            Effect = [.. this.Effect],
            Restrictions = this.Restrictions != null ? [.. this.Restrictions] : [],
            Specialization = this.Specialization,
            Source = this.Source
        };
    }
}
