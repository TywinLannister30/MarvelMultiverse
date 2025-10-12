using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersD
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
            Name = "Darwin",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 4, ego: 3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.QuickLearner),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.HitTheDirt),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.InstantEvolution)
            ],
            Biography = new Biography
            {
                RealName = "Armando Muñoz",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XFactor, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Unable to cope with their mutant son’s strange appearance, Armando Muñoz’s mother sent him off to boarding school, and his father left the family altogether. Muñoz was bullied relentlessly by his fellow students, and the adults in his life treated him little better. They endlessly studied his strange abilities and eventually began to publish papers on his powers.",
                    "These papers brought Muñoz to the attention of Moira MacTaggert, who invited him to the Xavier Institute, where he could learn to use his powers alongside other young mutants. Muñoz was among the ill-fated first group of mutants sent to retrieve the original X-Men from Krakoa. The mission was a disaster, with most of the untested team killed and the rest blasted into orbit. Muñoz only survived by merging himself with his teammate Vulcan.",
                    "It took years for Muñoz and Vulcan to return to Earth and separate. The experience drove Vulcan half insane, but Muñoz coped better. He rejoined the X-Men and later accepted a position with X-Factor Investigations.",
                    "Early in the Krakoan era, Muñoz and a handful of other X-Men were trapped inside a time bubble called the Vault. Muñoz seemingly died during this incident, and a replica of him was resurrected on Krakoa. However, a later investigation revealed that his mind had survived by merging with the Vault’s computers."
                ],
                Personality =
                [
                    "Darwin can adapt to handle just about anything, but that doesn’t mean he always enjoys every situation. He’s a soft-spoken guy who would generally prefer a simple night at home to an adventure across the cosmos.",
                    "In that way, merging with the Vault was good for him. As a digital construct, he has endless time to relax and experiment. His newer version lives on in his stead."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Dazzler",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 2, vigilance: 4, ego: 7, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption, reminder: "applies only to sonic damage"),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight1),
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
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimatedIllusion),
                        powerSelector.GetPower(PowerNames.Dazzle),
                        powerSelector.GetPower(PowerNames.Flare),
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.StaticIllusion),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Alison “Ali” Blaire",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [115],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Excalibur, TeamNames.SHIELD, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "During a performance at a high-school talent contest, Ali Blaire’s body began to emit dazzling lights. These lights helped Blaire not only wow her classmates but also drive off a group of rowdy bikers who attacked her school later that same night.",
                    "The incident left such an impact on Blaire that she rededicated herself to achieving her childhood dream of becoming a successful singer. She left home and got a regular gig performing at a club under the stage name of Dazzler.",
                    "Blaire’s fantastic, superhuman performances quickly drew the attention of mutant groups, both good and evil, who tried to recruit her into their ranks. Although she was initially uninterested in a life of adventure, her innate sense of justice and her impeccable knack for getting into tricky situations inevitably drew her into a life of super-heroics.",
                    "Over the years, Blaire has been a valued member of both the X-Men and S.H.I.E.L.D. She’s currently put most of her regular heroics aside to focus on her music, but she still finds the time to lend a helping hand now and again. Her son, Shatterstar, and her one-time husband, Longshot, are important mutant heroes in their own rights."
                ],
                Personality =
                [
                    "Frequently hailed as the world’s greatest mutant performer, Blaire’s presence on stage is positively electric. It would be easier to count the mutants on Earth who haven’t, in some way, been charmed by her.",
                    "However, like a lot of stars, her life offstage is often a wreck. She considers herself lucky if she can get through a night with friends without getting caught up in one adventure or another."
                ]
            },
            Source = BookSource.XMenExpansion
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
            Name = "Destiny",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 2, vigilance: 4, ego: 2, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"2 ({PowerNames.Precognition4})"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.VisionIssues),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SixthSense,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DangerSense),
                        powerSelector.GetPower(PowerNames.Intuition),
                        powerSelector.GetPower(PowerNames.Precognition4),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Irene Adler",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Gray-white irises due to blindness",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.QuietCouncilOfKrakoa],
                Base = "Krakoa",
                History =
                [
                    "Born into a noble family during the late Victorian era, Irene Adler enjoyed a quiet and privileged upbringing. Then, at the age of 13, her precognitive powers suddenly activated. She spent the next thirteen months in a delirious haze, transcribing the details of every possible future she could see. The effort eventually drove her blind.",
                    "Years later, Adler hired a detective named Raven Darkhölme (Mystique) to help make sense of her scribbled predictions. The pair hit it off and quickly became partners, first in the detective business and then, later on, in love.",
                    "They had a child, Nightcrawler (Kurt Wagner), who tragically disappeared shortly after his birth. Decades later, they adopted a young Rogue (Anna Marie LeBeau) as their surrogate daughter.",
                    "Determined to fight for the rights of mutantkind, Destiny, Mystique and Rogue helped found major incarnations of both the Brotherhood of Evil Mutants and Freedom Force. However, toward the end of Freedom Force’s tenure, Destiny died in battle.",
                    "Recently, and in spite of a secret ban on the resurrection of precogs on Krakoa, Mystique tricked the Five into reviving Destiny in a younger body. She and Mystique have spent most of the period since working closely together, making up for lost time."
                ],
                Personality =
                [
                    "Destiny’s ability to predict the future grants her the confidence to tackle just about any situation—confidence that is, more often than not, justified. She has a mind for planning ahead, which makes the greatest human tacticians in the world look like children playing checkers.",
                    "If she has a flaw, it is a penchant for being overly protective of her family. She wouldn’t hesitate to trade the lives of every last human on Earth if it increased the chances of Rogue and Mystique living a few extra years."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Destroyer",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 4, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Leverage),
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
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Destroyer’s Energy Baton", isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
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
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Destroyer’s Energy Baton",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Neganite),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplier bonus: +1"),
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                }
            ],
            Biography = new Biography
            {
                RealName = "Sharon Carter",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer, OccupationName.Spy],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.SHIELD, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "Inspired by her aunt Peggy’s old war stories, Sharon Carter signed up to protect the world with S.H.I.E.L.D. Not long after that, she began working alongside Peggy’s old comrade in arms and romantic partner, Captain America (Steve Rogers).",
                    "In time, Carter and Rogers began a romance of their own, though because of their duties, the relationship played out in fits and spurts, when it played out at all. At times, life and circumstance have even conspired to push them into direct conflict—like after the first superhuman civil war, when Carter was brainwashed into killing Rogers, or during the reign of the Secret Empire, when Rogers seemingly became an agent of Hydra. But somehow, they have always managed to repair their relationship and pick up where they left off.",
                    "Carter is one of the few S.H.I.E.L.D. operatives who can attest to having saved as many people as Steve Rogers himself, and for a brief period before it dissolved, she was even the head of the organization.",
                    "After her old friend the Destroyer (Roger Aubrey) was killed in battle, Carter decided to honor him by taking up his codename. As the new Destroyer, she currently spends most of her time fighting villainy around the globe with the Thunderbolts."
                ],
                Personality =
                [
                    "Much like Rogers, Sharon Carter is a coolheaded and determined operative. She has high ideals, and she isn’t afraid to fight for them. In fact, she suspects that she’s fated to do just that for the rest of her life.",
                ]
            },
            Source = BookSource.AvengersExpansion
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
            Name = "Doctor Octopus",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 3, vigilance: 3, ego: 0, logic: 6
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Ocktoid Tentacles [These semiautonomous drones have a psychic link with Octavius. He can see through them and pilot them by remote. While under remote control, they use Octavius’ stats and take his place in the initiative order. If Octavius is rendered unconscious, the tentacles automatically stop fighting and attempt to transport him to safety.]", isTech: true),
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
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
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
                RealName = "Otto Octavius",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [245],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Four biomechanical Ocktoid tentacles",
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
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Doctor Octopus (Earth-90214)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 1, resilience: 1, vigilance: 1, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
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
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Otto Octavius",
                Heights = [new() { Feet = 3, Inches = 10 }],
                Weights = [89],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Four mechanical arms",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.FriendsOfNewGermany],
                Base = "Ellis Island, New York City (Earth-90214)",
                History =
                [
                    "Though he was born without the use of his legs, the Noir Universe’s Otto Octavius never struggled a day in his life. He grew up in South Africa in the era before apartheid, in a household where enslaved native people were forced to wait on him hand and foot.",
                    "Unwilling to acknowledge his family’s exploitation of the native people, Octavius instead became obsessed with proving that his servants were worthless lesser beings that he could “improve” with science.",
                    "With the backing of the Nazi-associated Friends of New Germany, he moved to New York City and began carrying out a series of brutal experiments on members of the city’s Black population, using his mechanical arms to administer gruesome, forced lobotomies.",
                    "Spider-Man uncovered the scheme while investigating the head of the Friends of New Germany’s organized crime unit: the Crime Master. Realizing that he had been caught, Octavius attempted to get on Spider-Man’s good side by murdering the Crime Master, but the wall-crawler apprehended him nonetheless.",
                    "Octavius leveraged the last of his resources to escape to Germany, but to his surprise, the Nazi government wasn’t willing to hire a disabled man. Undeterred, Octavius eventually reappeared in New York, determined to brainwash the city’s people against Spider-Man, only for the Web-Head to thwart him once again. He was last seen going down in a flaming zeppelin as he tried to flee the United States."
                ],
                Personality =
                [
                    "Octavius is a Nazi and a fascist through and through, but of late, his ideological goals have taken a back seat to his vendetta against Spider-Man. The wall-crawler embarrassed him, and that is the one thing that Octavius absolutely cannot stand.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
            Name = "Domino",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 6, resilience: 3, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Leverage),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Luck,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CharmedLife),
                        powerSelector.GetPower(PowerNames.EvilEye),
                        powerSelector.GetPower(PowerNames.JinxYou),
                        powerSelector.GetPower(PowerNames.JinxYouAll),
                        powerSelector.GetPower(PowerNames.LuckyMe),
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
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Neena Thurman",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black with white streak",
                Size = Size.Average,
                DistinguishingFeatures = "Unnaturally pale skin with a black “domino” tattoo over left eye",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "Tossed out of a twisted Super-Soldier program for being insufficiently powerful, Neena Thurman grew up in a stifling church orphanage without any knowledge of her background or her mutant status. A delinquent at heart, she ran away in her teenage years to make a name for herself as a mercenary.",
                    "She spent some time working for the National Security Agency, where her uncanny ability to tip the odds in her team’s favor earned her the codename Domino. After bouncing between a few other organizations, she found true companionship for the first time as a part of the Wild Pack, a mutant mercenary group run by Cable. Domino and Cable struck up a brief romance, and though it ended poorly, she eventually agreed to join Cable in his next venture, X-Force.",
                    "Since then, Domino has consistently been a key member of X-Force. Although she has occasionally left the team to engage in independent mercenary work, she always finds a way back. Of the original X-Force lineup, Domino was the only one still on the team in the Krakoan era. Few mutants can credibly claim to have seen as much field combat as her.",
                ],
                Personality =
                [
                    "Above all else, Domino is a thrill seeker, and her mutant luck means that she can comfortably seek thrills that would certainly kill anyone else. Her comfort zone lies somewhere between dodging bullets and jumping from an airplane without a parachute.",
                    "Despite the insanity of her life, Domino is not a jaded and hardened mercenary like Cable. She’s lively, sociable and an ideal party guest."
                ]
            },
            Source = BookSource.XMenExpansion
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
            Name = "Doppelganger",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 4, vigilance: 2, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Mute, reminder: "speaks in growls"),
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
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Razorwebs),
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
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Monster resembling Spider-Man, sharp teeth and six arms with three fingers each",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.CultOfKnull, TeamNames.SpiderArmy],
                Base = "Mobile",
                History =
                [
                    "The Doppelganger was one of a number of monstrous duplicates created by Magus to weaken Earth’s super heroes in advance of his invasion of the planet during the first Infinity War. Although these doubles were killed during the initial stages of the invasion, the duplicate of Spider-Man was resurrected by the web-slinger’s demonic rival, the Demogoblin.",
                    "Spider-Man again made quick work of the vicious Doppelganger, and Demogoblin was disappointed enough in the creature’s performance to let it go free. The monster next appeared in the care of Carnage, and although they were temporarily separated several times in the subsequent years, the Doppelganger has remained in the murderous symbiote’s orbit ever since. It escaped from an illicit Alchemax laboratory but was last seen in custody in Ravencroft.",
                ],
                Personality =
                [
                    "It’s hard to say if the Doppelganger has much of a personality. Its mind is barely more advanced than that of a vicious dog. It can hardly think, let alone speak. It operates entirely on instinct, killing anything it perceives as a threat. Like a dog, it can, to a certain extent, be trained—a fact that many villains have taken advantage of to turn the creature into an instrument of mass slaughter.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
        new()
        {
            Name = "Ducktor Doom",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 4, vigilance: 3, ego: 7, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.SlipFree),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 3, Inches = 9 }],
                Weights = [76],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Unknown, likely none",
                Size = Size.Small,
                DistinguishingFeatures = "Anthropomorphic duck clad in iron suit and mask",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.SwinesterSix],
                Base = "Doom Island (Earth-8311)",
                History =
                [
                    "As the monarch of the isolated nation of Quackveria, Ducktor Doom began his super-villain career by terrorizing the heroic team known as the Fantastic Fur. However, after dozens of attacks, the heroes got so sick of Doom’s antics that they strapped him to an antigravity pod and shot him into the stratosphere.",
                    "Doom drifted around the Earth for a while before eventually touching down on an island near Australia. Taking a liking to the environment, he used his advanced weaponry to conquer the native Kangaroo people and turn the patch of land into his new base: Doom Island.",
                    "Hoping to make money by exploiting the Kangaroos’ love for music, Doom built a giant magnet to drag planes out of the sky, kidnapping hundreds of potential musicians. One of these planes happened to contain an investigative team from the Daily Beagle led by Spider-Ham (Peter Porker), who used his incredible Spider-Powers to put a permanent end to Doom’s music career.",
                    "Ever since that day, Doom has been bent on getting revenge on the Ham-Head. He’s tried attacking the hero with giant vegetable mutants. He’s tried imprisoning the pig in a trap-fi lled castle. He’s even tried working with a team of villains: the Swinester Six. None of his attempts have succeeded thus far, but the iron duck is never one to let a grudge lie—or a hero thrive."
                ],
                Personality =
                [
                    "Like his Earth-616 counterpart, Ducktor Doom is a megalomaniacal narcissist with dreams of conquering the world. However, the Ducktor is not quite as smart as his core-reality counterpart. His harebrained schemes are easily foiled by the likes of Mooster Fantastic, though he can still pose a considerable challenge to heroes like Spider-Ham.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Dust",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 2, vigilance: 3, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Water"),
                traitSelector.GetTrait(TraitNames.Leverage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.XGene),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BodySphere),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.SlipFree),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Sooraya Qadir",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [136],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Champions, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "When she was just a teenager, Sooraya Qadir was taken from her home in Afghanistan and sold to a group of mercenary slavers. Thankfully, she would not have to suffer in their clutches for long.",
                    "One night, before bed, Qadir made a wish upon a star. She prayed to be turned into a cloud so that she might float away from her life in captivity. She awoke to find that her wish had been granted and that the winds had already carried her halfway to the Afghan/Pakistani border. The mutant hero Wolverine (Logan) spotted Qadir trying to cross the border and, correctly deducing that she was a mutant, offered to take her to Charles Xavier’s School for Gifted Youngsters in America. Qadir took the deal and spent the next few years studying at Xavier’s facility, making friends and learning how to utilize her powers.",
                    "After graduation, Qadir joined up with the teen super-hero group known as the Champions. These days, she splits her time between acting as a backup member of the Champions and helping out her old friends on Krakoa.",
                ],
                Personality =
                [
                    "Qadir is a focused combatant and a capable commander, both on and off the field of battle. She speaks clearly and loudly, drawing her teammates toward the positions where they would be the most useful. She isn’t the type to goof off or joke around.",
                    "In accordance with Islamic tradition, Qadir wears an abaya dress with a niqab veil at almost all times. However, she observes this tradition less out of a sense of religious devotion and more out of a sense of fashion. She thinks the dress makes her look humble and distinguished."
                ]
            },
            Source = BookSource.XMenExpansion
        },
    ];
}
