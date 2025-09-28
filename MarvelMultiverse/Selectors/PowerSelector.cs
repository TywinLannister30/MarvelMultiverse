using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class PowerSelector : IPowerSelector
{
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
            Name = PowerNames.Accuracy1,
            Description = "The character is an ace with ranged attacks.",
            PowerSets = ["None"],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +1 to their Agility damage multiplier, and they gain a +1 bonus to Agility checks other than attacks.",
            ],
            AgilityDamageModifier = 1,
            AgilityNonCombatCheckModifier = 1
        },
        new()
        {
            Name = PowerNames.Accuracy2,
            Description = "The character is a sharpshooter.",
            PowerSets = ["None"],
            Prerequsites = "Accuracy 1, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +2 to their Agility damage multiplier, and they gain a +2 bonus to Agility checks other than attacks.",
            ],
            AgilityDamageModifier = 2,
            AgilityNonCombatCheckModifier = 2
        },
        new()
        {
            Name = PowerNames.Accuracy3,
            Description = "The character could hit a fly at one hundred paces.",
            PowerSets = ["None"],
            Prerequsites = "Accuracy 2, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +3 to their Agility damage multiplier, and they gain a +3 bonus to Agility checks other than attacks.",
            ],
            AgilityDamageModifier = 3,
            AgilityNonCombatCheckModifier = 3
        },
        new()
        {
            Name = PowerNames.Accuracy4,
            Description = " The character can out-target almost anyone.",
            PowerSets = ["None"],
            Prerequsites = "Accuracy 3, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +4 to their Agility damage multiplier, and they gain a +4 bonus to Agility checks other than attacks.",
            ],
            AgilityDamageModifier = 4,
            AgilityNonCombatCheckModifier = 4
        },
        new()
        {
            Name = PowerNames.AstralForm,
            Description = "The character can enter the Astral Plane.",
            PowerSets = [PowerSetNames.Magic, PowerSetNames.Telepathy],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character can project an avatar into the Astral Plane, leaving their physical body in a deep trance in the real world, where it is vulnerable to attack. While in the Astral Plane, they can interact with other characters in the Astral Plane, but they are intangible, invisible and generally undetectable in the real world. However, they can sense things in the real world. If the character is Rank 4 or higher, they can also take on a transparent form that can be seen in the real world.",
                "While in the Astral Plane, the character can fly, and in combat, their Flight Speed is equal to their rank times their Run Speed. Outside of combat, they can move 10 times as fast."
            ]
        },
        new()
        {
            Name = PowerNames.BangingHeads,
            Description = "The character takes two nearby enemies and slams their heads into each other.",
            PowerSets = [PowerSetNames.MartialArts, PowerSetNames.SuperStrength],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes one Melee check against the Melee defense scores of two enemies within reach. If the attack fails against either foe, it fails entirely. If the attack is a success against both foes, each enemy takes full damage. On a Fantastic success, each enemy is also knocked prone."
            ]
        },
        new()
        {
            Name = PowerNames.BattlePlan,
            Description = "The character always has a plan.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.Inspiration}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.OneRound,
            Cost = "10 Focus",
            Effect =
            [
                "The character inspires one or more allies of their choice in earshot, up to the character’s Vigilance. Inspired allies gain an edge on all action checks until the start of the character’s next turn."
            ]
        },
        new()
        {
            Name = PowerNames.BoltsOfBalthakk,
            Description = "The character fires enchanted bolts of electricity from their fingers.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "20 spaces",
            Cost = "5 or more Focus",
            Effect =
            [
                "The character makes an Ego check with an edge against the Agility defense of a target in their line of sight. For this attack, add +1 to the character’s Ego damage bonus for every 2 points of Focus they spend. On a success, an a­ffected target takes that total damage. On a Fantastic success, an a­ffected target takes double that total damage and is stunned for one round.",
            ]
        },
        new()
        {
            Name = PowerNames.Brawling,
            Description = "The character has the moves and is hard to hit.",
            PowerSets = ["None"],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can use their Melee defense score against Agility attacks too."
            ],
            MeleeInsteadOfAgilityForDefence = true
        },
        new()
        {
            Name = PowerNames.Clobber,
            Description = "The character pummels their foe with enough force to knock them flat.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a close attack against an enemy. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and is knocked prone."
            ]
        },
        new()
        {
            Name = PowerNames.CombatTrickery,
            Description = "The character is a tricky one!",
            PowerSets = ["None"],
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
            Name = PowerNames.CrimsonBandsOfCyttorak,
            Description = "The character unleashes red bands of magic that lash out to capture their target.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "20",
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Ego check with an edge against the Melee defense of a target in their line of sight. If the attack is a success, the crimson bands paralyze the target. On a Fantastic success, the target can be pinned too. Breaking out of the crimson bands requires a Melee check with target number 20.",
            ]
        },
        new()
        {
            Name = PowerNames.CrushingGrip,
            Description = "The character seizes an enemy and squeezes hard.",
            PowerSets = [PowerSetNames.MartialArts, PowerSetNames.SuperStrength],
            Prerequsites = "Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a Melee attack against the grabbed target’s Resilience defense. If it’s a success, the target takes regular damage. On a Fantastic success, the target takes double damage instead and is pinned."
            ]
        },
        new()
        {
            Name = PowerNames.Discipline1,
            Description = "The character works to hone their power.",
            PowerSets = ["None"],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +1 to their Ego damage multiplier, and they gain a +1 bonus to Ego checks other than attacks."
            ],
            EgoDamageModifier = 1,
            EgoNonCombatCheckModifier = 1
        },
        new()
        {
            Name = PowerNames.Discipline2,
            Description = "The character is more in touch with their power than ever.",
            PowerSets = ["None"],
            Prerequsites = "Discipline 1, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +2 to their Ego damage multiplier, and they gain a +2 bonus to Ego checks other than attacks."
            ],
            EgoDamageModifier = 2,
            EgoNonCombatCheckModifier = 2
        },
        new()
        {
            Name = PowerNames.Discipline3,
            Description = "Few can top the character’s grasp on their power.",
            PowerSets = ["None"],
            Prerequsites = "Discipline 2, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +3 to their Ego damage multiplier, and they gain a +3 bonus to Ego checks other than attacks."
            ],
            EgoDamageModifier = 3,
            EgoNonCombatCheckModifier = 3
        },
        new()
        {
            Name = PowerNames.Discipline4,
            Description = "The character has mastered their power.",
            PowerSets = ["None"],
            Prerequsites = "Discipline 3, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +4 to their Ego damage multiplier, and they gain a +4 bonus to Ego checks other than attacks."
            ],
            EgoDamageModifier = 4,
            EgoNonCombatCheckModifier = 4
        },
        new()
        {
            Name = PowerNames.DispelSpell,
            Description = "The character puts an end to a foe’s magic.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes an Ego check against the Ego defense of a target using a magic power that requires concentration. On a success, the target’s concentration on that power is broken. On a Fantastic success, the target’s concentration is broken entirely."
            ],
        },
        new()
        {
            Name = PowerNames.DoubleTap,
            Description = "To be twice as sure.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a ranged attack against an enemy within 2 spaces. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and is bleeding."
            ],
        },
        new()
        {
            Name = PowerNames.EditMemory,
            Description = "The character alters someone’s memory.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "Memory Blip, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Cost = "15 Focus",
            Effect =
            [
                "The character alters the memory of a target with whom they’ve established a Telepathic Link. This can be as simple as erasing a chunk of the target’s memory or as complicated as implanting entirely new memories. The Narrator sets the target number based on how complex the new memory is and how hard it would be to integrate such memories into the character’s other memories.",
                "The character makes a Logic check against the target’s Logic defense. On a success, the memories are altered. On a Fantastic success, the target has trouble on checks to refute such memories in the future.",
                "Any time the target is given good reason to doubt the edited memory, they can make a Logic check to refute the new version of their memories and recover their original memories. If they succeed, they remember both the original memory and the edited one. On a Fantastic success, they know for sure who did this to them."
            ],
        },
        new()
        {
            Name = PowerNames.EnvironmentalProtection,
            Description = "Environmental e£fects don’t bother the character.",
            PowerSets = ["None"],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character is not harmed by intense cold or heat, the pressure of the deep seas or the intense radiation and vacuum of space.",
                "The player can choose any or all of these protections, as best fi ts with the character concept.",
            ],
        },
        new()
        {
            Name = PowerNames.ESP,
            Description = "The character can sense the presence of others.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character can reach out with their mind to sense the presence of others within 100 spaces per rank. This tells them the person’s location and general status. It can also identify if they have super-powers or not.",
                "If a target or targets wish to remain undetected, the character must make a Logic check and compare it against each target’s Vigilance defense. If they succeed, they sense the target. On a Fantastic success, they can also identify they sense the target. On a Fantastic the source of any powers the target has.",
            ],
        },
        new()
        {
            Name = PowerNames.FlamesOfTheFaltine,
            Description = "The character shoots jets of enchanted fi re from their hands.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces",
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego check against the Agility defense of a target in their line of sight. If the attack is a success, it infl icts regular damage. On a Fantastic success, the target takes double damage and then su­ffers 5 points of damage at the end of every round until someone uses an action to put out the flames."
            ],
        },
        new()
        {
            Name = PowerNames.Flight1,
            Description = "The character can soar into the sky.",
            PowerSets = ["None"],
            Prerequsites = "Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can fly. Their combat Flight Speed is equal to their rank times their Run Speed. Outside of combat, they can move three times their Flight Speed."
            ],
            FlySpeed = true
        },
        new()
        {
            Name = PowerNames.Flight2,
            Description = "The character can zoom across the sky.",
            PowerSets = ["None"],
            Prerequsites = "Flight 1, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can fly. Their combat Flight Speed is equal to their rank times their Run Speed. Outside of combat, the character can fly up to 50 times their Flight Speed."
            ],
            FlySpeed = true
        },
        new()
        {
            Name = PowerNames.GroundShakingStomp,
            Description = "The character smashes the ground so hard the earth trembles.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = "Smash, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes a Melee check and compares that against the Agility defense of every target within the character’s reach plus their rank in spaces. Any targets the attack succeeds against take half regular damage. On a Fantastic success, the targets take full damage and are knocked prone."
            ]
        },
        new()
        {
            Name = PowerNames.HealingFactor,
            Description = "The character heals amazingly fast.",
            PowerSets = ["None"],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "At the end of the character’s turn, they regain Health equal to their Resilience. (This works outside of combat too, quickly bringing them back to full Health.)"
            ]
        },
        new()
        {
            Name = PowerNames.IcyTendrilsOfIkthalon,
            Description = "The character unleashes freezing tendrils at a foe.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces",
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego check against the Agility defense of a target in their line of sight. If the attack is a success, it inflicts regular damage. On a Fantastic success, the enemy takes double that total damage and is paralyzed by the ice."
            ],
        },
        new()
        {
            Name = PowerNames.ImagesOfIkonn,
            Description = "The character creates illusory duplicates of a person.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character creates one sound and sight illusory duplicate per rank of one person they’ve met (including themselves). The duplicates look and sound exactly like the original and are under the character’s complete control. They start in the same space as the character and instantly move into any open space around them, up to 2 spaces away, during which time the character can swap places with any of the duplicates. If the character is duplicating themselves, the character’s player should secretly record which one is the actual character.",
                "The duplicates can move up to 10 spaces away from the character, and they can pretend to attack (and miss) opponents. Any attack that hits a duplicate instantly removes it. If the character successfully attacks someone or does something else to make the truth evident, the illusion ends.",
                "This spell can also be used to see through someone else’s illusion. When used in this way, it gives the character a double edge on their Ego check."
            ],
        },
        new()
        {
            Name = PowerNames.Inspiration,
            Description = "The character’s words inspire their allies.",
            PowerSets = ["None"],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.OneRound,
            Effect =
            [
                "The character inspires an ally in earshot. The ally gains an edge on all action checks until the start of the character’s next turn.",
            ],
        },
        new()
        {
            Name = PowerNames.Immovable,
            Description = "Nobody pushes the character around.",
            PowerSets = [PowerSetNames.ShieldBearer, PowerSetNames.SuperStrength],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "The character is knocked back or knocked prone.",
            Duration = Duration.Instant,
            Effect =
            [
                "For every point of Melee defense the character has, they can reduce knockback by 1 space."
            ]
        },
        new()
        {
            Name = PowerNames.Jump1,
            Description = "The character can leap about like a frog.",
            PowerSets = [PowerSetNames.SpiderPowers, PowerSetNames.SuperStrength],
            Prerequsites = "Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains the Jump movement mode with a Jump Speed equal to their Run Speed. They can jump this distance in any direction, vertically as well as horizontally."
            ],
            JumpSpeed = true
        },
        new()
        {
            Name = PowerNames.Jump2,
            Description = "The character can leap around with dazzling speed.",
            PowerSets = [PowerSetNames.SpiderPowers, PowerSetNames.SuperStrength],
            Prerequsites = "Jump 1, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character’s Jump Speed is equal to their rank times their Run Speed. Outside of combat, they can move three times as fast."
            ],
            JumpSpeed = true,
            JumpSpeedMultipliedByRank = true,
        },
        new()
        {
            Name = PowerNames.Jump3,
            Description = "The character can leap into the sky with a single bound.",
            PowerSets = [PowerSetNames.SpiderPowers, PowerSetNames.SuperStrength],
            Prerequsites = "Jump 2, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character’s Jump Speed is equal to their rank times their Run Speed. Outside of combat, the character can jump up to 50 times their Jump Speed."
            ],
            JumpSpeed = true,
            JumpSpeedMultipliedByRank = true,
        },
        new()
        {
            Name = PowerNames.KeepMoving,
            Description = "The character can keep allies moving under fire.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "An ally in line of sight and earshot is demoralized or stunned.",
            Duration = Duration.Instant,
            Effect =
            [
                "The demoralized or stunned condition ends."
            ]
        },
        new()
        {
            Name = PowerNames.MemoryBlip,
            Description = " The character erases a bit of someone’s memory.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "Telepathic Link, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Cost = "5 Focus",
            Effect =
            [
                "The character causes a target with whom they’ve established a Telepathic Link to forget something that’s happened in the past hour. This gap can be up to an hour in length.",
                "The character makes a Logic check against the target’s Logic defense. On a success, the memories are forgotten. On a Fantastic success, the target has trouble on checks to recover such memories in the future.",
                "Any time the target is given good reason to question the blank in their memory, they can make a Logic check to recover their memory. If they succeed, the original memory floods back. On a Fantastic success, they know for sure who did this to them."
            ],
        },
        new()
        {
            Name = PowerNames.Mighty1,
            Description = "The character is superhumanly strong.",
            PowerSets = ["None"],
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
            PowerSets = ["None"],
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
            PowerSets = ["None"],
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
            PowerSets = ["None"],
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
            Name = PowerNames.MistsOfMunnopor,
            Description = "The character weaves a thick fog.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character creates a thick fog for up to 100 spaces per rank around them that blocks all line of sight beyond 10 spaces and keeps people or creatures inside it from flying, gliding or webslinging.",
            ],
        }, 
        new()
        {
            Name = PowerNames.MultiversalPortal,
            Description = "The character opens a portal to another universe.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.MultiversalTravelTogether}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character opens a glowing portal in a space next to them that moves anything that enters it between that space and its destination, which forms a matched glowing portal in the other place. The other end of the portal must be in a clear space in another universe that the character has been to. Anything can move through the portal in either direction until it is closed, which the character can do at will.",
            ],
        },
        new()
        {
            Name = PowerNames.MultiversalTravel,
            Description = "The character moves from one universe to another.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character instantly moves from their current universe to another universe. For instance: from Earth-616 to Earth-65. When they move to the other universe, they can arrive in any place they’ve been to before. Otherwise, they arrive at the closest available corresponding space in the other universe.",
            ],
        },
        new()
        {
            Name = PowerNames.MultiversalTravelTogether,
            Description = "The character sends someone to another universe.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.MultiversalTravel}, Rank 4",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes an Ego check against the Vigilance of a target they have grabbed. If the check is successful, the character can send the target to another universe. The target can be sent to any location in that universe that the character has been to before. Otherwise, the target arrives at the closest available corresponding space in the other universe.",
            ],
        },
        new()
        {
            Name = PowerNames.QuickToss,
            Description = "The character tosses a person like a toy.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = "Crushing Grip, Mighty 1, Rank 3",
            Action = ActionType.Reaction,
            Trigger = "A person the character can pick up is grabbed.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character throws the grabbed person at another target. The range is determined by the level of the character’s Mighty power and the grabbed person's size. The character makes a ranged attack against the target. A failure inflicts regular damage on the thrown person, who falls prone within 1 space of the target. If the attack is a success, the target takes regular damage too. On a Fantastic success, the target is knocked prone as well."
            ],
        },
        new()
        {
            Name = PowerNames.ShieldOfTheSeraphim,
            Description = "The character produces a magical shield.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character produces a magical shield that protects them from physical damage. Any attacks against them that do 20 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 20 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.Smash,
            Description = "SMASH!",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = "Clobber, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 or more Focus",
            Effect =
            [
                "The character makes a close attack with an edge. For this attack, add +1 to the character’s Melee damage bonus for every 2 points of Focus they spend. On a success, an a­ffected target takes that total damage. On a Fantastic success, an a­ffected target takes double that total damage and is stunned for one round."
            ],
        },
        new()
        {
            Name = PowerNames.SnapShooting,
            Description = "The character shoots from the hip with deadly speed.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character splits their attack to make two ranged attacks against separate targets (or they can focus a single attack on a single target). Make a single Agility check and compare it to the targets’ Agility defenses. On a success, an affected target takes half regular damage. On a Fantastic success, an affected target takes full damage and is bleeding."
            ],
        },
        new()
        {
            Name = PowerNames.Sturdy1,
            Description = "The character has protection from physical damage.",
            PowerSets = ["None"],
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
            PowerSets = ["None"],
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
            PowerSets = ["None"],
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
            PowerSets = ["None"],
            Prerequsites = "Sturdy 3, Rank 6",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 4.",
            ],
            HealthDamageReductionModifier = -4
        },
        new()
        {
            Name = PowerNames.SummonPortal,
            Description = "The character opens a portal between space and dimensions.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character opens a glowing portal in a space next to them that teleports anything that enters it between that space and its destination, which forms a matched glowing portal in the other place. This can be between any two points in the Multiverse, as long as the character has seen the destination. Anything can move through the portal in either direction until it is closed, which the character can do at will.",
            ],
        },
        new()
        {
            Name = PowerNames.SuppressiveFire,
            Description = "The character forces their foes to keep their heads down.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes an Agility attack against a target’s Vigilance defense. If the attack is a success, apply Health Damage Reduction normally. Any damage taken is then applied to the target’s Focus instead. If it’s a Fantastic success, the damage is doubled, and if the target takes any Focus damage, they are stunned for one round."
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticManipulation,
            Description = "The character can handle physical things with their mind.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "Varies",
            Effect =
            [
                "The character can manipulate objects in their line of sight with their mind. The maximum range for this is 5 spaces times the character’s rank. If someone tries to prevent the character from taking control of an object, the character makes a Logic check against the opponent’s Agility defense.",
            ],
        },
        new()
        {
            Name = PowerNames.TelepathicBlast,
            Description = "The character can mentally blast a foe’s mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "Telepathic Link, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a Logic attack against a target in line of sight. If the attack is a success, it infl icts regular Focus damage. On a Fantastic success, the target takes double damage instead and is stunned for one round.",
            ],
        },
        new()
        {
            Name = PowerNames.TelepathicLink,
            Description = "The character can speak with another telepathically.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character can communicate telepathically with one person at a time, and they must have met or seen the other person before. The communication can be verbal, visual or even more complex, such as imparting location information. There is no limit to the distance of the communication, as long as the character and the target are in the same dimension.",
                "If the other person does not wish to speak with the character, the target can automatically tune them out. To force a telepathic link, the character can make a Logic check against the target’s Vigilance defense. On a failure, the character cannot attempt to communicate with the target in this way for the rest of the day. On a success, the character can communicate with the target for as long as the concentration lasts. On a Fantastic success, the target cannot shut the character out for the rest of the day."
            ],
        },
        new()
        {
            Name = PowerNames.TelepathicNetwork,
            Description = "The character can speak telepathically with a group of people.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "Telepathic Link, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character can communicate telepathically with a group of willing, previously linked people, each of whom they have met or seen before. The communication can be verbal, visual or even more complex, such as imparting location information. The group can number up to five people per rank. There is no limit to the distance of the communication, as long as everyone involved is in the same dimension.",
            ],
        },
        new()
        {
            Name = PowerNames.TimePortal,
            Description = "The character opens a portal in time.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.TimeTravelTogether}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character opens a glowing portal in a space next to them that moves anything that enters it between that space and its destination, which forms a matched glowing portal in the other place. The other end of the portal must be in a clear space in another period of time, in roughly the same place. Anything can move through the portal in either direction until it is closed, which the character can do at will.",
            ],
        },
        new()
        {
            Name = PowerNames.TimeTravel,
            Description = "The character moves from one time to another.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = "Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character instantly moves from their current time to another time—for instance, from the present to 1962. When they move to the other time, they can arrive in any place they’ve been to before. Otherwise, they arrive at the closest available corresponding space in the other time.",
            ],
        },
        new()
        {
            Name = PowerNames.TimeTravelTogether,
            Description = "The character sends someone to another time.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.TimeTravel}, Rank 4",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes an Ego check against the Vigilance defense of a target they have grabbed. If the check is successful, the character can send the target to another time. The target can be sent to any location in that time that the character has been to before. Otherwise, the target arrives at the closest available corresponding space in the other time.",
            ],
        },
        new()
        {
            Name = PowerNames.UnrelentingSmash,
            Description = "The character smashes everything in reach.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = "Ground-Shaking Stomp, Mighty 2, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes a Melee check and compares it against the Melee defense of every enemy within their reach. Any enemy the attack succeeds against takes half regular damage. On a Fantastic success, those enemies take full regular damage and are knocked prone instead.",
                "The character may then pay 15 more Focus to do the same thing again—before which they can move up to half their speed with anything left from their normal movement action. They can keep doing this until they run out of speed or Focus. Each target can be a­ ected by this attack by this character only once per round."
            ],
        },
        new()
        {
            Name = PowerNames.VaporsOfValtorr,
            Description = "The character weaves an inky mist that can attack those inside it.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character creates an inky mist for up to 25 nspaces per rank around them that blocks all line of sight beyond 5 spaces. On later turns, the character can have the mist attacks one target at a time. Make an Ego check against the target’s Vigilance defense. On a success, the attack does regular damage. On a Fantastic success, it does double damage and blinds the target for one turn.",
            ],
        },
        new()
        {
            Name = PowerNames.WeaponsBlazing,
            Description = "The character blazes away at two foes at once.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = PowerNames.SnapShooting,
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character splits their attack to make two ranged attacks against separate targets (or they can focus a single attack on a single target). Make a single Agility check and compare it to the targets’ Agility defenses. On a success, the affected target takes half regular damage. On a Fantastic success, the affected target takes full damage, and the character can make a bonus attack with this power against any available target, with the same effect. "
            ],
        },
        new()
        {
            Name = PowerNames.WindsOfWatoomb,
            Description = "The character creates swirling winds for protection.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Sorcerous, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "Damage gets through the Shield of the Seraphim",
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character conjures swirling winds that they control. All movement by a foe within 10 spaces per the character’s rank is cut in half.",
                "The character can also use this spell to push away smoke, mist or fog. If such a thing was created by a power, the character makes an Ego check with an edge against the Ego defense of the opposing controller. On a success, the controller’s power ends. On a Fantastic success, the controller is knocked prone.",
                "Additionally, the Winds of Watoomb can be used to reinforce the Shield of the Seraphim. The character can transfer any Health damage that gets through the Shield of the Seraphim’s protection to their Focus instead, leaving the Shield of the Seraphim intact."
            ],
        },
    ];
}
