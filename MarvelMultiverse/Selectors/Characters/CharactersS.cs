using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersS
{
    public static List<Character> GetAllCharacters(
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
