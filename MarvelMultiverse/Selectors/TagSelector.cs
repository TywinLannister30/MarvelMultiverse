using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class TagSelector : ITagSelector
{
    public Tag GetTag(string name, string specialization = null, string reminder = null)
    {
        var staticTag = GetAllTags().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        var tag = staticTag.Clone() as Tag;

        if (!string.IsNullOrEmpty(specialization) )
        {
            tag.Name += $": {specialization}";
        }

        if (!string.IsNullOrEmpty(reminder))
        {
            tag.Name += $" ({reminder})";
        }

        return tag;
    }

    public List<Tag> GetTags()
    {
        return GetAllTags();
    }

    private static List<Tag> GetAllTags() =>
    [
        new()
        {
            Name = TagNames.AlienHeritage,
            Effect =
            [
                "The character—or at least one of their ancestors—is not from Earth. Pick an alien race that they belong to. If they were not raised on Earth, they should consider taking the Outsider occupation."
            ]
        },
        new()
        {
            Name = TagNames.AlternateForm,
            Effect =
            [
                "The character can change from their regular human form into another form and back. When in either form, the character can only access powers assigned to that form. In most cases, this means that the character can use powers only when in their alternate form. This tag applies to characters that switch from one humanoid form to another, like Colossus, Emma Frost and many of the Hulks. It also applies to characters that have inhuman forms, like werewolves and vampires."
            ]
        },
        new()
        {
            Name = TagNames.Authority,
            Effect =
            [
                "The character has a legal authority of some kind. They might be a commissioned officer, privateer, bounty hunter, doctor, firearms dealer, lawyer, pharmacist, police officer, private investigator, mayor, governor and so on. This tag can be selected multiple times if appropriate."
            ]
        },
        new()
        {
            Name = TagNames.Backup,
            Effect =
            [
                "The character is part of an organization—like a police force that they can call for immediate backup at any time."
            ]
        },
        new()
        {
            Name = TagNames.BlackMarketAccess,
            Effect =
            [
                "The character knows how and where they can buy and sell hard-to-find and potentially illegal things."
            ]
        },
        new()
        {
            Name = TagNames.Cursed,
            Effect =
            [
                "Willingly or not, the character is affiliated with Hell. This can open them up to all sorts of nefarious plots and plans."
            ]
        },
        new()
        {
            Name = TagNames.Deceased,
            Effect =
            [
                "The character is technically dead—although presumably still able to interact with the rest of the world in some way. They might be a vampire, a ghost, a zombie or even a brain floating in a jar."
            ]
        },
        new()
        {
            Name = TagNames.Enemy,
            Effect =
            [
                "There’s someone out there who has sworn to defeat the character. The enemy is of at least the same rank as the character and is obsessed with bringing them down. This tag can be taken multiple times, but it should be reserved for truly obsessed foes."
            ]
        },
        new()
        {
            Name = TagNames.ExtremeAppearance,
            Effect =
            [
                "The character looks very di­ggerent than the average person (wherever they happen to be) and cannot easily hide their identity. When this tag appears in origins in this chapter, it may give other useful information, like whether an extreme appearance is common.",
            ]
        },
        new()
        {
            Name = TagNames.GreenDoor,
            Effect =
            [
                "After being killed, the character can come back to life by passing through the Green Door, a portal that connects a part of the afterlife to Earth. This makes them e­ffectively immortal.",
            ],
            Restrictions =
            [
                "For gamma mutates only.",
            ],
        },
        new()
        {
            Name = TagNames.Headquarters,
            Effect =
            [
                "The character has a base, cave or lair they can use to recover from wounds, repair or store equipment, work on inventions and so on. The location can be public or secret, and it can be as humble as a toolshed or as elaborate as an underground complex or a Manhattan skyscraper.",
            ]
        },
        new()
        {
            Name = TagNames.Heroic,
            Effect =
            [
                "The character acts heroically. They help people in need, and they do their best not to kill—even with people who might deserve it.",
            ],
            Restrictions =
            [
                "The character cannot also be Villainous.",
            ],
        },
        new()
        {
            Name = TagNames.Hounded,
            Effect =
            [
                "The character is a member of a group of people who are persecuted for simply being themselves.",
            ],
        },
        new()
        {
            Name = TagNames.Hunted,
            Effect =
            [
                "The character is hunted by the law for crimes they have supposedly (or actually) committed. If captured by the police, they may be arrested, tried for their crimes and potentially sent to jail.",
            ],
        },
        new()
        {
            Name = TagNames.Imageless,
            Effect =
            [
                "The character casts no reflection, and their image cannot be captured by cameras.",
            ],
        },
        new()
        {
            Name = TagNames.Immunity,
            Effect =
            [
                "The character is immune to the usual e­ffects of something. This can be selected multiple times.",
            ],
        },
        new()
        {
            Name = TagNames.InhumanGenes,
            Effect =
            [
                "The character has latent Inhuman genes that cause them to develop super-powers when exposed to the Terrigen Mist.",
            ],
            Restrictions =
            [
                "For Inhumans only."
                ]
        },
        new()
        {
            Name = TagNames.LabAccess,
            Effect =
            [
                "The character either owns or has access to a laboratory filled with the technical equipment, supplies and tools they need for their work. This can be anything from a well-stocked high-school classroom to a forensics lab to an industrial site.",
            ],
        },
        new()
        {
            Name = TagNames.Krakoan,
            Effect =
            [
                "As a mutant, the character is automatically a citizen of the island-nation of Krakoa and can travel to and from there freely. Also, if they are killed and the Five—a group of powerful mutants—are able to work together, the character can be resurrected into an identical new body with most of their memories intact.",
                "If killed in Otherworld, the character can still be resurrected, but they will be changed in unpredictable ways. Just how this might a­ffect the character is up to the Narrator."
            ],
            Restrictions =
            [
                "For mutants only."
            ]
        },
        new()
        {
            Name = TagNames.Linguist,
            Effect =
            [
                "The character is fluent in a language other than their native tongue. This tag can be selected multiple times, once for each language.",
            ],
        },
        new()
        {
            Name = TagNames.Mentor,
            Effect =
            [
                "The character knows an older person they can ask for advice, even when it comes to having super-powers. This tag can be selected multiple times.",
            ],
        },
        new()
        {
            Name = TagNames.Mute,
            Effect =
            [
                "The character cannot speak. Unless otherwise specified, they can use other means to communicate.",
            ],
        },
        new()
        {
            Name = TagNames.Obligation,
            Effect =
            [
                "The character is responsible to certain people, places or organizations who rely on them. This tag can be selected multiple times, using many different categories. These include family, school, society, sports, work and so on.",
            ],
        },
        new()
        {
            Name = TagNames.Poor,
            Effect =
            [
                "The character has little access to money and struggles to make ends meet. This can cause them all sorts of problems.",
            ],
        },
        new()
        {
            Name = TagNames.Powerful,
            Effect =
            [
                "The character has access to the resources of their entire community. In most cases, they must be careful about how they use such resources so that they don’t lose that access.",
            ],
        },
        new()
        {
            Name = TagNames.PublicIdentity,
            Effect =
            [
                "The character’s real identity is known to the public. This can make it easier for them to ask their friends and family—and even strangers—for help. Unfortunately, it also makes it easier for their enemies to find them and even to threaten those same friends and family.",
            ],
        },
        new()
        {
            Name = TagNames.Radioactive,
            Effect =
            [
                "The character constantly emits low levels of some sort of radiation. This can be picked up by a Geiger counter.",
            ],
        },
        new()
        {
            Name = TagNames.Rich,
            Effect =
            [
                "The character has access to plenty of money. If they want something normally and legally available to people, they can simply buy it.",
            ],
        },
        new()
        {
            Name = TagNames.SecretIdentity,
            Effect =
            [
                "The character’s real identity is a secret to the public, and they must take precautions to maintain this status. This might help keep the people they care about safe from their enemies, but it can also cause strain in those same relationships.",
            ],
        },
        new()
        {
            Name = TagNames.SignatureWeapon,
            Effect =
            [
                "The character is known for owning and using a specific type of weapon, like Hawkeye’s bow or Elektra’s sai.",
                "This tag can be taken more than once, but each time must be with a di- erent weapon."
            ],
        },
        new()
        {
            Name = TagNames.Sorcerous,
            Effect =
            [
                "The character has dedicated themself to the study of traditional magic, also known as sorcery.",
            ],
        },
        new()
        {
            Name = TagNames.Streetwise,
            Effect =
            [
                "The character knows how things are handled on the street, who’s in charge of various criminal enterprises and how to avoid issues with them.",
            ],
        },
        new()
        {
            Name = TagNames.Supernatural,
            Effect =
            [
                "The character has powers that are magical or based on something magical.",
            ],
        },
        new()
        {
            Name = TagNames.Villainous,
            Effect =
            [
                "The character is a villain, someone who cares little for the rights of others, up to and including their right to live.",
            ],
            Restrictions =
            [
                "The character cannot also be Heroic.",
            ],
        },
        new()
        {
            Name = TagNames.XGene,
            Effect =
            [
                "The character has mutant genes that cause them to develop super-powers.",
            ],
            Restrictions =
            [
                "For mutants only."
            ]
        },
    ];
}
