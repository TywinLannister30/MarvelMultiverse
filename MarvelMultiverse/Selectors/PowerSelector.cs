using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class PowerSelector : IPowerSelector
{
    public Power GetPower(
        string name, 
        bool isTech = false,
        bool flySpeed = false,
        bool glideSpeed = false,
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

        if (flySpeed)
            power.FlySpeed = true;

        if (glideSpeed)
            power.GlideSpeed = true;

        if (swinglineSpeed)
            power.SwinglineSpeed = true;

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
            Name = PowerNames.Anger,
            Description = "You won’t like them when they’re angry.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Mighty3}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is harmed by an attack.",
            Duration = Duration.Concentration,
            Cost = "10 or more Focus",
            Effect =
            [
                "The character becomes angry and uses that anger to increase their strength. For every 10 points of Focus they spend, they add +15 to their Melee damage bonus and lose –2 from their Logic—and subsequently their Logic defense. While using this power, they cannot use any other powers that require concentration.",
            ]
        },
        new()
        {
            Name = PowerNames.AnimalBond,
            Description = "The character can communicate with an animal friend.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character can communicate telepathically with one animal of their choice, and they must have befriended the animal before. They cannot switch to another animal unless the animal dies, but they can select this power multiple times if desired.",
                "The communication can be verbal, visual or even more complex, such as imparting location information. There is no limit to the distance of the communication, as long as the character and the animal are in the same dimension.",
                "Animals with a telepathic bond are generally willing to communicate, even if they aren’t friendly. Bonded animals often do whatever the character asks, even if it might put them in danger."
            ]
        },
        new()
        {
            Name = PowerNames.AnimalCommunication,
            Description = "The character can communicate with a type of animal.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character can communicate telepathically with one taxonomic order of animals, such as birds, mammals, fish, amphibians and so on. They can call out to them as a group up to 500 spaces per rank away, and they can communicate specifically with ones they have met or at least seen.",
                "They cannot switch to another taxonomic order, but they can select this power multiple times if desired.",
                "The communication with the animals can be verbal, visual or even more complex, such as imparting location information. There is no limit to the distance of the communication, as long as the character and the animals are in the same dimension.",
                "Friendly animals often do whatever the character asks, as long as it doesn’t put them in danger—and they may be willing to risk even that for one they consider a friend. Hostile animals simply ignore all such requests—which make them a poor choice for communication."
            ]
        },
        new()
        {
            Name = PowerNames.AnimatedIllusion,
            Description = "By manipulating visual light, the character creates a moving hologram.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.StaticIllusion}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character creates a visual-only illusion anywhere in line of sight, within 50 spaces. The illusion can be anything up to four sizes larger than the character, and it can move freely within its limits. The character breaks concentration if they move beyond 50 spaces from the illusion or lose line of sight to it.",
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
            Name = PowerNames.Blink,
            Description = "The character teleports a short distance away.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = "None",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Instant,
            Effect =
            [
                "The character teleports into a clear space they can see or have been to, up to their rank in spaces away. If someone was about to attack them and they are now out of reach or line of sight, the attack automatically fails. If they are still within reach or line of sight, the attack has trouble instead."
            ]
        },
        new()
        {
            Name = PowerNames.BlinkBarrage,
            Description = "The character teleports rapidly around an opponent.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Blink}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character teleports several times in quick succession and winds up in a clear space they can see or have been to, up to their rank in spaces away. Any attacks have trouble against them for one round."
            ]
        },
        new()
        {
            Name = PowerNames.BlinkDefense,
            Description = "The character teleports a short distance away.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Blink}, Rank 3",
            Action = ActionType.Reaction,
            Trigger = "The character or an ally within reach is the subject of a ranged attack.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character pops away just as the attack reaches them and then pops back into the same space, leaving the projectile behind. The character makes an Ego check with an edge against the attacker’s Agility check result. On a success, the projectile from the attack is teleported away, someplace safe. On a Fantastic success, the attack is turned against the attacker, using the Ego check the character just made as the attack check."
            ]
        },
        new()
        {
            Name = PowerNames.Blur,
            Description = "The character moves like a blur!",
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
            Name = PowerNames.BodySheet,
            Description = "The character can flatten themselves like a sheet.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.FlexibleBones2}, {PowerNames.ExtendedReach2}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character falls or is the target of an attack.",
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character gains Health Damage Reduction 3, but they cannot make attacks. They gain a Glide Speed equal to double their Run Speed."
            ]
        },
        new()
        {
            Name = PowerNames.BodySphere,
            Description = "The character can form their body into a protective sphere.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.BodySheet}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character or an ally is the target of an attack.",
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character forms their body into a sphere, protecting up to one ally per rank, squeezed into the same space. Those inside the sphere gain Health Damage Reduction 3 against outside attacks, but they cannot move on their own until the character releases them.",
                "Alternatively, if the attacker is within the character’s reach, the character can make an Agility check against the target’s Agility defense. On a success, the character envelops the attacker, grabbing them. On a Fantastic success, the character closes the sphere enough to pin the attacker too."
            ]
        },
        new()
        {
            Name = PowerNames.BoltsOfBalthakk,
            Description = "The character fires enchanted bolts of electricity from their fingers.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Sorcerous}, Rank 2",
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
            Name = PowerNames.BoostPowers,
            Description = "The character turbocharges all of another character’s powers!",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = $"{PowerNames.BumpPower}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 or more Focus",
            Effect =
            [
                "The character picks one character within 5 spaces and boosts all of their powers. If the powers have ranges or e­ffective areas or durations, these are doubled. If the powers a­ ect a damage multiplier, add 1 to the e­ffects. Any e­ffects that normally happen with a Fantastic successes automatically happen on any success, not just a Fantastic one.",
                "If the target’s powers have costs, the character must pay the highest of them or a minimum of 15 Focus."
            ]
        },
        new()
        {
            Name = PowerNames.BorrowSenses,
            Description = "The character can use another person’s senses.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character can use the full senses of someone or something with whom they have established a telepathic link or bond. While they do, they retain the use of their own senses too.",
            ]
        },
        new()
        {
            Name = PowerNames.BounceBack,
            Description = "The character bounces back from even the hardest falls.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.FlexibleBones1}, {PowerNames.SlipFree}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The character takes damage from a fall or is knocked prone.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The fall doesn’t damage the character. If they are prone, they stand up. If they’d like, they can also jump a number of spaces, up to their Run Speed.",
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
            Name = PowerNames.BrainDrain,
            Description = "The character consumes the energies of another.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego attack against the target’s Vigilance. If it succeeds, the target takes regular Focus damage, and the character heals half that much Focus for themselves. On a Fantastic success, the character heals their full Focus damage instead.",
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
            Name = PowerNames.BumpPower,
            Description = "The character bumps up another character's power.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 or more Focus",
            Effect =
            [
                "The character picks one power from another character within 5 spaces and boosts it. If the power has ranges or e­ffective areas or durations, these are doubled. If the power a­ffects a damage multiplier, add 1 to the e­ ect. Any e­ffects that normally happen with a Fantastic success automatically happen on any success, not just a Fantastic one.",
                "If the power has a cost, the character must pay it as well, with a minimum of 5Focus."
            ]
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
            Name = PowerNames.CharmedLife,
            Description = "The character seems like they were born lucky.",
            PowerSets = [PowerSetNames.Luck],
            Prerequsites = "Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains an edge on any single action check each round. This does not stack with any other edges."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Cloak,
            Description = "The character makes people believe they’re not there.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character uses a mirage to block their presence from the minds of people within 20 spaces per rank. Cameras (for instance) can still record them, but when people look in the character’s direction, they see nothing there.",
                "The target number for anyone trying to detect the character is the character’s Logic defense."
            ]
        },
        new()
        {
            Name = PowerNames.CloakGroup,
            Description = "The character mentally hides themselves and their friends.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Cloak}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "Using a mirage, the character blocks their presence—and the presence of up to one other person per rank, within 10 spaces—from the minds of people within 20 spaces per rank. Cameras (for instance) can still record them, but when people look in the characters’ direction, they see nothing there.",
                "The target number for anyone trying to detect the character or the others protected is the character’s Logic defense."
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
            Name = PowerNames.CloneMoves,
            Description = "The character duplicates another character’s combat moves.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 or more Focus",
            Effect =
            [
                "The character picks another character within 10 spaces and in their line of sight and duplicates all their powers that could be selected with the Special Training origin. They can now use those powers as if they were always theirs. If the copied powers have costs, the character must pay the highest of them, or a minimum of 5 Focus.",
                "When the character uses a copied power, they must pay any cost normally as well."
            ]
        },
        new()
        {
            Name = PowerNames.ClonePowers,
            Description = "The character duplicates all of another character’s powers.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = $"{PowerNames.CopyPower}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 or more Focus",
            Effect =
            [
                "The character picks another character within 10 spaces and duplicates all of their powers. They can now use those powers as if they were always theirs. If the target’s powers have costs, the character must pay the highest of them, or a minimum of 15 Focus.",
                "When the character uses a copied power, they must pay any cost normally as well."
            ]
        },
        new()
        {
            Name = PowerNames.CoilingCrush,
            Description = "The character wraps around a target and crushes it.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.ExtendedReach1}, {PowerNames.ReversePunch}, Rank 3",
            Action = ActionType.Reaction,
            Trigger = "The character grabs an enemy.",
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes a Melee attack. On a success, the enemy is paralyzed. On a Fantastic success, the enemy also takes regular damage. During the character’s subsequent turns, they can spend their movement action to make a Melee check against the enemy's Resilience. If this succeeds, they inflict regular Health damage. On a Fantastic success, they do double damage instead.",
                "During the paralyzed enemy’s turn, they can make a Melee check against the character’s Melee defense to break free."
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
            Name = PowerNames.ControlFog,
            Description = "The character can create or dispel a thick fog.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character creates a thick fog for up to 50 spaces per rank around them that blocks all line of sight beyond 10 spaces. They can also dispel any fog in a similar area.",
            ]
        },
        new()
        {
            Name = PowerNames.ControlWeather1,
            Description = "The character can make it rain.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "It starts to rain in an area up to 5 miles across times the character’s rank, centered on the character. All ranges are cut in half. Movement is not a­ffected.",
            ]
        },
        new()
        {
            Name = PowerNames.ControlWeather2,
            Description = "The character can make it storm.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = $"{PowerNames.ControlWeather1}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "It starts to storm in an area up to 5 miles across times the character’s rank, centered on the character. All ranges and all speeds are cut in half.",
            ]
        },
        new()
        {
            Name = PowerNames.ControlWeather3,
            Description = "The character creates a thunderstorm.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = $"{PowerNames.ControlWeather2}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "It starts to storm in an area up to 5 miles across times the character’s rank, centered on the character. All ranges and all speeds are cut in half.",
                "If the character also has the Elemental Blast (Electricity) power, they can use it as a reaction when attacked while this power is active."
            ]
        },
        new()
        {
            Name = PowerNames.ControlWeather4,
            Description = "The character generates a hurricane.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = $"{PowerNames.ControlWeather3}, Rank 5",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "20 Focus",
            Effect =
            [
                "It starts to storm in an area up to 5 miles across times the character’s rank, centered on the character. All ranges and all speeds are cut to one quarter normal, and flying is impossible.",
                "If the character also has the Elemental Barrage (Electricity) power, they can use it as a reaction when attacked while this power is active."
            ]
        },
        new()
        {
            Name = PowerNames.CopyAbility,
            Description = "The character duplicates another character’s ability.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character picks one ability score of another character within 10 spaces and duplicates it. They now use that ability score in place of their own.",
            ]
        },
        new()
        {
            Name = PowerNames.CopyPower,
            Description = "The character duplicates another character’s power.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character picks one power a target within 10 spaces has and duplicates it. They can now use it as if it was always theirs. When the character uses such a power, they must pay any cost normally as well.",
            ]
        },
        new()
        {
            Name = PowerNames.CopyTrait,
            Description = "The character duplicates another character’s trait.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character picks one trait another character within 10 spaces has and duplicates it. They can now use it as if it was always theirs.",
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
            Name = PowerNames.CoveringFire,
            Description = "The character covers an ally’s attack.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.ReturnFire}, Rank 3",
            Action = ActionType.Reaction,
            Trigger = "An ally within the character’s line of sight begins its turn.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Agility attack against a target’s Vigilance defense. If the attack is a success, apply Health Damage Reduction normally. The target takes any damage to their Focus. If it’s a Fantastic success, the damage is doubled, and if the target takes any Focus damage, they are stunned for one round.",
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
            Name = PowerNames.CureAll,
            Description = "The character can cure what ails you—mostly.",
            PowerSets = [PowerSetNames.Healing],
            Prerequsites = $"{PowerNames.HealingHands}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "Reach",
            Cost = "15 Focus",
            Effect =
            [
                "With a touch, the character can cure any temporary ailments a target suffers from. The character makes an Ego vs. TN 12 action check. On a success, the effects of the ailment end immediately. On a Fantastic success, treat the result like a recovery check, and the target gains back that much of any Health and Focus lost to the condition.",
                "This can affect conditions including ablaze, bleeding, blinded, corroding, deafened, demoralized, paralyzed, poisoned and unconscious. If the target was demoralized, they now have 1 Focus, and if the target was unconscious, they now have 1 Health. (They can have more if the character got a Fantastic success and recovered more for them.)",
                "Note that this only works on acute conditions and diseases, those the target has contracted recently and that would—under ideal circumstances—resolve soon, leaving them alive. It does not affect chronic or permanent diseases or serious diseases that are likely to be fatal.",
                "For instance, it can cure temporary deafness but not permanent deafness. It can stop an allergy attack but not the allergies themselves. It can cure poison but not cancer. It has no effect against the Techno-Organic virus, the Transmode virus, the Legacy virus or other such diseases."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.DampenPower,
            Description = "The character tamps down another character’s power.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "Varies",
            Effect =
            [
                "The character picks one power from another character within 20 spaces and makes an Ego attack against them. On a success, they tamp the power down. If the power has ranges or e­ffective areas or durations, these are halved. If the power affects a damage multiplier, subtract 1 from the effect. The power can no longer enjoy Fantastic successes.",
                "If the power has a Focus cost, the character must also pay that cost to dampen it."
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
            Name = PowerNames.DangerSense,
            Description = "The character can feel danger on the way.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = $"{PowerNames.Precognition1}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "Even if the character doesn’t get a Fantastic result on their initiative check, they get a turn during the bonus round of any combat they are in. This works even if no one else in the combat can act in the bonus round.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Dazzle,
            Description = "The character blasts a blinding light into the face of their foe.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.Illumination}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego check against an enemy in their line of sight and compares that against the target’s Vigilance defense. If the attack is a success, the enemy is blinded for 1 turn. On a Fantastic success, it also inflicts regular damage.",
                "Alternatively, the character can blind the victim with darkness."
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
            Name = PowerNames.DetectLie,
            Description = "The character can tell if you’re telling the truth.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = $"{PowerNames.UnderstandBodyLanguage}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "Verbal communication the character can understand",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "When someone communicates in an active form the character can understand—verbally, telepathically, using sign language and so on—the character can make an Ego check against the communicator’s Ego defense. On a success, the character knows if the communicator is lying. On a Fantastic success, they also know (if possible) why the communicator is lying.",
                "This power does not allow the character to know the truth, although they may be able to figure it out by detecting lies. Also, it only works on communicators who know they are lying. If they believe what they are saying—even if it is wrong—no lie can be detected."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.DimensionalPortal,
            Description = "The character opens a portal to another place.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.DimensionalTravelTogether}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character opens a glowing portal in a space next to them that moves anything that enters it between that space and its destination, which forms a matched glowing portal in the other place. The other end of the portal must be in a clear space in another dimension that the character has been to. Anything can move through the portal in either direction until it is closed, which the character can do at will.",
            ]
        },
        new()
        {
            Name = PowerNames.DimensionalTravel,
            Description = "The character moves from one dimension to another.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = "Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character instantly moves from their current dimension to another dimension within the same universe. For instance: from Earth to Asgard, Limbo or K’un-Lun. When they move to the other dimension, they can arrive in any place they’ve been to before. Otherwise, they arrive at the most common entrance to that dimension.",
            ]
        },
        new()
        {
            Name = PowerNames.DimensionalTravelOther,
            Description = "The character sends someone to another dimension.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.DimensionalTravel}, Rank 4",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes an Ego check against the Vigilance defense of a target they have grabbed. If the check is successful, the character can send the target to another dimension. The target can be sent to any location in that dimension that the character has been to before. Otherwise, the target arrives at the most common entrance to that dimension.",
            ]
        },
        new()
        {
            Name = PowerNames.DimensionalTravelTogether,
            Description = "The character brings someone with them to another dimension.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.DimensionalTravel}, Rank 3",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character moves to a di­fferent dimension, taking any person they are touching with them. If the target does not wish to come along, the character must grab them first.",
                "When they move to the other dimension, they can arrive in any place they’ve been to before. Otherwise, they arrive at the most common entrance to that dimension."
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
            Prerequsites = $"{TagNames.Sorcerous}, Rank 4",
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
            Name = PowerNames.DisruptElectronics,
            Description = "The character can scramble electronics by moving through them.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "When phasing through electronics, the character can scramble them, causing them to either shut down or crash. In the case of powers that are Tech Reliant (and feature electronics), they are unusable for one turn while they reboot."
            ],
        },
        new()
        {
            Name = PowerNames.DisruptNerves,
            Description = "The character can scramble someone’s nervous system.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "When phasing through a person, the character can attempt to scramble their nervous system. The character makes an Ego check against the target’s Resilience defense. On a success, the target is stunned for one round. On a Fantastic success, the target also falls prone."
            ],
        },
        new()
        {
            Name = PowerNames.DisruptPerson,
            Description = "The character can hurt someone with their phasing powers.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character becomes the slightest bit solid while phasing themselves or a phased weapon through someone. They make a close attack. On a success, the attack does normal damage, ignoring any Health Damage Reduction. On a Fantastic success, the attack does double damage instead, ignoring any Health Damage Reduction, and the target is stunned for one round."
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
            Name = PowerNames.Domination,
            Description = "The character forces someone to follow their orders—permanently.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Orders}, Rank 5",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Cost = "20 Focus",
            Effect =
            [
                "The character dominates a target with whom they’ve established a Telepathic Link and who has no Focus left. The character makes a Logic check with trouble against the target’s Logic defense. On a success, the target is completely dominated and will follow the character’s orders. On a Fantastic success, the character gains an edge the next time they use this power against this same target.",
                "The result of the character’s check is the target number for any attempts by the target to end the domination. If any order involves harming someone, the target gets to make a Logic check to end the domination. If the target has the Heroic tag, they get an edge on the check.",
                "If the order would cause the target to harm themselves, the target gets an edge on the check. If they have the Heroic tag, they get a double edge."
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
            Name = PowerNames.ElementalForm,
            Description = "The character’s body is made of their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalReinforcement}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character’s body is made entirely of their element, which gives them a steady supply of their element to use and makes them essentially unkillable. When they lose all their Health, their form loses its cohesion and falls apart. When they have at least 1 Health—which they can gain back over time, normally— they can re-form.",
                "If the character wishes to use their elemental body in unusual ways, they should pick Plasticity powers. If they wish to be able to be fully human at times, they should take the Shape-Shift power."
            ],
        },
        new()
        {
            Name = PowerNames.ElementalGrab,
            Description = "The character uses their element to snare a target.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBurst}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego attack against a target’s Melee defense within 5 spaces times the character’s rank. If the attack is a success, the character grabs the target with their element. On a Fantastic success, the target can also be pinned and su­ffers the element’s special e­ffect. Breaking free requires a successful Melee check against target number 20.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalInfusion,
            Description = "The character infuses a weapon with their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalBurst}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character infuses their energy into a handheld weapon in their grasp. When the character gets a Fantastic success attacking with the weapon, add the energy’s special e­ffect.",
            ],
        },
        new()
        {
            Name = PowerNames.ElementalPrison,
            Description = "The character can create a cage of their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalProtection1}",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "Same as the character’s Elemental Protection power",
            Effect =
            [
                "The character picks a point within their line of sight and traps any chosen targets within up to 5 spaces times their rank—in a prison comprised of their element. When the Elemental Prison is formed, the character makes an Ego check and compares the results against the Agility defense of targets inside the enclosed spaces. On each success, the character traps the target within the prison’s perimeter. On a Fantastic success, such imprisoned people su­ffer full damage and the element’s special e­ffect too.",
                "Attacks against the prison are against the character’s Ego defense. Any attacks against the prison are absorbed as if made against the character’s Elemental Protection power, and the prison continues. If an attack does more damage than the character’s Elemental Protection power can sustain, it destroys the prison, but no one inside is harmed."
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
            Name = PowerNames.ElementalSphere,
            Description = "The character can create a protective sphere of their element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalProtection1}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Duration = Duration.Concentration,
            Cost = "Same as the character’s Elemental Protection power",
            Effect =
            [
                "The character envelops themselves—and any chosen people within up to 5 spaces times their rank—in a protective sphere comprised of their element.",
                "When the sphere is formed, the character makes an Ego check and compares the results against the Agility defense of unwanted characters in the enclosed spaces. On a success, the character can move any unwanted people within the sphere’s perimeter to spaces outside of the sphere. On a Fantastic success, such moved people su­ffer full damage and the element’s special effect.",
                "Attacks against the sphere are against the character’s Ego defense. Any attacks against the sphere are absorbed as if made against the character’s Elemental Protection power, and the sphere continues. If an attack does more damage than the character’s Elemental Protection power can sustain, it destroys the sphere, but no one inside is harmed."
            ],
        },
        new()
        {
            Name = PowerNames.ElementalSuffocation,
            Description = "The character envelops a target’s head in an element.",
            PowerSets = [PowerSetNames.ElementControl],
            Prerequsites = $"{PowerNames.ElementalGrab}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The target is grabbed with Elemental Grab.",
            Duration = Duration.Instant,
            Range = "Varies",
            Cost = "15 Focus",
            Effect =
            [
                "The character makes an Ego attack against the grabbed target’s Resilience defense. If the attack is a success, the target takes regular damage. On a Fantastic success, the target can also be pinned and su­ffers the element’s special e­ffect.",
                "With elements that aren’t suited to suffocation, this power chokes the target instead.",
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
            Name = PowerNames.EvilEye,
            Description = "The character can inflict trouble on those who cross their path.",
            PowerSets = [PowerSetNames.Luck],
            Prerequsites = $"{PowerNames.JinxYou}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "5 spaces per rank",
            Cost = "5 Focus per turn",
            Effect =
            [
                "The character picks a foe in their line of sight. That foe has trouble on all action checks made for the power’s duration. There is no limit on the range between the character and the foe once the power is activated.",
                "The character must pay the Focus cost at the start of each of their subsequent turns of concentration to keep the power working."
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.ExtendInvisibility,
            Description = "The character makes something else invisible.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.Invisibility}",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes something—a single person or object—within reach invisible. This can be one size bigger than them for every rank they have.",
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
            Description = "The character shoots jets of enchanted fire from their hands.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Sorcerous}, Rank 2",
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
            Name = PowerNames.Flare,
            Description = "The character generates a dazzling flare of light.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.Illumination}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character makes an Ego check and compares that against the Vigilance defense of every enemy within 5 spaces. Each beaten enemy is blinded for one turn. On a Fantastic success, the fl are infl icts regular damage too."
            ],
        },
        new()
        {
            Name = PowerNames.FlexibleBones1,
            Description = "The character’s skeleton is rubbery.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 1. They also have an edge on Agility checks for contortion and escape."
            ],
            HealthDamageReductionModifier = -1
        },
        new()
        {
            Name = PowerNames.FlexibleBones2,
            Description = "The character’s skeleton is flexible and pliable.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.FlexibleBones1}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains Health Damage Reduction 2. They also have a double edge on Agility checks for contortion and escape."
            ],
            HealthDamageReductionModifier = -2
        },
        new()
        {
            Name = PowerNames.FlexibleFingers,
            Description = "The character can turn their fingers and hands into whatever tool they need.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "With a standard action, the character can automatically pick any lock that requires a physical key. They can also shape their hands to form almost any other kind of simple tool."
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
            Name = PowerNames.FocusedStrike,
            Description = "The character finds the right spot and strikes.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.ChainStrikes}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 or more Focus",
            Effect =
            [
                "The character makes a close attack. Add +1 to the character’s Melee damage bonus for every 2 points of Focus they spend. On a success, an a­ ected target takes that total damage. On a Fantastic success, an a­ ected target takes double that total damage and is stunned for one round."
            ],
        },
        new()
        {
            Name = PowerNames.Fool,
            Description = "The character makes people believe they are someone else.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character uses a mirage to alter their appearance in the minds of anyone within 20 spaces per rank. Cameras (for instance) can still record them normally, but when people look in the character’s direction, they see someone else.",
                "The target number for anyone trying to see through the mirage is the character’s Logic defense. If the character is impersonating someone known to the other person, that person has an edge."
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
                "The character splits their attack to make two close attacks against separate targets within reach (or they can focus a single attack on a single target). Make a single Melee check and compare it to the targets’ Melee defenses. For these attacks, add +1 to the character’s Melee damage bonus for every 2 points of Focus they spend. On a success, an a­ffected target takes half that total damage. On a Fantastic success, an a­ ected target takes full damage and su­ffers the weapon’s special e­ffect."
            ],
        },
        new()
        {
            Name = PowerNames.GrandFool,
            Description = "The character mentally makes the group they’re with appear to be like other people.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Fool}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character uses a mirage to alter their appearance—and the appearance of up to one other person per rank, within 10 spaces—in the minds of people within 20 spaces per rank. Cameras (for instance) can still record them, but when people look in the characters’ direction, they see other people.",
                "The target number for anyone trying to see through the mirage is the character’s Logic defense. If the a­ ected characters are impersonating people known to the other person, that person has an edge."
            ],
        },
        new()
        {
            Name = PowerNames.GrandIllusion,
            Description = "By manipulating light and sound, the character creates an incredibly real hologram.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.AnimatedIllusion}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character creates a sound and sight illusion anywhere in line of sight, within 50 spaces. The illusion can be of anything up to fi ve sizes larger than the character, and it can move freely within its limits. The character breaks concentration if they move beyond 50 spaces from the illusion or lose line of sight of it.",
            ]
        },
        new()
        {
            Name = PowerNames.GrandMirage,
            Description = "The character can make a mirage appear in a group’s mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Mirage}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character creates a full-sensory mirage that a­ffects everyone in a Telepathic Network they set up who is also in the same locale. The mirage can be of anything the character desires, and it can move freely."
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
            Name = PowerNames.GroupFlight,
            Description = "The character can carry others with them into the sky.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Flight1}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "For every point of Ego the character has, they can hoist one ally into the air with them. The Flight Speed of the group is half the character’s, and all a­ ected allies must remain within 5 spaces times the character’s rank. The character controls each ally’s speed and position during the character’s turn, but they can release any or all allies at any time."
            ]
        },
        new()
        {
            Name = PowerNames.GroupInvisibility,
            Description = "The character can make something else invisible.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.ExtendInvisibility}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "For every point of Ego defense the character has, they can make one person or thing invisible, including themselves. Each of these can be one size bigger than them for every rank they have.",
            ],
        },
        new()
        {
            Name = PowerNames.GroupLevitation,
            Description = "The character can lift others into the air too.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.Levitation}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character can move up to one person per rank through the air in any direction at the character’s Run Speed. The levitated target(s) must remain within 5 spaces times the character’s rank. If any target does not wish to be moved like this, they must be telekinetically grabbed first.",
            ],
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
            Name = PowerNames.HealingHands,
            Description = "The character has a healing touch.",
            PowerSets = [PowerSetNames.Healing],
            Prerequsites = $"{PowerNames.LetsGo}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "Reach",
            Cost = "10 or more Focus",
            Effect =
            [
                "The character can heal a target creature with a touch. For every point of Focus the character spends, the target regains a point of Health, up to their maximum score. The character must spend at least 10 Focus to use the power. Any Health points that would have been healed beyond the target’s maximum Health are lost.",
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.HexBolt,
            Description = "The character hurls a hex bolt at their foe.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Chaotic}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character fires a hex bolt at a foe. Make an Ego check against the target’s Agility defense. On a success, the attack does regular damage. On a Fantastic success, it does double damage and causes the target trouble for one round.",
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
            Name = PowerNames.HitTheDirt,
            Description = "The character gets their allies to take cover.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.KeepMoving}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy in line of sight makes an attack on an lly within earshot.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "All allies within earshot can fall prone if they wish and are able to. If falling prone makes the ally an ineligible target for the initial attack, the attack automatically fails.",
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
            Name = PowerNames.Illumination,
            Description = "The character creates a bright light.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character illuminates one object or point in line of sight, within 50 spaces, with bright light. The character can maintain concentration on the e­ ect even if they move out of range or line of sight.",
            ],
        },
        new()
        {
            Name = PowerNames.Indecipherable,
            Description = "The character has a language all their own.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = $"{PowerNames.UnderstandSpokenLanguage}, {PowerNames.UnderstandUnusualCommunication}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character has constructed an internal language that only they can understand. They think in this language entirely, and when they communicate with others, they are translating from that language. This effectively renders them immune to telepathic powers like Mind Reading or Mind Interrogation, as anyone trying to read their mind cannot understand this unique language.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.ImagesOfIkonn,
            Description = "The character creates illusory duplicates of a person.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Sorcerous}, Rank 2",
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
            Name = PowerNames.InformationUpload,
            Description = "The character can transmit loads of information straight into another’s mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character transmits a knowledge-based label (a trait or tag) of their own to a target with whom they have established a telepathic link—willing or not. The label lasts until the target sleeps.",
                "The character can also impart any other kind of knowledge they have to a target this way. The process is almost instantaneous."
            ]
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
            Name = PowerNames.InstantReplay,
            Description = "The character rewinds time.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = "Rank 3",
            Action = ActionType.Reaction,
            Trigger = "The character fails a check.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "Once per battle, the character can make a second attempt at a check that they just failed, erasing and replacing the first attempt entirely.",
            ],
        },
        new()
        {
            Name = PowerNames.Integrity,
            Description = "The character can think their way through.",
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can use their Logic defense score against Ego attacks too.",
            ],
            LogicInsteadOfEgoForDefence = true
        },
        new()
        {
            Name = PowerNames.Intuition,
            Description = "The character has a bad feeling about this.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "When faced with a decision, the character can get a feeling about which choice would be best for them in the long run. When activating this power, the player presents the choice to the Narrator, and the Narrator tells them which choice the intuition is leading the character toward.",
                "Characters should take care when using this power. What is best for them might not be best for the rest of the team or anyone else they care about. Also, what’s best in the long run might not be best for the character in the short run. In fact, what’s best is often up for interpretation."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Invisibility,
            Description = "The character turns as transparent as glass.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character becomes invisible. They have an edge on Agility checks to sneak past people, and enemies have trouble on Vigilance checks to perceive them. It’s even harder to spot things that are invisible but aren’t moving. Characters must be actively trying to do so to be able to make a Vigilance check.",
            ],
        },
        new()
        {
            Name = PowerNames.Jinx,
            Description = "The character puts a jinx on a foe.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Chaotic}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego check against the target’s Ego defense. If it succeeds, the target has trouble on all actions. On a Fantastic success, the target loses their next standard action.",
            ]
        },
        new()
        {
            Name = PowerNames.JinxYou,
            Description = "The character can hit you with a jinx.",
            PowerSets = [PowerSetNames.Luck],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "Reach",
            Cost = "5 Focus per turn",
            Effect =
            [
                "The character makes a Melee check to touch the target. On a success, the power takes effect, and that foe has trouble on all action checks made for the power’s duration. On a Fantastic success, the target also takes standard (not doubled) Melee damage.",
                "The character must pay the Focus cost at the start of each of their subsequent turns of concentration to keep the power working."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.JinxYouAll,
            Description = "The character can jinx a whole group of foes at once.",
            PowerSets = [PowerSetNames.Luck],
            Prerequsites = $"{PowerNames.EvilEye}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "5 spaces per rank",
            Cost = "10 Focus per turn",
            Effect =
            [
                "The character picks up to one foe per rank in their line of sight. Those foes have trouble on all action checks made for the power’s duration. There is no limit on the range from the character to their foes once the power is activated.",
                "The character must pay the Focus cost at the start of each of their subsequent turns of concentration to keep the power working."
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.KillZone,
            Description = "The character shoots at every target that moves through their kill zone.",
            PowerSets = [PowerSetNames.RangedWeapons],
            Prerequsites = $"{PowerNames.CoveringFire}, {PowerNames.Headshot}, Rank 4",
            Action = ActionType.Reaction,
            Trigger = "An enemy in the character’s line of sight starts to move.",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes a ranged attack on the enemy. If the attack is a success, the enemy takes normal damage. On a Fantastic success, the enemy takes double damage. Either way, the character regains their reaction. Each target can be a­ ected by this attack by this character only once per round."
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
            Name = PowerNames.LeechLife,
            Description = "The character consumes the life force of another.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = "Rank 2",
            Action = ActionType.Reaction,
            Trigger = "Target is grabbed.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes an Ego attack against the target’s Resilience defense. If it succeeds, the target takes regular Health damage, and the character heals half that much Health for themselves. On a Fantastic success, the character heals the full Health damage instead."
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
            Name = PowerNames.LetsGo,
            Description = "The character can get a friend back on their feet.",
            PowerSets = [PowerSetNames.Healing],
            Prerequsites = "Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The target is knocked unconscious.",
            Duration = Duration.Concentration,
            Range = "Reach",
            Cost = "5 Focus",
            Effect =
            [
                "The character can eliminate the effects of a target losing all of their Health. Rather than falling unconscious, the target remains awake and mobile. They can use movement actions but not reactions or standard actions.",
                "This does not protect a character from death. They can be killed normally, and this power cannot bring back a dead character.",
                "Once the power takes effect, the target does not have to remain within the character’s reach. When the effect ends, if the target has 0 Health or less, they become unconscious.",
                "If the target’s Health rises above 0 at any point, this power automatically ends."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Levitation,
            Description = "The character can hover and move.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can move through the air in any direction at their Run Speed."
            ],
            LevitationSpeed = true
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
            Name = PowerNames.LuckyMe,
            Description = "Things are about to go the character’s way.",
            PowerSets = [PowerSetNames.Luck],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus per turn",
            Effect =
            [
                "The character gains an edge on all action checks made while this power is in effect. The character must pay the Focus cost at the start of each of their subsequent turns of concentration to keep the power working.",
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.MacrodimensionalTravel,
            Description = "The character outgrows the universe!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Grow4}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character can grow enough to travel into the Macroverse, the Overspace or other dimensions of enlarged space. They can return to their normal size at will.",
                "Note that this is something that most characters would rarely want to do, as it removes them entirely from their regular universe and places them in a dimension in which the rules of time and space work di­ erently. An hour in the Macroverse, for example, is roughly equivalent to a month in a regular universe. A trip to the Overspace is too overwhelming for most minds to handle.",
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
            Name = PowerNames.MentalPunch,
            Description = "The character can blast a foe’s mind in melee.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes a Melee attack against a target. If the attack is a success, it inflicts regular Focus damage (instead of Health damage). On a Fantastic success, the target takes double damage instead and is stunned for one round.",
            ],
        },
        new()
        {
            Name = PowerNames.MentalShelter,
            Description = "The character can create a shelter for their mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Uncanny1}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character extends their mental defenses to protect any chosen people within up to 5 spaces times their rank. The protected targets are granted Focus Damage Reduction equal to the character’s Uncanny power.",
            ],
        },
        new()
        {
            Name = PowerNames.MicrodimensionalTravel,
            Description = "The character shrinks out of the universe!",
            PowerSets = [PowerSetNames.Resize],
            Prerequsites = $"{PowerNames.Shrink4}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character can shrink enough to travel into subatomic realms. They can return to their normal size at will.",
                "Note that this is something that most characters would rarely want to do, as it removes them entirely from their regular universe and places them in a dimension in which the rules of time and space work di­ erently. The Underspace, for example, might make a fi ne place to hide, but there’s little else of interest there."
            ],
        },
        new()
        {
            Name = PowerNames.MicroscopicAwareness,
            Description = "The character can detect details about the smallest things.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "1 space per rank",
            Cost = "5 Focus",
            Effect =
            [
                "The character can see and identify items that would normally require a microscope to detect, much less comprehend. This includes things like fingerprints, a single strand of hair and even a person’s DNA. In the case of DNA, the character can use this to identify a person and link them to close relatives with similar DNA.",
            ],
            Source = BookSource.XMenExpansion
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
            Prerequsites = $"{PowerNames.Mighty1}, Rank 2",
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
            Prerequsites = $"{PowerNames.Mighty2}, Rank 3",
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
            Prerequsites = $"{PowerNames.Mighty3}, Rank 4",
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
            Name = PowerNames.MindInterrogation,
            Description = "The character can root through a target’s mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.MindReading}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.OneRound,
            Cost = "5 Focus",
            Effect =
            [
                "The character can delve into the mind of a single person with whom they have established a telepathic link. This requires a Logic check against the target’s Logic defense. On a success, the character can ask a single simple question and get the answer from the target’s mind. On a Fantastic success, the character can get more complex information.",
            ],
        },
        new()
        {
            Name = PowerNames.MindReading,
            Description = "The character can read thoughts.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}",
            Action = ActionType.Standard,
            Duration = Duration.OneRound,
            Effect =
            [
                "The character can read the thoughts of a single person with whom they have established a Telepathic Link. This requires a Logic check against the target’s Logic defense. On a success, the character can read the target’s surface thoughts. On a Fantastic success, the character can ask a single simple question and get the answer from the target’s mind.",
            ],
        },
        new()
        {
            Name = PowerNames.Mirage,
            Description = "The character can make mirages appear in a target’s mind.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character creates a full-sensory mirage that a­ffects any target with whom they have established a link. The mirage can be of anything the character desires, and it can move freely.",
            ],
        },
        new()
        {
            Name = PowerNames.MirrorImages,
            Description = "The character conjures up illusory duplicates of themselves.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.AnimatedIllusion}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character creates one sound and sight illusory duplicate of themselves per rank. The duplicates look and sound exactly like them and are under their complete control. They start in the same space as the character and instantly move into any open space around them, up to 2 spaces away, during which time the character can swap places with any of the duplicates. The character’s player should secretly record which one is the actual character.",
                "The duplicates can move up to 2 spaces away from the character, and they can pretend to attack (and miss) opponents. Any attack that hits a duplicate instantly removes it. If the character successfully attacks someone or does something else to make the truth evident, the illusion ends."
            ]
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
            Name = PowerNames.MolecularDestabilization,
            Description = "The character causes something to vibrate fast enough to explode.",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"{PowerNames.SpeedRun2}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes a close attack against an object their size or smaller. If the attack is a success, the object explodes. All targets within 2 spaces of the object— other than the character—take regular damage. On a Fantastic success, double the damage and ignore any Health Damage Reduction.",
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
            Name = PowerNames.NeverSurrender,
            Description = "The character can help a friend rally.",
            PowerSets = [PowerSetNames.Healing],
            Prerequsites = "Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "Reach",
            Cost = "5 Focus",
            Effect =
            [
                "The character can eliminate the effects of a target losing all of their Focus. Rather than becoming demoralized, the target can function normally without having trouble on all their actions due to their lack of Focus. They cannot spend more Focus, though, and they can still be shattered.",
                "Once the power takes effect, the target does not have to remain within the character’s reach. When the effect ends, if the target has 0 Focus or less, they become demoralized.",
                "If the target’s Focus rises above 0 at any point, this power automatically ends.",
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.Orders,
            Description = "The character forces someone to follow a complex set of orders.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Command}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Cost = "15 Focus",
            Effect =
            [
                "The character gives an order to a target with whom they’ve established a Telepathic Link and who has no Focus left. The character makes a Logic check against the target’s Logic defense. On a success, the target complies with the orders. On a Fantastic success, the character gains an edge the next time they use this power against this same target.",
                "The command must be to do something that can be completed in an hour or less. If it involves harming someone, the character has trouble on the check. If it would cause the target to harm themselves, the character has double trouble on the check."
            ],
        },
        new()
        {
            Name = PowerNames.PartialPhase,
            Description = "The character can make a portion of themselves tangible or intangible.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character has greater control over their phasing ability. They can make any portion of their body and clothing tangible or intangible, as they like.",
            ],
        },
        new()
        {
            Name = PowerNames.PenanceStare,
            Description = "The character can punish the wicked with their gaze.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Cursed}",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes an Ego attack against a target character within 3 spaces per rank. If it’s a success, the target takes Focus damage. On a Fantastic success, the target takes double damage and is paralyzed for one round.",
                "Characters with the Heroic tag take half the listed damage from this power in either case.",
                "If a target is shattered by this power, they can recover, but they come back in one of two ways. Either they are cleansed of their sins and ready to make a new start with a clean slate, or their emotions are drained from them permanently. How this works in each case is up to the Narrator."
            ],
        },
        new()
        {
            Name = PowerNames.PhaseObject,
            Description = "The character can make something they’re touching intangible.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character can make any object they are touching intangible. The object (and things attached to or inside of it) can be up to their rank in sizes bigger than them. For example, if they are Rank 5, the object can be 5 sizes bigger than them. For an average person, this would be Gargantuan.",
            ],
        },
        new()
        {
            Name = PowerNames.PhaseOther,
            Description = "The character can phase someone they are touching.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character can make any person (and their clothing) they are touching intangible. The character can also phase any people the initial person is touching or grabbing. People the character has phased remain tangible to each other.",
                "If the target does not wish to be phased, the character must grab them first. When contact is broken, the phasing for those no longer in contact with the character (even indirectly) ends.",
                "If a person is inside something when they stop phasing, they are automatically pushed out of it but take damage from the disruption equal to a standard action check. The damage multiplier is 1 for every space they must move to reach a clear area. If this kills them, their body is trapped inside the material they were phased into."
            ],
        },
        new()
        {
            Name = PowerNames.PhaseSelf,
            Description = "The character can become as intangible as a ghost.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character (and their clothing) becomes intangible and can move through anything as if it wasn’t there. Nothing can physically a­ ect them, nor can they a­ ect anything else that is not phasing along with them.",
            ],
        },
        new()
        {
            Name = PowerNames.PhaseWalk,
            Description = "The character can walk on air.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 2",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "When phasing, the character can move freely in any direction through anything—not just air, but also water, buildings and so on—at their Run Speed. The character can take anything or anyone they are phasing along with them.",
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
            Name = PowerNames.PossessVehicle,
            Description = "The character takes control of a vehicle.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Cursed}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character takes magical control of a vehicle they are inside of or touching. Hellfire engulfs the outside of the vehicle, but it does no damage to it. Anyone that comes into contact with it, though, takes regular damage with a damage multiplier equal to the character’s rank. On a Fantastic success, it inflicts regular Health damage and regular Focus damage instead.",
                "The character controls the vehicle by will, as long as it is within 20spaces times the character’s rank. They use their Ego for all checks to operate it, and they get an edge on all such checks.",
                "The vehicle’s speed doubles. It can climb walls at this speed and can even make jumps at that same speed."
            ],
        },
        new()
        {
            Name = PowerNames.PowerSlider,
            Description = "The character’s power waxes and wanes with what’s vital to them.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character has a single criterion that affects the strength of their powers on a spectrum. The character starts off normal, but they can become boosted or dampened from there.",
                "When things are going well for the character, all of their other powers are boosted. If the powers have ranges or effective areas or durations, these are doubled. If the powers affect damage multipliers, add 1 to the effects. Any effects that normally happen on a Fantastic success automatically happen on any success, not just a Fantastic one. Also, anything that would dampen their powers only brings them back to normal.",
                "When things are going poorly for the character, all of their other powers are dampened. If the powers have ranges or effective areas or durations, these are halved. If the powers affect damage multipliers, subtract 1 from the effects. The powers can no longer enjoy Fantastic successes. Also, anything that would boost their powers only brings them back to normal.",
                "These effects last for a single combat or—if they happen outside of combat—a single day.",
                "Here are some criteria to pick from: confidence, faith and media popularity. With the Narrator’s consent, players can come up with others.",
                "- Confidence: If the character gets a Fantastic success on an important action check, their confidence soars, and their powers are boosted. If the character fails an important action check, their confidence falls, and their powers are dampened.",
                "- Faith: If something the character believes as a core part of their faith is shown to be true, their faith soars and their powers are boosted. If something the character believes as a core part of their faith is shown to be doubtful, their faith falls, and their powers are dampened.",
                "- Media Popularity: If the character’s media ratings substantially rise (more people watch their shows), their powers are boosted. If the character’s media ratings substantially fall (fewer people watch their shows), their powers are dampened.",
                "- Serenity: The character’s criterion is maintaining their serenity by keeping cool. If they takes Focus damage, they must make an Ego check with the TN equal to the amount of Focus damage sustained. If they succeeds, their powers are boosted. If they fail, their powers are dampened.",
                "The criteria in question may go up and down often, seeming to leave the character to the whims of fate, but ignore minor changes. Only something that feels like a special moment should cause a change.",
                "Players may be tempted to set up their characters to constantly succeed. If this happens, Narrators should remember that they can often tip matters in the other direction. The swinging back and forth makes things more fun than keeping them always on an even keel."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.PowerfulHex,
            Description = "The character simulates another power with their magic.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Chaotic}, Rank 2",
            Action = ActionType.Standard,
            Duration = "Varies",
            Cost = "5 or more Focus",
            Effect =
            [
                "The character casts a hex that allows them to use any other power that they have the rank to use, even if they would not normally meet the power’s other prerequisites. They must pay whatever the regular Focus cost is for that power, plus 5 Focus.",
                "If the duration of the used power is permanent, it is concentration for the character instead. If the power is a numbered permanent power (like Mighty 3), the Focus cost is 5 times that number instead. (Mighty 3 would cost 15 Focus.)",
            ],
        },
        new()
        {
            Name = PowerNames.Precognition1,
            Description = "The character can see the near future.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = $"{PowerNames.Intuition}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character gains a sense of what is going to happen to a particular person, place or item within their reach—including themselves—in the next 24 hours. The further out any particular future is, the harder it is for the character to be certain about elements of that future. However, they can sense broad paths. Especially perilous or likely (or worse, both) possibilities stand out like beacons in the night.",
                "The player can ask the Narrator a single question about the day ahead and get an honest answer based upon what the Narrator thinks is most likely to happen. The Narrator should give short and direct answers without detailed descriptions. It is perfectly fine for the answer to be cryptic and to leave the player with more questions than they started with.",
                "These answers do not dictate what is fated to happen. They only give hints as to possible futures. The choices the players make and the chances they take have a tremendous impact upon these outcomes.",
                "Terribly unlikely things happen all the time, which means that the character’s sense of the future is not infallible. However, they are rarely outright wrong.",
                "This is a great power for a character the Narrator controls. They can use it to lead the players around, give them guidance and perhaps even set them up for a horrible betrayal. The characters, of course, don’t have to believe what a precognitive character tells them and might even openly defy their advice.",
                "However, this can be an incredibly challenging power to handle as a player. The Narrator shouldn’t spoon-feed details to the player. They should answer the player’s questions in generalities when possible and not offer extra details. If the player isn’t concerned enough about something to ask about it, then it doesn’t occur to the character to consider that particular aspect of the future either.",
                "If appropriate, the Narrator can state that the future is too uncertain to be determined at any particular moment. This often happens at climactic moments when there are too many possible futures to consider or when the ones available are equally likely to happen. The Narrator should use this option judiciously, though. If the character can’t ever effectively use their power, that’s a sure road to frustration.",
                "The Narrator can also present the character with visions that the character didn’t ask for. These often happen when something vitally important is destined (or at least likely) to occur that can negatively affect the character or people they care about. This could be a personal crisis or a disaster that’s bound to catch the character up in it. Such visions still cost Focus. They drain the character, even if they were not requested."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Precognition2,
            Description = "The character can see the week ahead.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = $"{PowerNames.Precognition1}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character gains a sense of what is going to happen to a particular person, place or item within their reach—including themselves—in the next week. Otherwise, this power works the same as Precognition 1.",
                "Alternatively, the character can consider the fate of something within a mile of their location (rather than within their reach) over the next 24 hours. The character simply closes their eyes and thinks about the thing in question, which must be something they already know about."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Precognition3,
            Description = "The character can see the month ahead.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = $"{PowerNames.Precognition2}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character gains a sense of what is going to happen to a particular person, place or item within their reach—including themselves—in the next month. Otherwise, this power works the same as Precognition 1.",
                "Alternatively, the character can consider the fate of something within a mile of their location (rather than within their reach) over the next week, or something within 100 miles of their location over the next 24 hours. The character simply closes their eyes and thinks about the thing in question, which must be something they already know about."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.Precognition4,
            Description = "The character can see a whole year ahead.",
            PowerSets = [PowerSetNames.SixthSense],
            Prerequsites = $"{PowerNames.Precognition3}, Rank 5",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "20 Focus",
            Effect =
            [
                "The character gains a sense of what is going to happen to a particular person, place or item within their reach—including themselves—in the next year. Otherwise, this power works the same as Precognition 1.",
                "Alternatively, the character can consider the fate of something within a mile of their location (rather than within their reach) over the next month, or something within 100 miles of their location over the next week, or something within 1,000 miles of their location over the next 24 hours. The character simply closes their eyes and thinks about the thing in question, which must be something they already know about."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.ProbabilityManipulationHex,
            Description = "The character makes unlikely things happen.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Chaotic}, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "When an ally within 5 spaces times the character’s rank attempts a check on which they have trouble, this hex eliminates all trouble and gives them an edge instead.",
            ],
        },
        new()
        {
            Name = PowerNames.ProtectionHex,
            Description = "The character casts a hex to protect themselves.",
            PowerSets = [PowerSetNames.Magic],
            Prerequsites = $"{TagNames.Chaotic}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character produces a hex to help protect themselves. Make an Ego check. The result is now the character’s defense against any attack. If the result isn’t as high as the character would like, they can end the hex and try again later. On a Fantastic success, the hex also grants Health Damage Reduction 1 for its duration.",
            ],
        },
        new()
        {
            Name = PowerNames.QuickPhase,
            Description = "The character can become as intangible as a ghost.",
            PowerSets = [PowerSetNames.Phasing],
            Prerequsites = $"{PowerNames.PhaseSelf}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character and their clothing can instantly become intangible.",
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
            Name = PowerNames.RegainFocus,
            Description = "The character takes a moment to fi nd their center.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.UnflappablePoise}, {PowerNames.UntouchablePosition}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "None",
            Effect =
            [
                "The character recovers Focus equal to their Vigilance."
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
            Name = PowerNames.Resurrect,
            Description = "The character can help someone defy death.",
            PowerSets = [PowerSetNames.Healing],
            Prerequsites = $"{PowerNames.HealingHands}, Rank 5",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "Reach",
            Cost = "20 or more Focus",
            Effect =
            [
                "The character can try to bring a target back from the dead if they do so soon after the target’s death. To attempt this, they must be able to touch the dead target’s body, and that body must be relatively intact—at least enough so that if the person came back to life they wouldn’t instantly die again.",
                "The character makes an Ego action check vs. a TN equal to 10 plus 1 for every hour the target has been dead. For example, if the target has been dead for four hours, the TN is 14.",
                "On a success, the target is restored to 1 Health. On a Fantastic success, the target is restored to full Health.",
                "With any kind of success, the character using this power is then reduced to 1 Focus. On a failure, they only have to pay the minimum cost of 20 Focus."
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.ReversePunch,
            Description = "The character can reach past an enemy and punch them from behind.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.FlexibleBones1}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a close attack with an edge on an enemy. If the attack is a success, the enemy takes regular damage. On a Fantastic success, the enemy takes double damage and is stunned for one round",
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
            Name = PowerNames.Rubberneck,
            Description = "The character can lengthen and twist their neck.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.FlexibleBones1}, {PowerNames.ExtendedReach1}",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can move their head away from their body, up to their reach, to establish a line of sight to a target.",
            ]
        },
        new()
        {
            Name = PowerNames.RunOnWater,
            Description = "The character can run across water.",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"{PowerNames.SpeedRun2}, Rank 3",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can run so that their feet skip across the surface of water. As long as they keep running (even in place), they do not sink.",
            ],
        },
        new()
        {
            Name = PowerNames.Scatter,
            Description = "The character warns allies to take evasive action.",
            PowerSets = [PowerSetNames.Tactics],
            Prerequsites = $"{PowerNames.HitTheDirt}, Rank 3",
            Action = ActionType.Reaction,
            Trigger = "An enemy in line of sight declares an attack on nan ally within earshot.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "Any allies in earshot can be a­ffected, up to a number equal to the character’s rank. Each a­ ected ally can move away from you at half Speed and then fall prone. If this makes the ally an ineligible target for the initial attack, that attack automatically fails.",
            ],
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
            Prerequsites = "None",
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
            Name = PowerNames.ShapeShift,
            Description = "The character can change forms.",
            PowerSets = [],
            Prerequsites = $"{PowerNames.Disguise}, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can change into another form no more than one size bigger or smaller than their regular form.",
                "When in any form, the character has access to the natural abilities of that form. For instance, if they transformed into a bird, they could fly. When transformed into a fish, they can breathe water."
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
            Name = PowerNames.ShutDownPowers,
            Description = "The character removes all of a target’s powers!",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = $"{PowerNames.DampenPower}, Rank 4",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "15 or more Focus",
            Effect =
            [
                "The character picks another character within 20 spaces and makes an Ego attack against them. On a success, they remove all of a target’s powers.",
                "If the target’s powers have costs, the character must pay the highest of them, or a minimum of 15 Focus."
            ]
        },
        new()
        {
            Name = PowerNames.SlipFree,
            Description = "The character is impossible to restrain.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "The character is grabbed or pinned.",
            Duration = Duration.Instant,
            Effect =
            [
                "The character is not grabbed or pinned.",
            ]
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
            Name = PowerNames.SpeedBlast,
            Description = "The character fans their arms fast enough to blast a target with a gust of air!",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = $"{PowerNames.SpeedRun2}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10",
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a ranged attack. If it succeeds, the target is stunned for one round. On a Fantastic success, the character is knocked prone too.",
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
            Name = PowerNames.SpeedSwim,
            Description = "The character can swim faster than a dolphin!",
            PowerSets = [PowerSetNames.SuperSpeed],
            Prerequsites = "Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "Multiply the character’s regular Swim Speed by their rank to get their new Swim Speed. Outside of combat, they can move three times as fast.",
            ],
            SwimSpeedMultipliedByRank = true
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
            Name = PowerNames.SpiderPheromones,
            Description = "The character exudes pheromones that a£ ect those nearby.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "5 spaces",
            Effect =
            [
                "The character has an edge on Ego (intimidation) checks against people who are not attracted to their gender. They also have an edge on Ego (persuasion) checks against people who are attracted to their gender.",
            ],
        },
        new()
        {
            Name = PowerNames.SpiderSense,
            Description = "The character has a sense of danger that tingles when threats are near.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character has an edge on initiative checks and on Vigilance checks to perceive danger. Enemies have trouble on Agility checks against the character’s Vigilance defense. The character also gains a permanent +2 bonus to their Agility defense.",
            ],
            InitiativeEdge = true,
            AgiltyDefenceModifier = 2
        },
        new()
        {
            Name = PowerNames.SpiderStrike,
            Description = "The character strikes in a blur of punches, kicks and webbing.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character splits their attack to make two close attacks against separate targets within reach (or they can focus a single attack on a single target). Make a single Melee check and compare it to the targets’ Melee defenses. On a success, the a­ffected target takes half regular damage. On a Fantastic success, the a­ffected target takes full damage and is paralyzed by webbing. Breaking free from webbing requires a Melee check (target number 20).",
                "After the attacks, the character may run, jump or climb at half speed for free."
            ],
        },
        new()
        {
            Name = PowerNames.SpinAndThrow,
            Description = "The character throws a grabbed foe to the ground.",
            PowerSets = [PowerSetNames.MartialArts],
            Prerequsites = $"{PowerNames.GrapplingTechnique}, Rank 2",
            Action = ActionType.Reaction,
            Trigger = "An enemy the character can pick up is grabbed.",
            Duration = Duration.Instant,
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a Melee attack against the grabbed foe. If the attack is a success, the enemy takes regular damage and is knocked prone. On a Fantastic success, the enemy takes double damage and is knocked prone, pinned and stunned for one round.",
                "Either way, the character can move the enemy to any open space within reach."
            ],
        },
        new()
        {
            Name = PowerNames.StaticIllusion,
            Description = "By manipulating visual light, the character creates a realistic hologram.",
            PowerSets = [PowerSetNames.Illusion],
            Prerequsites = $"{PowerNames.Illumination}",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character creates a visual-only illusion anywhere in line of sight, within 50 spaces. The illusion can be of anything up to three sizes larger than the character, but it must be static. The character breaks concentration if they move beyond 50 spaces from the illusion or lose line of sight of it.",
            ]
        },
        new()
        {
            Name = PowerNames.StiltSteps,
            Description = "The character can stretch their legs like extendable stilts.",
            PowerSets = [PowerSetNames.Plasticity],
            Prerequsites = $"{PowerNames.ExtendedReach1}, Rank 2",
            Action = ActionType.Movement,
            Duration = Duration.Concentration,
            Effect =
            [
                "The character’s Run Speed doubles, as does their Climb Speed.",
            ]
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
            Prerequsites = $"{TagNames.Sorcerous}, Rank 4",
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
            Name = PowerNames.SwapItems,
            Description = "The character swaps objects with someone else.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.SwapPlaces}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Effect =
            [
                "The character swaps items they possess with the items of another person they can see within 2 spaces per the character’s rank. These items can include weapons, clothing or anything else that is on the other person but not attached to them. When the effect ends, the swapped items return to the people who had them originally.",
                "The character can swap all of their possessions, or they can be as selective as they like. The items must generally be swapped on an equal basis, but it is possible to swap something for nothing. For instance, the character could swap what’s in their hands for what’s in the target’s hands. If they are holding nothing and the target has a pistol, they can swap the pistol for nothing.",
                "If the person being swapped with is unwilling, the character must make an Ego check against that person’s Vigilance defense to succeed."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.SwapPlaces,
            Description = "The character swaps places with someone else.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = "None",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Effect =
            [
                "The character swaps places with another person they can see within 2 spaces per the character’s rank. When the effect ends, the character and the other person swap places again.",
                "If the person being swapped with is unwilling, the character must make an Ego check against that person’s Vigilance defense to succeed.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.SwapPowers,
            Description = "The character swaps their powers for a target’s powers.",
            PowerSets = [PowerSetNames.PowerControl],
            Prerequsites = "Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "10 or more Focus",
            Effect =
            [
                "The character makes an Ego attack against a target they can see within 2 spaces per the character’s rank. If the target’s powers have costs, the character must pay the highest of them, or a minimum of 10 Focus. On a success, they swap all of their non-Swap powers with the target’s powers. Both characters can now use their new powers as if they had always had them. When either character uses a swapped power, they must pay any cost for it normally as well.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.SwapStatus,
            Description = "The character swaps status with someone else.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.SwapItems}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked.",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character swaps status with a target they can see within 2 spaces per the character’s rank. The character can swap their entire status with the target, or they can be selective about it. Statuses they can swap include:",
                "- Lost Health",
                "- Lost Focus",
                "- Any condition",
                "- Occupation",
                "- Traits",
                "- Tags",
                "When swapping lost Health or Focus, the character and the target each take their maximum Health or Focus and subtract from it anything that the other person has lost at that moment. The same thing happens when the effect ends. This could potentially kill or shatter someone, so the character should be careful when doing this.",
                "When swapping occupations, the character gains the target’s position, including their authority and their responsibilities. For instance, if the character swaps occupations with the ruler of a nation, others recognize them as being the ruler for as long as the effect continues.",
                "When the effect ends, any alterations that have happened to either character swap back to the other. For instance, if one of the characters is killed while the other lives, that would swap when the effect ends. For this reason alone, characters should take extreme care with this power."
            ],
            Source = BookSource.XMenExpansion
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
            Name = PowerNames.TelekineticBarrier,
            Description = "The character forms a protective barrier with their mind.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticGrab}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "5 Focus",
            Effect =
            [
                "The character forms an invisible barrier in their line of sight and up to 2 spaces away per rank. This covers up to 2 spaces across (vertically/horizontally) per their rank. The character makes a Logic check and compares the results against the Agility defense of any target in the a­ ected spaces. On a success, the character chooses which side of the barrier the target winds up on. On a failure, the target chooses. On a Fantastic success, the target is paralyzed for one round too.",
                "Attacks on the barrier are against the character’s Logic defense. Any attacks on it that do 10 points of damage or less are instantly absorbed, and the barrier continues. If an attack does more than 10 points of damage, it destroys the barrier. Either way, the attack leaves those behind the barrier unharmed."
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticGrab,
            Description = "The character can grab a foe with their mind.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticManipulation}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Range = "5 Focus",
            Effect =
            [
                "The character makes a Logic attack against the Melee defense of a target within 5 spaces times the character’s rank. If the attack is a success, the character grabs the target with their mind. On a Fantastic success, the target can also be pinned. Breaking free requires a successful Melee check against target number 20.",
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
            Name = PowerNames.TelekineticProtection1,
            Description = "The character uses their mind to physically protect themselves.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticBarrier}, Rank 2",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "5 Focus",
            Effect =
            [
                "The character’s personal telekinetic field protects them. Any attacks against them that do 10 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 10 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticProtection2,
            Description = "The character toughens their mind against physical damage.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticProtection1}, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "10 Focus",
            Effect =
            [
                "The character’s personal telekinetic field protects them. Any attacks against them that do 20 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 20 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticProtection3,
            Description = "The character’s mind protects them like a tank.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticProtection2}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "15 Focus",
            Effect =
            [
                "The character’s personal telekinetic field protects them. Any attacks against them that do 30 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 30 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticProtection4,
            Description = "The character’s mind protects them like a fortress.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticProtection3}, Rank 5",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "20 Focus",
            Effect =
            [
                "The character’s personal telekinetic field protects them. Any attacks against them that do 40 points of damage or less are instantly absorbed, and the protection continues. If an attack does more than 40 points of damage, it destroys the protection, allowing excess damage through.",
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticReinforcement,
            Description = "The character reinforces their defenses with their mind.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticProtection1}",
            Action = ActionType.Reaction,
            Trigger = "A character using a telekinetic power that grants damage protection is attacked.",
            Duration = Duration.Instant,
            Cost = "Varies",
            Effect =
            [
                "The character can transfer any Health damage that gets through a telekinetic power that grants damage protection to their Focus instead, leaving the protection intact.",
            ],
        },
        new()
        {
            Name = PowerNames.TelekineticSphere,
            Description = "The character can create a protective sphere with their mind.",
            PowerSets = [PowerSetNames.Telekinesis],
            Prerequsites = $"{PowerNames.TelekineticProtection1}",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character is attacked or otherwise in danger.",
            Duration = Duration.Concentration,
            Cost = "Same as the character’s Telekinetic Protection power",
            Effect =
            [
                "The character envelops themselves—and any chosen people within up to 5 spaces times their rank—in a protective telekinetic sphere.",
                "When the sphere is formed, the character makes a Logic check and compares the results against the Agility defense of unwanted characters in the enclosed spaces. On a success, the character can move any unwanted people within the sphere’s perimeter to spaces outside of the sphere. On a Fantastic success, such moved people su­ er full damage.",
                "Attacks on the sphere are against the character’s Logic defense. Any attacks on the sphere are absorbed as if made against the character’s Telekinetic Protection power, and the sphere continues. If an attack does more damage than the character’s Telekinetic Protection power can sustain, it destroys the sphere, but no one inside is harmed."
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
            Prerequsites = $"{PowerNames.TelepathicLink}, Rank 2",
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
            Name = PowerNames.TelepathicPossession,
            Description = "The character mentally takes over someone else’s body.",
            PowerSets = [PowerSetNames.Telepathy],
            Prerequsites = $"{PowerNames.Orders}, Rank 5",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Cost = "20 Focus",
            Effect =
            [
                "The character possesses a target with whom they’ve established a Telepathic Link and who has no Focus left. The character makes a Logic check with trouble against the target’s Logic defense. On a success, the character takes over the target’s body completely.",
                "The result of the character’s check is the target number for any attempts by the target to end the possession. If the character attempts to harm someone with the possessed body, the target gets to make a Logic check to end the possession. If the target has the Heroic tag, they get an edge on the check.",
                "If the character attempts to harm the possessed body, the target gets an edge on the check. If the target has the Heroic tag, they get a double edge.",
                "This power can also be used to transfer the character’s mind into an empty-minded target—like a fresh clone or android—permanently. This requires no check, as there is"
            ],
        },
        new()
        {
            Name = PowerNames.Teleport1,
            Description = "The character teleports someplace else.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Blink}",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Effect =
            [
                "The character teleports into a clear space they can see or have been to, up to 10 times their rank in spaces away. Outside of combat, they can teleport up to 100 times their rank in spaces away."
            ]
        },
        new()
        {
            Name = PowerNames.Teleport2,
            Description = "The character teleports great distances.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Teleport1}",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Effect =
            [
                "The character teleports into a clear space they can see or have been to, up to 10 times their rank in spaces away. Outside of combat, they can teleport up to 1,000 times their rank in spaces away."
            ]
        },
        new()
        {
            Name = PowerNames.TeleportBlind,
            Description = "The character teleports someplace new to them.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Teleport1}, Rank 3",
            Action = $"{ActionType.Standard} or {ActionType.Movement}",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character teleports to someplace they’ve never been and never seen, up to 10 times their rank in spaces away. Outside of combat, they can teleport up to 100 times their rank in spaces away.",
                "If the character teleports into something solid, they are automatically pushed out of it but take damage from the disruption equal to a standard action check. The damage multiplier is 1 for every space they must move to reach a clear area. If this kills them, their body is trapped inside the material they teleported into."
            ]
        },
        new()
        {
            Name = PowerNames.TeleportObject,
            Description = "The character can teleport something else with them.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Teleport1}, Rank 3",
            Action = ActionType.Standard,
            Duration = Duration.Permanent,
            Cost = "10 Focus",
            Effect =
            [
                "The character can teleport along with them an object within reach as far away as their Teleport power normally allows them.",
                "The object (and things attached to or inside of it) can be up to their rank in sizes bigger than them. For example, if they are Rank 4, the object can be up to four sizes bigger than them."
            ]
        },
        new()
        {
            Name = PowerNames.TeleportOther,
            Description = "The character can teleport someone else away.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Teleport2}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "15 Focus",
            Effect =
            [
                "The character makes an Ego check against the Vigilance defense of a target they have grabbed. If the check is successful, the character can teleport the target as far away as their Teleport power normally allows them in combat.",
                "If the target winds up in something solid, they are automatically pushed out of it but take damage from the disruption equal to a standard action check. The damage multiplier is 1 for every space they must move to reach a clear area. If this kills them, their body is trapped inside the material they teleported into."
            ]
        },
        new()
        {
            Name = PowerNames.TeleportTogether,
            Description = "The character can teleport someone they are touching.",
            PowerSets = [PowerSetNames.Teleportation],
            Prerequsites = $"{PowerNames.Teleport1}, Rank 3",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character teleports, taking any person they are touching with them, into clear spaces they can see or have been to, up to 10 times their rank in spaces away. Outside of combat, they can teleport up to 100 times their rank in spaces away.",
                "If the target does not wish to be teleported, the character must grab them first."
            ]
        },
        new()
        {
            Name = PowerNames.Thunder,
            Description = "The character causes a deafening crack of thunder.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "The character makes an Ego check and compares that against the Resilience defense of every character within 10 spaces. Any character the attack succeeds against is deafened. On a Fantastic success, the character is also stunned for one round.",
            ]
        },
        new()
        {
            Name = PowerNames.TimeOut,
            Description = "The character and allies step out of time.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.TimeOut}, Rank 4",
            Action = $"{ActionType.Standard} or {ActionType.Reaction}",
            Trigger = "The character or an ally is attacked.",
            Duration = $"{Duration.OneRound} per rank",
            Cost = "15 Focus per round",
            Effect =
            [
                "The character freezes time for everyone but themselves. During this period, they can act normally while everyone else seems to be frozen in place. The character can choose to activate the power for the maximum duration or choose to stop at any time. However long, they must pay the Focus cost for each round.",
                "For example, a Rank 6 character uses Time-Out as an action and pays 30 Focus to activate it for two rounds. They can take their normal number of actions, reactions and movement, while the other characters cannot take any actions, reactions or movements until after the two rounds end."
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
            Name = PowerNames.TimeTravelOther,
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
            Name = PowerNames.TimeTravelTogether,
            Description = "The character sends someone to another time.",
            PowerSets = [PowerSetNames.OmniversalTravel],
            Prerequsites = $"{PowerNames.TimeTravel}, Rank 3",
            Action = $"{ActionType.Standard}, {ActionType.Movement} or {ActionType.Reaction}",
            Trigger = "The target is grabbed.",
            Duration = Duration.Instant,
            Cost = "10 Focus",
            Effect =
            [
                "The character moves to a di­ erent time, taking any person they are touching with them. If the target does not wish to come along, the character must grab them first.",
                "When they move to the other time, they can arrive in any place they’ve been to before. Otherwise, they arrive at the closest available corresponding space in the other time."
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
            Name = PowerNames.UnderstandBodyLanguage,
            Description = "The character can read how a person holds themself.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "When the character encounters a culture for the first time, they can make a Logic vs. TN 13 action check to puzzle out its body language. If they already know any other version of the culture’s language, they have an edge. On a success, they understand and can emulate the body language. On a Fantastic success, they permanently understand and can use it and never need to make a check for it again.",
                "This covers not only any potential full-body language used by an alien species but also the body language of species that use other forms of communication. With such species, understanding their body language allows the character to understand more than the target’s words might communicate, such as whether a person is aggressive, shy, anxious, reckless and so on."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.UnderstandCode,
            Description = "The character can figure out any kind of code.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = $"{PowerNames.UnderstandWrittenLanguage}",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "When the character encounters an unknown code for the first time, they can make a Logic vs. TN 13 action check to puzzle it out. If they already know any other version of the language the code is based on, they have an edge. On a success, they understand and can communicate in the code. On a Fantastic success, they permanently understand and can use it and never need to make a check for it again.",
                "Digital data communication is considered a form of code, and the character can use this power to understand such data too."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.UnderstandSignLanguage,
            Description = "The character can get what someone is signing.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "When the character encounters an unknown sign language for the first time, they can make a Logic vs. TN 13 action check to puzzle it out. If they already know any other version of the language, they have an edge. On a success, they understand and can sign in the language. On a Fantastic success, they permanently understand and can use it and never need to make a check for it again.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.UnderstandSpokenLanguage,
            Description = "The character can get what someone is saying.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "When the character encounters an unknown spoken language for the first time, they can make a Logic vs. TN 13 action check to puzzle it out. If they already know any other version of the language, they have an edge. On a success, they understand and can speak the language. On a Fantastic success, they permanently understand and can speak it and never need to make a check for it again.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.UnderstandUnusualCommunication,
            Description = "The character can understand any other form of communication.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = $"{PowerNames.UnderstandBodyLanguage}",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "When the character encounters an unknown form of communication for the first time—one that doesn’t depend on hearing, vision or code—they can make a Logic vs. TN 13 action check to puzzle it out. If they already know any other version of the communication, they have an edge. On a success, they understand and can use that form of communication. On a Fantastic success, they permanently understand and can use it and never need to make a check for it again.",
                "This works with forms of communication that include other senses, like scent, touch, taste and so on."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerNames.UnderstandWrittenLanguage,
            Description = "The character can figure out what someone has written.",
            PowerSets = [PowerSetNames.Translation],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Effect =
            [
                "When the character encounters an unknown written language for the first time, they can make a Logic vs. TN 13 action check to puzzle it out. If they already know any other version of the language, they have an edge. On a success, they can read and write the language. On a Fantastic success, they can permanently read and write it and never need to make a check for it again.",
            ],
            Source = BookSource.XMenExpansion
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
            Prerequsites = $"{TagNames.Sorcerous}, Rank 3",
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
            Name = PowerNames.VenomBlast,
            Description = "The character unleashes a bioelectric shock.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "5 spaces",
            Effect =
            [
                "The character makes a ranged attack. If the attack is a success, it does regular damage. On a Fantastic success, the attack does double damage, and if the target su­ffers any actual damage, they are also stunned for one round.",
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
                "The character splits their attack to make two ranged attacks against separate targets (or they can focus a single attack on a single target). Make a single Agility check and compare it to the targets’ Agility defenses. On a success, the affected target takes half regular damage. On a Fantastic success, the affected target takes full damage, and the character can make a bonus attack with this power against any available target, with the same effect."
            ],
        },
        new()
        {
            Name = PowerNames.WeatherChill,
            Description = "The character cools things down.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The temperature in an area roughly a mile across falls as low as 0°F."
            ],
        },
        new()
        {
            Name = PowerNames.WeatherWarm,
            Description = "The character heats things up.",
            PowerSets = [PowerSetNames.WeatherControl],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Concentration,
            Effect =
            [
                "The temperature in an area roughly a mile climbs as high as 100°F."
            ],
        },
        new()
        {
            Name = PowerNames.Webcasting,
            Description = "The character can snare a target in a web.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = "None",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces",
            Effect =
            [
                "The character makes a ranged attack on an enemy. If the attack is a success, the web paralyzes the enemy. On a Fantastic success, the enemy is also pinned. Breaking free from webbing requires a Melee check (target number 20)."
            ],
        },
        new()
        {
            Name = PowerNames.Webgliding,
            Description = "The character can glide through the air on their webbing.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = $"{PowerNames.Webcasting}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains the Glide movement mode, with a speed equal to double their Run Speed."
            ],
            GlideSpeed = true
        },
        new()
        {
            Name = PowerNames.Webgrabbing,
            Description = "The character snares a foe in a web.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = $"{PowerNames.Webcasting}, Rank 2",
            Action = ActionType.Standard,
            Duration = Duration.Instant,
            Range = "10 spaces",
            Cost = "5 Focus",
            Effect =
            [
                "The character makes a ranged attack on an enemy. If the attack is a success, the character grabs the target with a web. On a Fantastic success, the target can also be pinned. Breaking free from webbing requires a Melee check (target number 20)."
            ],
        },
        new()
        {
            Name = PowerNames.Webslinging,
            Description = "The character can swing through the city on their webs.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = $"{PowerNames.Webcasting}, Rank 2",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character gains the swingline movement mode, with a Speed equal to triple their Run Speed. The reach of their swingline is equal to their Swingline Speed."
            ],
            SwinglineSpeed = true
        },
        new()
        {
            Name = PowerNames.Webtrapping,
            Description = "The character creates a giant web to trap those within it.",
            PowerSets = [PowerSetNames.SpiderPowers],
            Prerequsites = $"{PowerNames.Webgrabbing}, Rank 3",
            Action = ActionType.Standard,
            Duration = "The character’s rank times 15 minutes",
            Cost = "10 Focus",
            Effect =
            [
                "The character fills up to 5 spaces with sticky webs, and the a­ ected spaces are considered difficult terrain. Any creature that starts its turn in or moves into an a­ffected space must make an Agility check (target number 20) or be paralyzed by the webbing. Breaking free from webbing requires a Melee check (target number 20)."
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
            Prerequsites = $"{TagNames.Sorcerous}, Rank 2",
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
        new()
        {
            Name = PowerNames.Wisdom,
            Description = "The character not only has brains but knows when to use them.",
            PowerSets = [],
            Prerequsites = "None",
            Duration = Duration.Permanent,
            Effect =
            [
                "The character can use their Ego defense score against Logic attacks too.",
            ],
            EgoInsteadOfLogicForDefence = true
        },
        new()
        {
            Name = PowerNames.Wisecracker,
            Description = "The character irritates a foe with their sharp wit.",
            PowerSets = [],
            Prerequsites = "None",
            Action = ActionType.Reaction,
            Trigger = "The character succeeds in an attack on an enemy in earshot, or an enemy in earshot fails an attack on them.",
            Duration = Duration.Instant,
            Effect =
            [
                "The character cracks a joke at the enemy’s expense. Make an Ego attack. On a success, it does regular Focus damage. On a Fantastic success, the damage is doubled, and the target is stunned for one round.",
            ],
        },
    ];
}
