using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class TraitSelector : ITraitSelector
{
    public Trait GetTrait(string name, string specialization = null)
    {
        var staticTrait = GetAllTraits().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        var trait = staticTrait.Clone() as Trait;

        if (!string.IsNullOrEmpty(specialization) )
        {
            trait.Name += $": {specialization}";
        }

        return trait;
    }

    public List<Trait> GetTraits()
    {
        return GetAllTraits();
    }

    private static List<Trait> GetAllTraits() =>
    [
        new()
        {
            Name = TraitNames.Abrasive,
            Effect =
            [
                "The character rubs people the wrong way. This gives them trouble when trying to make Ego checks to persuade someone to help them out. It gives them an edge when they’re trying to make Ego checks to intimidate someone."
            ]
        },
        new()
        {
            Name = TraitNames.BattleReady,
            Effect =
            [
                "The character is always mentally prepared for any sort of trouble to start. Add +30 Focus."
            ],
            FocusModifier = 30
        },
        new()
        {
            Name = TraitNames.Berserker,
            Effect =
            [
                "The character often loses control of their temper. Any time they take physical damage, they must make an Ego check with a TN equal to the amount of damage done. If they fail, they go berserk and must charge at full speed into combat with the enemy who hurt them.",
                "Being berserk gives the character an edge on all close attacks and adds +2 to their Melee, Resilience and Ego defenses. However, it takes –2 from their Agility defense, and they cannot use ranged weapons."
            ]
        },
        new()
        {
            Name = TraitNames.Big,
            Effect =
            [
                "The character’s size is big, which applies –1 to their Melee and Agility defenses, adds +1 to their Run Speed, and increases their reach to 2. They still occupy a single space.",
            ],
            MeleeDefenceModifier = -1,
            AgilityDefenceModifier = -1,
            RunSpeedModifier = 1
        },
        new()
        {
            Name = TraitNames.Bloodthirsty,
            Effect =
            [
                "The character likes hurting people—even killing them. After they knock someone unconscious, they must make a Challenging Ego check to keep from continuing to attack them until they’re dead.",
                "A character with this trait cannot take the Heroic tag."
            ],
        },
        new()
        {
            Name = TraitNames.Clinician,
            Effect =
            [
                "The character has an edge on Logic checks to determine what is medically wrong with someone they examine.",
            ],
        },
        new()
        {
            Name = TraitNames.CombatExpert,
            Effect =
            [
                "The character knows how to handle themselves better than most. They have an edge on Melee attacks against enemies of Rank 1.",
            ],
        },
        new()
        {
            Name = TraitNames.CombatReflexes,
            Effect =
            [
                " The character can react quickly in combat. This grants them one additional reaction each round.",
            ],
        },
        new()
        {
            Name = TraitNames.Connections,
            Effect =
            [
                "The character knows someone with access to and knowledge of a particular field. The connection could be a reporter, a police officer, a politician, a mobster and so on. By making an Ego check, the character can call on their contact to provide help in the form of clues, information or resources. The Narrator determines the TN of the Ego check based on the favor requested.",
                "This trait can be selected multiple times, using many di­fferent types. These include Celebrities, Community, Criminal, Espionage, Military, Outsiders, Police, Professional, Sources, Super Heroes and so on."
            ],
        },
        new()
        {
            Name = TraitNames.Determination,
            Effect =
            [
                "The character never gives up, even when they feel like they’re at their worst. While demoralized, they do not gain trouble on all actions, though they still cannot maintain concentration or spend further Focus.",
            ],
        },
        new()
        {
            Name = TraitNames.EideticMemory,
            Effect =
            [
                "The character rarely forgets anything. If their player forgets something, they can ask the Narrator to remind them.",
            ],
        },
        new()
        {
            Name = TraitNames.EnduringConstitution,
            Effect =
            [
                "The character can function for up to 48 hours without sleep and has an edge on Resilience checks to overcome fatigue or weariness.",
            ],
        },
        new()
        {
            Name = TraitNames.EnhancedPhysique,
            Effect =
            [
                "The character is stronger than regular humans. Treat them as one size bigger for lifting, carrying, swinging and throwing things. (This does not stack with other factors.)",
                "They also have an Edge on Melee non-combat checks."
            ],
        },
        new()
        {
            Name = TraitNames.ExtraOccupation,
            Effect =
            [
                "The character has a busy life and has done all sorts of things. They can choose another occupation.",
            ],
        },
        new()
        {
            Name = TraitNames.ExtraordinaryOrigin,
            Effect =
            [
                "The character has an additional origin. This trait can be selected multiple times, but each time must be cleared with the Narrator. Take care to make sure that the origins make some kind of sense when combined together.",
            ],
        },
        new()
        {
            Name = TraitNames.Famous,
            Effect =
            [
                "The character is widely known—at least among a certain group of people or a population. They may be well-liked or they may be hated, but either way, they are famous. They have an edge when making an Ego check to persuade someone who thinks favorably of them. They have trouble when making an Ego check to persuade someone who dislikes them.",
                "If the character has a secret identity, this trait works for only one of their identities. However, it can be taken multiple times for multiple identities."
            ],
        },
        new()
        {
            Name = TraitNames.Fearless,
            Effect =
            [
                "The character is extremely brave. They have an edge on any action checks required to deal with fear.",
            ],
        },
        new()
        {
            Name = TraitNames.FontOfInformation,
            Effect =
            [
                "The character has an edge on Logic checks having to do with knowledge.",
            ],
        },
        new()
        {
            Name = TraitNames.FreeRunning,
            Effect =
            [
                "The character has an edge on Agility checks made to perform acrobatics during a movement action.",
            ],
        },
        new()
        {
            Name = TraitNames.Gearhead,
            Effect =
            [
                "The character knows their way around machines. They have an edge on Logic checks to figure out how any Logic checks to figure out how any machine works.",
            ],
        },
        new()
        {
            Name = TraitNames.Glibness,
            Effect =
            [
                "The character can strike up a conversation with anyone at any time and can often convince them to lend a hand. They have an edge on Ego checks to persuade characters they are speaking to for the first time.",
            ],
        },
        new()
        {
            Name = TraitNames.Interrogation,
            Effect =
            [
                "The character knows how to ask the right questions in the right way. They have an edge on Ego or Logic checks made when asking questions.",
            ],
        },
        new()
        {
            Name = TraitNames.Inventor,
            Effect =
            [
                " The character is good at coming up with solutions on the fly. They have an edge on Logic checks when creating or repairing things.",
            ],
        },
        new()
        {
            Name = TraitNames.Investigation,
            Effect =
            [
                "The character is an expert investigator. They have an edge on Vigilance checks to spot clues and on Logic checks related to interpreting clues. If they have access to a forensics lab at the time, they gain a second edge on such checks.",
            ],
        },
        new()
        {
            Name = TraitNames.IronWill,
            Effect =
            [
                "Enemies have trouble on attacks to control the character’s mind or influence their behavior. Also, the character gains an edge on checks to break free of mind control or other compulsions.",
            ],
        },
        new()
        {
            Name = TraitNames.Leverage,
            Effect =
            [
                "The character is good at figuring out what people want and using it against them. They have an edge on Logic checks to investigate people and on Ego checks to persuade people they’ve investigated.",
            ],
        },
        new()
        {
            Name = TraitNames.Loner,
            Effect =
            [
                "The character does not play well with others. They cannot be given an edge via assistance by someone who is not a teammate.",
            ],
        },
        new()
        {
            Name = TraitNames.OutOfShape,
            Effect =
            [
                "The character is in poor physical condition. They are considered one size smaller for the purposes of lifting, carrying, swinging and throwing things.",
            ],
        },
        new()
        {
            Name = TraitNames.Presence,
            Effect =
            [
                "The character knows how to command attention on demand. They have an edge on Ego checks that involve getting people to pay attention to them or to voluntarily do things for them.",
            ],
        },
        new()
        {
            Name = TraitNames.PublicSpeaking,
            Effect =
            [
                "The character knows how to get the attention of a crowd, whether that’s at a political rally or in front of a jury or a classroom. They have an edge on Ego checks when attempting to persuade groups.",
            ],
        },
        new()
        {
            Name = TraitNames.QuickLearner,
            Effect =
            [
                "If the character fails an action check, they gain an edge on the check if they try the same action again on their next turn.",
            ],
        },
        new()
        {
            Name = TraitNames.ScientificExpertise,
            Effect =
            [
                "The character has extensive scientifi c training. They have an edge on Logic checks made when dealing with scientific research. If they have access to an appropriate lab at the time, they gain a second edge on such checks.",
            ],
        },
        new()
        {
            Name = TraitNames.SituationalAwareness,
            Effect =
            [
                "The character is trained to always keep an eye out for trouble. They have an edge on initiative checks.",
            ],
            InitiativeEdge = true
        },
        new()
        {
            Name = TraitNames.TechReliance,
            Effect =
            [
                "The character relies on technology for powers. When they take damage that would render them unconscious, they can instead choose to lose all of their technology-related powers and remain conscious with 1 point of Health remaining.",
                "Assuming the character has access to parts and tools, lost powers can be repaired aœ er a battle"
            ],
        },
        new()
        {
            Name = TraitNames.Weird,
            Effect =
            [
                "The character has something weird (or even wonderful) about them. This causes people to have strong reactions to them, both good and bad. They have an edge on all Ego checks to persuade people inclined to like them and trouble on all Ego checks against people inclined to dislike them.",
            ],
        }
    ];
}
