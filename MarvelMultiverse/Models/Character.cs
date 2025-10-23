using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;

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

    public List<CharacterPowerSet> Powers { get; set; }

    public List<NarrativePower> NarrativePowers { get; set; }

    public List<string> PowerNotes { get; set; }

    public List<IconicItem> IconicItems { get; set; }

    public Biography Biography { get; set; }

    public bool IsHenchman { get; set; }

    public string ImageUrl { get; set; }

    public string Source { get; set; }

    public Character()
    {
        Source = BookSource.Core;
    }

    public void SetDefences()
    {
        var meleeDefence = Abilities.Melee.Score + 10 + Traits.Sum(x => x.MeleeDefenceModifier);
        var agilityDefence = Abilities.Agility.Score + 10 + Traits.Sum(x => x.AgilityDefenceModifier) + Powers.Sum(x => x.Powers.Sum(p => p.AgiltyDefenceModifier));
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

        if (Powers.Any(x => x.Powers.Any(p => p.LogicInsteadOfEgoForDefence)))
            Abilities.Ego.Defence = logicDefence;
        else
            Abilities.Ego.Defence = egoDefence;

        if (Powers.Any(x => x.Powers.Any(p => p.EgoInsteadOfLogicForDefence)))
            Abilities.Logic.Defence = egoDefence;
        else
            Abilities.Logic.Defence = logicDefence;

        if (IconicItems != null)
        {
            agilityDefence += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.AgiltyDefenceModifier));

            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.AgilityInsteadOfMeleeForDefence)))
                Abilities.Melee.Defence = agilityDefence;
            else
                Abilities.Melee.Defence = meleeDefence;

            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.MeleeInsteadOfAgilityForDefence)))
                Abilities.Agility.Defence = meleeDefence;
            else
                Abilities.Agility.Defence = agilityDefence;

            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.LogicInsteadOfEgoForDefence)))
                Abilities.Ego.Defence = logicDefence;
            else
                Abilities.Ego.Defence = egoDefence;

            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.EgoInsteadOfLogicForDefence)))
                Abilities.Logic.Defence = egoDefence;
            else
                Abilities.Logic.Defence = logicDefence;
        }

        if (Biography?.Size == Size.Little)
        {
            Abilities.Melee.Defence += 2;
            Abilities.Agility.Defence += 2;
        }
        if (Biography?.Size == Size.Huge)
        {
            Abilities.Melee.Defence -= 2;
            Abilities.Agility.Defence -= 2;
        }
        if (Biography?.Size == Size.Gigantic)
        {
            Abilities.Melee.Defence -= 3;
            Abilities.Agility.Defence -= 3;
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

        if (IconicItems != null)
        {
            Health.DamageReduction += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.HealthDamageReductionModifier));
        }
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

        if (IconicItems != null)
        {
            Focus.DamageReduction += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.FocusDamageReductionModifier));
        }
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
            HasEdge = Traits.Any(x => x.InitiativeEdge) || Powers.Any(x => x.Powers.Any(p => p.InitiativeEdge))
        };

        if (IconicItems != null)
        {
            Initiative.HasEdge = 
                Traits.Any(x => x.InitiativeEdge) || 
                Powers.Any(x => x.Powers.Any(p => p.InitiativeEdge)) || 
                IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.InitiativeEdge));
        }
    }

    public void SetSpeed()
    {
        var baseSpeed = 5 + Traits.Sum(x => x.RunSpeedModifier);

        baseSpeed += Abilities.Agility.Score / 5;

        var flightBaseSpeed = baseSpeed;

        if (Biography?.Size == Size.Little)
            baseSpeed /= 4;
        if (Biography?.Size == Size.Huge)
            baseSpeed *= 5;
        if (Biography?.Size == Size.Gigantic)
            baseSpeed *= 20;

        Speed = new Speeds
        {
            Run = baseSpeed,
        };

        if (Powers.Any(x => x.Powers.Any(p => p.RunSpeedMultipliedByRank)))
            Speed.Run = baseSpeed * Rank;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.RunSpeedMultipliedByRank)))
                Speed.Run = baseSpeed * Rank;
        }

        Speed.Climb = (int)Math.Ceiling(Speed.Run / 2.0);
        Speed.Swim = (int)Math.Ceiling(Speed.Run / 2.0);
        Speed.Jump = (int)Math.Ceiling(Speed.Run / 2.0);

        if (Powers.Any(x => x.Powers.Any(p => p.ClimbSpeedEqualToBaseSpeed)))
            Speed.Climb = baseSpeed;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.ClimbSpeedEqualToBaseSpeed)))
                Speed.Climb = baseSpeed;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.FlySpeed)) || IconicItems?.Any(i => i.Powers.Any(p => p.FlySpeed)) == true)
            Speed.Flight = flightBaseSpeed * Rank;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.FlySpeed)))
                Speed.Flight = flightBaseSpeed * Rank;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.GlideSpeed)))
            Speed.Glide = baseSpeed * 2;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.GlideSpeed)))
                Speed.Glide = baseSpeed * 2;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.JumpSpeed)))
        {
            Speed.Jump = baseSpeed;

            if (Powers.Any(x => x.Powers.Any(p => p.JumpSpeedMultipliedByRank)))
                Speed.Jump = baseSpeed * Rank;
        }

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.JumpSpeed)))
                Speed.Jump = baseSpeed;

            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.JumpSpeedMultipliedByRank)))
                Speed.Jump = baseSpeed * Rank;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.LevitationSpeed)))
            Speed.Levitation = baseSpeed;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.LevitationSpeed)))
                Speed.Levitation = baseSpeed;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.SwimSpeedMultipliedByRank)))
            Speed.Swim = Speed.Swim * Rank;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.SwimSpeedMultipliedByRank)))
                Speed.Swim = Speed.Swim * Rank;
        }

        if (Powers.Any(x => x.Powers.Any(p => p.SwinglineSpeed)) || IconicItems?.Any(i => i.Powers.Any(p => p.SwinglineSpeed)) == true)
            Speed.Swingline = baseSpeed * 3;

        if (IconicItems != null)
        {
            if (IconicItems.Any(x => x.Powers.Where(x => x.Power != null).Any(p => p.Power.SwinglineSpeed)))
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

        if (IconicItems != null)
        {
            Abilities.Melee.NonCombatCheck += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.MeleeNonCombatCheckModifier));
            Abilities.Agility.NonCombatCheck += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.AgilityNonCombatCheckModifier));
            Abilities.Ego.NonCombatCheck += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.EgoNonCombatCheckModifier));
            Abilities.Logic.NonCombatCheck += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.LogicNonCombatCheckModifier));
        }
    }

    public void SetDamageModifiers()
    {
        Abilities.Melee.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.MeleeDamageModifier));
        Abilities.Agility.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.AgilityDamageModifier));
        Abilities.Ego.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.EgoDamageModifier));
        Abilities.Logic.DamageModifier = Rank + Powers.Sum(x => x.Powers.Sum(p => p.LogicDamageModifier));

        if (IconicItems != null && IconicItems.Count > 0)
        {
            Abilities.Melee.DamageModifier += IconicItems.Sum(i => i.MeleeDamageModifier);
            Abilities.Agility.DamageModifier += IconicItems.Sum(i => i.AgilityDamageModifier);

            Abilities.Melee.DamageModifier += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.MeleeDamageModifier));
            Abilities.Agility.DamageModifier += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.AgilityDamageModifier));
            Abilities.Ego.DamageModifier += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.EgoDamageModifier));
            Abilities.Logic.DamageModifier += IconicItems.Sum(x => x.Powers.Where(x => x.Power != null).Sum(p => p.Power.LogicDamageModifier));
        }

        if (Biography?.Size == Size.Little)
            Abilities.Melee.DamageModifier -= 2;
        if (Biography?.Size == Size.Huge)
            Abilities.Melee.DamageModifier += 2;
        if (Biography?.Size == Size.Gigantic)
            Abilities.Melee.DamageModifier += 3;
    }

    public void SetImageUrl()
    {
        ImageUrl = $"/images/characters/{Name}.jpg";
    }
}
