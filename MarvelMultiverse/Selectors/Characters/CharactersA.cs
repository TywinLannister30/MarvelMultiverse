using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;
using System.Net.Sockets;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersA
{
    public static List<Character> GetAllCharacters(
        INarrativePowerSelector narrativePowerSelector,
        IPowerSelector powerSelector,
        ITagSelector tagSelector,
        ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "A.I.M. Agent",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 0, vigilance: 1, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "Bright yellow beekeeper-esque hazmat uniforms.",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.AIM],
                Base = "A.I.M. Island",
                History =
                [
                    "Founded during World War II, Advanced Idea Mechanics (aka A.I.M.) was created by regular Nick Fury nemesis and Hydra leader Baron Von Strucker. A.I.M. was initially intended to be nothing more than a scientific wing for Hydra, but the organization could not long be kept under Hydra control.",
                    "A.I.M. agents are highly intelligent scientific terrorists who desire nothing more than complete world domination. In pursuit of this goal, A.I.M. has aligned itself with countless super villains. As an organization, they are responsible for the creation of many of the most dangerous weapons in existence, including the Cosmic Cube and M.O.D.O.K.",
                ],
                Personality =
                [
                    "A.I.M. scientists are typically power-hungry outsiders to the scientific community—intelligent people furious that the world does not revere their brilliance. They seek to take revenge on a society that refuses to treat them as kings",
                ]
            }
        },
        new()
        {
            Name = "Abomination (Emil Blonsky)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 3, resilience: 8, vigilance: 3, ego: 3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump3),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Emil Blonsky",
                Heights = [new() { Feet = 6, Inches = 8 }],
                Weights = [980],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Bald",
                Size = Size.Big,
                DistinguishingFeatures = "Green, scaly skin, webbed ears, two massive toes per foot",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Thunderbolts, TeamNames.ProjectGreenSpring],
                Base = "Secret",
                History =
                [
                    "While infiltrating a U.S. Air Force base in New Mexico on orders from the Russian government, Emil Blonksy came across an experimental gamma device developed by Bruce Banner. Blonsky allowed himself to be bombarded by gamma rays, permanently transforming him into the green-skinned Abomination, a monstrosity with powers rivaling Banner’s own as the Hulk.",
                    "Blonsky considers the Hulk a public menace and a threat to his own considerable power. In the years since his transformation, he has largely dedicated himself to destroying the Hulk and anyone who associates with him. Blonksy has returned from certain death multiple times, only to continue pursuing the Hulk."
                ],
                Personality =
                [
                    "As the Abomination, Blonsky is highly intelligent and coherent, much unlike the Hulk often is. He’s also a self-assured egomaniac who is abusive even to those closest to him. He desires the death of the Hulk so that he can prove his physical and mental superiority. Blonsky is rarely reasonable, except on the rare occasion when he has to deal with someone clearly more powerful than himself.",
                ]
            }
        },
        new()
        {
            Name = "Agatha Harkness",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 2, vigilance: 5, ego: 8, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.OutOfShape),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.CrimsonBandsOfCyttorak),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticManipulation)
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork)
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Agatha Harkness",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Educator],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.DaughtersOfLiberty, TeamNames.DepartmentOfTheUncanny, TeamNames.StrangeAcademy],
                Base = "Mobile",
                History =
                [
                    "Agatha Harkness has been a practicing witch all her long life, stretching back tens of thousands of years. Her modern history begins in the 17th century when, following the Salem witch trials, she formed the town of New Salem as a sanctuary for persecuted magic users.",
                    "At some point in the 20th century, Harkness’ long life began to catch up with her. She retired from New Salem and found a second calling as a governess for a young Franklin Richards, regularly assisting the Fantastic Four on their adventures.",
                    "More recently, she has returned to a place of prominence in the magical community, acting as a teacher and a guide for young students at Strange Academy."
                ],
                Personality =
                [
                    "Harkness is generally a warm and inviting person, although she can be a bit overzealous. She’s harshest with the students from which she expects the most. If she has one flaw, it’s her assuredness that she knows best.",
                ]
            }
        },
        new()
        {
            Name = "Agent Anti-Venom",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 4, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Anti-Venom form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Healing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CureAll),
                        powerSelector.GetPower(PowerNames.HealingHands),
                        powerSelector.GetPower(PowerNames.LetsGo),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Eugene “Flash” Thompson",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [195],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SymbioteVenom],
                Teams = [TeamNames.Avengers, TeamNames.GuardiansOfTheGalaxy, TeamNames.USArmy],
                Base = "New York City",
                History =
                [
                    "High school football star and bully Flash Thompson grew up without many strong role models in his life—until Spider-Man (Peter Parker) started appearing in his friendly neighborhood. Inspired by the masked marvel’s selfl ess nature, Thompson started a Spider-Man fan club and began making amends with those he had bullied in the past, including, ironically, Parker himself.",
                    "Hoping to follow in his idol’s footsteps, Thompson joined the military after high school. He served multiple successful tours overseas, earning the rank of corporal, but his army career was cut short when his legs were blown off in combat.",
                    "Sometime later, one of Thompson’s old military contacts invited him to take part in an experimental weapons program. Military engineers helped Thompson bond with the Venom symbiote, transforming him into a super-powered government operative, codenamed Agent Venom.",
                    "Although Thompson leftthe military shortly thereafter, he retained the symbiote and the codename. Much later, while battling Eddie Brock for control of the symbiote, he was doused with an astrobiological serum that transformed the part of the symbiote attached to him into bright white with black markings. To go along with the new suit, Thompson changed his codename to Agent Anti-Venom, a name he retains to this day."
                ],
                Personality =
                [
                    "Flash Thompson may have been a bullying, egotistical jock in high school, but he’s become an extremely mature adult. He takes his responsibilities toward others very seriously, always looking for a chance to lend a helping hand. He and Peter Parker consider each other good friends.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Agent Phil Coulson",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 1, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "S.H.I.E.L.D. Helicarrier"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pistol"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Phillip “Phil” Coulson",
                Heights = [new() { Feet = 6 }],
                Weights = [203],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.PowerElite, TeamNames.SHIELD, TeamNames.SecretAvengers],
                Base = "S.H.I.E.L.D. Helicarrier",
                History =
                [
                    "From an early age, Phil Coulson was a massive super-hero fan. Over the course of decades, he has built a thorough database of all existing superhumans, including information on their strengths, abilities and weaknesses.",
                    "As a young adult, Coulson joined the U.S. Army Rangers, where he fought alongside an equally young Nick Fury Jr. After their time in the service, both men decided to join up with S.H.I.E.L.D. Coulson’s leadership skills quickly earned him the rank of Special Ops Supreme Commander.",
                    "In recent years, Coulson has taken a more villainous turn, dedicating himself to ridding the world of the heroes he admired for so long."
                ],
                Personality =
                [
                    "While considered fun and personable by his allies, Coulson is nonetheless a strict and serious field commander, not to mention a formidable combatant. Having worked in intelligence for so long, he is accustomed to keeping big secrets.",
                ]
            }
        },
        new()
        {
            Name = "Agent Sum",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 1, vigilance: 0, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Leverage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mysterious),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pistol"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HealingFactor),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Hui Lin",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [207],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Facial scar",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Born to a family of Chinese peasants in the mid-fourteenth century, Hui Lin grew up with no prospects in life. At the ripe age of forty, he took a fall off a horse and cracked his head wide open.",
                    "The fall should have killed Hui, but within minutes, his head had fully healed, leaving nothing but a small scar behind. Horrifi ed and confused, he fled his little village into the countryside.",
                    "From that day forward, Hui stopped aging. He spent the next several centuries living the quiet life, only emerging into the world on the rare occasions that he found a cause worth fighting for.",
                    "Going by the name of David Sum, Hui joined S.H.I.E.L.D. sometime in the late twentieth century. He’s been a top-ranking member of the organization ever since, maintaining ties with S.H.I.E.L.D. leadership even after its dissolution."
                ],
                Personality =
                [
                    "As a veteran of numerous wars, Agent Sum is a bit self-serious, if not outright world-weary. He has too often found himself as the lone survivor of a devastating attack.",
                ],
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Alpha Primitive",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 0, ego: 0, logic: -2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Inhuman Royal Guard)"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "typically around 5½ feet",
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                GenderReminder = "Mostly male",
                Eyes = "Varies",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = ["Servants and defenders of the Inhuman Royal Family"],
                Base = "Mobile",
                History =
                [
                    "Thousands of years ago, a brilliant but cruel geneticist appeared before the ruling council of Inhuman society. This geneticist argued that to turn their society into a true paradise, the Inhumans of the future would need docile, unintelligent attendants who could take care of their every physical want. To that end, he claimed he could breed a genetically perfect servant.",
                    "The ruling council approved the geneticist’s request. Within a few years, hundreds of his creations— which he dubbed Alpha Primitives—had joined Inhuman society.",
                    "At first, the Alpha Primitives were everything the geneticist had promised: unintelligent, physically strong and largely obedient. Even after the fall of the old Inhuman society and the rise of the Royal Family, the Alpha Primitives continued to provide their labor freely and without complaint.",
                    "However, deep down, beneath all their societal and genetic programming, some part of each Alpha Primitive yearns to be free. Across the last several decades, bloody Alpha Primitive rebellions have wracked the foundations of Inhuman society. With the recent collapse of New Attilan, most of the remaining Alpha Primitives have scattered to the winds."
                ],
                Personality =
                [
                    "Most Alpha Primitives are kind, but they have the vocabulary of a young child. They can speak in simple sentences and follow simple instructions, but they would be lost if asked to assemble anything more complex than a cardboard box.",
                    "However, when pushed to the breaking point, Alpha Primitives have been known to exhibit sudden flashes of incredible intelligence. Their rebellions have been organized and swift."
                ],
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "America Chavez",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 7, resilience: 4, vigilance: 3, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Professor Douglas"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalPortal),
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimePortal),
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BlazingFastFists),
                        powerSelector.GetPower(PowerNames.Blur),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Smash)
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "America Chavez",
                Heights = [new() { Feet = 6 }],
                Weights = [165],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Star tattoos on wrists",
                Occupations = [OccupationName.Adventurer, OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Thunderbolts, TeamNames.Ultimates, TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "America Chavez was born with Edges Syndrome, a mysterious and deadly genetic illness. Out of desperation, America’s mothers allowed a reclusive mad scientist and billionaire by the name of Mr. Gales to experiment upon America.",
                    "Gales’ experiments cured America’s illness but also gave her the power to open extradimensional portals. Seeking to use this power for himself, Gales murdered America’s mothers. Only by sheer luck did America herself manage to escape Gales’ clutches.",
                    "Stricken with amnesia, the wandering young America was adopted by a kindly couple in Washington Heights. As years passed, America slowly regained her memories and her powers. In honor of her dead parents, America vowed to protect the powerless."
                ],
                Personality =
                [
                    "Despite the traumatic events she experienced as a child, America remains a deeply empathetic and passionate crimefi ghter. As one of the most powerful young heroes in the world, she’s proven herself as an effective team leader.",
                ]
            }
        },
        new()
        {
            Name = "Angel",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 2, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Archangel"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Techno-organic wings [when in Archangel form, can fire feathery flechettes (treat like a submachine gun) and can act as a protective barrier (20 points to shatter)]"),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Warren Kenneth Worthington III",
                Heights = [new() { Feet = 6 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Feathery wings",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XFactor, TeamNames.XMen, TeamNames.XCorp],
                Base = "Krakoa",
                History =
                [
                    "From birth, Warren Worthington III wanted for nothing. His natural talents carried him through most of life’s troubles, and his parents’ wealth dealt with everything else.",
                    "Late in Worthington’s senior year of high school, his mutant powers kicked in, and two full-size wings spontaneously sprouted from his back. Under the codename of the Angel, Worthington decided to take a crack at emulating the super heroes he admired as a kid and waged a private one-man war on crime.",
                    "Angel’s solo exploits drew the attention of the fledgling X-Men, who invited him to become a founding member of their organization. He accepted, and he’s been in their orbit ever since.",
                    "During one of his regular adventures with the X-Men, Angel had his wings ripped from his back. Apocalypse kidnapped the injured Angel and attempted to turn him into a villainous Archangel of Death by brainwashing him and implanting stronger techno-organic wings into his body.",
                    "Angel eventually escaped Apocalypse’s control and found a way to return to his original form, but the incident left him forever scarred. He can become the blue-skinned Archangel when necessary, but he rarely wishes to do so. These days, Angel spends most of his time far from the field of battle, running Krakoa’s X-Corp."
                ],
                Personality =
                [
                    "Angel’s natural charisma and stunning looks inspire admiration in some and jealousy in others. When he’s not working or adventuring, he lives the life of a wealthy playboy, hanging out with supermodels and relaxing by the pool in his private mansion. However, Angel has no compunctions about using his wealth to help his friends—or the nation of Krakoa itself.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Annabelle Riggs",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 1, resilience: 1, vigilance: 2, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Valkyrie spear [+1 Melee damage multiplier; range is reach +1]",
                            meleeDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Annabelle Riggs",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [143],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.AsgardiansOfTheGalaxy, TeamNames.FearlessDefenders],
                Base = "New York City",
                History =
                [
                    "Archaeologist Annabelle Riggs asked her old friend and associate—the Hero for Hire Misty Knight—for her assistance in retrieving a handful of stolen artifacts. As part of this work, Knight recovered a powerful Asgardian totem capable of reviving the dead, and shortly therea« er, Viking zombies began attacking Riggs’ place of work. Soon enough, Riggs and Knight were caught up in an evil plot to revive some of Asgard’s fiercest foes.",
                    "The two eventually managed to end those vile plans, but not before Riggs was fatally wounded. As a reward for Riggs’ heroic efforts, Valkyrie (Brunnhilde) merged her essence with that of the fallen archaeologist. Now Valkyrie could transform into Riggs at will—and vice versa—but the pair could never exist in the same space. While one of them adventured in the real world, the other was forced to reside in a pocket dimension.",
                    "During the War of the Realms, Malekith slew Valkyrie, leaving Riggs barred from returning to reality. With the help of the Asgardians of the Galaxy, Riggs escaped Limbo and returned to rejoin the fight. Afterward, she retired as an adventurer and returned to her old archaeology position."
                ],
                Personality =
                [
                    "Although she fashions herself an intrepid explorer in the vein of Indiana Jones, Annabelle Riggs is actually something of a shy and awkward bookworm. When she’s not adventuring, she mostly keeps to herself and her studies. However, she still keeps an old Valkyrie weapon on hand, just in case. Her teammate and girlfriend, Ren Kimura, is more important to her than anyone else on the planet.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Ant-Man",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 2, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Family"),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, specialization: "Ants"),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ResizeObject),
                        powerSelector.GetPower(PowerNames.Shrink4),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Scott Lang",
                Heights = [new() { Feet = 6 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.Avengers, TeamNames.FutureFoundation, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Scott Lang was just a penniless engineer with a minor rap sheet. Then his daughter took ill. Desperate to pay for her treatment, Lang broke into the home of Henry Pym and stole Pym’s Ant-Man suit. ",
                    "Pym recognized Lang’s decent nature and eventually decided to let Lang keep his old suit. Since then, Lang has served the world as a new Ant-Man. In addition to his solo pursuits, Lang has served as a valuable asset to some of the most powerful super-teams on Earth, and he recently found his way into the company of the Guardians of the Galaxy.",
                ],
                Personality =
                [
                    "Scott Lang is a good friend and a caring father, if a bit of a goofball. He serves as an inspiration to his daughter, Cassie, now a super hero herself under the codename Stinger.",
                ]
            }
        },
        new()
        {
            Name = "Aphelion",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 2, resilience: 1, vigilance: 2, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlIce,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Reed Fox",
                Heights = [new() { Feet = 6, Inches = 3}],
                Weights = [198],
                Gender = Gender.Nonbinary,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NextMutants],
                Base = "New York City",
                History =
                [
                    "Reed Fox was one of the queer and transgender mutants who answered the call to join the Super Trans support group at the Matt Baker Community Center in Queens.",
                    "During the group’s first meeting, the center was attacked by a group of super villains seeking to create chaos across the city. Thankfully, with the help of the other members of the support group, Fox managed to send these villains packing before they could do any significant damage.",
                    "Having discovered that they enjoyed fighting together, Fox and the other mutants decided to form a more permanent team. Calling themselves the Next Mutants, they now spend their afternoons fighting to keep the streets of New York City safe for people everywhere.",
                    "To onlookers, it may appear that Fox simply has the power to freeze things, but this is not exactly the case. Fox can, at will, open a portal to a cold and largely empty universe that exists within their own body. They freeze things somewhat indirectly, by sucking heat out of the environment and into this other universe."
                ],
                Personality =
                [
                    "Fox is the closest thing the Next Mutants have to a team leader. They are, by far, the most eloquent and quick-witted of the group. Whenever the Next Mutants need to send someone forward to negotiate—or to lead them in a call to battle—Fox is the one who steps up",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Apocalypse",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 8, vigilance: 5, ego: 3, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExternalAwareness),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Infector, reminder: "Techno-Organic virus"),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExternallyImmortal),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Linguist, reminder: "all known human languages"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CopyPower),
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
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "En Sabah Nur",
                Heights = [new() { Feet = 7}],
                Weights = [300],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Gray-blue skin covered in dark blue markings",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MutantExternal],
                Teams = [TeamNames.Externals, TeamNames.HorsemenOfApocalypse, TeamNames.QuietCouncilOfKrakoa],
                Base = "Mobile",
                History =
                [
                    "One of the first of the modern era’s mutants, En Sabah Nur was born in Egypt thousands of years ago. Rejected by his parents as an infant, Nur was taken in by a brutal clan of mercenaries. Life among this clan taught him a single twisted lesson: Might makes right.",
                    "As a young man, Nur renamed himself Apocalypse and set out to make himself the most fearsome warrior in the universe. Some years later, he married a female warrior named Genesis and had four children with her. These children each became powerful fighters in their own right, waging war as Apocalypse’s Four Horsemen.",
                    "Apocalypse’s family life came to an unexpected end when his wife and children were sucked through a dimensional portal to a demonic hellscape called Amenth. As a tribute to his lost family, he spent the next several millennia capturing rival super-beings and forcibly transforming the best of them into his new Horsemen.",
                    "Not long ago, Apocalypse managed to build a portal to Otherworld—and, by means of that, to Amenth—on the island-nation of Krakoa. The demons of Amenth attempted to invade Krakoa, but the island’s defenders pushed them back into their dimension, along with Apocalypse and his family. They recently reappeared when Genesis launched an invasion of Arakko (Mars) from Amenth, with Apocalypse standing against them."
                ],
                Personality =
                [
                    "Despite having a large and studied vocabulary, Apocalypse typically speaks in short, commanding sentences. He cares for little outside of war and family, and in that way, his new life in Amenth seemed an ideal one. He had his kin by his side and unending waves of demonic foes to vanquish as he pleased.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Arana",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, reminder: "Captain Marvel (Carol Danvers)"),
                tagSelector.GetTag(TagNames.Obligation, reminder: "School"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Young),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Invisibility),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Aña “Anya” Sofía Corazón",
                Heights = [new() { Feet = 5, Inches = 3 }],
                Weights = [115],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Magic, OriginName.WeirdScience],
                Teams = [TeamNames.AvengersAcademy, TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "New York City",
                History =
                [
                    "Following the death of their champion, Ezekiel Sims, the secretive Spider Society set out to locate the Spider-Totem’s new host. To their surprise, they found that Sims’ mystic powers had latched onto an ordinary 14-year-old girl named Anya Corazón.",
                    "Corazón immediately became the target of the Society’s oldest enemies: the Sisterhood of the Wasp. The Spider Society sent their best agent, Miguel Legar, to protect Corazón, but by the time he arrived, she had been fatally injured. To save her life, he transferred a portion of his own powers to her, granting her a hard exoskeleton and limited spiderlike abilities.",
                    "Newly empowered, Corazón set out on a mission to fight crime—first under the tutelage of the Spider Society and later under Captain Marvel (Carol Danvers). Corazón was robbed of her initial powers toward the end of her time with Captain Marvel, but she gained a whole new set of more traditional spider abilities after being exposed to an experimental Spider-Virus.",
                    "As of late, Corazón’s duties as a super hero have taken a back seat to her duties as a college student at Empire State University, but she’s still ready and willing to help anyone in need."
                ],
                Personality =
                [
                    "Corazón’s mother died when she was 6, and her father died shortly after she became a super hero, so for the last several years, she’s had to make her own way through life, both as a hero and as a civilian. Despite it all, she maintains a positive outlook. She’s the kind of clever and sociable person who always has a good joke and a helping hand at the ready.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Armored Hydra Agent",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
                        powerSelector.GetPower(PowerNames.KillZone),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "The green-and-yellow Hydra uniform",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechBattleSuit, OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Secret",
                History =
                [
                    "As a terrorist organization, Hydra uses most of its many recruits (Hydra Agents) as cannon fodder. But sometimes, Hydra will spend the resources upgrading an agent to be their tank on the battlefield. Hydra reverse-engineers the technology of heroes and villains, like Iron Man, War Machine, Iron Monger, Titanium Man and others, to create their own specialized armor. While this new armor may not be as dependable as those superbeings, it can still create a shock troop who can carry out the heaviest Hydra missions.",
                ],
                Personality =
                [
                    "While Armored Hydra Agents remain anonymous members of the terrorist organization, they have an elevated status among their peers. Like all Hydra agents, they are fanatical, mean and merciless.",
                ]
            },
            Source = BookSource.EnterHydra
        },
        new()
        {
            Name = "Arnim Zola",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 3, vigilance: 2, ego: 2, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Arnim Zola",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "None",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Humanoid robot with a screen for a face in his chest",
                Occupations = [OccupationName.Criminal, OccupationName.Scientist],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "Arnim Zola was once a brilliant Nazi scientist who, in order to protect himself from the dangers of his own creations, transferred his mind into a robotic body he made. Atop this body he mounted an experimental “ESP Box”—a device designed to amplify his own brain waves.",
                    "The ESP Box worked better than Zola ever could have expected, granting him a slew of telepathic powers. His renown in fascist circles skyrocketed, and after the fall of the Third Reich, Zola joined with the Red Skull and several other fanatical fascists to form the latest incarnation of the terrorist group Hydra.",
                    "In the years since, Zola has always been a top-ranking member of Hydra High Command. He forms the backbone of the evil organization’s scientific efforts, and has been personally responsible for the creation of many of their most powerful villains. Doughboy, Man-Fish, Primus and the Black Knights (A.K.A. the Fenris Twins) all owe their existence to the dastardly inventions of Zola.",
                    "Zola is not a skilled fi ghter, but his ESP Box allows him to hold his own in battles against the likes of Captain America and the Falcon."
                ],
                Personality =
                [
                    "Like most of Hydra’s leaders, Arnim Zola is a committed fascist and megalomaniac. His complete disregard for the lives of others has been made apparent by his many horrific and torturous experiments. Zola is single-mindedly determined to continue his terrible research, and he will let no one stand in his way.",
                ],
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Askani",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 3, vigilance: 5, ego: 5, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
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
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimeTravel),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticBarrier),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                        powerSelector.GetPower(PowerNames.TelekineticProtection2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.CloakGroup),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Rachel “Ray” Anne Summers",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "Various tattoos",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Excalibur, TeamNames.XFactor, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Rachel Summers was born to Marvel Girl and Cyclops on Earth-811, a dystopian possible future in which most mutants have been herded into camps or outright slaughtered. She was spared from the horrors of the death camps only to face a fate perhaps even worse. Her oppressors made her into a “Hound,” a brainwashed government tracker tasked with hunting down members of the mutant resistance.",
                    "As a Hound, Summers participated in the capture and execution of dozens of mutants. She eventually broke free of her brainwashing and escaped to Earth-616, but the guilt has stuck with her to this day.",
                    "As soon as she arrived on Earth-616, Summers joined the X-Men and worked with them to help ensure that their universe would not go down the same dark path as her own. Although she later managed to return to her home universe and liberate its mutants, Summers still prefers life on Earth-616. These days, she spends most of her time as part of Krakoa’s Excalibur team, alongside her girlfriend and longtime teammate, Betsy Braddock.",
                ],
                Personality =
                [
                    "Although they are not—strictly speaking—her birth family, Rachel Summers is close with the Earth-616 versions of her mother (Jean Grey), father (Cyclops) and brother (Cable). She lives with them in the Summer House in the Blue Area of the Moon.",
                    "Rachel is more like her mother than she would ever like to admit. They are both gifted telepaths and favored hosts for the Phoenix Force. Their personal traumas spring from very different sources, but both Rachel and her mother have fiery and occasionally erratic personalities."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Aurora",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 3, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Dazzle),
                        powerSelector.GetPower(PowerNames.Illumination),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BlazingFastFists),
                        powerSelector.GetPower(PowerNames.Blur),
                        powerSelector.GetPower(PowerNames.CatchBullets),
                        powerSelector.GetPower(PowerNames.LightningActions),
                        powerSelector.GetPower(PowerNames.MolecularDestabilization),
                        powerSelector.GetPower(PowerNames.SpeedBlast),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jeanne-Marie Beaubier",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Unusually pointy ears",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.AlphaFlight, TeamNames.Marauders],
                Base = "Krakoa",
                History =
                [
                    "Jeanne-Marie Beaubier and her brother, Jean-Paul, were just infants when their parents died in a car accident. In the chaos of the aftermath, the twins were sent to different orphanages. Jean-Paul grew up bouncing around the foster system, while Jeanne-Marie spent her childhood in a Catholic boarding school.",
                    "The twins had no knowledge of each other’s existence until they were well into their adult years after being recruited into Canada’s Department H. The moment they grasped hands, their mutant powers activated, and a powerful and blinding light emerged from their bodies, blasting them backward.",
                    "The twins decided to use their powers for the betterment of humanity. They joined the Canadian super-team Alpha Flight and spent most of the next decade adventuring together, making up for lost time.",
                    "The twins began living separate lives again after the founding of Krakoa drew them away from their Alpha Flight colleagues. These days, Jean-Paul runs Krakoa’s X-Factor Investigations team, while Jeanne-Marie serves as a member of the secretive Marauders."
                ],
                Personality =
                [
                    "The sadistic nuns who ran the boarding school where Jeanne-Marie grew up taught her to be demure and obedient the only way they knew how: by beating it into her.",
                    "To survive, Jeanne-Marie increasingly had to compartmentalize the freewheeling aspects of her personality. This eventually led to her manifesting a form of dissociative identity disorder, in which she had one uninhibited personality and one well-behaved, repressed personality.",
                    "Only recently did she manage to integrate these disparate aspects of herself into a single core personality. The current Jeanne-Marie is both levelheaded and fun-loving."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Average Citizen",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 0, vigilance: 0, ego: 0, logic: 0
            ),
            Traits = [],
            Tags = [],
            Powers = [],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "Any",
                Occupations = [],
                Origins = [],
                Teams = [],
                Base = "Anywhere",
                History =
                [
                    "This person has led a fairly ordinary life and has an average amount of abilities. In addition to that, they have no super-powers.",
                ],
                Personality =
                [
                    "This profi le is for an average, unpowered human. It can be used in a pinch for many characters, but it can also be tailored to suit particular characters with just a few adjustments.",
                ]
            }
        },
    ];
}
