using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersT
{
    public static List<Character> GetAllCharacters(
      INarrativePowerSelector narrativePowerSelector,
      IPowerSelector powerSelector,
      ITagSelector tagSelector,
      ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "Talisman",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 2, vigilance: 3, ego: 7, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
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
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Flight1, isMagicItem: true),
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
                    IsMagicItem = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
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
                    IsMagicItem = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Elizabeth Twoyoungmen",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [132],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.AlphaFlight, TeamNames.BetaFlight],
                Base = "Mobile",
                History =
                [
                    "Following the death of his wife, Michael Twoyoungmen abandoned his daughter Elizabeth and retreated to the woods of northern Canada to learn the mystic secrets of his ancestors. Elizabeth spent the rest of her childhood with a foster family, hearing only whispers of her father’s exploits as the hero Shaman.",
                    "Her life without Michael was a good one. She never intended to see her father again until an evil spirit began to menace the archaeological dig where she worked. To rid herself of the spirit, Elizabeth was forced to track down her father and request his assistance.",
                    "Michael tried—and failed—to dispel the dark spirit. In the process, he discovered that his daughter was the reincarnation of a legendary mystical champion known as Talisman.",
                    "With Micheal’s help, Elizabeth uncovered the Coronet of Enchantment — an ancient artifact which allowed her to unlock her ancestral powers. Together, she and Michael defeated the dark spirit.",
                    "Michael briefly convinced his daughter to join him in the super-hero group Alpha Flight, but old resentments kept the arrangement from becoming permanent. Nowadays, she uses her powers only in times of crisis, acting as backup for the main team."
                ],
                Personality =
                [
                    "If she ever set her mind to it, Talisman might be able to give Stephen Strange a run for his money. She never would, though, as it would take too much time and effort, and she prefers to avoid violence.",
                    "There may remain some tension between Talisman and her father, but the rest of Alpha Flight adores her. She’s intelligent, chipper and an all-around loyal friend."
                ]
            },
            Source = BookSource.XMenExpansion
        },
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
            Name = "Teresa Parker",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 4, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.TechReliance),
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
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
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
                RealName = "Teresa Elizabeth Parker",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.CIA, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Teresa Parker is the younger sister of Spider-Man (Peter Parker) and the daughter of deceased undercover C.I.A. agents Richard and Mary Parker. Having grown increasingly paranoid after Peter was born, Richard and Mary chose to keep Teresa’s birth a secret from everyone, even Peter. She survived the plane crash that claimed her parents’ lives and was put up for adoption shortly thereafter, unaware that she had a brother.",
                    "Teresa spent much of her adolescence investigating her origins, discovering the truth only after she was recruited by her parents’ former employers: the C.I.A. In her new job, she discovered a plot by Kingpin (Wilson Fisk) to restore his criminal enterprise that involved kidnapping Peter Parker. While looking into Peter and his parents, Teresa found long-buried documents proving she was his sister. She revealed herself to Peter, and together, they foiled the Kingpin’s plot.",
                    "Having fulfi lled her life’s mission, Teresa left the C.I.A. to take a position with S.H.I.E.L.D. She knows Peter’s secret identity and has fought alongside Spider-Man a number of times since, and while her parentage has occasionally been called into question, the pair have come to accept each other as siblings."
                ],
                Personality =
                [
                    "Being a C.I.A. spy means that Teresa is all about the cloak-and-dagger lifestyle, but she nonetheless has a similar moral compass to Peter, and she tries her best to use her skills responsibly. She still holds a lot of anger over her parents’ deaths, but she never lets her emotional hang-ups get in the way of doing the right thing. She’s smart, and her extensive combat training makes her a formidable opponent.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
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
            Name = "The Rose",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 1, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Leverage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                },
            ],
            Biography = new Biography
            {
                RealName = "Richard Fisk",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.FiskIndustries],
                Base = "New York City",
                History =
                [
                    "When you’re the son of Kingpin (Wilson Fisk) and Vanessa Fisk, a life of crime might seem only natural. Wilson Fisk never wanted that for his son, Richard, so he tried to keep the boy away from his criminal concerns by sending him to a Swiss boarding school. The distance only made Richard idolize his father more, and when he learned the truth about Kingpin, he went a little insane. He faked his death and used what money he had left to become the Schemer, a criminal mastermind bent on dismantling Kingpin’s empire.",
                    "Kingpin eventually uncovered the Schemer’s true identity, and for a while, the pair reconciled. Under the codename the Rose, Richard entered into the family business, acting as his father’s on-and-off rival and successor. However, after a series of high-profile failures, Richard became sick of working alongside his father and attempted to have him assassinated. Vanessa, in retaliation, killed Richard and then herself.",
                    "Years later, Kingpin used an ancient ritual to bring his son back to life. Richard has since returned to his old Rose persona, and though he and his father aren’t exactly close, they treat each other cordially.",
                ],
                Personality =
                [
                    "Rose is a well-spoken and pleasant man, always wearing stark white suits, a purple ski mask and thick glasses. While he is almost as good as the Kingpin at playing the organized-crime game, he lacks his father’s physical prowess and menace, and his embarrassing attempts to take over his father’s enterprise have diminished his status in the criminal underworld.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Famous),
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
            },
            Source = BookSource.FantasticFourFromTheDepths
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
                tagSelector.GetTag(TagNames.Allspeak),
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
                tagSelector.GetTag(TagNames.Allspeak),
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
                tagSelector.GetTag(TagNames.Allspeak),
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
            Name = "Tinkerer",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 2, resilience: 0, vigilance: 2, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
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
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Phineas Mason",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Gray",
                Hair = "Gray, mostly bald, formerly brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Engineer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.MastersOfEvil],
                Base = "New York City",
                History =
                [
                    "Annoyed by the audacity and showmanship of the vigilantes he saw on the news, small-time repair technician Phineas Mason vowed to become a different kind of villain—a quieter, more thoughtful counterpoint to the flashy world of super-heroics. With the help of Mysterio (Quentin Beck), he used his technical expertise to create an underground spy ring, disguising his listening devices as ordinary electronics and his criminal clients as aliens looking to colonize the planet Earth.",
                    "In one of his earliest outings as an adventurer, Spider-Man (Peter Parker) shattered Mason’s spy ring. However, for years afterward, Parker remained convinced that Mason and his goons had actually been aliens, giving the Tinkerer ample opportunity to rebuild. By the time Mason next appeared in public, he had firmly established himself as one of the top gadget makers and weapon suppliers in the underworld.",
                    "Over the years, the Tinkerer has provided vital technical support to dozens of villains, including the Beetle (Abner Jenkins), the Scorpion and even the Kingpin. Although he occasionally dons a battle suit or equips himself with other gizmos and enters the fray directly, his real passion is facilitating the villainy of others."
                ],
                Personality =
                [
                    "Although technically an engineer, the Tinkerer behaves like a classic mad scientist. His motives are petty, and his social skills are nonexistent. To him, morality is a foreign concept. He cares only about doing good work—and showing up anyone foolish enough to doubt his technical prowess.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
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
        new()
        {
            Name = "Toad",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Sneaky),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder: "Tongue"),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = $"{PowerSetNames.ElementControl} Air/Chemical",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
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
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Tongue Only, Reach 4"),
                        powerSelector.GetPower(PowerNames.SlipFree),
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
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedSwim),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Mortimer “Mort” Toynbee",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [169],
                Gender = Gender.Male,
                Eyes = "Black, originally brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Unnaturally long tongue",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Mort Toynbee spent his childhood in an orphanage where the other kids bullied him relentlessly. Adulthood served him no better, and the punks in his neighborhood took every chance they could to torture him, mocking his strange mannerisms and subjecting him to constant beatings. Then one day, Magneto appeared and offered Toynbee a founding position in the Brotherhood of Evil Mutants, which he accepted without hesitation, taking on the codename Toad.\r\n\r\n",
                    "Unfortunately, the Brotherhood wasn’t everything he dreamed it would be. Magneto treated him as little more than a servant, and his other teammates, while not cruel, still considered him their inferior. Eventually, Toad left the group to go into business as a solo operative. He spent the next several years flipping back and forth between super-villain and super-hero work, gravitating toward jobs that served his burgeoning ego.\r\n\r\n",
                    "As time went on, Toad gradually became more confident and sociable. Slowly but surely, he gained the respect of both his former Brotherhood allies and most of the X-Men. Recently, as part of a scheme hatched by Magneto, Toad took the fall for a murder he didn’t commit, and the Krakoan authorities considered him a fugitive from justice.\r\n\r\n",
                ],
                Personality =
                [
                    "It’s a cruel word, but the best word to describe Toad in his early days is sniveling . Filled with self-hatred, he cowered in the faces of both his allies and his enemies. Although he’s not entirely free from insecurity, the modern Toad has accepted who he is. Most mutants consider him a decent man who can be counted on in a pinch.\r\n\r\n",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Tombstone",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 2, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Weird),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
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
                RealName = "Alonzo Thompson “Lonnie” Lincoln",
                Heights = [new() { Feet = 6, Inches = 7 }],
                Weights = [460],
                Gender = Gender.Male,
                Eyes = "Gray",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "Hard, gray skin, partially severed nose, teeth filed down into fangs",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Maggia, TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "In high school, future Daily Bugle editor Robbie Robertson was threatened by an older kid named Lonnie Lincoln into dropping a story that made Lincoln look bad. Robertson vowed to never again bow down to that kind of pressure, and a few decades later, he had the chance to prove his resolve.",
                    "Now a mid-level Maggia enforcer operating under the codename of Tombstone, Lincoln tried to pressure Robertson into dropping a story that was inconvenient for his employers. When Robertson refused, Tombstone broke his back and beat him within an inch of his life.",
                    "Mad for revenge, Robertson tracked Tombstone to his hideout, shot him and shoved him into a freezer, not knowing it also contained an experimental chemical reagent that would make Tombstone as tough and strong as his namesake. With his new super-powers, Tombstone rapidly rose in the ranks of the criminal underworld to become the head of his own Harlem-based family.",
                    "The two men eventually declared a truce after Robertson discovered that his son Randy was secretly dating Tombstone’s daughter, the Beetle (Janice Lincoln). The prospective in-laws both pitched in to throw a wedding for their children, only for the ceremony to be derailed by a Maggia assassination attempt on Tombstone, kicking o¦ a citywide gang war. With help from Spider-Man (Peter Parker), Tombstone ultimately managed to defeat Madame Masque, the instigator of the attack at the wedding—and became the uncontested leader of New York City’s underworld."
                ],
                Personality =
                [
                    "Tombstone has a soft, raspy voice that pairs well with his quiet brand of evil. Unlike many other super villains, he is not a serial killer or a madman. He is a classic mastermind of organized crime, more concerned with protecting his business interests than with notions of right or wrong.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Tricephalous",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 4, vigilance: 6, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.UnusualSize, specialization: "Huge"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Subterranea"),
                tagSelector.GetTag(TagNames.Mysterious),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.GroupFlight),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
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
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Tricephalous",
                Heights = [new() { Feet = 24 }],
                Weights = [],
                WeightReminder = "13 tons",
                Gender = Gender.Unknown,
                Eyes = "Orange",
                Hair = "None",
                Size = Size.Huge,
                DistinguishingFeatures = "Three-headed green beast",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Monstrous],
                Teams = [],
                Base = "Subterranea",
                History =
                [
                    "Members of the Deviant race created huge mutates to aid them in their battles against the Eternals. When this plot was discovered, the mutates were abandoned on Monster Island and the tunnels below. They were later found and now serve the Mole Man.",
                    "Tricephalous is a three-headed winged reptilian Deviant mutate. One of Mole Man’s leading defenders, Tricephalous has battled his master’s foes numerous times, including the Fantastic Four on their first adventure.",
                ],
                Personality =
                [
                    "Tricephalous acts as a defender and steed for the Mole Man. There appears to be more than one member of its race in Subterranea and Monster Island, as similar looking multiheaded monsters have been seen in the Mole Man’s territories.",
                ]
            },
            Source = BookSource.FantasticFourFromTheDepths
        },
    ];
}
