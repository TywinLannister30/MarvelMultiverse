



using MarvelMultiverse.Constants;

namespace MarvelMultiverse.Models;

public class Character
{
    public string Name { get; set; }

    public int Rank { get; set; }

    public Abilities Abilities { get; set; }

    public DamageCapacity Health { get; set; }

    public DamageCapacity Focus { get; set; }

    public int Karma { get; set; }

    public Initiative Initiative { get; set; }

    public Speeds Speed { get; set; }

    public List<Trait> Traits { get; set; }

    public List<Tag> Tags { get; set; }

    public List<Power> Powers { get; set; }

    public Biography Biography { get; set; }

    public void SetDefences()
    {
        Abilities.Melee.Defence = Abilities.Melee.Score + 10 + Traits.Sum(x => x.MeleeDefenceModifier);
        
        Abilities.Agility.Defence = Abilities.Agility.Score + 10 + Traits.Sum(x => x.AgilityDefenceModifier);
        
        Abilities.Resilience.Defence = Abilities.Resilience.Score + 10;
        
        Abilities.Vigilance.Defence = Abilities.Vigilance.Score + 10;
        
        Abilities.Ego.Defence = Abilities.Ego.Score + 10;
        
        Abilities.Logic.Defence = Abilities.Logic.Score + 10;
    }

    public void SetHealth()
    {
        var health = Abilities.Resilience.Score * 30;

        if (health < 10) health = 10;

        Health = new DamageCapacity
        {
            Value = health,
            DamageReduction = Powers.Sum(x => x.HealthDamageReductionModifier)
        };
    }

    public void SetFocus()
    {
        var focus = Abilities.Vigilance.Score * 30;

        if (focus < 10) focus = 10;

        Focus = new DamageCapacity
        {
            Value = focus,
        };
    }

    public void SetKarma()
    {
        var karma = 0;

        if (Tags != null && Tags.Any(x => x.Name == TagNames.Heroic))
        {
            Karma = Rank;
        }

        Karma = karma;
    }

    public void SetInitiative()
    {
        Initiative = new Initiative
        {
            Modifier = Abilities.Vigilance.Score,
        };
    }

    public void SetSpeed()
    {
        var baseSpeed = 5 + Traits.Sum(x => x.RunSpeedModifier);

        baseSpeed += Abilities.Agility.Score / 5;

        Speed = new Speeds
        {
            Run = baseSpeed,
            Climb = (int)Math.Ceiling(baseSpeed / 2.0),
            Swim = (int)Math.Ceiling(baseSpeed / 2.0),
            Jump = (int)Math.Ceiling(baseSpeed / 2.0),
            Flight = 0
        };
    }

    public void SetNonCombatCheckModifiers()
    {
        Abilities.Melee.NonCombatCheck = Abilities.Melee.Score + Powers.Sum(x => x.MeleeNonCombatCheckModifier);
        Abilities.Agility.NonCombatCheck = Abilities.Agility.Score;
        Abilities.Resilience.NonCombatCheck = Abilities.Resilience.Score;
        Abilities.Vigilance.NonCombatCheck = Abilities.Vigilance.Score;
        Abilities.Ego.NonCombatCheck = Abilities.Ego.Score;
        Abilities.Logic.NonCombatCheck = Abilities.Logic.Score;
    }

    public void SetDamageModifiers()
    {
        Abilities.Melee.DamageModifier = Rank + Powers.Sum(x => x.MeleeDamageModifier);
        Abilities.Agility.DamageModifier = Rank;
        Abilities.Ego.DamageModifier = Rank;
        Abilities.Logic.DamageModifier = Rank;
    }
}
