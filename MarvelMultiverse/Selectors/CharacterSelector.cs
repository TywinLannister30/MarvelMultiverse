using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
    ];
}
