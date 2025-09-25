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
        /*
£ Sorcerous
£ Supernatural
     */
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
            Name = TagNames.Linguist,
            Effect =
            [
                "The character is fluent in a language other than their native tongue. This tag can be selected multiple times, once for each language.",
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
            Name = TagNames.Sorcerous,
            Effect =
            [
                "The character has dedicated themself to the study of traditional magic, also known as sorcery.",
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
