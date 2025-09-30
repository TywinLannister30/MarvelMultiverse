using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

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

    private List<Character> GetAllCharacters() =>
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
                traitSelector.GetTrait(TraitNames.Big),
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
                Occupations = ["Spy"],
                Origins = ["Weird Science: Gamma Mutate"],
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
                Occupations = ["Educator"],
                Origins = ["Magic: Sorcery"],
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
                Occupations = ["Law Enforcer"],
                Origins = ["Special Training"],
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
                Occupations = ["Adventurer", "Student"],
                Origins = ["Weird Science"],
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
                Occupations = ["Scientist"],
                Origins = ["High Tech"],
                Teams = [TeamNames.AIM],
                Base = "A.I.M. Island",
                History =
                [
                    "Founded during World War II, Advanced Idea Mechanics (aka A.I.M.) was created by regular Nick Fury nemesis and Hydra leader Baron Von Strucker. A.I.M. was initially intended to be nothing more than a scientific wing for Hydra, but the organization could not long be kept under Hydra control.",
                    "A.I.M. agents are highly intelligent scientific terrorists who desire nothing more than complete world domination. In pursuit of this goal, A.I.M. has aligned itself with countless super villains. As an organization, they are responsible \r\nfor the creation of many of the most dangerous weapons in existence, including the Cosmic Cube and M.O.D.O.K",
                ],
                Personality =
                [
                    "A.I.M. scientists are typically power-hungry outsiders to the scientific community—intelligent people furious that the world does not revere their brilliance. They seek to take revenge on a \r\nsociety that refuses to treat them as kings",
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
                Occupations = ["Scientist"],
                Origins = ["High Tech"],
                Teams = [TeamNames.AIM],
                Base = "A.I.M. Island",
                History =
                [
                    "Founded during World War II, Advanced Idea Mechanics (aka A.I.M.) was created by regular Nick Fury nemesis and Hydra leader Baron Von Strucker. A.I.M. was initially intended to be nothing more than a scientific wing for Hydra, but the organization could not long be kept under Hydra control.",
                    "A.I.M. agents are highly intelligent scientific terrorists who desire nothing more than complete world domination. In pursuit of this goal, A.I.M. has aligned itself with countless super villains. As an organization, they are responsible \r\nfor the creation of many of the most dangerous weapons in existence, including the Cosmic Cube and M.O.D.O.K",
                ],
                Personality =
                [
                    "A.I.M. scientists are typically power-hungry outsiders to the scientific community—intelligent people furious that the world does not revere their brilliance. They seek to take revenge on a \r\nsociety that refuses to treat them as kings",
                ]
            }
        },
    ];
}
