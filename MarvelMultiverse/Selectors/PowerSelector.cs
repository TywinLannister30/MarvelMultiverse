using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class PowerSelector : IPowerSelector
{
    public Power GetPower(
        string name, 
        bool isTech = false,
        bool swinglineSpeed = false,
        string specialization = null, 
        string reminder = null,
        int? meleeDamageModifier = null, 
        int? agilityDamageModifier = null)
    {
        var staticPower = GetAllPowers().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        var power = staticPower.Clone() as Power;

        if (!string.IsNullOrEmpty(specialization))
            power.Name += $": {specialization}";

        if (!string.IsNullOrEmpty(reminder))
            power.Name += $" ({reminder})";

        power.IsTech = isTech;
        power.SwinglineSpeed = swinglineSpeed;

        if (meleeDamageModifier.HasValue)
            power.MeleeDamageModifier += meleeDamageModifier.Value;

        if (agilityDamageModifier.HasValue)
            power.AgilityDamageModifier += agilityDamageModifier.Value;

        return power;
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
            PowerSets = [],
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
            PowerSets = [],
            Prerequsites = $"{PowerNames.Accuracy1}, Rank 2",
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
            PowerSets = [],
            Prerequsites = $"{PowerNames.Accuracy2}, Rank 3",
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
            PowerSets = [],
            Prerequsites = $"{PowerNames.Accuracy3}, Rank 4",
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
            Name = PowerNames.AdditionalLimbs,
            Description = "The character has extra limbs that can grab objects and attack foes.",
            PowerSets = [],
            Prerequsites = $"None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character has an additional prehensile appendage (like a tail) or a symmetrical pair of them (like arms) that can be used to lift objects, use tools or otherwise take actions that normally require the use of a hand. This grants them an edge in Melee and Agility checks.",
                "A character can have as many additional limbs as they like—within reason—but they get no additional advantages for them."
            ]
        },
        new()
        {
            Name = PowerNames.AlwaysReady,
            Description = "The character is prepared to fight.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.DoThisAllDay}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains one additional reaction per round, which can be used only to activate a Martial Arts power.",
            ]
        },
        new()
        {
            Name = PowerNames.AnimalCommunication,
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
            Name = PowerNames.AttackStance,
            Description = "The character enters an aggressive attack stance, ready to strike in any direction.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character doubles their Melee ability bonus to damage.",
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
            Name = PowerNames.BlazingFastFists,
            Description = "The character can attack superfast.",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = "Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character has an edge on all Melee attacks."
            ]
        },
        new()
        {
            Name = PowerNames.Blur,
            Description = " The character moves like a blur!",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"{PowerNames.SpeedRun2}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.OneRound,
            Cost = "5 Focus",
            Effect =
            [
                "Any attacks against the character have trouble."
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
            Name = PowerNames.BraceForImpact,
            Description = "The character mentally toughens themselves for a fight.",
            PowerSets = [PowerSetNames.MartialArts, PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.DoThisAllDay}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy deals physical damage to the character.",
            Duration = Duration.Instant,
            Cost = "5 or more Focus",
            Effect =
            [
                "For every point of Focus spent, the character can ignore 1 point of Health damage dealt by the attack.",
            ]
        },
        new()
        {
            Name = PowerNames.Brawling,
            Description = "The character has the moves and is hard to hit.",
            PowerSets = [],
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
            Name = PowerNames.Brilliance1,
            Description = "The character puts their brain to work.",
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +1 to their Logic damage multiplier, and they gain a +1 bonus to Logic checks other than attacks.",
            ],
            LogicDamageModifier = 1,
            LogicNonCombatCheckModifier = 1
        },
        new()
        {
            Name = PowerNames.Brilliance2,
            Description = "Everything makes more sense to the character.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Brilliance1}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +2 to their Logic damage multiplier, and they gain a +2 bonus to Logic checks other than attacks.",
            ],
            LogicDamageModifier = 2,
            LogicNonCombatCheckModifier = 2
        },
        new()
        {
            Name = PowerNames.Brilliance3,
            Description = "Little can stop the character’s mind.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Brilliance2}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +3 to their Logic damage multiplier, and they gain a +3 bonus to Logic checks other than attacks.",
            ],
            LogicDamageModifier = 3,
            LogicNonCombatCheckModifier = 3
        },
        new()
        {
            Name = PowerNames.Brilliance4,
            Description = "The character’s intelligence is unparalleled.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Brilliance3}, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character adds +4 to their Logic damage multiplier, and they gain a +4 bonus to Logic checks other than attacks.",
            ],
            LogicDamageModifier = 4,
            LogicNonCombatCheckModifier = 4
        },
        new()
        {
            Name = PowerNames.CatchBullets,
            Description = "The character is fast enough to catch bullets—safely!",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"{PowerNames.SpeedRun2}, Rank 3",
            Action = ActionType.Reaction,
            Trigger = "A ranged attack using physical projectiles (arrows, bullets and so on) is made against the character—or a character within their character’s reach.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Agility check, using the attacker’s attack result as the target number. If the character’s check succeeds, the attack is nullified. On a Fantastic success, the character gets their reaction back."
            ]
        },
        new()
        {
            Name = PowerNames.ChainStrikes,
            Description = "The character unleashes a hail of strikes.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.FastStrikes}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a close attack with an edge. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the character can also make an additional Chain Strike."
            ]
        },
        new()
        {
            Name = PowerNames.ChangeOfPlans,
            Description = "The character thinks of a better way.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.Inspiration}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An ally has trouble on an action check.",
            Duration = Duration.OneRound,
            Cost = "5 Focus",
            Effect =
            [
                "The ally gains an edge on that action check."
            ]
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
            Name = PowerNames.CombatSupport,
            Description = "The character gives a friend a hand.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.ChangeOfPlans}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.OneRound,
            Cost = "10 Focus",
            Effect =
            [
                "Once per battle, the character chooses an ally in earshot. If the ally makes an action check before the start of the character’s next turn, the ally automatically rolls a 1 on their Marvel die, and that die cannot be a­ffected by trouble."
            ]
        },
        new()
        {
            Name = PowerNames.CombatTrickery,
            Description = "The character is a tricky one!",
            PowerSets = [],
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
            Name = PowerNames.Command,
            Description = "The character forces someone to follow an order.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.OneRound,
            Cost = "5 Focus",
            Effect =
            [
                "The character gives an order to a target with whom they’ve established a Telepathic Link. The character makes a Logic check against the target’s Logic defense. On a success, the target complies with the order. On a Fantastic success, the character gains an edge the next time they use this power against this same target.",
                "The command must be something that can be completed in a single action. If it involves harming someone, the character has trouble on the check. If it would cause the target to harm themselves, the character has double trouble on the check."
            ]
        },
        new()
        {
            Name = PowerNames.CounterstrikeTechnique,
            Description = "The character counters an enemy’s strike with one of their own.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.AttackStance}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "While Attack Stance is active, a close attack against the character does damage.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character deals half the attacker’s regular damage to the attacker.",
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
            Name = PowerNames.DanceOfDeath,
            Description = "The character spins about, shooting at every enemy around them.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.SlowMotionDodge}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Agility check and compares that against the Agility defense of every enemy within 5 spaces and in their line of sight. Each success does half the regular damage. On a Fantastic success, each enemy takes full damage instead and is bleeding.",
            ]
        },
        new()
        {
            Name = PowerNames.DefenseStance,
            Description = "The character enters a fluid defensive stance, hands poised to parry and counterattack.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "Any close attacks made against the character have trouble until they are successfully attacked in this combat.",
            ]
        },
        new()
        {
            Name = PowerNames.Discipline1,
            Description = "The character works to hone their power.",
            PowerSets = [],
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
            PowerSets = [],
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
            PowerSets = [],
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
            PowerSets = [],
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
            Name = PowerNames.Disguise,
            Description = "The character appears to be someone else.",
            PowerSets = [],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Effect =
            [
                "The character instantly alters their appearance so that they appear to be someone else. The target number for anyone trying to see through the disguise is the character’s Ego defense. If the character is impersonating someone known to the other person, that person has an edge."
            ],
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
            Name = PowerNames.DoThisAllDay,
            Description = "The character draws on their inner strength to heal themselves.",
            PowerSets = [PowerSetNames.MartialArts, PowerSetNames.ShieldBearer],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 or more Focus",
            Effect =
            [
                "The character heals Ž points of Health for every point of Focus they spend.",
            ]
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
            Name = PowerNames.ElementalBarrage,
            Description = "The character hurls a barrage of their element at their foes.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBlast}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character designates a space within their line of sight. The attack can a­ ect every enemy within 10 spaces of that. The character makes a single Ego check and compares it to each target’s Resilience defense. A­ ected enemies take half regular damage. On a Fantastic success, they take full regular damage and the elemental type’s special e­ffect.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalBarrier,
            Description = "The character forms a wall of their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBlast}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character forms a wall of their element within their line of sight and up to 10 spaces away per rank. This covers up to 2 spaces across (vertically/horizontally) per their rank. The character makes an Agility check and compares the results against the Agility defense of any target in the a­ffected spaces. On a success, the character chooses which side of the barrier the target winds up on. On a failure, the target chooses. On a Fantastic success, the target su­ffers the element’s special e­ffect too.",
                "Attacks against the barrier are against the character’s Ego defense. Any attacks against it that do 10 points of damage or less are instantly absorbed, and the barrier continues. If an attack does more than 10 points of damage, it destroys the barrier. Either way, the attack leaves those behind the barrier unharmed."
            ],
        },
        new()
        {
            Name = PowerNames.ElementalBlast,
            Description = "The character blasts a foe with their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBurst}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 Spaces",
            Cost = "5 or more Focus",
            Effect =
            [
                "The character makes a ranged attack with an edge at an enemy in line of sight. For this attack, add +1 to the character’s Agility damage bonus for every 2 points of Focus they spend. On a success, an affected target takes that total damage. On a Fantastic success, an affected target takes double that total damage and suffers the elemental type’s special effect.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalBurst,
            Description = "The character fires a burst of their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 Spaces",
            Effect =
            [
                "The character makes a ranged attack against an enemy in line of sight. If the attack is a success, it infl icts regular damage. On a Fantastic success, the enemy takes double damage instead and the elemental type’s special effect.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalProtection1,
            Description = "The character protects themselves with their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBarrier}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character protects themselves with their element. Any attacks against them that do 10 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 10 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalProtection2,
            Description = "The character’s elemental protection is like armor.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalProtection1}, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character protects themselves with their element. Any attacks against them that do 20 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 20 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalProtection3,
            Description = "The character’s elemental protection is like a tank.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalProtection2}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character protects themselves with their element. Any attacks against them that do 30 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 30 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalProtection4,
            Description = "The character’s elemental protection is like a fortress.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalProtection3}, Rank 5",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "20 Focus",
            Effect =
            [
                "The character protects themselves with their element. Any attacks against them that do 40 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 40 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalPush,
            Description = "The character can move a target with their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBurst}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Ego attack against the target’s Agility defense. If the attack succeeds, the character can move the target in any direction, up to 1 space times the character’s rank. On a Fantastic success, the target also takes regular damage, is knocked prone and suffers the element’s special effect.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalReinforcement,
            Description = "The character reinforces their powers with their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalProtection1}",
            Action = ActionType.Reaction,
            Trigger = "Damage gets through an elemental power",
            Duration = Duration.Instant,
            Cost = "Varies",
            Effect =
            [
                "The character can transfer any Health damage that gets through an elemental power that grants damage protection to their Focus instead, leaving the protection intact.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalRicochet,
            Description = "The character bounces the burst off one foe and into another.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBurst}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces times the character’s rank",
            Cost = "10 Focus",
            Effect =
            [
                "The character makes a ranged attack against a target in line of sight. If the attack is a success, it inflicts regular damage. On a Fantastic success, energy also bounces off­ the first target to another in line of sight, and the character can make a new attack against that target, adding the new range to the previous attack’s range. This can be repeated until an attack is not fantastic.",
            ],
        },
        new()
        {
            Name = PowerNames.EnergyAbsorption,
            Description = "The character turns damage into power.",
            PowerSets = [],
            Prerequsites = "Rank 4",
            Action = ActionType.Reaction,
            Trigger = "The character takes Health damage.",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character can take any Health damage done to them (after applying any damage reduction), ignore it and add that number to their Focus instead. In this way, they can increase their Focus up to double their regular maximum Focus.",
                "Once the combat is over, any extra Focus over the character’s regular maximum Focus score fades away. This power cannot be used again until any Focus the character gained in this way is spent.",
            ],
        },
        new()
        {
            Name = PowerNames.EnvironmentalProtection,
            Description = "Environmental e£fects don’t bother the character.",
            PowerSets = [],
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
            Name = PowerNames.Evasion,
            Description = "The character can dodge fists quickly.",
            PowerSets = [],
            Prerequsites = $"None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can use their Agility defense score against Melee attacks too.",
            ],
            AgilityInsteadOfMeleeForDefence = true
        },
        new()
        {
            Name = PowerNames.Exploit,
            Description = "The character finds a weak spot and exploits it.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = $"{PowerNames.ViciousAttack}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "A Fantastic success on an attack using the character’s weapon that deals at least 1 point of damage",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a Melee attack against the target’s Resilience defense score. If the attack is a success, the damage it does ignores Health Damage Reduction. On a Fantastic success, the target suffers double damage and the weapon’s special effect.",
            ],
        },
        new()
        {
            Name = PowerNames.ExtendedReach1,
            Description = "The character’s reach grows.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character’s reach quadruples.",
            ],
        },
        new()
        {
            Name = PowerNames.ExtendedReach2,
            Description = "The character can reach a looong way.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.ExtendedReach1}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character’s reach is 10 times normal.",
            ],
        },
        new()
        {
            Name = PowerNames.FastAttacks,
            Description = "The character’s weapons lash out!",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character splits their attack to make two close attacks against separate targets within reach (or they can focus a single attack on a single target). Make a single Melee check and compare it to the targets’ Melee defenses. On a success, the affected target takes half regular damage. On a Fantastic success, the affected target takes full damage, and the character can make a bonus attack with this power against any target within reach, with the same effect.",
            ],
        },
        new()
        {
            Name = PowerNames.FastHands,
            Description = "The character can shoot faster than the eye can blink.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.PointBlankParry}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains one additional reaction per round. This reaction can be used only to trigger a Ranged Weapons power.",
            ],
        },
        new()
        {
            Name = PowerNames.FastStrikes,
            Description = "The character unleashes a flurry of strikes.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character splits their attack to make two close attacks against separate targets within reach (or they can  focus a single attack on a single target). Make a single Melee check and compare it to the targets’ Melee defenses. On a success, the affected target takes half regular damage. On a Fantastic success, the affected target takes full damage.",
            ]
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
            PowerSets = [],
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
            PowerSets = [],
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
            Name = PowerNames.FlyingDoubleKick,
            Description = "The character leaps into the air and snap kicks two enemies at once.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.LegSweep}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes a close attack against two enemies within reach. If an attack is a success, the enemy takes regular damage. If an attack is a Fantastic success, the enemy takes double damage and is knocked prone."
            ],
        },
        new()
        {
            Name = PowerNames.FocusFire,
            Description = "The character calls out a target.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.BattlePlan}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character calls out an enemy in line of sight and inspires one or more allies of their choice in earshot, up to the character’s Vigilance. They gain an edge on all action checks against that enemy."
            ],
        },
        new()
        {
            Name = PowerNames.FocusedFury,
            Description = "The character channels their rage into a devastating blow.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = $"{PowerNames.Exploit}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 or more Focus",
            Effect =
            [
                "The character makes a close attack with an edge. For this attack, add +1 to the character’s Melee damage bonus for every 2 points of Focus they spend. On a success, an a­ffected target takes that total damage. On a Fantastic success, an a­ffected target takes double that total damage and su­ffers the weapon’s special e­ffect."
            ],
        },
        new()
        {
            Name = PowerNames.FuriousAttacks,
            Description = "The character’s weapons smash into the foe.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = $"{PowerNames.WhirlingFrenzy}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 or more Focus",
            Effect =
            [
                "The character splits their attack to make two close attacks against separate targets within reach (or they can focus a single attack on a single target). Make a single Melee check and compare it to the targets’ Melee defenses. For these attacks, add +1 to the character’s Melee damage bonus for every 2 points of Focus they spend. On a success, an a­ ected target takes half that total damage. On a Fantastic success, an a­ ected target takes full damage and su­ffers the weapon’s special e­ffect."
            ],
        },
        new()
        {
            Name = PowerNames.GrapplingTechnique,
            Description = "The character snags an enemy.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a close attack. If the attack is a success, the enemy takes regular damage and is grabbed. On a Fantastic success, the target takes double damage instead and is pinned too."
            ]
        },
        new()
        {
            Name = PowerNames.GroundShakingStomp,
            Description = "The character smashes the ground so hard the earth trembles.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = $"{PowerNames.Smash}, Rank 3",
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
            Name = PowerNames.Grow1,
            Description = "The character sizes up!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = "None",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can grow up to huge size. They can return to their normal size at will."
            ]
        },
        new()
        {
            Name = PowerNames.Grow2,
            Description = "The character becomes even bigger!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Grow1}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can grow up to gigantic size. They can return to their normal size at will."
            ]
        },
        new()
        {
            Name = PowerNames.Grow3,
            Description = "The character can be the size of a house!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Grow2}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can grow up to titanic size. They can return to their normal size at will."
            ]
        },
        new()
        {
            Name = PowerNames.Grow4,
            Description = "The character can tackle kaiju!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Grow3}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can grow up to gargantuan size. They can return to their normal size at will."
            ]
        },
        new()
        {
            Name = PowerNames.GrowingAttack,
            Description = "The character attacks as they grow",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Grow1}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The character grows.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a close attack with an edge. If the attack succeeds, they do regular damage for the size they are growing to. On a Fantastic success, they do double damage and stun the target."
            ]
        },
        new()
        {
            Name = PowerNames.Headshot,
            Description = "Ouch!",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.StoppingPower}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes a ranged attack with trouble on an enemy within the weapon’s range. If the attack is a success, the enemy takes double normal damage. On a Fantastic success, the enemy takes triple damage. Either way, if the enemy su­ ers any actual damage, they are also stunned for one round."
            ]
        },
        new()
        {
            Name = PowerNames.HealingFactor,
            Description = "The character heals amazingly fast.",
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "At the end of the character’s turn, they regain Health equal to their Resilience. (This works outside of combat too, quickly bringing them back to full Health.)"
            ]
        },
        new()
        {
            Name = PowerNames.HeightenedSenses1,
            Description = "The character has superior senses.",
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can sense things roughly twice as far away as normal. They also have an edge on Vigilance checks to perceive things, and enemies have trouble on checks they make to sneak past the character."
            ]
        },
        new()
        {
            Name = PowerNames.HeightenedSenses2,
            Description = "The character has senses as sharp as radar.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.HeightenedSenses1}",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can sense things roughly four times as far away as normal. Their senses are so sharp that they can use some of them to compensate for the loss of others (say, if blinded or deafened). They can even listen to the heartbeat of a person in the same room to see if they are lying—although this is as reliable as a traditional lie detector: far from 100% and not admissible in court.",
                "They also have a double edge on Vigilance checks to perceive things, and enemies have double trouble on checks they make to sneak past the character."
            ]
        },
        new()
        {
            Name = PowerNames.HellfireChains,
            Description = "The character shoots out chains covered in hellfire.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Cursed}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character summons chains covered in hellfire and can use them to bind or smash targets. They can attack anyone within 10 spaces per rank and line of sight. Make an Ego attack. On a success, the target takes regular Health damage. On a Fantastic success, the target is grabbed and paralyzed too.",
                "If a target is grabbed by the hellfire chains, on each subsequent round, the character can make an Ego check against the target’s Resilience Resilience defense to inflict regular Health damage and regular Focus damage. Breaking free from the hellfire chains requires a Melee check with a target number of 20."
            ]
        },
        new()
        {
            Name = PowerNames.HitAndRun,
            Description = "The character hits hard and keeps moving!",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a close attack with an edge on an enemy. If the attack is a success, the enemy takes regular damage, and the character can make an additional movement up to half their Run Speed for free. On a Fantastic success, the enemy takes double damage and su­ffers the weapon’s special e­ffect.",
            ]
        },
        new()
        {
            Name = PowerNames.HurledShieldBash,
            Description = "The character hurls their mighty shield at an enemy.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.ShieldBash}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces times the character’s rank",
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a ranged attack on an enemy. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and is knocked prone. The shield then bounces back to the character.",
            ]
        },
        new()
        {
            Name = PowerNames.HurledShieldBlock,
            Description = "The character hurls their mighty shield to protect an ally from an attack.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.Shield1}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy makes an attack against an ally’s Agility.",
            Duration = Duration.Instant,
            Range = "5 spaces times the character’s rank",
            Cost = "5 Focus",
            Effect =
            [
                "The ally gains Health Damage Reduction equal to the character’s Shield power against that attack. The shield then bounces back to the character.",
            ]
        },
        new()
        {
            Name = PowerNames.HurledShieldDeflection,
            Description = "The character hurls their mighty shield to save an ally from an attack.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.ShieldDeflection}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy makes an attack against an ally’s Agility.",
            Duration = Duration.Instant,
            Range = "5 spaces times the character’s rank",
            Cost = "5 Focus",
            Effect =
            [
                "The enemy has trouble on the attack. The shield then bounces back to the character.",
            ]
        },
        new()
        {
            Name = PowerNames.IconicWeapon,
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character is known for owning and using a unique and powerful weapon, like Mjolnir (Thor’s hammer) or Captain America’s shield. The Narrator must approve the details of this weapon. This power can be taken more than once, but each time must be with a di­fferent weapon.",
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
            PowerSets = [],
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
            Name = PowerNames.LeapingLeglock,
            Description = "The character leaps into the air and snaps their legs around an enemy.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.FlyingDoubleKick}, {PowerNames.CrushingGrip}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes a close attack against an enemy. If the attack is a success, the enemy is grabbed and dealt regular damage. On a Fantastic success, the enemy takes double damage and is grabbed and stunned for one round. Either way, both the character and the enemy are knocked prone."
            ]
        },
        new()
        {
            Name = PowerNames.LegSweep,
            Description = "The character knocks the enemy’s legs from under them.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.FastStrikes}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a close attack. If it succeeds, the enemy takes regular damage and is knocked prone. If it’s a Fantastic success, the enemy is stunned for one round too."
            ]
        },
        new()
        {
            Name = PowerNames.LightningActions,
            Description = "The character has lightning-fast moves.",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "Once per round, the character can use a standard action as a reaction or a reaction as a standard action. Additionally, they can turn their Marvel die to a Fantastic success when making an initiative check."
            ]
        },
        new()
        {
            Name = PowerNames.MachineTelepathy,
            Description = "The character can communicate with machines with their mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character can communicate telepathically with one machine at a time, and they must have met or seen the machine before. The communication can be verbal, visual or even more complex, such as imparting location information. There is no limit to the distance of the communication, as long as the character and the machine are in the same dimension.",
                "Simple machines do not have much to o­ffer in the way of conversation, but they are also generally compliant with requests. Complex machines—like computers, smartphones and other electronics—are also often compliant, but if they are secured in any way, they usually refuse to communicate with strangers. A Logic check can get the character past such security, and the Narrator should set the target number according to the strength of the security.",
            ],
        },
        new()
        {
            Name = PowerNames.MemoryBlip,
            Description = "The character erases a bit of someone’s memory.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
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
            PowerSets = [],
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
            PowerSets = [],
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
            PowerSets = [],
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
            PowerSets = [],
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
            Name = PowerNames.MistsOfMorpheus,
            Description = "The character causes their foe to fall asleep.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Sorcerous}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Ego check against the target’s Vigilance defense. On a success, the target is stunned and remains that way while the character concentrates. On a Fantastic success, the target falls asleep instead.",
            ],
        },
        new()
        {
            Name = PowerNames.MistsOfMunnopor,
            Description = "The character weaves a thick fog.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Sorcerous}, Rank 2",
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
            Name = PowerNames.OnYourFeet,
            Description = "The character stands their friends on their feet.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.KeepMoving}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An ally in line of sight and earshot is knocked prone.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "All prone allies within earshot, who are able to, can immediately stand up for free. Allies currently unable to stand up for any reason are not a­ffected."
            ],
        },
        new()
        {
            Name = PowerNames.OperationsCenter,
            Description = "The character directs their allies in combat.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.CombatSupport}, {PowerNames.FocusFire}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character inspires one or more allies of their choice in earshot, up to the character’s Vigilance defense. A­ffected allies gain an edge on all action checks until the start of the character’s next turn. The character breaks concentration on this power if they use a movement action."
            ],
        },
        new()
        {
            Name = PowerNames.PointBlankParry,
            Description = "When the enemy steps in, the character lets loose.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = "Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy within 2 spaces misses an attack against the character.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a ranged attack against the enemy who missed them. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and is bleeding."
            ],
        },
        new()
        {
            Name = PowerNames.QuickToss,
            Description = "The character tosses a person like a toy.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = $"{PowerNames.CrushingGrip}, {PowerNames.Mighty1}, Rank 3",
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
            Name = PowerNames.RallyOnMe,
            Description = "The character rallies their friends around them.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.OnYourFeet}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "Any allies in earshot can be a­ffected, up to a number equal to the character’s Vigilance. Each a­ffected ally can move toward the character at half speed. If they are within the character’s reach at the end of this move, they recover lost Focus equal to 5 times the character’s rank. The character can use this power once per battle."
            ],
        },
        new()
        {
            Name = PowerNames.ReinforcedSkeleton,
            Description = "The character’s bones have been reinforced or replaced with a super-strong alloy or metal.",
            PowerSets = [],
            Prerequsites = $"None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 1.",
            ],
            HealthDamageReductionModifier = -1
        },
        new()
        {
            Name = PowerNames.ResizeObject,
            Description = "The character can change the size of an object within reach.",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Grow2} or {PowerNames.Shrink2}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Cost = "10 Focus",
            Effect =
            [
                "The character can make an object within reach grow or shrink. The character can resize the object as much as their own Grow or Shrink power would allow them to."
            ],
        },
        new()
        {
            Name = PowerNames.ReturnFire,
            Description = "The character responds to an assault with a hail of shots.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.SuppressiveFire}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy declares an attack against the character.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Agility attack against a target’s Vigilance defense. If the attack is a success, apply Health Damage Reduction normally. Any damage taken is then applied to the target’s Focus instead. If it’s a Fantastic success, the damage is doubled and, if the target takes any Focus damage, they are stunned for 1 round."
            ],
        },
        new()
        {
            Name = PowerNames.ReverseMomentumThrow,
            Description = "The character uses the momentum of their attacker to hurl them to the ground.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.DefenseStance}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "While Defense Stance is active, a close attack against the character misses.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The attacker is knocked prone and takes half the damage their attack would have inflicted if it had succeeded.",
            ]
        },
        new()
        {
            Name = PowerNames.RicoShield,
            Description = "The character ricochets their shield from target to target.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.HurledShieldBash}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces times the character’s rank",
            Cost = "10 Focus",
            Effect =
            [
                "The character makes a ranged attack on a target. If the attack is a success, the target takes regular damage. On a Fantastic success, the target is also knocked prone, and the character can make an extra attack on another target, adding the extra range between the two targets to the new attack roll. This can be repeated until an attack is not a Fantastic success.",
                "When the attacks are over, the shield then bounces back to the character."
            ]
        },
        new()
        {
            Name = PowerNames.Riposte,
            Description = "Seeing the enemy o£ balance, the character strikes back.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "An enemy makes a close attack against the character that fails.",
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a close attack on the enemy who just missed them. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and su­ffers the weapon’s special e­ffect.",
            ]
        },
        new()
        {
            Name = PowerNames.SenseSins,
            Description = "The character can look into a person’s soul.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Cursed}",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character looks into a target’s eyes and makes an Ego check against the target’s Ego defense. On a success, the character can sense what sorts of horrible things the target has done. On a Fantastic success, they can sense what sorts of horrible things the target intends to do in the immediate future.",
            ]
        },
        new()
        {
            Name = PowerNames.SenseSupernatural,
            Description = "The character can sense the supernatural.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character can reach out with their mind to sense the presence of supernatural people, places or things within 100 spaces per rank. This tells them the location of the supernatural thing and its general status.",
                "If a target or targets wish to remain undetected, the character must make an Ego check and compare it against each target’s Vigilance defense. If they succeed, they sense the target. On a Fantastic success, they can also identify if the target is cursed or demonic."
            ]
        },
        new()
        {
            Name = PowerNames.Shield1,
            Description = "The character wields a personal shield.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = "None",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Effect =
            [
                "The character gains Health Damage Reduction 1.",
            ]
        },
        new()
        {
            Name = PowerNames.Shield2,
            Description = "The character’s shield protects them like a wall.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.Shield1}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character gains Health Damage Reduction 2.",
            ]
        },
        new()
        {
            Name = PowerNames.Shield3,
            Description = "The character’s shield protects better than a tank.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.Shield2}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character gains Health Damage Reduction 3.",
            ]
        },
        new()
        {
            Name = PowerNames.Shield4,
            Description = "The character’s shield protects like a concrete barrier.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.Shield3}, Rank 6",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "25 Focus",
            Effect =
            [
                "The character gains Health Damage Reduction 4.",
            ]
        },
        new()
        {
            Name = PowerNames.ShieldBash,
            Description = "The character bashes a foe with their shield.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a close attack on an enemy within their reach. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and is knocked prone.",
            ]
        },
        new()
        {
            Name = PowerNames.ShieldDeflection,
            Description = "The character uses their shield to deflect attacks.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "The character is the target of an attack against their Agility defense.",
            Duration = Duration.Instant,
            Effect =
            [
                "The attack has trouble.",
            ]
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
            Name = PowerNames.ShieldWall,
            Description = "The character stands like an impenetrable wall.",
            PowerSets = [PowerSetNames.ShieldBearer],
            Prerequsites = $"{PowerNames.BraceForImpact}, Rank 3",
            Action = ActionType.Movement,
            Duration = Duration.Concentration,
            Effect =
            [
                "Attacks against the character have trouble. The character breaks concentration on this power if they use a movement action.",
            ]
        },
        new()
        {
            Name = PowerNames.Shrink1,
            Description = "The character thinks small.",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = "None",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can shrink down to little size. They can return to their normal size at will."
            ],
        },
        new()
        {
            Name = PowerNames.Shrink2,
            Description = "The character becomes even smaller!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Shrink1}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can shrink down to tiny size. They can return to their normal size at will."
            ],
        },
        new()
        {
            Name = PowerNames.Shrink3,
            Description = "The character is smaller than an action figure.",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Shrink2}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can shrink down to miniature size. They can return to their normal size at will."
            ],
        },
        new()
        {
            Name = PowerNames.Shrink4,
            Description = " The character is so small that they’re hard to see.",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Shrink3}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can shrink down to microscopic size. They can return to their normal size at will."
            ],
        },
        new()
        {
            Name = PowerNames.ShrinkingDodge,
            Description = "The character shrinks to avoid an attack.",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Shrink1}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The character is attacked.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The attacker has trouble on the attack."
            ],
        },
        new()
        {
            Name = PowerNames.SlowMotionDodge,
            Description = "Time seems to slow down for the character, making it easy to dodge enemy attacks.",
            PowerSets = [],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "An enemy makes an attack against the character’s Agility defense.",
            Duration = Duration.Instant,
            Effect =
            [
                "The enemy has trouble on the attack."
            ],
        },
        new()
        {
            Name = PowerNames.SlowMotionShootDodge,
            Description = "The character dives sideways, weapons blazing, hanging in midair for a split second.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.SlowMotionDodge}, {PowerNames.WeaponsBlazing}, Rank 3",
            Action = ActionType.Standard,
            Duration = $"{Duration.Instant} + {Duration.OneRound}",
            Cost = "10 Focus",
            Effect =
            [
                "The character splits their attack to make two ranged attacks against separate targets (or they can focus a single attack on a single target). Make a single Agility check and compare it to the targets’ Agility defenses. On a success, an a­ffected target takes half regular damage. On a Fantastic success, an a­ffected target takes full damage, and the character can make a bonus attack with this power against any available target, with the same e­ffect.",
                "When the character moves, is moved or starts their next turn, they instantly fall prone. Until that happens, all attacks against their Agility defense have trouble."
            ],
        },
        new()
        {
            Name = PowerNames.Smash,
            Description = "SMASH!",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = $"{PowerNames.Clobber}, Rank 2",
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
            Name = PowerNames.Sniping,
            Description = "The character takes aim and shoots with deadly accuracy.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = "Rank 2",
            Action = $"Both {ActionType.Standard} and {ActionType.Movement} (character cannot move this turn)",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a ranged attack against an enemy at least 20 spaces away. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes triple damage instead."
            ],
        },
        new()
        {
            Name = PowerNames.SpeedRun1,
            Description = "The character runs as fast as a car!",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = "Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "Multiply the character’s regular Run Speed by their rank to get their new Run Speed. Outside of combat, they can move three times as fast.",
            ],
            RunSpeedMultipliedByRank = true
        },
        new()
        {
            Name = PowerNames.SpeedRun2,
            Description = "The character runs as fast as a jet!",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"{PowerNames.SpeedRun1}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "Multiply the character’s regular Run Speed by their rank to get their new Run Speed. Outside of combat, the character can move up to 50 times as fast as their increased Run Speed.",
            ],
            RunSpeedMultipliedByRank = true
        },
        new()
        {
            Name = PowerNames.SpiderDodge,
            Description = "The character dodges attacks with a spiderlike scuttle.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "Someone makes an Agility attack against the character.",
            Duration = Duration.Instant,
            Effect =
            [
                "The attacker has trouble on the attack. If the attack misses, the character can leap in any direction at their Jump Speed.",
            ],
        },
        new()
        {
            Name = PowerNames.StoppingPower,
            Description = "The character keeps shooting at the target.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.DoubleTap}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a ranged attack on an enemy. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage, and the character can make another regular ranged attack on the same target.",
            ],
        },
        new()
        {
            Name = PowerNames.Sturdy1,
            Description = "The character has protection from physical damage.",
            PowerSets = [],
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
            PowerSets = [],
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
            PowerSets = [],
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
            PowerSets = [],
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
            Name = PowerNames.Supernova,
            Description = "The character blasts out a massive burst of their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBlast}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 or more Focus",
            Effect =
            [
                "The character makes an Ego check and compares that against the Resilience defense of every enemy within 10 spaces. For these attacks, add +1 to the character’s Ego damage bonus for every 2 points of Focus they spend. On a success, an a­ffected target takes half that total damage. On a Fantastic success, an a­ffected target takes full damage and su­ffers the elemental type’s special e­ffect.",
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
            Name = PowerNames.TelekineticAttack,
            Description = "The character can punch or choke an enemy with their mind.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticManipulation}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "5 Focus",
            Effect =
            [
                "The character makes a Logic attack against the Melee defense of a target within 5 spaces times the character’s rank. If the attack is a success, it inflicts regular damage. On a Fantastic success, the damage is doubled instead, and the target is stunned for one round.",
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
            Name = PowerNames.Uncanny1,
            Description = "The character has protection against mental assaults.",
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "Any damage multiplier for attacks against the character’s Focus is reduced by 1. If this power is part of a battle suit, the power is integrated into a removable helmet. Otherwise, it’s a part of the character.",
                "If this power stems from armor or anything else removable—like Magneto’s helmet—the character should apply the Tech Reliance trait to it."
            ],
            FocusDamageReductionModifier = -1
        },
        new()
        {
            Name = PowerNames.Uncanny2,
            Description = "The character’s mind is protected as if by steel.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Uncanny1}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "Any damage multiplier for attacks against the character’s Focus is reduced by 2.",
            ],
            FocusDamageReductionModifier = -2
        },
        new()
        {
            Name = PowerNames.Uncanny3,
            Description = "The character’s mind is protected like a tank.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Uncanny2}, Rank 4",
            Duration = Duration.Permanent,
            Effect =
            [
                "Any damage multiplier for attacks against the character’s Focus is reduced by 3.",
            ],
            FocusDamageReductionModifier = -3
        },
        new()
        {
            Name = PowerNames.Uncanny4,
            Description = "The character’s mind is protected like a battleship.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Uncanny3}, Rank 6",
            Duration = Duration.Permanent,
            Effect =
            [
                "Any damage multiplier for attacks against the character’s Focus is reduced by 4.",
            ],
            FocusDamageReductionModifier = -4
        },
        new()
        {
            Name = PowerNames.UnflappablePoise,
            Description = "The character can dodge most close attacks.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.DefenseStance}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "Any close attacks against the character have trouble. While they use Defense Stance, such attacks have double trouble.",
            ],
        },
        new()
        {
            Name = PowerNames.UnrelentingSmash,
            Description = "The character smashes everything in reach.",
            PowerSets = [PowerSetNames.SuperStrength],
            Prerequsites = $"{PowerNames.GroundShakingStomp}, {PowerNames.Mighty2}, Rank 4",
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
            Name = PowerNames.UnstoppableAssault,
            Description = "The character hews a path through their foes.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = $"{PowerNames.FuriousAttacks}, {PowerNames.FocusedFury}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes a Melee check and compares that against the Melee defense of every enemy within their reach. Any enemy the attack succeeds against takes half regular damage. On a Fantastic success, those enemies take full regular damage instead and su­ffer the weapon’s special e­ffect.",
                "The character may then pay 15 more Focus to do the same thing again—before which they can move up to half their Speed with whatever is left from their normal movement action. They can keep doing this until they run out of Speed or Focus. Each target can only be a­ ected by this attack by this character once per round."
            ],
        },
        new()
        {
            Name = PowerNames.UntouchablePosition,
            Description = "The character’s enemies struggle to gang up on them.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.CounterstrikeTechnique}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "If the character is attacked, all other close attacks against them have trouble until the start of their next turn.",
            ],
        },
        new()
        {
            Name = PowerNames.ViciousAttack,
            Description = "The character strikes a felling blow.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a close attack. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and suffers the weapon’s special effect.",
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
            Name = PowerNames.Wallcrawling,
            Description = "The character can climb like a spider.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can climb at a speed equal to their regular speed. Under normal conditions, they never lose their grip, no matter the angle of the surface.",
            ],
            ClimbSpeedEqualToBaseSpeed = true
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
            Name = PowerNames.WhirlingFrenzy,
            Description = "The character assaults a foe with a tornado of whirling attacks.",
            PowerSets = [PowerSetNames.MeleeWeapons],
            Prerequsites = $"{PowerNames.FastAttacks}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a Melee check and compares it against the Melee defense of every enemy within their reach. If an attack is a success, the enemy takes half regular damage. On a Fantastic success, the enemy takes full damage and su­ffers the weapon’s special e­ffect.",
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
