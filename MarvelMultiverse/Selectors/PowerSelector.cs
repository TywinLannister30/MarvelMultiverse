using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class PowerSelector : IPowerSelector
{
    /*
    public const string Sturdy = "Sturdy";
     */
    public Power GetPower(string name)
    {
        return GetAllPowers().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<Power> GetPowers()
    {
        return GetAllPowers();
    }

    private static List<Power> GetAllPowers() =>
    [
        new()
        {
            Name = PowerNames.Brawling,
            Description = "The character has the moves and is hard to hit.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can use their Melee defense score against Agility attacks too."
            ]
        },
        new()
        {
            Name = PowerNames.CombatTrickery,
            Description = "The character is a tricky one!",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The character makes an attack.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "Once per battle, when the character is attacking targets of equal or higher rank, the character automatically rolls a 1 on their Marvel die, and that die cannot be a­ffected by trouble. If the character is attacking multiple targets, all the targets must be of equal or higher rank."
            ]
        },
        new()
        {
            Name = PowerNames.HealingFactor,
            Description = "The character heals amazingly fast.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "At the end of the character’s turn, they regain Health equal to their Resilience. (This works outside of combat too, quickly bringing them back to full Health.)"
            ]
        },
        new()
        {
            Name = PowerNames.Mighty1,
            Description = "The character is superhumanly strong.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "Treat the character as one size bigger for lifting, carrying, swinging and throwing things. They also add +1 to their Melee damage multiplier, and they gain a +1 bonus to Melee checks other than attacks."
            ],
            MeleeDamageModifier = 1,
            MeleeNonCombatCheckModifier = 1
        },
        new()
        {
            Name = PowerNames.Mighty2,
            Description = "The character could lift a bus.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Mighty 1, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "Treat the character as two sizes bigger for lifting, carrying, swinging and throwing things. They also add +2 to their Melee damage multiplier, and they gain a +2 bonus to Melee checks other than attacks."
            ],
            MeleeDamageModifier = 2,
            MeleeNonCombatCheckModifier = 2
        },
        new()
        {
            Name = PowerNames.Mighty3,
            Description = "The character could lift a house.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Mighty 2, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "Treat the character as three sizes bigger for lifting, carrying, swinging and throwing things. They also add +3 to their Melee damage multiplier, and they gain a +3 bonus to Melee checks other than attacks."
            ],
            MeleeDamageModifier = 3,
            MeleeNonCombatCheckModifier = 3
        },
        new()
        {
            Name = PowerNames.Mighty4,
            Description = "The character is among the strongest there are.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Mighty 3, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "Treat the character as four sizes bigger for lifting, carrying, swinging and throwing things. They also add +4 to their Melee damage multiplier, and they gain a +4 bonus to Melee checks other than attacks."
            ],
            MeleeDamageModifier = 4,
            MeleeNonCombatCheckModifier = 4
        },
        new()
        {
            Name = PowerNames.Sturdy1,
            Description = "The character has protection from physical damage.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character’s body is so sturdy that they have Health Damage Reduction 1.",
                "If this power stems from armor or anything else removable—like Iron Man’s armor—the character should apply the Tech Reliance trait to it."
            ],
            HealthDamageReductionModifier = -1
        },
        new()
        {
            Name = PowerNames.Sturdy2,
            Description = "The character is protected as if by steel.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Sturdy 1, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 2.",
            ],
            HealthDamageReductionModifier = -2
        },
        new()
        {
            Name = PowerNames.Sturdy3,
            Description = "The character is protected like a tank.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Sturdy 2, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 3.",
            ],
            HealthDamageReductionModifier = -3
        },
        new()
        {
            Name = PowerNames.Sturdy4,
            Description = "The character is protected like a battleship.",
            PowerSet = PowerSetNames.Basic,
            Prerequsites = "Sturdy 3, Rank 6",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 4.",
            ],
            HealthDamageReductionModifier = -4
        },
    ];
}
