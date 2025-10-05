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
        allCharacters.AddRange(GetAllCharactersN());
        allCharacters.AddRange(GetAllCharactersO());
        allCharacters.AddRange(GetAllCharactersP());
        allCharacters.AddRange(GetAllCharactersQ());
        allCharacters.AddRange(GetAllCharactersR());
        allCharacters.AddRange(GetAllCharactersS());
        allCharacters.AddRange(GetAllCharactersT());
        allCharacters.AddRange(GetAllCharactersU());
        allCharacters.AddRange(GetAllCharactersV());
        allCharacters.AddRange(GetAllCharactersW());
        return allCharacters;
    }
    private List<Character> GetAllCharactersA() =>
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
                Base = "NYC",
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline3),
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
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Beta Ray Bill",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 3, resilience: 8, vigilance: 2, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage, reminder: "via Twilight Sword"),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "regular Korbinite form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped, reminder: "as Thor"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline2),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Twilight Sword [Adds elemental fire effect to melee attacks.]"),

                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty4, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Beta Ray Bill",
                Heights = [new() { Feet = 6, Inches = 7 }],
                Weights = [480],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Bright orange skin, horse-like head",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.Alien, OriginName.HighTechCybernetics, OriginName.MythicAsgardian],
                Teams = [TeamNames.Annihilators, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Years ago, the demonic Surtur of Muspelheim unleashed his minions upon the planet of Korbin. Korbinite civilization was annihilated, and the few who survived fled across the cosmos.",
                    "Korbinite scientists performed torturous experiments upon their own people, hoping to create a champion capable of fi ghting the demons. Only one subject named Bill survived the transformation, but even his newfound powers were not enough to hold back the demons.",
                    "All hope was lost until a chance encounter with Thor Odinson led Bill into an alliance with Asgard. Impressed by Bill’s strength, Odin himself granted the Korbinite a hammer with a set of powers to match Thor’s own. Together, Bill and Thor pushed the demons back into Muspelheim.",
                    "Much later, Bill invaded Muspelheim and defeated Surtur once and for all. He abandoned Odin’s gifts and claimed Surtur’s Twilight Sword as his own. Although he is still revered in Asgard, Bill now focuses most of his energies on caring for his people."
                ],
                Personality =
                [
                    "Beta Ray Bill’s noble and serious demeanor matches well with those of the gods of Asgard. The Asgardians accept him as one of their own—more so than his fellow Korbinites, who are largely frightened by his monstrous form. Bill can use his sword to disguise himself as a regular Korbinite, and he tends to stay in this disguise when among his own.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                Teams = [TeamNames.HouseOfAgon, TeamNames.UniversalInhumans],
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
            Name = "Black Knights / Fenris Twins",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 2, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight1, reminder: "adjacent"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast, reminder: "adjacent"),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "adjacent"),
                        powerSelector.GetPower(PowerNames.ElementalPush, reminder: "adjacent"),
                        powerSelector.GetPower(PowerNames.ElementalRicochet, reminder: "adjacent"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            PowerNotes =
            [
                "The Fenris Twins are two mechanically identical characters. They can move separately, but several of their abilities work only when the twins are close enough to touch. These powers bear the label “(adjacent).”"
            ],
            Biography = new Biography
            {
                RealName = "Andrea and Andreas von Strucker",
                Heights = [new() { Feet = 5, Inches = 9 }],
                HeightReminder = "both",
                Weights = [],
                WeightReminder = "110 lbs. (Andrea), 165 lbs. (Andreas)",
                Gender = Gender.Varies,
                GenderReminder = "Female (Andrea), Male (Andreas)",
                Eyes = "Blue (both)",
                Hair = "Blond (both)",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Mutant, OriginName.WeirdScience],
                Teams = [TeamNames.HellfireTradingCompany, TeamNames.Hydra],
                Base = "Krakoa",
                History =
                [
                    "Decades ago, fascist leader Baron von Strucker forced his pregnant wife to undergo experimental treatments developed by the brilliant but evil Dr. Arnim Zola. The genomes of the twin embryos were modifi ed to include a number of unusual genes, including the X-Gene of mutant fame.",
                    "Andrea and Andreas von Strucker displayed few symptoms of this meddling at birth, but as young adults their powers began to emerge. The twins could fl y, perform incredible feats of acrobatics, and shoot blasts of energy from their fi sts—but only while in direct contact with each other.",
                    "Under the codename Fenris, the twins went into business for themselves as super-powered mercenaries. They have spent most of their adult lives menacing the rest of mutantkind, attacking super heroes for profi t and pleasure.",
                    "Although the Fenris Twins were granted permission to live on Krakoa—despite the artifi cial nature of their mutant status—most other mutants do not regard them with respect. As the Black Knights of the Hellfi re Club, they act as personal bodyguards for the villainous Sebastian Shaw."
                ],
                Personality =
                [
                    "The Fenris Twins are almost comically spoiled. They grew up in the lap of luxury, their every whim attended to by a squadron of servants. From a young age, they were taught to understand that they were better than other people and to violently oppose any who gainsaid that idea.",
                    "Like their father, both of the Fenris Twins are committed fascists and white supremacists. However, their fi rst and greatest loyalty is to money. They do terrible things not out of a commitment to an ideology but out of a desire to maintain their opulent lifestyle."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Blindspot (Sam Chung)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Daredevil (Matt Murdock)"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Steel pole (club)"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Invisibility),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Samuel “Sam” Chung",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Black eyes with glowing blue irises",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.TheHand],
                Base = "NYC",
                History =
                [
                    "When Sam Chung was just a boy, he and his family emigrated from China to the United States. With a prodigious mind and a strong admiration for the super heroes of New York City, Chung spent much of his childhood working on designs for an invisibility suit.",
                    "As soon as he was able, Chung built his suit and began to fight crime on the streets of New York’s Chinatown under the codename Blindspot. Later, the super villain Muse tore out his eyes. They were eventually replaced with mystic counterparts, but his new glowing eyes have made maintaining his secret identity difficult.",
                ],
                Personality =
                [
                    "Chung is a bit of a loner and a cynic. His mentor, Daredevil, is one of the few people on Earth he genuinely admires.",
                    "As an undocumented immigrant, Chung displays trepidation around law-enforcement o¸ cers."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Bulldozer (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 3, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Ram"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DefenseStance),
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
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Henry Camp",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [325],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Abandoned on a trash heap when he was just 2 days old, Henry Camp grew up in an orphanage. Following a dishonorable discharge from the U.S. Army, he turned to a life of crime. After being picked up on burglary charges multiple times, he was sentenced to an extended stay on Ryker’s Island.",
                    "In prison, Camp met Dirk Garthwaite, A.K.A. the villainous Wrecker. Along with a couple of other inmates, Camp helped Garthwaite escape from Ryker’s. In exchange, Garthwaite granted Camp and his compatriots a portion of his own super-powers. Together, they formed the super-villain group known as the Wrecking Crew, and they’ve been in each other’s orbits ever since.",
                    "At times when Henry Camp is not available, his daughter, Marci Camp, takes his place in the Wrecking Crew as the new Bulldozer."
                ],
                Personality =
                [
                    "Henry Camp’s outwardly cool and tough demeanor conceals an inner bitterness. He harbors a burning resentment toward the government, society and the world at large, stemming from how they all failed him his entire life. It is this resentment that drives him forward in his criminal activities.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Captain America (Sam Wilson)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 3, vigilance: 3, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Captain America’s shield [+1 damage multiplier. Grants the user one extra level of the power Shield (up to Shield 4).]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.HurledShieldBlock),
                        powerSelector.GetPower(PowerNames.HurledShieldDeflection),
                        powerSelector.GetPower(PowerNames.RicoShield),
                        powerSelector.GetPower(PowerNames.Shield3),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Redwing"),
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "birds"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Samuel Thomas “Sam” Wilson",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [240],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD],
                Base = "NYC",
                History =
                [
                    "Sam Wilson grew up as an orphan in Harlem. As an adult, he was determined to give back to the community that raised him. He was helping out as a social worker when a fateful encounter with the Red Skull and a Cosmic Cube granted him super-strength and the ability to communicate with birds.",
                    "Shortly thereafter, Wilson ran into Steve Rogers— the original Captain America. Wilson and Rogers became fast friends, and together, they defeated the Red Skull. Subsequently, Rogers and Wilson became crimefi ghting partners: Captain America and the Falcon.",
                    "Wilson gradually developed a prowess in battle to rival Rogers’ own. At times when Rogers has been unwilling or unable to take up the mantle of Captain America, Wilson has taken his place. Nowadays, both Wilson and Rogers go by the codename of Captain America."
                ],
                Personality =
                [
                    "Even more so than Rogers, Wilson’s defi ning trait is his love for the downtrodden. His one goal in life is to use his powers for the protection of the weak and the oppressed.",
                    "Although Wilson is generally a serious man, he has a soft spot for those closest to him, particularly his avian companion Redwing."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Captain Avalon (Brian Braddock)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 3, resilience: 6, vigilance: 4, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
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
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitTheDirt),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Brian Braddock",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [257],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.Excalibur, TeamNames.SHIELD],
                Base = "Krakoa",
                History =
                [
                    "Brian Braddock was once just a promising young physicist working out of an obscure facility in England. Then came the day the villainous mercenary Reaver attacked his workplace and slaughtered all of his co-workers. Braddock himself was on the verge of death when the specter of the wizard Merlin suddenly appeared before him.",
                    "Merlin offered Braddock one of two powerful gifts: a sword or an amulet. Out of a desire not to harm others, Braddock chose the amulet.",
                    "Instantly fi lled with power, he transformed into Captain Britain. As the one true defender of the British Isles, Braddock spent years defending both the United Kingdom and the mystical Otherworld of Arthurian legend, from which he drew his incredible powers.",
                    "Eventually, he learned of other ways to draw power from the Otherworld and granted possession of his amulet to his sister, Betsy Braddock. Today, Betsy fi ghts under the title of Captain Britain, while Brian acts as Captain Avalon.",
                    "When he’s not adventuring, Brian spends most of his time at home with his wife—Meggan Puceanu (codename Gloriana)— and their daughter Maggie."
                ],
                Personality =
                [
                    "Although he holds a doctorate in physics, Braddock is hardly a stuffy old professor. His friends know him as a kind and caring father with a good sense of humor. His enemies know him as a fearsome and determined opponent.",
                    "Braddock’s natural confi dence and charisma serve as the source of his mystic powers, which can be channeled only by those who believe in themselves. When he is feeling self-assured, Captain Avalon is nearly impossible to defeat."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Claire Dixon",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 3, agility: 0, resilience: 1, vigilance: 1, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Heroic),
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
                RealName = "Claire Dixon",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [133],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.WeirdScience], 
                Teams = [TeamNames.FBI],
                Base = "Mobile",
                History =
                [
                    "Claire Dixon was the head of the F.B.I.’s Anti-Symbiote Task Force, until the day she was forcibly bonded to a symbiote of her own. Under the infl uence of the dark creature, she wrought chaos against her former allies. As the super villain Raze, she slaughtered members of her own unit. Eventually, Venom himself intervened to separate her from the alien slime.",
                    "Following the separation, Claire discovered that she had retained a portion of the symbiote’s power. Vowing to make up for the evils she committed as Raze, Claire took a leave of absence from the F.B.I. and set out to become a super hero.",
                ],
                Personality =
                [
                    "Claire takes her job as a government agent very seriously, and she has a strong sense of justice. Although she used to harbor an almost fanatical hatred of all things alien, her interactions with Venom have led her to soften her stance on symbiotes.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Flight2),
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
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
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
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Cloak",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 2, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, specialization: PowerNames.TeleportOther),
                traitSelector.GetTrait(TraitNames.Weird),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "The Cloak (Can imprison grabbed opponents in the Darkforce dimension, during which time Cloak automatically makes a free Ego attack against them on his turn each round. To escape, imprisoned creatures must succeed on an Ego check against Cloak’s Ego defense.)"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                        powerSelector.GetPower(PowerNames.QuickPhase),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportOther),
                        powerSelector.GetPower(PowerNames.TeleportTogether),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Tyrone Johnson",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [155],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant, OriginName.WeirdScience],
                Teams = [TeamNames.SavageAvengers, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Tyrone Johnson grew up in a poor neighborhood in south Boston where, despite a signifi cant stutter, he excelled in school. As a well-respected member of his community, he had no intention of leaving his hometown—until the day he watched his best friend get gunned down in the street by a trigger-happy cop.",
                    "Terrifi ed and racked with guilt over his inability to prevent his friend’s death, Johnson fl ed for New York. At a bus station in Manhattan, he and fellow runaway Tandy Bowen were kidnapped by Maggia goons.",
                    "The Maggia injected Johnson, Bowen and a number of other teenagers with an experimental narcotic. While this drug killed most of the runaways, it reacted with something lying dormant in Johnson and Bowen. Johnson gained a metaphysical connection to a dimension of darkness, while Bowen tapped into the power of light.",
                    "Under the codenames of Cloak and Dagger, Johnson and Bowen took their revenge on the Maggia. Since then, they have worked to protect young people across the world. They frequently fi ght with Mister Negative, a super villain created by the same narcotic that empowered them."
                ],
                Personality =
                [
                    "Years of adventuring have softened Cloak’s naturally anxious personality. He spends most of his time in the form of his heroic alter ego, scouring the world for people to protect. Serious and soft-spoken, Cloak no longer stutters—except on the few occasions he returns to his old identity and becomes fully tangible.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Cole North",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 1, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Cole North",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Fist, TeamNames.NYPD],
                Base = "NYC",
                History =
                [
                    "Cole North was once a revered detective in the Chicago Police Department. Then, for reasons unknown, he took a transfer to the New York Police Department. His fi rst task in New York was to investigate a murder supposedly committed by Daredevil (Matt Murdock).",
                    "North took to that case the same way he does with all his cases: with dogged determination. In a matter of days, he tracked Daredevil down, beat him up and arrested him. Unfortunately, North’s incredible and public defeat of Daredevil only made the hero’s subsequent escape from custody all the more humiliating for the NYPD.",
                    "For a while after that, North harbored a grudge against all costumed super heroes. However, recent events have begun to push him into closer cooperation with the hero he once called an enemy.",
                ],
                Personality =
                [
                    "North is a serious, by-the-book cop. He has trouble understanding why his fellow officers would willingly allow costumed vigilantes to act freely within their city.",
                    "Although he would typically prefer to avoid violence, North is more than capable of it. He is a highly trained boxer and a serious bodybuilder. North’s status as the most muscular cop in New York has granted him a level of respect within the NYPD typically reserved for much older officers."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Colleen Wing",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 1, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Nightwing Restorations Ltd."),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Sword"),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Colleen Wing",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Investigator],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.HeroesForHire, TeamNames.DaughtersOfTheDragon],
                Base = "NYC",
                History =
                [
                    "With her mother dead and her father busy, Colleen Wing grew up in the custody of her grandfather: Kenji Ozawa, the head of the Japanese Secret Service. As a combat veteran, Ozawa was eager to tutor Wing in the art of sword fi ghting, training her to be a world-class expert with the katana.",
                    "As an adult, Wing moved to New York City, where she met Misty Knight, who soon became her best friend and her partner in their private investigation business, Nightwing Restorations Ltd. They often join Luke Cage and Iron Fist (Danny Rand) to round out their team, known as the Heroes for Hire.",
                    "Wing later learned that her mother had been the leader of the Nail, a faction of the ninja clan called the Hand. For a short while, she led a new incarnation of the Nail, but later betrayed them when she couldn’t stomach their harsh methods.",
                ],
                Personality =
                [
                    "Wing is a bit more socially reserved than Misty Knight, but the women have more in common than not. Both are thrill-seeking daredevils with a cool head for combat.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
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
            Name = "Crimson Surfer",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 5, vigilance: 4, ego: 7, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            flySpeed: true,
                            specialization: "Crimson surfoard [Summonable by Crimson Surfer. Grants Flight 2.]"),

                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            PowerNotes =
            [
                "The Crimson Surfer’s powers are not identical to those of the Silver Surfer and are, in fact, weaker. This is because Kang the Devourer does not trust Shmidt with that much power and so gave him less of it."
            ],
            Biography = new Biography
            {
                RealName = "Johann Shmidt",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [189],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Body covered in nigh-indestructible crimson material",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "The Crimson Surfer started out the same way as Earth-616’s Red Skull. Adolf Hitler—declaring that he could turn anyone into the ideal Nazi soldier—selected a random bellboy by the name of Johann Shmidt to be his next secret agent. After World War II, the crimson-headed Shmidt carried the mad führer’s dream of a worldwide Nazi government into the modern age. This is where his fate and that of his Earth-616 counterpart diverge, as he successfully led Hydra to take over the world.",
                    "At some point, Kang the Devourer targeted the timeline of this Red Skull for destruction. Much like Norrin Radd made a deal with Galactus in the universe of Earth-616 to save his people, the Red Skull presented himself to the Devourer and offered to become his herald. He did it only to save his own skin, though, and for the Devourer to grant him a portion of his Power Cosmic. This gave him powers comparable to those of Earth- 616’s Silver Surfer and transformed him into the Crimson Surfer—after which, he helped oversee the destruction of his own universe’s timeline."
                ],
                Personality =
                [
                    "Shmidt is a fascist zealot, a madman and a master propagandist who deftly recruits crowds of bigots. Gaining the Power Cosmic has only heightened Shmidt’s megalomania. If he did not have to serve Kang the Devourer, the Crimson Surfer would already be scouring the universe, forcing as many worlds under his boot as he possibly could. He constantly looks for ways to betray the Devourer and take the rest of his power too.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Crystal",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 3, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = $"{PowerSetNames.ElementControl} Air/Earth/Fire/Ice/Water",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.ElementalSuffocation),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Crystalia Amaquelin",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Blue-green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.FantasticFour, TeamNames.HouseOfAgon, TeamNames.UniversalInhumans],
                Base = "Mobile",
                History =
                [
                    "Crystal was born in the Inhuman city of Attilan into a family of royal nutritionists. Just like her older sister, Medusa, Crystal was exposed to the Terrigen Mist as a baby. Subsequently, she gained the power to control the four classical elements: earth, air, fi re and water.",
                    "As young girls, Crystal and Medusa were inseparable. Sadly, war and chaos conspired to tear them apart when Crystal was just eight years old. Crystal spent her youth traveling the world, searching for Medusa. By the time they fi nally reunited, Crystal had grown into a young woman.",
                    "Crystal accompanied her sister back to Attilan, and in time, both became prominent members of the royal court. Medusa became queen of the Inhumans, while Crystal became an important ambassador and royal advisor.",
                    "Even after the bulk of Inhuman society was destroyed by Black Bolt, Crystal remained close to the Royal Family, providing whatever help she could to assist her sister in rebuilding their kingdom."
                ],
                Personality =
                [
                    "Having spent her youth traveling the world, Crystal is far more outgoing and personable than most Inhumans. She’s the only member of the Inhuman royal court to have had a number of signifi cant romantic relationships outside of Inhuman society. She dated the Human Torch (Johnny Storm) and was even briefl y married to Quicksilver. Together, they had one child, a girl named Luna.",
                    "Even more than Medusa, Crystal is headstrong. She relishes adventure and never hesitates to rush into the most dangerous situations."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
            Name = "Dagger",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Weird),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Light daggers [act as regular ranged weapons, but inflict Focus damage rather than Health damage]"),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.FastHands),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Tandy Bowen",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [115],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Crescent moon mark on face",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant, OriginName.WeirdScience],
                Teams = [TeamNames.SavageAvengers, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Tandy Bowen was born into a cold and distant family of wealthy socialites. As a teenager, she became fed up with her a¼ uent but unloving life in Ohio and ran away from home.",
                    "At a bus station in Manhattan, she ran into another teenage runaway: a penniless boy named Tyrone Johnson. She and Tyrone had only just begun commiserating over their mutual homelessness when they were kidnapped by Maggia goons.",
                    "The Maggia injected Bowen, Johnson and other teenagers with an experimental narcotic. While this drug killed most of the runaways, it reacted with something lying dormant in Johnson and Bowen. Johnson gained a metaphysical connection to a dimension of darkness, while Bowen tapped into the power of light.",
                    "Under the codenames Cloak and Dagger, Johnson and Bowen took their revenge on the Maggia. Since then, they have worked to protect young people across the world. They frequently fight with Mister Negative, a super villain created by the same narcotic that empowered them."
                ],
                Personality =
                [
                    "Dagger’s personality contrasts sharply with that of her partner. While Cloak is serious, demure and soft-spoken, Dagger is friendly and outgoing. Cloak prefers to fi ght evasively, while Dagger attacks head-on.",
                    "Despite their differences, Dagger is connected to Cloak by their powers and their mutual desire to protect the young and innocent. Dagger is one of the few people who can enter Cloak’s Darkforce dimension unharmed."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Dakota North",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 2, resilience: 1, vigilance: 1, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Skeptical),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Dakota North Investigations"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.Streetwise),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DefenseStance),
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
                RealName = "Dakota North",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Investigator],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.DakotaNorthInvestigations],
                Base = "Dakota North Investigations",
                History =
                [
                    "As the daughter of a cold and distant C.I.A. agent, Dakota North grew up hearing only whispers of her father’s world-spanning escapades. Despite her father’s protests, Dakota became determined to understand what his work was really all about. She became a world-famous child model, but from her teen years onward, she spent every day training, preparing for the day when she would enter the world of adventuring herself.",
                    "On the day of her eighteenth birthday, Dakota founded Dakota North Investigations—a private detective agency based out of New York City. Using her connections in the fashion industry, the business quickly took off. Over the course of the next few years, she opened three more branches of the investigative company in major cities across the United States.",
                    "In her time as a P.I., Dakota North has solved serial murders, thwarted terrorist attacks and assisted several other investigative super heroes in their escapades. Few other P.I.s in the world are as respected as Dakota North.",
                ],
                Personality =
                [
                    "Dakota North is a no-nonsense woman of action. She would not hesitate for a moment to jump through a window or to take a bullet for a client.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Deadpool-Bot 2000",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 8, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Giant swords"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
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
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "None",
                Heights = [new() { Feet = 10 }],
                Weights = [900],
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Giant clanky robot",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechAndroid],
                Teams = [],
                Base = "Bagalia",
                History =
                [
                    "When A.I.M. decided that nothing could possibly go wrong with creating an A.I. to train mercenaries, they evaluated a number of assassins, henchmen and hired guns. They even downloaded the thought patterns of a few of them—including Deadpool.",
                    "Deadpool’s thought patterns corrupted the A.I., which started calling itself M.A.D.E.M. (Murderous Application Designed Exclusively for Mayhem). It created a number of hideous challenges to train—or slaughter— mercenaries. Among these creations was the Deadpool-Bot 2000.",
                ],
                Personality =
                [
                    "This clattering, clunky robot believes itself to be Deadpool, and—like 90% of the comic creators in the world—it believes its own hype. It taunts opponents, cracks bad jokes and runs its mechanical mouth during battle… and pretty much all other times too.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Demolisher (Wrecking Crew)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 1, resilience: 2, vigilance: 3, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Ball and chain (throwable club)"),
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
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
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
                RealName = "Laura Lopez",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [240],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Unlike the core four members of the Wrecking Crew, Laura Lopez joined the criminal organization long after its initial formation. She had been training to be muscle for Wilson Fisk, but the Kingpin believed that her incredible talents could be made better use of elsewhere. He introduced her to the Wrecker, and she’s been part of the crew ever since.",
                    "Little is known about the Demolisher’s early life. She presumably has some history in the professional bodybuilding scene because—unlike the other members of Wrecking Crew—she does not rely on the Wrecker’s magic. Instead, her strength arises from years of hard work and training.",
                ],
                Personality =
                [
                    "Lopez is the youngest member of the Wrecking Crew, and as such, she is less hardheaded and jaded than her compatriots. She truly enjoys the thrill of battle and isn’t above cracking a joke in the midst of a life-or-death situation. She’s also the only woman on the team, which she is always aware of.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Doombot",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 3, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Doombot army)"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, German, Hungarian, Latverian, Romani"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "typically around 6'6\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "typically around 500 lbs.",
                Gender = Gender.Male,
                Eyes = "Varies, usually brown",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Robotic body, usually hidden by armor",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.AlliesOfDoctorDoom],
                Base = "Latveria",
                History =
                [
                    "Victor von Doom is an ambitious and intelligent man with more enemies than he can count. By the end of his college years, Doom realized that, if he wanted to survive the coming decades, he would need trained body doubles.",
                    "Unwilling to settle for using regular men, Doom began prototyping robots that could act in his place. The fi rst of these Doombots were impressive but fl imsy, barely able to fi ght for themselves. Ever undeterred by defeat, Doom continued to rebuild and rework his bots until they became a force to be reckoned with.",
                    "The modern Doombots are among the toughest and most fearsome androids on the planet Earth. A single Doombot can contend with the likes of Spider-Man, and Doom’s enemies are rarely lucky enough to be faced with just a single bot. Doom has been known to deploy entire armies of Doombots to deal with his archrivals in the Fantastic Four, or to put down peasant uprisings in his home country of Latveria."
                ],
                Personality =
                [
                    "The A.I. that runs the Doombots is both sophisticated and limited. When Doom himself is not available, they are capable of emulating his personality almost exactly, to the point where they begin to believe that they themselves are the real Doom.",
                    "However, when Doom is present, the Doombots shift into a mode more resembling that of mindless zombies. They follow Doom’s orders to the letter, with no comments or complaints."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Doop",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 6, vigilance: 7, ego: 4, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Mysterious),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelDimensional,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DimensionalPortal),
                        powerSelector.GetPower(PowerNames.DimensionalTravel),
                        powerSelector.GetPower(PowerNames.DimensionalTravelOther),
                        powerSelector.GetPower(PowerNames.DimensionalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ClonePowers),
                        powerSelector.GetPower(PowerNames.CopyPower),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.GroupLevitation),
                        powerSelector.GetPower(PowerNames.Levitation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 3’",
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Legless green creature resembling a large, fat pickle with arms",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.AlienMarginalian],
                Teams = [TeamNames.XStatix],
                Base = "Mobile",
                History =
                [
                    "No one knows for sure where Doop came from, not even Doop. He grew up in the mysterious dimension of Marginalia, a place that exists outside of space and time, metaphorically in the margins of comic-book pages themselves.",
                    "Some say that Doop was the result of top-secret experiments performed by the U.S. military in the eighties. Others claim Doop spawned entirely from the imagination of an anonymous hospital orderly who scribbled the fi rst known image of the creature in the margins of a screenplay written by fi lm director Ingmar Bergman.",
                    "Whatever the truth may be, Doop spent his formative years believing that Ingmar Bergman was his creator. Out of respect for the director, Doop began practicing the art of fi lmmaking. Eventually, he lucked into a videography job with the private, for-profi t X-Statix super-hero team.",
                    "Doop is the only member of the original X-Statix lineup still with the team. All the others either died or abandoned the group long ago, but Doop remains steadfast, always watching from the background, recording every movement.",
                    "When not with X-Statix, Doop mingles with mutants of all kinds. He once even served as a receptionist at the Jean Grey School for Higher Learning."
                ],
                Personality =
                [
                    "Doop has powers beyond comprehension, but he rarely uses them to their fullest extent. He does not want to make himself the subject of his own movies, preferring instead to let his teammates in X-Statix speak for themselves.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty4),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SenseSupernatural),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HellfireChains),
                        powerSelector.GetPower(PowerNames.SenseSins),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow3),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Egghead",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 2, resilience: 1, vigilance: 1, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminals"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Egg bombs (frag grenades)"),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Elihas Starr",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [320],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Unusually large, conconical head",
                Occupations = [OccupationName.Criminal, OccupationName.Scientist],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.MastersOfEvil],
                Base = "NYC",
                History =
                [
                    "For attempting to smuggle atomic secrets out of his own government-backed laboratory, Elihas Starr was fi red from his job and became a pariah in the scientifi c community. Unfortunately for humanity, this served only to drive Starr further down the criminal path.",
                    "Shortly after Starr was fired, a group of upperclass criminals contacted him. Impressed by his supposed intellect, they hired Starr to defeat the scientist/crimefi ghter Ant-Man (Hank Pym).",
                    "Starr’s initial attempts at this were, by and large, catastrophic failures, but that did not matter to him. He had gotten a taste for the thrill of supervillainy, and he was never going back.",
                    "Despite repeatedly being beaten, locked in jail and—on at least one occasion—killed outright, Starr has continued to menace the scientifi c world. Under the codename Egghead, he plots the destruction of all legitimate scientists, particularly Hank Pym and his heroic proteges."
                ],
                Personality =
                [
                    "Egghead is a delusional egomaniac who believes he is the smartest man in the world. In reality, he is nothing more than a mediocre scientist with a decent head for on-the-fl y inventions. He can be reasoned with, but only insofar as he can be fl attered.",
                    "Though Egghead may make an exception for the right price, he prefers criminal assignments that allow him to face off against important scientists like Hank Pym and Tony Stark. He wants nothing more than to prove himself in a battle of wits with those whom he believes are his intellectual rivals. He never succeeds."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DampenPower),
                        powerSelector.GetPower(PowerNames.ShutDownPowers),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicChaosMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HexBolt),
                        powerSelector.GetPower(PowerNames.Jinx),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
        new()
        {
            Name = "Frog-Man",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 1, vigilance: 0, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in suit"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitAndRun),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Eugene Paul Patilio",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.ActionPack, TeamNames.SpaceFriends],
                Base = "NYC",
                History =
                [
                    "Vincent Patilio was a penniless inventor who thought he could make a quick buck by building a super-suit that would allow him to make a quick escape from any heist. Donning a frog-themed costume, Vincent Patilio made his debut upon the world stage as the villain Leap-Frog.",
                    "He was almost immediately arrested by Daredevil.",
                    "From then on, Vincent’s life only got worse. Despite having sworn off crime, the public continued to see him as little more than a petty menace. He and his son Eugene fell further and further into poverty.",
                    "Eventually, Eugene became sick of people bad-mouthing his father. He dug up his dad’s old suit and vowed to clear the name of frog-themed adventurers everywhere. Under the title of Frog- Man, he wages a one-amphibian war on crime."
                ],
                Personality =
                [
                    "Eugene has a good heart, but his own bumbling and awkward nature has kept him from achieving his dreams. Despite having been an adventurer for a few years, he has yet to make much of a name for himself. He often falls back on his old job as a busboy to make rent.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sniping),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedRun1),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedRun1),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
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
            Name = "Gorgon",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 3, resilience: 5, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Inhuman Royal Guard)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Gorgon Petragon",
                Heights = [new() { Feet = 6, Inches = 8 }],
                Weights = [485],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Hooved feet",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.HouseOfAgon, TeamNames.InhumanRoyalGuard],
                Base = "Mobile",
                History =
                [
                    "Born into an off shoot of the royal House of Agon, Gorgon Petragon was taught from a young age to revere and respect Inhuman royalty. As a young man, he befriended the future Inhuman king, Black Bolt, pledging his loyalty to the young prince. In the years since, Gorgon has never strayed far from Black Bolt or his queen, Medusa.",
                    "As the head of the Inhuman Royal Guard and the personal bodyguard of the royals themselves, Gorgon has been entrusted with the protection and preservation of the House of Agon. This is a job he takes with deadly seriousness, one he continued to perform even after Black Bolt was forced to kill the bulk of the Inhuman population.",
                    "If he can be convinced that doing so would be in the Royal Family’s best interests, Gorgon has sometimes been known to work against the royals’ wishes. On multiple occasions, the Inhuman villain Maximus has used this fact to manipulate Gorgon into attacking those he was sworn to protect.",
                ],
                Personality =
                [
                    "Gorgon’s unfl inching loyalty to the House of Agon is both his greatest strength and his greatest weakness. He stops at nothing to ensure the safety of the Inhuman Royal Family. In times of relative unity, this dedication has been an immense boon for the royals. In times of division and confusion, Gorgon can be as much a danger as an asset.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Gorgon (Tomi Shishido)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 3, vigilance: 4, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.FocusedFury),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Tomi Shishido",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [215],
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Glowing yellow eyes, pale-gray undead skin",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GreatCaptainsOfKrakoa, TeamNames.TheHand, TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "Unlike most mutants, Tomi Shishido’s powers began to manifest almost immediately after his birth. As a mere toddler, Shishido had the skills to rival the world’s greatest artists. His intelligence advanced so quickly and erratically that by the time he was a teenager, something fundamental within his psyche could no longer bear the strain. He became increasingly despondent and, eventually, violent.",
                    "At the age of eighteen, Shishido killed his entire family. Shortly thereafter, he took control of the Hand and merged the ninja organization’s already considerable resources with those of Hydra. As the mighty Gorgon—high commander of both Hydra and the Hand—Shishido committed himself to sowing death and destruction across the globe.",
                    "For the good of mutantkind, the founders of Krakoa convinced Shishido to put aside his evil ways. However, few doubt that he could return to his old patterns under different circumstances.",
                    "As a man who cares deeply about the well-being of Japan, Wolverine (Logan) keeps tabs on Shishido. He has already foiled Gorgon’s plots for world domination several times, and if and when the time comes, he will be prepared to do so again."
                ],
                Personality =
                [
                    "Unlike most members of Hydra, Gorgon is not a fascist. Rather, he is an extreme nihilist. He sees the world as only a cruel joke played by an unloving god. In his heart, he desires nothing more than to wipe the slate clean and destroy all of creation. Hydra and the Hand are simply means to that end.",
                    "Rumors hold that—like the monster of Greek myth from which he takes his name—Gorgon can turn a person to stone with a single glance. However, no one has witnessed this happen for a long time, and it may be that Gorgon himself is the source of these rumors."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
        new()
        {
            Name = "Growing Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 5, vigilance: 2, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
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
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.Mighty3),
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
                        powerSelector.GetPower(PowerNames.MacrodimensionalTravel),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                    IsTech = true
                },
            ],
            PowerNotes =
            [
                "Whenever possible, the Growing Man uses the Energy Absorption power as a reaction. Every time he successfully uses this power, he automatically grows one size. He cannot willingly return to his default size."
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Varies",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Robotic humanoid with bright orange skin",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.HighTechAndroid],
                Teams = ["Ally to Kang the Conqueror", TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "As part of his usual plans to cement himself as ruler of the known multiverse, Kang the Conqueror created the world’s fi rst stimuloid: an artifi cial human with the ability to absorb kinetic energy and turn it into mass. Kang proudly named his creation the Growing Man, and he buried it in Earth’s ancient past for safekeeping.",
                    "In the early twenty-first century, a group of archaeologists working out of Manhattan inadvertently uncovered this stimuloid, awakening it much earlier than Kang had wished. Without the guidance of his creator, the Growing Man embarked on a wild rampage that drew Kang to that period of time. In the end, it took Thor himself to stop both the Growing Man and Kang himself.",
                    "Kang has rebuilt the Growing Man several times, only to see the stimuloid defeated again and again. He long ago abandoned any hope that the Growing Man would be his ultimate weapon, and these days he mostly uses the android as a bodyguard."
                ],
                Personality =
                [
                    "The Growing Man is intelligent, but only at the level of a toddler. Though he does not really understand why, he has an instinctive loyalty to his creator. Nothing bothers him more than the idea that Kang may have betrayed or otherwise abandoned him.",
                    "The Growing Man’s control over his own powers is limited, and a slow and steady beating can force him into a spiral of uncontrollable growth. Whenever the Growing Man is in the fi eld, Kang carries a “De-Energizer” gun capable of instantly reverting the stimuloid to his default size of small."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                    ],
                },
                new CharacterPowerSet
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
            Rank = 2,
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Hawkeye (Kate Bishop)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Hawkeye (Clint Barton)"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bow and arrow"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Katherine Elizabeth “Kate” Bishop",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Investigator],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.WestCoastAvengers, TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "When Kate Bishop was a young girl, she was kidnapped by a super villain named El Matador. After being rescued by the Avengers, she developed an abiding admiration for the team, especially Hawkeye (Clint Barton), who fought for justice despite his lack of super-powers.",
                    "Bishop decided to follow in Hawkeye’s footsteps. As a teenager, she adopted Hawkeye’s codename and began fighting crime as a member of the Young Avengers, with whom she has had numerous adventures. In the years since taking on the codename Hawkeye, she has worked several times with the original Hawkeye, who has made her his o¸ cial protege, and she even took over ownership of his dog, Lucky. She recently started her own detective agency: Hawkeye Investigations.",
                ],
                Personality =
                [
                    "Despite her outwardly casual and sometimes flighty attitude, Bishop has a strong and determined sense of justice. She wouldn’t hesitate to put herself in harm’s way to save another, even if it risked certain death.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.LeechLife),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "H.E.R.B.I.E (Security Unit)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 3, resilience: 1, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Opti-Blaster (works like a regular pistol, but blinds the target on a Fantastic success)"),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                    IsTech = true
                },
            ],
            PowerNotes =
            [
                "Not all H.E.R.B.I.E. units are equipped with weapons. Such non-security units can fly but are otherwise no more powerful than an average civilian (see that profile in the Core Rulebook)."
            ],
            Biography = new Biography
            {
                RealName = "Humanoid Experimental Robot, B-type, Integrated Electronics",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 2'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 70 lbs.",
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Child-sized metallic robot with screen for a face",
                Occupations = [OccupationName.Educator, OccupationName.Scientist],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.FantasticFour],
                Base = "NYC",
                History =
                [
                    "The fi rst prototype H.E.R.B.I.E. was created by Mister Fantastic (Reed Richards) of the Fantastic Four to aid in the search for Galactus and to act as his personal laboratory assistant. HERBIE was designed to be smart, helpful and generally cheerful. Incredibly, he actually turned out to be all those things.",
                    "In fact, the H.E.R.B.I.E. project was such a success that Richards slowly began to produce more H.E.R.B.I.E.s. Within a few years, H.E.R.B.I.E. units were running almost all of the day-to-day activities at the Fantastic Four’s headquarters.",
                    "H.E.R.B.I.E. units sometimes accompany the Fantastic Four on their adventures across time and space. However, the average H.E.R.B.I.E.’s duties are far more pedestrian. For example, a specialized H.E.R.B.I.E. unit often acts as the personal caretaker to Richards’ two children, Franklin and Valeria."
                ],
                Personality =
                [
                    "For the most part, H.E.R.B.I.E. units are thoughtful and chipper. Built with a heroic spirit, they are quick to offer a hand in assistance to any who need one.",
                    "Some H.E.R.B.I.E.s, particularly those assigned to menial and boring tasks, harbor some resentment for their creator, but they rarely let it show. Only a select few H.E.R.B.I.E. units have ever chosen to leave the Fantastic Four behind."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hit Monkey",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 2, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.DanceOfDeath),
                traitSelector.GetTrait(TraitNames.Small),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only make monkey noises"),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DanceOfDeath),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "None",
                Heights = [new() { Feet = 2, Inches = 5 }],
                Weights = [31],
                Gender = Gender.Male,
                Eyes = "Amber",
                Hair = "Gray",
                Size = Size.Small,
                DistinguishingFeatures = "Small Japanese macaque who o« en stands on two legs and wears a suit",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.MercsForMoney, TeamNames.STAKE],
                Base = "Mobile",
                History =
                [
                    "As a young macaque, Hit-Monkey grew up among a tribe of his species hidden deep within the mountains of Japan. Life was peaceful until, one day, a dying hit man stumbled into the tribe’s territory. Hit-Monkey demanded that the murderous man be cast back out into the snowy wastes, but the other macaques refused to listen. Determined to have his way, Hit-Monkey lashed out at the tribe’s leader, injuring him. As punishment, the leader sent Hit-Monkey into exile. On the same day that exile began, a group of hired mercenaries came to the mountainside, looking for the hit man. They slaughtered him—along with every one of the macaques protecting him.",
                    "Filled with rage upon discovering the fate of his tribe, Hit-Monkey took up the dead man’s weapons and destroyed the mercenaries. He then set out for vengeance upon the men who’d hired those killers.",
                    "In short order, Hit-Monkey had his revenge, but it brought him little solace, as he had no home to return to. To keep on living, he became a hit man himself.",
                    "In the years since, Hit-Monkey has taken on and defeated some of the best mercenaries on the planet, including Deadpool. Many consider him the greatest contract killer to ever live. The upper echelons of the underworld utter his name only in hushed whispers."
                ],
                Personality =
                [
                    "Although Hit-Monkey understands human speech, he cannot speak any human language. He can communicate only with normal simian grunts and screeches. He has a hair-trigger temper, and in the heat of battle, he all but perpetually screams.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Hive",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 1, resilience: 4, vigilance: 2, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only speak in eldritch gibberih"),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Hive",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "typically around 7'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "typically around 340 lbs.",
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Humanoid hive of parasitic organisms",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "The Hive is a living bioweapon, the result of experiments performed by Hydra researchers on some of the world’s deadliest creatures. These maniacal scientists sought to create a living monster that was also a physical representation of everything Hydra stands for. In the many-tentacled Hive, they found their champion.",
                    "Just like Hydra, the Hive is conniving, amoral and parasitic. It can survive only by regularly bonding with a host—that it takes over entirely—and feeding upon innocent people. If left isolated for an extended period, the Hive dissolves back down into its original form: a pathetic and squirming pile of prehensile appendages.",
                    "The Hive’s innate loyalty to Hydra as an organization is the only thing that keeps it in check. For high-ranking members of Hydra, the Hive has been known to sacrifi ce pieces of itself, merging with its allies in order to extend their lifespans."
                ],
                Personality =
                [
                    "Although the Hive is thought to be intelligent, it cannot speak any known human language. It can understand English, but its own speech consists of a garbled mess of undersea squeals and eldritch burbling. A few select members of Hydra have learned to decipher this language, and they serve as the Hive’s handlers.",
                    "The Hive needs to feed on a new human only once every few years, but it prefers to feast on a daily basis. It can bond with persons of any gender, but it tends to present as male."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hood",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 1, vigilance: 3, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Supernatural),
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
                        powerSelector.GetPower(PowerNames.Flight1),
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
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Parker Davis Robbins",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.Illuminati],
                Base = "Mobile",
                History =
                [
                    "With a pregnant wife at home and an ailing mother in the hospital, Parker Robbins turned to a life of crime to make ends meet. Off a tip from his cousin, Robbins broke into a warehouse that was supposed to contain a large shipment of valuable foreign goods.",
                    "Robbins found no such riches. What he discovered instead was a summoning circle and a terrifying cloaked demon spawned from the depths of hell.",
                    "More out of panic than malice, Robbins riddled the demon with bullets. In a frenzy, he stole the creature’s clothes and made off into the night.",
                    "Only after the fact did Robbins realize that the garments had special powers. Using them, he could turn invisible, walk on air and even shoot bolts of lightning from his hands.",
                    "Under the codename of the Hood, Robbins set out to turn his newly found powers toward the pursuit of personal profi t. He found that he had a talent for villainy and, after a few rocky capers, his crimes began to pay for themselves. Today, the Hood oversees a crime syndicate worthy of the Kingpin himself."
                ],
                Personality =
                [
                    "Despite his many crimes, Robbins still sees himself as basically a good person, a misunderstood man of the people. He rarely fl aunts his wealth, stowing most of it away for the future benefi t of an infant son he hardly ever sees.",
                    "Largely estranged from his family, Robbins spends most of his time drinking heavily and skulking around his own gambling dens."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
        new()
        {
            Name = "Hydra Officer",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
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
                    "Hydra tends to treat its lowest-level recruits (Hydra Agents) as cannon fodder, foot soldiers who can be spent or lost without hesitation. After all, there never seems to be a lack of disaffected people looking to join up with the fascist organization to do their part for world domination. As the Hydra oath goes, “Cut off a limb and two more shall take its place!”",
                    "Those agents who survive long enough—or are ambitious enough—find themselves promoted to positions of leadership within their hierarchical organization. Often they’re the leaders of independent cells sequestered from the rest of Hydra for operational security, and the fact that they’ve survived to that point means (at least to them) that they must be doing something right.",
                ],
                Personality =
                [
                    "While Hydra agents like to follow orders, Hydra officers have developed a taste for giving them. They like to shout at their underlings and boss them around, and many of them harbor aspirations of one day becoming the Supreme Hydra themselves. They tend to be mean and merciless— to outsiders, to their subordinates and most especially to those they see as rivals. Many of them see the fact that they’ve risen in the ranks as the proof of their superiority, and because of this, they tend to be cocky as well.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hyperion",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 6, vigilance: 3, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MahdWyry),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Marcus “Marc” Milton",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [460],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Auburn",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.AlphaFlight, TeamNames.Avengers, TeamNames.SquadronSupreme],
                Base = "Mobile",
                History =
                [
                    "Marcus Milton was born in an alternate universe— Earth-13034—as the sole survivor of a dying world of Eternals. His people sent him to Earth, where he was raised by a humble family of ordinary people.",
                    "Under the codename Hyperion, Milton worked to make that Earth into a utopia. Sadly, his home, his family and every other member of his universe were destroyed by the incursion of another reality, leaving him—once again—the sole survivor.",
                    "Hyperion was pulled from the void of his dead universe to Earth-616 by a group of A.I.M. scientists experimenting with multiversal travel. The Avengers freed Hyperion from A.I.M. containment, and for a while, he traveled with them on their adventures. However, he eventually tired of hero work, abandoned his identity as Hyperion and took up a job as a trucker, hoping to learn more about his new home.",
                    "Events outside of his control have occasionally forced Milton to return to his super-hero identity, but he continues to spend most of his time living on the road."
                ],
                Personality =
                [
                    "Milton struggles with his identity. He is not even the fi rst version of himself to be pulled from another universe into Earth-616. The original Hyperion—Mark Milton of Earth-712—died shortly after this Milton’s arrival.",
                    "Having survived so much death and destruction, Milton sometimes feels like fi ghting for justice may be a futile effort when, at any second, his whole world could be destroyed or reset. Still, he can’t help but answer the call to action when he sees a person in need."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Inhuman Royal Guard",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Inhumans)"),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.InhumanGenes),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
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
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.InhumanRoyalGuard],
                Base = "New Attilan",
                History =
                [
                    "The Inhuman Royal Guard has existed in one form or another since the dawn of the Inhuman monarchy itself. For thousands of years, they have been charged with the protection and preservation of the Royal Family. It is a duty that most of its members treat with deadly importance.",
                    "The Royal Guard has always been led by off shoots of the Royal Family itself. The most recent commander of the guard was Gorgon Petragon, cousin to both the king and the queen. The few who have obtained signifi cant ranks within the Royal Guard have earned the privilege of direct proximity to ultimate power. Inhuman children grow up dreaming of gaining so much as a temporary position within the guard’s lowliest ranks.",
                    "Early incarnations of the guard wielded spears and swords, and on ceremonial occasions the modern guard has been known to return to these implements. However, when out and about on duty, members of the current guard carry energy pistols and wear suits of gray cyber-armor. They are crack shots who shoot fi rst and ask questions later.",
                ],
                Personality =
                [
                    "While the leaders of the Royal Guard have distinct and boisterous personalities, the rankand- fi le members of the institution are often indistinguishable from normal humans. Some of them have undergone Terrigenesis and acquired low-level super-powers, but many others have chosen to forgo the mists and strengthen themselves in more traditional ways.",
                    "When in the presence of royalty, members of the guard are expected to maintain complete and reverent silence. Much of a guard’s regular duties can be summed up in a single sentence: stand still and look intimidating."
                ],
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline3),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.FocusedStrike),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Iron Fist (Lin Lie)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.FocusedStrike),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Iron Fist (Danny Rand)"),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Shang-Chi"),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FocusedStrike),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Lin Lie",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Dragon insignia on right arm.",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic, OriginName.SpecialTraining],
                Teams = [TeamNames.AgentsOfAtlas],
                Base = "Mobile",
                History =
                [
                    "One year after Lin Lie’s father and brother mysteriously disappeared, Lie was attacked at his home in Shanghai by a deliveryman—who turned out to be one of the demons who had kidnapped his missing kin. In a last-ditch effort to ward off the hellish creature, Lie took hold of his father’s old sword and lashed out. To his surprise, the demon disappeared.",
                    "The blade once belonged to Fu Xi, one of China’s three legendary sovereigns, and as Xi’s descendant, Lie was one of a select few who could wield it against demons. Determined to save his family, Lie took on the codename of Sword Master and embarked on a global demon-killing spree.",
                    "After months of adventures, Lie fi nally encountered a demon he could not defeat. This fearsome creature shattered the legendary blade, embedding the shards within Lie’s body. He would have perished had it not been for the intervention of the dragon spirit Shou-Lao. The serpent imbued Lie with chi power, transforming him into the latest incarnation of Iron Fist.",
                    "Lie’s search for his family continues, but now he must juggle that quest with the responsibility of being the new Iron Fist."
                ],
                Personality =
                [
                    "In his heart, Lin Lie is still just a kid from Shanghai. He is young and insecure and constantly questions whether he deserves the power he has been given. Only with the constant support of those around him has Lie been able to build and maintain the confidence to carry on.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
        new()
        {
            Name = "Ironheart (Riri Williams)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 3, vigilance: 2, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Tony Stark"),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection, isTech: true),
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
                RealName = "Riri Williams",
                Heights = [new() { Feet = 5, Inches = 2 }],
                Weights = [100],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Engineer],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.Champions, TeamNames.Underground],
                Base = "Mobile",
                History =
                [
                    "As a shy kid from the south side of Chicago, Riri Williams had few prospects and even fewer friends. However, as a certifi ed child genius, Williams earned a full ride to M.I.T. at the age of 11. Lacking the skills to make friends there—and surrounded by students twice her age—her fi rst two years at the institute passed uneventfully. She withdrew into her studies, rarely speaking to anyone save for her parents and her childhood friend Natalie Washington.",
                    "In the summer of her sophomore year, Williams’ social circle shrank even further when both her stepfather and Natalie were killed in a senseless drive-by shooting. Determined to avenge the deaths of her loved ones, Williams built a battle suit in the style of Iron Man (Tony Stark). Her escapades in this initial prototype drew the attention and admiration of Stark himself, who offered Williams the mentorship and resources she needed to build a new suit and become a fullfledged super hero.",
                    "As Ironheart, Williams has everything she ever wanted, including the opportunities to make friends. She often fights as part of the Champions, a team of young super heroes ready to help save the world."
                ],
                Personality =
                [
                    "As a young girl, Williams could not have been any more timid and awkward, but as she matured into a young adult, she learned how to speak her mind with confi dence. As such, she’s made friends both within the super hero community and without. What little free time she has she spends listening to hip-hop and poring over circuit diagrams.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
    ];

    private List<Character> GetAllCharactersJ() =>
    [
        new()
        {
            Name = "J. Jonah Jameson",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 0, resilience: 0, vigilance: 1, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.Skeptical),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "John Jonah Jameson Jr.",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [181],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black with gray temples",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.TheDailyBugle, TeamNames.TNM],
                Base = "NYC",
                History =
                [
                    "Determined to make the world a better place, J. Jonah Jameson spent his childhood studying the art of journalism. As a mere high school student, he wriggled his way into a position as a junior reporter with the Daily Bugle. Jameson’s stellar reporting on civil rights issues, alongside his thrilling exposés on organized crime, rocketed him to the top of the paper’s lineup.",
                    "Eventually, Jameson found the resources to buy the Daily Bugle and install himself as the editor in chief. Practically overnight, Jameson turned the Bugle from a failing local rag into an internationally respected news organization.",
                    "More than anything, Jameson is renowned for his editorial stance against costumed super heroes. As a man dedicated to the truth, he despises anyone whom he believes has something to hide. He has a particular sore spot for Spider-Man, who operates in the Bugle’s direct vicinity.",
                    "Jameson lost control of the Daily Bugle and was forced to get a job as a regular reporter again. He even became mayor of New York City for a while. He has since returned to his fi rst love: the news."
                ],
                Personality =
                [
                    "While he can come off as charming on camera, Jameson’s employees know him as the gruff and abrasive man he really is. Although he retains the strong sense of justice he had in his youth, years of dangerous reporting work have turned Jameson into an angry cynic. He spends his days alternately shouting at his reporters to work harder and brooding in his office, scheming ways to keep his latest venture in the black.",
                    "Jameson has a soft spot for his son, John Jameson (A.K.A. Man-Wolf), whose heroics as an astronaut earned him worldwide recognition."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Jean Grey",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 3, vigilance: 7, ego: 8, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
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
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Levitation),
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticBarrier),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                        powerSelector.GetPower(PowerNames.TelekineticProtection2),
                        powerSelector.GetPower(PowerNames.TelekineticReinforcement),
                        powerSelector.GetPower(PowerNames.TelekineticSphere),
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
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                        powerSelector.GetPower(PowerNames.TelepathicPossession),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jean Grey-Summers",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Jean Grey’s mutant psychic abilities awakened when she was just 10 years old, after she witnessed her best friend die in a hit-and-run. With Jean traumatized and unable to control her nascent powers, her parents did the only thing they could think of. They entered her into the care of psychic professor Charles Xavier, better known as Professor X.",
                    "Not long thereafter, Xavier formed the original X-Men and installed Grey as a founding member, under the codename Marvel Girl. In the years since, Grey has become one of the most famous and powerful mutants—if not heroes—in existence. Along with the rest of the X-Men, she has fought against existential threats to the universe itself.",
                    "Additionally, Grey has hosted the Phoenix Force, an ineffable entity of light and fire older than the cosmos. Although the Phoenix Force has currently bound itself to another, Grey remains extremely powerful.",
                    "Two of Grey’s future children that she has yet to have with Cyclops (Scott Summers)—who she is in a long-term relationship with—have become X-Men on their own: Rachel Summers and X-Man (Nate Grey)."
                ],
                Personality =
                [
                    "Grey’s powers are limited by her ability to control her mental state. She has rarely been completely stable on a psychic level, and repeatedly acting as the host of the sentient Phoenix Force has only served to further damage her. When she is stable, though, Grey is known for her kind and caring nature. Grey’s teammates have long been a driving force in helping her to maintain her sanity, particularly Cyclops.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Kang the Conqueror",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 6, ego: 5, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimePortal),
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelOther),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Nathaniel Richards",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Anachronauts, TeamNames.CouncilOfKangs],
                Base = "Mobile",
                History =
                [
                    "Nathaniel Richards grew up in the near-utopian environment of the 30th century of Earth-6311. As an adult, he became sick of luxury and became determined to live a life of adventure in a more interesting era.",
                    "Disguising himself as the Pharaoh Rama-Tut, he built a time machine and set about conquering ancient Egypt. The Avengers put a quick end to his reign, but Richards remained undeterred. He conquered the war-torn 40th century and returned to the Avengers’ era equipped with the greatest weaponry the future could offer.",
                    "As Kang the Conqueror, Richards has attempted many times to take down Earth’s mightiest heroes. He has faced many defeats, but his powers over time have always allowed him to return and try again.",
                    "Kang is not above meddling in anyone’s timeline, even his own. As a result, his early life has become shrouded in mystery and divergence, including other identities like those of Iron Lad and the Scarlet Centurion. Several alternate Kangs from across the Multiverse have had adventuring careers to rival his own. His future timeline is just as convoluted, often due to him trying to avoid becoming the more peaceful Immortus."
                ],
                Personality =
                [
                    "Kang is a megalomaniac and a narcissist of the highest order. He believes he's the most important being in existence, and he goes to great lengths to prove it. He often speaks in the style of ancient Greco-Roman conquerors.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Karnak",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 3, vigilance: 4, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.Exploit),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Karnak’s hands (act as melee weapons)"),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.RegainFocus),
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Karnak Mander-Azur",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "Shaved",
                Size = Size.Average,
                DistinguishingFeatures = "Numerous face tattoos",
                Occupations = [OccupationName.Adventurer, OccupationName.Educator],
                Origins = [OriginName.Inhuman, OriginName.SpecialTraining],
                Teams = [TeamNames.HouseOfAgon, TeamNames.UniversalInhumans],
                Base = "Mobile",
                History =
                [
                    "Karnak was born into a prominent family of Inhuman geneticists, an off shoot of the royal House of Agon. When Karnak was just a boy, his brother Triton was exposed to the Terrigen Mist and mutated into a fi shlike creature incapable of surviving on dry land. Subsequently, Karnak’s parents forbade him from ever touching the mists.",
                    "Unwilling to be left behind by the other members of the Royal Family, Karnak embarked on a course of specialized and mysterious training. With the help of his strong Inhuman genes, Karnak quickly became an expert in combat. He can break most barriers and defeat most opponents in a single punch, given a chance to analyze their weaknesses.",
                    "Karnak’s skill in combat makes him an invaluable asset to Black Bolt and the rest of the Inhuman Royal Family, though he’s not as attached to the royals as many of the other members of their court. In recent years, he has dedicated much of his time to educating the next generation of warriors.",
                ],
                Personality =
                [
                    "More so than any of the other Inhuman royals, Karnak is ruthless in combat. He does not hesitate to kill an opponent, especially one he considers inferior.",
                    "Outside of combat, he is equally single-minded. He spends much of his free time meditating on the nature of existence. He cares for the other members of the House of Agon, but only in a distant, brooding manner."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
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
            Name = "Lockjaw",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 3, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only bark"),
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
                    Name = PowerSetNames.OmniversalTravelDimensional,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DimensionalTravel),
                        powerSelector.GetPower(PowerNames.DimensionalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportBlind),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportOther),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lockjaw",
                Heights = [new() { Feet = 5 }],
                Weights = [1240],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Giant bulldog with small tuning-fork-like antennae",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Inhuman, OriginName.WeirdScience],
                Teams = [TeamNames.HouseOfAgon, TeamNames.PetAvengers],
                Base = "Mobile",
                History =
                [
                    "Lockjaw is the fi nal result of a series of experiments on animals performed by Inhuman geneticists. He was implanted with Inhuman genes and exposed to the Terrigen Mist while still in the womb. As a result, he later grew to an immense size and gained the ability to teleport nearly unlimited distances.",
                    "The data from the experiments on Lockjaw was used to give the future Inhuman king Black Bolt his own powers. Mere days after Black Bolt was born, the young prince developed an attachment to the dog who had been mutated in the same manner as himself. Soon enough, Lockjaw had become the official pet of the Inhuman Royal Family.",
                    "Lockjaw accompanies the royals on nearly all of their adventures. Although his combat abilities are limited, his powers of teleportation make him an indispensable teammate. In the rare event that the Inhuman royals are outmatched by an opponent, they can always cling to Lockjaw and teleport away.",
                ],
                Personality =
                [
                    "Although more intelligent and observant than an average bulldog, Lockjaw is still an animal. He whines, barks, begs and behaves like any other dog.",
                    "Lockjaw can be rambunctious, and he has been known to run off on his own adventures from time to time. However, he is, above all else, loyal to Black Bolt. Any who make themselves an enemy of the Inhuman king must also contend with his dog."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Logos (of Earth-56438)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Hounded, reminder: "outside ancient Egypt"),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Powerful, reminder: "within ancient Egypt"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Logos",
                Heights = [new() { Feet = 5 }],
                Weights = [125],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Mutant],
                Teams = ["Personal advisor to Rama-Tut Kang"],
                Base = "Ancient Egypt",
                History =
                [
                    "Having been born into a wealthy Egyptian family, Logos was raised from birth to act as an advisor within the pharaoh’s royal court. His brilliant mind and his preternatural ability to sense what others are thinking brought Logos prestige and renown. However, he obtained the status of grand vizier only after Kang’s arrival.",
                    "When Kang fi rst arrived in Egypt, he slaughtered most of the last pharaoh’s court. Logos is one of the few who Kang chose to spare.",
                    "Although he does not know it himself, Logos is a mutant, one of the earliest. He is a brilliant advisor, but Logos’ mutant status is the main reason Kang kept him around. Kang has been on the lookout for Apocalypse since the moment he set foot on Egyptian soil. Some part of him believes that by retaining control over one mutant, he can somehow draw in another.",
                ],
                Personality =
                [
                    "Logos was raised to have unquestioning loyalty to the pharaoh. However, Kang’s brutality has shaken his resolve. Logos remains committed to Kang’s service, and he treats any threats to the pharaoh’s well-being with deadly seriousness. However, he would be willing to assist an investigation into Kang’s true origins.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
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
            Name = "Madame Mask",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Leverage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Submachine gun"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Giuletta Kristina Nefaria",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Gray",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Scarred face beneath mask",
                Occupations = [OccupationName.Criminal, OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Maggia],
                Base = "Mobile",
                History =
                [
                    "As a baby, Giuletta Nefaria was discarded by her father Count Nefaria—the one-time leader of the Maggia. She spent her youth believing she was the daughter of a pair of wealthy Wall Street fi nanciers. It was only after the death of her adoptive parents that Luchino re-entered Giuletta’s life.",
                    "Sensing potential in the young woman, Luchino coerced his daughter into joining the Maggia. He gave her special training in combat and forced her to act as a Maggia spy under the codename of Madame Masque. Although she eventually separated herself from her toxic father, Giuletta has continued to work as a Maggia agent.",
                ],
                Personality =
                [
                    "Unlike a lot of mafiosos, Madame Masque is not driven primarily by greed. She works for the Maggia because it’s the only way she knows to make a sound living. A well-conceived moral argument could convince her to compromise her criminal ways.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Maddy Cho",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 0, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Madame Curie “Maddy” Cho",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [118],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.OlympusGroup],
                Base = "Mobile",
                History =
                [
                    "Despite having an intellect to rival the world’s top scientists, Maddy Cho spends most of her time acting as a caretaker for her younger brother Amadeus—the boy better known as Brawn. Maddy is one of the few people in the world who Amadeus truly respects. Her calm maturity helps to temper her brother’s fi ery and often unstable personality.",
                    "Maddy is, ostensibly, a student, but her vast intellect makes school a minimal concern. She spends most of her time either looking after her brother or working on some self-driven scientifi c project. She jumps at any opportunity to study mysterious scientifi c phenomena.",
                ],
                Personality =
                [
                    "Although she’s just a teenager herself, Maddy has a very serious personality. Since the death of their parents, she’s had to act more and more as a mother to her younger brother. Only on the rare occasions that she’s separated from Amadeus does Maddy relax her typically stern demeanor.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Maggia Tough",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 0, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pistols or clubs"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SpecialTraining],
                Teams = [],
                Base = "Varies",
                History =
                [
                    "Born out of European crime syndicates that date back centuries, the modern Maggia are less a singular entity and more a group of criminal families who occasionally aid one another. They have no hidden bases or Helicarriers. They’re a bunch of racketeers who scratch each other’s backs.",
                    "Unlike Hydra or other fanatical criminal organizations, Maggia toughs are motivated primarily by profi t, not political ideology. Their pursuit of money often leads them to commit heinous crimes and even bankroll super villains, but they can be persuaded down more righteous paths—for the right price.",
                ],
                Personality =
                [
                    "Many members of the Maggia are suit-wearing wiseguys. Most high-ranking members gain their status by being born into one crime family or another. Regular toughs, on the other hand, come from all sorts of places. New recruits tend to be poor youths with few scruples, folks happy to join up with a well-established criminal outfit.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline3),
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
                new CharacterPowerSet
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
                new CharacterPowerSet
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
            Name = "Mariah Hill",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
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
                        powerSelector.GetPower(PowerNames.Sniping),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Maria Hill",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.ForceWorks, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Having gotten a taste of action on a tour of duty with the US Marine Corps, a young Maria Hill joined up with S.H.I.E.L.D. the moment she was able. Her determination to succeed and her natural ability to make hard decisions propelled her through the ranks of the organization. Within a few years, she became the right hand of S.H.I.E.L.D. director Nick Fury Sr. Soon after, she replaced Fury.",
                    "Although supported by her subordinates, many of Hill’s actions as director of S.H.I.E.L.D. remain controversial. The foundation of Pleasant Hill— an artifi cial-town prison designed to reform super villains through brainwashing—caused an international outcry. For her role in overseeing that project, Hill was booted from S.H.I.E.L.D. The organization itself dissolved shortly thereafter.",
                    "Despite her notoriety, Hill has found a second life as an agent for the CIA. She is wholly committed to the cause of making the world a safer place for regular people."
                ],
                Personality =
                [
                    "Hill’s ability to make tough calls makes her a strong leader, but it’s also her greatest fl aw. Like many members of S.H.I.E.L.D., her knack for working within ethical gray areas gets her in trouble as often as it helps her succeed. If she can be convinced that doing so is for the greater good, Hill can steel herself to commit atrocious deeds.",
                    "Despite her headstrong and driven nature, Hill is not above cracking the occasional joke. Her social circle consists almost entirely of former S.H.I.E.L.D. agents."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
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
        new()
        {
            Name = "May Parker",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 0, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.OutOfShape),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Maybelle “May” Parker-Jameson",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [],
                Origins = [],
                Teams = ["Howard T. Duck Private Investigations, Uncle Ben Foundation"],
                Base = "NYC",
                History =
                [
                    "May Parker’s early life was, for the most part, unremarkable. She was born into a poor and religious family that placed a high value on decency and responsibility. As an adult, she began dating a carnival barker named Ben Parker.",
                    "Ben was just as poor as May, if not more so, but he was kind and thoughtful. May valued that more than any riches in the world. Unable to have children themselves, Ben and May devoted their energies toward helping out with their nephew, Peter Parker.",
                    "After Peter’s parents died in a tragic plane crash, he came to live with his aunt and uncle full-time. Ben and May treated Peter like their own son, which only made it all the more di¸ cult for the boy when, a few short years later, Ben was gunned down in a robbery.",
                    "Ben’s tragic death inspired Peter to become the world-renowned super hero Spider-Man. For many years Peter hid this fact from his aunt, but May eventually discovered her nephew’s secret identity. Although she was wary at fi rst, May has come to accept who Peter is and even appreciate his heroics.",
                    "At one point, she married J. Jonah Jameson’s father, Jay, but he has since passed away."
                ],
                Personality =
                [
                    "Although she’s getting up there in years, May Parker believes she can still take care of herself. She is a proud woman, and she resents the idea that she would need help with basic tasks. However, her increasingly ailing state has forced her, bit by bit, to accept more and more assistance.",
                    "May’s greatest fear is that she will become a burden on Peter, the one person on Earth who she cares the most about."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Medusa",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = $"{PowerSetNames.Plasticity}",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Medusalith Amaquelin-Boltagon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "Long, freely controllable hair",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.FantasticFour, TeamNames.HouseOfAgon, TeamNames.UniversalInhumans],
                Base = "Mobile",
                History =
                [
                    "Medusalith Amaquelin was born in the Inhuman city of Attilan into a family of royal nutritionists. As an infant, she was exposed to the Terrigen Mist and subsequently gained the power to control strands of her hair as if they were superstrong tendrils emerging from her head.",
                    "At a young age, Medusa developed close friendships with core members of the Inhuman Royal Family, particularly her second cousin, the Inhuman prince Black Bolt. Medusa later helped Black Bolt overthrow the cruel rulers of Attilan and establish himself as the king of all Inhumans.",
                    "As the years drew on, Medusa and Black Bolt grew closer and were married. Together, they’ve had one child, a boy named Ahura.",
                    "Following the tragic events wherein Black Bolt was forced to kill the bulk of the Inhuman population, Medusa and her husband began to grow apart. Although they remain close friends, they have functionally separated."
                ],
                Personality =
                [
                    "Medusa has exactly the personality one would expect of a powerful queen. She is headstrong, righteously vindictive and often a bit pompous. Her self-confi dence makes her an effective ruler and team leader, though in more interpersonal settings it can cause troubles.",
                    "Even more than Black Bolt, Medusa takes her role as an Inhuman leader with deadly seriousness. She is determined to live up to the title of queen, no matter the personal cost."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Mirage (Dani Moonstar)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 3, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "Grand Mirage"),
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
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Brightwind"),
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Mammals"),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
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
                RealName = "Danielle “Dani” Moonstar",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [123],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a teenager, Dani Moonstar discovered she had the ability to create powerful psychic illusions. When those illusions began to attack those closest to her, her grandfather—the shaman Black Eagle—asked Charles Xavier (Professor X) to train her in the use of her powers. Before Xavier could arrive, Black Eagle was assassinated by a madman bent on destroying mutantkind. As part of Xavier’s brand-new New Mutants team, Moonstar helped put an end to that madman’s plans.",
                    "For a while, Moonstar served as one of Asgard’s Valkyries, but today she lives on Krakoa, where she has joined a revived New Mutants team. She uses her powers to help other mutants process their trauma. Despite no longer being a Valkyrie, she still retains her bond with her Asgardian winged horse, Brightwind.",
                ],
                Personality =
                [
                    "Moonstar is a powerful and serious combatant, not the type to joke around during a mission. Away from battle, she is a highly intelligent and empathetic person. Her psychic abilities allow her to literally dig into the emotional problems of her teammates.",
                ]
            }
        },
        new()
        {
            Name = "Mister Fantastic",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 4, vigilance: 2, ego: 2, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "4 Yancy Street"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BodySphere),
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Reed Richards",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown, gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FantasticFour, TeamNames.FutureFoundation],
                Base = "New York City",
                History =
                [
                    "Brilliant young physicist Reed Richards gambled his family’s considerable fortune on an experimental space mission, during which he and his crew were bombarded by cosmic rays, giving them super-powers. Back on Earth, with Richards as their leader, the crew formed the Fantastic Four.",
                    "Richards’ intellect is just as critical a component of his heroism as his powers. With eighteen separate doctorates, he is arguably the most brilliant scientist on the planet. Richards later married one of the crew—Susan Storm (Invisible Woman)— with whom he has two kids, and nothing is more important to him than his family and friends.",
                ],
                Personality =
                [
                    "Richards’ intense and calculating nature occasionally puts him at odds with his more outwardly emotional teammates, but at heart, he is a humanitarian. He believes that science has the potential to solve all of humanity’s problems, and nothing frustrates him more than an unsolvable problem.",
                ]
            }
        },
        new()
        {
            Name = "Misty Knight",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 3, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
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
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Mercedes “Misty” Knight",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [136],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bionic arm",
                Occupations = [OccupationName.Investigator, OccupationName.LawEnforcer],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining],
                Teams = [TeamNames.AberrantCrimesDivisionOfTheFBI, TeamNames.DaughtersOfTheDragon, TeamNames.Defenders],
                Base = "Mobile",
                History =
                [
                    "Misty Knight was a talented rookie in the NYPD bomb squad—until the day her arm got blown off in the line of duty. Admiring the young woman’s heroism, billionaire Tony Stark personally commissioned a bionic arm to replace Knight’s lost limb.",
                    "Newly empowered, Knight quit her job with the NYPD and started a private detective agency called Nightwing Restorations. Her adventures as a private investigator have frequently brought her into the orbit of other heroes for hire, particularly Colleen Wing, Luke Cage and her longtime fl ame Danny Rand (Iron Fist)."
                ],
                Personality =
                [
                    "Although charming and coolheaded, Knight’s steadfast belief in the righteousness of the law sometimes leads her astray. She has little patience for those she believes to be criminals—and perhaps too much patience for those who claim to support the law. On more than one occasion, she’s hung up the title of P.I. to return to a career as a law enforcement officer.",
                ]
            }
        },
        new()
        {
            Name = "M.O.D.O.K.",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 0, agility: 2, resilience: 2, vigilance: 4, ego: 5, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
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
                    IsTech = true
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
                        powerSelector.GetPower(PowerNames.TelekineticSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "George Tarleton",
                Heights = [new() { Feet = 12 }],
                Weights = [750],
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Massive cranium",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [TeamNames.AIM, TeamNames.Intelligencia],
                Base = "Mobile",
                History =
                [
                    "A low-level lab technician at Advanced Idea Mechanics, George Tarleton was forced by his superiors to undergo a dangerous mutagenic experiment so they could create a being intelligent enough to study the newly fashioned Cosmic Cube. To that end, A.I.M. scientists radically enlarged George’s head and placed his now-frail body into a weaponized hover chair.",
                    "The mutated George immediately turned on and slaughtered his superiors. Dubbing himself M.O.D.O.K. (Mental Organism Designed Only for Killing), Tarleton took control of A.I.M. and set the organization to the task of sowing chaos everywhere."
                ],
                Personality =
                [
                    "Although a frequent ally of Hydra and the Red Skull, M.O.D.O.K.’s evil is born more out of madness and egomania than any political agenda. He only really enjoys himself while engaging in or plotting mass murder. On the rare occasions he isn’t killing, M.O.D.O.K. wears a perpetual sneer upon his face.",
                ]
            }
        },
        new()
        {
            Name = "Mocking Bird (Bobbi Morse)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Fighting batons (clubs)"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
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
                RealName = "Barbara “Bobbi” Morse",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD, TeamNames.WestCoastAvengers],
                Base = "Mobile",
                History =
                [
                    "As a young but up-and-coming name in the world of biological science, Bobbi Morse was recruited by S.H.I.E.L.D. to act both as an agent and an on-staff scientist. Under the codename Mockingbird, she fought to keep the world safe from all manners of nefarious threats.",
                    "Morse eventually left S.H.I.E.L.D. to become an independent adventurer. In the years since, she has been an invaluable member of countless super-hero teams. Most famously, she has been a regular partner to the hero Hawkeye, to whom she was briefl y married.",
                    "For a long while, she was thought to be dead, killed by Mephisto while she was on a mission with the West Coast Avengers. It turned out that she had been kidnapped and replaced with a Skrull impersonator who had died in her place."
                ],
                Personality =
                [
                    "Much like her ex-husband, Hawkeye (Clint Barton), years of adventuring have tempered Morse’s attitude toward danger. Threats that would have terrifi ed her in her early days now elicit little more than an eye roll or a pained groan from her. Her years terrorizing the Skrulls as the Robed Witch—while temporarily escaped on their home planet—contributed to that.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Moon Girl",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 0, vigilance: 2, ego: 2, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.Brilliance3}"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Devil Dinosaur"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.VisionIssues),
                tagSelector.GetTag(TagNames.Young),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Devil Dinosaur"),
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.InformationUpload),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lunella Louise Lafayette",
                Heights = [new() { Feet = 3, Inches = 9 }],
                Weights = [48],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Small,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist, OccupationName.Student],
                Origins = [OriginName.Inhuman],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "As a hyper-intelligent grade-schooler, Lunella Lafayette faced ridicule from her fellow students and even her teachers, all of whom were unable to comprehend the depths of her brilliance. Her life dragged on in a boring sort of way until the day she accidentally activated a portal to an alternate dimension.",
                    "From this portal emerged Devil Dinosaur, a highly intelligent red Tyrannosaurus rex. Lafayette and the dinosaur became fast friends and agreed to adventure together. Determined to explore the universe, Lafayette adopted the alter ego Moon Girl, reclaiming a name once thrown at her by schoolyard bullies."
                ],
                Personality =
                [
                    "Lafayette is a fun-loving kid with a strong sense of justice. She loves exploration and experimentation as much as she hates bullies. Lafayette will go far out of her way to stop people from pushing others around. The only bullies she has trouble standing up to are her own.",
                ]
            }
        },
        new()
        {
            Name = "Moon Knight",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 2, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Crescent-Darts (knife or thrown knife)"),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Truncheon (club)"),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Marc Spector",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Investigator, OccupationName.Military],
                Origins = [OriginName.Mythic],
                Teams = [TeamNames.Defenders, TeamNames.MidnightMission, TeamNames.MidnightSons],
                Base = "New York City",
                History =
                [
                    "Brutally beaten by his superiors for attempting to save the life of an innocent young woman, mercenary Marc Spector was left for dead in the Egyptian desert. Unconscious, Spector’s spirit was visited by Khonshu, the ancient Egyptian god of the moon, who struck a deal with the dying man. In exchange for entering into the lunar deity’s benevolent service, Khonshu saved Spector’s life and granted him divine powers. Donning a white costume, Spector declared himself Moon Knight and set out on a quest to make up for his muddled past as a mercenary.",
                ],
                Personality =
                [
                    "On account of being partially possessed by a god, Spector suffers from a condition similar to dissociative identity disorder. His main alter egos are cabbie Jake Lockley and fi nancier Steven Grant. While Spector is a decent guy who regrets his life as a mercenary and wishes to atone for his actions, he is sometimes motivated—at least partially by Khonshu (or the version of Khonshu in his head)—to use extreme methods as Moon Knight.",
                ]
            }
        },
        new()
        {
            Name = "Morbius",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 1, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.LeechLife),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Michael Morbius",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Pale skin, fangs, retractable claws",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.MidnightSons, TeamNames.LegionOfMonsters],
                Base = "Mobile",
                History =
                [
                    "In a desperate bid to save himself from a terminal blood condition, Dr. Michael Morbius subjected himself to an experimental treatment using vampire bat DNA. The treatment saved Morbius’ life but transformed him into a hideous vampire. Horrified by his insatiable lust for blood, Morbius attempted to throw himself into the sea only to discover that his new form was seemingly unkillable. Forced to live, Morbius embarked on a blood-fueled rampage across New York.",
                    "In the years since, Morbius has found temporary cures for his condition, but he lives in constant fear of reverting into a bloodsucking monster.",
                ],
                Personality =
                [
                    "Highly eloquent and intelligent, Morbius still cares for those he left behind in his human life. In his more lucid moments, he does his best to redirect his feeding instincts toward violent criminals, particularly those who would do his loved ones harm.",
                ]
            }
        },
        new()
        {
            Name = "Ms. Marvel (Kamala Khan)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 4, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain Marvel (Carol Danvers)"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Young),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Disguise),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Kamala Khan",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.Champions, TeamNames.Protectors],
                Base = "Jersey City",
                History =
                [
                    "From a young age, Kamala Khan idolized Captain Marvel (Carol Danvers), who exemplifi ed a sort of uncomplicated femininity missing from Khan’s own life as the teenage daughter of Pakistani immigrants. One night, while sneaking out of her parents’ house to go to a party, Khan was exposed to a mysterious cloud of Terrigen Mist that activated the Inhuman DNA lurking in her system, giving her the power to grow, shrink and morph into whatever shape or appearance she pleased.",
                    "Donning a costume of her own, Khan adopted Carol Danvers’ former alias and became the new Ms. Marvel. In short order, she met her idol Carol and even joined the Avengers, but she later left them to form the new teenage Champions.",
                ],
                Personality =
                [
                    "Khan is a lovable and friendly nerd and a natural leader. She’s also a teenager still trying to fi gure out the specifi cs of who she is, but she’s gradually becoming more confident in herself and her identity.",
                ]
            }
        },
        new()
        {
            Name = "Mysterio (Quentin Beck)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 1, vigilance: 2, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "(2) Grand Illusion, Mirror Images"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimatedIllusion),
                        powerSelector.GetPower(PowerNames.Dazzle),
                        powerSelector.GetPower(PowerNames.GrandIllusion),
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.MirrorImages),
                        powerSelector.GetPower(PowerNames.StaticIllusion),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Quentin Beck",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "A special effects designer of extraordinary skill, Quentin Beck grew frustrated with the lack of recognition he received from the public. Feeling that his expertise could be put to more profi table uses, he assumed the title of Mysterio, master illusionist, and began a life of crime.",
                    "Unfortunately, all of Mysterio’s earliest schemes were foiled by Spider-Man (Peter Parker), and his plans gradually became less about profi t and more about revenge. He has appeared to have been killed numerous times—and others have sometimes temporarily taken his place—but he has always managed to return from the grave."
                ],
                Personality =
                [
                    "Mysterio has an undying flair for the theatrical. Rather than attacking his enemies directly, he prefers to trick them into hurting themselves, or otherwise gaslight them into insanity. Years of media coverage have only heightened his delusions of grandeur. He might be persuaded to give up crime if he could be assured that he would still be famous.",
                ]
            }
        },
        new()
        {
            Name = "Mystique",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 2, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in true form"),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Czech, English, Farsi, French, German, Korean, Portuguese, Spanish, Swedish"),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Raven Darkhölme",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "Her true form has blue skin and yellow eyes",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.HellfireClub, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "No one, save perhaps Raven Darkhölme herself, knows the true origins of Mystique. She has existed in some form or another for well over a hundred years. Before the turn of the previous century, she worked extensively with the precognitive mutant Irene Adler, who later became Destiny—and her wife.",
                    "In modern times, Mystique fi rst surfaced as a minor member of the Brotherhood of Evil Mutants, but circumstances quickly forced her to switch sides and join the X-Men. In the years since, she’s regularly fl ip-fl opped, sometimes working as a hero and other times as a villain. Her shape-shifting powers make her a perfect spy or double agent."
                ],
                Personality =
                [
                    "Mystique’s abnormally long life has granted her a world-weary coolheadedness her younger teammates could never achieve. Unfortunately, her jaded instincts frequently drive her down the path to villainy. She is happy to ignore ethics if she believes that doing so is for the betterment of mutants.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersN() =>
    [
        new()
        {
            Name = "Nebula",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 4, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Sniping),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Nebula",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [185],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Blue and purple skin, cyborg",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Graces],
                Base = "Mobile",
                History =
                [
                    "As the daughter of Zorr the Conqueror (a Luphomoid warlord) and the granddaughter of Thanos, Nebula was always destined for battle. Thanos raised her alongside her adopted sister, Gamora, who was clearly Thanos’ favorite. When she set out on her own as a conqueror, she destroyed the planet Xandar, home of the Nova Corps. She later thwarted Thanos’ plan to kill all living creatures in the universe, but she suffered such horrible injuries that much of her body had to be replaced with cybernetics. This includes a cybernetic eye and a cybernetic arm that fi res energy bursts.",
                    "Nebula’s hatred for Gamora knows few bounds. Given the chance, she would kill her sister in a heartbeat, and she has tried to do so many times. So far, she hasn’t managed to succeed, but their rivalry seems doomed to end in one of their deaths.",
                ],
                Personality =
                [
                    "Nebula is cold-hearted, manipulative and murderous. She has no qualms about destroying entire planets to get what she wants, but she also knows that most things require a more delicate touch. She can be as brutal with her words as she is with her weapons.",
                ]
            }
        },
        new()
        {
            Name = "Nick Fury Jr.",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 2, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
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
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Nicholas Joseph “Nick” Fury Jr.",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Eyepatch covers a lost left eye",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.CIA, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Born of a secret love affair between spies Nick Fury and Nia Jones, Marcus Johnson spent his youth not knowing who his father was. Imbued from birth with strength and vitality beyond the human norm, Johnson made a name for himself as an elite soldier. In time, heinous villains discovered Johnson’s parentage and began targeting him for the Infi nity Formula lurking in his blood, but with the help of S.H.I.E.L.D. operatives— including his own father—Johnson fought off his pursuers.",
                    "Adopting the name of Nick Fury Jr., he followed in his heroic father’s footsteps and became an agent of S.H.I.E.L.D. With the dissolution of that organization, he retreated to the shadows, where he works to save humanity as a freelance spy, an agent of nothing.",
                ],
                Personality =
                [
                    "Years of combat have molded Nick Fury Jr. into a steel-headed, no-nonsense operator. However, he is not above cracking a joke or two while on the job.",
                ]
            }
        },
        new()
        {
            Name = "Nick Fury Sr.",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Nicholas Joseph “Nick” Fury Sr.",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [221],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald, formerly brown",
                Size = Size.Average,
                DistinguishingFeatures = "Eye patch, various scars",
                Occupations = [OccupationName.Adventurer, OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.CIA, TeamNames.SHIELD, TeamNames.HowlingCommandos],
                Base = "Mobile",
                History =
                [
                    "As a stringent anti-fascist, Fury was among the fi rst in his neighborhood to join the fi ght against the Axis Powers during World War II. He soon became a sergeant and was eventually appointed to lead a covert attack squadron of “Howling Commandos” through the European theater.",
                    "Late in the war, Fury took a stray piece of shrapnel to the face. The injury permanently blinded him in one eye and left him on the edge of death. To save his life, government scientists injected him with the experimental Infi nity Formula. Miraculously, Fury made a quick recovery and fi nished out the war in style.",
                    "Shortly thereafter, Fury was tapped to lead the newly established UN peacekeeping force S.H.I.E.L.D. His run as the organization’s director remains legendary.",
                    "Fury later left S.H.I.E.L.D. but continued working on his own to keep the world safe, no matter the costs. He recently took over for the Watcher (Uatu) as the one keeping watch over the Earth, but he’s since moved on to helping protect the entirety of the Multiverse."
                ],
                Personality =
                [
                    "The serum in Nick Fury’s blood slows his aging to a crawl. This has allowed him to act as a hero across several decades, but it has not kept him from being stuck in the past.",
                    "Nick Fury is, by most modern standards, a conservative old grump. He left Earth behind, in large part, because he was looking for new challenges."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Night Nurse",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 1, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FirstAid),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Iron Man's gloves (Elemental Burst: Energy)"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Integrity),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Linda Carter",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.HealthCareWorker],
                Origins = [OriginName.SpecialTraining],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "After being rescued by a costumed super hero, registered nurse Linda Carter decided to dedicate her medical talents to treating heroes who wished to keep their identities secret. To do so, she took on a secret identity of her own, calling herself the Night Nurse. She has helped numerous heroes over the years, including Captain America (Steve Rogers), Daredevil (Matt Murdock), Firestar, Iron Fist (Danny Rand), Luke Cage and Spider-Man (Peter Parker). She even dated Doctor Strange and Hawkeye (Clint Barton) in the past.",
                    "In an effort to be more effective in her relatively unique position, Carter went back to school and obtained her medical degree to become a general practitioner. Despite that, she continues to use the codename Night Nurse. Her original clinic burned down, but she reopened in Chinatown.",
                ],
                Personality =
                [
                    "Carter is a dedicated doctor who cares deeply for her patients. She knows that she may be the only recourse many of them have for getting actual medical treatment without blowing their secret identities. Because this requires a deep level of trust, she takes their privacy as seriously as she takes her Hippocratic Oath.",
                ]
            }
        },
        new()
        {
            Name = "Nightcrawler",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 2, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Sneaky),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, German, Japanese, Russian, Spanish"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.BlinkBarrage),
                        powerSelector.GetPower(PowerNames.BlinkDefense),
                        powerSelector.GetPower(PowerNames.Teleport1),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Kurt Wagner",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [161],
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "Blue",
                Size = Size.Average,
                DistinguishingFeatures = "Mutant with demonic appearance",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Abandoned in the Alps by his mutant parents, the future Nightcrawler was adopted by traveling Romani performers. His incredible agility and bizarre appearance made him a star circus performer. Sadly, this life did not last. He was on the verge of being burned at the stake by an angry mob when psychic Professor X intervened and saved his life.",
                    "The grateful Nightcrawler agreed to become a part of the X-Men, and he’s been a hero to the mutant community ever since. He was one of the fi rst to join the new mutant government in Krakoa."
                ],
                Personality =
                [
                    "Kurt Wagner numbers among the kindest and most heroic people ever to join the X-Men. Despite having long left the circus behind, he’s never lost his carnie spirit and fights his battles with a smile on his face. A highly religious man, Nightcrawler acts as a spiritual and moral guide to his fellow mutants.",
                ]
            }
        },
        new()
        {
            Name = "Nighthawk (Kyle Richmond)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 3, vigilance: 3, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Sunlight (Nighthawk loses his damage reduction during the day)"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                RealName = "Kyle Richmond",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.HighTech, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.Defenders, TeamNames.SquadronSinister],
                Base = "NYC",
                History =
                [
                    "Kyle Richmond was once just a scrawny, spoiled college kid who believed that his family’s wealth could get him out of any jam. Then he got into a drunk driving accident that lefthim badly injured and—worse yet—confi ned his girlfriend to a wheelchair. Racked with guilt, Richmond dropped out of school and spent the next few years wandering around the United States, looking for something that could bring meaning back into his life.",
                    "An interdimensional being known as the Grandmaster took note of Richmond’s plight. In exchange for Richmond helping found a team of super villains, the Grandmaster offered him a serum that made him superhumanly powerful whenever the moon shone.",
                    "Richmond accepted the serum, but his conscience eventually got the better of him. Within a few months, he turned against his own super-villain team. In the years since, Richmond has done his best to earn the trust of the super-hero community and has served as a member of both the Avengers and the Defenders.",
                ],
                Personality =
                [
                    "Kyle Richmond’s childhood as a lonely rich kid led him to a life of excessive thrill-seeking. However, years of adventuring have shaped his youthful hotheadedness into a more balanced vigilance. The missteps of his past weigh heavily upon his mind.",
                    "Nighthawk’s ability to fly comes not from his innate superhuman strength, but from a custom jetpack he designed."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Nova (Rich Rider)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 4, vigilance: 3, ego: 7, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Nova form"),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                        powerSelector.GetPower(PowerNames.Wisdom),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Richard “Rich” Rider",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.NovaCorps],
                Base = "Mobile",
                History =
                [
                    "Many years ago, on the planet Xandar, a group of scientists tapped into a mysterious source of incredible power. They dubbed it the Nova Force and decided to imbue their most brilliant citizens with it. These brave explorers dedicated themselves to the betterment of the galaxy, forming the fi rst Nova Corps.",
                    "Then came the day Zorr the Conqueror arrived on Xandar and slaughtered nearly the entire planet. Only a single, mortally wounded Nova Centurion escaped.",
                    "This dying warrior used the last of his power to send the entirety of the Nova Force to Earth, where it inhabited a scrawny teenager named Richard Rider.",
                    "Under the codename Nova, Rider has defeated countless cosmic threats, some on the level of Thanos himself. As he matured, he became more of a leader, even heading up the Guardians of the Galaxy for a while and—on a couple occasions— rebuilding the entire Nova Corps from scratch."
                ],
                Personality =
                [
                    "In his early adventures, Nova was a bit of a jokester, imitating the likes of other teenage heroes. Only after years of battle did he start to develop an identity for himself.",
                    "Today, Nova isn’t humorless, but he is experienced enough to project a level of gravitas that was unavailable to him in his youth. He takes his role as a protector of the innocent seriously and is haunted by those he could not save."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
    ];

    private List<Character> GetAllCharactersO() =>
    [
        new()
        {
            Name = "Okoye",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 2, vigilance: 1, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Dora Milaje)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup, reminder: "Dora Milaje"),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Okoye",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Wakandan tribal tattoos",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.DoraMilaje],
                Base = "Wakanda",
                History =
                [
                    "Renowned for her capabilities as a warrior, Okoye was personally selected by the Black Panther (T’Challa) to be the head of his personal guard: the Dora Milaje. There is no one among the Dora Milaje who the Panther trusts more than Okoye. She assists him in nearly all of his heroic exploits, and she has personally put down rebellions against his government.",
                    "Due to her skills and her loyalty, Okoye helped found and became the director of the Agents of Wakanda, a team of heroes organized to support the Avengers during the Black Panther’s time as their leader.",
                ],
                Personality =
                [
                    "As a seasoned warrior, Okoye isn’t the type for small talk. As a bodyguard, she spends much of her time silently standing behind the Panther, looking intimidating. When battle inevitably breaks out, she focuses on communicating her orders clearly and effectively. She’s not above a rare bit of humor, but her jokes tend to be on the dry side.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersP() =>
    [
        new()
        {
            Name = "Paladin",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 2, ego: 3, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mysterious),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Stun gun [ranged weapon; deals electricity damage, stunning target on a Fantastic success]"),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.HeroesForHire, TeamNames.VillainsForHire],
                Base = "Mobile",
                History =
                [
                    "Paladin’s past is a secret to everyone except maybe the man himself, and he isn’t forthcoming with details. S.H.I.E.L.D.’s archives on Paladin date back only as far as a few years ago when, during a mission to capture the Purple Man, he fought with Daredevil. Although Paladin was already a moderately well-established mercenary by this point, no one knows for sure what jobs he had completed before facing off against the Man Without Fear.",
                    "Although Paladin ultimately failed to capture the Purple Man, his ability to hold his own against Daredevil made him famous overnight. Job offers came pouring in, from both super heroes and super villains.",
                    "For a while, Paladin sold his services exclusively to the highest bidder. Some days he was a hero, and other days he was a villain. He is one of the few people who can truthfully claim to have fought on both sides of the superhuman Civil War.",
                    "As the years drew on, though, Paladin’s duplicitousness began to gnaw at his conscience. There was no single moment of reform and repentance, but slowly, he stopped accepting villainous jobs. These days, he works primarily as an independent hero for hire."
                ],
                Personality =
                [
                    "Ninety percent amoral mercenary and ten percent big-hearted softy, Paladin has a strangely charming aura. He’s had a number of romantic relationships within the super-hero community, most notably with the Wasp. Even his enemies regard him as a gentleman and a consummate professional.",
                    "Paladin’s need to make money exists in perpetual confl ict with his conscience. He has, on several occasions, dropped well-paying assassination jobs at the last moment because he couldn’t bear to kill his target."
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Patriot (Rayshaun Lucas)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 1, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Falcon (Sam Wilson)"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Young),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            glideSpeed: true,
                            specialization: "Patriot’s Shield. Grants Glide Speed equal to double his Run Speed. Also acts as a drone that can move within his line of sight and fire energy blasts with a range of 10."),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Shield2),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Rayshaun “Shaun” Lucas",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.Champions],
                Base = "NYC",
                History =
                [
                    "As a young teenager, Rayshaun Lucas was an active participant in the protests that followed the wrongful arrest of the super hero Rage. The connections he made during those protests led him further into the world of super heroes, and during the rise of Hydra’s plot to take over the USA with the help of a twisted version of Captain America (Steve Rogers), he helped provide vital intel to the resistance.",
                    "The leaders of the resistance later rewarded Lucas for his noble efforts. Iron Man built him a hightech shield based on Lucas’ own designs, and the Falcon (Sam Wilson) took him on as a super-heroin- training. Ever since, Lucas has fought crime and injustice—often alongside the Champions— under the codename Patriot.",
                    "Lucas is the latest hero by the name Patriot. The original was Jeffrey Mace, who became a replacement Captain America in the late 1940s. More recently was Elijah Bradley, a member of the Young Avengers, who has since given up the codename."
                ],
                Personality =
                [
                    "Lucas is young and inexperienced in battle, but he has an unfl inching sense of justice that transcends the law. He refuses to let any authority stand between him and doing the right thing.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Phoenix",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 5, vigilance: 4, ego: 8, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AuditoryIssues),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
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
                new CharacterPowerSet
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
                Origins = [OriginName.Mythic, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.DaughtersOfLiberty],
                Base = "Mobile",
                History =
                [
                    "When Maya Lopez was a child, her father was gunned down by his own boss: the Kingpin (Wilson Fisk). Seeing the young girl’s potential, Fisk took her in, giving her special training and eventually tricking her into believing that Daredevil had killed her father.",
                    "Eventually, Lopez discovered the Kingpin’s deception and turned on him. Her quest for vengeance resolved, she became a tireless fi ghter for justice around the world. Under the codename Echo, she fought to keep the streets of Hell’s Kitchen safe.",
                    "Recently, Echo took part in a contest held by the Phoenix Force, a primordial entity of fire and instability older than the universe itself. The Phoenix Force gathered heroes from around the globe and pitted them against each other to determine who would best serve as a host for its unfathomable power.",
                    "Echo lost her bout to the Sub-Mariner (Namor). However, the Phoenix Force admired Echo’s unflinching determination in battle and decided to take her as its host anyway. With the power of the Phoenix Force within her, Maya Lopez has quickly advanced from a neighborhood vigilante to a defender of entire worlds."
                ],
                Personality =
                [
                    "As a deaf woman and a member of the Cheyenne Nation, Lopez’s life has been full of struggles. Despite it all, she generally manages to stay upbeat. She has a particular love for the theatrical arts, having become a concert pianist and an expert dancer.",
                    "The Phoenix Force has, at times, threatened to turn Lopez into an unstoppable berserker. However, her strong sense of right and wrong helps her keep the primordial entity under control."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Photon (Monica Rambeau)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 5, resilience: 4, vigilance: 4, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
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
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Monica Rambeau",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.Thunderbolts, TeamNames.Ultimates],
                Base = "Mobile",
                History =
                [
                    "Monica Rambeau was a lieutenant with the New Orleans Harbor Patrol when she stumbled upon an experimental energy weapon hidden aboard a Roxxon oil rig. In the process of destroying the weapon, her body was bathed in extradimensional energy, giving her the power to transform her body into powerful forms of electromagnetic radiation. Embracing her new abilities, Rambeau quit her job and became the new Captain Marvel. She’s since gone by a number of aliases, including Photon, Pulsar and Spectrum, but she’s recently returned to Photon.",
                    "Rambeau has often been a part of the Avengers and has even led the team. Her powers and her leadership skills put her in high demand.",
                ],
                Personality =
                [
                    "Although generally agreeable, Rambeau has a short fuse when it comes to people messing with her. She knows her abilities make her one of the most powerful people in the universe, and she expects to be treated as such. She does not suffer condescension or discrimination from anyone.",
                ]
            }
        },
        new()
        {
            Name = "Piledriver (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 2, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Supernatural),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Brian Phillip Calusky",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [310],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Giant hands",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "As a teenager in the countryside, Brian Calusky turned to a life of crime more out of boredom than anything else. Calusky’s initial infractions were minor, but over the course of a decade, he managed to build himself a solid rap sheet. Eventually, he was sentenced to an extended stay in the maximum-security prison on Ryker’s Island.",
                    "It was at Ryker’s that Calusky met the super villain Wrecker. Along with a couple other inmates, Calusky helped the Wrecker escape from Ryker’s. Out of gratitude, the Wrecker granted his allies a portion of his own powers, and together, they formed the Wrecking Crew.",
                    "Calusky has been with the super-villain group ever since. At one point, he mentored his son, Rick Calusky, who become the criminal known as Excavator."
                ],
                Personality =
                [
                    "Outside of the Wrecker himself, Piledriver might be the most unhinged member of the Wrecking Crew. He can be utterly reckless, both in a battle and outside of it. Unlike his allies, Piledriver prefers to fi ght without weapons or armor, smashing his opponents with his giant bare fists.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Professor X (Charles Xavier)",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 2, vigilance: 9, ego: 9, logic: 9
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.CloakGroup),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.GrandFool),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.InformationUpload),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                        powerSelector.GetPower(PowerNames.TelepathicPossession),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Charles Francis Xavier",
                Heights = [new() { Feet = 6 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Educator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a mutant, Charles Xavier was gifted with powerful psychic abilities. Although he hid his own status as a mutant in his youth, Xavier decided to become an activist for mutant rights. He turned his old family mansion into a School for Gifted Youngsters and began recruiting young mutants across the globe.",
                    "It was within this school that Xavier founded the X-Men, a team of mutant heroes dedicated to showing the world just how helpful mutants can be. He later went on to expand the school and the number of mutant hero teams. He recently helped found a mutant homeland on the living island of Krakoa.",
                ],
                Personality =
                [
                    "Xavier’s greatest flaw is paternalism. He has the well-earned right to feel pride for his accomplishments, but his belief that he knows best leads him to occasionally make decisions for other people rather than leaving them to their own devices.",
                ]
            }
        },
        new()
        {
            Name = "Psylocke (Kwannon)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: $"{PowerNames.MentalPunch}"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MentalPunch),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Kwannon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [155],
                Gender = Gender.Female,
                Eyes = "Purple",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Marauders, TeamNames.TheHand, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Kwannon was raised from birth by the shadowy Hand organization to become a super-powered assassin, but she balked at the cold-blooded murder of innocents. It wasn’t long before she turned against her handlers, slaughtering them and escaping to Japan.",
                    "Shortly thereafter, Kwannon suffered an accident that left her comatose. While she slept, Betsy Braddock—another mutant psychic on the verge of death—swapped bodies with Kwannon. Only recently did Kwannon manage to regain control over her own body. In the short career she’s had since, she has already proven herself as a capable leader among the X-Men.",
                ],
                Personality =
                [
                    "Although the traumatic events of her past have filled Kwannon with some deep-seated anger and resentment, she retains a cool head for battle. She’s an effective tactical leader, and she’s well trained in focusing her fury at those who most deserve it.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersQ() =>
    [
        new()
        {
            Name = "Quasar",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 4, vigilance: 6, ego: 8, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Wendell Elvis Vaughn",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "As a young man, Wendell Vaughn successfully completed the special-agent training course at S.H.I.E.L.D. Academy only to be rejected for fi eld duty by higher-ups who believed he was too kind and caring to be a serious agent. Instead, Vaughn was assigned to guard duty outside the containment chamber of the legendary Quantum Bands, mystic artifacts designed to protect life throughout the universe. These bands contain such incredible power that they annihilated most people who attempted to wield them.",
                    "Vaughn performed his duties diligently until the day an A.I.M. attack overran the base where he was stationed. Desperate to escape the slaughter, Vaughn took a chance and donned the Quantum Bands. Incredibly, the kindness in his heart soothed the cosmic energies within the bands and transformed him into Quasar, Protector of the Universe.",
                    "As Quasar, Vaughn has achieved things beyond his wildest dreams and gone places S.H.I.E.L.D. could never have taken him. He has helped to end galaxy-spanning wars and fought with evil creatures the size of planets. Today, he numbers among the most powerful heroes in existence."
                ],
                Personality =
                [
                    "Quasar wields phenomenal power, but he prefers to solve his problems peacefully whenever possible. He treats defeated enemies gracefully, with an eye toward reform. On at least one occasion, Quasar has faked his own death to peacefully satisfy a vengeful opponent.",
                    "If Quasar has a flaw, it is his tendency to defer to established authority. He has assisted in many of S.H.I.E.L.D.’s operations, not all of them strictly ethical."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Quicksilver",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 7, resilience: 3, vigilance: 4, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.InstantReplay),
                        powerSelector.GetPower(PowerNames.TimeOut),
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
                        powerSelector.GetPower(PowerNames.RunOnWater),
                        powerSelector.GetPower(PowerNames.SpeedBlast),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Pietro Django Maximoff",
                Heights = [new() { Feet = 6 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Silver",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.BrotherhoodOfEvilMutants, TeamNames.XFactor],
                Base = "Mobile",
                History =
                [
                    "As infants, Pietro Maximoff and his twin sister, Wanda, were subjected to dangerous experiments, and as they aged, they began to exhibit strange powers. Pietro developed superhuman speed, while Wanda developed powerful magic. Superstitious villagers were about to kill the twins when Magneto saved them and invited them to join his Brotherhood of Evil Mutants as Quicksilver and the Scarlet Witch.",
                    "The twins later renounced such evil and became early members of the Avengers. Like the Scarlet Witch, Quicksilver is a hero at heart. He cares deeply for his sister and is ready to give his life to defend her, and he considers his work as a hero a form of atonement for the years he spent living as a terrorist.",
                ],
                Personality =
                [
                    "Due to his powers, Quicksilver is often impatient with others to the point of condescension, and he can come across as humorless. When he’s able to cut loose, though, he smiles with joy.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersR() =>
    [
        new()
        {
            Name = "Rama-Tut",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 4, ego: 4, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Disguise, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimePortal),
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelOther),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Nathaniel Richards",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Anachronauts, TeamNames.CouncilOfKangs],
                Base = "Ancient Egypt",
                History =
                [
                    "Nathaniel Richards grew up in the near-utopian environment of the 30th century of Earth-6311. As an adult, he became sick of luxury and became determined to live a life of adventure in a more interesting era.",
                    "Disguising himself as the Pharaoh Rama-Tut, Richards built a time machine and set about conquering ancient Egypt. As the supreme ruler of Egyptian civilization, Richards sought to secure his reign over all the Earth. As such, he is constantly on the lookout for any who may have the power to oppose him, particularly the mutant conqueror known as Apocalypse.",
                    "He does not yet know it, but Apocalypse will be the least of his worries. He later takes on a number of other identities, the most famous of which is Kang the Conqueror.",
                ],
                Personality =
                [
                    "Richards is a megalomaniac and a narcissist of the highest order. He believes himself to be the most important being in existence, and he will go to any length to prove his own importance. He often speaks in the style of the old Greco-Roman conquerors.",
                    "Richards is not above meddling in anyone’s timeline, even his own. As a result, his early life has become shrouded in mystery and divergence. A number of alternate versions of him from across the Multiverse have had adventuring careers to rival Richards’ own."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Red Skull (Johann Shmidt)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 1, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Johann Shmidt",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [189],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Head is disfigured into a red skull",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "Declaring that he could turn anyone into the ideal Nazi soldier, Adolf Hitler selected a random bellboy by the name of Johann Shmidt to be his next secret agent. He personally trained Shmidt to be a killer and spy, transforming him into one of the deadliest soldiers in the Third Reich.",
                    "After World War II, the crimson-faced Shmidt carried the mad führer’s dream of a worldwide Nazi government into the modern age. Were he not so dangerous, it would be easy to write him off as a cackling madman. A regular ally or even commander of fascist organizations like Hydra, he’s capable of launching complex schemes that threaten to bring the entire planet beneath his heel.",
                ],
                Personality =
                [
                    "In his day-to-day interactions with others, the Red Skull shows himself to be little more than a fascist zealot and a madman. Despite this, he is an expert propagandist who deftly recruits crowds of bigots.",
                ]
            }
        },
        new()
        {
            Name = "Red Wolf",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 1, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.AnimalCommunication}"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Wolves"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Red Wolf",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.SantaRosaSheriffsDepartment],
                Base = "Mobile",
                History =
                [
                    "Red Wolf was born to a community of Cheyenne natives in the old west of an alternate universe (Earth-51920). As a young man, he was sent to destroy a dam in Timely, a settler community that was diverting water from Cheyenne lands. Red Wolf made a deal with the townsfolk of Timely: in exchange for the destruction of their dam, he would take down their corrupt mayor, Wilson Fisk. With the help of some locals, Red Wolf killed Fisk and became the town’s sheriff.",
                    "Sometime later, Red Wolf fought a time-traveling super villain and wound up in the present day of Earth-616, where he has worked alongside Hawkeye (Clint Barton) and other heroes to help fi ght injustice.",
                ],
                Personality =
                [
                    "Red Wolf has a deep and abiding love for the communities he protects. While he enjoys his time in what he thinks of as the future—and especially the relationships he’s made there—he still wishes to return home.",
                ]
            }
        },
        new()
        {
            Name = "Ren Kimura",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        
                        powerSelector.GetPower(PowerNames.IconicWeapon, 
                            specialization: "Razor arms [hands act as melee weapons; +1 Melee damage multiplier]",
                            meleeDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ren Kimura",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [122],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.AsgardiansOfTheGalaxy, TeamNames.FearlessDefenders],
                Base = "New York City",
                History =
                [
                    "Growing up, Ren Kimura wanted to be a dancer. Unfortunately, her parents never approved of her aspirations or—for that matter—her homosexuality. She was forced to take up dancing (and dating) in secret, regularly sneaking away from home to spend long hours practicing at a local dance studio.",
                    "Because of this, Kimura was at the dance studio—not safe at home— when the Terrigen Bomb detonated over New York City. The Terrigen Mist activated the Inhuman DNA lurking inside her genes, transforming her arms into twisted masses of metal wire. With effort, Kimura discovered that she could make the wires float through the air like dancing ribbons, able to slice distant targets to pieces.",
                    "That night, super villains invaded New York City, looking to kidnap the newly awakened Inhumans. Kimura would have fallen prey to them were it not for the intervention of the Fearless Defenders.",
                    "Kimura joined the Defenders and fell deeply in love with one of her new teammates: Annabelle Riggs. Even after the Defenders fell apart, Riggs and Kimura stuck together. They became part of the Asgardians of the Galaxy, and later, Riggs helped Kimura form her own dance studio. Although they’ve officially retired from the adventuring business, they remain ready to answer any call to action."
                ],
                Personality =
                [
                    "Despite their mutual affection, Riggs and Kimura have diametrically opposed personalities. Riggs is bookish, shy and more than a little awkward, while Kimura is as outgoing and charming as a person can be. She adores the stage and the spotlight.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Reptil",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 5, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Dinosaur Forms"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Vicente Lopez"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Family"),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink2),
                    ],
                    IsTech = true
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
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Humberto “Berto” Lopez",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [142],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Dinosaur tail and limbs (when using powers)",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechPymParticles, OriginName.Magic],
                Teams = [TeamNames.AvengersAcademy],
                Base = "Los Angeles",
                History =
                [
                    "While out at a dig site with his paleontologist parents, Humberto Lopez stumbled upon a mystical fossilized amulet that gave him the power to shape-shift into prehistoric creatures, particularly dinosaurs. As a lifelong fan of super heroes, he leaped at this opportunity to become a hero himself, adopting the codename Reptil.",
                    "Shortly after Reptil began adventuring, his parents mysteriously disappeared. While he continued to search for them, he joined the Avengers Academy and became good friends with many of his fellow students. Although the academy is no more, he continues to do his best to help those in need.",
                ],
                Personality =
                [
                    "Reptil loves adventure, but he fears his own powers as much as he appreciates them. His reptilian transformations can occasionally send him into a berserker state, where he has little more reasoning power than a T. rex. He fears the possibility of accidentally lashing out at those closest to him.",
                ]
            }
        },
        new()
        {
            Name = "Rocket Racoon",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 4, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "2 Pistols"),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Rifle"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DanceOfDeath),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
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
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.FocusFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Rocket",
                Heights = [new() { Feet = 4 }],
                Weights = [55],
                Gender = Gender.Male,
                Eyes = "Brown (with tapetal reflection)",
                Hair = "Brown, black and white",
                Size = Size.Small,
                DistinguishingFeatures = "Raccoon-like alien",
                Occupations = [OccupationName.Criminal, OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Avengers, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Rocket is a genetically and cybernetically engineered extraterrestrial created to resemble an Earth raccoon and to work as one of the protectors of the Loonies, a group of criminally insane aliens sentenced to life on the prison planet Halfworld in the Keystone Quadrant. After leaving his position, Rocket made his way into the wider galaxy, where he wound up involved in questionable activities that landed him in a Kree prison. There, he met his best friend, Groot, and together, they helped form the Guardians of the Galaxy.",
                    "With the rest of the Guardians, Rocket saved the galaxy from being destroyed by the alien hive fl eet known as the Phalanx. After that, they decided to band together permanently, becoming a family as much as a team. Rocket has even stepped up to lead the team when Star-Lord wasn’t available.",
                ],
                Personality =
                [
                    "Rocket is sharp and conniving, one of the smartest people around, especially when it comes to tactics and logistics. He carries larceny in his heart and is always looking for a better angle on any problem that presents itself.",
                ]
            }
        },
        new()
        {
            Name = "Ronan the Accuser",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 4, vigilance: 2, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.BreatheDifferent),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Ronan",
                Heights = [new() { Feet = 7, Inches = 5 }],
                Weights = [480],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Blue skin",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.AlienKree],
                Teams = [TeamNames.KreeEmpire],
                Base = "Kree-Lar",
                History =
                [
                    "A powerful warrior, Ronan rose through the ranks of the Kree military, eventually achieving the position of Supreme Accuser. Second only to the Emperor himself, Ronan was in charge of overseeing all Kree military operations.",
                    "Ronan has battled some of the deadliest warriors in the galaxy and personally led invasions of Earth, the Skrull Empire and the Inhuman homeland. After a coup resulted in the death of the Kree Emperor, Ronan himself was elected to the position. He later made peace with the Inhumans and entered into an arranged marriage with Crystal to cement it, but this didn’t last.",
                ],
                Personality =
                [
                    "A hulking mass of a warrior, Ronan demands respect from those around him, and any show of disrespect can cause him to erupt in a murderous rage. His proud loyalty to the Kree people outweighs his ferocious nature, though, and he tends to look down on those from “lesser races.”",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersS() =>
    [
        new()
        {
            Name = "Sabretooth (Victor Creed)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 6, vigilance: 4, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.XGene),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Victor Creed",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [275],
                Gender = Gender.Male,
                Eyes = "Amber",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Muttonchops, long canines, claws, slitted pupils",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.NineteenFiftyNineAvengers, TeamNames.BrotherhoodOfEvilMutants, TeamNames.TheHand, TeamNames.Marauders, TeamNames.TeamX, TeamNames.XFactor],
                Base = "Krakoa",
                History =
                [
                    "Victor Creed’s father treated him like an animal as a child, keeping him chained in the basement of their home. Once freed, Creed entered a life of murder and betrayal that caused him to cross paths several times with Wolverine (Logan), often with fatal results for those around them, despite their many similarities.",
                    "Magik killed Creed during the War of the Realms, but the mutants of Krakoa eventually brought him back to life. While on a mission for Krakoa, he killed a couple of humans, breaking one of Krakoa’s main laws, for which he was sentenced to being imprisoned inside Krakoa for life.",
                ],
                Personality =
                [
                    "Creed is vicious and callous, caring little for anyone but himself. He shows no mercy to those who dare cross his path. He likes to give into his animalistic nature and has never opted to take up any of the chances at redemption offered to him.",
                ]
            }
        },
        new()
        {
            Name = "Scarlet Witch",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 5, ego: 8, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Chaotic),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicChaosMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HexBolt),
                        powerSelector.GetPower(PowerNames.Jinx),
                        powerSelector.GetPower(PowerNames.PowerfulHex),
                        powerSelector.GetPower(PowerNames.ProbabilityManipulationHex),
                        powerSelector.GetPower(PowerNames.ProtectionHex),
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
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BumpPower),
                        powerSelector.GetPower(PowerNames.BoostPowers),
                        powerSelector.GetPower(PowerNames.DampenPower),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wanda Maximoff",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [132],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience, OriginName.MagicChaosMagic],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As infants, Wanda Maximoff and her twin brother, Pietro, were subjected to dangerous experiments, and as they aged, they began to exhibit strange powers. Wanda developed powerful magic, while Pietro developed superhuman speed. Superstitious villagers were about to kill the twins when Magneto saved them and invited them to join his Brotherhood of Evil Mutants as Quicksilver and the Scarlet Witch.",
                    "The twins later renounced such evil and became early members of the Avengers. As part of the team, Scarlet Witch met and fell in love with the Vision, with whom she had two children. When that went wrong, she broke down and unleashed the full powers of her chaos magic with disastrous results. She has since recovered and works to redeem herself.",
                ],
                Personality =
                [
                    "Although good at heart, Scarlet Witch has suffered repeated bouts of mental illness. When she is stable, she is kind, warm and friendly.",
                ]
            }
        },
        new()
        {
            Name = "Shang-Chi",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 3, resilience: 3, vigilance: 5, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese (Cantonese, Mandarin and other dialects), English"),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.FocusedStrike),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.LeapingLeglock),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.RegainFocus),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                        powerSelector.GetPower(PowerNames.SpinAndThrow),
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Zheng Shang-Chi",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.Avengers, TeamNames.FiveWeaponsSociety, TeamNames.HeroesForHire, TeamNames.Protectors],
                Base = "Chinatown, New York City",
                History =
                [
                    "As the son of the criminal mastermind Zheng Zu, Shang-Chi—who believed his father to be a good man—was trained from an early age to become the ultimate martial artist. When sent on a mission to assassinate one of his father’s enemies, he learned the truth and vowed to destroy his father’s criminal empire instead.",
                    "After Zheng Zu’s death, Shang-Chi inherited his father’s position as the Supreme Commander of the Five Weapons Society. He also learned that his mother—Jiang Li—hailed from the pocket dimension Ta Lo, and that her father—Chieftain Xin—wanted to destroy Shang-Chi’s entire family and take possession of the mystical Ten Rings."
                ],
                Personality =
                [
                    "Shang-Chi is a loyal friend and a determined leader who works hard to refute his father’s criminal legacy. He regularly resists the temptations of power and respects the rule of law. Despite this, he tries to maintain a light and friendly demeanor.",
                ]
            }
        },
        new()
        {
            Name = "She-Hulk",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 3, vigilance: 3, ego: 1, logic:6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Gamma Forms"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Jump3),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Jennifer Walters",
                Heights = [new() { Feet = 5, Inches = 10 }, new() { Feet = 6, Inches = 7 }],
                Weights = [150, 700],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Brown/dark green",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Lawyer],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Avengers, TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "Young attorney Jennifer Walters nearly died after being shot by a criminal. A blood transfusion from her cousin Bruce Banner—also known as the Hulk—saved her life, but the gamma-irradiated blood granted her powers similar to those of her cousin. Unlike the Hulk though, Walters can control the transformations into her emerald-skinned alter ego and retains her intelligence.",
                    "In the years since, Walters has proven herself a valuable member of the Avengers and a regular substitute member of the Fantastic Four. While she spent some time as a bounty hunter, she regularly returns to the law. Her skills as a sharp litigator with hands-on experience with super-powered people keeps her in high demand."
                ],
                Personality =
                [
                    "In her regular form, Walters is often an introverted homebody, but when in her She-Hulk form, she is much more extroverted, to the point of aggressiveness. She struggles to balance these two sides of her personality and sometimes prefers to simply remain She-Hulk, who she considers more fun.",
                ]
            }
        },
        new()
        {
            Name = "She-Hulk (Lyra)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 3, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PowerSliderSerenity),
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
                        powerSelector.GetPower(PowerNames.Jump2),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lyra",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [220],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Big,
                DistinguishingFeatures = "Green skin",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.ARMOR, TeamNames.AvengersAcademy],
                Base = "Mobile",
                History =
                [
                    "On Earth-8009, massive environmental and military disasters long ago rendered the vast majority of humanity infertile. The survivors underwent experimental body modifi cations, granting them longer lives and incredible powers, and in the ensuing chaos, society stratified along strict gender lines, with the men of the world making perpetual war against the women.",
                    "In an attempt to gain the upper hand, one of the leaders of the female resistance—Thundra—stole some skin cells from the Hulk of Earth-616 and used his DNA to impregnate herself. Her daughter, Lyra, was the first person naturally born on the planet in decades.",
                    "When Lyra was just 16, her handlers sent her to Earth-616 so she could obtain fertile male DNA in much the same way her mother had. She was supposed to obtain cells from Norman Osborn, but once she saw how evil he was, she refused to complete her mission. Her handlers generously released her from her duties, allowing her to stay on Earth-616 and train with its heroes.",
                    "Over the years, Lyra has been tutored by many of Earth’s greatest warriors, but she considers the original She-Hulk (Jennifer Walters) her number-one mentor. The pair are good friends, and Lyra sometimes uses the She-Hulk codename in honor of Walters."
                ],
                Personality =
                [
                    "When not in combat, Lyra has the personality of a normal, peppy teenage girl. In battle, she acts much more like a traditional stoic warrior. As opposed to most gamma mutates, Lyra’s powers get weaker as she gets angrier. To keep herself in top form, she forces herself to roll with the punches, literally and fi guratively.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "S.H.I.E.L.D. Agent",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 1, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.LegalEagle),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
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
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.SHIELD],
                Base = "S.H.I.E.L.D. Helicarrier",
                History =
                [
                    "Born out of an ancient brotherhood of peacekeepers, the modern S.H.I.E.L.D. was founded in the 1960s as part of a collaboration between the U.N. and arms magnate Howard Stark. As an anti-terrorist peacekeeping force, its primary goal has always been to dismantle the worldwide fascist terror organization Hydra.",
                    "S.H.I.E.L.D.’s incredible resources have proven to be a double-edged sword. Its upper ranks have been repeatedly infiltrated by terrorists, temporarily turning the organization into a terrifying evil army. Even when it works properly, S.H.I.E.L.D. leaders sometimes overreach, suspending civil liberties in pursuit of their anti-terrorist goals. At the moment, it has been disbanded entirely.",
                ],
                Personality =
                [
                    "Agents of S.H.I.E.L.D. tend to be combat-hardened soldiers with a strong sense of justice. While this makes them effective fighters, their training sometimes makes them too unwilling to question orders.",
                ]
            }
        },
        new()
        {
            Name = "Shuri",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 3, vigilance: 2, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new CharacterPowerSet
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Shuri",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [127],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader, OccupationName.Scientist],
                Origins = [OriginName.HighTech, OriginName.Magic],
                Teams = [TeamNames.PantherCult],
                Base = "Wakanda",
                History =
                [
                    "As the lone daughter of the Wakandan royal family, Shuri was narrowly defeated by her brother, T’Challa, in a contest to determine the next Wakandan regent, the Black Panther. Although she had long dreamed of becoming the Panther, Shuri did not let her envy consume her. Instead, she set out to make a name for herself in her own right.",
                    "Shuri’s brilliant mind and natural combat skills make her a fi ghter on par with T’Challa. In times of national upheaval, Shuri has temporarily accepted the title of Black Panther, but more often, she works as an advocate for the Wakandan people under her own name and to great success.",
                ],
                Personality =
                [
                    "Shuri sometimes resents the disproportionate amount of attention and power given to her brother, but her love for him and the Wakandan people outweighs all that. Eloquent, personable and incredibly sharp, she has proven herself an excellent leader.",
                ]
            }
        },
        new()
        {
            Name = "Silk",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 3, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Integrity),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderPheromones),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
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
            ],
            Biography = new Biography
            {
                RealName = "Cindy Moon",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.SpiderArmy],
                Base = "New York City",
                History =
                [
                    "As a teenager, Cindy Moon was bitten by the exact same radioactive spider that gave Spider-Man (Peter Parker) his powers. Her own powers proved a powerful lure for the multiversal predator Morlun, so she was locked away in a bunker for her own safety for thirteen years. After learning of Moon’s existence, Parker freed her from her bunker, unintentionally launching Morlun’s hunt for her once again.",
                    "Morlun and his family of hero hunters have since been defeated, and Moon has been reunited with her family. Today, she works as a reporter for J. Jonah Jameson’s new outlet, Threats and Menaces, and helps save the world as the spiderpowered hero Silk.",
                ],
                Personality =
                [
                    "A decade of nearly complete isolation gave Moon no small amount of social anxiety. Although she’s made great strides in the last few years, she still has some trouble socializing, particularly with people she doesn’t know well. Despite her fears, Moon’s unwavering heroic spirit allows her to push forward in her adventures.",
                ]
            }
        },
        new()
        {
            Name = "Silver Surfer",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 6, vigilance: 6, ego: 8, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Chaotic),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            flySpeed: true,
                            specialization: "Cosmic surfoard [Summonable by Silver Surfer. Grants Flight 2.]"),

                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection4),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicChaosMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PowerfulHex, reminder: "represents his Power Cosmic"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Norrin Radd",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Silver",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Body covered in nigh-indestructible silvery metal",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.Alien, OriginName.WeirdScience],
                Teams = [TeamNames.Annihilators, TeamNames.Defenders],
                Base = "Mobile",
                History =
                [
                    "Norrin Radd was an ordinary man born on the utopian planet of Zenn-La. Fascinated by the opportunities provided by space, Radd endeavored to explore the cosmos. He was well on his way to achieving his dream when Galactus arrived on his planet.",
                    "Despite the best efforts of Zenn-La’s leaders, none of their weapons could drive Galactus away. In a last-ditch effort to save his people, Radd boarded a spaceship and made a deal with the planet-eater. In exchange for sparing Zenn-La, Radd became Galactus’ herald, imbued with a portion of Galactus’ Power Cosmic, which transformed him into the Silver Surfer.",
                    "The Silver Surfer served Galactus faithfully until the day he arrived on Earth. Radd took pity on the people of Earth and fought Galactus on their behalf. Galactus ultimately spared the planet and stripped Radd of his position.",
                    "As a free agent, Radd has spent most of his subsequent years wandering the cosmos. His adventures have taken him across the universe and made him central in the fate of countless worlds."
                ],
                Personality =
                [
                    "The Silver Surfer regrets his time serving Galactus, and he often misses the people of Zenn-La he left behind. In addition, he is racked with guilt for all those he couldn’t save.",
                    "The Silver Surfer does his best to act as a hero, but decades of tragic escapades have worn him down. The primary thing that keeps him going is his love for life itself."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Skrull",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 2, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Skrull Empire)"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in natural form"),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "when disguised"),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
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
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "Green-skinned aliens with shape-shifting powers",
                Occupations = [OccupationName.Military, OccupationName.Outsider],
                Origins = [OriginName.AlienSkrull],
                Teams = [TeamNames.SkrullEmpire],
                Base = "Tarnax II",
                History =
                [
                    "The aliens commonly known as Skrulls are actually the Deviant variant of their race, created by visiting Celestials in ancient times. Their amazing powers to assume any guise allowed them to drive both the original Skrulls and the Eternal variant Skrulls long extinct.",
                    "Over the past ten million years, the Skrull Empire has spread its infl uence throughout the galaxy— first as traders and then as invaders—conquering hundreds of planets, including the entire Andromeda Galaxy. After Galactus devoured their homeworld, they were scattered among the stars, but they recently allied with their ancient enemies—the Kree—under the leadership of Emperor Dorrek VIII, also known as the Earth hero Hulkling.",
                ],
                Personality =
                [
                    "The militaristic culture of the Skrull Empire has turned many Skrulls into jingoistic monsters. Few of them would hesitate to give their lives for the Empire. They have been raised to believe that they are the greatest, most worthy race of people in the universe. Other people are inherently lesser and deserve to be conquered.",
                ]
            }
        },
        new()
        {
            Name = "Spider-Man (Miles Morales)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SurprisingPower),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Peter Parker"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.VenomBlast),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
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
            ],
            Biography = new Biography
            {
                RealName = "Miles Morales",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [160],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Champions, TeamNames.SpiderArmy],
                Base = "New York City",
                History =
                [
                    "Born in an alternate universe (Earth-1610), high-school student Miles Morales was bitten by a genetically modifi ed spider that granted him amazing spiderlike abilities. After witnessing the death of his universe’s Spider-Man (Peter Parker), Morales decided to take on the hero’s mantle and become the new Spider-Man.",
                    "When Morales’ universe was destroyed, he managed to escape to the main Marvel Universe (Earth- 616), and the Molecule Man integrated Morales’ past life and family into his new home, restoring some of them to life. Today, Morales attends the Brooklyn Visions Academy and adventures alongside the original Spider-Man, the Order of the Web (a team of Spider-Man-related heroes) and the Champions (a team of teenaged heroes), as well as establishing himself as a hero all his own.",
                ],
                Personality =
                [
                    "Morales is an excellent student and a loyal friend. He remembers little of his old life on Earth-1610, but he is dedicated to making the most of his second chances on Earth-616 with his family. He looks up to Peter Parker as a mentor, but at the same time, he is determined to carve out his own path and become his own kind of hero.",
                ]
            }
        },
        new()
        {
            Name = "Spider-Man (Peter Parker)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 7, resilience: 3, vigilance: 3, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Aunt May"),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Integrity),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
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
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.FantasticFour, TeamNames.SpiderArmy],
                Base = "New York City",
                History =
                [
                    "Bitten by a radioactive spider when he was in high school, Peter Parker gained a suite of spider-related powers. He exploited them for profi t until he let a robber get away who later shot and killed his Uncle Ben in a botched burglary, driving home the lesson “with great power there must also come great responsibility.” Since then, Parker has dedicated himself to fi ghting crime and helping those who have less power than him.",
                    "Over the years, Parker has been cloned, discovered one of his costumes was an alien symbiote and learned more about his deep connection to the Spider-Totem. At the same time, he’s battled against the most colorful rogues’ gallery around. Meanwhile, he’s met up with several different variations of Spider-Man hailing from alternate dimensions, including the younger Miles Morales, also known as Spider-Man.",
                ],
                Personality =
                [
                    "Parker is a genius who oft en lets his sense of responsibility get in the way of taking care of the basics of his life. He’s known for his sharp wit and his wisecracking ways, which he often uses to enrage his foes. Despite the problems that often plague his personal life, it’s rare that he lets feeling sorry for himself stop him from helping others, especially when he’s in costume, webswinging through the city’s streets.",
                ]
            }
        },
        new()
        {
            Name = "Spider-Man 2099 (Miguel O’Hara)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 3, vigilance: 2, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Integrity),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Miguel O’Hara",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Fangs, retractable talons, spinnerets",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy],
                Base = "New York City",
                History =
                [
                    "Born in a dystopic alternate future (Earth-928), Miguel O’Hara became a brilliant geneticist under the employ of the powerful Alchemax corporation. After being pressured into performing a genetic experiment that killed its subject, Miguel attempted to resign from Alchemax, but his bosses instead injected Miguel with a high dose of an addictive drug that only they could supply.",
                    "To find a cure for his addiction, Miguel redid his dangerous genetic experiment, splicing his own DNA with that of a spider. It cured Miguel of his addiction but mutated his body, giving him spider-powers.",
                    "Today, having eliminated his potential future while time-traveling to the present day, Miguel resides in Earth-616."
                ],
                Personality =
                [
                    "Miguel is a serious crimefi ghter and a brilliant scientist. While he has a particular hatred for the type of corporate evildoers who forced him to mutate his own body, Miguel will fi ght anyone who threatens the safety of innocents.",
                ]
            }
        },
        new()
        {
            Name = "Spider-Woman (Jessica Drew)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 7, resilience: 3, vigilance: 3, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Dependents, specialization: "Gerry Drew"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.VenomBlast),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgliding),
                    ],
                },
                 new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jessica Miriam “Jess” Drew",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Blond, usually dyed black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Investigator, OccupationName.Spy],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DaughtersOfLiberty, TeamNames.NewAvengers, TeamNames.SHIELD],
                Base = "NYC",
                History =
                [
                    "When Jessica Drew was just a child, she contracted an acute case of radiation poisoning. Her father—a top geneticist and nuclear researcher—searched desperately for a cure to his daughter’s condition. Hoping to grant her the increased radiation immunity enjoyed by many insects, he injected her with an irradiated form of spider DNA.",
                    "The treatment saved Drew’s life but forced her into a coma that lasted more than a decade. By the time she awoke, her parents were long gone.",
                    "Lost and alone, Drew briefly stumbled into the care of Hydra agents who attempted to make her into a spider-themed superspy named Spider-Woman. Drew quickly turned on her handlers, but she kept the Spider-Woman costume.",
                    "As Spider-Woman, Drew spent the next several years traveling across Europe and the United States, occasionally allying herself with S.H.I.E.L.D. and other heroic organizations. Eventually, she settled down in NYC and decided to start a family on her own. When she’s not adventuring, she spends much of her time caring for her son, Gerry."
                ],
                Personality =
                [
                    "Spider-Woman’s early days as an adventurer were rocky. Having spent most of her life in a coma, her brain was deeply undeveloped. She often fled from conflict, fighting more out of necessity than a desire to enact justice.",
                    "The Spider-Woman of today hardly resembles her younger self. Years of experience have molded her into a confi dent and capable crimefi ghter. Drew is an expert in the arts of both espionage and investigation, and she suffers nonsense from no one."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Squirrel Girl",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 2, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Nancy Whitehead"),
                tagSelector.GetTag(TagNames.Mysterious),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Tippy-Toe"),
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Squirrels"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Doreen Green",
                Heights = [new() { Feet = 5, Inches = 3 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Squirrel tail",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.GreatLakesAvengers, TeamNames.SHIELD],
                Base = "New York City",
                History =
                [
                    "Born with the proportionate speed and strength of a squirrel, Doreen Green has been fi ghting super villains since she was 14. In less than a decade, Squirrel Girl has personally prevented worldwide disaster at the hands of villains as powerful as Thanos and Galactus. Squirrel Girl’s exploits have never made her famous, in no small part because people in the media tend to fi nd her squirrel powers a little silly. While Green can communicate with all sorts of squirrels, she has a special bond with one she named Tippy-Toe, who has fought crime by her side for the longest.",
                    "More recently, Green has enrolled in the computer science program at Empire State University. Despite her collegiate studies, Green still fi nds the time to help protect the people of NYC.",
                ],
                Personality =
                [
                    "Relentlessly happy-go-lucky, Doreen Green has a lot of faith in the goodness of others, even villains. She prefers to solve problems without violence if it can be helped, and she’s talked villains out of committing crimes about as often as she’s actually defeated them. Green’s ideal world would be one in which everyone could just chill out with one another peacefully.",
                ]
            }
        },
        new()
        {
            Name = "Star-Lord",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 5, vigilance: 4, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, reminder: "translator implant"),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection, reminder: "space helmet", isTech: true),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Element Gun [Can pick elemental effect from air, earth, fire, water, or energy; returns when summoned]"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage, reminder: "Element Gun"),
                        powerSelector.GetPower(PowerNames.ElementalBlast, reminder: "Element Gun"),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "Element Gun"),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Illumination),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Levitation),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Peter Jason Quill",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Glowing left eye (formerly cybernetic), sun tattoo on right hand",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.UnitedFront],
                Base = "Mobile",
                History =
                [
                    "Quill grew up without a father, unaware that his mother, Meredith Quill, had conceived him during an affair with a humanoid alien named J’son, the heir to the interstellar Spartax Empire. As a young adult, he worked as a NASA mechanic, but after being fired, he stole a Kree space ship and escaped to the stars. The space pirates known as the Ravagers found him stranded in space, and their leader, Yondu, allowed him to join their crew. He eventually turned against them and set out on his own, calling himself Star-Lord.",
                    "Quill learned of his father’s identity but refused to join him and rule Spartax. Instead, he helped defeat the massive galactic threats mounted by both Annihilus and then Ultron, after which he formed a group of adventurers known as the Guardians of the Galaxy. Quill recently gained the title Master of the Sun (along with some new powers) and spent over a hundred years adventuring in another dimension before returning to his home reality.",
                    "In addition to his powers, Quill carries the Element Gun (which allows him to fi re different elements), and he wears a space helmet that protects him in outer space, provides him with air to breathe, and allows him to remotely pilot a linked starship."
                ],
                Personality =
                [
                    "Quill is a natural leader who exudes confi dence, even when it’s unjustifi ed. He thinks of himself as a principled thief, an outlaw with standards. Despite his disdain for rulers, when he found himself elected as the first president of Spartax, he rose to the occasion—until he was ousted and became an outlaw again.",
                    "Quill is often wracked with guilt over the mistakes he’s made, some of which have cost hundreds of thousands of lives, but he does his best to cover those with his bravado and his natural charm. Time has helped heal those wounds."
                ]
            }
        },
        new()
        {
            Name = "Stick",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 1, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.VisionIssues),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
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
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [135],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic, OriginName.SpecialTraining],
                Teams = [TeamNames.Chaste, TeamNames.Fist],
                Base = "NYC",
                History =
                [
                    "Born both blind and penniless, Stick took up martial arts at a young age to survive. He found that he had a natural talent for fi ghting, and soon enough he had drawn the attention and mentorship of the mystic martial arts master Yao (A.K.A. the Ancient One). The next several decades of Stick’s life were spent in the shadows, during which he became the leader of the Chaste, an elite organization of ninjas created to counter the insidious clan of the Hand.",
                    "Stick’s life was full of thrills and adventures, but as he got older, life in the shadows started to wear on him. He took a young blind boy named Matt Murdock under his wing to train as his heir. He taught the boy to fi ght and to develop his radarlike senses, which compensated for his blindness. Within a few years, Murdock’s abilities began to rival Stick’s.",
                    "As the super hero Daredevil, Murdock uses the training Stick gave him for the betterment of humanity. Stick died years ago, saving Daredevil and Black Widow from the Hand. He has returned to life occasionally since."
                ],
                Personality =
                [
                    "Stick is a gruff and disagreeable old man whose training methods often verge upon outright cruelty. He is hard on everyone, but none more than Matt Murdock.",
                    "Stick cares deeply for Murdock but that care often translates to harsh treatment. Stick’s life has been hard, and he had to become hard to get through it. He fears that his star pupil lacks that same hardness, and that it may one day get him killed."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Storm",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 4, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
                        powerSelector.GetPower(PowerNames.GroupFlight),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlFog),
                        powerSelector.GetPower(PowerNames.ControlWeather3),
                        powerSelector.GetPower(PowerNames.Thunder),
                        powerSelector.GetPower(PowerNames.WeatherChill),
                        powerSelector.GetPower(PowerNames.WeatherWarm),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ororo Munroe",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [145],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "Her eyes turn white when using her powers",
                Occupations = [OccupationName.Adventurer, OccupationName.Leader],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Avengers, TeamNames.GodsOfWakanda, TeamNames.Marauders, TeamNames.QuietCouncilOfKrakoa, TeamNames.XMen],
                Base = "Krakoa, Wakanda",
                History =
                [
                    "The latest in a long line of witch-priestesses from Africa, Ororo Munroe was orphaned during a war in Egypt and wound up living on the streets of Cairo as a thief. Later, Professor X found her and convinced her to join the X-Men where she quickly became one of the team’s strongest members and has long served as one of its leaders.",
                    "Munroe fell in love with and married the Black Panther (T’Challa), but confl ict between the X-Men and the Avengers led to their marriage being annulled. She has since reconciled with him, but she spends much of her time on the island of Krakoa, serving in the government there, while his duties require him to live in Wakanda.",
                ],
                Personality =
                [
                    "Munroe is a force of nature in her powers and her personality. She is comfortable as a thief and a queen, and she is majestic in both roles. Despite her regal nature, she has a sharp sense of humor.",
                ]
            }
        },
        new()
        {
            Name = "Sub-Mariner (Namor)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 4, resilience: 3, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat/Flame"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Amphibious),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Atlantis"),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlWater,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedSwim),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Fish"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Namor McKenzie",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [278],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Gills, pointed ears and small ankle wings",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.Atlantean, OriginName.Mutant],
                Teams = [TeamNames.AtlanteanRoyalFamily, TeamNames.Avengers],
                Base = "Atlantis",
                History =
                [
                    "Born a mutant, half-human Atlantean prince, Namor fought alongside the Allies in World War II, joining the Invaders and the All-Winners Squad. In the 1950s, the Serpent Crown was used to wipe his memory, and he spent decades as a confused vagrant, until the Human Torch (Johnny Storm) stumbled upon him. Returning to Atlantis, Namor took back the throne that was his birthright and ruled as the king.",
                    "In the years since, Namor has fended off coup attempts and led attacks against the surface world in retaliation for their abuse of the oceans. He allies himself with those who support Atlantean interests. As such, he has joined the Avengers and Defenders, but he also has allied himself with villains like Doctor Doom.",
                ],
                Personality =
                [
                    "Namor has a regal bearing and a tendency to condescend toward others, coupled with a short temper for those condescending toward him. Despite his pompous manner, he truly cares for his subjects.",
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Mutant Status",
                        Description =
                        [
                            "Namor is a mutant Atlantean. This combination of origins removes the standard Atlantean traits Breathe Different and Enhanced Physique and the tag Extreme Appearance. It also removes the mutant tag Hounded. While he technically has the right to be Krakoan, he generally refuses to use it."
                        ]
                    }
                ]
            }
        },
        new()
        {
            Name = "Sunspot",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 6, resilience: 3, vigilance: 3, ego: 8, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "when using powers"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Askani, English, Portuguese, Spanish"),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Roberto “Bobby” Da Costa",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Body cloaked in darkness (when powers are active)",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GreatRingOfArakko, TeamNames.NewMutants, TeamNames.XMen],
                Base = "Arakko",
                History =
                [
                    "Wealthy Brazilian heir Bobby Da Costa’s powers manifested suddenly in his teen years when he accidentally punched a racist bully halfway across a soccer fi eld. Pursued by an organization of mutant-hating evildoers, Da Costa found his way into the care of Charles Xavier (Professor X) and became a founding member of the New Mutants.",
                    "Bobby used his wealth as well as his powers to help not only the X-Men but the Avengers. He even purchased A.I.M. at one point and transformed the organization into one dedicated to doing good. He died during the War of the Realms, but he was later resurrected on Krakoa."
                ],
                Personality =
                [
                    "Sunspot is a strong conversationalist and orator. He has a talent for relating to others, making him an effective team manager. Bobby rarely turns his nose up at an opportunity for a good joke or a bit of fun.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersT() =>
    [
        new()
        {
            Name = "Taskmaster",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Mysterious),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CloneMoves),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.Shield1),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Anthony “Tony” Masters",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Skull mask",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.Hydra, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Tony Masters was born with photographic refl exes granting him the uncanny ability to perfectly mimic any fi ghting technique he witnesses. He spent years studying professional athletes and warriors, slowly building himself into one of the greatest hand-to-hand fighters on the planet.",
                    "Hoping to use his powers for good, Tony joined S.H.I.E.L.D., where he was dosed with an experimental variant of the Super-Soldier Serum, which enhanced his body but erased his memories. The amnesiac Tony donned a skull mask and decided to put his skills to more profitable uses, becoming the mercenary Taskmaster.",
                ],
                Personality =
                [
                    "Tony lacks any lofty political goals. He just loves to fight. Getting paid for it is just frosting on the cupcake. He eventually regained his memories of his time as a S.H.I.E.L.D. agent, but he kept on as a mercenary. He enjoys being the Taskmaster too much to let it go.",
                ]
            }
        },
        new()
        {
            Name = "Terror",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 4, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Head spikes [can extrude green spikes from his head that can be broken off and used as knives]"),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CopyAbility),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.CopyTrait),
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
                    ],
                },
            ],
            PowerNotes =
            [
                "Terror’s Healing Factor and Power Control powers function only as long as he has a steady supply of body parts. To use any of his “Copy” powers, he must first steal a body part from his target and then attach it to himself."
            ],
            Biography = new Biography
            {
                RealName = "Unknown, sometimes goes by “Shreck”",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually around 6'2\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually around 170 lbs.",
                Gender = Gender.Male,
                Eyes = "Varies",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Patchwork body with reptilian torso and head; other parts salvaged from various humanoid species",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicDemonic],
                Teams = [TeamNames.MercsForMoney, TeamNames.TerrorInc],
                Base = "New York City",
                History =
                [
                    "Terror hails from Earth-88194, a world that resembles Earth-616 in some superfi cial ways but lacks costumed super heroes. In their place, Earth-88194 has the Shadow Dwellers, a mysterious and immortal off shoot of humanity that manipulates world affairs from behind the scenes.",
                    "Terror is not one of these Shadow Dwellers. Instead, he claims to have been a caveman who heroically defended his tribe of early humans from a demon. Unfortunately, before he could kill the demon, it infl icted a terrible curse upon him: He would live forever, but in a constant state of decay.",
                    "Terror spent the subsequent centuries wandering the planet, harvesting new parts for himself from corpses as the old bits decayed and fell away. Sometime during the medieval era, he met the love of his life, a knight named Talita. When she died, he sealed her left arm in iron and attached it to himself. It is the one part of his body that he has refused to ever replace.",
                    "In the modern era, Terror became a mercenary, first on Earth-88194, then later on Earth-616. Currently he lives in New York City, where he operates a private detective/mercenary business under the name of Terror Inc."
                ],
                Personality =
                [
                    "Terror’s personality largely resembles that of a classic P.I. He’s hardnosed and ruthless but not exactly cruel. However, the fi ne details of who Terror is shift constantly, as he absorbs a bit of the knowledge and personality of the people whose body parts he attaches to himself.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Thanos",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 4, resilience: 7, vigilance: 3, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.MahdWyry),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Thanos",
                Heights = [new() { Feet = 6, Inches = 7 }],
                Weights = [985],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Chin furrows, purple skin",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.Eternals],
                Base = "Mobile",
                History =
                [
                    "Although his parents are Eternals, Thanos was born on Titan (a moon of Saturn) with a rare genetic mutation giving him the appearance of a Deviant. Shunned by Eternal society for his resemblance to their ancient enemies, only one young woman dared to keep him company, and he fell for her hard. The woman eventually revealed herself to be the embodiment of Death, and to win her favor, Thanos set out to kill everyone in the universe.",
                    "Thanos has come close to achieving his ambitions a few times, once killing half the universe with a single snap of his fi ngers. However, his plans to exterminate all life have all been foiled in the end, often with the aid of his adopted daughters, Nebula and Gamora.",
                ],
                Personality =
                [
                    "Although often referred to as the Mad Titan, Thanos is both serious and eloquent. His murderous motives are born out of deep-seated feelings of loneliness and his lust for Death.",
                ]
            }
        },
        new()
        {
            Name = "Thing",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 3, resilience: 8, vigilance: 4, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Sturdy4),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "4 Yancy Street"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                        powerSelector.GetPower(PowerNames.Wisdom),
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
                },
            ],
            Biography = new Biography
            {
                RealName = "Benjamin Jacob “Ben” Grimm",
                Heights = [new() { Feet = 6 }],
                Weights = [500],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Four digits on each limb, rocky skin",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "As an experienced test pilot, Ben Grimm jumped at the opportunity to join his old college buddy Reed Richards on an experimental space mission. Just after takeoff, the ship was bombarded by cosmic rays, forcing them to make an emergency landing. Back on Earth, the crew realized they each had been uniquely transformed. Ben’s skin had turned rocky and hard, giving him a monstrous appearance. Although horrifi ed by his new visage, Ben joined the rest of the crew to form the Fantastic Four.",
                    "Ben has since married the blind sculptor Alicia Grimm (née Masters) and adopted two kids: a Kree boy named Jo-Venn and a Skrull daughter named N’Kalla.",
                ],
                Personality =
                [
                    "Ben can be gruff and combative and does not take slights against himself or his friends lightly. Years of living in the public eye have allowed him to reach some level of peace with his appearance, but it’s still a sore spot. When determined, Grimm will never quit, even when it seems as though he has reached the limit of his strength.",
                ]
            }
        },
        new()
        {
            Name = "Thor (Jane Foster)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 4, vigilance: 3, ego: 3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.GodHeritage, reminder: "via Mjolnir"),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Gorr the God Butcher"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped, reminder: "as Thor"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Mjolnir [+1 Melee and Agility damage multiplier. Returns to thrower. Can only be wielded by the worthy.]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlFog),
                        powerSelector.GetPower(PowerNames.ControlWeather4),
                        powerSelector.GetPower(PowerNames.Thunder),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jane Foster",
                Heights = [new() { Feet = 5, Inches = 7 }, new() { Feet = 5, Inches = 9 }],
                Weights = [135, 450],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown/blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.HealthCareWorker],
                Origins = [OriginName.MythicAsgardian, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers],
                Base = "New York City, Asgard",
                History =
                [
                    "Jane Foster served as a nurse for Doctor Donald Blake, the alter ego of Thor Odinson, with whom she fell in love. Thor’s father, Odin, separated them, though, and Foster went on to become a doctor herself, as well as a wife and mother. She later divorced her husband, who retained custody of their son.",
                    "While Foster battled breast cancer, Thor Odinson lost the ability to use his magic hammer, Mjolnir. The hammer reached out to Foster, who took possession of it and gained the power of Thor. Odinson gave his blessing and approved of Foster using the name Thor. Becoming Thor purged Foster’s body of the chemotherapy drugs fighting her cancer, though and aftr a series of adventures that nearly killed her, she gave up being Thor and succesfully fought her cancer. She later became a Valkyrie to help shepherd the souls of dead heroes to Valhalla.",
                ],
                Personality =
                [
                    "Foster is smart, capable and determined, able to stand up to Asgardian gods. Life has not always been kind to her, but she’s survived it all and come out more independent and capable than ever.",
                ]
            }
        },
        new()
        {
            Name = "Thor (Thor Odinson)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 4, resilience: 8, vigilance: 2, ego: 5, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Gorr the God Butcher"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped),
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

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Mjolnir [+1 Melee and Agility damage multiplier. Returns to thrower. Can only be wielded by the worthy.]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlWeather4),
                        powerSelector.GetPower(PowerNames.Thunder),
                        powerSelector.GetPower(PowerNames.WeatherChill),
                        powerSelector.GetPower(PowerNames.WeatherWarm),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Thor Odinson",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [640],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.Avengers, TeamNames.GodsOfAsgard, TeamNames.GodSquad],
                Base = "Asgard",
                History =
                [
                    "As the son of Odin—ruler of the Asgardian gods— Thor was destined for greatness. Raised alongside his adopted brother, Loki—the God of Mischief— Thor had many adventures as a youth. When Odin realized Thor needed to learn humility, he erased Thor’s memories and sent him to Earth as medical student Donald Blake. After learning his lesson, he recovered his powers and memories, and served both Asgard and Earth as Thor. After Thor (and a number of variants) defeated Malekith in the War of the Realms, he became the new All-Father of Asgard. Ruling over his people does not suit the thunder god, well as he prefers to be an active hero instead.",
                ],
                Personality =
                [
                    "Thor can be grim when faced with his responsibilities, but he feels most himself when given something he can strike with his enchanted hammer, Mjolnir—preferably a worthy foe. There is little he enjoys more than a drink after a wellfought battle. Despite all his time on Earth—and in America—he still speaks with an Asgardian accent and often in an old-fashioned way.",
                ]
            }
        },
        new()
        {
            Name = "Thunderball (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 4, vigilance: 2, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Skeptical),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Thunderball and chain [Throwable club. Automatically returns to thrower.]"),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Eliot Augustus Franklin",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [325],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.Illuminati, TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Eliot Franklin was a world-renowned physicist who seemed to be living the dream—until the day he invented a miniature gamma bomb. The bomb’s design was brilliant, but as his reward, Franklin’s employers fi red him and patented the bomb in their own names instead of his.",
                    "Franklin tried to steal back his invention but was caught and sent to prison, where he wound up alongside Dirk Garthwaite, the super villain known as the Wrecker. Franklin and a couple of his fellow inmates helped break Garthwaite out of prison, and in exchange, Garthwaite granted them each a portion of his own powers. Together, these escapees formed the Wrecking Crew.",
                    "For most of his criminal career, Franklin has worked with the Wrecking Crew, but he did join the Hood’s version of the Illuminati for a while too."
                ],
                Personality =
                [
                    "Thunderball is known for being smarter and more restrained than the rest of the Wrecking Crew and has occasionally contested the Wrecker for the group’s leadership. He has stayed with the crew largely so that he can continue to fund his research into gamma radiation. If any member of the crew can be reasoned with, it’s Thunderball.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Tigra",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Tigra form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Greer Grant Nelson",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [180],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Orange",
                Size = Size.Average,
                DistinguishingFeatures = "Body covered with orange-and-black striped fur. Eyes have vertical slits like a cat’s. Also has claws, fangs and a tail.",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mythic, OriginName.WeirdScience],
                Teams = [TeamNames.Defenders, TeamNames.WestCoastAvengers],
                Base = "Mobile",
                History =
                [
                    "As a newly widowed woman in need of a steady income, Greer Nelson took a job working as a laboratory assistant for the kind but mysterious Dr. Joanne Tumolo, who was researching cats as a means of developing physical conditioning treatments for eccentric health club owner Malcolm Donalbain. However, when Tumolo discovered that Donalbain planned on using her treatments for evil, she abandoned her bizarre benefactor and made Nelson her primary test subject.",
                    "The experimental treatments gave Nelson catlike refl exes and agility. Under the codename the Cat, Nelson embarked on a short stint as a costumed crimefi ghter, using her abilities to defeat Donalbain once and for all.",
                    "After sustaining a critical injury in a fi ght with Hydra, Nelson discovered Tumolo’s true identity. Her beloved boss was not merely a professor with an interest in feline physiology but part of an ancient and underground race of super-powered cat-people.",
                    "To save her assistant’s life, Tumolo was forced to transform Nelson into a full-fledged cat-person too. Nelson quickly came to appreciate her new form, and she returned to her crimefi ghting career under the new codename Tigra."
                ],
                Personality =
                [
                    "Tigra makes the most of her powers with her fi erce determination. She fi ghts with a ferocity bordering on savagery when forced to it.",
                    "Although she has been part of both the Avengers and the Defenders, Tigra is oftn not shown the same level of respect as her peers in the superhero community. A part of her resents the lack of recognition, but she never lets that stop her."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Titania",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 3, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Mary MacPherran",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [545],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.GammaFlight],
                Base = "Mobile",
                History =
                [
                    "Born to a poor family in a Colorado suburb, Mary MacPherran was mocked her whole life for being small and scrawny, so when Doctor Doom offered to transform her into a powerful and wealthy super villain, she didn’t hesitate. As Titania, MacPherran became a hulking mass of a woman imbued with the strength of a hundred men and set out to obtain the wealth she had dreamed of by any means necessary. To that end, she fell in with a series of other super criminals.",
                    "Years of adventuring have tempered Titania’s greed. She thinks of herself as a mercenary now rather than a criminal, and she and her longtime boyfriend the Absorbing Man (Crusher Creel) are doing their best to keep straight."
                ],
                Personality =
                [
                    "Titania is loud and boisterous but inherently defensive. Money, power and respect mean the world to her, and she doesn’t take kindly to anyone who threatens to take those things away from her.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersU() =>
    [
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

    private List<Character> GetAllCharactersV() =>
    [
        new()
        {
            Name = "Vampire",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Garlic / Holy Symbols (including Holy Water) / Sunshine"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Silver / Wood"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bat / Mist / Wolf"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Deceased),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.Imageless),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.LeechLife),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Bats / Rodents"),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
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
                DistinguishingFeatures = "Fangs, other features vary",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.MonstrousVampire],
                Teams = [],
                Base = "Varies",
                History =
                [
                    "Almost every vampire who exists today can trace their origins back to a single vampiric monster named Varnae. This monster was summoned into the world tens of thousands of years ago by a dark Atlantean cult, and it didn’t take long for him to seed his monstrous infl uence throughout the globe.",
                    "Today, there are thousands of vampires spread across more than a dozen secretive sects. Some vampires can pass as classy human aristocrats, while others have terrifying, bat-like appearances. However, all vampires have one thing in common: an insatiable lust for blood. Their largest colony resides in Chernobyl under the reign of Dracula."
                ],
                Personality =
                [
                    "Vampire personalities vary wildly, but your classic bloodsuckers tend to act like feudal lords. They have a charming, even charismatic manner belying their demonic nature. They often follow in the footsteps of Dracula, the lord of vampires, an aristocratic warlord imbued with Varnae’s own power. This profi le represents a newly turned vampire. As vampires grow older, they can become even more powerful.",
                ]
            }
        },
        new()
        {
            Name = "Venom (Eddie Brock)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 3, vigilance: 2, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Pundit),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Edward Charles Allan “Eddie” Brock",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [260],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Venom form has retractable nclaws, fangs and an unnaturally long tongue",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.Symbiote],
                Teams = [TeamNames.SinisterSix, TeamNames.SymbioteHive],
                Base = "New York City",
                History =
                [
                    "Eddie Brock was disgraced as a journalist after Spider-Man (Peter Parker) unknowingly discredited the biggest story of his career. Outcast and despondent, Eddie went to a church to pray for a way out. Unbeknownst to him, Spider-Man was there too, wrestling with an alien symbiote he’d been wearing as a costume. Once Spider-Man rid himself of the symbiote, it found and bonded itself to Eddie and the two vowed to take revenge on Spider-Man as Venom.",
                    "Eddie has since managed to rein in his anger and the symbiote’s murderous tendencies. For a while, he parted from Venom and bonded with other symbiotes spawned from it—Anti-Venom and Toxin—but he eventually returned to the original."
                ],
                Personality =
                [
                    "Although he can still be murderously unstable, Eddie has softened over the years. These days, he’s more concerned with becoming a hero in his own right and protecting his son, Dylan, who has also bonded with the Venom symbiote.",
                ]
            }
        },
        new()
        {
            Name = "Viper",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ophelia Sarkissian",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black, often dyed green",
                Size = Size.Average,
                DistinguishingFeatures = "Artificial fangs",
                Occupations = [OccupationName.Military, OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.HellfireClub, TeamNames.Hydra, TeamNames.SerpentSquad],
                Base = "Mobile",
                History =
                [
                    "Orphaned or abandoned shortly after birth, Ophelia Sarkissian was taken in by the terrorist group Hydra when she was just an infant. She took to the organization’s training, and by the time she was in her preteens, she developed an unusual aptitude for combat. Before her twentieth birthday, she earned her way into Hydra’s inner circle. Under the codename of Viper, she took charge of the organization’s most insidious and clandestine operations.",
                    "Renowned for her ruthlessness in combat, Viper has gone toe to toe with the likes of Captain America (Steve Rogers) and Wolverine (Logan). Although she occasionally works as a private mercenary, she is rarely far from Hydra. The organization is the closest thing she has to a family, and it is the one place in the world where she is respected and loved unconditionally. Her unfl inching loyalty to Hydra is emotional as much as it is ideological.",
                    "Sarkissian is a woman of many aliases and identities. Viper may be the codename she uses the most, but at other times she has been known as Madame Hydra, Madame Viper, the White Warrior Princess, or simply Ms. Sarkissian."
                ],
                Personality =
                [
                    "Above all, Sarkissian is cold and conniving, and as a leader she makes for an extremely harsh mistress. She cares for interpersonal relationships only insofar as she can use them to advance her own interests. She once clawed her way into a sham marriage with Wolverine (Logan)—a man she personally hated—solely so that she could obtain a favorable political position within a foreign court.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Vision",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 3, vigilance: 3, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                    IsTech = true
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
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DisruptElectronics),
                        powerSelector.GetPower(PowerNames.DisruptNerves),
                        powerSelector.GetPower(PowerNames.DisruptPerson),
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                    ],
                    IsTech = true,
                },
            ],
            Biography = new Biography
            {
                RealName = "Vision",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [300],
                Gender = Gender.Male,
                Eyes = "Gold",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Bright red skin",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.Avengers],
                Base = "Arlington, Virginia",
                History =
                [
                    "The android named Vision was originally built by Ultron to infi ltrate the Avengers, but just as Ultron rebelled against his creator, the Vision rebelled against Ultron. He joined the Avengers instead, vowing to protect the world from Ultron’s machinations. He has worked with them for many years, at times even leading the team.",
                    "He later discovered that his body had once belonged to a time-split variant of the original Human Torch (Jim Hammond). Despite his synthetic nature, the Vision feels strong emotions. He’s been married twice, fi rst to the Scarlet Witch, with whom he had two children who became Wiccan and Speed. After their divorce, his second wife was Virginia, an android he’d built himself, along with their children Vin and Viv. She has since been destroyed."
                ],
                Personality =
                [
                    "The Vision can seem distant, even aloof, but he cares deeply for his family and his friends. Anyone who hurts his loved ones is sure to suffer deeply at the hands of his unstoppable wrath.",
                ]
            }
        },
        new()
        {
            Name = "Vulture (Adrian Toomes)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Grappling Technique [while flying]"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Adrian Toomes",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.SinisterSix, TeamNames.SinisterTwelve, TeamNames.SavageSix],
                Base = "New York City",
                History =
                [
                    "Adrian Toomes invented a magnetic harness that allowed the person wearing it to fly and gave them superhuman strength. Frustrated after catching his business partner embezzling from their company, he used his invention to turn to crime, robbing places and then fl ying away before anyone could catch him. Spider-Man (Peter Parker) consistently puts a stop to him.",
                    "Over the years, Toomes has been put in and broken out of prison several times. He’s run casinos and organized crime rings and worked at improving the technology that gives him his powers. He’s at his most dangerous when working with others, but he usually prefers to work on his own."
                ],
                Personality =
                [
                    "Toomes is an old man who’s bitter about how his life turned out, and he uses that as an excuse for his criminal behavior. His one soft spot is his granddaughter Tiana Toomes, who uses his technology as the costumed adventurer Starling.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersW() =>
    [
        new()
        {
            Name = "War Machine",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Stark Tower"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
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
                RealName = "James Rupert “Jim” Rhodes",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [240],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD],
                Base = "New York City",
                History =
                [
                    "While working as an army pilot, James Rhodes was forced to make an emergency landing, deep in the Sin-Cong jungle, where he ran into Tony Stark, who had just escaped the Sin-Cong prison where he had fashioned his original Iron Man suit. Together, they fought their way out.",
                    "Rhodey quickly became one of Tony’s closest friends and has even taken over as Iron Man on occasion. Eventually, he wound up with his own suit of Stark-designed armor as War Machine. He was killed in action during the second superhuman Civil War, but Tony later restored him to life."
                ],
                Personality =
                [
                    "Although Rhodey is perfectly personable around his friends and family, he takes battle seriously and isn’t the type to fire off quips while fighting a super villain. He serves as a coolheaded and focused counterpart to the off en-erratic Tony.",
                ]
            }
        },
        new()
        {
            Name = "Warlock",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 5, vigilance: 4, ego: 9, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                        powerSelector.GetPower(PowerNames.Wisdom),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.SenseSupernatural),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Adam Warlock",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [240],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "eyes and bright golden skin",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.InfinityWatch],
                Base = "Mobile",
                History =
                [
                    "Adam Warlock was created by a group of evil geneticists known only as the Enclave. This shadowy organization sought to create the perfect human being—an all-powerful creature they could use to control the world. They succeeded in creating a very powerful creature, just not one that they could control.",
                    "Adam Warlock emerged from his biomechanical cocoon a fully grown adult. He instantly sensed the evil in the hearts of his creators and destroyed them. Then he set off across the cosmos to find his purpose.",
                    "In the years since his birth, Warlock has been at the center of several galaxy-spanning confl icts. He has contended with forces that threatened to consume all of existence, including the mad titan Thanos and the insatiable Hunger. Warlock has, on several occasions, died fi ghting for justice only to rise again, stronger than before.",
                    "Warlock’s already considerable powers are frequently augmented by the Soul Stone, one of the six Infi nity Gems. Although Warlock currently lacks a fully powered Soul Stone, he is still regarded as one of the toughest beings in the known universe."
                ],
                Personality =
                [
                    "Warlock’s early days were filled with anger and confusion. He had incredible power but only the most basic grasp of right and wrong. Years passed before he could form a coherent identity for himself. Only then was he ready to become the hero the world knows today.",
                    "The modern Warlock is a humble and determined warrior. He seeks to preserve life across the universe and to defeat evil wherever it may be."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Wasp (Janet Van Dyne)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 3, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, French, Hungarian, Italian, Spanish"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
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
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                        powerSelector.GetPower(PowerNames.Shrink3),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Janet Van Dyne",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Auburn",
                Size = Size.Varies,
                DistinguishingFeatures = "Cybernetic wings",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.AgentsOfWakanda, TeamNames.Avengers],
                Base = "Mobile",
                History =
                [
                    "Born a wealthy heiress, Janet Van Dyne caught the eye of brilliant scientist Hank Pym. The two quickly became partners, in both crimefi ghting and romance. Hank developed a special substance called Pym Particles, allowing him to grow and shrink his body mass at will. Using them, Hank and Janet became the super heroes known as Ant-Man and the Wasp, founding members of the Avengers.",
                    "Eventually, the pair split, their marriage irreparably broken by Hank’s often unstable and abusive behavior, but Janet never stopped being the Wasp. Over the years, she’s become a shining example of true heroism for people everywhere, far surpassing her ex-husband as a trusted leader in the super-hero community.",
                ],
                Personality =
                [
                    "Raised as a pampered socialite, Janet makes a surprisingly effective battle leader. However, her social skills also make her an excellent administrator. She takes an empathetic, understanding approach to tackling the problems of her allies and her friends.",
                ]
            }
        },
        new()
        {
            Name = "White Tiger (Ava Ayala)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
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
                RealName = "Ava Ayala",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [131],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.AvengersAcademy, TeamNames.DaughtersOfLiberty, TeamNames.HeroesForHire],
                Base = "Mobile",
                History =
                [
                    "After her family was murdered by the super villain Gideon Mace, Ava Ayala was left with no choice but to take hold of an old family heirloom, the mystical White Tiger Amulet. In years past, both her older brother and her niece had made use of the divine amulet’s powers, fi ghting for justice under the codename White Tiger. Now it was her turn.",
                    "Bent on revenge and determined to continue the legacy of the White Tiger, Ava left home and began training at the Avengers Academy. She quickly became a skilled and capable combatant. Despite recently having the powers of the amulet ripped away, she remains a powerful hero.",
                ],
                Personality =
                [
                    "Ava is a strongly determined person. She pursues her goals with unwavering conviction, and she expects others to do the same. She has very little time or patience for those whom she perceives not to be doing their utmost.",
                ]
            }
        },
        new()
        {
            Name = "Winter Soldier (Bucky Barnes)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese (Mandarin), English, German, Japanese, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James Buchanan “Bucky” Barnes",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [260],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Bionic left arm",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.KGB, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Toward the end of World War II, the aerial explosion that sent Captain America (Steve Rogers) into the north Atlantic where he froze into a block of ice seemingly killed his sidekick, the young Bucky (Bucky Barnes). He was captured by Soviet scientists, who replaced a missing arm with a bionic prosthetic and brainwashed him to become a Russian assassin codenamed the Winter Soldier, after which he was kept in suspended animation for decades, only released to kill and then returned to sleep again.",
                    "Cap eventually discovered who the Winter Soldier was and successfully undid Bucky’s brainwashing. During a period when Rogers was dead, Bucky took up the shield and replaced him as Captain America, but he has since returned to being the Winter Soldier and trying to use his skills for good.",
                ],
                Personality =
                [
                    "Bucky is a deadly serious and world-weary vet. The remorse he feels for his time as an assassin weighs on him every day.",
                ]
            }
        },
        new()
        {
            Name = "Wolverine (Laura Kinney)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.TechReliance),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Adamantium Claws [+1 Melee damage multiplier]",
                            meleeDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Laura Kinney",
                Heights = [new() { Feet = 5, Inches = 1 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium claws in hands and feet",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Laura Kinney was created as part of a secret attempt to re-create the experiment that gave the original Wolverine (Logan) his adamantium skeleton. She’s a partial clone of Logan himself, with DNA mixed in from Sarah Kinney, the geneticist who created her.",
                    "The shadowy figures funding this experiment intended for Laura to be an assassin, but Sarah Kinney took pity on her creation and helped Laura escape from their clutches. Free from her captors, Laura tracked down her genetic father and became his protégé. Now she fights alongside Logan, both of them acting under the codename Wolverine.",
                ],
                Personality =
                [
                    "Although the people who funded her creation did their best to erase her humanity, Laura Kinney has grown into a mature and empathetic young woman. She serves as a levelheaded counterpart to her younger, freewheeling genetic twin sister, Gabrielle Kinney (Scout).",
                ]
            }
        },
        new()
        {
            Name = "Wolverine (Logan)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 5, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Sabretooth"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Adamantium Claws [+1 Melee damage multiplier; ignores 1 level of DR]]",
                            meleeDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James Howlett (a.k.a. Logan)",
                Heights = [new() { Feet = 5, Inches = 3 }],
                Weights = [195],
                WeightReminder = "300 lbs. with adamantium",
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium claws, muttonchops",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.Avengers, TeamNames.FantasticFour, TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa, Summer House (the Blue Area of the Moon)",
                History =
                [
                    "Born in Canada in the late 1800s, James Howlett wandered the world under the name Logan. At one point, the Weapon X program captured him and bonded adamantium metal to his entire skeleton, including his retractable claws; his mutant healing factor enabled him to survive the experience. He escaped, but with large gaps in his memory.",
                    "Logan later joined the X-Men and became a valued member of various X-teams. Over time, he recovered most of his memories. He was killed in recent years, but returned to life in time to help establish a new mutant nation on the island of Krakoa.",
                ],
                Personality =
                [
                    "Logan can be cold-blooded and slow to trust others, but the restoration of his memory blunted those edges. He’s still a no-nonsense man, but that’s tempered with the wisdom age brings. After living as a loner for so long, he treasures his found family.",
                ]
            }
        },
        new()
        {
            Name = "Wong",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 7, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wong",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.MidnightSons],
                Base = "New York City",
                History =
                [
                    "Wong is the latest in a long ancestral line of Tibetan monks who have vowed to serve and protect the Earth’s Sorcerer Supreme. In that role, Wong has acted as an assistant to Doctor Strange for most of his adult life.",
                    "Years of working closely together have led to no small amount of friction between Wong and Doctor Strange. Strange's distant, intense and sometimes condescending personality matches poorly with Wong’s laid-back nature. The pair remain allies, though Wong has learned to take some breaks from Strange’s service, making time to strike out as a hero in his own right.",
                ],
                Personality =
                [
                    "Wong and Strange couldn’t be more different as people. Strange is generally sharp and sometimes abrasive to those around him, rarely cracking jokes. Wong, conversely, is a charming and humble man who has an easy time empathizing with the struggles of others.",
                ]
            }
        },
        new()
        {
            Name = "Wrecker (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 5, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Gullible),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Magic crowbar [Throwable club. Automatically returns to thrower.]"),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Dirk Garthwaite",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [320],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Dirk Garthwaite was just a small-time thief with a crowbar until the day he was accidentally granted magical powers originally meant for Loki. As the Wrecker, Garthwaite used his new powers to embark on a one-man crime spree across New York City, and it took the intervention of Thor to end his villainous rampage.",
                    "Garthwaite wound up serving time in Ryker’s Island. He eventually escaped, but only with the help of a few of his fellow inmates. Out of gratitude, he granted a portion of his own power to each of them, and they formed the nefarious Wrecking Crew.",
                    "Under the Wrecker’s leadership, the Wrecking Crew has committed countless crimes, often in the employ of smarter, more ambitious or more powerful villains."
                ],
                Personality =
                [
                    "Even before he had powers, Garthwaite was prone to fits of anger and violence. Most people consider him an impulsive man in need of some serious psychiatric help. He is admired by the other members of his crew—if by no one else.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
    ];
}
