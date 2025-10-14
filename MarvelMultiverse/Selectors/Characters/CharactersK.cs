using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersK
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
            Name = "Karma",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 3, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"2 ({PowerNames.Orders}, {PowerNames.TelepathicPossession})"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Dependents, reminder: "Younger siblings (Leong and Nga)"),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.Command),
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
                RealName = "Xuân Cao Manh",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [119],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bionic leg",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "When Xuân Cao Manh was just a little girl, her parents were murdered by pirates, leaving her and her three siblings in the custody of their uncle, General Nguyen Coy.",
                    "Xuân and her twin brother, Trân, were both born with the power to psychically possess other people—a power their uncle sought to exploit for his own nefarious purposes. Xuân feared her powers and refused to go along with her uncle’s plans, but Trân—a sadist at heart—readily agreed.",
                    "To put a stop to Trân’s crime spree, Xuân had to absorb her brother’s entire psyche. He became a permanent part of her—a dark and proactive counterpart to her own shy and patient nature.",
                    "She took the codename Karma, and having already proven herself a hero, she was invited by Professor Charles Xavier to join his junior super-hero squad, the New Mutants. In the years since, Karma has done her best to act as a member of—and later on, advisor to—the New Mutants, but her obligations as a caretaker for her two younger siblings have kept her from being as active a member of the team as many of her cohorts."
                ],
                Personality =
                [
                    "From the moment she absorbed Trân, Xuân was doomed to have a somewhat unstable personality. Depending on the emotional states of the people she possessed, she could be perfectly fine one moment and irrationally angry the next.",
                    "The founding of Krakoa changed everything for Xuân. For the first time in years, Trân has a body of his own, and Xuân has a mind all her own. She’s been trying to make the best of her newfound freedom by focusing on herself and her relationships, particularly that with her girlfriend, Galura."
                ]
            },
            Source = BookSource.XMenExpansion
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Karnak’s Hands"),
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Karnak’s Hands",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "On a Fantastic success, causes bleeding."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Damage Multiplier Bonus +1."),
                    ],
                    Restrictions =
                    [
                        "Menacing",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                },
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
            Name = "Kid Juggernaut",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 1, resilience: 5, vigilance: 2, ego: 3, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2; Kid Juggernaut form only"),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Justin Jin"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Avengers Academy"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain Marvel (Carol Danvers)"),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Shard of the Crimson Gem of Cyttorak", isMagicItem: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                }
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Shard of the Crimson Gem of Cyttorak",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty3),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy2),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                    Restrictions =
                    [
                        "Flashy",
                        "Large"
                    ],
                    Tags =
                    [
                        tagSelector.GetTag(TagNames.AlternateForm),
                    ],
                    PowerValue = 3,
                }
            ],
            Biography = new Biography
            {
                RealName = "Joon-Sung “Justin” Jin",
                Heights = [new() { Feet = 6, Inches = 8 }],
                Weights = [225,475],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Big,
                SizeNotes = "Average as Joon-Sung “Justin” Jin",
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Student],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.AvengersAcademy],
                Base = "Avengers Academy",
                History =
                [
                    "The Crimson Gem of Cyttorak and the title of Juggernaut were once held by a Korean farmer named Moon-Ho Jin who—on orders from the demon Cyttorak—helped Japanese imperialists invade his homeland. However, when the time came to raze his own village, Jin hesitated. Outraged, Cyttorak summoned Cain Marko, who killed Moon-Ho and claimed the gem as his own, becoming the new Juggernaut.",
                    "Moon-Ho’s son Jung-Woo recovered a shard of the gem, but out of shame for his father’s legacy, he kept the existence of the shard secret. He later married a woman named Hae-Ran with whom he had a son named Joon-Sung. For a few years, they lived happily together, but in time, the parents grew apart and divorced. In Jung-Woo’s absence, Hae-Ran and Joon-Sung moved to Vancouver, where they started a café.",
                    "Years later, Cyttorak directed a mage named Malphegor to kill Jung-Woo and take possession of the shard. Though the wizard succeeded in the former task, he failed in the latter. As his final act, Jung-Woo sent the shard to his teenage son, who promptly absorbed its powers and defeated his father’s killer.",
                    "Cyttorak pushed Joon-Sung to kill Malphegor, but the boy resisted the demon’s dark influence. Calling himself Kid Juggernaut, he vowed that, from that day forward, he would be the hero that his grandfather had never been.",
                    "These days, Kid Juggernaut spends most of his time at the new Avengers Academy, learning the basics of hero work alongside his classmate and crush, Aaron Fischer."
                ],
                Personality =
                [
                    "Justin Jin is as kind as he is strong, and as gentle as he is unstoppable. He can, at times, be a bit inattentive to his surroundings, but he’s such a good guy that no one begrudges him for it.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Kid Omega",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 2, vigilance: 8, ego: 4, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.QuickLearner),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.Command),
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
                RealName = "Quintavius Quirinius “Quentin” Quire",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [129],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown, currently dyed pink",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.WestCoastAvengers, TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "Quentin Quire is an ambitious and talented young telepath. He joined Professor Xavier’s School for Gifted Youngsters during its first year of fully public operations as a school for mutants, and he rapidly distinguished himself as a leader within the mutant student body. Almost overnight, a cultlike following formed around him.",
                    "Quire was not emotionally prepared for this level of success. The fame went to his head, and soon enough, he started thinking he would be a better headmaster for the school than Professor X. He and his most loyal followers attacked the Professor, declaring themselves the true masters of the institute.",
                    "The other teachers at the school managed to put Quire’s rebellion down without much effort, but the reputation of “troublemaker” stuck with him, driving him toward further misbehavior, even years afterward. Only recently has he managed to put aside his old ways and learn a bit of humility.",
                    "As a member of Krakoa’s X-Force, Quire played a critical role in the protection of the island-nation. The older mutants on Krakoa still regard him with suspicion, but many of the island’s younger residents consider him a figure worthy of respect and even admiration."
                ],
                Personality =
                [
                    "Despite his incredible talents, Quentin Quire is a deeply insecure person. He believes himself to be mostly worthless, and he lives in constant fear that his peers and superiors might come to see him the same way he sees himself. That’s why he’s so eager to take on leadership roles. As long as he’s in charge, people have to respect him.",
                    "Quire has slowly learned to deal with his insecurities in healthier ways, but the feelings have never entirely left him. He’s still recovering from his breakup with Phoebe Cuckoo, of the Stepford Cuckoos."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Kidpool",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.MediaAwareness),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Deadpool of Earth-616"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Laser Swords"),
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
                        powerSelector.GetPower(PowerNames.Uncanny1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
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
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wade Wilson",
                Heights = [new() { Feet = 4, Inches = 5 }],
                Weights = [90],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Small,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DeadpoolCorps],
                Base = "Mobile",
                History =
                [
                    "A resident of Earth-10330, obnoxious preteen Wade Wilson was the least popular student at the Xavier Orphanage for Troubled Boys. While in Danger Room detention with Scott Summers, Wilson convinced Summers to break out and used two energy swords he stole from the Danger Room to ruin a school dance for everyone. Moments before he was to be expelled, Earth-616’s Deadpool arrived to recruit him into the multiversal Deadpool Corps alongside several variants of himself. Nicknamed “Tito” and later “Kidpool,” he joined the Corps in battling the sentience-devouring Awareness at the behest of the Elders of the Universe and continued to serve alongside them as they became a spacefaring mercenary crew, becoming embroiled in a struggle over the resource-rich planet Kagan 7 between its natives and the rapacious Omega Confederation. Kidpool struck out on his own with Dogpool; at one point, while attempting to impress a group of children, he stole the experimental military mecha suit Jet Falchion, resulting in enormous property damage. Eventually, the disappointed Elders sent the Deadpool Corps, including Kidpool, back to their home universes. Later, Lady Deadpool reassembled the Corps when they were threatened by the Evil Deadpool Corps, a multiversal coalition of Deadpools dedicated to killing all other Deadpools. While the Corps sought Earth-616’s Deadpool, one of the Evil Deadpools killed Dogpool; the Corps then returned to their base to find all their teammates had been slaughtered. Kidpool accidentally triggered one of their booby-trapped corpses; welcoming the chance to be reunited with Dogpool, he was killed in the ensuing explosion. He was later resurrected by the reality-manipulating Killville.",
                ],
                Personality =
                [
                    "Kidpool is impulsive and belligerent. However, he has managed to find a surrogate family in the Deadpool Corps, forming an especially strong bond with the canine Dogpool.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
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
            Name = "Kindred",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 5, vigilance: 5, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in true form"),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                        powerSelector.GetPower(PowerNames.Resurrect),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Possession),
                        powerSelector.GetPower(PowerNames.SenseSins),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
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
            ],
            Biography = new Biography
            {
                RealName = "Gabriel and Sarah Stacy",
                Heights = [new() { Feet = 6 }, new() { Feet = 5, Inches = 6 }],
                HeightReminder = "Gabriel / Sarah",
                Weights = [180, 125],
                WeightReminder = "Gabriel / Sarah",
                Gender = Gender.Varies,
                GenderReminder = "Male (Gabriel), female (Sarah)",
                Eyes = "Brown (Gabriel), blue (Sarah)",
                Hair = "Auburn (Gabriel), blond (Sarah)",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicDemonic, OriginName.WeirdScience],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "Shortly before his death, the Green Goblin (Harry Osborn) launched two separate long-term schemes that would toy with the mind of Spider-Man (Peter Parker) for years to come. The fi rst of these projects involved a simple pair of Life-Model Decoys made to look like Parker’s parents. The second was far more complicated.",
                    "Using DNA samples harvested from Gwen Stacy and Norman Osborn, Harry created a pair of unique, rapidly aging clones named Gabriel and Sarah Stacy, who closely resembled Norman and Gwen, respectively. He then brainwashed not only the clones, but also Norman and Mary Jane Watson, into believing that Gabriel and Sarah were Norman and Gwen’s illicit children.",
                    "Acting on the orders of an A.I. construct of Harry, the twins set out to torment Spider-Man, torturing him with the idea that Gwen had cheated on him with his worst enemy. Spider-Man eventually uncovered the truth behind the scheme, and shortly thereaft er, the twins died of old age.",
                    "In an attempt to break Spider-Man’s will, Mephisto resurrected the pair and imbued them with magical abilities. Acting in tandem as the demonic Kindred, Gabriel and Sarah blasted Parker with visions of those he couldn’t save, driving him to the brink of insanity. Thankfully, Parker managed to keep his mind together long enough for Mephisto to lose faith in his agents and send them back to the underworld."
                ],
                Personality =
                [
                    "Gabriel and Sarah are angry and irrational individuals driven by resentment. They resent Harry for creating them. They resent Norman for how he raised Harry. Most of all, they resent Peter Parker for, as they see it, driving Harry and Norman to insanity in the fi rst place.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
            Name = "Kingpin (Earth-65)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 1, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Cane Sword (acts as a regular sword)"),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
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
            ],
            Biography = new Biography
            {
                RealName = "Matthew “Matt” Murdock",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Lawyer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.TheHand],
                Base = "New York City (Earth-65)",
                History =
                [
                    "The history of Earth-65’s Matt Murdock almost exactly mirrors that of his Earth-616 counterpart until midway through his adolescence, when members of the Hand killed his mentor, Stick, and forcibly enlisted him into their ranks. As Murdock grew older, the Hand began to fear his strange abilities and eventually they sent him away to live in New York. Trained to seek power at all costs, Murdock worked his way into becoming the right-hand man of Kingpin (Wilson Fisk), and after Fisk was sent to prison, Murdock took over the crime lord’s organization, becoming the new Kingpin.",
                    "Though he had achieved supremacy over the criminal underworld, Murdock had no idea what to do with his power—until he saw Ghost-Spider. Inspired by her unfl inching heroic spirit, he became obsessed with corrupting her. With all the resources of the underworld behind him, he launched a vast campaign of torment, blackmail and extortion against the wall-crawler.",
                    "When Murdock’s plans failed to yield results, he grew increasingly unhinged. Eventually, he chose to burn his organization to the ground, betraying both the Maggia and the Hand. The Hand tried to kill him, but their ninja stood no chance against Murdock. Ultimately, it took the combined efforts of Ghost-Spider and her band of friends to bring him down and send him to a high-security S.H.I.E.L.D. prison."
                ],
                Personality =
                [
                    "Sharp, arrogant, violent and manipulative, Matt Murdock makes for a good lawyer and an even better mobster. He hates himself for becoming everything he stood against in his youth, but heroes would have a better chance of cutting him physically before they could cut through the facade he puts up to hide his shame.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Kl'rt, the Super-Skrull",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 3, resilience: 3, vigilance: 3, ego: 6, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Kree-Skrull Alliance)"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in natural form"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Emperor Hulkling"),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "when disguised"),
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
                    Name = $"{PowerSetNames.ElementControl} Fire / Force",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendInvisibility),
                        powerSelector.GetPower(PowerNames.Invisibility),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
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
                RealName = "Kl’rt",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 6’8”",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 625 lbs.",
                Gender = Gender.Varies,
                Eyes = "Yellow (Varies)",
                Hair = "None (Varies)",
                Size = Size.Average,
                DistinguishingFeatures = "Green-skinned alien with shape-shifting powers, in addition to other powers.",
                Occupations = [OccupationName.Military, OccupationName.Spy],
                Origins = [OriginName.AlienSkrull],
                Teams = [TeamNames.KreeSkrullAlliance, $"{TeamNames.ChildrenOfLostTarnax} (infiltration)"],
                Base = "Abandoned Safehouse",
                History =
                [
                    "Kl’rt is an experienced soldier of the Skrull Empire. He was imbued with super powers by the Skrull Emperor Dorrek in a plot to gain revenge against the Fantastic Four, and dubbed the “Super-Skrull.” While he would occasionally have the upper hand in these conflicts, he was regularly defeated by the team. He fell out of favor with the government and was exiled, becoming a free agent and often having an on-again, off-again relationship with both the inhabitants of Earth and his home race. Eventually, after the Skrull Empire had crumbled into factions, he joined the group devoted to seeking an heir to Emperor Dorrek VIII — Hulkling. The Super- Skrull revealed the truth of Hulkling’s origin and his own role in killing Hulkling’s “mother.” As punishment, Kl’rt was forbidden from taking another life and relegated to diplomatic duty.",
                ],
                Personality =
                [
                    "Kl’rt is arrogant, often considering himself to be the most powerful warrior of his kind, and possibly the entire galaxy. He is also extremely loyal to the ideals of the Skrull empire, even when his race has repeatedly turned their backs on him. He has grown to loathe the superhumans of Earth due to his repeated defeats, but his recent punishment by his emperor is forcing him to re-evaluate this hatred. He isn’t adverse to tricking humans into doing his dirty work for him, however.",
                ]
            },
            Source = BookSource.RevengeOfTheSuperSkrull
        },
        new()
        {
            Name = "Klaw",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 5, vigilance: 6, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Vibranium"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Ulysses S. Klaw",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Red, formerly brown",
                Hair = "None, formerly black",
                Size = Size.Average,
                DistinguishingFeatures = "Unique sonic construct with red and purple body",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FrightfulFour, TeamNames.MastersOfEvil],
                Base = "Mobile",
                History =
                [
                    "Gifted scientist Ulysses Klaw created a revolutionary machine capable of converting sound waves into real physical constructs. All the machine needed was authentic Wakandan vibranium, and as the son of a Nazi, Klaw had no problem with simply invading Wakanda and taking it. He would have succeeded, too, had the Black Panther (T’Chaka) not sacrificed himself to ward off the invading army.",
                    "Years later, Klaw returned, backed by sonic constructs of his own design, and attempted to take over the country again, only to face overwhelming resistance from the new Black Panther (T’Challa) and the Fantastic Four. He tried to turn the tide back in his favor by transforming himself into a being of pure sound, but Wakanda’s defenders sent him packing anyway.",
                    "Klaw has tried and failed to conquer Wakanda since then, but to fund his operations he’s had to take on more and more work with other villainous organizations. He still dreams of looting and dismantling the African nation, but now he does so in between his regular stints with the Frightful Four and the Masters of Evil.",
                ],
                Personality =
                [
                    "Klaw is a vengeful, narcissistic madman who cares nothing for the rights of other people, particularly people of color. He would love nothing more than to establish himself as a petty tyrant over all of Africa. Fortunately, he is not nearly smart or powerful enough to have ever come close.",
                ]
            },
            Source = BookSource.AvengersExpansion
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
                Base = "Savage Land",
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
        new()
        {
            Name = "Kraven the Hunter (Ana Kravinoff)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 2, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
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
                RealName = "Anastasia Tatiana “Ana” Kravinoff",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Inhuman, OriginName.Magic],
                Teams = [TeamNames.Syndicate],
                Base = "New York City",
                History =
                [
                    "As the youngest progeny of the original Kraven the Hunter (Sergei Kravinoff), Ana Kravinoff grew up hardly knowing her father. Nonetheless, her mother, Sasha, raised her to revere their deceased patriarch and to despise his enemies, particularly Spider-Man (Peter Parker).",
                    "The moment that Ana was old enough to fi ght, Sasha sent her off to New York City to kill the Web- Head. This “first hunt” ended in failure, but ever undeterred, Ana and her mother spent the next several years coming up with plans to ensure the web-slinger’s downfall, eventually spearheading a scheme to resurrect Sergei himself.",
                    "The Kravinoffs were thrilled to see their patriarch in the fl esh once again, but Sergei—unable to believe that such weak people were his successors—killed off most of the family, sparing only Ana, due to her potential. However, in time he became disillusioned with Ana as well and decided to make dozens of clones of himself fi ght to the death to earn a place as his true successor.",
                    "Disgusted by her father’s actions, Ana abandoned him and sought employment as a mercenary. She currently spends most of her time working with the all-female Syndicate led by the Beetle (Janice Lincoln)."
                ],
                Personality =
                [
                    "In many ways, Ana Kravinoff is still fi guring herself out. She continues to use her father’s codename, but she no longer cares much for him or the Kravinoff name. Her only surviving family member is her father’s clone successor, and she hates him almost as much as she hates Spider-Man.",
                    "Ana maintains a bit of the old Kravinoff aristocratic superiority, but unlike her former family members, she is open to other points of view."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Kraven the Hunter (Last Son of Kraven)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 3, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Spear (+1 Melee damage multiplier bonus; range: reach +1)"),
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
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "None",
                Heights = [new() { Feet = 6 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic, OriginName.WeirdScience],
                Teams = [TeamNames.SinisterSix, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "Having finally bested his longtime rival Spider- Man (Peter Parker), Sergei Kravinoff shot himself, content that the legend of his Last Hunt would live long past his death. However, his wife and daughter could not let sleeping dogs lie, and after years of searching out the right rituals, they resurrected their patriarch. Disgusted by his own return, Kravinoff disowned his family and retired to the Savage Land where, with the help of the High Evolutionary, he created and raised 87 clones of himself, training them to follow in his footsteps.",
                    "Eventually, the most brutal of these clones killed all his brethren, earning him the title of Kraven’s Last Son. In the guise of Spider-Man, Kravinoff attacked his Last Son, baiting the clone into beating him to death. As a reward for the clone’s victory, Kravinoff left behind a note naming his Last Son as his one true heir.",
                    "As the new Kraven the Hunter, this clone—who refers to the original as his father—has worked tirelessly to hunt down Spider-Man and his wall-crawling allies. Though he may lack his father’s depth of experience, he is just as vicious and clever as the old Kraven, if not more so."
                ],
                Personality =
                [
                    "Just like his father, this new Kraven is arrogant and bombastic, but he is also determined to prove himself to be the greatest hunter who ever lived. He cares for little else, and he regards the rest of Kraven’s family, particularly Kraven’s daughter, Ana Kravinoff —who also uses the Kraven the Hunter title—as mere pretenders to the throne.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
    ];
}
