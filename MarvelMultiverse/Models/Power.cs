using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class Power : ICloneable
{
    public string Name { get; set; }

    public string Description { get; set; }

    [JsonIgnore]
    public string Specialization { get; set; }

    public List<string> PowerSets { get; set; }

    public string Prerequsites { get; set; }

    public string Action { get; set; }

    public string Trigger { get; set; }

    public string Duration { get; set; }

    public string Range { get; set; }

    public string Cost { get; set; }

    public List<string> Effect { get; set; }

    [JsonIgnore]
    public int MeleeDamageModifier { get; set; }

    [JsonIgnore]
    public int MeleeNonCombatCheckModifier { get; set; }

    [JsonIgnore]
    public int AgilityDamageModifier { get; set; }

    [JsonIgnore]
    public int AgilityNonCombatCheckModifier { get; set; }

    [JsonIgnore]
    public int EgoDamageModifier { get; set; }

    [JsonIgnore]
    public int EgoNonCombatCheckModifier { get; set; }

    [JsonIgnore]
    public int LogicDamageModifier { get; set; }

    [JsonIgnore]
    public int LogicNonCombatCheckModifier { get; set; }

    [JsonIgnore]
    public int HealthDamageReductionModifier { get; set; }

    [JsonIgnore]
    public int FocusDamageReductionModifier { get; set; }

    [JsonIgnore]
    public bool MeleeInsteadOfAgilityForDefence { get; set; }

    [JsonIgnore]
    public bool AgilityInsteadOfMeleeForDefence { get; set; }

    [JsonIgnore]
    public bool ClimbSpeedEqualToBaseSpeed { get; set; }

    [JsonIgnore]
    public bool FlySpeed { get; set; }

    [JsonIgnore]
    public bool JumpSpeed { get; set; }

    [JsonIgnore]
    public bool JumpSpeedMultipliedByRank { get; set; }

    [JsonIgnore]
    public bool RunSpeedMultipliedByRank { get; set; }

    [JsonIgnore]
    public bool SwinglineSpeed { get; set; }

    public bool IsTech { get; set; }

    public object Clone()
    {
        return new Power
        {
            Name = this.Name,
            Specialization = this.Specialization,
            Description = this.Description,
            PowerSets = [.. this.PowerSets],
            Prerequsites = this.Prerequsites,
            Action = this.Action,
            Trigger = this.Trigger,
            Duration = this.Duration,
            Range = this.Range,
            Cost = this.Cost,
            Effect = [.. this.Effect],
            MeleeDamageModifier = this.MeleeDamageModifier,
            MeleeNonCombatCheckModifier = this.MeleeNonCombatCheckModifier,
            AgilityDamageModifier = this.AgilityDamageModifier,
            AgilityNonCombatCheckModifier = this.AgilityNonCombatCheckModifier,
            EgoDamageModifier = this.EgoDamageModifier,
            EgoNonCombatCheckModifier = this.EgoNonCombatCheckModifier,
            LogicDamageModifier = this.LogicDamageModifier,
            LogicNonCombatCheckModifier  = this.LogicNonCombatCheckModifier,
            HealthDamageReductionModifier = this.HealthDamageReductionModifier,
            FocusDamageReductionModifier = this.FocusDamageReductionModifier,
            MeleeInsteadOfAgilityForDefence = this.MeleeInsteadOfAgilityForDefence,
            AgilityInsteadOfMeleeForDefence = this.AgilityInsteadOfMeleeForDefence,
            ClimbSpeedEqualToBaseSpeed = this.ClimbSpeedEqualToBaseSpeed, 
            FlySpeed = this.FlySpeed,
            JumpSpeed = this.JumpSpeed,
            JumpSpeedMultipliedByRank  = this.JumpSpeedMultipliedByRank,
            RunSpeedMultipliedByRank = this.RunSpeedMultipliedByRank,
            SwinglineSpeed = this.SwinglineSpeed,
            IsTech = this.IsTech
        };
    }
}
