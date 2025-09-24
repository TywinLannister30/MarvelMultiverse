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
            Name = TraitNames.Connections,
            Effect =
            [
                "The character knows someone with access to and knowledge of a particular field. The connection could be a reporter, a police officer, a politician, a mobster and so on. By making an Ego check, the character can call on their contact to provide help in the form of clues, information or resources. The Narrator determines the TN of the Ego check based on the favor requested.",
                "This trait can be selected multiple times, using many di­fferent types. These include Celebrities, Community, Criminal, Espionage, Military, Outsiders, Police, Professional, Sources, Super Heroes and so on."
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
            Name = TraitNames.Leverage,
            Effect =
            [
                "The character is good at fi guring out what people want and using it against them. They have an edge on Logic checks to investigate people and on Ego checks to persuade people they’ve investigated.",
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
