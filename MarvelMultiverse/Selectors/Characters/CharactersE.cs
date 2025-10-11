using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersE
{
    public static List<Character> GetAllCharacters(
        INarrativePowerSelector narrativePowerSelector,
        IPowerSelector powerSelector,
        ITagSelector tagSelector,
        ITraitSelector traitSelector) =>
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
            Name = "Electro",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 2, vigilance: 4, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.ElementalBarrage),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Supernova),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Maxwell “Max” Dillon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Auburn, shaved bald",
                Size = Size.Average,
                DistinguishingFeatures = "Skin shifts from peach to gold to pitch black depending on power usage",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.EmissariesOfEvil, TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Max Dillon grew up in a poor household without many prospects, and when he graduated from high school, the only decent-paying job he could get was working as a line technician for an electrical company. One day on the job, Dillon was simultaneously shocked by an electrical line and hit by a bolt of lightning. The currents should have killed him, but instead, they gave him the power to control electricity.",
                    "Figuring that he could use his new powers to make a quick buck, Dillon made a costume and started robbing houses under the codename Electro. Spider-Man (Peter Parker) put an end to his crime spree, and the villain has hated the wall-crawler ever since.",
                    "Electro has tried and failed countless times to get even with Spider-Man. He joined the Sinister Six in its earliest days. When that didn’t produce results, he started his own team. Then another. Then another.",
                    "Despite having literally burned himself out pursuing the wall-crawler, Electro has never managed to get over his obsession with Spider- Man. He has no other real relationships in his life—no driving purpose other than to get rich and to get revenge."
                ],
                Personality =
                [
                    "Although Electro started out as little more than a common thief, years and years of defeats have slowly morphed him into something more dangerous and sadistic. He still covets cash, and for the right price, he can be reasoned with, but the opportunity to torture Spider-People is worth more to him than all the money in the world.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Elixir",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 5, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Resurrect),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SecondaryMutation),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.NeverSurrender),
                        powerSelector.GetPower(PowerNames.Resurrect),
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
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SixthSense,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MicroscopicAwareness),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Joshua “Josh” Foley",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [157],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Skin shifts from peach to gold to pitch black depending on power usage",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.TheFive, TeamNames.NewMutants, TeamNames.Reavers],
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
                Base = "New York City",
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
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.Worshipped),
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
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
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
        new()
        {
            Name = "Escapade",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Skeptical),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SwapPowers),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SwapItems),
                        powerSelector.GetPower(PowerNames.SwapPlaces),
                        powerSelector.GetPower(PowerNames.SwapStatus),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Shela Sexton",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [175],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red, with dyed blue tips",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech, OriginName.Mutant],
                Teams = [TeamNames.NewMutants],
                Base = "Krakoa",
                History =
                [
                    "Shela Sexton discovered her powers, as most mutants do, in her teenage years. With concentrated effort, she could instantly swap positions, clothes, abilities and even appearances with other people. For a few hours a day, she could become anyone, even her high-school principal, with nobody else the wiser.",
                    "Sexton eventually revealed her mutant status to her parents, a status they readily accepted. They were much less accepting of her status as a transgender woman.",
                    "Sexton’s parents kicked her to the curb, forcing her to move in with her longtime best friend, Morgan Red. Then, with the help of some of Morgan’s high-tech gadgets, she set out to become a hero of the people, using her powers to target the rich and powerful.",
                    "After the founding of Krakoa, Sexton reluctantly agreed to move to the island and become part of the New Mutants. She’s made friends among the team, but as an avowed anti-nationalist, she remains skeptical of the whole Krakoa project. She’s done her best to direct the New Mutants toward her mission of taking down the world’s oligarchs."
                ],
                Personality =
                [
                    "Sexton is typically a funny and upbeat person, with a healthy suspicion of authority. Few things can really shake her, but the ones that do shake her hard. It’s extremely difficult for her to confront situations where she feels her loved ones, particularly Morgan Red, may be in danger.",
                    "The move to Krakoa has put new strains on Sexton and Red’s friendship, but they still remain the most important people in each other’s lives. Red accompanies the New Mutants on many of their adventures."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Executioner",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 7, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Battle-ax (acts as a sword)"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Mighty4),
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
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Skurge",
                Heights = [new() { Feet = 7, Inches = 2 }],
                Weights = [1100],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black, usually shaved",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.AsgardiansOfTheGalaxy, TeamNames.MastersOfEvil, TeamNames.Roxxon],
                Base = "Asgard",
                History =
                [
                    "A fierce but lonely Asgardian warrior, Skurge the Executioner proved all too easy for the Enchantress to manipulate. Without her casting so much as a simple charm, he vowed to obey her every word. He assisted her in countless schemes to ensnare Thor Odinson, even while knowing that the Thunder God was the one she truly loved. He followed her into becoming part of the Masters of Evil and, from there, into dozens of disastrous fights with the Avengers. He followed her into exile, into war and even to the brink of death.",
                    "After years of such abuse, Skurge gradually began to take sojourns from the Enchantress. He never stopped loving her—even now, he would do anything for her—but he did start going on adventures of his own.",
                    "On one of those adventures, he sacrificed himself to save Thor from the assembled forces of Hel and to preserve the safety of Asgard. Then, after escaping Valhalla, he once again gave his life for the greater good, protecting Earth during the War of the Realms.",
                    "Though Skurge has since returned to the Enchantress’ nefarious service, the people of Asgard, particularly Thor, still respect him as a warrior and a man."
                ],
                Personality =
                [
                    "Deep down, Skurge is a soft-spoken and noble warrior. Under normal circumstances, he would never attack an unarmed opponent or harm another Asgardian—at least not without serious provocation. However, he’s willing to put his principles aside to prove his undying love for the Enchantress. He knows that she may never truly love him, yet he believes that to defy her would be to deny his own heart.",
                ]
            },
            Source = BookSource.QuickStartWithThunderboltsAdventure
        },
        new()
        {
            Name = "Exodus",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 4, ego: 6, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Gullible),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BrainDrain),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Faith"),
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
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Bennet du Paris",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "No pupils, unnaturally bright red skin",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Acolytes, TeamNames.BrotherhoodOfEvilMutants, TeamNames.QuietCouncilOfKrakoa],
                Base = "Krakoa",
                History =
                [
                    "Knight Templar Bennet du Paris and his best friend, Eobar Garrington, entered the Sahara Desert on a quest to find the mythical Egyptian Tower of Power. They eventually found the tower, only to be taken captive by its sole inhabitant: Apocalypse.",
                    "Apocalypse unlocked du Paris’ latent mutant powers, transforming him into Exodus. He then promised Exodus further power—beyond his wildest dreams—but first, he had to prove his loyalty by killing his friend, Garrington.",
                    "Exodus refused, and as punishment, Apocalypse entombed him within the Tower of Power. He spent the next one thousand years there in a state of living death, until Magneto happened upon Exodus and freed him.",
                    "Out of gratitude, Exodus joined Magneto’s then-current terrorist group: the Acolytes. Exodus and the Acolytes worshiped Magneto as a living messiah until he was eventually defeated.",
                    "Exodus spent the next several years wandering from group to group, sometimes acting as a hero, sometimes as a villain, always on the lookout for a new purpose. The founding of Krakoa gave him everything he ever dreamed of.",
                    "As a member of the Quiet Council, Exodus became Krakoa’s biggest advocate. He believes the island is paradise on Earth and that Hope Summers, the leader of the Five, is the mutant messiah he was always waiting for."
                ],
                Personality =
                [
                    "Although Exodus has spent most of his time as a villain, he does not have a vicious nature. He is an extremely pious individual, one who sees violence as a regrettable means toward righteous ends, not an end in itself. Ideologically, he has more in common with Magneto than Mister Sinister.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
    ];
}
