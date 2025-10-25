using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersC
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
            Name = "Cable",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 5, vigilance: 4, ego: 4, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Infector, reminder: "Techno-Organic virus"),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
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
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.CloakGroup),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                        powerSelector.GetPower(PowerNames.MentalShelter),
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
                "The Graymalkin II is a city-sized starship that grants Cable a range of Teleportation powers, which he refers to as “bodysliding.” As long as he remains in contact with his ship, he can access the following Teleportation powers: Blink, Teleport 2, Teleport Object, Teleport Together, Teleportal"
            ],
            Biography = new Biography
            {
                RealName = "Nathan Christopher Charles Summers",
                Heights = [new() { Feet = 6, Inches = 8 }],
                Weights = [350],
                Gender = Gender.Male,
                Eyes = "Naturally blue, but left eye glows yellow when using powers",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "Scar over right eye, glowing left eye, Techno-Organic left arm",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "As an infant, Nathan Summers was kidnapped by Apocalypse and infected with the deadly Techno-Organic virus. To save his life, Summers was sent to the dystopian future of Earth-4935, where Apocalypse ruled supreme.",
                    "The people of this alternate Earth spent years tutoring Summers in the use of his mutant psychic powers, teaching him to telekinetically halt the advance of the Techno-Organic virus. His training went spectacularly well, allowing him to defeat Apocalypse early in his teenage years.",
                    "As a young man, Summers returned to Earth-616 shortly before the Krakoan era to discover that an older version of himself arrived well ahead of him. Summers killed his future self, but helped the Five revive the older version on Krakoa before returning to Earth-4935.",
                    "Summers spent the next few decades fighting on Earth-4935, dealing with the aftermath of Apocalypse’s reign and slowly becoming that older version of himself. Battle-hardened, he returned to Earth-616 at a point in the timeline near when he had been kidnapped as a baby. During that era, he founded X-Force and participated in countless world-saving adventures—before being killed and revived by a younger version of himself."
                ],
                Personality =
                [
                    "After decades of battle on Earth-4935, Cable became a gruff veteran with a penchant for three things: battling, shouting one-liners and shouting one-liners in battle.",
                    "Cable has few close friends or attachments, but he does share a bond with his father (Cyclops), his adoptive mother (Jean Grey) and his adopted daughter (Hope Summers)."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Callisto",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 1, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                RealName = "Unknown",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Eyepatch",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.HellfireTradingCompany, TeamNames.Morlocks],
                Base = "Krakoa",
                History =
                [
                    "As a young mutant, Callisto was attacked by mutant-hating humans, who scarred her and blinded her in one eye. Shortly thereafter, she gave up on trying to live alongside normal humans and took to a life of seclusion in the sewers beneath Manhattan.",
                    "Underground, Callisto met with a number of other mutants who had similarly abandoned human society. With Callisto as their leader, these exiles banded together and formed their own society, becoming the Morlocks.",
                    "Although initially wary of the X-Men, these Morlocks nonetheless came to assist the mutant heroes on many of their adventures. One of the X-Men—Storm—eventually came to replace Callisto as the de facto leader of the Morlocks.",
                    "However, not long after Storm’s takeover, the Morlocks were driven from their underground home by a band of evil mutants and slaughtered by the dozens. Callisto was one of the few survivors.",
                    "Callisto and the remaining Morlocks spent the next several years drifting around the world until the founders of Krakoa provided them with a new place to settle down. Many of the Morlocks occupy critical positions within the new Krakoan government, with Callisto herself serving as the White Knight of the Hellfire Trading Company."
                ],
                Personality =
                [
                    "Callisto is a proud woman and a born leader. Equally charismatic and stubborn, she has a strong sense of justice and a correspondingly strong distaste for most normal humans.",
                    "Although she puts up a tough front, Callisto has a soft spot for the Morlocks and the X-Men, particularly Storm. Callisto and Storm have long been rivals of a sort, but within that rivalry, they share a strong and mutual respect."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Cannonball",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 3, vigilance: 2, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Ram"),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Samuel Zachery Guthrie",
                Heights = [new() { Feet = 6 }],
                Weights = [181],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.XForce, TeamNames.XTerminators],
                Base = "Krakoa",
                History =
                [
                    "To make ends meet for his family, young Sam Guthrie had to take a job working in the same rural coal mine that killed his father. On Guthrie’s very first day on the job, the mine collapsed, trapping him inside.",
                    "Guthrie and every other worker in the mine that day should have died, but the panic of the collapse triggered something deep inside the boy’s genes. He grabbed hold of his friends and blasted his way out of the mine.",
                    "This act of heroism drew the attention of Professor Charles Xavier, who correctly deduced that Guthrie was a mutant. At Xavier’s request, Guthrie became a founding member of the New Mutants, a super-team consisting entirely of teenage mutants.",
                    "Guthrie eventually aged out of the New Mutants, at which point he became a founding member of X-Force. Since then, he has continually bounced back and forth between working with X-Force and helping to tutor the newest incarnations of the New Mutants.",
                    "When he’s not adventuring, Guthrie spends most of his time with his wife, Izzy (A.K.A. the Smasher) and their son, Josiah. Much of that time is spent on Chandilar, throneworld of the Shi’ar Empire."
                ],
                Personality =
                [
                    "Guthrie has seen more action than most super heroes could ever hope to. He has fought in intergalactic wars, traversed alternate dimensions and acted as the leader or co-leader of several important super-teams, but he hasn’t let any of it faze him.",
                    "Deep down, Guthrie is still a goofy teenager from Kentucky. He likes drinking beer, grilling burgers and chilling with his teammates. Of all his old colleagues, Guthrie is particularly close with Sunspot. They regularly get together on the weekends just to catch up."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Captain America (Bucky Barnes)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 3, vigilance: 4, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Fearless),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Captain America’s shield"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
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
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.HurledShieldBlock),
                        powerSelector.GetPower(PowerNames.RicoShield),
                        powerSelector.GetPower(PowerNames.Shield2, reminder: "Shield 3 with Iconic Item"),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Captain America’s Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.ReducedFocus),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Stackable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplierbonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        "Requires: Shield 1 power"
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
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
                Occupations = [OccupationName.Adventurer, OccupationName.Spy],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.KGB, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Toward the end of World War II, the aerial explosion that sent Captain America (Steve Rogers) into the north Atlantic where he froze into a block of ice seemingly killed his sidekick, the young Bucky (Bucky Barnes). He was captured by Soviet scientists, who replaced a missing arm with a bionic prosthetic and brainwashed him to become a Russian assassin codenamed the Winter Soldier, after which he was kept in suspended animation for decades, only released to kill and then returned to sleep again.",
                    "Cap eventually discovered who the Winter Soldier was and successfully undid Bucky’s brainwashing. During a period when Rogers was believed to be dead, Bucky took up the shield and replaced him as Captain America.",
                    "Bucky eventually gave up the title and returned to his regular globe-trotting activities, first as the Winter Soldier and then, most recently, as the Revolution. This profile, however, represents Bucky during the period when he was Captain America, when he was doing everything he could to live up to the legacy of his old mentor."
                ],
                Personality =
                [
                    "Bucky is a deadly serious and world-weary vet. The remorse he feels for his time as an assassin weighs on him every day.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Captain America’s shield"),
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Captain America’s Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.ReducedFocus),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Stackable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplierbonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        "Requires: Shield 1 power"
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
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
                Base = "New York City",
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Captain America’s shield"),
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
                        powerSelector.GetPower(PowerNames.Shield3, reminder: "Shield 4 with Iconic Item"),
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Captain America’s Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.ReducedFocus),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Stackable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplierbonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        "Requires: Shield 1 power"
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
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
            Name = "Captain America (Early Days)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 3, vigilance: 2, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Beguiling),
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
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Triangular shield (acts as a standard shield)"),

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
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Shield1),
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
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
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
                Teams = [TeamNames.USArmy],
                Base = "Camp Lehigh, Virginia",
                History =
                [
                    "At the dawn of World War II, scrawny Steve Rogers was rejected by the U.S. Army as unfit for service, but Dr. Abraham Erskine saw something in him and selected him for the first human trials for his Super-Soldier Serum. A Nazi sympathizer assassinated Erskine during the procedure, but not before Rogers was improved to the peak of human physical ability. As Captain America, Rogers fought Nazis on the front lines in Europe, alongside his sidekick Bucky Barnes—right up until 1945 when they were presumed killed while stopping a plot by the evil Baron Zemo.",
                    "Decades later, the newly formed Avengers found Rogers frozen in a block of ice and revived him, allowing him to return to the field. However, this profile represents Rogers long before he was frozen, even before the United States entered World War II. This is Rogers in his earliest days, back when he and Bucky were just a couple of low-rank grunts, secretly performing covert military operations in their off-hours.",
                ],
                Personality =
                [
                    "Rogers is serious about helping people out, and he’s a natural leader, both in and out of combat. He knows that when he’s in his costume and carrying his shield he represents everything that is great about the land and people he loves so much.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Captain America (Earth-1610)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 4, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Hydra"),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Captain America’s shield"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.HurledShieldBlock),
                        powerSelector.GetPower(PowerNames.RicoShield),
                        powerSelector.GetPower(PowerNames.Shield3, reminder: "(Shield 4 with Iconic Item)"),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Captain America’s Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.ReducedFocus),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Stackable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplierbonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        "Requires: Shield 1 power"
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Steven “Steve” Rogers",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [250],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Ultimates],
                Base = "Mobile (Earth-1610)",
                History =
                [
                    "The life of Earth-1610’s Captain America largely resembles that of his Earth-616 counterpart, right up until the end of World War II. Rogers fell into the icy water while disarming an experimental missile created by a Nazi named Herr Kleiser, who was actually an alien Chitauri.",
                    "Decades later, Rogers was fished out of the ice by agents of S.H.I.E.L.D. who immediately drafted him into their new super-team program: the Ultimates. His unrelenting ruthlessness as a combatant quickly propelled him to become the team’s field leader, and he led the Ultimates on a mission that successfully wiped out Kleiser and his plot for the shape-changing Chitauri to take over the world.",
                    "Since then, Rogers has faithfully and consistently served as the linchpin of both the Ultimates and the United States itself. He even served as the president of the country during a brief period when it seemed like the nation might once again descend into a civil war, though he stepped down as soon as the crisis ended."
                ],
                Personality =
                [
                    "While Earth-1610’s Steve Rogers has a lot in common with his Earth-616 counterpart, he lacks the latter man’s idealism. He’s an old-fashioned soldier and a die-hard patriot, but he’s not as concerned about the symbolism of his role. Rogers’ determination to win and to never give up drives him hard.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Captain America of the Railways",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AuditoryIssues, reminder: "partially deaf in right ear"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Avengers Academy"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain Marvel (Carol Danvers)"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Young),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Captain America of the Railways’ Shield"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.RicoShield),
                        powerSelector.GetPower(PowerNames.Shield2, reminder: "(Shield 3 with Iconic Item)"),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Captain America of the Railways’ Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Stackable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplierbonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Aaron Fischer",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Student],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.AvengersAcademy, TeamNames.CaptainsNetwork],
                Base = "Avengers Academy",
                History =
                [
                    "Life at home was never great for Aaron Fischer growing up as an openly gay teen in an isolated community, and after cancer took his mother, things only got worse. One day, he decided he’d had enough of his father’s beatings and hit the rails, living out of boxcars and drifting wherever the tracks took him.",
                    "As time passed and Fischer witnessed more and more of the hardships that come with rough living, he gradually came to see the rails as his home and himself as their protector. Inspired by his childhood hero—Captain America—Fischer fashioned a shield and a costume and became the Captain America of the Railways, champion of those with nowhere else to go. Soon after that, he met both of the main Captains America—Steve Rogers and Sam Wilson—and helped them expose a string of vagrant kidnappings by the Roxxon Energy Corporation.",
                    "Later, while investigating a similar string of crimes committed by Alchemax, Fischer stumbled into a trap set by the ringleaders of the conspiracy. The corporation had been testing a deadly new Super-Soldier treatment on the local unhoused population. It forced this treatment onto Fischer, hoping to kill him, but for some reason, the treatment actually worked on him. With his new energy powers, Fischer dismantled the facility and freed the remaining victims.",
                    "These days, Fischer spends most of his time at the new Avengers Academy, learning how to be a better hero alongside his crush, Kid Juggernaut."
                ],
                Personality =
                [
                    "In regular interpersonal situations, Fischer can be awkward and shy, but that all disappears the second he sees someone in need. He has an unflinching commitment to helping others, particularly the poor and disenfranchised. His first priority is always the protection of others, and as such, he never uses his energy powers to blast others, only to shield them.",
                ]
            },
            Source = BookSource.AvengersExpansion
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
            Name = "Captain Britain",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 5, vigilance: 4, ego: 2, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Betsy Braddock’s Psychic Sword"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
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
                        powerSelector.GetPower(PowerNames.MentalPunch),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Betsy Braddock’s Psychic Sword",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Constructable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.DamageSwitch),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier Bonus: +2."),
                    ],
                    Restrictions =
                    [
                        "Flashy",
                        "Requires: Logic 2 or more"
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 2
                }
            ],
            Biography = new Biography
            {
                RealName = "Elizabeth “Betsy” Braddock",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [155],
                Gender = Gender.Female,
                Eyes = "Violet",
                Hair = "Blond, currently dyed purple",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.MagicSorcery, OriginName.Mutant],
                Teams = [TeamNames.CaptainBritainCorps, TeamNames.Excalibur, TeamNames.KnightsOfX],
                Base = "Krakoa",
                History =
                [
                    "Not long after her twin brother, Brian, first took up the mantle of Captain Britain, Betsy Braddock began to manifest powers of her own. Her psychic abilities and excellent reflexes made Betsy an ideal stand-in for her brother and, soon enough, there were two Captain Britains protecting the United Kingdom.",
                    "Tragically, this state of affairs did not last. Betsy was kidnapped by the otherworldly villain Mojo and brainwashed into becoming the treacherous psychic assassin Psylocke. To complicate matters further, soon after Betsy escaped Mojo’s programming, she was forced into a body-swap with an actual professional assassin named Kwannon.",
                    "Her mind having partially merged with Kwannon’s, Betsy spent most of the next decade in a spiritual and mental confusion, unsure of her purpose in life. As Psylocke, she was both an ally and an enemy to all around her.",
                    "Only recently did Betsy manage to regain control of her original body and resume her place as Captain Britain. With Brian having become the super hero Captain Avalon, Betsy is the sole holder of the Captain Britain title. She has taken on a vital leadership role in the defense of both Krakoa and Otherworld.",
                ],
                Personality =
                [
                    "Betsy Braddock is as much of a serious and stoic warrior as her brother, if not more so. She’s a focused commander with no patience for small talk or joking around on the battlefield.",
                    "Outside of battle, Betsy can be charismatic and thoughtful. She’s had whirlwind romances with other heroes over the years, having most recently started a relationship with Askani (Rachel Summers)."
                ]
            },
            Source = BookSource.XMenExpansion
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
                    Name = PowerSetNames.ElementalControlEnergy,
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
            Name = "Cardiac",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 4, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "Elemental Barrage"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalPush),
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
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Elias “Eli” Wirtham",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [300],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.HealthCareWorker],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.HEARTClinic, TeamNames.MarvelMedics],
                Base = "New York City",
                History =
                [
                    "After his brother, Joshua, died of a painful and degenerative disease with no known cure, Elias Wirtham vowed to create a world in which no one would have to suffer like that ever again. Overcoming impossible odds, he fought his way up the ranks of the medical industry—first as a surgeon, then later as an executive. He eventually acquired a company known to have done promising research on his brother’s disease, only to discover, to his horror, that the company had cured the disease decades ago but shelved the treatment due to its unprofitability.",
                    "Completely disillusioned with the private health care industry and the law as a whole, Wirtham became a vigilante. Using his vast resources and his skills as a surgeon, he replaced his heart with an energy generator and his skin with hard cybernetic armor. Under the codename Cardiac, he set out to assassinate every white-collar criminal he could get his hands on.",
                    "However, after many of his assassinations were foiled by Spider-Man (Peter Parker), Cardiac settled on a less lethal approach to his mission. He’s still a criminal, but he’s not a killer, and these days, he spends most of his time stealing resources from the rich and powerful to help the poor clients of his nonprofi t H.E.A.R.T. health clinic.",
                ],
                Personality =
                [
                    "Though his methods may sometimes be questionable, Cardiac’s values have always been pure. He’s a kind and handsome surgeon with a good bedside manner, and like every great hero, he is fully dedicated to the cause of protecting the weak and powerless.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Carnage",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 4, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
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
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Razorwebs),
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
                RealName = "Cletus Cortland Kasady",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "Carnage form has retractable claws, fangs and an unnaturally long tongue",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SymbioteVenom],
                Teams = [TeamNames.SymbioteHive],
                Base = "New York City",
                History =
                [
                    "Even before he became Carnage, Cletus Kasady’s death toll was shocking. Evidence exists to suggest that before the age of 18, he had already killed his parents, his grandparents, several sets of foster parents and an entire orphanage. Later in life, he was convicted of killing and partially eating almost a dozen people, and he was sentenced to a corresponding eleven consecutive life sentences on Ryker’s Island.",
                    "Unwilling to let prison put a damper on his killing streak, Kasady immediately attempted to murder his cellmate, not knowing that his prospective victim was, in fact, Venom (Eddie Brock). In the fi ght, the Venom symbiote gave birth to a new symbiote, which entered Kasaday's bloodstream, transforming him into the symbiotic serial killer Carnage.",
                    "Empowered beyond his wildest dreams, Carnage set out to commit murder on a mass scale. In the end, it took the combined efforts of Spider-Man (Peter Parker) and Venom to take him down and bring the slaughter to an end.",
                    "Carnage has escaped from prison many times since then, with each subsequent killing spree more deadly than the last. During his last major escapade, he came within inches of overrunning the entirety of New York City with an army of immortal Carnage zombiotes. Though he has since lost his godlike powers, he remains one of the most lethal and dangerous super villains on the planet."
                ],
                Personality =
                [
                    "The Carnage symbiote entered Kasady’s body when it was only an infant, so unlike with the original Venom symbiote, Carnage’s consciousness cannot be fully disentangled from Kasady’s own. They are both utterly deranged and narcissistic psychopaths who delight in the torture and slaughter of others.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Cassandra Nova",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 2, vigilance: 9, ego: 9, logic: 9
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                        powerSelector.GetPower(PowerNames.TelepathicPossession),
                    ],
                },
            ],
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.DNAManipulation),
            ],
            Biography = new Biography
            {
                RealName = "Cassandra Nova Xavier",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [115],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant, OriginName.MonstrousMummudrai],
                Teams = [TeamNames.Marauders],
                Base = "Krakoa",
                History =
                [
                    "Cassandra Nova Xavier—or Cassandra Nova, as she is often called—is Professor Charles Xavier’s long-lost evil twin. She formed alongside him in the womb, and Charles—sensing her terrible nature—attempted to strangle her. A few of her still-living cells escaped the womb and fell into a nearby sewer. They spent the next several decades festering on a dirty wall, growing a full body.",
                    "Nova finished re-forming on a bright summer morning. By that afternoon, she had destroyed the nation of Genosha and killed an estimated sixteen million mutants.",
                    "The X-Men put an end to her genocide as quickly as they could, but the damage had been done. Nova spent much of the next several years imprisoned by the X-Men. In exchange for promises of reform, she was allowed to go free, though she remains under strict surveillance. Only now, with the activation of Krakoa’s resurrection protocols, has mutant society finally begun to recover from the damage she caused.",
                    "Just about everyone on Krakoa distrusts or outright hates Nova. She has been allowed to claim Krakoan citizenship and even join the Marauders, but no one likes having her around. She was eventually abandoned billions of years in the past on a mission with the Marauders."
                ],
                Personality =
                [
                    "Although Nova and Professor X operate along different moral lines, Nova speaks in a similar manner to her brother. She is eloquent, straightforward and even polite. It’s just that she hates everyone.",
                    "Xavier has dedicated his life to preserving mutantkind, while Nova has dedicated her life to annihilating it. That’s the key difference."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Chamber",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 2, vigilance: 4, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.ElementalBarrage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Mute, reminder: "Can speak psionically"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Jonothon “Jono” Evan Starsmore",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Chest and lower face composed of a mysterious psionic energy",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GenerationX, TeamNames.Legionnaires, TeamNames.Morlocks, TeamNames.NewMutants, TeamNames.NewWarriors, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Jonothon Starsmore’s X-Gene activated shortly after his eighteenth birthday. On that day, a fiery ball of pure psionic energy formed within his chest and grew until it had nowhere else to go but out. The resulting explosion annihilated most of Starsmore’s body and permanently disabled his girlfriend. He should’ve died that day, but the psionic energy refused to let him go. It became his new body, filling in the spaces it had destroyed.",
                    "Permanently disfigured and unable to face the guilt of having hurt his girlfriend, Starsmore left home. He accepted an invitation to Charles Xavier’s School for Gifted Youngsters and subsequently became a founding member of the super-hero team Generation X.",
                    "Generation X eventually disbanded as its members aged out of Xavier’s school, but Starsmore never stopped being an active super hero. Over the ensuing years, he has served as a member of the Morlocks, the New Warriors and even the X-Men themselves.",
                    "On Krakoa, Starsmore split his time between acting as a member of Nightcrawler’s Legionnaires group and helping his old Generation X teammate Jubilee raise her adopted son, Shogo.",
                ],
                Personality =
                [
                    "Chamber could be an exceptionally powerful hero, but the guilt he feels over his past keeps him from using his powers to their fullest extent. The explosive psionic energy within his chest fluctuates with his emotions, and outside of the battlefield, he tries to maintain a relatively calm and simple lifestyle. He has a big and loving heart, but for obvious reasons, romantic entanglements are difficult for him.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Chameleon",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 2, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in true form"),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Disguise),
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
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Dmitri Nikolayevich “Anatoly” Smerdyakov",
                Heights = [new() { IsUnknown = true }],
                Weights = [],
                UnknownWieght = true,
                Gender = Gender.Male,
                Eyes = "Varies, originally brown",
                Hair = "Varies, originally brown",
                Size = Size.Average,
                DistinguishingFeatures = "Pale, nearly featureless head with glowing yellow eyes (in true form)",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Anatoly Smerdyakov grew up in the Russian countryside alongside his half brother Sergei Kravinoff, the future Kraven the Hunter. The Kravinoff patriarch considered Smerdyakov’s existence an embarrassment, so as soon as he was able, he sent the young boy off to an underground school for spies.",
                    "Smerdyakov discovered that he had a knack for faking his appearance, so aft er graduation, he set out to become a world-renowned master of disguise. Using nothing more than simple cosmetics, he managed to sneak into a U.S. missile defense center and steal top government secrets—secrets that were saved only by the last-minute intervention of Spider-Man (Peter Parker).",
                    "Not one to let a defeat stand, Smerdyakov developed a serum that made his body smooth and malleable, allowing him to change his appearance at will. Equipped with the ability to become anyone at any time, he embarked on a series of increasingly complex and brutal operations to make the wall-crawler’s life as miserable as possible.",
                    "Spider-Man has, thus far, always managed to uncover the Chameleon’s treachery, but that may not hold true forever. The villain’s most recent plot involved a small army’s worth of body doubles and covert operatives, all of whom had to be rooted out before the Chameleon himself could be apprehended."
                ],
                Personality =
                [
                    "The Chameleon has gone through periods of mental instability during which he loses himself in his alternate identities, but his core self has always remained that of a cruel and conniving Victorian nobleman. When he’s between jobs, he likes to lie back, lounge in an antique chair, drink an expensive bottle of red wine and contemplate his next labyrinthine scheme.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Chasm",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 7, resilience: 3, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
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
                        powerSelector.GetPower(PowerNames.Integrity),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
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
            ],
            Biography = new Biography
            {
                RealName = "Benjamin “Ben” Reilly",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.BeyondCorporation, TeamNames.NewWarriors, TeamNames.SpiderArmy],
                Base = "New York City",
                History =
                [
                    "Of the Jackal’s many attempts to create a perfect clone of Spider- Man (Peter Parker), Reilly is indisputably the most like the original. He’s been a crimefi ghter for almost as long as the Web- Head himself, and unlike the Jackal’s other clones, he rarely suffers from cellular degeneration or genetic defects.",
                    "Shortly after his creation, Reilly escaped from the Jackal, assumed a new identity and fled to the far corners of the country. After spending years attempting to live a normal life in obscurity, he returned to New York City—and to the life of a super hero—after learning that Aunt May was suffering health problems.",
                    "Under the codename Scarlet Spider, Reilly helped Spider- Man protect New York from some of the deadliest threats in its history, including attacks by other clones. For a while, he and Parker believed Reilly to be the original, but they later learned they had been fooled.",
                    "Recently, after members of the Beyond Corporation erased most of his memories, Reilly adopted a darker attitude and a darker codename: Chasm. His girlfriend, Hallows’ Eve, has been helping him to slowly regain his senses, but it’s been a long and ongoing process."
                ],
                Personality =
                [
                    "As the Scarlet Spider, Reilly’s personality heavily resembled that of Peter Parker, albeit a tad darker. As Chasm, Reilly is a vicious and angry individual whose motives frequently border on the villainous. The infl uence of Hallows’ Eve has helped keep him sane, but it might not take much to push him into a murderous rage. He maintains a complex and frequently hostile relationship with his old partner Parker.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Children of Lost Tarnax",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 1, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
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
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                        powerSelector.GetPower(PowerNames.FlexibleBones1),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.SlipFree),
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
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.AlienSkrull],
                Teams = [TeamNames.ChildrenOfLostTarnax],
                Base = "Varies",
                History =
                [
                    "The aliens commonly known as Skrulls are actually the Deviant variant of their race, created by visiting Celestials in ancient times. Their amazing powers to assume any guise allowed them to drive both the original Skrulls and the Eternal variant Skrulls long extinct.",
                    "Over the past ten million years, the Skrull Empire has spread its influence throughout the galaxy— first as traders and then as invaders—conquering hundreds of planets, including the entire Andromeda Galaxy. After Galactus devoured their homeworld, they were scattered among the stars, but they recently allied with their ancient enemies—the Kree—under the leadership of Emperor Dorrek VIII, also known as the Earth hero Hulkling. These renegade Skrulls reject this half-breed emperor, calling themselves the Children of Lost Tarnax.",
                ],
                Personality =
                [
                    "The Children of Lost Tarnax are, perhaps surprisingly, even more xenophobic and jingoistic than their contemporaries in the Kree-Skrull Alliance. Few of them would hesitate to give their lives for the cause. While these particular Skrulls are not as powerful as their commanders, they have been raised to believe they are the greatest, most worthy race of people in the universe.",
                ]
            },
            Source = BookSource.RevengeOfTheSuperSkrull
        },
        new()
        {
            Name = "Chondu the Mystic",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 2, vigilance: 4, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Small, reminder: "when not using body"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.CrimsonBandsOfCyttorak),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMorpheus),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
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
            ],
            Biography = new Biography
            {
                RealName = "Harvey Schlemerman",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Bald",
                Size = Size.Small,
                SizeNotes = "usually",
                DistinguishingFeatures = "He’s a floating head in a jar",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.Headmen],
                Base = "New York City",
                History =
                [
                    "After discovering that he had a knack for the mystical arts, Harvey Schlemerman attempted to make a name for himself in entertainment as the magician Chondu. Despite the fact that he employed real magic, the viewing public largely deemed him a two-bit charlatan.",
                    "Determined to become famous at any cost, Schlemerman turned to a life of crime. He joined up with the Headmen, who attempted to infiltrate their enemies—the Defenders—by implanting Schlemerman’s mind into Nighthawk’s body. Thankfully, Schlemerman was quickly caught by the Defenders, and his mind was forced into the body of a passing deer.",
                    "When Schlemerman eventually made it back to the Headmen’s headquarters, he was horrified to discover that his teammate Gorilla-Man had cut his head from his body and grafted it onto a monstrous, chimera-like creature.",
                    "Despite this betrayal, Schlemerman stayed with the Headmen for a while, transferring his head from one hideous body to another as the situation required. Although he recently retired from super-villainy, Schlemerman could still be called back into the ranks of the Headmen—for the right price."
                ],
                Personality =
                [
                    "Chondu desires two things: money and respect. If he has both, he is a happy and quiet intellectual. When he has neither, he becomes murderously furious.",
                    "Like many practitioners of the mystic arts, Chondu has a huge ego. The quickest way to make him mad is to mock his skills as a sorcerer."
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Cloak’s Cloak"),
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Cloak’s Cloak",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.DarkforceAttack),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.DimensionalTravelOther, powerSelector.GetPower(PowerNames.DimensionalTravelOther)),
                    ],
                    Restrictions =
                    [
                        "Large",
                    ],
                    PowerValue = 1,
                }
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
                Base = "New York City",
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
                Base = "New York City",
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
            Name = "Contessa Valentina Allegra de Fontaine",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                    IsTech = true
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
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black, with white streak",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.HighTechAndroid, OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra, TeamNames.SHIELD, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "After her parents were killed in a senseless bombing, the Contessa Valentina Allegra de Fontaine joined S.H.I.E.L.D. and dedicated the rest of her life to preventing similar tragedies. Or at least, that was the cover story. In truth, both Fontaine and her supposed parents were agents of an ancient Russian spy cell called Leviathan, and she only joined S.H.I.E.L.D. to ensure that the organization never laid hands on any of Leviathan’s world-shattering technology.",
                    "Fontaine spent years with S.H.I.E.L.D. and became not only one of its best agents but also the on-and-off lover of its director, Nick Fury Sr. She was even named director herself during a brief period when Fury was thought to be dead. She developed a real affection for S.H.I.E.L.D., but when Hydra uncovered Leviathan technology, she felt that she had no choice but to defect and become the new Madame Hydra.",
                    "Fury refused to accept this, and with the help of his best agents, he defeated Hydra and dismantled Leviathan. Adrift for the first time in her life, Fontaine disappeared.",
                    "Recently, a Life-Model Decoy of Fontaine joined the new incarnation of the Thunderbolts led by the Revolution (Bucky Barnes). This is the version represented in this profile."
                ],
                Personality =
                [
                    "Fontaine is an expert spy and tactical manipulator, but deep beneath her conniving exterior lies a soul that really cares about people. That’s part of what makes her such a good actor. She has the mental fortitude to betray whoever she needs to betray, even when she doesn’t really want to.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Count Nefaria",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 5, vigilance: 8, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Adamantium"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BrainDrain, reminder: "limited to targets with Elemental Control [Energy] powers"),
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Luchino Nefaria",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Leader],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.LethalLegion, TeamNames.Maggia],
                Base = "Los Angeles",
                History =
                [
                    "As Europe’s wealthiest nobleman and the leader of the Maggia crime syndicate, Luchino Nefaria detests anyone he cannot control, especially those who dare to work against him. By continually interfering with the Maggia, the Avengers gradually became his most hated enemies.",
                    "Nefaria moved to America and attempted to turn the United States government against the Avengers, but his plans ultimately failed to disband the team. He decided to take a new approach and created his own Lethal Legion to fight the Avengers directly. The heroes initially defeated the Legion with little trouble, but unbeknownst to them, Nefaria had employed a former Nazi scientist named Kenneth Sturdy to analyze, magnify and re-create their powers. Sturdy used the data from the Avengers’ first fight with the Legion to make Nefaria into a super villain with powers rivaling those of all the Avengers combined.",
                    "Though the heroes narrowly managed to defeat the empowered Nefaria and his Lethal Legion, he has not given up on his plans to destroy them. His daughter, Madame Masque (Whitney Frost), has also proven a worthy foe to many of the Avengers.",
                ],
                Personality =
                [
                    "Although Nefaria is capable of going toe-to-toe with the likes of Thor, a fistfight is unbecoming of the count. He prefers to use less direct methods when possible. A ruthless, egomaniacal businessman and crime boss, Nefaria wants his legacy to be the destruction of the Avengers. His outward veneer of respectability and civility is a farce, a means to better enrich himself, and he believes that deep down, everyone is just like him.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Corvus Glaive",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 3, vigilance: 4, ego: 4, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Thanos’ army)"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Corvus Glaive’s Glaive", isTech: true),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                        powerSelector.GetPower(PowerNames.HitTheDirt),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                        powerSelector.GetPower(PowerNames.OperationsCenter),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Corvus Glaive’s Glaive",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Unkillable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach + 1, Melee Damage Multiplier bonus: +2."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 2,
                }
            ],
            Biography = new Biography
            {
                RealName = "Corvus Glaive",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [144],
                Gender = Gender.Male,
                Eyes = "Black (glow orange when using powers)",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Pale appearance with dark glowing eyes and pointed ears",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.BlackOrder],
                Base = "Mobile",
                History =
                [
                    "Corvus Glaive and his wife, Proxima Midnight, were among Thanos’ earliest followers, and to this day, they remain among his most beloved subjects. They were the first to join the Mad Titan’s coveted inner circle—his Black Order—and it is they who have kept the Order running, even in the Titan’s absence.",
                    "Little is known of Glaive’s early life or what happened to engender within him such fanatical devotion to one of the greatest monsters in the cosmos, but a fanatic he remains nonetheless. Not only has Glaive killed untold billions in the name of Thanos, he has—on multiple occasions—given his own life in pursuit of the Mad Titan’s goals.",
                    "In fact, Glaive is still recovering from his last death, having been annihilated by Thor for attempting to kidnap the Asgardian pantheon’s youngest member, Laussa Odinsdottir.",
                ],
                Personality =
                [
                    "Glaive is a ruthless and hyperintelligent schemer. Often considered to be the real brains behind the Mad Titan’s operations, Glaive has long been responsible for maintaining the logistical end of Thanos’ many conquests.",
                    "It is Glaive who collects the taxes necessary to keep the Mad Titan’s armies on their endless warpath, and it is he who draws up the plans for each battle along the way. He delights in these tasks and in the bloodshed that they offer."
                ]
            },
            Source = BookSource.AvengersExpansion
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Cosmic Surfoard"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
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
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Cosmic Surfoard",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Flight2, powerSelector.GetPower(PowerNames.Flight2)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Summonable),
                    ],
                    Restrictions =
                    [
                        "Driven",
                        "Flashy"
                    ],
                    PowerValue = 1,
                }
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
                    Name = $"{PowerSetNames.ElementalControl} Air/Earth/Fire/Ice/Water",
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
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
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
        new()
        {
            Name = "Cyclops (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 3, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
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
                        powerSelector.GetPower(PowerNames.RallyOnMe),
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
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "Scott Summers grew up in an orphanage. When he discovered his mutant ability–the power to emit blasts of energy from his eyes–he was taken in by Professor X and fitted with ruby-quartz glasses to control it. As Cyclops, he was part of Xavier’s first team of X-Men and remained their field leader throughout his tenure with the team. He fell in love with teammate Jean Grey, and the two eventually married. Their relationship was tested again and again by Jean’s mutual but unactedupon attraction to their teammate Wolverine; by the Phoenix, the cosmic force that granted Jean enormous power but corrupted her, leading her to die and be reborn; and by the twisted Mister Sinister, who wanted to experiment on them. During this period of turmoil, however, Scott learned that his long-thought-dead father had survived as the space-faring buccaneer Corsair. He also encountered the enigmatic Havok, leader of the government mutant task force X-Factor; their powers inexplicably canceled each other out. Eventually, he and Jean had a child, Nathan; however, much to his horror, he learned that Jean had been replaced by a Sinister-grown clone. Upon the real Jean’s return, the clone’s programming activated, and she turned Nathan over to Sinister, who infected him with a technoorganic virus. With modern science unable to cure the infant, Scott faced the agonizing decision of sending him to Bishop’s future timeline to be treated. Meanwhile, Cyclops was torn between the real Jean and the clone, who dubbed herself Madelyne Pryor, until the latter was killed by Sentinels. He also learned the mysterious mercenary Cable was really a grown-up Nathan.",
                ],
                Personality =
                [
                    "Cyclops is a stalwart believer in Xavier’s dream, and an accomplished leader. He is unfailingly courageous, and a tactical genius. He can sometimes be too unyielding in his beliefs.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Cypher",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 2, vigilance: 3, ego: 3, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    Name = PowerSetNames.Translation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DetectLie),
                        powerSelector.GetPower(PowerNames.Indecipherable),
                        powerSelector.GetPower(PowerNames.UnderstandBodyLanguage),
                        powerSelector.GetPower(PowerNames.UnderstandCode),
                        powerSelector.GetPower(PowerNames.UnderstandSignLanguage),
                        powerSelector.GetPower(PowerNames.UnderstandSpokenLanguage),
                        powerSelector.GetPower(PowerNames.UnderstandUnusualCommunication),
                        powerSelector.GetPower(PowerNames.UnderstandWrittenLanguage),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Douglas Aaron “Doug” Ramsey",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.QuietCouncilOfKrakoa],
                Base = "Krakoa",
                History =
                [
                    "Shadowcat (Kate Pryde) had long suspected that her childhood friend Doug Ramsey—with his uncanny knack for codes and languages—was some kind of mutant. However, for the sake of his safety, she rarely involved him in mutant business. Then the alien mutant Warlock crash-landed near Xavier’s School for Gifted Youngsters and fought the original New Mutants. To communicate with the rampaging Warlock, Pryde was forced to enlist Ramsey’s assistance.",
                    "Ramsey and Warlock became fast friends and decided, almost simultaneously, to become members of the New Mutants, with Ramsey taking the codename Cypher. As Cypher, Ramsey proved a capable member of the team, but his time with the New Mutants was cut short when he was killed in battle, taking a bullet meant for Wolfsbane.",
                    "Years later, the Black Priestess (Selene Gallio) resurrected Ramsey. He rejoined the New Mutants for a while, but his heart was no longer with the team. Eventually, he retreated to the edges of mutant society, only returning to the spotlight after being persuaded to assist in the foundation of Krakoa. Cypher served as the Quiet Council’s liaison with the island of Krakoa itself, until instability within the nation led the island to swallow him up, supposedly for his own protection.",
                ],
                Personality =
                [
                    "Cypher may not have flashy energy blasts, but he is more intelligent, more courageous and more empathic than more aggressive super heroes. His omni-linguistic abilities allow him to stop many fights before they even start.",
                    "Though he has dozens of friends, Cypher is particularly close with Warlock. At times, they have merged to form a single powerful being called Douglock."
                ]
            },
            Source = BookSource.XMenExpansion
        },
    ];
}
