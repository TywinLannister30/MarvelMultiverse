using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class Power
{
    public string Name { get; set; }

    public string Description { get; set; }

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
    public int HealthDamageReductionModifier { get; set; }

    [JsonIgnore]
    public bool MeleeInsteadOfAgilityForDefence { get; set; }

    [JsonIgnore]
    public bool FlySpeed { get; set; }

    [JsonIgnore]
    public bool JumpSpeed { get; set; }

    [JsonIgnore]
    public bool JumpSpeedMultipliedByRank { get; set; }
}
