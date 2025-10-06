using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersK
{
    public static List<Character> GetAllCharacters(
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
}
