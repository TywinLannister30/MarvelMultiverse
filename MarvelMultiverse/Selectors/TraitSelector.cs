using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class TraitSelector : ITraitSelector
{
    public Trait GetTrait(string name, string specialization = null, string reminder = null)
    {
        var staticTrait = GetAllTraits().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        var trait = staticTrait.Clone() as Trait;

        if (!string.IsNullOrEmpty(specialization) )
        {
            trait.Name += $": {specialization}";
        }

        if (!string.IsNullOrEmpty(reminder))
        {
            trait.Name += $" ({reminder})";
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
                "The character su­ffers direct harm when exposed to a particular substance. They cannot voluntarily enter the same space with it. If they are touched by it, they instantly su­ffer the damage of a Rank 3 attack roll that automatically succeeds. This continues each turn until they are separated from the substance or are killed or destroyed.",
                "Damage caused by Anathema ignores all damage reduction the character has and cannot be healed by their Healing Factor."
            ]
        },
        new()
        {
            Name = TraitNames.Anathema,
            Effect =
            [
                "Many people follow the character’s work and treat them with the respect they deserve. By making an Ego check, the character can persuade their audience to provide help in the form of information or resources. The Narrator determines the TN of the Ego check based on the favor requested."
            ]
        },
        new()
        {
            Name = TraitNames.Audience,
            Effect =
            [
                "Many people follow the character’s work and treat them with the respect they deserve. By making an Ego check, the character can persuade their audience to provide help in the form of information or resources. The Narrator determines the TN of the Ego check based on the favor requested."
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
            Name = TraitNames.Beguiling,
            Effect =
            [
                "The character has an edge when making an Ego check to persuade someone who could be attracted to them.",
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
            Name = TraitNames.BreatheDifferent,
            Effect =
            [
                "The character cannot breathe Earth’s air for long. They lose 1 point of Health for every minute they do not have some sort of assistance to allow them to breathe properly.",
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
            Name = TraitNames.Clueless,
            Effect =
            [
                "The character tends to shut out things they’re not entirely focused on. They have trouble on any Vigilance checks to spot hidden or invisible things. Enemies have an edge on Agility checks to sneak near or past them.",
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
                "The character can react quickly in combat. This grants them one additional reaction each round.",
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
            Name = TraitNames.Dealmaker,
            Effect =
            [
                "The character is skilled at the art of negotiation. They have an edge on action checks that have to do with making deals.",
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
            Name = TraitNames.ExternalAwareness,
            Effect =
            [
                "The character has a telepathic link with all other Externals. This allows them to:",
                "- Know where other Externals are.",
                "- Know when an External kills another External.",
                "- Telepathically call for other Externals.",
            ],
            Restrictions =
            [
                "For Externals only."
            ],
            Source = BookSource.XMenExpansion
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
            Name = TraitNames.FirstAid,
            Effect =
            [
                "The character knows how to administer first aid. They have an edge on Logic checks to stop bleeding.",
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
            Name = TraitNames.FreshEyes,
            Effect =
            [
                "The character has their own way of doing things. This often makes them seem strange to those around them, but it means they can bring new perspectives to existing issues. They have an edge on Logic checks when faced with something for the first time.",
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
            Name = TraitNames.GodHeritage,
            Effect =
            [
                "The character—or at least one of their ancestors—is a god. Pick something that they are the god of.",
                "They don’t have to be a god that most people have heard of. In fact, they can be the god of something entirely new. However, they cannot generally be the god of something that’s already been claimed by someone else in their pantheon. Other gods are often jealous of their positions and take issue with such rivals.",
                "The character has an edge when dealing with something that they are the god of."
            ],
            Restrictions =
            [
                "This trait can be selected only by characters with a mythic origin and an attachment to a particular pantheon, like Asgardian or Olympian."
            ]
        },
        new()
        {
            Name = TraitNames.Gullible,
            Effect =
            [
                "The character is easy to fool. People lying to them have an edge on their Ego checks to persuade the character of something.",
            ],
        },
        new()
        {
            Name = TraitNames.HiveMind,
            Effect =
            [
                "The character has some independence but is connected to others of their kind by a telepathic network with an unlimited range and an unlimited number of members. When given orders by the leader of that network, the character must make an Ego vs. TN 18 action check or follow those orders. On a Fantastic success, the character can choose to permanently break free from the network.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = TraitNames.Honest,
            Effect =
            [
                "The character is a terrible liar. They have trouble any time they make an Ego check that involves telling a lie. However, they have an edge on any friendly Ego (persuasion) checks in which they’re truthful.",
            ],
        },
        new()
        {
            Name = TraitNames.Infector,
            Effect =
            [
                "The character can infect a target with a disease, which must be chosen along with the trait. Examples include:",
                "- Brood implantation",
                "- Carrion Virus",
                "- Spider-Wasp Venom",
                "- Techno-Organic virus",
                "- Transmode virus",
                "See the infected condition for details about how infection works, the Infections and Possessions section for the effects of the above diseases.",
                "See the Clones section (page p118 Spiderverse) for the effects of the Carrion Virus, and the Spider-Wasp Venom section (page p125 Spiderverse) for the effects of Spider-Wasp Venom."
            ],
            Source = BookSource.XMenExpansion
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
            Name = TraitNames.LegalEagle,
            Effect =
            [
                "The character knows the laws of their homeland and can help others navigate them. They have an edge on Logic checks when dealing with legalities.",
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
            Name = TraitNames.MagicItemReliance,
            Effect =
            [
                "The character relies on a magically empowered item for some or all of their powers. When they take Health damage that would render them unconscious, they can instead choose to lose all of their magic-item–related powers and remain conscious with 1 point of Health left.",
                "Similarly, if they take Focus damage that would render them demoralized, they can instead choose to lose all of their magic-item–related powers and have 1 point of Focus left.",
                "Magic items are notoriously difficult to destroy. They cannot be harmed by most attacks. However, they can be taken away or lost. Many characters would go to great lengths to recover the magic items that grant them powers."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = TraitNames.Monster,
            Effect =
            [
                "The character is some kind of monster, often of a type spoken of in legend. They have an edge whenever they attempt to intimidate someone.",
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
            Name = TraitNames.Piloting,
            Effect =
            [
                "The character knows how to operate vehicles of all kinds. They have an edge on Agility checks triggered when piloting or driving a vehicle during a movement action. This applies to cars, boats, aircraft and so on.",
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
            Name = TraitNames.Pundit,
            Effect =
            [
                "The character knows how to break news items and put them into context to craft a story around them. They have an edge on Ego or Logic rolls made when giving their opinion via media.",
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
            Name = TraitNames.SignatureAttack,
            Effect =
            [
                "The character is known for favoring a particular kind of weapon or attack power. They have an edge when making attacks that way.",
                "This trait can be taken more than once, but each time must be with a di­ erent kind of weapon or attack power."
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
            Name = TraitNames.Skeptical,
            Effect =
            [
                "The character is hard to fool. People lying to them have trouble on their Ego checks to persuade the character of something.",
            ],
        },
        new()
        {
            Name = TraitNames.Small,
            Effect =
            [
                "The character’s size is small, which adds +1 to their Melee and Agility defenses and takes –1 from their Run Speed.",
            ],
            MeleeDefenceModifier = 1,
            AgilityDefenceModifier = 1,
            RunSpeedModifier = -1
        },
        new()
        {
            Name = TraitNames.Sneaky,
            Effect =
            [
                "The character has an edge on Agility checks when sneaking around. Enemies have trouble on Vigilance checks to detect the character when the character is invisible or hiding.",
            ],
        },
        new()
        {
            Name = TraitNames.Stranger,
            Effect =
            [
                "The character doesn’t understand local customs. They have trouble on checks made when trying to decipher such things or when trying to pass themselves o­ff as a local.",
            ],
        },
        new()
        {
            Name = TraitNames.SurprisingPower,
            Effect =
            [
                "The character can choose a power they normally wouldn’t be able to use. The character will still need to have any prerequisite powers, but they can ignore rank and origin requirements. This trait can be selected multiple times.",
            ],
        },
        new()
        {
            Name = TraitNames.Suspicious,
            Effect =
            [
                "The character is naturally suspicious of people who are hiding something. When someone with a secret identity makes a Logic check to try to convince the character that they’re mistaken about the secret identity, the character gives them trouble.",
            ],
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = TraitNames.SymbioticSpiderBlinder,
            Effect =
            [
                "While the character is bonded to a symbiote, they cannot be detected by the Spider-Sense of any character who was previously bonded to the same symbiote. This effect is passed on to the symbiote’s offspring as well.",
                "The reason is that Spider-Sense detects the previously bonded symbiote as part of itself and thus not a threat. As such, the affected character does not gain an edge on Vigilance checks to perceive danger from such a symbiote. Nor do such symbiotes have trouble on Agility checks against the character’s Vigilance defense."
            ],
            Source = BookSource.SpiderverseExpansion
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
            Name = TraitNames.UnusualSize,
            Effect =
            [
                "The character’s regular size is beyond those for small, average or big, as shown on the Resize Effects Table.",
                "The one exception is a character’s Flight Speed. If they are microscopic, miniature, tiny or little, calculate their Flight Speed as if they were small-sized. If they are huge, gigantic, titanic or gargantuan, calculate their Flight Speed as if they were big-sized.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = TraitNames.Venomous,
            Effect =
            [
                "When the character uses sharp Melee Weapons powers and gets a Fantastic success, they have the option of causing a target to be poisoned rather than bleeding.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = TraitNames.Weakness,
            Effect =
            [
                "The character su­ffers an unusual amount of harm from certain substances. Any attack made with that substance ignores all inherent damage reduction the character has and cannot be healed by their Healing Factor.",
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
