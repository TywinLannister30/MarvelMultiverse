



using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using System.Security.Claims;

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

    public List<PowerSet> Powers { get; set; }

    public Biography Biography { get; set; }

    public void SetDefences()
    {
        var meleeDefence = Abilities.Melee.Score + 10 + Traits.Sum(x => x.MeleeDefenceModifier);
        var agilityDefence = Abilities.Agility.Score + 10 + Traits.Sum(x => x.AgilityDefenceModifier);
        var resilienceDefence = Abilities.Resilience.Score + 10;
        var vigilanceDefence = Abilities.Vigilance.Score + 10;
        var egoDefence = Abilities.Ego.Score + 10;
        var logicDefence = Abilities.Logic.Score + 10;

        if (Powers.Any(x => x.Powers.Any(p => p.AgilityInsteadOfMeleeForDefence)))
            Abilities.Melee.Defence = agilityDefence;
        else
            Abilities.Melee.Defence = meleeDefence;

        if (Powers.Any(x => x.Powers.Any(p => p.MeleeInsteadOfAgilityForDefence)))
            Abilities.Agility.Defence = meleeDefence;
        else
            Abilities.Agility.Defence = agilityDefence;

        Abilities.Resilience.Defence = resilienceDefence;

        Abilities.Vigilance.Defence = vigilanceDefence;

        Abilities.Ego.Defence = egoDefence;

        Abilities.Logic.Defence = logicDefence;

        if (Biography.Size == Size.Huge)
        {
            Abilities.Melee.Defence -= 2;
            Abilities.Agility.Defence -= 2;
        }
    }

    public void SetHealth()
    {
        var health = Abilities.Resilience.Score * 30;

        if (health < 10) health = 10;

        Health = new DamageCapacity
        {
            Value = health,
            DamageReduction = Powers.Sum(x => x.Powers.Sum(p => p.HealthDamageReductionModifier))
        };
    }

    public void SetFocus()
    {
        var focus = Abilities.Vigilance.Score * 30;

        if (focus < 10) focus = 10;

        focus += Traits.Sum(x => x.FocusModifier);

        Focus = new DamageCapacity
        {
            Value = focus,
            DamageReduction = Powers.Sum(x => x.Powers.Sum(p => p.FocusDamageReductionModifier))
        };
    }

    public void SetKarma()
    {
        var karma = 0;

        if (Tags != null && Tags.Any(x => x.Name == TagNames.Heroic))
        {
            karma = Rank;
        }

        Karma = karma;
    }

    public void SetInitiative()
    {
        Initiative = new Initiative
        {
            Modifier = Abilities.Vigilance.Score,
            HasEdge = Traits.Any(x => x.InitiativeEdge)
        };
    }

    public void SetSpeed()
    {
        var baseSpeed = 5 + Traits.Sum(x => x.RunSpeedModifier);

        baseSpeed += Abilities.Agility.Score / 5;

        if (Biography.Size == Size.Huge)
            baseSpeed *= 5;

        Speed = new Speeds
        {
            Run = baseSpeed,
        };

        if (Powers.Any(x => x.Powers.Any(p => p.RunSpeedMultipliedByRank)))
            Speed.Run = baseSpeed * Rank;

        Speed.Climb = (int)Math.Ceiling(Speed.Run / 2.0);
        Speed.Swim = (int)Math.Ceiling(Speed.Run / 2.0);
        Speed.Jump = (int)Math.Ceiling(Speed.Run / 2.0);

        if (Powers.Any(x => x.Powers.Any(p => p.ClimbSpeedEqualToBaseSpeed)))
        {
            Speed.Climb = baseSpeed;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.FlySpeed)))
        {
            Speed.Flight = baseSpeed * Rank;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.JumpSpeed)))
        {
            Speed.Jump = baseSpeed;

            if (Powers.Any(x => x.Powers.Any(p => p.JumpSpeedMultipliedByRank)))
                Speed.Jump = baseSpeed * Rank;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.SwinglineSpeed)))
        {
            Speed.Swingline = baseSpeed * 3;
        }
    }

    public void SetNonCombatCheckModifiers()
    {
        Abilities.Melee.NonCombatCheck = Abilities.Melee.Score + Powers.Sum(x => x.Powers.Sum(p => p.MeleeNonCombatCheckModifier));
        Abilities.Agility.NonCombatCheck = Abilities.Agility.Score + Powers.Sum(x => x.Powers.Sum(p => p.AgilityNonCombatCheckModifier));
        Abilities.Resilience.NonCombatCheck = Abilities.Resilience.Score;
        Abilities.Vigilance.NonCombatCheck = Abilities.Vigilance.Score;
        Abilities.Ego.NonCombatCheck = Abilities.Ego.Score + Powers.Sum(x => x.Powers.Sum(p => p.EgoNonCombatCheckModifier));
        Abilities.Logic.NonCombatCheck = Abilities.Logic.Score + Powers.Sum(x => x.Powers.Sum(p => p.LogicNonCombatCheckModifier));
    }

    public void SetDamageModifiers()
    {
        Abilities.Melee.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.MeleeDamageModifier));
        Abilities.Agility.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.AgilityDamageModifier));
        Abilities.Ego.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.EgoDamageModifier));
        Abilities.Logic.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.LogicDamageModifier));

        if (Biography.Size == Size.Huge)
        {
            Abilities.Melee.DamageModifier += 2;
        }
    }
}
