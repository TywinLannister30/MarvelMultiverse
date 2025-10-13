using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersS
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
            Name = "Sandman",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 1, resilience: 3, vigilance: 6, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Water"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEarth,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.SlipFree),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow3),
                    ],
                },
            ],
            PowerNotes =
            [
                "Flight 1 represents Sandman’s ability to turn into a whirlwind of sand and float through the air."
            ],
            Biography = new Biography
            {
                RealName = "William “Flint Marko” Baker",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually around 6'1\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually around 450 lbs.",
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Varies,
                SizeNotes = "usually average",
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.FrightfulFour, TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Born William Baker, the future Sandman picked up the nickname of Flint Marko later in life—“Flint” because he’s built like a rock, and “Marko” because he’s determined to make a mark on the world.",
                    "Unfortunately, for most of Marko’s life, that mark has been exclusively negative. Expelled from high school for his uncontrollable temper, he spent the early years of his adulthood as a two-bit thief, landing himself an extended prison sentence.",
                    "Marko eventually escaped prison by crawling through a condemned tunnel system, inadvertently exposing himself to illicit radioactive waste that granted him the power to control—and even become—sand.",
                    "Believing himself to be untouchable, Marko embarked on a crime spree, robbing banks and terrorizing random people until Spider-Man (Peter Parker), in one of his earliest outings, came to the rescue by literally vacuuming Marko up.",
                    "Marko spent a long time trying to have his revenge on Spider-Man, but after many, many defeats, he got tired of being a villain and tried his hand at joining a few super-hero teams.",
                    "In the years since, he’s bounced back and forth between dozens of different super-teams, some of them heroic, many of them villainous."
                ],
                Personality =
                [
                    "Marko is a world-weary romantic whose villainous tendencies tear him up inside. Sometimes, this internal division manifests in subtle ways. Other times, it presents as something closer to a full-blown dissociative identity disorder, with “Flint Marko” being his evil half and “William Baker” being his true self.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Sasquatch",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 5, vigilance: 3, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "in Alternate Form; Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Sasquatch"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
                tagSelector.GetTag(TagNames.VisionIssues),
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
                        powerSelector.GetPower(PowerNames.Jump2),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Walter Langkowski",
                Heights = [new() { Feet = 6, Inches = 4 }, new() { Feet = 10 }],
                Weights = [245, 2000],
                Gender = Gender.Male,
                Eyes = "Blue/Red",
                Hair = "Blond/Brown-orange fur",
                Size = Size.Average,
                DistinguishingFeatures = "Massive furry body (in alternate form)",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.AlphaFlight, TeamNames.GammaFlight],
                Base = "Mobile",
                History =
                [
                    "Early on in his collegiate studies, Walter Langkowski made the acquaintance of a gifted young particle physicist named Bruce Banner. Although they only studied together for a semester, Banner’s passion for physics inspired Langkowski to pursue a career in that field himself.",
                    "After Banner’s transformation into the Hulk, Langkowski got to wondering if there wasn’t a way for him to make a similar—albeit more controlled—transformation. Working from Banner’s notes, Langkowski built and exposed himself to a sophisticated gamma ray emitter.",
                    "Miraculously, this device worked. Otherworldly interference made Langkowski’s powerful new form brown and furry, rather than green, but he managed to take on a form similar to that of the Hulk without Banner’s loss of control.",
                    "On the recommendation of his friend James Hudson (Guardian), Langkowski joined the Canadian super-team Alpha Flight. He spent the next several years adventuring with them before eventually transferring—along with a number of his teammates—to the gamma-mutate-focused team Gamma Flight.",
                    "Shortly after joining Gamma Flight, Langkowski inadvertently swapped bodies with another gamma mutate named Doc Samson. No one knows exactly how long this swap may last, but Langkowski and Samson are working to resolve the issue."
                ],
                Personality =
                [
                    "Unlike most gamma mutates, Langkowski is a relatively laid-back guy. He’s a highly intelligent and graceful fighter, disinclined to bouts of rage even in the direst of circumstances. He typically enters battle with a cheeky grin on his face. Like many Canadian natives, Langkowski spends most of his spare time drinking or fishing with friends.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Scarlet Spider",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 7, resilience: 4, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                RealName = "Kaine Parker",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Massive scars across entire body, particularly the face",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.NewWarriors, TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "Mobile",
                History =
                [
                    "When the Jackal (Miles Warren) set out to create a clone of Spider-Man (Peter Parker), it took him some time to iron out the kinks in his process. His first semi-successful attempt became Kaine Parker, an ultra-strong and disfigured version of Peter Parker.",
                    "Driven half to madness by the pain of gradual cellular degeneration, Kaine became everything he despised. A combination of self-hatred and love for the original Peter Parker eventually led Kaine to try to eliminate Peter’s other clones, particularly the Scarlet Spider (Ben Reilly).",
                    "Although Peter managed to talk Kaine out of killing Reilly, he could not convince the man to give up life as a criminal, and they clashed many times in the subsequent years. Their rivalry ended only after Kaine inadvertently discovered that the cure for a Spider-Virus that temporarily gave most of New York City super-powers could also cure his degenerative condition.",
                    "In full control of his faculties for the first time in his life, Kaine renounced his villainous ways and adopted the iconography of the man he once set out to kill, becoming the new Scarlet Spider.",
                    "With Ben Reilly recently having been corrupted into the amnesiac Chasm, Kaine is the only Scarlet Spider right now, though he is actively working to restore Reilly to his former state."
                ],
                Personality =
                [
                    "Kaine used to be a much darker, angrier person, but as the years have worn on, he’s reverted to a personality similar to that of the original Peter Parker. In some ways, he now has a brighter outlook on life than Peter. Kaine has none of Peter’s life obligations, and he can be the Scarlet Spider 24/7 without having to worry about anyone needing him elsewhere.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
            Name = "Scorpio",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 5, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "The Zodiac Key"),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                    IsTech = true
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "The Zodiac Key",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrage} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrier} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBlast} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalProtection1} (Energy)"),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBarrier, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBlast, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalProtection1, reminder: "Energy"),
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 4,
                }
            ],
            Biography = new Biography
            {
                RealName = "Jacob “Jake” Fury",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.Hydra, TeamNames.Zodiac],
                Base = "Mobile",
                History =
                [
                    "The younger brother of superspy Nick Fury Sr., Jake Fury is a World War II vet, Hell’s Kitchen native and seasoned secret agent.",
                    "Following the war, Jake became a spymaster, and in 1961, he and Nick joined the Great Wheel of Zodiac. The original Zodiac was an anti-imperialist group composed of the best spymasters on the planet, who sought to protect the world from dangerous lost technology. During one mission, Jake imprinted himself on an ancient automaton, inadvertently creating the first Life-Model Decoy (LMD). In service to their own plans, the Fury brothers decided to keep the LMD a secret. Shortly afterward, the Zodiac collapsed, and Jake went underground, with his LMD taking his place in public.",
                    "Unfortunately, Jake’s LMD was not a perfect copy. The LMD grew to hate the brothers and society at large and sought to destroy both. Using a weapon called the Zodiac Key and backed by a super-villain team modeled after the original Zodiac, the LMD launched several failed campaigns against his brother under the codename Scorpio, before eventually killing himself.",
                    "Now believed dead, the actual Jake remained undercover, eventually taking the place of a high-level Hydra agent known as the Kraken. Together, Jake and Nick orchestrated a war between Hydra and the secret Soviet spy group known as Leviathan that crippled both organizations.",
                    "This profile represents the Scorpio LMD at the height of its powers."
                ],
                Personality =
                [
                    "Whether his objective requires threatening a nun, pulling an old man off life support or brutally killing an enemy, Fury does the job without complaint. Brash and boastful, he can be just as hard-nosed and ruthless as his brother.",
                    "The Scorpio LMD is much the same as the real Jake Fury but with an added layer of instability and recklessness."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Scorpion",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 3, vigilance: 4, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder: "tail", isTech: true),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
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
                    IsTech = true
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
                    IsTech = true
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
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "MacDonald “Mac” Gargan",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown, usually shaved bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Investigator],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [TeamNames.CapeKillers, TeamNames.SinisterSix, TeamNames.Thunderbolts],
                Base = "New York City",
                History =
                [
                    "Determined to put his money where his mouth was, J. Jonah Jameson hired a small-time private investigator named Mac Gargan to take down Spider- Man (Peter Parker) and paid thousands of dollars for the man to receive an experimental treatment involving scorpion DNA. This treatment not only gave Gargan the proportional speed and strength of a scorpion, it also granted him perfect psychic control over a powerful mechanical tail. The overwhelming rush of becoming the Scorpion went straight to Gargan’s head, and he quickly abandoned the job he was hired for to embark on a crime spree across New York City, until he was eventually arrested by Spider-Man.",
                    "After several defeats at the hands of the wallcrawler, Gargan’s delusions of grandeur began to wear o¦ . He went back to being a freelance investigator and mercenary—fi rst for entirely criminal outfi ts like A.I.M. and then, as time went on, for increasingly legitimate organizations like the Thunderbolts and S.H.I.E.L.D.",
                    "Until recently, he was a key part of New York City’s “Cape Killer” crackdown on unauthorized super-hero activity. Now that the program has been disbanded, it’s anyone’s guess as to what the Scorpion might do next.",
                ],
                Personality =
                [
                    "Although he has gone through periods of mental instability, the Scorpion is widely considered to be one of the more reasonable people in Spider-Man’s villain repertoire. He may have a long-running grudge against both the Web-Head and J. Jonah Jameson, but he doesn’t let his darker emotions run his life. He does what he does primarily for the money and secondarily for fun, with revenge being a distant third priority.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Sebastian Shaw",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 1, resilience: 4, vigilance: 2, ego: 6, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Famous),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlForce,
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
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FocusedStrike),
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
                }
            ],
            Biography = new Biography
            {
                RealName = "Sebastian Hiram Shaw",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [210],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.HellfireTradingCompany, TeamNames.QuietCouncilOfKrakoa],
                Base = "Krakoa",
                History =
                [
                    "As a child of poverty, Sebastian Shaw has only ever cared about one thing: money. From the time he was a teenager, his sole goal in life has been to establish himself as the richest and most powerful man on the planet.",
                    "Shaw spent decades working his way up through the cutthroat world of international shipping. Then he took his millions and used them to take over the secretive Hellfire Club, turning it from a glorified social club for wealthy men into a mutant organization capable of conquering the planet.",
                    "Despite the fact that Shaw’s schemes for world domination have been consistently thwarted by the X-Men, he’s never stopped trying. Shaw is always working on some plot or another.",
                    "In exchange for the rights to several valuable drugs, Shaw agreed to temporarily place his resources in the control of the Krakoan government, allowing for the establishment of the Hellfire Trading Company. But make no mistake: Shaw does not have a generous bone in his body. He did this for personal gain, and given the opportunity, he would not hesitate to betray his collaborators for his own ends.",
                ],
                Personality =
                [
                    "Shaw dresses and acts like a Victorian-era nobleman. He believes that doing so makes him look distinguished and intelligent, although many other mutants believe he looks like a pretentious fool.",
                    "No one has a stronger distaste for Shaw than Emma Frost. Frost joined the Hellfire Club in its early days, but after realizing that Shaw was an ineffective leader, she quickly abandoned the organization. Since the founding of Krakoa, she has made it her personal mission to keep Shaw in line and, whenever possible, embarrass him."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Selim",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 3, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.Linguist),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.Young),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
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
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                RealName = "Selim",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [158],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "Brooklyn, New York City",
                History =
                [
                                        "As part of his plans to cause as much pain as possible for Spider-Man (Miles Morales), the villain Ultimatum hired an enigmatic artifi cial being known as the Assessor to capture, torture and clone the wall-crawler. Though the Assessor succeeded at the first two parts, he was not a particularly good cloner. Most of his creations degenerated into cellular goop within minutes. One survived for a few hours, just long enough to disintegrate while fighting Spider-Man.",
                    "Only three of the Assessor’s many clones were stable enough to survive more than a day. The strongest and smartest of these clones, Selim, led his brothers Shift and Mindspinner on a quest to escape the Assessor and find a cure for their degeneration.",
                    "However, Selim’s murderous tactics gradually turned his brothers against him, and after he kidnapped Spider-Man’s little sister, Billie, they teamed up to take him down. Ultimately, Mindspinner and Selim killed each other, leaving Shift as the only surviving clone.",
                    "The Selim of Earth-9375 defeated his world’s Spider-Man and conquered New York City, declaring himself Emperor Selim."
                ],
                Personality =
                [
                    "Miles Morales is no slouch in the intellect department, but Selim’s cold expertise puts him to shame. His ruthless cunning, complete amorality and stunning combat expertise would make him a tough opponent for any wall-crawling hero.",
                    "Despite his degenerative problems, Selim considers himself the perfect specimen, and he says his self-chosen name, in Arabic, means undamaged. (It also happens to spell Miles backward.)"
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Sentinel",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 5, vigilance: 3, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Sentinel Army)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.UnusualSize, reminder: "Gigantic; Reach 20"),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight1),
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
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
                Size = Size.Gigantic,
                DistinguishingFeatures = "Humanoid robot",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.SentinelArmy],
                Base = "Mobile",
                History =
                [
                    "A deep-seated fear of mutants led roboticist Bolivar Trask to design the first Sentinels: monstrous machines built expressly to hunt and kill mutants. Despite the fact that Trask’s original Sentinels eventually turned on him and he was forced to ask the X-Men for help defeating them, anti-mutant bigots have continued to follow in his footsteps, creating ever-more-dangerous versions.",
                    "One of the most common variants of Sentinel is the advanced giant Sentinel. These particular models have been referred to by many names across different timelines. Sometimes, they are called “Omega Class” or “Hunter-Seeker” Sentinels. Often, they are referred to simply by their model number. Most Sentinel models numbered MKIII and above owe something to this design.",
                    "These giant Sentinels represent a half step between Trask’s crude original designs and the inevitable end point of Sentinel development: the creation of the unstoppable machine organism known as Nimrod.",
                    "Giant Sentinels are powerful and easily capable of annihilating many mutants, but unlike most Nimrods, they can be outsmarted. They are not fully sentient, nor are they good planners. A well-balanced team of smart heroes can usually take a giant Sentinel down.",
                ],
                Personality =
                [
                    "Like most Sentinels, giant Sentinels are powered by a crude A.I. programmed to locate and kill mutants. Their speech is simple and robotic, devoid of any emotion or sympathy. They are perfectly willing to kill mutant children to fulfill their programming.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Sentry",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 5, resilience: 8, vigilance: 3, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bob Reynolds"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, reminder: "The Void"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
                tagSelector.GetTag(TagNames.SecondaryMutation, reminder: "known to allies"),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
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
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.Invisibility),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BumpPower),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Confidence"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            PowerNotes =
            [
                "When killed, the Sentry becomes Bob (use the Average Civilian profile in the Core Rulebook), with 1 Health and 1 Focus. Bob can become the Sentry again when restored to full Health and Focus. When shattered, the Sentry becomes the Void, at full Health and Focus."
            ],
            Biography = new Biography
            {
                RealName = "Robert “Bob” Reynolds",
                Heights = [new() { Feet = 6 }, new() { Feet = 6, Inches = 2 }],
                Weights = [194,200],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DarkAvengers, TeamNames.MightyAvengers, TeamNames.NewAvengers],
                Base = "Mobile",
                History =
                [
                    "In college, Bob Reynolds began to hear voices. Over time, they pushed him into drug abuse in an attempt to self-medicate. Looking for a new high, Reynolds broke into a local lab and drank a vial containing an experimental serum, granting himself incredible super-powers.",
                    "As the Sentry, Reynolds’ powers are nearly unsurpassed, making him the last line of defense for Earth. However, due to his mental instability, he is also closely monitored by all manner of government agencies and the super-powered community. His greatest enemy is the Void—the manifestation of his own self-destructive impulses. The Sentry and the Void are two sides of the same coin, and at times, they have both separately and simultaneously controlled Reynolds’ body.",
                    "After being killed in battle by Knull, Reynolds took his place in Valhalla, and the Sentry’s power was split up among several people. It eventually consolidated in Solarus (Mallory Gibbs). This profile represents the Sentry when he was a member in good standing of the Avengers.",
                ],
                Personality =
                [
                    "Reynolds’ mental health burdens are more numerous and heavy than any one man—even with godlike abilities—could be expected to handle on his own. His friends help him manage, but unfortunately, his reliance on them makes his friends an easy target for manipulation by those looking to use the Sentry’s powers for their own ends.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Sersi",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 4, vigilance: 5, ego: 6, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MahdWyry),
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
                        powerSelector.GetPower(PowerNames.GroupFlight),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportTogether),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Sersi",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.Avengers, TeamNames.Eternals, TeamNames.NewAvengers],
                Base = "Mobile",
                History =
                [
                    "Long ago, mysterious cosmic beings known as Celestials visited Earth and experimented on the planet’s proto-humans, transforming them into Deviants—unstable humanoids who inevitably degenerated into grotesque monsters. To curb this threat, the Celestials also created Eternals, a race of immortal superhumans genetically programmed to kill degenerated Deviants.",
                    "The Eternals have dealt with the ennui of their unusually long existences in different ways. For most of Sersi’s existence, she kept her spirits up by hosting massive galas and indulging in all manner of debauchery to distract her from the slow march of time—and from her discovery that, every time an Eternal dies, Earth restores them by taking the life of a mortal.",
                    "Sersi only became involved in world affairs after two other Avengers-associated Eternals—Starfox and Gilgamesh—brought the super-team to one of her parties. Sersi made friends with the team’s leaders, and after Gilgamesh was injured in battle, they invited her in as his replacement.",
                    "Though Sersi proved to be a strong Avenger, she eventually abandoned the team and returned to the Eternals. The Avengers later allied with the Eternals to fight the Progenitor: a rogue Celestial bent on ushering in Judgment Day. Moments before Earth was to be wiped out, Sersi broadcast the truth behind the Eternals’ immortality to the entire planet. As a reward for this show of selflessness, the Progenitor spared Earth but permanently destroyed Sersi.",
                ],
                Personality =
                [
                    "Hedonistic and self-absorbed by nature, it took countless centuries for Sersi to begin thinking about how to better the world rather than just how to distract herself from its horrors. Her final sacrifice proves that anyone can change, even Eternals.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Shadow King",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 2, vigilance: 8, ego: 6, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Mysterious),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
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
                RealName = "Unknown",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Varies,
                SizeNotes = "typically Average",
                DistinguishingFeatures = "Varies",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.BrotherhoodOfEvilMutants],
                Base = "Mobile",
                History =
                [
                    "The exact origins of the Shadow King remain unknown. Some say he is a living nightmare, the very manifestation of humanity’s cruelty. Others believe that he was never anything more than Amahl Farouk, a two-bit con man from Egypt who lucked into powerful telepathic abilities and made up the legend of the Shadow King to excuse his own bad behavior.",
                    "What we know for certain is that some decades ago, a young Professor Charles Xavier ran into Amahl Farouk in Cairo. They engaged in a psychic battle, and Xavier, eking out a narrow victory, blasted Farouk (and also, perhaps, the Shadow King) into the astral plane.",
                    "From that day forward, the Shadow King made it his sole mission in life to get revenge on Xavier. The dark regent has, at various times in the past, possessed several of Xavier’s students and turned them against their teacher—including, most infamously, Xavier’s son, Legion.",
                    "Claiming to have freed himself from the Shadow King’s influence, Amahl Farouk recently attempted to take up residence on the new mutant nation of Krakoa. However, after an incident in which the Shadow King’s lingering essence re-emerged from Farouk’s psyche and had to be purged once again, Farouk agreed to leave Krakoa and enter into a long-term rehabilitation program on Arakko."
                ],
                Personality =
                [
                    "The Shadow King is a sadistic blowhard who delights in psychically torturing others. He loves nothing more than to trap people within their own fears and insecurities, forcing them to face their worst and most painful traumas. He can be quite polite and persuasive when he wants to be, but he is a manipulative and conniving creature, fully capable of setting short-term victories aside in the pursuit of a greater prize.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Shaman",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 2, vigilance: 3, ego: 6, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
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
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Mammals"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlWeather2),
                        powerSelector.GetPower(PowerNames.Thunder)
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Michael Twoyoungmen",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.HealthCareWorker],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.AlphaFlight, TeamNames.StrangeAcademy],
                Base = "Mobile",
                History =
                [
                    "As a teenager, Michael Twoyoungmen wrote off the ancient treatments of his Tsuut’ina ancestors as a bunch of nonsense. He left the reservation behind to practice scientific medicine elsewhere.",
                    "Twoyoungmen had a natural talent for medical work, and in short order, he became one of Canada’s top surgeons. However, for all his talents, he could not save the life of his own wife, who died of a disease his colleagues called inoperable and incurable.",
                    "Disillusioned with western medicine, Twoyoungmen spent the next several years of his life in seclusion, communing with the spirit of his grandfather and learning the magics of his people.",
                    "Determined to use his new mystic powers for the protection of all Canadians, Twoyoungmen took up the codename of Shaman and joined Alpha Flight. He has been with the organization ever since, acting as the team’s healer and mystic expert, though these days—with Alpha Flight’s regular activities taking a back seat to more experimental projects like Gamma Flight—Shaman spends most of his time teaching medicinal magic at Strange Academy."
                ],
                Personality =
                [
                    "More than anything, Shaman is a man blindly driven toward his goals. This has allowed him to achieve great feats, but it has also been the cause of his greatest failures. He believed there was no place for his daughter Elizabeth in his mystic studies or his adventures, so he abandoned her. In her place, he adopted the demigod Narya, raising her into Snowbird of Alpha Flight.",
                    "To reclaim her father’s attention, Elizabeth became the super hero Talisman. Shaman has apologized to Talisman repeatedly for leaving her behind, but their relationship remains fraught. It may never be fully healed."
                ]
            },
            Source = BookSource.XMenExpansion
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
            Name = "Shang-Chi (with the Ten Rings)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 5, resilience: 4, vigilance: 5, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese (Cantonese, Mandarin and other dialects), English"),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "The Ten Rings", isMagicItem: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.DefenseStance),
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "The Ten Rings",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.CrimsonBandsOfCyttorak),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Flight1),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.ReturnsWhenThrown),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.SummonPortal),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10 spaces, Melee/Agility Damage Multiplier bonus: +1."),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.CrimsonBandsOfCyttorak),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 5,
                    MeleeDamageModifier = 1,
                }
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
                Origins = [OriginName.Magic, OriginName.SpecialTraining],
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.Avengers, TeamNames.FiveWeaponsSociety, TeamNames.HeroesForHire, TeamNames.Protectors],
                Base = "Chinatown, New York City",
                History =
                [
                    "As the son of the criminal mastermind Zheng Zu, Shang-Chi—who believed his father to be a good man—was trained from an early age to become the ultimate martial artist. When sent on a mission to assassinate one of his father’s enemies, he learned the truth and vowed to destroy his father’s criminal empire instead.",
                    "After Zheng Zu’s death, Shang-Chi inherited his father’s position as the Supreme Commander of the Five Weapons Society. He also learned that his mother—Jiang Li—hailed from the pocket dimension Ta Lo, and that her father—Chieftain Xin—wanted to destroy Shang-Chi’s entire family and take possession of the mystical Ten Rings.",
                    "Thankfully, with some help from his mother, Shang-Chi managed to defeat Xin and harness the power of the Ten Rings for himself. In the years since, Shang-Chi has either given up or lost the rings many times, but this profile represents him at the height of his powers, armed with all Ten Rings."
                ],
                Personality =
                [
                    "Shang-Chi is a loyal friend and a determined leader who has worked hard to refute his father’s criminal legacy. He regularly wrestles with the temptations of power, and it is only his determination not to follow in his father’s footsteps that has kept him from being corrupted by items like the Ten Rings.",
                    "Despite all his troubles, Shang-Chi has always managed to maintain a light and friendly demeanor."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Shathra",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 7, vigilance: 6, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.HiveMind, reminder: "Leader of the Great Hive"),
                traitSelector.GetTrait(TraitNames.Infector, reminder: "Spider-Wasp Venom"),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlSwarm,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.SummonPortal),
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
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "wasps"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Shathra",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Brown, glowing white (in corrupted form)",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Corrupted form is uniformly black with claws, wings, antennae and fangs",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MagicSorcery, OriginName.Mythic],
                Teams = [TeamNames.TheHive],
                Base = "Astral Plane",
                History =
                [
                    "Long ago, when existence was still young, the elder goddesses Gaea and Oshtur tasked their daughters Shathra and Neith with deciding the shape of the coming Multiverse. Envisioning a place of hierarchy and order, Shathra proposed the Great Nest: a collection of tightly connected universes with their own universe, Earth-001, as the central authority. Neith, in turn, designed the Great Web of Life and Destiny as a critique of her sister’s creation: a network of equal universes where each supports the other.",
                    "Gaea and Oshtur supported Neith’s vision, and though Shathra tried to pretend that the snub didn’t bother her, her rage and envy slowly consumed her, turning her into a shadow of her former self. Over the subsequent eons, Neith’s Great Web of Life and Destiny grew into the Web of Life and Destiny, and Earth-001 became Loomworld, the place where the web was spun.",
                    "Meanwhile, Shathra’s shadow roamed aimlessly across the Multiverse, instinctively destroying pieces of her sister’s Web. Eventually, her journey brought her to Earth-616, where Spider-Man (Peter Parker), Ezekiel Sims and, later, Kaine, banished her into the depths of the Web.",
                    "Years later, while investigating the Web of Life and Destiny’s origins, Spiderling inadvertently summoned Shathra back into Earth-001. Shathra used her powers to erase a large chunk of the Web and corrupt much of the Spider-Army, but the remaining members managed to defeat her, cleansing both her and the heroes she had corrupted, turning them back to normal."
                ],
                Personality =
                [
                    "Shathra is normally an intelligent if prideful goddess, no different from many of the gods of Asgard or Olympus. However, her corrupted form is borderline animalistic. Consumed entirely by her desire to sow chaos and death throughout the Web of Life and Destiny, she speaks in the hissing voice of a Spider-Wasp, the arachnid’s natural enemy.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Shatterstar",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 5, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Dual swords"),
                tagSelector.GetTag(TagNames.Sorcerous),
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
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Gaveedra Seven",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [95],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red, formerly blond",
                Size = Size.Average,
                DistinguishingFeatures = "Star-shaped mark over left eye; eyes sometimes glow when using powers",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant, OriginName.WeirdScience],
                Teams = [TeamNames.XCorp, TeamNames.XFactor, TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "During the brief period when Longshot and Dazzler (Alison Blaire) were married and fighting a rebellion to liberate Mojoworld, they had a son. Their son was delivered by a future version of himself, who erased his parents’ memories of his existence and then sent his infant self one hundred years into the future. The boy grew up, took on the codename Shatterstar and launched a rebellion of his own. Then, hoping to recruit allies, he sent himself back to the current day of Earth-616.",
                    "There Shatterstar encountered Cable, who agreed to assist his rebellion if Shatterstar would, in turn, help him establish X-Force. Shatterstar spent years adventuring with X-Force, but after M-Day he left the team to join some of his colleagues in X-Factor Investigations. Shortly thereafter, he came out as gay and began dating Rictor.",
                    "Just as X-Factor Investigations was beginning to fall apart, Shatterstar and Rictor were sucked into the past of the Mojoverse. On Mojoworld, a genetic scientist used some of Shatterstar’s DNA to create Longshot, effectively making Shatterstar his own grandfather. Realizing this, Shatterstar jumped forward in time and kidnapped himself as an infant, completing the temporal loop.",
                    "Once Shatterstar and Rictor returned to the present, they agreed to join Krakoa’s Excalibur."
                ],
                Personality =
                [
                    "For a long time, Shatterstar had difficulties being close with others. The survival instincts he developed over the course of his bizarre and traumatic upbringing made it hard for him to be friendly with teammates. Although his relationship with Rictor has somewhat ameliorated these old issues, Shatterstar still has times when he simply needs to be alone.",
                ]
            },
            Source = BookSource.XMenExpansion
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
                        powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Serenity"),
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
            Name = "Shift",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 4, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 8 (due to Big)"),
                        powerSelector.GetPower(PowerNames.FlexibleBones1)
                    ]
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Shift",
                Heights = [new() { Feet = 7, Inches = 2 }],
                Weights = [598],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Big,
                DistinguishingFeatures = "Massive, morphable and heavily scarred body",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "Brooklyn, New York City",
                History =
                [
                    "As part of his plans to cause as much pain as possible for Spider-Man (Miles Morales), the villain Ultimatum hired an enigmatic artifi cial being known as the Assessor to capture, torture and clone the wall-crawler. Though the Assessor succeeded at the first two parts, he was not a particularly good cloner. Most of his creations degenerated into cellular goop within minutes. One survived for a few hours, just long enough to disintegrate while fighting Spider-Man.",
                    "Only three of the Assessor’s many clones were stable enough to survive more than a day. The strongest and smartest of these clones, Selim, led his brothers Shift and Mindspinner on a quest to escape the Assessor and find a cure for their degeneration.",
                    "However, Selim’s murderous tactics gradually turned his brothers against him, and after he kidnapped Spider-Man’s little sister, Billie, they teamed up to take him down. Ultimately, Mindspinner and Selim killed each other, leaving Shift as the only surviving clone.",
                    "In the immediate aftermath, Billie gave Shift a cold that, by some miracle, cured his degeneration. After a few adventures together, Spider-Man invited Shiftto formally join the Morales household."
                ],
                Personality =
                [
                    "Shift’s weird, morphable body keeps him from easily manipulating his own vocal cords. For most of his life, he could only get out the occasional grunt or gurgle. However, Spider-Man’s friend Ms. Marvel (Kamala Khan) began working with Shift to train his vocal muscles, and he can now speak in short, rough sentences. Even with his broken speech, it’s easy to tell that he has a sense of humor and camaraderie similar to Spider-Man’s own.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Shocker",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 3, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.ElementalBarrage),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlAir,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion)
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
                RealName = "Herman Schultz",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Engineer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.SinisterSix, TeamNames.Thunderbolts],
                Base = "New York City",
                History =
                [
                    "Second-story man Herman Schultz never had any skill for cracking safes, but during a long stint in prison, he discovered that he had an incredible talent for electrical engineering. Using the tools in the jail workshop, he tried to create a vibrational device capable of countering any safe’s tumblers.",
                    "Although Schultz failed to build a universal safe-cracker, he succeeded in constructing a vibro-shock generator capable of blasting through walls. Spying an opportunity at freedom, he fit his new generator into a pair of gauntlets, wove himself a recoil-negating suit and blasted his way out of prison.",
                    "As the Shocker, Schultz embarked on a crime spree, blasting through dozens of banks. He was eventually stopped by Spider-Man (Peter Parker), but his ability to battle the wall-crawler to a near draw made him a hot topic throughout the underworld.",
                    "Over the years, the Shocker garnered work with dozens of mercenary groups—mostly criminal outfi ts like the Maggia, but also semi-legitimate organizations like the Thunderbolts. He worked for the Hobgoblin (Roderick Kingsley) during the gang war that recently consumed much of New York City, but when the Hobgoblin began losing ground to his rivals, the Shocker joined the rest of the crew in turning on their boss and fleeing for the hills."
                ],
                Personality =
                [
                    "A lifetime of failure has given the Shocker deep insecurities. He couldn’t hack it as a regular guy—or as a regular criminal—so he clings desperately to the limited success he’s achieved as a super villain. So much as suggest that he might not be the brilliant mastermind he thinks he is, and the Shocker fl ies into a violent rage.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Shroud",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 3, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.Sneaky),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.VisionIssues, reminder: "blind; “sees” with ESP"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                        powerSelector.GetPower(PowerNames.ElementalGrab)
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Darkness),
                        powerSelector.GetPower(PowerNames.Illumination),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ESP),
                    ],
                },
            ],
            PowerNotes =
            [
                "Shroud draws his Elemental Control (Energy) powers from the Darkforce dimension, so his blasts and bursts appear dark in color."
            ],
            Biography = new Biography
            {
                RealName = "Maximillian Quincy Coleridge",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Facial scar in shape of Kali",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.HeroesForHire, TeamNames.SecretAvengers],
                Base = "New York City",
                History =
                [
                    "As a child, Maximillian Coleridge was forced to watch helplessly as his parents were gunned down by a mugger. Resolving to fight crime for the rest of his life, Coleridge took to studying criminology and martial arts. Having heard rumors of the Cult of Kali’s mastery of darkness and other strange abilities, he traveled to Nepal and sought them out. The cult trained him, taught him to worship their goddess and branded his face, blinding him.",
                    "When Coleridge recovered, he discovered he no longer needed his eyes to see and could access the Darkforce, granting him super-powers. He adopted the codename Shroud and, following a failed attempt to kill Doctor Doom, he took up residence in Los Angeles, pretending to be a villain. He briefly led a team called the Night Shift, composed of super villains he tricked into performing heroic acts, until he was eventually ousted.",
                    "After a brief stint in New York with Misty Knight’s Heroes for Hire, Shroud fell into a depression and moved to San Francisco. Acting increasingly reckless, he attacked Daredevil (Matt Murdock) when the hero moved to San Francisco, but Shroud eventually helped him bring down the criminal empire of Kingpin (Wilson Fisk).",
                    "Searching for purpose, Coleridge briefly attempted to take the mantle of Moon Knight following Marc Spector’s death, but Spector soon returned. Coleridge, in turn, went back to being Shroud."
                ],
                Personality =
                [
                    "Since the death of his parents, Coleridge has dedicated his life to fighting crime, and his mission has taken a toll on him. A once-lively man, Coleridge has grown more bitter and erratic over the years, deploying increasingly violent and sadistic methods against criminals. He tends to drift between various super-villain and super-hero teams, working with whomever he thinks can help him further his mission at any given moment.",
                ]
            },
            Source = BookSource.AvengersExpansion
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
            Name = "Sif",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 4, vigilance: 7, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Hofund", isMagicItem: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Wisdom),
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
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            IconicItems =
            [
                new()
                {
                    Name = "Hofund",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.SummonPortal),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier bonus +2."),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Sif",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [425],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black, formerly blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.WarAvengers],
                Base = "Asgard",
                History =
                [
                    "Sif and Thor grew up alongside each other, and they have been lovers on and off since they became adults. However, while Thor loves Sif, he also loves Earth, and Sif’s first priorities have always been their home: Asgard.",
                    "For many years, Sif indulged Thor in his long sojourns away from Asgard, allowing him to go off and have whatever dalliances he pleased on Earth, then returning to her role as his stalwart lover and ally as soon as he returned. But after years of going back and forth in their relationship, the pair began to grow apart. Sif started to go on her own adventures and even take other lovers—most notably Beta Ray Bill.",
                    "Eventually, Thor and Sif both agreed that they would be better off remaining friends. Soon after that, Sif’s brother Heimdall was killed by Bullseye, and Sif found a new role for herself in Asgard, filling her brother’s shoes by acting as the guardian of the Rainbow Bridge."
                ],
                Personality =
                [
                    "Sif is a proud warrior woman, every bit as stalwart and noble as any of the heroic souls who walk Valhalla’s halls. She could probably take Thor’s place on the Avengers if necessary, but she prefers a somewhat quieter life.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Silence",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 3, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.MagicItemReliance, reminder: "Hell-Mark"),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Agent Anti-Venom"),
                tagSelector.GetTag(TagNames.Poor),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Hell-Mark [Grants Elemental Burst (Hellfire). Also allows Silence to create dimensional portals exclusively to and from Hell. She must still pay the regular Dimensional Portal power cost of 15 Focus.]", isMagicItem: true),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlHellfire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsMagicItem = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Healing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HealingHands),
                        powerSelector.GetPower(PowerNames.LetsGo),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Andrea “Andi” Benton",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black, usually dyed purple",
                Size = Size.Average,
                DistinguishingFeatures = "Red and white Silence form has claws, no visible mouth",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicDemonic, OriginName.SymbioteVenom],
                Teams = [TeamNames.VenomverseResistanceMovement],
                Base = "New York City",
                History =
                [
                    "When Flash Thompson was Agent Venom, he briefl y took a job coaching gym at a high school. While there, he befriended a bullied teen named Andi Benton. Benton and her father lived in an apartment just upstairs from Thompson, and when an agent of Thompson’s nemesis Jack O’Lantern— masquerading as the villain—attacked, they were caught in the crossfire.",
                    "The attacker killed Benton’s father and was about to kill her too when Thompson transferred a piece of his symbiote to her. This piece happened to contain the enchanted Hell-Mark that Thompson had previously taken from Mephisto, and it imbued her with the powers of both a demon lord and a symbiote.",
                    "As the unstable but heroic Mania, Benton became Thompson’s new partner, helping him to battle the likes of Jack O’Lantern and Carnage. Sometime later, Venom’s enemy Lee Price ambushed Benton and stole the Mania symbiote, turning himself into Maniac. Thompson defeated Maniac, but in the process, he effectively destroyed the Mania symbiote.",
                    "Benton eventually regained her symbiote powers by convincing the Scream symbiote to break its connection with Carnage’s hive mind, but Scream soon returned to Carnage’s side. However, with help from Alchemax scientists, Benton used Thompson’s new Anti-Venom symbiote to turn some of Scream’s remnants into a new symbiote named Silence. Fully repowered, she resumed her old partnership with Thompson."
                ],
                Personality =
                [
                    "Benton may dress goth and act like she doesn’t care, but her hard exterior belies a heart that is profoundly compassionate and caring. She frequently prioritizes the safety and well-being of others over her own and is, at the moment, both a resident and a volunteer at the F.E.A.S.T. homeless shelter.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "New York City",
                History =
                [
                    "As a teenager, Cindy Moon was bitten by the exact same radioactive spider that gave Spider-Man (Peter Parker) his powers. Her own powers proved a powerful lure for the multiversal predator Morlun, so she was locked away in a bunker for her own safety for thirteen years. After learning of Moon’s existence, Parker freed her from her bunker, unintentionally launching Morlun’s hunt for her once again.",
                    "Morlun and his family of hero hunters have since been defeated, and Moon has been reunited with her family. Today, she works as a reporter for J. Jonah Jameson’s new outlet, Threats and Menaces, and helps save the world as the spiderpowered hero Silk.",
                    "Silk has truly come into her own as a hero. She wound up being the most important hero in the battle against Shathra and has taken on a leadership role in the new Spider-Society. She considers fellow female wall-crawlers Araña and Madame Web to be her best friends."
                ],
                Personality =
                [
                    "A decade of nearly complete isolation gave Moon no small amount of social anxiety. Although she’s made great strides in the last few years, she still has some trouble socializing, particularly with people she doesn’t know well. Despite her fears, Moon’s unwavering heroic spirit allows her to push forward in her adventures.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Silver Samurai",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 1, resilience: 5, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal (Yakuza)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Katana (Sword)"),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
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
                        powerSelector.GetPower(PowerNames.FocusedStrike),
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
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Kenuichio “Ken” Harada",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [250],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Mutant, OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra, TeamNames.Yakuza],
                Base = "Krakoa",
                History =
                [
                    "Kenuichio Harada has been mixed up in the world of organized crime since the day he was born. As the son of Yakuza boss Shingen Harada, Ken spent his youth learning the skills he would need to one day take his father’s place. He took to the training like a fish takes to water, immediately excelling both in finance and in hand-to-hand combat. His prowess in battle was enhanced by his mutant power, which allows him to create a tachyon energy field.",
                    "After his father was killed in a duel with Wolverine (Logan), Ken assumed his long-awaited place as head of the Harada clan. He immediately entered into a long-term rivalry with Wolverine, setting the entirety of Japan’s criminal underworld on a mission to capture and execute the mutant hero.",
                    "After being defeated by Wolverine several times, Ken gave up on killing the mutant hero and instead became his friend. On Krakoa, Ken ran a combat arena, one which Wolverine frequently attended.",
                ],
                Personality =
                [
                    "Ken Harada styles himself as a feudal-era samurai, but his actions often conflict with a true samurai’s code. He initially adopted the identity of the Silver Samurai to intimidate his enemies and underlings, and it worked so well that he just kept doing it. This persona is largely based on the samurai films and comics he consumed as a child.",
                    "Harada’s ruthlessness is both his greatest strength and his greatest weakness. His determination to get the job done, no matter the cost, allows him to go toe-to-toe with combat experts like Wolverine. However, that philosophy has also led him into making alliances of convenience with evil organizations like Hydra."
                ]
            },
            Source = BookSource.XMenExpansion
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
            Name = "Silvermane",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
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
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Silvio Manfredi",
                Heights = [new() { Feet = 7 }],
                Weights = [440],
                Gender = Gender.Male,
                Eyes = "Gray",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Cybernetic body",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.Hydra, TeamNames.Maggia],
                Base = "New York City",
                History =
                [
                    "As the decades-long head of one of the most powerful Maggia families on the East Coast, Silvio Manfredi had more experience dealing with crimefi ghters—both super and non-super—than almost anybody else on the planet. He was so vital—not just to the operations of his family, but to all organized crime—that his people set out to ensure that he would never die. They went on a mission to obtain an elixir of eternal life, and after that failed, they put into place another, less mystical contingency plan.",
                    "When Manfredi was eventually struck down by Cloak and Dagger, his people took him apart and put him back together in a top-of-the-line cybernetic body. Now more robot than man, Manfredi was stolen and reprogrammed into a mindless killing machine by his greatest rival: the Kingpin. Although he later regained his senses, this brief absence allowed for the Kingpin to conquer much of Manfredi’s territory, cementing his place as an all-encompassing leader of organized crime.",
                    "Though their power continues to diminish, Silvermane and the Manfredi family have managed to linger. They had a chance at regaining some of their lost glory during the gang war that recently overtook most of New York City, but along with the rest of the old-timers, Silvermane ultimately lost the confl ict to Tombstone’s faction."
                ],
                Personality =
                [
                    "Silvermane is an irritable—verging on unhinged—old man with little patience for dealing with anyone other than himself. His children, Joseph Manfredi and Saya Ishii, have both become respectable Maggia leaders in their own right, but Silvermane couldn’t care less. He would rather reminisce about his glory days than spend time with them—or anyone else, for that matter.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Sin-Eater",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 3, vigilance: 2, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Sin-Eating Shotgun [Applies the effects of Penance Stare on a Fantastic success; otherwise acts as a normal shotgun]"),
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
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Stanley “Stan” Carter",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [237],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown with gray temples",
                Size = Size.Average,
                DistinguishingFeatures = "Half-decayed, zombified appearance",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.Magic, OriginName.WeirdScience],
                Teams = [TeamNames.NYPD, TeamNames.SHIELD],
                Base = "New York City",
                History =
                [
                    "Once an ordinary if slightly overzealous S.H.I.E.L.D. agent, Stan Carter’s life changed forever when he volunteered as a test subject for a new Super-Soldier Serum. The drug—a heavily modifi ed variant of the hallucinogenic compound PCP—succeeded in granting Carter a limited form of super-strength, but it also made him mentally unstable, sometimes even violent. Ultimately, S.H.I.E.L.D. higher-ups were forced to scrap the project and fire Carter.",
                    "In the aftermath, Carter got a new job working for the New York Police Department, where he became increasingly paranoid. When he found out that his partner was secretly pushing drugs for the mob, his mind broke. In a dissociative fugue state, he killed his partner and adopted the identity of Sin-Eater.",
                    "Donning a hastily constructed disguise, Carter embarked on a campaign of terror across New York City, killing every corrupt priest, politician and cop he could get his hands on—including, most infamously, NYPD Captain Jean DeWolff.",
                    "Spider-Man (Peter Parker) eventually managed to capture Carter. Shortly thereafter, the Sin-Eater was shot down by the NYPD while attempting to escape prison.",
                    "Years later, Carter was resurrected by the demonic Kindred and given the power to literally devour sins, which he used to suck the evil out of several major villains, including the Green Goblin. The current whereabouts of this partially zombifi ed Sin-Eater remain unknown."
                ],
                Personality =
                [
                    "Stan Carter sees himself as the ultimate good guy: a holy warrior sent by God to cleanse the world of all corruption. In truth, he is nothing more than a run-of-the-mill serial killer, and somewhere deep inside, he knows it. His mad zealotry exists as a shield to protect himself from having to consider the consequences of his actions.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Siryn",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 2, vigilance: 3, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Investigation),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlSound,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Theresa Rourke Cassidy",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XFactor, TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "Sean Cassidy (who later became the hero known as Banshee) was too wrapped up in the world of international espionage to notice when one of his old flames, Maeve, gave birth to a girl named Theresa. Maeve died shortly after the birth, and Banshee’s cousin and rival, Black Tom (Thomas Cassidy), kidnapped the infant.",
                    "Black Tom raised Theresa to be a criminal, and once she was old enough, he began having her accompany him on his super-villain escapades, as the Siryn. The guilt of a criminal life weighed heavily on her mind, though, and Black Tom couldn’t help but regret forcing her into it. After a botched job nearly landed them both in prison, he wrote to Banshee, revealing the truth of Siryn’s birth.",
                    "She reunited with her father, and under his tutelage, Siryn became a super hero. She joined X-Force shortly after its foundation and quickly became one of its most important members. After M-Day, Siryn moved to X-Factor Investigations and had a son with a duplicate of her long-term partner, Multiple Man. Unfortunately, Multiple Man accidentally absorbed the infant upon first holding him, and their relationship hasn’t been the same since.",
                    "Shortly after leaving X-Factor Investigations, Siryn was possessed by the dark god Morrigan. She wasn’t freed until after the foundation of Krakoa, at which point she dropped out of active duty to focus on herself.",
                ],
                Personality =
                [
                    "Even more of a devout Catholic than her father, Siryn believes it is her duty in life to protect as many people as possible. She takes her responsibilities as a super hero seriously and blames herself for any casualties incurred on the job.",
                ]
            },
            Source = BookSource.XMenExpansion
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
                    "Over the past ten million years, the Skrull Empire has spread its influence throughout the galaxy— first as traders and then as invaders—conquering hundreds of planets, including the entire Andromeda Galaxy. After Galactus devoured their homeworld, they were scattered among the stars, but they recently allied with their ancient enemies—the Kree—under the leadership of Emperor Dorrek VIII, also known as the Earth hero Hulkling.",
                ],
                Personality =
                [
                    "The militaristic culture of the Skrull Empire has turned many Skrulls into jingoistic monsters. Few of them would hesitate to give their lives for the Empire. They have been raised to believe that they are the greatest, most worthy race of people in the universe. Other people are inherently lesser and deserve to be conquered.",
                ]
            }
        },
        new()
        {
            Name = "Sleeper",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 4, resilience: 3, vigilance: 5, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimatedIllusion),
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.Invisibility),
                        powerSelector.GetPower(PowerNames.StaticIllusion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Sleeper",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually around 9\"",
                Weights = [],
                VariableWieght = true,
                Gender = Gender.None,
                GenderReminder = "it/its",
                Eyes = "Red",
                Hair = "None",
                Size = Size.Varies,
                SizeNotes = "usually Small",
                DistinguishingFeatures = "Shape-shifting symbiote with black-and-yellow features, usually takes the form of a cat",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.SymbioteVenom],
                Teams = [],
                Base = "Mobile",
                History =
                [
                    "The symbiote known as Sleeper was spawned from Venom in Alchemax labs. When the Kree warrior Tel-Kar—the Venom symbiote’s fi rst host—stole the Venom symbiote from Eddie Brock, Sleeper bonded with Brock to pursue the thief. Eventually, Sleeper bonded with Tel-Kar instead and destroyed the Kree’s mind.",
                    "Using Tel-Kar as a mindless host, Sleeper traveled the universe until it reached Klyntar. When it realized that Knull was working his way loose, Sleeper returned to Earth to warn Brock. Sleeper tried to bond with Brock’s son, Dylan, to protect him, but the boy’s innate symbiote powers prevented it.",
                    "Instead of finding a new host, Sleeper took the form of a cat and moved in with Eddie and Dylan. For a while, Sleeper bonded with Hank Hensley, a friend of Flash Thompson. Hensley has no memory of serving as a symbiote’s host.",
                    "After Brock defeated Knull and took his place as the King in Black, Dylan bonded with Venom, and Sleeper, in turn, became Dylan’s companion in his fight against Brock’s chaotic reign."
                ],
                Personality =
                [
                    "Sleeper’s feline form suits it perfectly. Like a cat, Sleeper is sneaky, thoughtful and often solitary. The symbiote is fi ercely protective of those it cares for and totally indifferent toward everyone else. Stay out of its way, and it will stay out of yours, but get too close, and you might get scratched.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Snowbird",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 3, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SixthSense,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Postcognition1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlFog),
                        powerSelector.GetPower(PowerNames.ControlWeather2),
                        powerSelector.GetPower(PowerNames.WeatherChill),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Narya",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 5'10\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 145 lbs.",
                Gender = Gender.Female,
                Eyes = "Blue (white when shape-shifting)",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mythic],
                Teams = [TeamNames.AlphaFlight],
                Base = "Mobile",
                History =
                [
                    "In order to create a champion worthy of her sacred stature, the Inuit goddess Nelvanna sired a daughter with a hapless archeologist named Richard. She named this child Narya.",
                    "From the beginning, Nelvanna had hoped that Richard would be able to take care of their daughter, but the experience of connecting with the goddess had driven him insane. So Nelvanna instead left her daughter in the safe hands of the doctor who delivered her—Michael Twoyoungmen (A.K.A. Shaman).",
                    "By the time she was born, Narya was already physically a year old, and she continued to grow rapidly throughout her youth—to the point where, within a few years, she was old enough to take care of herself.",
                    "Right around then, both Narya and Shaman were recruited into the Canadian super-team Alpha Flight. She and her father have been with the organization ever since, working tirelessly to protect the people of Canada.",
                ],
                Personality =
                [
                    "Snowbird’s sacred heritage can, at times, make her seem a bit stuck-up and perhaps even disconnected from regular human society. However, she is much more down to earth than the likes of Thor or Zeus. She grew up on Earth, and most other members of Alpha Flight, the people she considers her closest friends in the world, are Earthlings.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "SP//dr",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 3, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Uncle Ben"),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.VenomBlast),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "SP//dr’s co-pilot “Spider”"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peni Parker",
                Heights = [new() { Feet = 4, Inches = 9 }],
                HeightReminder = "9' in battle suit",
                Weights = [105, 900],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Big,
                SizeNotes = "Average when not in suit",
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy],
                Base = "New York City (Earth-14512)",
                History =
                [
                    "In the futuristic world of Earth-14512, high-tech criminals run wild, terrorizing millions. To combat the scourge, a government-backed scientist named Richard Parker developed a mechanical suit capable of combating nearly any opponent. To help handle the mental load of piloting the suit, Parker bonded himself to a genetically modified, hyperintelligent, psychic spider.",
                    "For a while, Parker and his arachnid partner protected the world under the codename of SP//dr. But when Parker died under mysterious circumstances, responsibility for piloting the SP//dr suit fell to the only other person capable of bonding with its spider pilot: Parker’s 9-year-old daughter, Peni.",
                    "Under the tutelage of her Uncle Ben, Peni spent the next several years training to pilot her father’s suit. By the time she was 14, government authorities considered her experienced enough to begin using the suit on a regular basis.",
                    "These days, Peni splits her time between her school duties and protecting New York City in the SP//dr suit. This has made it hard for her to make friends at school, but she’s made plenty of compatriots in the multiversal Spider-Army. She’s gone on dozens of adventures with the Spider-Verse defenders—almost as many as she’s had on her own."
                ],
                Personality =
                [
                    "Peni Parker is a brave, if occasionally shy, teenage girl whose main concerns are having fun and being accepted by her peers. Piloting SP//dr can sometimes be a burden, but her strong sense of justice refuses to let her give up. Her Uncle Ben is her favorite person in the world.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Speed",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.LightningActions),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.MolecularDestabilization),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                RealName = "Thomas “Tommy” Shepherd",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [155],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "Unable to conceive children naturally with her husband (the Vision), the Scarlet Witch unconsciously stole two fragments of Mephisto’s demonic essence and transmogrified them into living children: a pair of twins named William and Thomas Maximoff. Some time later, Mephisto discovered the theft and had the children killed, but despite his best efforts, their souls continued to elude his grasp. Eventually, they were sent back in time and reincarnated as William Kaplan and Thomas Shepherd.",
                    "As part of a happy, well-off family, Kaplan had a relatively easy time coming to terms with his powers, becoming the hero known as Wiccan, and helping to form the Young Avengers. Shepherd, on the other hand, struggled and spent his early teens lashing out at others.",
                    "As part of one of their first missions, the Young Avengers freed Shepherd from a juvenile detention center for super-powered teens. After realizing that they looked nearly identical, it didn’t take long for Shepherd and Kaplan to piece together their origins.",
                    "For a while, the boys worked together to protect the world with the Young Avengers. However, Kaplan eventually left the team to elope with Hulkling and join him in overseeing the new Kree/Skrull Alliance. Shepherd similarly ran off to Krakoa with his boyfriend Prodigy, but the pair lost track of each other during the island-nation’s fall."
                ],
                Personality =
                [
                    "Compared to his sensitive and insecure brother, Speed often comes across as an unfeeling and overconfident problem child. But for all his tough-guy bluster, Shepherd does care about people, particularly his teammates. He just has trouble opening up to others, even his friends.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Speed Demon",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 2, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.LightningActions),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.FastStrikes),
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
                        powerSelector.GetPower(PowerNames.RunOnWater),
                        powerSelector.GetPower(PowerNames.SpeedBlast),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James Sanders",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Blond",
                Size = Size.Average,
                SizeNotes = "Average when not in suit",
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.LethalLegion, TeamNames.SinisterSix, TeamNames.SquadronSinister, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "James Sanders was once an ordinary chemist, fine in fortune and body but lacking in fulfillment and purpose. So when the Grandmaster approached him, offering a life of thrills and excitement, Sanders didn’t hesitate. He worked with the mysterious alien to synthesize a superspeed serum, and he subsequently became a member of the Grandmaster’s Squadron Sinister under the codename Whizzer.",
                    "Though the squadron was defeated and depowered by the Avengers, Sanders refused to let go of his new life of adventure. He created an improved version of his serum and shed the Whizzer persona, rebranding himself as the nefarious Speed Demon. In this new guise, Sanders embarked on a series of crime sprees, robbing department stores and banks and fighting off their defenders—including, most notably, Spider-Man (Peter Parker).",
                    "Sanders’ super-speed makes him a very formidable foe, and in the years following his rebranding, he became a regular recruit for a variety of super-villain teams. These days, when he isn’t planning heists or acting as a member of Hank Pym’s Lethal Legion, he spends most of his time bouncing between prisons, low-level robberies and superhuman fighting tournaments.",
                ],
                Personality =
                [
                    "Sanders is unstable—not in the violent manner most super villains exhibit, but emotionally. He has little in the way of a social filter, and he often lets his emotions get the better of his judgment, to the detriment and disapproval of his teammates. Sanders isn’t particularly evil—he doesn’t enjoy killing—but he has found the super-villain life suits him nicely and has no intentions of giving it up anytime soon.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Boy",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 2, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "when angry"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Spider-Man (Peter Parker)"),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitAndRun),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SixthSense,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Intuition),
                        powerSelector.GetPower(PowerNames.Precognition1, reminder: "limited to held items"),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "arachnids"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Bailey Briggs",
                Heights = [new() { Feet = 4, Inches = 11 }],
                Weights = [64],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Small,
                DistinguishingFeatures = "Retractable fangs and spider eyes",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "New York City",
                History =
                [
                    "A few years ago, Bailey Briggs, his mother, Tabitha, and numerous other people were kidnapped by the mad scientist Madame Monstrosity. The victims of these kidnappings had their DNA spliced with various animals, turning them into hybrid creatures called Humanimals.",
                    "Most of the Humanimals lost a portion of their humanity in the process, but Bailey somehow kept his mind completely intact and gained a slew of Spider-Powers to boot. He escaped Madame Monstrosity and fell into the custody of Spider-Man (Peter Parker), who made the boy his sidekick.",
                    "Sometime later, Spider-Boy was erased from the interdimensional Web of Life and Destiny that connects the entire Spider-Verse. All evidence of his existence, including everyone’s memories of him, was wiped away. When the Web of Life and Destiny was eventually restored, Spider-Boy came back, but still no one remembered him. Spider-Boy spent most of his time since his return trying to reconnect with his mentor and idol, Spider-Man. Sadly, Parker’s complete amnesia regarding the boy has made this an arduous process.",
                    "During that time, Bailey stayed at the F.E.A.S.T. homeless shelter, under the supervision of Parker’s Aunt May. One of the older girls at the shelter, Christina Xu, is his closest confi dante and his only real non-super-powered friend.",
                    "But that all changed after Spider-Boy pushed the Spider-Society to help him. With Spider-Man’s help, Spider-Boy was restored, and three years of memories of his existence was restored to the world. Bailey was reunited with his mother and has started back in school."
                ],
                Personality =
                [
                    "Bailey Briggs is a sweet but deeply insecure kid. The experiment that gave him his powers also gave him fangs and six spiderlike eyes. He’s learned to suppress these features, but in moments of anger or excitement, they can reassert themselves. When they do, he feels—not entirely inaccurately — that people perceive him as a monster.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spidercide",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 3, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 8 (due to Big)"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.SlipFree)
                    ]
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.SpiderSense),
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
                RealName = "None",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Shape-shifting clone of Peter Parker",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "A clone created by the Jackal (Miles Warren), Spidercide originally believed himself to be the real Peter Parker. Possessing all of Spider-Man’s abilities, Spidercide had also been given the power to control his physical form at the molecular level. Warren programmed him to kill Parker and his friends when the proper trigger occurred.",
                    "Spidercide could shift his mass, density and shape at will, making him a deadly match for Spider-Man. At the time, the Jackal considered Spidercide to be his ultimate achievement. However, Spidercide eventually got sick of taking the Jackal’s orders, and the pair turned on each other.",
                    "Spidercide still hates Parker and his other clones, but he might despise the Jackal more. Recently, the Jackal captured Spidercide and forced him to help torment Parker with spine-tingling illusions. Not one to be forced into anything, Spidercide helped Parker escape the Jackal’s trap and send the villain back to prison.",
                ],
                Personality =
                [
                    "Spidercide is a cold-blooded killer. He and the Jackal killed hundreds of people together, and after they separated, Spidercide continued to occasionally kill innocent civilians. That said, he is not a completely unreasonable psychopath. He speaks with precise diction and is clear about what he wants at all times. It just so happens that the thing he wants most is to bathe in Spider-Man’s blood.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Girl",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 7, resilience: 3, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Darkdevil"),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Spider-Man (Peter Parker)"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
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
                        powerSelector.GetPower(PowerNames.Repulse),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.StickAround),
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
                RealName = "May “Mayday” Parker",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [119],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD, TeamNames.SpiderSociety],
                Base = "New York City (Earth-982)",
                History =
                [
                    "In Earth-982, Spider-Man (Peter Parker) lost his leg in a fight that also claimed the life of the Green Goblin (Harry Osborn). Unable—and, more importantly, unwilling—to continue as a crimefi ghter, Parker settled down with Mary Jane Watson and had a daughter, May.",
                    "May was a rambunctious kid, creating trouble often enough that her parents nicknamed her “Mayday,” but compared to what came later, the first stages of her life were relatively uneventful. At right around the age that Peter first got his powers, Mayday began manifesting a similar set of abilities.",
                    "Having had the importance of responsibility drilled into her head by her parents all her life, Mayday knew she had to put her powers to good use. First in secret—then later with tentative parental approval—she adopted her father’s iconography and set out to protect New York City as the amazing Spider-Girl.",
                    "Although she’s been doing the job for only a few years, Mayday has already made a major splash not only in her home universe but throughout the entire Spider-Verse. A determined go-getter, she juggles her duties as a local hero with her duties as a member of the Spider-Society and with her job as a babysitter for her little brother, Benjy, who is just beginning to come into powers of his own."
                ],
                Personality =
                [
                    "Although she’s not above the occasional bout of righteous anger, Mayday Parker is a more hopeful person than her father. Unlike many of the heroes around her, she genuinely believes in the power of reform and restorative justice. She would rather turn her enemies into friends than beat them up, though she recognizes that the latter is often unavoidable.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Ham",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 7, resilience: 6, vigilance: 3, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "May Porker"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.ExtendedReach1),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
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
                RealName = "Peter Porker",
                Heights = [new() { Feet = 3, Inches = 8 }],
                Weights = [95],
                Gender = Gender.Male,
                Eyes = "Black",
                Hair = "Brown",
                Size = Size.Small,
                DistinguishingFeatures = "Anthropomorphic pig",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderSociety],
                Base = "New Yolk City (Earth-8311)",
                History =
                [
                    "One day, in the strange anthropomorphic animal dimension of Earth-8311, mad scientist May Porker gave herself a critical dose of radiation while trying to create a nuclear-powered hair dryer. Stumbling around in an irradiated stupor, she discovered a down-on-his-luck spider named Peter, who had been secretly squatting in her basement. Mistaking him for some sort of snack, May bit Peter, transforming him into a pig with the proportional speed and strength of a spider.",
                    "The event gave May severe memory damage, and in the aftermath, she believed that Peter had always been her nephew. Too worried for her health to shock her with the truth, Peter allowed May to adopt him and began living in her house full-time.",
                    "Out of love for his adoptive aunt, Peter decided to use his newfound powers for the greater good of all animalkind. Under the codename Spider-Ham, he defends his world—and others—from villainous anthropomorphic threats like Ducktor Doom and the Green Gobbler.",
                ],
                Personality =
                [
                    "Peter Porker makes a lot of jokes, to the point that many people, even in his own universe, consider him to be nothing more than a joke, and an obnoxious one at that. But he suffers just as much as any other Spider-Person, if not more so.",
                    "Porker’s friends and colleagues in the Spider- Society are the only people with real sympathy for him, and even they consider his existence strange. To them, his odd homeworld where no one can ever die or even really change sounds like some kind of cosmic gag."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man (Earth-1610)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 2, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Poor),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
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
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderSociety, TeamNames.Ultimates],
                Base = "New York City (Earth-1610)",
                History =
                [
                    "While the history of Earth-1610’s Peter Parker broadly resembles that of Earth-616’s Parker in his teenage years, the devil lies in the details. Rather than being bitten by a radioactive spider, Earth-1610’s Parker was bitten by an Oscorp spider that had previously been a test subject for Norman Osborn’s Oz formula. Parker later lost his Uncle Ben—in much the same way as his Earth- 616 counterpart—but in this world, his girlfriend Mary Jane Watson was already there to help comfort him through the loss.",
                    "As Spider-Man, Parker protected his friendly neighborhood from dozens of deadly threats, including, frequently, Osborn himself. A little over a year after their adventures began, Parker and Osborn had one fi nal battle, a fi ght that killed them both. In the wall-crawler’s absence, another young hero named Miles Morales took up the title—and the responsibilities—of Spider-Man.",
                    "Sometime later, the Oz formula flowing in Parker and Osborn’s veins brought them both back to life. Morales was moved to Earth-616, and life in Earth-1610 mostly returned to the status quo. Now an adult, Parker spends most of his time helping the Ultimates protect New York City from monsters like Venom and the Green Goblin."
                ],
                Personality =
                [
                    "During his first year of adventuring, Parker was all but constantly underslept, overworked and stressed out of his teenage mind. Now that he’s had a few years to settle into his webs, he’s leveled out a bit, but his life as Spider-Man is still a major strain on his personal health and his social relationships.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man (Earth-6160)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 4, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Dependents, specialization: "Richard and May Parker"),
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
                        powerSelector.GetPower(PowerNames.Disguise, isTech: true),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [178],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [],
                Base = "New York City (Earth-6160)",
                History =
                [
                    "Determined to create a world without heroes, the megalomaniacal Maker (Reed Richards) of Earth-1610 went to Earth-6160, a universe much like that of Earth-616 but decades in the past. The first thing he did after arriving on the planet was go to a certain laboratory and prevent a certain radioactive spider from biting a certain teenager.",
                    "So, Peter Parker never became Spider-Man and, by extension, his uncle Ben Parker never died. Instead, Peter got to live the quiet, domestic life that his counterpart in Earth-616 has always dreamed of. He got to marry Mary Jane Watson and have two kids: Richard and May. He got to become a successful journalist at the Daily Bugle, studying the craft under the trifecta of J. Jonah Jameson, Robbie Robertson and Ben Parker.",
                    "But the Maker’s reign couldn’t last forever, and eventually, a resistance movement formed to oppose him. As part of this movement, Iron Lad (Tony Stark) sent Peter Parker a package containing three things: a video message explaining the situation, a radioactive spider and an experimental picotech battle suit.",
                    "After careful consideration, Parker put the suit on and let the spider bite him. Initially in secret and then later, with family approval, he took to the streets as Spider-Man.",
                    "In the months since, he’s been working with his partner, the Green Goblin (Harry Osborn), to take down New York’s secret ruler: the Kingpin."
                ],
                Personality =
                [
                    "This version of Spider-Man may be older than his Earth-616 counterpart, but he’s still a rookie hero, just beginning to come to grips with his new powers. Parker started out a fairly laid-back family man, but that may change as he learns just how dangerous life as Spider-Man can be.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man (Miles Morales)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 7, resilience: 3, vigilance: 4, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.QuickLearner),
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
                        powerSelector.GetPower(PowerNames.VenomBash),
                        powerSelector.GetPower(PowerNames.VenomBlast),
                        powerSelector.GetPower(PowerNames.VenomBurst),
                        powerSelector.GetPower(PowerNames.VenomSword),
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
                Teams = [TeamNames.Champions, TeamNames.SpiderSociety],
                Base = "Brooklyn, New York City",
                History =
                [
                    "Born in an alternate universe (Earth-1610), high-school student Miles Morales was bitten by a genetically modified spider that granted him amazing spiderlike abilities. After witnessing the death of his universe’s Spider-Man (Peter Parker), Morales decided to take on the hero’s mantle and become the new Spider-Man.",
                    "When Morales’ universe was destroyed, he managed to escape to the main Marvel Universe (Earth-616), and the Molecule Man integrated Morales’ past life and family into his new home, restoring some of them to life. Today, Morales attends the Brooklyn Visions Academy and adventures alongside the original Spider-Man, the Order of the Web (a team of Spider-Man-related heroes) and the Champions (a team of teenaged heroes), as well as establishing himself as a hero all his own.",
                    "Morales’ family is aware of his vigilante activities and do their best to support him in his heroic efforts. That includes taking in his genetic clone, Shift, who intermittently acts as Morales’ adventuring partner."
                ],
                Personality =
                [
                    "Morales is an excellent student and a loyal friend. He remembers little of his old life on Earth-1610, but he is dedicated to making the most of his second chances on Earth-616 with his family. He looks up to Peter Parker as a mentor, but at the same time, he is determined to carve out his own path and become his own kind of hero. Though he’s not exactly a social butterfly, Morales has a number of close friends, including his old pal Ganke Lee, his girlfriend Starling (Tiana Toomes) and former Champions teammate Ms. Marvel (Kamala Khan).",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man (Miles Morales) (Earth-1048)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 3, ego: 3, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Peter Parker"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Young),
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
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
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
                        powerSelector.GetPower(PowerNames.VenomBash),
                        powerSelector.GetPower(PowerNames.VenomBlast),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Miles Morales",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Underground],
                Base = "New York City (Earth-1048)",
                History =
                [
                    "Earth-1048’s version of Miles Morales grew up idolizing Spider-Man (Peter Parker), not knowing that the man behind the mask was another volunteer at the same F.E.A.S.T. shelter where he worked.",
                    "After Morales’ father was killed in a terrorist attack orchestrated by the head of F.E.A.S.T., Spider-Man reached out in both his civilian and his hero personas to comfort the young man.",
                    "Unbeknownst to either of them, an experimental genetically modifi ed spider similar to the one that gave Parker his powers escaped from Oscorp and hid away in a F.E.A.S.T. box. While Morales was moving supplies, the spider leaped out and bit him, granting him powers even greater than Parker’s own. From that day forward, both Parker and Morales have protected New York City, each under the codename of Spider-Man.",
                    "Although Morales is still in the early stages of his super-hero career, he’s already caught up to Parker in terms of ability and experience, to the point where Parker has been able to take extended absences from his regular Spider-Man duties. Morales has already saved the city on his own once, from a major reactor meltdown inadvertently caused by his friend the Tinkerer (Phin Mason)."
                ],
                Personality =
                [
                    "Much like his counterpart Spider-Man (Peter Parker) in Earth-616, Morales is a friendly, fun-loving kid who is always willing to help others. When he’s not being Spider-Man, he spends his days hanging out with his best friend, Ganke Lee, and his girlfriend, Hailey Cooper.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
                    "Bitten by a radioactive spider when he was in high school, Peter Parker gained a suite of spider-related powers. He exploited them for profi t until he let a robber get away who later shot and killed his Uncle Ben in a botched burglary, driving home the lesson “with great power there must also come great responsibility.” Since then, Parker has dedicated himself to fighting crime and helping those who have less power than him.",
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
            Name = "Spider-Man (Peter Parker) (early days)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Aunt May"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.Poor),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
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
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [145],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "Bitten by a radioactive spider when he was in high school, Peter Parker gained a suite of spider-related powers. He exploited them for profit until he let a robber get away who later shot and killed his Uncle Ben in a botched burglary, driving home the lesson “with great power there must also come great responsibility.”",
                    "Though Parker would have a lot of crazy, universe-spanning adventures in his later years, this profi le represents him in his earliest days, before he had signifi cant experience or combat training, back when he was still struggling to establish himself. He has the support of a few people, most notably his Aunt May, but for the most part, he’s a social outcast and a bullied, nerdy kid. He is only just beginning to meet the villains who will defi ne the rest of his life, and though he has great potential, for the time being, he is barely capable of handling more than a few basic foes.",
                ],
                Personality =
                [
                    "Parker is a genius who often lets his sense of responsibility get in the way of taking care of the basics of his life. No one knows his secret identity, and those closest to him, including his teachers, don’t take his excuses for showing up late to everything very kindly.",
                    "Though he has a sharp wit and a penchant for wisecracking, Parker is still an awkward teenager. Endless problems plague his personal life, but it’s rare that he lets feeling sorry for himself stop him from helping others, especially when he’s in costume swinging through his friendly neighborhood."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man (Peter Parker) (Earth-1048)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 7, resilience: 3, vigilance: 3, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder: "Spider-Arms", isTech: true),
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
                Weights = [167],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "New York City (Earth-1048)",
                History =
                [
                    "While Earth-1048’s Spider-Man has virtually the same origin story as Earth-616’s Spider-Man, their later histories di¦ er signifi cantly. In Earth-1048, Peter Parker got all the way through college without encountering many of his biggest foes. Although he has fought some villains like the Lizard and the Shocker, he has only recently begun to run into his heaviest hitters.",
                    "Many of this Parker’s contemporary problems can be traced back to a single source: Norman Osborn. Norman’s son, Harry (who is Parker’s best friend), su¦ ers from a rare degenerative nerve disease—a disease Norman is determined to cure, regardless of scientifi c ethics.",
                    "In his rush to develop a medical treatment, Norman inadvertently created a bioweapon, which was stolen by the terrorist Mister Negative and used to kill people, including Parker’s Aunt May. After that, Norman asked Otto Octavius to develop a prosthetic cure for Harry, only for the project to drive Octavius mad and turn him into Doctor Octopus. Then, as a last-ditch attempt, Norman tried to bind his son with an alien symbiote, accidentally transforming him into the murderous Venom.",
                    "Although Spider-Man has had to shoulder the burden of cleaning up all these disasters, he still loves the Osborn family. He would do it all over again in a heartbeat in order to save Harry."
                ],
                Personality =
                [
                    "Earth-1048’s Spider-Man is a little more upbeat and optimistic than his Earth-616 counterpart. He’s in a steady relationship with Mary Jane, and now that he has Spider-Man (Miles Morales) around to pick up his slack, he’s had more time to devote to his personal life and his scientifi c studies.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man 2099",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 3, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                RealName = "Miguel O’Hara",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [164],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Fangs, retractable talons and spinnerets",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderSociety],
                Base = "Nueva York (Earth-2099)",
                History =
                [
                    "After the original Spider-Man 2099 (Earth-928) uncovered evidence suggesting that someone in the past was working to prevent the future he lived in from ever coming to be, he used a time portal to travel back to Earth-616’s present to try to preserve his timeline. Unfortunately, all this did was create a new alternate future: Earth-2099. O’Hara stayed behind in the present and aged naturally into this new world’s future, which contained its own, younger Miguel O’Hara.",
                    "This new O’Hara spent his youth traveling the so-called Ravage wastelands, experimenting on the strange mutants scattered throughout the wastes. One day, he encountered a “spider man” and harvested some of its genetic material for his employer, Alchemax.",
                    "After witnessing repeated visions of the original Earth-928 timeline and its Spider-Man, the young O’Hara met his older self from that other reality. Old O’Hara revealed to his counterpart that the villainous Doctor Doom had changed the world using magic, causing its citizens to forget their past. The young O’Hara then learned that his rebellious brother, Gabriel, had been killed by Alchemax for trying to alert the public to the company’s immoral experiments. Enraged, Miguel genetically altered his own body using the mutated spider creature’s DNA. He fi nally accepted his fate and became the new Spider-Man of 2099.",
                    "Though the original O’Hara eventually found his way back to his original timeline, he has largely retired. The new O’Hara has taken his place as the defender of the Multiverse and the de facto leader of the Spider-Society. Though hounded at every turn by Alchemax’s law enforcement agency, the Public Eye, he is still dedicated to making Earth- 2099 a better place."
                ],
                Personality =
                [
                    "Though their histories differ, the Miguel O’Hara of Earth-2099 has almost the same personality as his older counterpart. He is a serious crimefi ghter and a brilliant scientist, not to mention a natural leader with a particular hatred for corporate evildoers.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
            Name = "Spider-Man India",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Aunt Maya"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
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
                RealName = "Pavitr Prabhakar",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [105],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "Mumbai (Earth-50101)",
                History =
                [
                    "Earth-50101 largely resembles Earth-616, except that Spider-Man and his associated repertoire of enemies and allies live in Mumbai, India, rather than New York City.",
                    "As a poor and somewhat awkward scholarship student, Pavitr Prabhakar encountered his fair share of bullies in high school. One day, while hiding from his tormentors, he was visited by an aspect of the Spider-Totem in the form of an ancient yogic spirit who granted him web powers and the proportional speed and strength of a spider.",
                    "Filled with a desire for revenge, Prabhakar rushed back to school, ignoring nearby cries for help. Only after the fact did he discover the cries were those of his beloved Uncle Bhim, who was being stabbed by a mugger.",
                    "Having learned that with great power there must also come great responsibility, Prabhakar became the hero known as Spider-Man, protector of the weak and innocent.",
                    "Later in his webslinging career, Spider-Man was recruited into the multiversal Spider-Army and thereafter into the Spider-Society. Although Prabhakar goes by the codename Spider-Man, the other members of these teams refer to him as Spider-Man India to help distinguish him from his other incarnations.",
                    "These days, when he’s not protecting Mumbai (or the rest of the Multiverse), Prabhakar attends college alongside his girlfriend, Meera Jain."
                ],
                Personality =
                [
                    "Far more so than his Earth-616 counterpart, Prabhakar abides by his core values of kindness, mercy and, above all, service to his community, as embodied by the Hindu concept of Seva. More often than not, his villains are uncaring billionaires and business moguls who would love nothing more than to pave over every last poor neighborhood in Mumbai.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Man Noir",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 7, resilience: 2, vigilance: 3, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Pundit),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Poor),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
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
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
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
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.SpiderSociety],
                Base = "New York City (Earth-90214)",
                History =
                [
                    "Determined to expose business magnate Norman Osborn for the brutal murder of his Uncle Ben, a young Peter Parker sought out a job as an assistant investigative reporter at the Daily Bugle. On his fi rst job, he tailed Osborn’s men to a warehouse filled with stolen artifacts intercepted from overseas shipments.",
                    "One of these artifacts, an idol of a spider deity, broke open, releasing a flood of ancient spiders into the building. These strange, mystic spiders killed Osborn’s men, but sensing Parker’s good nature, they spared him, instead granting him the web powers and proportional speed and strength of a spider.",
                    "After using his newfound powers to defeat Osborn once and for all, Parker vowed to keep protecting the world from those who would abuse their wealth and resources to prey on the little guy. As the Spider-Man, he investigates the stories that no one else can and punishes the rich and powerful criminals behind them.",
                ],
                Personality =
                [
                    "The Spider-Man’s colleagues in the Multiversespanning Spider-Society call him Spider-Man Noir, a cheeky reference to his grim home universe. Spider-Man Noir has, naturally, picked up a corresponding reputation for being darker and more serious than other Spider- People, but this is only half true. He is grim and serious, but like most variants of Peter Parker, he’s not above cracking a joke now and again.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Punk",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 3, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Electric Guitar (acts as club)"),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                RealName = "Hobart “Hobie” Brown",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Entertainer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderBand, TeamNames.SpiderSociety],
                Base = "New York City (Earth-138)",
                History =
                [
                    "Not long ago in Earth-138, the United States was overrun by corporate-backed totalitarian fascism. President for Life and Oscorp C.E.O. Norman “Ozzy” Osborn set about using the country as his dumping ground, dropping billions of gallons of radioactive waste directly onto poor communities.",
                    "One day, a radioactive spider emerged from a waste site in Brooklyn and bit a teenage punk rocker named Hobie Brown, granting him extraordinary Spider-Powers and turning him into the unstoppable Spider-Punk. Determined to use his new powers for the greater good, Brown formed a Spider-Band of other antiauthoritarian heroes, and together, they organized a successful mass uprising against the Osborn government. Brown himself delivered the final blow, killing Osborn and freeing the country from his iron grip.",
                    "Then Spider-Punk did the most punk thing of all. He became a community organizer in Brooklyn. With help from the Wakandan government, he works to reform New York into a kinder, freer place, one built upon democratic and communal ideals. Between rocking out and doing organizing work, Brown still finds time to be a hero, both for the people of his world and the entire Spider-Verse.",
                ],
                Personality =
                [
                    "Spider-Punk takes the “punk” part of his name very seriously. Being a punk is not just a fashion statement for him. It’s an entire lifestyle and ideology. It means wearing your heart on your sleeve. It means loving life and loving music. Most of all, it means questioning systems of authority and dismantling the ones that don’t work for the people.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Slayer",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 4, resilience: 2, vigilance: 4, ego: 0, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.MobilityIssues),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: false),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: false),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
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
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Alistaire Alphonso Smythe",
                Heights = [new() { Feet = 6 }],
                Weights = [131],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Cybernetic body with extra arms, claws and retractable metal carapace",
                Occupations = [OccupationName.Engineer],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.TheSpiderSlayerSeries],
                Base = "New York City",
                History =
                [
                    "Many years ago, Alistaire Smythe’s father, Spencer, was hired by J. Jonah Jameson to create a Spider-Slayer—a robot capable of defeating Spider-Man (Peter Parker). However, after the first several models failed to capture the wall-crawler, Jameson cut his funding.",
                    "Rather than return to civilian life, Spencer became obsessed with killing both Jameson and Spider-Man and continued to manufacture new Spider-Slayer models toward those ends. He eventually contracted a case of acute radiation poisoning from his own creations and died unfulfi lled.",
                    "Blaming Jameson and the Web-Head for Spencer’s death, Alistaire Smythe took up his father’s cause, creating new models of Spider-Slayer to menace them. Frustrated that his attempts to attack the pair so often failed, he used cybernetics to turn himself into the ultimate Spider-Slayer and subsequently killed Jameson’s wife, Marla.",
                    "For this crime, the authorities sentenced Smythe to death. He attempted to escape his execution, but the Superior Spider-Man (Otto Octavius) killed him before he could.",
                    "The Jackal (Ben Reilly) later created clones of both Smythe and his father, e¦ ectively bringing them back to life. Spencer Smythe’s clone was killed by the Sleep-Stealer not long after his return, but Alistaire’s clone remains alive today, still building new models of Spider-Slayers."
                ],
                Personality =
                [
                    "Alistaire Smythe’s obsession with Jameson and Spider-Man used to be all-consuming. Making their lives as painful as possible was his only purpose. Now that he’s had a modicum of revenge against Jameson, his motivations have become more muddled. He’s gotten into the habit of redesigning his old spider robots to make them more humanoid and selling them o¦ for traditional military purposes.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spiders-Man",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 0, agility: 5, resilience: 3, vigilance: 4, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlSwarm,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 5'10\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 160 lbs.",
                Gender = Gender.Male,
                Eyes = "Innumerable",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Hive mind of spiders containing Peter Parker’s consciousness",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy],
                Base = "New York City",
                History =
                [
                    "While visiting Horizon Labs with his girlfriend Gwen Stacy, the Peter Parker of Earth-11580 fell into a pit containing thousands of radioactive spiders. The arachnids brutally devoured Parker, and in the process, they absorbed his consciousness into their budding hive mind. Thus, Spiders-Man was born.",
                    "For a while, Parker was tortured by his monstrous new state of being. Convinced that he could never be fixed, he pushed away the people who cared for him, watching them from afar and devouring all those who dared to threaten them. However, he eventually found companionship and acceptance in the multiversal Spider-Army, helping his arachnid compatriots defeat cosmic threats.",
                    "After most of the spiders that comprise Spiders- Man perished fighting agents of Shathra, the Peter Parker of Earth-616 took in the remnants of the hive and gave them a habitat where they could rebuild. They have acted as Parker’s lab assistants, communicating ideas and equations by spelling them out with their bodies.",
                ],
                Personality =
                [
                    "Though Spiders-Man ostensibly believes in handling power responsibly, he has a real passion for eating bad guys. His moral compass isn’t as strong as those of most Spider-Men, and he tends to align with whoever has the fewest reservations about him killing and eating his enemies.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Woman (Earth-1610)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
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
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
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
                RealName = "Jessica Drew",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [132],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SHIELD, TeamNames.Ultimates, TeamNames.YoungUltimates],
                Base = "New York City (Earth-1610)",
                History =
                [
                    "As part of a plea deal, the Doctor Octopus of Earth-1610 helped government scientists create several clones of Peter Parker. Though the fi rst few clones had signifi cant problems, Octavius eventually realized that by making the clone female, he could stabilize the process while still creating a specimen that looked and acted remarkably like Parker.",
                    "The government planned to brainwash this fi nal clone, Jessica Drew, into being a secret agent, but before they could do so, the clones all escaped containment. With Parker’s help—and a small amount of intervention on the part of S.H.I.E.L.D.—the clones broke up the government cloning program and defeated Doctor Octopus.",
                    "In the aftermath, Drew adopted the codename Spider-Woman and joined S.H.I.E.L.D.’s associated super-team, the Ultimates. After most of the team was badly injured fi ghting Galactus, Nick Fury disbanded the Ultimates program, but that didn’t stop Drew. Unwilling to let the spirit of the group die, she formed the Young Ultimates, an all-teenage super-team.",
                    "The Young Ultimates picked up right where the Ultimates left off. However, after Drew’s protégé Miles Morales was moved to Earth-616, the team fell apart. Drew was last seen in her old Spider- Woman duds with a re-formed incarnation of the original Ultimates, helping Parker defeat the Green Goblin."
                ],
                Personality =
                [
                    "Jessica Drew has all of Peter Parker’s formative memories and experiences. She has the same anxieties and fears, the same awkward demeanor and the same dedication to wielding power responsibly.",
                    "Drew has no close family to fall back on for support, but she also lacks Parker’s familial responsibilities. She can spend all her time adventuring without having to worry about going to school or taking care of Aunt May."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Woman (Earth-332)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 7, resilience: 3, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Dependents, specialization: "Child"),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
                 new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jessica “Jess” Drew",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [137],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.SpiderSociety],
                Base = "New York City (Earth-332)",
                History =
                [
                    "Though her story seems to share elements with that of the Spider-Man (Peter Parker) and Spider-Woman (Jessica Drew) of Earth-616, little is known about the personal history of the Jess Drew of Earth-332. She gets around on a custom Spider-Bike that can race up walls and even along ceilings.",
                    "Years ago, Drew was partners—both in adventuring and in love—with her world’s version of Hawkeye (Clint Barton). However, at some point, their relationship broke bad, and Hawkeye became one of her greatest enemies.",
                    "Drew eventually married a different man and had a child, whom she affectionately refers to as “bugaloo.” Around this same time, Spider-Man 2099 recruited her into his new Spider-Society, where she rose to the position of being his right-hand woman.",
                ],
                Personality =
                [
                    "Equal parts maternal figure and seasoned action hero, Spider-Woman is the beating heart of the Spider-Society. Her effortless confidence and charisma have made her a friend and mentor to many of her peers. Her cool biker look helps accentuate this persona.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderPheromones),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.VenomBlast),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgliding),
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
                Base = "New York City",
                History =
                [
                    "When Jessica Drew was just a child, she contracted an acute case of radiation poisoning. Her father—a top geneticist and nuclear researcher—searched desperately for a cure to his daughter’s condition. Hoping to grant her the increased radiation immunity enjoyed by many insects, he injected her with an irradiated form of spider DNA.",
                    "The treatment saved Drew’s life but forced her into a coma that lasted more than a decade. By the time she awoke, her parents were long gone.",
                    "Lost and alone, Drew briefly stumbled into the care of Hydra agents who attempted to make her into a spider-themed superspy named Spider-Woman. Drew quickly turned on her handlers, but she kept the Spider-Woman costume.",
                    "As Spider-Woman, Drew spent the next several years traveling across Europe and the United States, occasionally allying herself with S.H.I.E.L.D. and other heroic organizations. Eventually, she settled down in New York City and decided to start a family on her own. When she’s not adventuring, she spends much of her time caring for her son, Gerry.",
                    "During a recent Spider-Verse crisis, Drew was briefly erased from existence when she was stabbed with the Totem Dagger. This also annihilated everyone else’s memories of her son, and in the resulting confusion, Hydra kidnapped Gerry, then forcibly aged and brainwashed him into becoming the adult super villain Green Mamba. Now Drew is on a mission to defeat Hydra and save her son by any means necessary."
                ],
                Personality =
                [
                    "Spider-Woman’s early days as an adventurer were rocky. Having spent most of her life in a coma, her brain was deeply undeveloped. She often fled from conflict, fighting more out of necessity than a desire to enact justice.",
                    "The Spider-Woman of today hardly resembles her younger self. Years of experience have molded her into a confi dent and capable crimefi ghter. Drew is an expert in the arts of both espionage and investigation, and she suffers nonsense from no one."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spider-Woman (Mattie Franklin)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 2, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight1),
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
                        powerSelector.GetPower(PowerNames.VenomBlast),
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
            ],
            Biography = new Biography
            {
                RealName = "Martha “Mattie” Franklin",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [123],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.FiftyStateInitiative, TeamNames.Loners],
                Base = "New York City",
                History =
                [
                    "Rambunctious teenager Mattie Franklin took her father’s place in a magic ritual when he chickened out at the last minute. Alongside the likes of Norman Osborn and Cassandra Webb, Franklin used five ancient magical artifacts to summon a vortex of power into the world.",
                    "Those present at the ritual who already had powers simply had their abilities slightly enhanced. However, those who had no powers gained them, with Franklin obtaining abilities similar to those of the original Spider-Woman (Jessica Drew), along with a unique set of psionic extra limbs.",
                    "Around this same time, Spider-Man disappeared for several months, so Franklin, as a lifelong fan of the wall-crawler, resolved to protect New York City in his place. As the new and improved Spider- Woman, she fought tirelessly to keep the city safe from villainy in all its forms. Even after Spider-Man returned, she kept on as Spider-Woman, partially out of a desire to make her role model proud and partially because she just enjoyed being a hero.",
                    "Unfortunately, her career as a crimefighter proved short-lived. Just a few years after becoming Spider-Woman, both Franklin and Madame Web (Cassandra Webb) were murdered by the Kravino¦ family. Some time down the line, the Jackal created a nearly perfect clone of Mattie, only for her to similarly die in battle, sacrifi cing herself to protect the Spider-Hero Silk.",
                ],
                Personality =
                [
                    "Mattie Franklin’s disposition is far less grim than those of the other women who have shared her codename. Although legally an adult, she is still a teenager, with a teenage attitude and teenage problems. When she needs advice on personal matters, she usually reaches out to her uncle, J. Jonah Jameson.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Spot",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 4, vigilance: 4, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalPortal),
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelOther),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.BlinkDefense),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportTogether),
                        powerSelector.GetPower(PowerNames.Teleportal),
                        powerSelector.GetPower(PowerNames.Telespot),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Johnathon Ohnn",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "None, formerly blue",
                Hair = "None, formerly brown",
                Size = Size.Average,
                DistinguishingFeatures = "Bright white body covered in black wormholes",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Having just gone through a long and messy divorce, scientist Johnathon Ohnn threw his values to the side and took a job working for the Kingpin. Alongside a number of other scientists, he was tasked with tapping into the Darkforce dimension that gives the hero Cloak his powers.",
                    "Ohnn succeeded in creating a portal to the Dark Dimension, but the aperture required so much energy that it immediately threatened to collapse the New York City power grid. Unwilling to miss out on yet another opportunity, he leapt through the portal just as it was destabilizing.",
                    "Caught in the liminal space between worlds, Ohnn found himself in a dimension of black polka dots that infested his body. With e¦ ort, he found that he could control the little black portals and even use them to teleport individual pieces of his body to several different locations at once.",
                    "Emboldened, Ohnn teleported home and set out to take down the Kingpin’s old enemy Spider-Man (Peter Parker). He actually succeeded in beating down the wall-crawler once before Spider-Man rallied and carted him off to prison.",
                    "In the years since, Ohnn has tried again and again to defeat Spider-Man, but he’s never managed to re-create the success he had on his initial outing. As of late, he’s been traveling the Multiverse in search of easier prey."
                ],
                Personality =
                [
                    "Despite his incredible powers, the Spot is perpetually depressed. Neither his family nor the scientific community nor the super-villain community has ever taken him seriously. The world considers him a joke, and he in turn resents the world. He spends a lot of time in bars, drinking heavily.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
                    "More recently, Green has enrolled in the computer science program at Empire State University. Despite her collegiate studies, Green still fi nds the time to help protect the people of New York City.",
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
            Name = "Starfox",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 3, vigilance: 5, ego: 7, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MahdWyry),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.GroupFlight),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.GrandMirage),
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
                RealName = "Eros",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.Avengers, TeamNames.Eternals],
                Base = "Mobile",
                History =
                [
                    "The Celestials never intended for there to be more than one hundred Eternals, and they intentionally locked off the system of rebirth from all Eternal progeny. In defiance, two Eternals—A’Lars and Sui-San—sought to give birth to new Eternals. Their first attempt, Thanos, was a disastrous failure. Their second was Eros.",
                    "Eros was a true Eternal and in almost every way his older brother’s opposite—as obsessed with spreading love and joy as Thanos was with spreading death. He fought alongside the Avengers in their quest to defeat Thanos, and he later joined the team under the codename Starfox. Though his time with the Avengers was short-lived, he served the organization faithfully and even helped introduce other Eternals like Sersi into their ranks.",
                    "Starfox eventually left the Avengers to explore the universe and reconnect with his extended family, but he has continued to come to the team’s aid during times of major crisis—especially when those crises involve Thanos.",
                ],
                Personality =
                [
                    "Starfox numbers among the most flamboyant, eccentric and relentlessly cheery people in the known galaxy. When he’s not actively adventuring, he spends his time partying hard and hitting on anything that moves. Though he’d be loath to violate anyone’s boundaries, he is determined to spread love and peace everywhere he goes.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Starling",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: $"{PowerNames.GrapplingTechnique} (while flying)"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
                RealName = "Tiana Toomes",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [138],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Champions],
                Base = "New York City",
                History =
                [
                    "With a dead mother and an absentee father, Tiana Toomes found refuge in the care of her grandfather, the Vulture (Adrian Toomes). Out of embarrassment, Adrian hid the full extent of his villainous career from his new ward, painting for her the picture of a heroic Vulture who always fought for the working class.",
                    "These tales inspired Tiana to become a super hero herself, and with some help from her granddad, she constructed a fl ying suit capable of taking down the toughest of foes. As the Starling, she launched a one-woman war on organized crime, starting with the vicious Tombstone gang.",
                    "It was while battling a handful of Tombstone’s most dangerous gangsters that she fi rst joined forces with Spider-Man (Miles Morales). Starling and Spider-Man worked so well together that they rapidly became each other’s closest partners— first in crimefighting and then, later, in love.",
                    "Both Morales and the other Spider-Man (Peter Parker) eventually let Starling in on the truth behind her grandfather’s exploits, but the revelations did little more than strain her relationship with the old man. She still adores her granddad, although she’s committed to heroism above all else. She’s been actively avoiding him, lest she be forced to take him down.",
                ],
                Personality =
                [
                    "Tiana Toomes is a strong, intelligent and independent woman with an unwavering sense of justice. Her love for Morales stems largely from the fact that she sees that same sense of justice— that same dedication to doing the right thing, no matter the personal cost—in him.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Stegron",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 1, resilience: 4, vigilance: 2, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Cold / Large Bodies of Water"),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder: "tail"),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Mighty3),
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
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "reptiles"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Vincent Stegron",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [350],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Large bipedal dinosaur-like body with scales, dorsal plates, claws and tail",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SavageSix],
                Base = "Savage Land",
                History =
                [
                    "Dr. Vincent Stegron was once a lab assistant for Dr. Curt Connors. While helping Connors study the potential for dinosaur DNA to unlock rapid cellular regeneration, he grew obsessed with the experiment that made Connors into the Lizard.",
                    "One night, Stegron stole a sample of dinosaur DNA from the lab and fled to the Savage Land. Having studied Connors’ Lizard experiments, he duplicated the process with the dinosaur DNA, injecting himself with a serum that turned him into Stegron the Dinosaur Man.",
                    "Stegron used his new powers to become the ruler of the local Swamp Men. Not content to settle in the Savage Land, he led an army of dinosaurs into New York, determined to take over the world. Ka-Zar of the Savage Land teamed up with Spider-Man (Peter Parker) to take Stegron and his army down, but this did little to deter the mad scientist.",
                    "In subsequent attempts, Stegron changed tactics, using modified versions of his dinosaur serum to convert the people and animals of New York into creatures like himself, raising new, psychically controlled armies. Spider-Man has, thus far, managed to cure most of those affected by Stegron’s meddling, but the scientist always seems to come back with a newer, stronger serum.",
                ],
                Personality =
                [
                    "Much like the Lizard was in his early days, Stegron is a raspy-voiced megalomaniac, endlessly obsessed with power and control. He basks in the abilities that the dinosaur serum has given him and will never be content until he and his dinosaurs once again rule the Earth.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Stepford Cuckoos",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 2, vigilance: 4, ego: 2, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Crystalline Form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Emma Frost"),
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
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BumpPower),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.InformationUpload),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            PowerNotes = 
            [
                "The Stepford Cuckoos have identical stat blocks and powers. Individually, they are not nearly as powerful as Frost, but by working together, they can become a force to be reckoned with. Often in combat, one of the Cuckoos goes on the attack while the others hang back and work together to bump up their attacking sister’s powers as much as possible."
            ],
            Biography = new Biography
            {
                RealName = "Celeste, Esme, Irma, Phoebe and Sophie Cuckoo",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [105],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant, OriginName.WeirdScience],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As part of the secretive Weapon Plus project, mutant hater and scientist John Sublime stole a sizable portion of Emma Frost’s eggs. He used them to create the five Stepford Cuckoos— Sophie, Phoebe, Irma, Celeste and Esme—who are essentially clones of Frost. They each contain minor genetic variations, but they all look like younger versions of Frost, talk like her and have powers similar to hers.",
                    "Hoping to use his creations as moles, Sublime inserted the Cuckoos into Professor Charles Xavier’s mutant academy. This was a big mistake. With the help of the X-Men, Emma Frost quickly freed the Cuckoos from Sublime’s control and made them into regular hero trainees.",
                    "Though they are not usually intimidating individually, as a collective, the Cuckoos number among the most powerful young mutants on the planet."
                ],
                Personality =
                [
                    "Much like Emma Frost, the Cuckoos can be aloof. They have trouble forming relationships with anyone outside of their inbuilt psychic network. A few of the Cuckoos have, for brief periods, gone off on their own, but they always return to the fold. The relationship they have with each other is the most important one in their lives.",
                    "Although the Cuckoos often appear to act almost identically, they do have subtle differences in their personalities. Sophie is their stalwart heroic leader, while Phoebe is more of a hothead. Irma and Celeste are the shyest members of the crew, and Esme is a bit of a schemer."
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Alternate Form",
                        Description =
                        [
                            "Just like Emma Frost, the Stepford Cuckoos can transform into an alternate crystalline form. This form grants them the Sturdy 1 power, but it prevents them from using the Brilliance 1 power and all their Telepathy and Power Control powers. They can use their Uncanny 1 power in either form.\r\n\r\n",
                            "Numbers before a slash are for the Cuckoos’ regular human forms. Numbers after a slash are for their crystalline forms.\r\n\r\n"
                        ]
                    }
                ]
            },
            Source = BookSource.XMenExpansion
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
                Base = "New York City",
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
            Name = "Stinger",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 3, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Ant-Man (Scott Lang)"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "known to allies"),
                tagSelector.GetTag(TagNames.Young),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                    IsTech = true
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
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.ResizeObject),
                        powerSelector.GetPower(PowerNames.Shrink4),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, specialization: "insects"),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Cassandra “Cassie” Lang",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "normally 5'4\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "normally 106 lbs.",
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.YoungAvengers],
                Base = "New York City",
                History =
                [
                    "Cassie Lang was born with a rare heart defect, and to treat it, her father, Scott, stole Hank Pym’s Ant-Man technology. Pym could have had Scott imprisoned, but out of admiration for the man’s noble cause, Pym ultimately allowed Scott to keep the tech and become the new Ant-Man.",
                    "Cassie grew up admiring her father’s heroism and secretly took small doses of Pym Particles throughout her youth, just in case she was ever called into battle. However, she never seriously considered donning an Ant-Man suit herself—at least not until Scott was seemingly killed by the explosion of the undead corpse of his radioactive teammate, Jack of Hearts.",
                    "Determined to carry on in her father’s stead, Cassie threw on Scott’s old suit and joined the Young Avengers as Stature. Her teammate, Iron Lad, developed a crush on her, and in an attempt to win her love, he helped the team travel back in time and rescue Scott. Unfortunately, Cassie couldn’t enjoy her father’s return, as she was killed by Doctor Doom immediately thereafter.",
                    "Years later, during a brief period of remorse, Doom brought Cassie back to life. She quickly returned to adventuring under a new title—Stinger—and to keep her safe, Scott reluctantly took her on as his apprentice."
                ],
                Personality =
                [
                    "Cassie Lang loves and admires her father, but she’s also a somewhat insecure young woman looking for acceptance among her peers, and that often makes his presence embarrassing. She’s happy to work with him on his adventures, but she’s adamant about keeping him far away from her social life.",
                ]
            },
            Source = BookSource.AvengersExpansion
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
            Name = "Storm (X-Men '97)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 4, vigilance: 4, ego: 6, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
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
                        powerSelector.GetPower(PowerNames.Discipline3),
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
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "The weather-controlling mutant Ororo Munroe, alias Storm, was born in the shadow of Mount Kilimanjaro. As a child, she was once buried alive, leading to a lifelong case of claustrophobia. In her home village, she assisted in the birth of a baby, Mjnari; she subsequently considered him to be like a son to her. She fi rst met Professor X during an encounter with the evil psychic the Shadow King; she subsequently joined him and his X-Men in America, becoming one of the team’s most powerful members. When Jean Grey and Cyclops were captured by the Morlocks, a subterranean group of mutant outcasts, Storm challenged their leader, Callisto, to a duel. Winning, she became the Morlocks’ leader, although she later passed that responsibility back to Callisto. The Shadow King, craving vengeance on her, lured her back home by possessing Mjnari, but Storm was able to defeat him once more. Later, she traveled to the alien world Polemachus to quell the storms that raged there and was briefly betrothed to the planet’s king, Arkon, but left when she realized he was a cruel tyrant. Recently, during a battle with the X-Cutioner, Storm was blasted with a hightech weapon that suppressed her mutant powers. She left the X-Men on a quest for self-discovery, linking up with the mutant inventor Forge along the way. She battled the demonic Adversary and regained her powers, returning to the X-Men to aid them in their battle against Bastion and his Prime Sentinels.",
                ],
                Personality =
                [
                    "Storm is supremely empathetic and a valued friend and teammate to her fellow X-Men. In battle, Storm is bombastic, her proclamations eliciting as much fear from her adversaries as her ability to summon the elements. Even when denied the use of her powers, she is a capable and crafty fighter.",
                ]
            },
            Source = BookSource.XMen97Characters
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
            Name = "Sunfire",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 4, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Shiro Yoshida",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.AlphaFlight, TeamNames.Avengers, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Shiro Yoshida was raised by two different men with two very different ideologies. His father, Saburo, was a quiet but progressive man, while his uncle Tomo was a raging conservative nationalist. Gradually, Tomo’s loud and angry rhetoric infected Shiro, and as Shiro’s latent mutant powers began to manifest, Tomo convinced the boy he should use his fiery new abilities to attack the United States.",
                    "Shiro was on the verge of burning down the U.S. Capitol when Tomo, in an act of rage, shot Saburo. Shiro immediately turned on his uncle, striking him down while rushing to his father’s side. As Saburo died, he made one last request of his son: fight for peace, not for war.",
                    "Shiro vowed to fulfill his father’s dying wish. He spent the next several years traveling across Japan, making a name for himself as the country’s foremost defender.",
                    "Although he occasionally left Japan to help super-teams from other countries—like Alpha Flight and the X-Men—Shiro never strayed long from home. Not until the founding of Krakoa.",
                    "With his loyalties torn between Japan and the new mutant nation, Shiro began to give up his nationalist roots in favor of a more humanist ideology, one that favors the wider success of all society."
                ],
                Personality =
                [
                    "As a young man, Shiro was both highly disciplined and a hothead. Like many fire-based heroes, he was prone to bouts of rage, but at the same time, he romanticized the stoic samurai of Japan’s past and worked to become more like them.",
                    "Shiro still has some of that angry, wannabe-samurai persona in him, but years of actual combat have tempered his personality into that of a genuinely experienced warrior."
                ]
            },
            Source = BookSource.XMenExpansion
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
        new()
        {
            Name = "Sunspot (X-Men '97)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 2, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
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
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                },
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
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "Born into family fortune, Roberto Da Costa manifested solar-powered mutant abilities and attempted to hide his powers from his family. Roberto’s parents deduced his nature after he accidentally burned four of their homes but pretended not to know. Roberto was eventually captured by the anti-mutant Friends of Humanity (FoH) before being rescued by the X-Men and questioned about the FoH’s Sentinel technology. Roberto befriended the X-Men’s Jubilee before departing. He continued to visit and soon became involved in battles against a mind-controlled Jean Grey clone and the extradimensional Mojo, who projected Roberto and Jubilee into a digital world where Roberto nearly perished. Roberto and Jubilee began dating, and Roberto was convinced to reveal his mutant nature to his mother. Roberto and Jubilee were later attacked by Da Costa’s butler, who had been transformed into a cyborg Prime Sentinel. Evading more Prime Sentinels, Roberto and Jubilee returned to Roberto’s mother, but she remanded them to the Sentinels, concerned more about bad publicity than her son’s safety. Escaping when Magneto unleashed a worldwide electromagnetic pulse, Roberto and Jubilee were rescued from the FoH by Storm and Forge. The increasingly cynical Roberto soon joined Magneto and reluctantly battled Jubilee when the X-Men infi ltrated Magneto’s Asteroid M base. Denouncing Magneto a\u001f er witnessing him nearly kill the X-Man Wolverine, Roberto, now calling himself Sunspot, saved Jubilee from Asteroid M when it was shot down by the U.S. government.",
                ],
                Personality =
                [
                    "Slightly self-centered due to his privileged upbringing, the fun-loving and outwardly confident Sunspot often doesn’t seem to grasp the gravity of situations. Despite his sometimes cynical and skeptical demeanor, he is secretly unsure of himself and his powers, having spent much time hiding his true nature.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Supergiant",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 3, vigilance: 6, ego: 4, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.InformationUpload),
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
                RealName = "Supergiant",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [215],
                Gender = Gender.Female,
                Eyes = "Yellow",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Blue skin with black markings, angular facial features, no visible ears",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.BlackOrder],
                Base = "Mobile",
                History =
                [
                    "Supergiant claims to have first met Thanos in her childhood, back when she was living in an orphanage for severely traumatized children. After witnessing the Mad Titan expertly butcher one of his own children, Supergiant begged him to grant her the honor of a similar death. Thanos agreed, on the condition that she help him kill all his other children first.",
                    "For a time, Supergiant served Thanos faithfully as a member of the Black Order, but after many frustrating years of waiting patiently for death, she decided to take matters into her own hands. During Thanos’ first invasion of Earth, she stole the codes to a powerful antimatter bomb and set it to blow, hoping to kill Thanos, his son Thane and herself all at once.",
                    "Thankfully, the Inhuman dog Lockjaw managed to teleport both her and the bomb to an uninhabited area at the last second, ensuring that she would be the only casualty of the blast.",
                    "Sadly, death refused to take Supergiant, and she soon returned to life, first as a psychic ghost and later in a physical body. Alive again, she rejoined the Black Order and returned to Thanos’ service."
                ],
                Personality =
                [
                    "Though some other members of the Black Order have limited psychic abilities, Supergiant is the team’s dedicated psychic soldier. Described at times as a “psychic leech,” she is capable of not only manipulating her opponents’ minds, but consuming and replacing them entirely.",
                    "However, unlike many psychics, Supergiant is not particularly willful or egotistical. She speaks softly, with a wistfulness that betrays her longing for oblivion. At times, she acts less like her own person and more like a psychic extension of Thanos."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Superior Spider-Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 2, ego: 0, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist, OccupationName.Tycoon],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.ParkerIndustries],
                Base = "New York City",
                History =
                [
                    "Dying from a combination of old age and injuries sustained fighting Spider-Man (Peter Parker), Doctor Octopus hatched a plan to turn the tables on his nemesis. He ambushed the wall-crawler at a vulnerable moment and used experimental technology to swap his mind with Parker’s, leaving Parker to die in Octopus’ failing body.",
                    "However, this swap was not as clean as Octavius had planned. Along with Parker’s body, he got all of Parker’s memories and—with them—Parker’s sense of responsibility. Filled with a new sympathy for his old opponent, Octavius vowed to become a better Spider-Man than Parker had ever been.",
                    "As the Superior Spider-Man, Octavius moved to expand Spider-Man’s usual neighborhood operations into a self-sustaining crimefighting empire. He started Parker Industries, a governmentbacked security corporation founded with the explicit goal of creating tools that allowed Spider-Man to patrol all of New York City at once.",
                    "For a few short months, it looked like Octavius truly was a superior Spider-Man. However, his dreams of a crime-free surveillance state didn’t last. People fi gured out how to exploit his monitoring devices, and they used their workarounds to kidnap Octavius’ girlfriend, Anna Maria Marconi.",
                    "His confi dence shaken, Octavius voluntarily erased his mind from Parker’s body, allowing Parker’s consciousness to regain control so he could save Marconi.",
                    "Otto Octavius was later resurrected. However, with the memories of his time as Spider-Man erased, he soon returned to a life of crime."
                ],
                Personality =
                [
                    "Becoming Spider-Man may not have made Octavius into any less of a narcissist, but it did round o¦ some of his hard edges. He still looks down on others, but he prefers not to kill or unnecessarily harm them, much as he might be tempted.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Swarm",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Smoke / Water"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.GroupFlight),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlSwarm,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "bees"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Fritz Von Meyer",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 6'5\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 104 lbs.",
                Gender = Gender.Male,
                Eyes = "Innumerable",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Hive mind of bees containing Fritz Von Meyer’s consciousness",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.HatefulHexad, TeamNames.SinisterSix],
                Base = "Mobile",
                History =
                [
                    "Toward the end of World War II, Nazi scientist Fritz Von Meyer fled Germany and went into hiding in South America. While there, he continued his research into melittology, the science of bees. One day, he stumbled upon a peculiar beehive. Believing the unusual bees to have been irradiated by a nearby meteorite, he sought to magnify their killer instincts and assume control of them.",
                    "Meyer built a device that he believed would do just that, and though it did restore the bees’ killer instincts, it did not allow him to control them. The bees swarmed the Nazi scientist, devouring him and absorbing his consciousness in their budding hive mind. Thus, Swarm was born.",
                    "Swarm seeks to rid the world of humanity and give it back to the insects by any means necessary. Over the years, his e¦ orts have been thwarted by the Runaways, the Champions and, most frequently, Spider-Man (Peter Parker). Meyer is also continually pursued by government agencies like Interpol for his role in Nazi war crimes and by other super villains looking to recruit him for their own nefarious schemes.",
                    "After many years of failed world-conquering plans, Swarm has lowered his ambitions. These days, he spends most of his time just trying to be a general nuisance to the super-hero community. He was recently spotted outside the newly reopened Avengers Academy, harassing the freshman class."
                ],
                Personality =
                [
                    "Meyer is a Nazi at his core, but now that his core is made of bees, his conception of the “master race” has shifted. He dreams of creating a new world of powerful insectoids that he can rule over. Most heroes consider him a joke, but he can be a dangerous foe under the right circumstances.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Swordsman",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 2, vigilance: 3, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Swordsman’s Sword", isMagicItem: true),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            IconicItems =
            [
                new()
                {
                    Name = "Swordsman’s Sword",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.BoltsOfBalthakk),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.FlamesOfTheFaltine),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.MistsOfMorpheus),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier bonus: +2."),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus)
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 3,
                    MeleeDamageModifier = 2,
                }
            ],
            Biography = new Biography
            {
                RealName = "Jacques Duquesne",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [250],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Entertainer],
                Origins = [OriginName.Magic, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.LegionOfTheUnliving, TeamNames.LethalLegion],
                Base = "Mobile",
                History =
                [
                    "Jacques Duquesne mentored Hawkeye (Clint Barton) back when Clint worked at a circus with his older brother, Barney. The old weapons expert taught Clint everything he ever needed to know about combat, and Clint idolized him—until he caught Duquesne stealing money from the circus to pay off his gambling debts.",
                    "The pair fought, and Duquesne disappeared. The Swordsman spent the next several years traveling the world—working as a thief and a sword for hire—before eventually returning to the United States and attempting to weasel his way into his old ward’s new group: the Avengers.",
                    "The team quickly uncovered the Swordsman’s impure intentions and kicked him out, but after fighting with the Avengers a few more times, Duquesne fell in love with an alien bartender named Mantis and realized that he actually did want to turn over a new leaf. With Mantis’ support, he joined the Avengers for real and helped them protect the world from the likes of the Mandarin and the Enchantress. Sadly, his time with the team was cut short when he died protecting Mantis from Kang.",
                    "Though the Swordsman has been resurrected a couple of times since, these returns have been short-lived. Not long after the Swordsman’s original death, an elder of the alien Cotati possessed his body and claimed his memories, becoming a plant-based version of the man."
                ],
                Personality =
                [
                    "Though certainly selfish and self-destructive, the Swordsman was never a complete monster, even at the height of his villainous activities. The fact that he looked out for the Barton brothers as boys shows that he always had a decent heart buried somewhere beneath his swaggering, devil-may-care exterior.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Symbiote (Unbonded)",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 2, agility: 1, resilience: 1, vigilance: 1, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Lightning / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.None,
                GenderReminder = "it/its",
                Eyes = "Red",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Shape-shifting symbiote; can vary in color but often black with white markings",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.SymbioteKnull],
                Teams = [],
                Base = "Mobile",
                History =
                [
                    "Symbiotes are an alien species of shapeless, parasitic creatures composed of inorganic material. They require attachment to a sentient host to be able to thrive, and they grant their host increased strength and durability—among other powers—in exchange for sustenance the symbiotes struggle to otherwise obtain. Bonded symbiotes feed on their hosts’ emotions too—the stronger, the better.",
                    "Symbiotes are sometimes encountered without any hosts. This profi le represents unbonded symbiotes from the planet Klyntar.",
                    "Sometimes, unbonded symbiotes force an unconscious foe to bond with them, giving them control over the host. See the Symbiotes section of Chapter 10: New Rules for details.",
                    "If an unbonded symbiote is reduced to 0 Health or Focus, it becomes formless. If it loses Health or Focus to the point that would kill it, it becomes inert instead. If reduced to inert (or past that point) by its Anathema, it is killed. See Unbonded Symbiotes in Chapter 10: New Rules for details."
                ],
                Personality =
                [
                    "Many unbonded symbiotes are part of a hive mind, and the leader of that hive mind—the King in Black—can control them. When they are uncontrolled and on their own, they can be docile and curious creatures—friendly, even—but they can also be voracious and relentless killers.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Symbiote Dragon",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 4, vigilance: 3, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Lightning / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.HiveMind),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.UnusualSize, specialization: "Huge"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.Mute, reminder: "speak in roars"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
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
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FlexibleBones1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.None,
                GenderReminder = "it/its",
                Eyes = "Varies, usually white or red",
                Hair = "None",
                Size = Size.Huge,
                DistinguishingFeatures = "Dragon-like creatures molded from several symbiotes bonded together",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Monstrous, OriginName.SymbioteKnull],
                Teams = [TeamNames.SymbioteHive],
                Base = "Mobile",
                History =
                [
                    "The god of the abyss, Knull, created many servants, but one of his earliest e¦ orts produced the symbiote dragons: gigantic winged creatures that he could control through a hive mind. As they were capable of spacefl ight, he sent them out to conquer the universe in his name. The most notorious pair of these creatures became known as Grendel and Grendel’s mother after they came to Earth and Thor defeated them, as depicted in the epic poem Beowulf.",
                    "Symbiote dragons do not generally bond with hosts, but when they are injured, parts that fall from them can become regular symbiotes. These creatures can bond with anyone they meet, mentally dominating them and taking them over for Knull to control as the King in Black.",
                    "In addition, symbiote dragons can combine to form even larger creatures or constructs. When Knull was captured, the symbiote dragons were used to form the planet-sized prison that came to be called Klyntar. Similarly, when Knull assaulted Earth, he combined countless symbiote dragons to engulf the entire planet, blotting out the sun. During the invasion, other symbiote dragons combined over Shanghai to form a gigantic representation of Chiyou, a god of darkness. Similarly, American Kaiju—a giant monster created by the U.S. government—fought a skyscraper-sized twoheaded dragon in New York City.",
                    "After Knull’s defeat, Eddie Brock became the King in Black and took control of the hive mind that connected all of the god’s symbiotes and symbiote dragons."
                ],
                Personality =
                [
                    "Though technically sentient, the symbiote dragons look and act more like mindless monsters. When symbiotes merge to form dragons, their higher cognitive functions are subsumed into the symbiote hive mind. They rarely speak—except in roars—and they exist primarily to do the bidding of the King in Black, whoever that may be.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Symbiote Spider-Man",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 8, resilience: 4, vigilance: 4, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump2),
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
                Origins = [OriginName.SymbioteVenom, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "Bitten by a radioactive spider when he was in high school, Peter Parker gained a suite of spider-related powers. He exploited them for profi t until he let a robber get away who later shot and killed his Uncle Ben in a botched burglary, driving home the lesson “with great power there must also come great responsibility.” Since then, Parker has dedicated himself to fighting crime and helping those who have less power than him.",
                    "Some years ago, Parker discovered that one of his costumes was an unstable and violent alien symbiote named Venom. This profi le represents Spider-Man during the period of his life immediately before he learned the true nature of his black suit, when it was quietly taking his body out at night to hunt down and devour the locals. The suit makes Parker more powerful than normal, but it also limits his self-control, making him less heroic, and when Parker is asleep or otherwise incapacitated, it can take him over entirely.",
                ],
                Personality =
                [
                    "Parker is a genius who oft en lets his sense of responsibility get in the way of taking care of the basics of his life. He’s known for his sharp wit and his wisecracking ways, which he often uses to enrage his foes. Despite the problems that often plague his personal life, it’s rare that he lets feeling sorry for himself stop him from helping others, especially when he’s in costume, webswinging through the city’s streets.",
                    "Though Parker has not yet realized it, the Venom symbiote has been accentuating his negative impulses, making him selfi sh and violent, e¦ ectively isolating him from his closest friends. Parker is still a hero in his heart, and some part of him is resisting the suit’s infl uence, but as long as he’s wearing it, he remains a threat to everyone around him."
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Synch",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 3, vigilance: 6, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CloneMoves),
                        powerSelector.GetPower(PowerNames.ClonePowers),
                        powerSelector.GetPower(PowerNames.CopyAbility),
                        powerSelector.GetPower(PowerNames.CopyPower),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Everett Thomas",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black, usually shaved",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GenerationX, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Teenager Everett Thomas discovered his mutant powers during a chance encounter with the X-Men and an evil alien race known as the Phalanx. With concentration, he found that he could synchronize with members of the X-Men, gaining their powers for as long as they remained in his vicinity. He used these new abilities to help them defeat the Phalanx, and the X-Men, in turn, invited him to join their at-the-time-latest junior team: Generation X.",
                    "Thomas agreed, but his time with the team didn’t last long. He was killed on the field of battle, and Generation X disbanded shortly thereafter.",
                    "Years later, the mutant government on Krakoa resurrected Thomas. He tried to pick up his life where he left off, but the temporal disconnect between him and his former teammates left him feeling lonely. This problem only compounded when he and a few other X-Men were caught inside a bubble of highly accelerated time.",
                    "These days, Synch is only really close with a single person: his romantic partner Talon, an older version of Wolverine (Laura Kinney) with whom he spent the accelerated-time incident. They have a romantic history stretching back untold centuries, most of which is known only to them.",
                ],
                Personality =
                [
                    "Synch may have the body of a young man, but in his mind, he is hundreds of years old. He is, by any metric, an unimaginably experienced combat veteran. He’s seen things that would make most veteran X-Men quiver in their boots.",
                    "Despite it all, Synch is neither bitter nor angry. He has the mental tranquility of an old man who has made peace with his mortality, such as it is."
                ]
            },
            Source = BookSource.XMenExpansion
        },
    ];
}
