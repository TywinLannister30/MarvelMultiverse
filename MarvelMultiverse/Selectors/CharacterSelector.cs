using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarvelMultiverse.Selectors;

public class CharacterSelector(
    IPowerSelector powerSelector,
    ITagSelector tagSelector,
    ITraitSelector traitSelector) : ICharacterSelector
{
    public Character GetCharacter(string name)
    {
        var character = GetAllCharacters().FirstOrDefault(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        SetUpCharacter(character);

        return character;
    }

    public List<Character> GetCharacters()
    {
        var characters = GetAllCharacters();

        foreach (var character in characters)
        {
            SetUpCharacter(character);
        }

        return characters;
    }

    private static void SetUpCharacter(Character character)
    {
        character.SetDefences();
        character.SetHealth();
        character.SetFocus();
        character.SetKarma();
        character.SetInitiative();
        character.SetSpeed();
        character.SetNonCombatCheckModifiers();
        character.SetDamageModifiers();
    }

    private List<Character> GetAllCharacters()
    {
        var allCharacters = new List<Character>();
        allCharacters.AddRange(GetAllCharactersA());
        allCharacters.AddRange(GetAllCharactersB());
        allCharacters.AddRange(GetAllCharactersC());
        allCharacters.AddRange(GetAllCharactersD());
        allCharacters.AddRange(GetAllCharactersE());
        allCharacters.AddRange(GetAllCharactersF());
        allCharacters.AddRange(GetAllCharactersG());
        allCharacters.AddRange(GetAllCharactersH());
        allCharacters.AddRange(GetAllCharactersI());
        allCharacters.AddRange(GetAllCharactersJ());
        allCharacters.AddRange(GetAllCharactersK());
        allCharacters.AddRange(GetAllCharactersL());
        allCharacters.AddRange(GetAllCharactersM());
        return allCharacters;
    }
    private List<Character> GetAllCharactersA() =>
    [
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
                new PowerSet
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
                new PowerSet
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
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new PowerSet
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
                new PowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticManipulation)
                    ],
                },
                new PowerSet
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
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new PowerSet
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
                new PowerSet
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
                new PowerSet
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
                new PowerSet
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
                new PowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalPortal),
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimePortal),
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BlazingFastFists),
                        powerSelector.GetPower(PowerNames.Blur),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
                new PowerSet
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
            Name = "A. I. M. Agent",
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
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                    ],
                },
                new PowerSet
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
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new PowerSet
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
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, specialization: "Ants"),
                    ],
                    IsTech = true
                },
                new PowerSet
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

    private List<Character> GetAllCharactersB() =>
    [
        new()
        {
            Name = "Baron Mordo",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 5, ego: 8, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Karl Amadeus Mordo",
                Heights = [new() { Feet = 6 }],
                Weights = [250],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bright green and yellow robes, goatee",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [],
                Base = "Castle Mordo",
                History =
                [
                    "Starting in his youth, Mordo studied the mystic arts under the tutelage of the Ancient One. A greedy and resentful man, he sought magic power primarily as a means to restore the Transylvania of his youth to its once-great feudal status.",
                    "Mordo eventually got sick of the Ancient One’s mystic methods and betrayed him in favor of the power offered by the dread demon Dormammu instead. In the years since, Mordo has spent much of his time serving Dormammu and butting heads with the Ancient One’s most famous disciple: Doctor Strange.",
                ],
                Personality =
                [
                    "Boastful, zealous and often verging on insane, Baron Mordo is not the type to make friends. More than anything, he desires the power to prove to the world that he is the greatest sorcerer in existence. He has returned from death and madness on multiple occasions to continue his pursuit of ultimate power.",
                ]
            }
        },
        new()
        {
            Name = "Baron Zemo (Helmut Zemo)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 1, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Adhesive X"),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Helmut Zemo",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [183],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blonde",
                Size = Size.Average,
                DistinguishingFeatures = "Heavily scarred face, covered with a mask",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra, TeamNames.MastersOfEvil, TeamNames.Thunderbolts],
                Base = "Tower Zemo",
                History =
                [
                    "Helmut Zemo was born the son of Heinrich Zemo, a Nazi scientist and super villain. Heinrich spent years seeking the destruction of America and the resurrection of fascist Germany but ultimately died in a rockslide while fighting with Captain America. Helmut, furious, chose to follow in his father’s footsteps.",
                    "Helmut has long served as a key figure among fascist organizations, acting as an ally to the likes of the Red Skull and Hydra. Over the years, he’s personally founded and led a number of super teams, including multiple incarnations of the Masters of Evil and the Thunderbolts.",
                ],
                Personality =
                [
                    "Despite being a fascist zealot bent on world domination, Zemo has a good head for battle. He lacks extensive super-powers, relying instead on careful scheming to best his opponents. His duplicitous nature makes him a danger both to his enemies and his supposed allies.",
                ]
            }
        },
        new()
        {
            Name = "Beast (Hank McCoy)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 2, vigilance: 2, ego: 3, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Henry Philip “Hank” McCoy",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [402],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Covered with blue fur",
                Size = Size.Big,
                DistinguishingFeatures = "Pointed teeth and ears, claws, blue fur",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Avengers, TeamNames.XMen, TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "Despite his obvious brilliance, Hank McCoy was expelled from college because of his mutant status. Shortly thereafter, he was recruited by Professor Xavier to become a founding member of the X-Men.",
                    "Hank was born with super-strength, agility and intelligence, but he acquired his trademark blue fur during a brief sabbatical from the X-Men, when he ingested an experimental serum designed to activate latent mutations. He’s temporarily morphed into other forms since, but he always seems to return to the bushy blue Beast he’s best known as.",
                    "Hank is widely regarded as one of the world’s greatest scientists and super heroes. In recent years, he’s taken on more of a leadership role among the X-Men and mutant society at large, becoming the leader of X-Force."
                ],
                Personality =
                [
                    "Though something of a hothead in his youth, Hank developed a more stringently logical demeanor. If anything, the modern Beast has become impersonal, seeing his allies more as assets than people.",
                ]
            }
        },
        new()
        {
            Name = "Black Bolt",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 8, resilience: 4, vigilance: 4, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Mute, reminder: "Cannot speak without activating sonic blasts."),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlSound,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BlazingFastFists),
                        powerSelector.GetPower(PowerNames.Blur),
                        powerSelector.GetPower(PowerNames.CatchBullets),
                        powerSelector.GetPower(PowerNames.LightningActions),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Blackagar Boltagon",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.TheHouseOfAgon, TeamNames.UniversalInhumans],
                Base = "Attilan",
                History =
                [
                    "Blackagar Boltagon was born into the House of Agon, the Inhuman royal family. Because he was exposed to the Terrigen Mists while still in utero, his powers surpass those of most Inhumans.",
                    "Black Bolt cannot speak normally. He has other methods of communicating, but any vocal noise he makes becomes a massive sonic blast. He was kept in a soundproof chamber for most of his youth, only being released shortly before he took the mantle of Inhuman monarch.",
                    "Black Bolt’s primary goals have always been to preserve the Inhuman homeland and to foil those who would usurp his rule. No one has been a more regular threat to Black Bolt than his own brother, Maximus, a madman who often would rather the Inhumans be wiped out by the Kree than allow Black Bolt to stay on the throne."
                ],
                Personality =
                [
                    "While generally considered by his people to be a benevolent ruler, Black Bolt can come off as a bit aloof, especially to non-Inhumans.",
                ]
            }
        },
        new()
        {
            Name = "Black Panther (T’Challa)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Killmonger"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Electrified vibranium claws [+1 damage multiplier]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),
                       
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.OperationsCenter),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "T’Challa",
                Heights = [new() { Feet = 6 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.HighTech, OriginName.Magic],
                Teams = [TeamNames.AgentsOfWakanda, TeamNames.Avengers, TeamNames.FantasticFour, TeamNames.PantherCult, TeamNames.Ultimates],
                Base = "Wakanda",
                History =
                [
                    "As the young heir of Wakanda, T’Challa went through a grueling series of tests to prove his worthiness to become the Black Panther and lead his nation, the most technologically advanced country on the planet. At one point, he lost the powers given to him as the Black Panther by the heart-shaped herb, but he regained them by pledging himself to the panther god Bast and becoming King of the Dead, ruler of the Necropolis under Wakanda.",
                    "Today, T’Challa not only leads Wakanda and the Avengers but also the Agents of Wakanda, which provides support for the Avengers on their vital missions. He also spends as much time as he can with his ex-wife, Storm, with whom he has renewed their romance.",
                ],
                Personality =
                [
                    "T’Challa is serious, competent and regal. He was born to his position, but knew that he would always have to work hard to attain it and keep it. He takes nothing for granted, especially his responsibilities, the greatest of which is the welfare of his people. While Wakandan to his core, he was educated in Europe and America.",
                ]
            }
        },
        new()
        {
            Name = "Black Widow (Natasha Romanoff)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Sneaky),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese, English, French, German, Japanese, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Natasha Romanoff",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [131],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.InfinityWatch, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Trained from a young age to be a Russian special agent, Natasha Romanoff defected to the United States after clashing with the Avengers. Since then, Natasha has served as a vital ally to many of the most powerful organizations on the planet, particularly S.H.I.E.L.D. and the Avengers.",
                    "Natasha spent much of her career as a solo mercenary, doing high-level black ops for paying clients. She tries to never take a job she believes to be immoral, but in the world of espionage, things are not always so clear-cut.",
                ],
                Personality =
                [
                    "Charming and cool-headed, Natasha’s personality makes her an excellent spy. A life of espionage has made her slow to trust others, but those closest to her consider her a good friend and an exceptional team leader.",
                ]
            }
        },
        new()
        {
            Name = "Blade",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Monster),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Deceased),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Imageless),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Sword"),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Eric Brooks",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [215],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Back tattoos, fangs",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MonstrousVampire, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.MI13, TeamNames.MidnightSons],
                Base = "Mobile",
                History =
                [
                    "Eric Brooks’ mother was attacked by a vampire while he was still in the womb. She died, but he survived, transformed into a half vampire.",
                    "As a dhampir, Brooks has all the strengths of a vampire, but none of their weaknesses. Aided by his powers, he underwent extensive training in swordplay and acrobatics, vowing to rid the world of the kind of monsters who killed his mother.",
                    "Blade has teamed up with other super heroes from time to time, but he’s never lost sight of the goal which has driven him his entire life. No one poses more of a threat to the vampire world than him."
                ],
                Personality =
                [
                    "Blade is a no-nonsense operator focused on his grim mission to rid the world of the undead. He can sometimes come across as cocky, but he can be warm to his allies and friends, though he has little time to make either.",
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Dhampir",
                        Description =
                        [
                            "As half-human/half-vampire, Blade does not have all of the powers of vampires, nor all their traits and tags."
                        ]
                    }
                ]
            }
        },
        new()
        {
            Name = "Blue Marvel",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 5, resilience: 6, vigilance: 3, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Neutronium"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Family"),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Adam Bernard Brashear",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Educator, OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.Ultimates],
                Base = "New York City",
                History =
                [
                    "Adam Brashear already had an extensive combat career as a Marine in the Korean War when he was blasted by an experimental machine designed to create a bridge to the Negative Zone. This accident made Adam into the Blue Marvel, one of the most powerful men on Earth, but it also turned his friend Connor Sims into Anti-Man, his nemesis.",
                    "Adam has been a major part of hero operations since the 1960s, but because of his status as an African American, his heroic deeds at the time were covered up. His identity was only revealed to the world recently, long after he had retired from adventuring to become a teacher. Now accepted by the wider world, Adam has become Blue Marvel once again.",
                ],
                Personality =
                [
                    "Despite a lifetime of discrimination weighing on his soul, Adam has always managed to be a loyal friend and a good teacher. His students consider him to be charming and personable.",
                ]
            }
        },
        new()
        {
            Name = "Brawn (Amadeus Cho)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 4, vigilance: 2, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Gamma Forms"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Amadeus Cho",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [117],
                Gender = Gender.Male,
                Eyes = "Black",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Green skin (while using powers)",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.Champions],
                Base = "Mobile",
                History =
                [
                    "By the time Amadeus Cho was a teenager, he was being hunted by international organizations desperate to harness his abnormal intelligence. Forced into a life on the run, Cho fell into the occasional company of another roaming hyper-intelligent scientist—Bruce Banner (the Hulk)—and the two became fast friends.",
                    "When a radioactive meltdown threatened to turn Bruce into a nuclear bomb, Cho built a machine to transfer the excess radiation out of Bruce and into himself. The radiation imbued Cho with a sizable portion of the Hulk’s powers. For a while, Cho took up the title of Hulk himself, but in more recent days, he’s come to prefer the codename Brawn.",
                ],
                Personality =
                [
                    "Like many gamma mutates, Cho has struggled with anger issues, but compared to Bruce Banner, Cho is as cool as an ice cube. Cho’s super-intelligence is matched with an emotional immaturity that can land him in over his head in certain situations. Thanks to his Champions teammates and his brilliant sister, Maddy, Cho has begun to navigate the world more thoughtfully.",
                ]
            }
        },
        new()
        {
            Name = "Bullseye",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 3, vigilance: 2, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Sniping"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Lester",
                Heights = [new() { Feet = 6 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Bull’s-eye scar on forehead",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining, OriginName.HighTechCybernetics],
                Teams = [TeamNames.DarkAvengers, TeamNames.FiskIndustries, TeamNames.TheHand],
                Base = "Hell’s Kitchen, New York City",
                History =
                [
                    "Beyond his first name, the world knows next to nothing about the man who became Bullseye. He trained for some period as a mercenary with the United States government, eventually resurfacing in New York as Bullseye, extortionist and killer for hire.",
                    "Hell’s Kitchen has long been Bullseye’s base of choice, regularly putting him into conflict with Daredevil. Besides the Kingpin himself, Bullseye may be Daredevil’s most dangerous nemesis. His superhuman ability to hit any target from any angle makes him a perfect match for the swift and acrobatic Man Without Fear.",
                ],
                Personality =
                [
                    "Bullseye is a madman who enjoys killing above all else. He’s generally not the type to be reasoned with, though he has been persuaded to cooperate",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersC() =>
    [
        new()
        {
            Name = "Captain America (Steve Rogers)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Hydra"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Red Skull"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Captain America’s shield [+1 Melee and Agility Damage multiplier. Grants the user one extra level of the power Shield (up to Shield 4), which they can use without paying the additional level’s Focus cost.]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.HurledShieldBlock),
                        powerSelector.GetPower(PowerNames.HurledShieldDeflection),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.RicoShield),
                        powerSelector.GetPower(PowerNames.Shield3),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
                        powerSelector.GetPower(PowerNames.ShieldWall),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Steve Rogers",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [240],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD, TeamNames.USArmy],
                Base = "Avengers Mountain",
                History =
                [
                    "At the dawn of World War II, scrawny Steve Rogers was rejected by the U.S. Army as unfit for service, but Dr. Abraham Erskine saw something in him and selected him for the first human trials for his Super-Soldier Serum. A Nazi sympathizer assassinated Erskine during the procedure, but not before Rogers was improved to the peak of human physical ability. As Captain America, Rogers fought Nazis on the front lines in Europe, alongside his sidekick Bucky Barnes—right up until 1945 when they were presumed killed while stopping a plot by the evil Baron Zemo.",
                    "Decades later, the newly formed Avengers found Rogers frozen in a block of ice and revived him. He immediately leaped back into action, defending American ideals and saving the entire planet again and again.",
                ],
                Personality =
                [
                    "Rogers is serious about helping people out, and he’s a natural leader, both in and out of combat. He knows that when he’s in his costume and carrying his shield he represents everything that is great about the land and people he loves so much.",
                ]
            }
        },
        new()
        {
            Name = "Captain Marvel (Carol Danvers)",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 7, agility: 6, resilience: 6, vigilance: 5, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Magnitron (Yon-Rogg)"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Arabic, English, Imperial Shi’ar, Kree, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy4),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Carol Danvers",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [145],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military, OccupationName.Spy],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Avengers, TeamNames.Ultimates, TeamNames.USAirForce],
                Base = "New York City",
                History =
                [
                    "While serving as a pilot for the U.S. Air Force and NASA, Carol Danvers became involved with Captain Mar-Vell, a super-powered visitor from the Kree Empire, and was caught in an explosion that she thought gave her super-powers too. She later discovered that the blast activated the Kree DNA she was previously unaware she’d inherited from her mother. Danvers joined the Avengers, but lost her powers to Rogue. Over the years, she has struggled with fluctuating power levels, alcoholism and low self-confi dence, but after using the names Binary, Warbird and Ms. Marvel, Danvers claimed the Captain Marvel name to honor Mar-Vell, who had died of cancer.",
                ],
                Personality =
                [
                    "Danvers is a strong-willed and pragmatic person who has embraced her role as a mentor to younger heroes like the new Ms. Marvel (Kamala Khan). She cares for her friends deeply and does whatever it takes to protect them and the worlds in which they live.",
                ]
            }
        },
        new()
        {
            Name = "Clea",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 6, ego: 9, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new PowerSet
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
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Clea",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [190],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.Defenders],
                Base = "Sanctum Sanctorum",
                History =
                [
                    "As the niece of the dread Dormammu, Clea was raised in the Dark Dimension. Her relatively quiet life there changed completely upon the first intrusion of Doctor Stephen Strange.",
                    "Impressed by the mortal’s magical abilities, Clea fell in love with Doctor Strange. She did all in her power to preserve his life throughout his repeated battles with Dormammu, going so far as to temporarily sacrifice herself. After decades of battling side by side, Clea and Strange were married.",
                    "With Strange’s recent death, Clea—who was already the Sorcerer Supreme of the Dark Dimension—has taken the title of Earth’s Sorcerer Supreme as well."
                ],
                Personality =
                [
                    "Determined and hotheaded, Clea refuses to let anyone stand in the way of her goals, whatever they may be. While she has a soft spot for Strange, Clea is often condescending to those she considers to be her lessers, and that category includes most people.",
                ]
            }
        },
        new()
        {
            Name = "Colossus",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 3, resilience: 7, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "in Alternate Form; Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.Sturdy4}"),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Adamantium or vibranium weapons"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Metallic Form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, Japanese, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                },
                new PowerSet
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
                },
            ],
            Biography = new Biography
            {
                RealName = "Piotr Nikolaievitch “Peter” Rasputin",
                Heights = [new() { Feet = 6, Inches = 6 }, new() { Feet = 7, Inches = 5 }],
                Weights = [250, 500],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Piotr Rasputin first discovered his latent mutant powers as a teenager, when he jumped in front of a runaway tractor in order to save his little sister, Illyana. He discovered that he could, at will, assume the form of a metal man, greatly increasing his size, strength and durability.",
                    "Shortly after he discovered his powers, Colossus was recruited by Professor X and became a member of the X-Men’s second incarnation. Since then, Colossus has served the world as both a hero and a mutant activist.",
                ],
                Personality =
                [
                    "For a long time, Colossus was known for letting his passion get the best of him in the heat of battle, turning him into a nigh-unstoppable metal berserker. In recent years he has adopted a softer and more sympathetic attitude. For those he loves, his heart is as big as his anger is strong.",
                ]
            }
        },
        new()
        {
            Name = "Crossbones",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Submachine Gun"),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DanceOfDeath),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.FastHands),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Brock Rumlow",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [290],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Skull and crossbones mask",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra, TeamNames.Thunderbolts, TeamNames.SkeletonCrew],
                Base = "Mobile",
                History =
                [
                    "As a teenager growing up in New York, Brock Rumlow killed two boys in a gang-related conflict. After fleeing the authorities, he began training as a mercenary with the Taskmaster Technical School for criminals.",
                    "As an adult, Crossbones has found his work primarily as a hired killer for the Red Skull and Hydra. His superhuman strength and speed, combined with his cruel nature, has made him almost as formidable a foe as the Skull himself. During the first Superhuman Civil War, Rumlow successfully pulled off the Red Skull’s plot to assassinate Captain America, temporarily putting the first Avenger out of commission.",
                ],
                Personality =
                [
                    "Crossbones carries himself in the manner of a classic hard-talking, no-nonsense military man. He is a ruthless mercenary who lives for the rush of battle. His deep-seated belief that might makes right regularly puts him into conflict with defenders of the weak. He is loyal to no one but his longtime girlfriend—the Red Skull’s daughter, Sin.",
                ]
            }
        },
        new()
        {
            Name = "Cyclops",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 2, vigilance: 3, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese, English, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                        powerSelector.GetPower(PowerNames.OperationsCenter),
                        powerSelector.GetPower(PowerNames.RallyOnMe),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Scott Summers",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [195],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Ruby-quartz visor",
                Occupations = [OccupationName.Educator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a young boy, Scott Summers suffered a major head injury during a plane crash. This put him into a coma for several years and destroyed his ability to control his emerging mutant powers. When opened, Scott’s open eyes constantly emit powerful energy blasts.",
                    "Professor X found Scott and fashioned a rubyquartz visor to control the boy’s raw energy. Recognizing Scott’s incredible powers, the professor offered to make the boy the first member of his then nascent X-Men team. Scott has been the de facto leader of the X-Men ever since.",
                ],
                Personality =
                [
                    "Despite being an intelligent and commanding leader, Scott has often struggled in personal social situations. Over the years, with the help of his mutant friends, he’s managed to overcome much of his social anxiety.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersD() =>
    [
        new()
        {
            Name = "Daredevil",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 1, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Work"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.VisionIssues),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Daredevil’s Billy Club. Adds +1 damage multiplier and grants the swingline movement mode, with a speed equal to triple his Run Speed. The Billy Club can be thrown and instantly retrieved. The range of the Billy Club and the reach of the swingline is equal to its Swingline Speed: 15 spaces.",
                            swinglineSpeed: true,
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Matthew “Matt” Murdock",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "Blind",
                Occupations = [OccupationName.Lawyer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Defenders],
                Base = "Hell’s Kitchen, New York City",
                History =
                [
                    "When Matt Murdock was just a boy, his face was splashed with a rare radioactive isotope. While the isotope cost him his sight, it enhanced all his other senses. Shortly thereafter, his father was killed by mobsters for refusing to take a fall in a mob-run boxing match. Matt vowed revenge on all the criminals of Hell’s Kitchen and began training in martial arts with the legendary sensei Stick.",
                    "As an adult, Matt fights crime both within and without the boundaries of the law. In addition to his duties as Daredevil, he often runs a thriving law office with his longtime pal Foggy Nelson.",
                ],
                Personality =
                [
                    "Though firmly dedicated to the pursuit of justice, Matt is not above a joke or engaging in a bit of romance. His legal clients think of him as a charming, highly considerate gentleman.",
                ]
            }
        },
        new()
        {
            Name = "Deadpool",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 4, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Katana"),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.LeapingLeglock),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wade Wilson",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [210],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Full-body scarring",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.MercsForMoney],
                Base = "Mobile",
                History =
                [
                    "Wade Wilson was an ordinary man, until he contracted a deadly cancer. On the verge of death, he turned to the experimental Weapon X program, where scientists implanted him with Wolverine’s healing factor. The treatment saved Wilson’s life but drove him insane and left him with scars all over his body.",
                    "As the super-powered Deadpool, Wade’s driving motivation has long been to just have a good time. He’s worked as a contract killer, a mercenary and a bona fide super hero. Whether it’s money, power or a decent lunch, he seeks only whatever will please him in a given moment.",
                ],
                Personality =
                [
                    "Thoroughly insane, Deadpool can be a good guy one minute and a terrifying villain the next. He’s best known for his anarchic jokester attitude. He takes almost nothing seriously, not even his status—at least in his own mind—as a comic-book character.",
                ]
            }
        },
        new()
        {
            Name = "Devil Dinosaur",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 6, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mute, reminder: "Can only roar."),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow1, reminder: "permanently Huge size; Reach 5"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Devil",
                Heights = [new() { Feet = 20 }],
                Weights = [600],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Huge,
                DistinguishingFeatures = "Red T. rex.",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = ["Partner to Moon Girl and Moon-Boy"],
                Base = "New York City",
                History =
                [
                    "The Tyrannosaurus rex known as Devil Dinosaur was born on an alternate Earth, one filled with dinosaurs and simple, apelike humans. As a child, Devil was almost burned to death by a tribe of humans known as the Killer-Folk. He was rescued by a young human of the rival Small-Folk tribe, who called himself Moon-Boy. Together, the two adventured throughout Dinosaur World, repeatedly foiling the dastardly plots of the Killer-Folk.",
                    "Following the death of Moon-Boy at the hands of the Killer-Folk, Devil and a number of the Killer-Folk were transported to Earth-616. There, he teamed up with child prodigy Lunella Lafayette, who took the title of Moon Girl, and the two have been adventuring together ever since.",
                ],
                Personality =
                [
                    "Although he cannot speak, Devil Dinosaur shows signs of human-level intelligence. He seems to have the ability to understand human language and follow complex plans. In any case, he’s no less ferocious or effective in battle than any other T. rex.",
                ]
            }
        },
        new()
        {
            Name = "Doctor Doom",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 4, ego: 7, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, German, Hungarian, Latverian, Romani"),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.CrimsonBandsOfCyttorak),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Victor Von Doom",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Heavily scarred face, suit of armor",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.IntergalacticCouncil, TeamNames.SavageAvengers, TeamNames.TerribleTrio],
                Base = "Latveria",
                History =
                [
                    "Born to a poor Romani family in the far-flung country of Latveria, Victor Von Doom first encountered Reed Richards while in college on scholarship. The two were instantly bonded as intellectual rivals and compatriots. However, Doom quickly grew tired of Richards upstaging him, purposefully ignoring a mistake in his experimental calculations just because Richards pointed it out. Doom’s experiment blew up in his face, permanently scarring him.",
                    "Bent on revenge, Victor quit college and obtained a powerful suit of Tibetan armor, becoming the dreaded Doctor Doom. He conquered his homeland of Latveria, declaring himself king. Ever since, he’s been a monstrous threat to Reed Richards, the Fantastic Four and the world at large.",
                ],
                Personality =
                [
                    "Doom’s defining feature is his ego. Be it science or sorcery, he wishes to believe that he is the best at everything he does, and he is deeply angered by any evidence which would point to the contrary.",
                ]
            }
        },
        new()
        {
            Name = "Doctor Octopus (Otto Octavius)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 2, ego: 4, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, isTech: true),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Otto Octavius",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [245],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Four mechanical arms",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTech, OriginName.WeirdScience],
                Teams = [TeamNames.MastersOfEvil, TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Everything changed for brilliant scientist Otto Octavius after a lab experiment gone wrong drove him mad and left him with mental control of four mechanicals arms. With these powerful limbs at his disposal, Octavius decided to fi nance his future research through crime, becoming the super villain Doctor Octopus.",
                    "Doc Ock’s life has been intertwined with that of his one-time admirer Peter Parker (Spider-Man). Ock has fought Spider-Man countless times, romanced Parker’s Aunt May and even become Parker himself for a brief period. As more multiversal variants of Spider-Man appear, more versions of Doc Ock have also manifested themselves.",
                ],
                Personality =
                [
                    "Doctor Octopus is a Grade-A narcissist. He considers his scientific endeavors to be of the greatest importance to humanity, and he is not above robbing, hurting and even killing others in the pursuit of his research.",
                ]
            }
        },
        new()
        {
            Name = "Doctor Strange",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 3, vigilance: 7, ego: 9, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Loner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Baron Mordo"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Dormammu"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new PowerSet
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
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Stephen Vincent Strange",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Gray",
                Hair = "Black, gray",
                Size = Size.Average,
                DistinguishingFeatures = "Minor scars on hands",
                Occupations = [OccupationName.HealthCareWorker],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.Avengers, TeamNames.StrangeAcademy],
                Base = "New York City",
                History =
                [
                    "After a car accident damaged the nerves in his hands, Dr. Stephen Strange was forced to retire from his job as a successful neurosurgeon. Desperate for a cure, Stephen pawned what few possessions he had and voyaged to Tibet, where he sought out a powerful sorcerer known only as the Ancient One.",
                    "Rather than simply heal Stephen’s hands, the Ancient One offered to make the gifted young man his apprentice. Stephen accepted the offer and spent years training under the Ancient One’s tutelage. Following his master’s death, Stephen ascended to the title of Sorcerer Supreme and became the world’s foremost mystical defender.",
                ],
                Personality =
                [
                    "Even back in his surgeon days, Stephen Strange was known for his haughty and cold personality. He has since learned several lessons in humility, and he’s developed a soft spot for his closest allies, particularly his wife, Clea.",
                ]
            }
        },
        new()
        {
            Name = "Dora Milaje Warrior",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 1, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Dora Milaje)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.PublicIdentity),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                DistinguishingFeatures = "Vibranium armor, weaponry",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.DoraMilaje],
                Base = "Wakanda",
                History =
                [
                    "The Dora Milaje, also known as the “Mighty and Adored,” are the militarized personal guard of the Black Panther. The first incarnation of the Dora Milaje was established in Wakanda many centuries ago, but they had long been put out of commission until T’Challa (the current Black Panther) reinstated them.",
                    "Following some recent revolts within the Dora Milaje, the Black Panther agreed to limit his own powers as monarch and establish a democratic government in Wakanda. The Dora Milaje still exist and still protect the Panther, but their powers as a military organization have also considerably diminished.",
                ],
                Personality =
                [
                    "The warriors of the Dora Milaje are, by and large, proud and powerful military women. They join the Dora out of pride for their country and respect for the Black Panther. Most members of the Dora Milaje shave themselves bald when they enter the organization as a show of dedication.",
                ]
            }
        },
        new()
        {
            Name = "Dormammu",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 5, vigilance: 5, ego: 9, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty4),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SenseSupernatural),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HellfireChains),
                        powerSelector.GetPower(PowerNames.SenseSins),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow3),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Dormammu",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "Flames",
                Size = Size.Average,
                DistinguishingFeatures = "Flaming body",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.MagicDemonic],
                Teams = [TeamNames.HellLords, TeamNames.LordsOfTheSplinterRealms],
                Base = "Dark Dimension",
                History =
                [
                    "Exiled from the mystical realm known as the Faltine, Dormammu and his family singlehandedly conquered the native people of the Multiversespanning Dark Dimension, turning it into their fortress. Over untold centuries, Dormammu slowly pushed the other members of his family out of power, eventually declaring himself the sole Lord of the Dark.",
                    "As a being of nearly limitless power, Dormammu’s conquest of all reality has been halted solely by the ancient lineage of the Sorcerer Supreme, but time has not dulled the dark one’s ambitions. Aided by his servant Baron Mordo, Dormammu’s schemes to defeat the Sorcerer Supreme have only become more frequent and dangerous over the last several decades.",
                ],
                Personality =
                [
                    "As one of the most intelligent and long-lived conquerors across all existence, Dormammu is proud in victory and a pragmatist in defeat. Dormammu considers every defeat a minor setback on the road to his eternal reign. Ever the opportunist, he always fi nds a way to turn an unfavorable shortterm situation into a long-term advantage.",
                ]
            }
        },
        new()
        {
            Name = "Drax",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 4, resilience: 7, vigilance: 3, ego: 3, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Thanos"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Arthur Sampson Douglas",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [680],
                Gender = Gender.Male,
                Eyes = "Entirely red",
                Hair = "Bald",
                Size = Size.Big,
                DistinguishingFeatures = "Green skin covered in red tattoos",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.InfinityWatch, TeamNames.UnitedFront],
                Base = "Mobile",
                History =
                [
                    "While driving through the Mojave Desert, Arthur Douglas and his wife and daughter spotted Thanos’ spaceship on a reconnaissance mission, and Thanos destroyed their car to keep his presence secret. Horrified, Thanos’ father (Mentor) asked his own father (Kronos) to help him create someone powerful enough to defeat Thanos. Together, they formed a body and imbued it with Douglas’ spirit, calling it Drax. Awakening in this new form, Drax had no memory of his original life, only a driving hatred for his murderer.",
                    "Drax later regained his memories and learned Mentor had also rescued his daughter, who had become Moondragon. He has killed Thanos a number of times, although the Mad Titan keeps coming back.",
                    "After helping end the Annihilation War, Drax joined the Guardians of the Galaxy. He was resurrected once after being killed, but he came back in a smaller form with fewer powers. He later sacrificed himself to save the rest of the Guardians of the Galaxy, but a clone with his memories has since taken his place."
                ],
                Personality =
                [
                    "As Drax began as a moody person bent on vengeance. While he can still be dire and serious when on a mission, he has lightened up a great deal over the years and come to enjoy fi ghting for the sheer thrill of it. He has a dark, off-beat sense of humor rooted in the fact that he has only a rudimentary understanding of society, how jokes work and what most people would consider terrifying.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersE() =>
    [
        new()
        {
            Name = "Echo",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "Clone Moves"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AuditoryIssues),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CloneMoves),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Maya Lopez",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "White handprint makeup on face",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.DaughtersOfLiberty],
                Base = "Avengers Mountain",
                History =
                [
                    "When Maya Lopez was a child, her father was gunned down by his own boss: Wilson Fisk (Kingpin). Seeing the young girl’s potential, Fisk took her in, giving her special training and eventually tricking her into believing that her father’s killer was Daredevil.",
                    "After fighting the Man Without Fear several times, Maya discovered the Kingpin’s deception and turned on him. Her quest for vengeance resolved, she became a tireless fighter for justice around the world.",
                ],
                Personality =
                [
                    "As a deaf woman and a member of the Cheyenne Nation, Maya has faced many struggles. Despite this, she generally manages to stay upbeat. She has a particular love for the theatrical arts, having become a concert pianist and an expert dancer.",
                ]
            }
        },
        new()
        {
            Name = "Elektra",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 1, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Fast Attacks"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Sai"),
                tagSelector.GetTag(TagNames.Streetwise),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Elektra Natchios",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.TheHand, TeamNames.SavageAvengers],
                Base = "Hell’s Kitchen",
                History =
                [
                    "Already working as an agent of the Hand, Elektra first encountered Matt Murdock while in college. Admirers of each other’s skills, the two quickly fell in love, but after a tragic accident killed Elektra’s father, she abandoned Matt to return to her work as an assassin.",
                    "Years later, while working for Kingpin, Elektra encountered Matt again, this time as the super hero Daredevil. They slowly began to rekindle their romance, and after years of fi ghting both together and separately—both of them being killed and resurrected multiple times—they seem to have finally gotten it together as partners. They now defend Hell’s Kitchen together, both acting as Daredevil.",
                ],
                Personality =
                [
                    "Trained as an assassin, Elektra is generally a cold and private person. However, she does have a soft spot for Matt Murdock. More than anything, she is defi ned by the unwavering determination she shows in pursuit of her goals.",
                ]
            }
        },
        new()
        {
            Name = "Emma Frost",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 4, vigilance: 6, ego: 4, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Crystalline Form"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DampenPower),
                        powerSelector.GetPower(PowerNames.ShutDownPowers),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.InformationUpload),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Emma Frost",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [144],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Dyed blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.HellfireClub, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "The mutant daughter of a wealthy family, Emma Frost was born with psychic powers rivaling those of Professor X himself. Later in life, she would further obtain the ability to transform herself into a powerful crystalline form.",
                    "As a young woman, Emma rejected multiple invitations to join the X-Men, only revealing herself to the world as a mutant after encountering Sebastian Shaw, the Black King of the villainous Hellfire Club. Frost became his White Queen, and together, they fought the X-Men. After defeating the Black King, the X-Men persuaded Emma to leave the Hellfire Club behind. Since then, Emma Frost has often been on the side of good, only occasionally falling back into old ways.",
                ],
                Personality =
                [
                    "As a wealthy heiress, Emma Frost was taught from birth to be proud, spoiled and petty. Over the course of decades, she has managed to become a bit more considerate and self-aware, but the attitudes she picked up in her youth frequently overwhelm her better nature.",
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Alternate Form",
                        Description =
                        [
                            "Frost underwent a secondary mutation that allows her to transform into crystalline form. This grants her the Mighty 1 and Sturdy 2 powers. She cannot use her Brilliance 1, Telepathy and Power Control powers when in that form. She can use her Uncanny 2 power in either form.",
                            "Numbers before a slash are for her regular human form, and numbers after a slash are for her crystalline form."
                        ]
                    }
                ]
            }
        },
        new()
        {
            Name = "Enchantress",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 3, ego: 7, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicChaosMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HexBolt),
                        powerSelector.GetPower(PowerNames.Jinx),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicPossession),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Amora",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [450],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Magic, OriginName.MythicAsgardian],
                Teams = [TeamNames.AstonishingAvengers, TeamNames.DarkCouncil],
                Base = "Asgard",
                History =
                [
                    "As the goddess of beauty and one of the most gifted magicians in existence, Amora ranks among the most powerful of the Asgardian elite. She seldom visited the modern world until the day she first encountered Thor Odinson. Impressed with the thunder god’s power, she sought to seduce him, but Thor ultimately rejected her in favor of Jane Foster.",
                    "Amora has harbored a grudge against Thor ever since. While she has had some brief flirtations with acting heroically, she spends most of her time plotting to take down Thor and the Asgardian royal family at large. To that end, she frequently finds herself acting as an ally to Loki.",
                ],
                Personality =
                [
                    "Equal parts vain and vengeful, Amora takes no half measures. She takes great pride in her abilities as a seductress and a sorceress, and she extracts brutal retribution against anyone brave enough to slight her. The only thing she fears is being left completely alone, with no one to adore her.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersF() =>
    [
        new()
        {
            Name = "Forge",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 4, vigilance: 3, ego: 5, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6 }],
                Weights = [179],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bionic leg and hand",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechCybernetics, OriginName.MagicSorcery, OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a powerful Cheyenne shaman and an equally brilliant inventor, the young Forge joined the military and had a traumatic tour of duty, during which he lost his right hand and leg. He went on to work in the field of advanced weapons research. On behalf of the U.S. government, Forge built a gun that could temporarily neutralize super-powers.",
                    "When Forge saw that his weapon was being used by S.H.I.E.L.D. agents to target mutants like himself, he abandoned his government job and took up adventuring with the X-Men. While he occasionally goes out adventuring on his own, Forge most enjoys serving as a technician for his fellow X-Men, equipping them with all kinds of powerful gadgets.",
                ],
                Personality =
                [
                    "Forge revels in his abilities as an inventor to “make the impossible real” as he has called it. He can be both a proud inventor and a soft - hearted romantic, proven by his long on-againoff -again relationship with fellow mutant and super hero Storm.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersG() =>
    [
        new()
        {
            Name = "Gamora",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 6, resilience: 5, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Nebula"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sniping),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedRun1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Gamora Zen Whoberi Ben Titan",
                Heights = [new() { Feet = 6 }],
                Weights = [170],
                Gender = Gender.Female,
                Eyes = "Yellow",
                Hair = "Dark green",
                Size = Size.Average,
                DistinguishingFeatures = "Light green skin with yellow area around the eyes",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Graces, TeamNames.GuardiansOfTheGalaxy, TeamNames.UnitedFront],
                Base = "Mobile",
                History =
                [
                    "Gamora came from a possible future (Earth-7528) in which she was the last survivor of the Zen Whoberi race, which the Universal Church of Truth wiped out. Thanos brought her back to Earth-616 and adopted her so that he could forge her into the ultimate assassin and send her to kill the Magus, the founder of the Universal Church of Truth. After helping the Magus, her time loop changed so that the Badoon killed the Zen Whoberis instead.",
                    "Gamora later helped Adam Warlock stop Thanos from destroying the universe and then set out on her own. After helping end the Annihilation War, she joined the Guardians of the Galaxy. Since then, she’s been a key part of the team, often leaving it but always rejoining.",
                ],
                Personality =
                [
                    "Gamora is sharp and focused, brooking no nonsense, the way that Thanos trained her. She often carries a great deal of anger and can be cold and intimidating to those around her, but she can also be intensely loyal to those few people she considers friends.",
                ]
            }
        },
        new()
        {
            Name = "Ghost Rider (Robbie Reyes)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 5, vigilance: 2, ego: 7, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "2 (Partial Phase, Phase Self)"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Ghost Rider Form"),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Gabe Reyes"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlHellfire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HellfireChains),
                        powerSelector.GetPower(PowerNames.PenanceStare),
                        powerSelector.GetPower(PowerNames.PossessVehicle),
                        powerSelector.GetPower(PowerNames.SenseSins),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedRun1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Robbie Reyes",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Flaming skull for a head when transformed.",
                Occupations = [OccupationName.Engineer],
                Origins = [OriginName.SpiritOfVengeance],
                Teams = [TeamNames.Avengers, TeamNames.SpiritsOfVengeance],
                Base = "Los Angeles",
                History =
                [
                    "Robbie Reyes was just a poor kid living in East L.A. when he was gunned down by gangsters. Reyes would have died were it not for a nearby vengeful spirit. The ghost of a serial killer, a man named Eli, had been secretly haunting Robbie’s car. Eli possessed Reyes, healing the boy’s wounds and transforming him into a Ghost Rider.",
                    "Reyes’ good nature was matched only by Eli’s bloodthirst. The two fought for control of Reyes’ body until a bit of assistance from another Ghost Rider (Johnny Blaze) allowed Reyes to finally get the best of Eli. Free of Eli’s influence, Reyes joined the Avengers and vowed to help rid the world of evil.",
                ],
                Personality =
                [
                    "As an orphan, Reyes’ primary motivation in life is to act as a guide and protector to his younger brother, Gabe. Around others, Reyes can be anxious and distant, but in Gabe’s presence, Reyes always puts up a tough front.",
                ]
            }
        },
        new()
        {
            Name = "Ghost-Spider",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "George Stacy"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.PublicIdentity, reminder: "Earth-65"),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "Earth-616"),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalPortal),
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                    IsTech = true
                },
                new PowerSet
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
                RealName = "Gwen Stacy",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy, TeamNames.WebWarriors],
                Base = "New York City",
                History =
                [
                    "On Earth-65, teenager Gwen Stacy was bitten by a genetically engineered spider and gained spider-based powers. Soon after, she became her world’s costumed crime-fighting Spider-Woman. In an early adventure, she battled her friend Peter Parker—who had not acquired spider-powers in this universe but had turned himself into the Lizard in an attempt to become a hero like Spider-Woman—and accidentally killed him, a mistake she has been trying to make up for since.",
                    "After being drawn into the multiversal battle of Spider-Totems against the murderous Inheritors, Stacy began traveling among worlds, particular between her own and Earth-616. After surviving the battle with the Inheritors, she took on the name Ghost-Spider. Her identity has become public in her universe, but she enjoys the anonymity she often finds in other worlds.",
                    "At one point, Stacy lost her spider-powers, but she regained them after bonding with a sentient costume made of synthetic spiders. She also has pendant/bracelet called the Ticket to the Multiverse that allows her to move between worlds."
                ],
                Personality =
                [
                    "Stacy is smart and friendly, an independent free spirit who enjoys playing drums in her rock band, the Mary Janes. Growing up the daughter of police detective George Stacy helped instill a strong sense of justice in her, and she tries to live up to her own ideals every day. She doesn’t always manage it, but she’s determined to keep making the effort.",
                ]
            }
        },
        new()
        {
            Name = "Giant-Man (Raz Malhotra)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 2, vigilance: 3, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Raz Malhotra",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.AgentsOfAtlas],
                Base = "Mobile",
                History =
                [
                    "Raz Malhotra spent his whole life studying the science of artificial intelligence, only to graduate from college during an unprecedented wave of anti-A.I. sentiment. Unable to find any career opportunities in A.I., Malhotra reluctantly took a tech-support job with the shady and reclusive Dr. Elihas Starr.",
                    "Unfortunately, Starr was secretly a madman bent on taking over the world. He brainwashed Malhotra and forced him to build evil robot duplicates of the Avengers. Malhotra eventually broke free of Starr’s influence and teamed up with Hank Pym—the original Giant-Man—to help destroy the robots. When Pym later seemingly died fighting Ultron, Malhotra was entrusted with the title of Giant-Man.",
                ],
                Personality =
                [
                    "Although still technically a novice adventurer, Malhotra has the confi dence and wit of a seasoned hero. He’s not the type to flinch in the heat of battle, even with a gun pointed at his head.",
                ]
            }
        },
        new()
        {
            Name = "Gorr the God Butcher",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 6, resilience: 8, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "All-Black the Necrosword [without All-Black, Gorr is powerless]"),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Gorr",
                Heights = [new() { IsUnknown = true }],
                Weights = [],
                UnknownWieght = true,
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Pale white skin covered in morphing black marks.",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien, OriginName.Symbiote],
                Teams = [],
                Base = "Black World of Gorr",
                History =
                [
                    "Born in a religious community on an inhospitable planet, Gorr’s life was marked by misfortune and starvation. As a child, he had to watch his parents die. As an adult, he formed his own family only to see them too be picked off one by one.",
                    "Gorr came to doubt the existence of the gods and was on the verge of giving up his faith altogether when a chance encounter with the dark god Knull imbued him with power of All-Black the Necrosword. Newly empowered, Gorr vowed to take revenge on the gods who had neglected him so.",
                ],
                Personality =
                [
                    "Gorr believes that the universe would be better off without gods, who all sat around in luxury while the people of his planet suffered. Why should they get to continue living while his own family had to die?",
                    "As powerful as he is vengeful, Gorr’s quest for the complete eradication of the gods has only ever been hampered by the thunder god Thor—and by his own self-doubt."
                ]
            }
        },
        new()
        {
            Name = "Green Goblin (Norman Osborn)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 4, vigilance: 2, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Spider-Man"),
                tagSelector.GetTag(TagNames.Headquarters),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pumpkin Bombs (frag grenades)"),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Norman Osborn",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Tycoon],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DarkAvengers, TeamNames.GoblinNation, TeamNames.SinisterSix, TeamNames.Thunderbolts],
                Base = "New York City",
                History =
                [
                    "From an early age, Norman Osborn had a relentless drive to succeed. Using notes stolen from his business partner, Osborn developed the Goblin formula to give himself superhuman powers. It also transformed Osborn into the Green Goblin— and set him on the road to insanity. He decided to use these powers to establish himself as the criminal leader of New York City. While doing so, he became enemies with Spider-Man (Peter Parker), who he later discovered to be his son Harry’s best friend. Although he seems to have died several times, Osborn keeps returning, apparently fated to be a constant thorn in Spider-Man’s side.",
                ],
                Personality =
                [
                    "Osborn is a smooth operator, a wealthy, powerful and sharp schemer who is often several steps ahead of his foes. He is often cool and collected— right up until something frustrates his plans, at which point he becomes unhinged.",
                ]
            }
        },
        new()
        {
            Name = "Groot",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 6, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mute, reminder: "Can only say “I am Groot.”"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BodySphere),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Groot",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Black",
                Hair = "Branches",
                Size = Size.Average,
                DistinguishingFeatures = "Plantlike alien",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Groot hails from Planet X and is an alien member of the Flora colossi race, a people who resemble trees and educate their young via photosynthesis. After rebelling against the way his people treated other intelligent species, Groot was banished from his homeworld, and he took to adventuring around the galaxy. There, he met his best friend, Rocket Raccoon, and along with him, joined the Guardians of the Galaxy led by Star-Lord (Peter Quill).",
                    "Groot has nearly been killed a number of times, but on each occasion, he managed to regrow himself from as little remaining of himself as a splinter. He seems dedicated to helping others, especially Rocket and their fellow teammates in the Guardians."
                ],
                Personality =
                [
                    "Groot is talkative and intelligent, but due to his stiff and inflexible larynx, it appears to others that he can only say “I am Groot.” In actuality, those with a trained ear can discern what Groot is saying in the subtle sigh and breeze under the words.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersH() =>
    [
        new()
        {
            Name = "Hand Ninja",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 0, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Snap Shooting"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SnapShooting),
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
                DistinguishingFeatures = "Bright red ninja outfits",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.TheHand],
                Base = "Japan",
                History =
                [
                    "The Hand is a cult composed entirely of dangerous ninja assassins, first formed in feudal Japan. Members of the Hand worship an elder god known only as the Beast. Manipulating the world from the shadows, they sow chaos wherever they roam.",
                    "For centuries, the Hand’s machinations have been opposed primarily by a rival ninja organization: the Chaste. Many of the world’s most famous ninja have at some point joined forces with either the Hand or the Chaste.",
                ],
                Personality =
                [
                    "Members of the Hand are fanatical and dedicated killers. Behind closed doors, the leaders of the Hand give loud and raving religious sermons, but your average Hand ninja is a professional— soft-spoken on the job and communicating only when absolutely necessary.",
                ]
            }
        },
        new()
        {
            Name = "Hawkeye (Clint Barton)",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 1, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AuditoryIssues),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bow and arrow"),
                tagSelector.GetTag(TagNames.Streetwise),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                    IsTech = true
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.Sniping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Clinton Francis “Clint” Barton",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.Thunderbolts],
                Base = "Brooklyn, New York City",
                History =
                [
                    "After his parents were killed in a tragic car accident, Clint Barton ran away to join the circus. Naturally talented, he quickly made a name as Hawkeye, one of the premier archers. Barton might have stayed a performer into his old age if a chance encounter hadn’t brought Iron Man to his circus. Inspired by Iron Man’s exploits, Barton created a costume and began fi ghting crime as Hawkeye.",
                    "While Barton sometimes operates solo, he’s best known for his work with the Avengers. After years of such adventures, Barton trained and mentored Kate Bishop into becoming a second Hawkeye.",
                ],
                Personality =
                [
                    "Clint Barton is well aware that his lack of super-powers places the upper limits of his abilities well below those of most super heroes. He sometimes puts on an arrogant attitude to cover his insecurities. Barton is sometimes led astray by his passions, but his conscience always brings him back to the fi ght for justice.",
                ]
            }
        },
        new()
        {
            Name = "Hela",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 4, resilience: 6, vigilance: 3, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped),
                tagSelector.GetTag(TagNames.Villainous),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.LeechLife),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimeTravel),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Hela",
                Heights = [new() { Feet = 7 }],
                Weights = [500],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Big,
                DistinguishingFeatures = "Covered by illusions, the left side of her body is dead",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.BlackOrder, TeamNames.GodsOfAsgard, TeamNames.HellLords],
                Base = "Hel",
                History =
                [
                    "The current incarnation of the Asgardian god of death was born under mysterious circumstances, half dead and half alive. Just as Thor must wield his hammer to operate at full power, Hela must wear her green cloak lest she return to her half-dead state.",
                    "As the god of death, Hela has had a tumultuous relationship with her fellow Asgardians. She can kill even a god with her touch, so other Asgardians tend to avoid her company. Despite this, she rarely attacks healthy Asgardians, preferring to swoop in and reap the souls of the injured and dying.",
                ],
                Personality =
                [
                    "Though not above the occasional bit of queenly mercy, Hela’s actions naturally trend toward destruction. While she’s usually content scheming up ways to capture the souls of her fellow Asgardians, Hela has been known to commit mass murder upon regular people, often with help from powerful villains like Thanos or Loki.",
                ]
            }
        },
        new()
        {
            Name = "Hellcat",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 2, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),

            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Patricia “Patsy” Walker",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.Defenders, TeamNames.PatsyWalkerTempAgency],
                Base = "Brooklyn, New York City",
                History =
                [
                    "When she was just a teenager, Patsy Walker’s mother created a comic-book series based on her daughter’s exploits. The series was a huge success, and by the time Walker was 18, she was already a household name.",
                    "Despite her history, Walker had a greater interest in super heroes than teenage drama. A chance encounter led her to discover the Beast’s secret identity, which she used to leverage his assistance in becoming a super hero. Donning a battle suit once worn by the Cat (Greer Nelson), Walker became Hellcat. Aided by her suit, Walker underwent extensive martial arts training and joined the Defenders. More recently she’s been partnering directly with Iron Man.",
                ],
                Personality =
                [
                    "A star from a young age, Walker is a lot more media savvy than most super heroes. Highly charismatic, she can befriend just about anyone. Hellcat’s love life has frequently been marked by misfortune, but she always manages to stay brave and cheerful no matter the circumstances.",
                ]
            }
        },
        new()
        {
            Name = "Hulk (Bruce Banner)",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 3, resilience: 9, vigilance: 4, ego: 2, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Gamma Forms"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Abomination"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Leader"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Anger),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
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
                RealName = "Robert Bruce Banner",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Big,
                DistinguishingFeatures = "Several distinct Hulk forms.",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD, TeamNames.USHulkOperations],
                Base = "Mobile",
                History =
                [
                    "Bruce Banner was just a mild-mannered nuclear physicist until the day he stepped out onto a bomb-testing range to save a young man (Rick Jones) who had wandered onto the site. Jones escaped unharmed, but the bomb blasted Banner with gamma rays. The radiation should have killed him, but instead, he gained the ability to transform into the Hulk—an unstoppable monster brought out by the scientist’s own rage.",
                    "Highly powerful and just as unstable, the Hulk has been involved in more major international incidents than just about any super-powered person in existence. Some people consider him a hero. Others consider him a threat worth waging war over."
                ],
                Personality =
                [
                    "Banner suffers from dissociative identity disorder. Depending on the circumstances, he can manifest any one of a half dozen separate personalities, each with their own corresponding Hulk transformation. Banner’s default personality is cool, collected and deeply empathetic. The rest are all over the map. Some are impressively cunning, while others are more like angry children.",
                ]
            }
        },
        new()
        {
            Name = "Human Torch (Johnny Storm)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 4, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "4 Yancy Street"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Jonathan Lowell Spencer “Johnny” Storm",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "As an ambitious young test pilot, Johnny Storm was invited aboard an experimental space mission led by his older sister Sue’s boyfriend, Reed Richards. Shortly after takeoff , Storm and the crew were bombarded by cosmic rays, granting them each fantastical abilities. Together, they formed the Fantastic Four and vowed to use their new powers for the good of all humanity.",
                    "As the Human Torch, Storm has control over the forces of heat and flame. He can spontaneously burst into flames, shoot fire from his hands, fly and even assume an ultra-hot nova form in times of great need."
                ],
                Personality =
                [
                    "While good at heart, Johnny Storm has always been a natural hothead. It doesn’t help that as the youngest member of the Fantastic Four, he has a hard time being taken seriously by his fellow adventurers. Part of that might arise from the fact that he delights in teasing and playing pranks on his older and grumpier teammate, the Thing.",
                ]
            }
        },
        new()
        {
            Name = "Hydra Agent",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
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
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Secret",
                History =
                [
                    "Hydra has reportedly been around in one form or another since the days of Ancient Egypt, and it’s evolved into one of the most dangerous criminal organizations on Earth. The latest incarnation sprang from the ruins of World War II-era Germany and Japan, and various factions of it have wavered back and forth between organized crime and fascist power.",
                    "Hydra recruits agents all around the world. In public, they know each other by secret signals and whispers of “Hail Hydra.” In secret, they don their green-and-yellow uniforms and chant the Hydra oath: “Hail, Hydra! Immortal Hydra! We shall never be destroyed! Cut off one head, two more shall take its place! We serve none but the Master—as the world shall soon serve us! Hail Hydra!”",
                ],
                Personality =
                [
                    "Agents join Hydra for a number of reasons that usually boil down to money and power. They believe that Hydra can take over any organization or government, and they want to be on the winning side, no matter what they have to do to manage it. The Hydra uniform makes them mostly anonymous, fi tting well with their oath to replace one fallen agent with two more just like them.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersI() =>
    [
        new()
        {
            Name = "Iceman",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 3, vigilance: 5, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlIce,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.ElementalSuffocation),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Robert “Bobby” Drake",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [145],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.ChampionsOfLosAngeles, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "From a young age, Bobby Drake was able to manifest and control ice. He managed to keep this ability secret until the day he accidentally froze his school bully. Outraged, the people of Drake’s hometown organized a mob to hang the young mutant. He was saved only by the sudden intervention of psychic Charles Xavier (Professor X), who erased the mob’s memories.",
                    "Xavier offered to recruit Drake into a mutant super-group he was forming called the X-Men. Drake graciously accepted and became one of the team’s founding members under the codename Iceman. Years have passed, but Iceman has rarely strayed far from the X-Men or the heroes he founded it with."
                ],
                Personality =
                [
                    "Drake has always been the jokester of the X-Men, almost compulsively trying to be liked by everyone. Closeted for decades, he recently came out as gay and has found new happiness exploring this side of his life.",
                ]
            }
        },
        new()
        {
            Name = "Ikaris",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 5, vigilance: 4, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MahdWyry),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.Eternals],
                Base = "Olympia",
                History =
                [
                    "A million years ago, mysterious cosmic beings known only as the Celestials visited Earth. They experimented on the proto-humans, transforming them into grotesque and powerful monsters known as Deviants. In order to curb this Deviant threat, the Celestials also created the Eternals, a race of immortal heroes tasked with protecting the planet.",
                    "Since the beginning, Ikaris has been a leader among the Eternals. He has served on the front lines of every major conflict against the Deviants. He has personally defended the planet from some of the most powerful villains in existence, chief among them Thanos—a mad conqueror set on exterminating life throughout the universe."
                ],
                Personality =
                [
                    "The Eternals are typically withdrawn and private people, slow to interfere with human affairs. Among them, Ikaris is known for being unusually personable. He has had human friends and even lovers. His codename serves as a tribute to his long deceased half-human son, Ikaris.",
                ]
            }
        },
        new()
        {
            Name = "Invisible Woman",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 5, ego: 6, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "4 Yancy Street"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlForce,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendInvisibility),
                        powerSelector.GetPower(PowerNames.GroupInvisibility),
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.Invisibility),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Susan “Sue” Storm Richards",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "As a young college student, Sue Storm fell in love with doctoral student Reed Richards, who later invited her to join him on an experimental space mission. During the mission, Richards, Storm and the rest of the crew were bombarded by cosmic rays, granting them super-powers. Sue gained the ability to turn invisible and summon invisible force-fields. Along with the rest of the newly empowered crew, she vowed to use her powers for the good of humanity, forming the Fantastic Four.",
                    "Storm and Richards eventually married and now have two children of their own that they bring along on many of their adventures."
                ],
                Personality =
                [
                    "Coolheaded and compassionate, the Invisible Woman helps to balance out the more hotheaded and intense members of the Fantastic Four. However, she only lets the others push her so far before she emphasizes clear boundaries.",
                ]
            }
        },
        new()
        {
            Name = "Iron Fist (Danny Rand)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 2, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Focused Strike"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.FocusedStrike),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Daniel Thomas “Danny” Rand",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Dragon insignia on chest.",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic, OriginName.SpecialTraining],
                Teams = [TeamNames.Defenders],
                Base = "New York City",
                History =
                [
                    "After his parents were murdered on an expedition to the Himalayas, Danny Rand inadvertently stumbled through a portal to the mystical city of K’un-Lun. The people of K’un-Lun adopted Danny and gave him extensive tutelage in the martial arts.",
                    "After ten years of grueling training, Danny’s mentor sent him on a mission to defeat the evil serpent Shou-Lao. Narrowly beating the beast, Danny took hold of its molten heart, infusing his hands and body with mystical chi energies and assuming the title of Iron Fist. He left K’un-Lun, vowing to take vengeance upon the man who killed his parents and upon evildoers everywhere."
                ],
                Personality =
                [
                    "Danny Rand is a serious fi ghter prone to acting like a lone wolf. He is devoted to martial arts and despises nothing more than people who put such skills to evil uses. Years of living in NYC have tempered Danny’s demeanor. He’s allowed himself to develop a small group of friends and allies—including his best friend, Luke Cage— though he often still prefers to work alone.",
                ]
            }
        },
        new()
        {
            Name = "Iron Man (Tony Stark)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 3, ego: 5, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Mandarin"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.Headquarters),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese (Mandarin), English, French, Japanese, Russian, Korean, Urdu"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection, isTech: true),
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Anthony “Tony” Stark",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black, short",
                Size = Size.Average,
                DistinguishingFeatures = "Van Dyke beard",
                Occupations = [OccupationName.Engineer, OccupationName.Tycoon],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.Avengers, TeamNames.GuardiansOfTheGalaxy, TeamNames.SHIELD],
                Base = "New York City",
                History =
                [
                    "Tony Stark is the adopted son of Maria Stark and weapons manufacturer Howard Stark, founder of Stark Enterprises. He inherited the business when his parents were killed in a car crash, and he transformed it into a global conglomerate worth billions. During an overseas weapons demonstration, a terrorist attack caused an explosion that lodged shrapnel near Stark’s heart. After being captured by the terrorists, instead of producing a weapon for them, he built a suit of powered armor in which he escaped.",
                    "After returning home, Stark improved his armor and pretended that Iron Man was his personal bodyguard. He decided to use his powers and his amazing fortune for good by co-founding and then funding the Avengers."
                ],
                Personality =
                [
                    "Stark is one of the smartest, wealthiest and most famous people on Earth, something that can make him both arrogant and sarcastic. He’s all too aware of his shortcomings and tries to temper his sharp tongue, especially around his longtime friends, to whom he is extremely loyal.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersJ() =>
    [
        new()
        {
            Name = "Jessica Jones",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Harlem Apartment"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
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
                }
            ],
            Biography = new Biography
            {
                RealName = "Jessica Campbell Jones",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [124],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Investigator],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Defenders],
                Base = "New York City",
                History =
                [
                    "Jessica Campbell’s entire family was killed when their car hit a truck carrying dangerous radioactive chemicals. Jessica survived, but the chemicals gave her super-powers. Adopted by a new family, she changed her last name to Jones and began fighting crime as the costumed hero Jewel, but after being captured and mind-controlled by the Purple Man for months, she hung up her mask.",
                    "Jones later opened up Alias Investigations, a forprofit P.I. firm, using her powers to help people— but without a costume. She has since married her love Luke Cage, with whom she has a little girl, Danielle."
                ],
                Personality =
                [
                    "Jones’ hard life has made her more than a little world-weary, but despite her travails she remains a strongly caring person. She may work for profit, but still she strives to deliver the best possible outcomes for her clients, going out of her way to ensure that they get the justice they pay for.",
                ]
            }
        },
        new()
        {
            Name = "Juggernaut",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 7, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "Sturdy 4"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Crimson Gem of Cyttorak [Any attack which deals less than 30 points of damage to the user of the Crimson Gem is instantly negated.]"),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Cain Marko",
                Heights = [new() { Feet = 6, Inches = 10 }],
                Weights = [900],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Big,
                DistinguishingFeatures = "Unnatural strength and bulk as result of powers",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "While not a mutant himself, Cain Marko’s fate was permanently bound to that of mutant society the day that Charles Xavier—the future Professor X—became his stepbrother. As boys, they had a rocky relationship, with Marko resenting Xavier’s obvious brilliance.",
                    "While serving as a U.S. soldier, Marko stumbled upon the Crimson Gem of Cyttorak, a mystical artifact that infused his body with superhuman strength and size. Seeing a chance to get the better of his stepbrother, Marko became the new Juggernaut and used his power for super-villainy."
                ],
                Personality =
                [
                    "Marko and Xavier have slowly managed to repair their relationship, and in recent years, the Juggernaut has been more often a force for good than evil. Although a bit dense by nature, Marko has shown surprising moments of intelligence and humility. The main thing that still manages to set him off is Xavier, who struggles to fully trust him.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersK() =>
    [
        new()
        {
            Name = "Kate Pryde",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Magical Attacks"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, Japanese, Russian, Shi’ar, Skrullos"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DisruptElectronics),
                        powerSelector.GetPower(PowerNames.DisruptNerves),
                        powerSelector.GetPower(PowerNames.DisruptPerson),
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseObject),
                        powerSelector.GetPower(PowerNames.PhaseOther),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                        powerSelector.GetPower(PowerNames.PhaseWalk),
                        powerSelector.GetPower(PowerNames.QuickPhase),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Katherine Anne “Kate” Pryde",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Knuckle tattoos",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.HellfireTradingCompany, TeamNames.Marauders, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "When she was 13, Kate Pryde discovered that her recurring migraines were in fact a byproduct of her developing mutant powers. With intense concentration, she found she could phase through solid matter. She was quickly whisked away to Professor Xavier’s School for Gifted Youngsters, and she’s been an important member of the X-Men ever since.",
                    "For mysterious reasons, Pryde has been cut off from many of the powers provided by the mutant homeland in Krakoa. Regardless of this setback, she remains a critical member of the Krakoan government and the leader of the Marauders."
                ],
                Personality =
                [
                    "Pryde numbers among the most charming and friendly people, let alone mutants, on the planet. She has an uncanny knack for connecting with others, even those as gruff as Wolverine (Logan).",
                ]
            }
        },
        new()
        {
            Name = "Killmonger",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 3, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                        powerSelector.GetPower(PowerNames.RallyOnMe),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Erik Killmonger",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.HighTech, OriginName.Magic],
                Teams = [],
                Base = "Niganda",
                History =
                [
                    "Born in a small Wakandan village, the boy who would become Erik Killmonger saw his entire family slaughtered at the hands of slavers. Killmonger himself was kidnapped and taken to the United States, where he vowed to avenge the deaths of his family and ensure that nothing like what happened to him could ever happen to anyone in the world again.",
                    "It wasn’t long before Killmonger managed to kill his captors and return to Wakanda, where he set his sights on the Black Panther (T’Challa). Killmonger’s sole wish is to destroy T’Challa and take control of Wakanda for himself.",
                ],
                Personality =
                [
                    "Highly determined and charismatic, Erik Killmonger makes an extremely effective battlefield leader. It’s his ruthless, murderous methods that steer him down the wrong path.",
                ]
            }
        },
        new()
        {
            Name = "Kingpin (Wilson Fisk)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 1, resilience: 3, vigilance: 2, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Leverage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.SpinAndThrow),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wilson Fisk",
                Heights = [new() { Feet = 6, Inches = 7 }],
                Weights = [450],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Bald",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.FiskIndustries, TeamNames.PowerElite],
                Base = "New York City",
                History =
                [
                    "Born and raised in New York City, Wilson Fisk started on his path to become the Kingpin of Crime at an early age. He developed a skill for uncovering secrets and using them as leverage, while at the same time, he dedicated himself to becoming an astonishing bodybuilder with the strength (and shape) of the most powerful sumo wrestlers.",
                    "As Fisk’s criminal organization spread throughout New York City, he butted heads several times with both Spider-Man and Daredevil. The only thing that seemed to soften him was his love for his wife, Vanessa, and their son, Richard, both of whom were killed. He has since remarried, this time to Typhoid Mary.",
                    "Fisk recently became the mayor of New York City after helping save the city during an alien invasion. He has since divested himself of his criminal enterprises—but not his crooked ways."
                ],
                Personality =
                [
                    "Fisk can be charming and savvy, but he is also a schemer who is usually in control of most things around him. He’s used to being the boss and having his people leap to obey him. When his plans are thwarted though, he can become murderously violent.",
                ]
            }
        },
        new()
        {
            Name = "Kraven the Hunter",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 2, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Sergei Nikolaevich Kravinoff",
                Heights = [new() { Feet = 6 }],
                Weights = [235],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.SinisterSix],
                Base = "Savage Landy",
                History =
                [
                    "Born into a family of disgraced Russian nobles, Sergei Kravinoff was raised to believe that he was inherently better than the common man and that he needed to prove it. He spent years traveling across Africa, making a name for himself as an amazing big-game hunter. On his travels, he discovered an enchanted potion that granted him superhuman strength and vitality.",
                    "Armed with the power to defeat lions with his bare hands, Kravinoff adopted the title of Kraven the Hunter and began hunting super heroes instead, often with disappointing results. He once took his own life after defeating Spider-Man (Peter Parker), but his adult children later resurrected him.",
                ],
                Personality =
                [
                    "Kraven is arrogant and bombastic, but he is also determined to prove himself to be the greatest hunter who ever lived. He allows nothing— including his family—to stand between himself and that goal.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersL() =>
    [
        new()
        {
            Name = "Leader",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 3, vigilance: 4, ego: 4, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Samuel “Sam” Sterns",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [144],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Enlarged cranium, green skin",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Intelligencia, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "Samuel Sterns was once nothing more than a mild-mannered factory worker tasked with transporting canisters of nuclear waste. One day, during a routine disposal, a canister broke open and showered him in gamma radiation. The radiation mutated Sterns’ body, turning his skin green and enlarging his skull. Finding that he now had superhuman intelligence and psionic abilities, Sterns adopted the title of the Leader and set himself to the task of conquering the world.",
                    "Sterns’ evil plans have been thwarted again and again by the intervention of fellow gamma mutate the Hulk (Bruce Banner). He has become obsessed with defeating the Hulk, who he sees as the biggest obstacle on his path toward world domination.",
                ],
                Personality =
                [
                    "A megalomaniacal narcissist, the Leader believes that his brilliant intellect grants him the right to rule the world. It infuriates him that a being as dim-witted as the Hulk could possibly foil his schemes.",
                ]
            }
        },
        new()
        {
            Name = "Loki",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 4, ego: 8, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Loki Laufeyson",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.DarkCouncil, TeamNames.GodsOfAsgard],
                Base = "Asgard",
                History =
                [
                    "Although born to a family of Frost Giants, Loki Laufeyson was rescued from a battlefi eld and adopted by Odin, the king of Asgard, who treated Loki as one of his own and raised him alongside his other son Thor. As the crafty god of mischief, Loki’s schemes have served as the inciting incident for many incredible adventures, including the formation of the original Avengers. He has been thought defeated many times, but he never fails to return, often even more cunning than ever.",
                    "Loki often plays the villain, but he’s served as a hero many times as well. His focus as a god has morphed many times too, including things like mischief, lies and stories.",
                ],
                Personality =
                [
                    "Feeling like an outsider to the Asgardian community, Loki harbors some resentment toward his brother, Thor, for his effortless ability to fit in. However, he’s willing to set everything aside in the name of a good prank. He delights in mischief above all else.",
                ]
            }
        },
        new()
        {
            Name = "Luke Cage",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 5, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.Sturdy3}"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Harlem Apartment"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lucas “Luke” Cage; formerly Carl Lucas",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [425],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Leader],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Defenders, TeamNames.HeroesForHire, TeamNames.MightyAvengers],
                Base = "New York City",
                History =
                [
                    "Imprisoned for a crime he didn’t commit, Carl Lucas was recruited by the prison’s doctor as a test subject for an experimental variant of the Super-Soldier Serum that empowered Captain America (Steve Rogers). Imbued with superhuman strength and durability, Lucas broke free of his prison and returned to the Harlem of his youth.",
                    "As a fugitive, Lucas adopted the name Luke Cage and began working as a Hero for Hire. Cage has been through a lot in the years since, sometimes teaming up with internationally recognized super-groups and sometimes returning to for-hire work, but he’s never stopped being a tireless fi ghter for the people of Harlem."
                ],
                Personality =
                [
                    "Cage is as sensitive and caring as he is tough and strong. Circumstances may force him into work as a paid hero, but he often helps those in need for free. Nothing is more important to him than his friends and family, including his wife, Jessica Jones, and their daughter, Danielle.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersM() =>
    [
        new()
        {
            Name = "Magneto",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 6, ego: 9, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Arabic, English, French, German, Hebrew, Polish, Russian, Ukrainian, Yiddish"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny4, isTech: true),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlIron,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalProtection4),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.ElementalSuffocation),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Max Eisenhardt",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Auschwitz I.D. #24005 tattoo on arm",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Max Eisenhardt, going by the name Erik Lensherr, first met Charles Xavier (who would become Professor X) while working at a psychiatric hospital for Holocaust survivors, where they recognized each other’s mutant powers and had heated debates about mutant integration into normal society. As a Holocaust survivor himself, Eisenhardt struggled to accept that humanity would ever accept mutants.",
                    "Eisenhardt later became the villain Magneto and formed the Brotherhood of Evil Mutants in direct opposition to Xavier’s own X-Men. Eventually, Magneto put aside such methods and even led the X-Men himself for a while. He has long worked to establish a homeland for mutants, and with Krakoa, he feels that he and Charles may finally have succeeded."
                ],
                Personality =
                [
                    "Magneto has a strong sense of right and wrong. Periods of mental instability throughout his life have sometimes made him into a zealot willing to harm innocents in the pursuit of his dreams, but his righteous intentions have never wavered.",
                ]
            }
        },
        new()
        {
            Name = "Magnitron",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 4, vigilance: 3, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.BreatheDifferent),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Kree Empire)"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Yon-Rogg",
                Heights = [new() { Feet = 6 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military, OccupationName.Outsider],
                Origins = [OriginName.AlienKree],
                Teams = [TeamNames.ImperialKreeAmy],
                Base = "Hala",
                History =
                [
                    "As a young adult, Yon-Rogg enlisted in the Kree Imperial Army, where he befriended a man named Mar-Vell. At first, their friendship was solid, but as time wore on, Yon-Rogg became increasingly jealous of the admiration showered upon Mar-Vell by the other Kree, so he stabbed Mar-Vell in the back and abandoned him on Earth.",
                    "Tasked with expanding the Kree Empire, Yon- Rogg attempted to invade Earth time and time again, only to be defeated each time by Captain Marvel (Mar-Vell), who survived his treachery. Mar-Vell died years ago, but Yon-Rogg continues to hunt those who associated with him, including the current Captain Marvel (Carol Danvers). In more recent years, he gained new powers and assumed the codename Magnitron."
                ],
                Personality =
                [
                    "Yon-Rogg is normally a serious and competent soldier, but his hatred for Mar-Vell and the man’s legacy often drives him to irrational ends.",
                ]
            }
        },
        new()
        {
            Name = "Malekith",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 4, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Iron"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Mist"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Malekith",
                Heights = [new() { Feet = 6, Inches = 9 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "Dark blue skin on right side of body, black on left",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Mythic],
                Teams = [TeamNames.DarkCouncil, TeamNames.DarkElves],
                Base = "Niffleheim",
                History =
                [
                    "Malekith was born in Svartalheim—the Asgardian realm of the dark elves—during a tumultuous period of war and suffering. He saw his whole family die in the fi ghting, only for his mother— his one remaining relative—to sell him off for a few sacks of food.",
                    "While in captivity, Malekith made the acquaintance of a wizard who taught him powerful spells. Together they plotted ways to escape their prison and bring an end to the war. Unfortunately, Malekith had already gone mad. At the last second he betrayed his magical compatriot. With his dying breath, the wizard used his remaining magic to permanently mar Malekith, turning half of his body pitch-black.",
                ],
                Personality =
                [
                    "War has been the defining feature of Malekith’s life, and he is in love with the chaos. While he is far more sadistic than Loki, Malekith frequently finds an ally in the god of mischief in his plots against Asgard itself.",
                ]
            }
        },
        new()
        {
            Name = "Mandarin",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 5, ego: 7, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Mandarin City"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline3),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [215],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.TheHand, TeamNames.Triads],
                Base = "Mandarin City",
                History =
                [
                    "Born into a poor English family in the Chinese countryside, the future Mandarin was forced to flee his childhood home by the rising communist revolution. Wandering about, he stumbled upon the wreck of an alien spacecraft, inside of which he found ten magic rings that granted him unstoppable mystical powers. Enthralled by his new powers, the young man claimed the title of the Mandarin and began building himself into the greatest arms smuggler on the planet.",
                    "The Mandarin’s arms dealing frequently brings him into confl ict with Tony Stark (Iron Man), a reformed arms manufacturer himself. The Mandarin generally prefers to work against Stark through proxies, but he is plenty capable of holding his own against Iron Man when drawn out.",
                ],
                Personality =
                [
                    "Highly unstable and egotistical, the Mandarin has been racked by delusions of glory throughout his entire life. A conqueror at heart, he would see war and chaos spread across the globe.",
                ]
            }
        },
        new()
        {
            Name = "Maximus",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 3, ego: 3, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new PowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new PowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Maximus Boltagon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.KreeImperium, TeamNames.LeagueOfEvilInhumans],
                Base = "New Arctilan",
                History =
                [
                    "A powerful psychic, Maximus was born the second son of the Inhuman royal family, preceded in the line of succession only by his brother, the hero Black Bolt. From a young age, Maximus came to resent his brother, repeatedly attempting to get the young Black Bolt into trouble, but it was only after Black Bolt ascended to the throne that Maximus went truly mad.",
                    "Determined to kill his brother and ascend to the position of Inhuman King, Maximus has launched coup attempt after coup attempt against Black Bolt. In recent years, Maximus has shown the ability to work with his fellow Inhumans, but his motivations are always suspect and can change at any moment.",
                ],
                Personality =
                [
                    "Maximus’ strongest desire has always been to take over as ruler of the Inhumans and make his brother suffer. How much of this is motivated by madness and how much by self-interest is hard to discern.",
                ]
            }
        },
    ];
}
