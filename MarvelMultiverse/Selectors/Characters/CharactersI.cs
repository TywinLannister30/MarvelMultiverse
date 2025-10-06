using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersI
{
    public static List<Character> GetAllCharacters(
       INarrativePowerSelector narrativePowerSelector,
       IPowerSelector powerSelector,
       ITagSelector tagSelector,
       ITraitSelector traitSelector) =>
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
        new()
        {
            Name = "Isca The Unbeaten",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 3, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Arakkii),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.CannotLose)
            ],
            Biography = new Biography
            {
                RealName = "Isca",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [151],
                Gender = Gender.Female,
                Eyes = "Varies, typically white",
                Hair = "Varies, typically black",
                Size = Size.Average,
                DistinguishingFeatures = "Skin, eye and hair colors vary with her allegiance; skin is often covered in black geometric markings",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GreatRingOfArakko],
                Base = "Arakko",
                History =
                [
                    "Isca grew up on the sentient island of Okkara some hundreds of years ago in a settlement of other powerful mutants. Her X-Gene activated in her early childhood, and from that moment on, she could never lose. Ironically, this power served to alienate her from the other people of Okkara, none of whom could stand to compete with her. Only her older sister, Genesis, remained faithful.",
                    "Some years later, the island of Okkara was split into the twin islands of Krakoa and Arakko. While Krakoa remained on Earth, Isca, Genesis and Arakko were sucked through a portal to the demonic dimension of Amenth. Genesis did her best to organize the mutants of Arakko into a fighting force capable of holding back the demonic hordes, but Isca—seeing the overwhelming odds arrayed against them—switched sides and joined the demons, who quickly took over Arakko and possessed Genesis.",
                    "The tide of this battle would not turn again until many years later, when the demons of Amenth attempted to invade Earth through a portal to Krakoa. Isca, working with the people of Krakoa, finally managed to defeat the demons and rejoin her sister. Subsequently, Isca took on a position in the governing Great Ring of Arakko.",
                ],
                Personality =
                [
                    "Isca’s outward confidence masks a tragic emotional interior. Her powers ensure that she is always on the winning team, but they don’t always allow her to pick which team wins. If her preferred side is doomed to fail, her powers cannot make them succeed. Instead, they compel her to switch sides. This has forced her into a duplicitous lifestyle she quietly despises.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
    ];
}
