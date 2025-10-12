using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class Characters0To9
{
    public static List<Character> GetAllCharacters(
        IIconicItemPowerSelector iconicItemPowerSelector,
        INarrativePowerSelector narrativePowerSelector,
        IPowerSelector powerSelector,
        ITagSelector tagSelector,
        ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "3-D Man",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BlazingFastFists),
                        powerSelector.GetPower(PowerNames.SpeedRun1),
                        powerSelector.GetPower(PowerNames.SpeedSwim),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Delroy Garrett Jr.",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.Avengers, TeamNames.SkrullKillKrew],
                Base = "Mobile",
                History =
                [
                    "Eons ago, mysterious forces conspired to create three shards of light, weapons capable of opposing an evil extradimensional pyramid known as the Triple-Evil. In the modern era, two of these shards found their way into the hands of a man named Jonathon Tremont, who used them to start a cult called the Triune Understanding. Only able to use one shard, Tremont sought a disciple who could use the other and found one in Delroy Garrett Jr.",
                    "Having recently lost his accreditation as an Olympic athlete by failing a drug test, Garrett came to the Triune Understanding seeking a new start. Sensing his compatibility, Tremont took him under his wing and infused Garrett with the fragment, granting him superhuman strength and speed.",
                    "Initially as Triathlon—then, later, as 3-D Man—Garrett made a name for himself in the world of super heroes, assisting the Avengers through several major crises and eventually earning a spot on the team. When the Triple-Evil arrived in the midst of one of Kang the Conqueror’s attempts to take over Earth, Tremont betrayed Garrett and tried to take his shard. Garrett instead took the other shards from him and used them to stop both Kang and the Triple-Evil.",
                    "Since then, Garrett has been a member of several iterations of the Avengers. He distinguished himself as a critical member of the team during the original secret invasion, when his Skrull-detecting 3-D goggles allowed the authorities to root out the aliens. More recently, he proved his heroic stature again by acting as the team’s mole within the anti-mutant organization Orchis. Though he isn’t currently on the main Avengers roster, 3-D Man can still be counted on to come to their aid in times of need."
                ],
                Personality =
                [
                    "3-D Man is as quick with a joke as he is on his feet. Perpetually underestimated, he has a talent for foresight and strategy, making him immensely capable both on the battlefield and in the war room.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
    ];
}
