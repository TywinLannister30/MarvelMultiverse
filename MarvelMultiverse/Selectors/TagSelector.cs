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
            Name = TagNames.AI,
            Effect =
            [
                "The character possesses an artifi cial intelligence in a computerized mind. Their digital nature means that copies or backups can be made of their mind and can even be transferred into other compatible forms."
            ]
        },
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
            Name = TagNames.Amphibious,
            Effect =
            [
                "The character can breathe just fi ne underwater and can see and hear well in it too."
            ]
        },
        new()
        {
            Name = TagNames.Arakkii,
            Effect =
            [
                "The character hails from Arakko, which was once part of the same island as Krakoa before it was severed and sent into the dark dimension of Amenth. Arakko has since returned to the regular world and been transplanted onto a terraformed Mars.",
                "Arakkii society emphasizes independence. Arakkii do not accept help from others and often settle disputes by means of formal duels. They refuse to allow the Five to resurrect them."
            ],
            Restrictions =
            [
                "For mutants only."
            ]
        },
        new()
        {
            Name = TagNames.AuditoryIssues,
            Effect =
            [
                "The character has trouble hearing that can range from partial to full deafness."
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
            Name = TagNames.Chaotic,
            Effect =
            [
                "The character has been a­ ected by the chaos lord Chthon."
            ]
        },
        new()
        {
            Name = TagNames.Convict,
            Effect =
            [
                "The character has been convicted of a crime, which is reflected on their record."
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
            Name = TagNames.Dependents,
            Effect =
            [
                "The character has young children, elderly relatives or others who rely on them. They can’t just abandon these people and must check on them and help care for them on a regular basis."
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
            Name = TagNames.EternallyImmortal,
            Effect =
            [
                "The character does not age and could theoretically live forever. If the character is killed, they can be brought back to life in the Activation Chamber found in the Exclusion, an Eternal base located beneath the South Pole. To make this happen, the Activation Chamber sacrifices the life of a random human anywhere on Earth."
            ],
            Restrictions =
            [
                "For Eternals only."
            ]
        },
        new()
        {
            Name = TagNames.ExternallyImmortal,
            Effect =
            [
                "The character is nearly impossible to permanently kill. If they die, they are either revived somehow or reincarnated with their full memories, and then they age quickly till they reach the age of their first death, at which point they stop aging at all.",
                "The only way for an External to permanently die is for another External to kill all the others within a certain period of time and either drain their life energies or eat their hearts, which grants the killer the victim’s powers. Otherwise, they come back again."
            ],
            Restrictions =
            [
                "For Externals only."
            ],
            Source = BookSource.XMenExpansion
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
            Name = TagNames.LunarTransformation,
            Effect =
            [
                "On the three nights that the moon is at its fullest and while the moon is above the horizon, the character must transform into a werewolf and is ruled by their animal nature. They cannot help but hunt and attack any people or creatures they come across, no matter if they are friend or foe.",
            ],
            Restrictions =
            [
                "For werewolves only."
            ]
        },
        new()
        {
            Name = TagNames.MahdWyry,
            Effect =
            [
                "The character lives for so long that their accumulated memories have the potential to drive them insane. The only cure for this condition is to die and then be reborn with a restoration of their mind from a clean backup. This happens rarely, but the disease can progress quickly once it starts."
            ],
            Restrictions =
            [
                "For Eternals only."
            ]
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
            Name = TagNames.MutantAssociate,
            Effect =
            [
                "Much of the public believes—or has believed—the character to be a mutant. While this isn’t technically true, the character is lumped in with other mutants in most people’s minds.",
            ],
            Restrictions =
            [
                "For non-mutants or those with the Mutant: Artificial origin."
            ],
            Source = BookSource.XMenExpansion
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
            Name = TagNames.Mysterious,
            Effect =
            [
                "The character does not entirely understand how or why they have powers. This can prove unsettling and perhaps even dangerous, or they can just take it in stride.",
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
            Name = TagNames.VisionIssues,
            Effect =
            [
                "The character has trouble seeing that can range from partial to full blindness. This can also include color blindness, astigmatisms and being nearsighted or farsighted.",
            ],
        },
        new()
        {
            Name = TagNames.Worshipped,
            Effect =
            [
                "The character is worshipped by others as a god.",
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
        new()
        {
            Name = TagNames.Young,
            Effect =
            [
                "The character is a minor, under 18 years old. If possible, they must report in to their parents or guardians on a regular basis.",
            ],
        },
    ];
}
