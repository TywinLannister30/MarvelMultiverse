using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class IconicItemPowerSelector : IIconicItemPowerSelector
{
	public IconicItemPower GetIconicItemPower(string name, string reminder = null)
	{
		var staticPower = GetAllIconicItemPowers().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

		var power = staticPower.Clone() as IconicItemPower;

		if (!string.IsNullOrEmpty(reminder))
		{
			power.Name += $" ({reminder})";
		}

		return power;
	}

	public List<IconicItemPower> GetIconicItemPowers()
    {
        return GetAllIconicItemPowers();
    }

    public IconicItemPower GetPowersAsIconicItemPower(string name, Power power)
    {
        return new()
        {
            Name = name,
            Effect =
            [
                $"The wielder can use the {name} power."
            ],
            Power = power,
            Source = BookSource.AvengersExpansion
        };
    }

    private static List<IconicItemPower> GetAllIconicItemPowers() =>
    [
        new()
        {
            Name = IconicItemPowerNames.Adamantium,
            Effect =
            [
                "Weapons made with this amazing metal ignore 1 level of Health Damage Reduction, and they cannot be destroyed by normal means. Unless the user has the Healing Factor power, items made with this material must be unattached. If they lose the Healing Factor, they must make a Challenging Resilience check at the end of each week. If they fail it, they lose 1 point of Resilience. If they reach –4 Resilience, they die.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Allspeak,
            Effect =
            [
                "The wielder can understand any spoken language and can be understood by others in their own language as well.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.AntiMetal,
            Effect =
            [
                "Weapons made with this type of Antarctic vibranium from the Savage Land can ignore all Health Damage Reduction that comes from metal. This includes most shields and battle suits. Also, such items cannot be destroyed by normal means.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.AsgardianTransformation,
            Effect =
            [
                "When tapped on the ground, the item can transform the user into a mortal form or an Asgardian form. (The item itself can also transform into an innocuous-looking form to suit the user’s mortal form.) The user’s Asgardian form gains all of the item’s powers. If a non-Asgardian user is separated from the item for more than one minute, they lose the powers the item grants and return to mortal form.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Bandaging,
            Effect =
            [
                "The item instantly stops the wearer from bleeding.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Constructable,
            Effect =
            [
                "The user constructs the item using their own powers. They can regenerate the item at will, without using any actions. Such items cannot be used by others and cannot have any Unattached restrictions.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.DamageSwitch,
            Effect =
            [
                "The item can use its powers to inflict Focus damage instead of Health damage, or vice versa. The type of damage must be declared when the attack is made.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.DarkforceAttack,
            Effect =
            [
                "Each round, the item can make a free Ego attack, doing Focus damage, against a target the item has transported to the Darkforce dimension.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.EffectOptions,
            Effect =
            [
                "The item can have different elemental effects of the user’s choice. If there are only two options, switching between the types costs 5 Focus. If there are more options, switching between types costs one action of any kind (movement, standard or reaction) and 5 Focus. Either way, the switch must be made before the attack.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Glider,
            Effect =
            [
                "Grants the user a Glide Speed equal to double their Run Speed. On its own, without a rider, the item has Flight 1.",
            ],
            FlySpeed = true,
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Godkiller,
            Effect =
            [
                "The item ignores Damage Reduction effects due to Mythic origins.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Mysterium,
            Effect =
            [
                "This metal disrupts magic. If someone is touched with it, any ongoing magic-based effects they are using or affected by end immediately, including instant negation of any such damage reduction or protection. Any checks made for magic-based attacks targeted against someone in a mysterium battle suit or using a mysterium shield automatically fail. In addition, Spider-Sense cannot detect it.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Neganite,
            Effect =
            [
                "A rare material found in Dimension Z that can produce explosive blasts of kinetic energy. A weapon fashioned from it can either ignore 10 points of damage protection or add +1 Health Damage Multiplier. Unlike just about anything else, this actually does stack with other such bonuses. Switching between the two effects costs one action of any kind (movement, standard or reaction) and 5 Focus.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Nuform,
            Effect =
            [
                "A synthetic vibranium created by Roxxon. Weapons made with this amazing metal add +1 Health Damage Multiplier, and unlike just about anything else, this actually does stack with other such bonuses. However, if the item is not exposed to microwave radiation at least once per week, it transforms into anti-metal instead.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.PsychicLink,
            Effect =
            [
                "The user can contact and control the item telepathically. If the item has senses, the user can tap into them. If the item is used remotely, it shares the user’s turn in the initiative order. The user can spend their movement or standard actions to give the item either a movement action or a standard action (or, by spending both actions, both). The item can also use the user’s reaction to react to things that happen to it. However, just like a regular character, the item can only use one standard action per turn.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Ranged,
            Effect =
            [
                "The item allows the user to use a power that normally requires a Melee check at range, requiring an Agility check instead.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.ReducedFocus,
            Effect =
            [
                "Reduces the Focus cost for a particular power by –5.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.ReturnsWhenThrown,
            Effect =
            [
                "If thrown (and unrestrained), the item returns to the user at the start of the user’s next turn.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Reverbium,
            Effect =
            [
                "This extremely rare artificial vibranium amplifies kinetic energy instead of absorbing it. Weapons made with this amazing metal add +1 Health Damage Multiplier, and unlike just about anything else, this actually does stack with other such bonuses. However, it is not nearly as durable as vibranium and can be destroyed by a gadget hacked to do so.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Sacrifice,
            Effect =
            [
                "Any Focus costs required to use the item’s powers must be paid with Health instead.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Salvation,
            Effect =
            [
                "If the user is knocked unconscious, then during what would be the user’s next turn (or turns), the item automatically uses its powers to remove the user from danger, if it can.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Stackable,
            Effect =
            [
                "One of the item’s numbered powers (like Mighty, Sturdy and so on) can stack +1 on top of the same power if the user already has it. For instance, if the item grants +1 Mighty and the user does not have the power, they gain Mighty 1. If the user has Mighty 2, using the item bumps them up to Mighty 3. This cannot go beyond the normal limit for such a power, so a character who already has Mighty 4 cannot gain this benefit.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Summonable,
            Effect =
            [
                "The item can be mentally summoned to the user from any distance, as long as it is in the same dimension. Alternatively, the item can be summoned from another dimension directly to the user. This requires a standard action or reaction.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Swingline,
            Effect =
            [
                "The character gains the swingline movement mode, with a Swingline Speed equal to triple their Run Speed. The reach of their swingline is equal to their Swingline Speed, as is the range if the item is a ranged weapon.",
            ],
            SwinglineSpeed = true,
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Toolkit,
            Effect =
            [
                "The item can contain a single hacked gadget at a time, and its owner has an edge when hacking a gadget for the item. (See Gadget Hacking in Avengers Expansion for the rules on hacking gadgets.)",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Unkillable,
            Effect =
            [
                "As long as the item is not destroyed, the user cannot be permanently killed. Their Health can be reduced to any negative amount, even far beyond the point of death, but they heal normally despite this.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Unmovable,
            Effect =
            [
                "The item can be moved only by those who are able to use it.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Uru,
            Effect =
            [
                "Weapons made with this amazing substance have unlimited range and usually have the Mythic: Asgardian origin. If the item has a restriction related to a quality the user must have (like requiring the Worthy tag or being wise) to wield it, it cannot be lifted by someone without the quality.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Vibranium,
            Effect =
            [
                "Weapons made with this amazing metal add +1 Health Damage Multiplier, and they cannot be destroyed by normal means. Unlike just about anything else, this actually does stack with other such bonuses. The vast majority of vibranium comes from Wakanda.",
            ],
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = IconicItemPowerNames.Weapon,
            Effect =
            [
                "The item is a weapon, and the entry gives the weapon’s details, including its damage multiplier and range. If there are two entries separated by a slash under Damage Multiplier, the first is for Melee attacks, and the second is for Agility attacks. If there are two entries separated by a slash under Range, the first is the weapon’s range for Melee attacks, and the second is the weapon’s range for Agility attacks.",
            ],
            Source = BookSource.AvengersExpansion
        },
    ];
}
