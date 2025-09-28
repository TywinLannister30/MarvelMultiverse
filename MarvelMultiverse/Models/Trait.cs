using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class Trait: ICloneable
{
    public string Name { get; set; }

    public List<string> Effect { get; set; }

    [JsonIgnore]
    public string Specialization { get; set; }
    
    [JsonIgnore]
    public int MeleeDefenceModifier { get; set; }
    
    [JsonIgnore]
    public int AgilityDefenceModifier { get; set; }

    [JsonIgnore]
    public int RunSpeedModifier { get; set; }

    [JsonIgnore]
    public bool InitiativeEdge { get; set; }

    public object Clone()
    {
        return new Trait
        {
            Name = this.Name,
            Effect = [.. this.Effect],
            Specialization = this.Specialization,
            MeleeDefenceModifier = this.MeleeDefenceModifier,
            AgilityDefenceModifier = this.AgilityDefenceModifier,
            RunSpeedModifier = this.RunSpeedModifier,
            InitiativeEdge = this.InitiativeEdge
        };
    }
}
