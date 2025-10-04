using MarvelMultiverse.Constants;
using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class Trait: ICloneable
{
    public Trait()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

    public List<string> Effect { get; set; }

    public List<string> Restrictions { get; set; }

    [JsonIgnore]
    public string Specialization { get; set; }
    
    [JsonIgnore]
    public int MeleeDefenceModifier { get; set; }
    
    [JsonIgnore]
    public int AgilityDefenceModifier { get; set; }

    [JsonIgnore]
    public int FocusModifier { get; set; }

    [JsonIgnore]
    public int RunSpeedModifier { get; set; }

    [JsonIgnore]
    public bool InitiativeEdge { get; set; }

    public string Source {  get; set; }

    public object Clone()
    {
        return new Trait
        {
            Name = this.Name,
            Effect = [.. this.Effect],
            Specialization = this.Specialization,
            MeleeDefenceModifier = this.MeleeDefenceModifier,
            AgilityDefenceModifier = this.AgilityDefenceModifier,
            FocusModifier = this.FocusModifier,
            RunSpeedModifier = this.RunSpeedModifier,
            InitiativeEdge = this.InitiativeEdge,
            Source = this.Source
        };
    }
}
