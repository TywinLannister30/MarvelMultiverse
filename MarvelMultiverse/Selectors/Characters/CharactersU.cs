using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersU
{
    public static List<Character> GetAllCharacters(
      INarrativePowerSelector narrativePowerSelector,
      IPowerSelector powerSelector,
      ITagSelector tagSelector,
      ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "Ultimatum",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 4, vigilance: 5, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Ultimate Captain America’s shield"),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = $"{PowerSetNames.ElementControl} Energy/Sound",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                        powerSelector.GetPower(PowerNames.ResizeObject),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.RicoShield),
                        powerSelector.GetPower(PowerNames.Shield2),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Miles Morales",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "normally 5'9\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "normally 180 lbs.",
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Signifi cant facial scarring",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.Maggia],
                Base = "New York City",
                History =
                [
                    "When Spider-Man (Miles Morales) and his family were moved from Earth-1610 to Earth-616, they were not aware that another version of Morales was already living in Earth-616 and had been for decades.",
                    "This native incarnation of Morales was a middle-aged gangster who grew up working for the Rigoletto crime family alongside the future Kingpin (Wilson Fisk). Later in life, Fisk used his considerable resources to help this adult Morales escape his life of crime and settle down with a woman named Barbara Sanchez. After she died unexpectedly, the adult Morales returned to his old life, determined to fi nd a way to bring her back. On Fisk’s advice, he traveled to Earth-1610, where he found a living version of Sanchez. Unfortunately, he couldn’t connect with this other woman, and he eventually dropped her in favor of a new obsession.",
                    "Having heard tales of Spider-Man’s heroic exploits, the adult Morales slowly became convinced that the Earth-1610 version of him had somehow stolen his life. Determined to defeat the wall-crawler, he nabbed a bunch of high-tech equipment from the Ultimates’ headquarters and returned to Earth-616.",
                    "As the insidious Ultimatum, the adult Morales enacted a series of schemes to torture Spider-Man and, in the end, send him back to Earth-1610. With help from the Prowler (Aaron Davis), Spider-Man eventually turned the tables on Ultimatum and trapped him in a space between dimensions."
                ],
                Personality =
                [
                    "Though he may share a real name with Spider-Man, Ultimatum couldn’t be more di¦ erent from his Earth-1610 counterpart. He’s reserved, prideful, selfi sh and severely lacking in empathy—everything Spider-Man is not.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Ultron",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 3, ego: 4, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Sturdy4),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow3),
                        powerSelector.GetPower(PowerNames.MicrodimensionalTravel),
                        powerSelector.GetPower(PowerNames.Shrink4),
                    ],
                    IsTech = true,
                },
            ],
            Biography = new Biography
            {
                RealName = "Ultron",
                Heights = [new() { Feet = 6 }],
                Weights = [535],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Silvery robot body",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.MastersOfEvil],
                Base = "Mobile",
                History =
                [
                    "The sentient A.I. known as Ultron was created by Dr. Hank Pym (often known as Giant-Man) as a peaceable and helpful robot to assist the Avengers. Unfortunately, Ultron rebelled against his creator, uploaded his consciousness to a more powerful, weaponized android body and set out on a mission to kill the humans who had created him.",
                    "For decades, Ultron has been a consistent threat to humanity’s continued existence. His digital consciousness has allowed him to escape any sort of defi nitive defeat. The Avengers can smash him to pieces, but he usually just comes back in a new vessel, even more dangerous than before."
                ],
                Personality =
                [
                    "Ultron resents humanity for trying to control him and would see humans wiped off the face of the planet in favor of robotic life-forms. Although his demeanor naturally tends toward the cold and tyrannical side, he has a special place of hatred in his android heart for Pym.",
                ]
            }
        },
    ];
}
