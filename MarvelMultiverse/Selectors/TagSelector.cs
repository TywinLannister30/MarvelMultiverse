using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class TagSelector : ITagSelector
{
    public Tag GetTag(string name, string specialization = null)
    {
        var staticTag = GetAllTags().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        var tag = staticTag.Clone() as Tag;

        if (!string.IsNullOrEmpty(specialization) )
        {
            tag.Name += $": {specialization}";
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
            Name = TagNames.Immunity,
            Effect =
            [
                "The character is immune to the usual e­ ects of something. This can be selected multiple times.",
            ],
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
        }
    ];
}
