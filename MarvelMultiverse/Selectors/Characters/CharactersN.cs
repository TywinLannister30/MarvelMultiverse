using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersN
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
            Name = "Nemesis (Heather Hudson)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 3, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Flight1, isMagicItem: true),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Scell"),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Scell",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Blink, powerSelector.GetPower(PowerNames.Blink)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.LeechLife, powerSelector.GetPower(PowerNames.LeechLife)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty2, powerSelector.GetPower(PowerNames.Mighty2)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Sacrifice),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy2, powerSelector.GetPower(PowerNames.Sturdy2)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Teleport2, powerSelector.GetPower(PowerNames.Teleport2)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.TeleportTogether, powerSelector.GetPower(PowerNames.TeleportTogether)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee/Agility Damage Multiplier Bonus: +2."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 9,
                    MeleeDamageModifier = 2,
                    AgilityDamageModifier = 2,
                    IsMagicItem = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Heather McNeil Hudson",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.AlphaFlight],
                Base = "Mobile",
                History =
                [
                    "As a smart young woman from a poor family, Heather McNeil quickly earned herself a job as a secretary for a top executive at the Am-Can Petroleum Corporation. She enjoyed the job, but when she found out that her bosses were planning to steal their best engineer’s exosuit research and sell it to the military, she resigned in protest. She and the engineer, James Hudson, fled into the custody of the Canadian government.",
                    "The government offered James and Heather complete protection on the condition that they use their exosuit technology to help form a Canadian super-squad. The pair agreed and began to draw up plans for what would become Alpha Flight. At the same time, they became romantically involved, and they married and had a daughter, Claire.",
                    "In the beginning, Heather often acted as a support member of Alpha Flight, staying out of the field to provide intel and advice for the other members, but whenever James was unable to lead the team himself, she donned his exosuit and served in his place as the costumed hero Vindicator.",
                    "Recently, Heather took on a new codename, Nemesis, and secretly joined some of her mutant teammates in an illegal scheme to help mutant refugees from Krakoa escape to safety. When the scheme collapsed, she and the rest of Alpha Flight were taken into federal custody.",
                ],
                Personality =
                [
                    "Heather Hudson is the heart of Alpha Flight. She is the shoulder other members lean on in times of strife, and she is the empathetic voice they turn to for advice in times of peace. Unlike her husband, she feels no strong loyalties to the Canadian government.",
                ]
            },
            Source = BookSource.XMenExpansion
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Night Nurse’s Gauntlet"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Integrity),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Night Nurse’s Gauntlet",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)", powerSelector.GetPower(PowerNames.ElementalBurst, reminder : "Energy")),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Summonable),
                    ],
                    Restrictions =
                    [
                        "Carried",
                    ],
                    PowerValue = 1,
                }
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
            Name = "Nightcrawler (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 2, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FreeRunning),
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
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, German, Japanese, Russian, Spanish"),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
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
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.LegSweep),
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
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.BlinkBarrage),
                        powerSelector.GetPower(PowerNames.BlinkDefense),
                        powerSelector.GetPower(PowerNames.Teleport1),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportTogether),
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
                Base = "X-Mansion",
                History =
                [
                    "Abandoned by his shape-shifter mother Mystique at birth, the mutant later known as Nightcrawler was adopted and raised in the Wagner Circus, where he was given the name Kurt Wagner and became its star attraction. Despite his onstage fame, Nightcrawler was an outcast off stage due to his appearance, and his anger drove him to leave the Circus and fi nd peace in religion. His devotion led him to the Swiss Alps, where he joined a monastery that judged him on the strength of his character rather than his appearance. After being attacked by townspeople who assumed he was a demon, Nightcrawler drew the attention of vacationing X-Men Rogue, Gambit and Wolverine, allying with them to uncover the true culprit behind the attacking mob: the monastery’s own Brother Reinhart. When Mystique was later willingly used to lure the unknowing Nightcrawler into a trap set by his anti-mutant half brother Graydon Creed, Nightcrawler sought the X-Men’s assistance. Learning that Mystique was his mother and Rogue his adopted sister, Nightcrawler ultimately forgave Mystique for his earlier abandonment. When the island of Genosha was later restructured as a mutant haven, Nightcrawler joined the Genoshan council as part of their outreach to mutant communities of faith and he was present during a massive Sentinel attack, risking his life to help rescue innocent mutants. After Gambit died in the attack, Nightcrawler delivered the eulogy at his funeral and subsequently joined the X-Men, helping the grieving Rogue and aiding them against the living Sentinel Bastion’s cyborg Prime Sentinels.",
                ],
                Personality =
                [
                    "A devoted man of faith, Nightcrawler always looks at life from the perspective of love and caring. Friendly and easily approachable, Nightcrawler is fi ercely loyal to his friends and family, genuinely caring about their well-being and often playing the role of listener, dispensing advice gained from his unique life experiences.",
                ]
            },
            Source = BookSource.XMen97Characters
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
                Base = "New York City",
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
            Name = "Nimrod",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 5, vigilance: 6, ego: 7, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Sentinel Army)"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny3),
                    ],
                    IsTech = true
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
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CloneMoves),
                        powerSelector.GetPower(PowerNames.ClonePowers),
                        powerSelector.GetPower(PowerNames.CopyAbility),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.CopyTrait),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Nimrod",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "typically around 9'10\"",
                Weights = [550],
                Gender = Gender.Male,
                Eyes = "Pink",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Large, purple and white robotic android",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.SentinelArmy],
                Base = "Mobile",
                History =
                [
                    "In the dystopian future of Earth-811, mechanical life-forms known as Sentinels have all but wiped out mutantkind. Among the most advanced of this world’s mechanical life-forms are the Nimrods, sentient Sentinels designed to act as autonomous battlefield commanders.",
                    "When the hero Rachel Summers (Askani) escaped from Earth-811 to the relative safety of Earth-616, a Nimrod unit followed. The X-Men of Earth-616 managed to eke out a small victory over this lone Nimrod, but he was far from the last of his kind to plague them.",
                    "As the X-Men of Earth-616 explored more and more timelines, they encountered a great number of alternate Nimrods. In fact, Nimrod seems to be present in some form in almost every timeline in which mutants are oppressed.",
                    "This phenomenon has led many mutant scientists to conclude that Nimrod represents the flip side of the mutant coin: the cold, technological path toward machine supremacy that humanity is forced to walk down if it cannot embrace life alongside mutants.",
                    "As long as bigotry and technology continue to march forward, Nimrod is inevitable.",
                    "Some of Nimrod’s variants are relatively weak—barely stronger than your average MK II Sentinel—while others are unstoppable monstrosities on the level of Rank X. This profile represents the most basic and common Nimrod units, like the one first encountered by Earth-616’s X-Men."
                ],
                Personality =
                [
                    "Nimrod units are, by and large, intelligent, polite and ruthlessly self-interested. They seek to improve the universe by replacing all organic life with beautiful, efficient machine life. The Nimrods don’t hate organic life so much as they look down on it. They consider both humans and mutants to be sad and pathetic creatures for whom death is a mercy.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Nocturne (Earth-2182)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 5, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Possession),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Chaotic),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicChaosMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HexBolt),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Possession),
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
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.LegSweep),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Talia Josephine “T.J.” Wagner",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Yellow",
                Hair = "Blue",
                Size = Size.Big,
                DistinguishingFeatures = "Blue fur, skin and hair; pointed ears; tail; three digits on feet and hands",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Exiles, TeamNames.Excalibur, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "In Nocturne’s universe, older versions of Wolverine (Logan) and Nightcrawler led a fledgling X-Men unit out of the old Xavier mansion. Although she was just one of a number of next-generation heroes on this team, as Nightcrawler’s daughter, she was subject to additional pressures and expectations, and she frequently ran away from home. Then, one day, she ran too far away to ever return.",
                    "Freak temporal fluctuations forced her out of her home universe and into the Panoptichron, a crystal citadel existing outside time and space. The inhabitants of this citadel—the Timebreakers—forced Nocturne and several other temporal refugees to travel the Multiverse, fixing universes the Timebreakers had accidentally ruined.",
                    "As the Exiles, Nocturne and her compatriots repaired the errant timelines of dozens of worlds. Eventually, the Timebreakers released Nocturne from their service and allowed her to make a new life for herself on Earth-616. Although she spent a bit of time adventuring with the X-Men and later Excalibur, she gradually gravitated back toward her friends in the Exiles.",
                    "Recently, Nocturne left the Exiles to become the Scheherazade of a world inspired by One Thousand and One Nights . However, she remains in touch with her teammates.",
                ],
                Personality =
                [
                    "Nocturne is one of the most hardened and experienced members of the Exiles. In fact, with the exception of her best friend, Blink, she is the only member of the original Exiles to survive to the modern day. In spite of her expertise, Nocturne has never taken on a leadership position within the team. She’s a happy-go-lucky person who values her freedom too much to consider ordering others around.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Norman Osborn (Earth-90214)",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 1, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "hidden behind thin mask"),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Norman Osborn",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Brown (under mask, right eye is deformed, yellow)",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Green scaly skin, usually hidden",
                Occupations = [OccupationName.Criminal, OccupationName.Tycoon],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.GoblinGang],
                Base = "New York City (Earth-90214)",
                History =
                [
                    "Born with a rare skin condition and forced into the role of circus freak, Norman Osborn vowed that one day he would be the most powerful man in the New York City of the Noir universe. Hiding his deformity behind a sophisticated mask, he spent the next several decades rising to the top of the city’s underworld, where his complete ruthlessness and his willingness to prey on others earned him the nickname the Goblin.",
                    "During his rise, Osborn had a number of labor organizers brutally killed, including one Ben Parker. Years later, Ben’s nephew Peter became Spider-Man and dedicated his life to Osborn’s downfall.",
                    "Eventually, Spider-Man dredged up enough evidence of Osborn’s wrongdoing to put the man away for good. He raided the villain’s compound and, in the process, accidentally knocked Osborn’s lieutenant Sergei Kravinoff into a pit of spiders. He was just about to have his revenge on Osborn when Kravinoff escaped from the pit and—in a fit of madness—dragged Osborn into a nearby river, presumably killing them both.",
                ],
                Personality =
                [
                    "Norman Osborn is a crime boss in the style of Prohibition-era gangsters like Al Capone and Meyer Lansky. He has enough money and infl uence to maintain a thin facade of respectability in the papers, but everyone in New York knows that he’s a killer and a tyrant.",
                    "His only genuine soft spot is his love for carnies. Most of his top men began their careers in the circus.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Northstar",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 3, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Famous),
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
                RealName = "Jean-Paul Beaubier",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Unusually pointy ears",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.AlphaFlight, TeamNames.XFactor],
                Base = "Krakoa",
                History =
                [
                    "Jean-Paul Beaubier and his sister, Jeanne-Marie, were just infants when their parents died in a car accident. In the chaos of the aftermath, the twins were sent to different orphanages. Jean-Paul grew up bouncing around the foster system, while Jeanne-Marie spent her childhood in a Catholic boarding school.",
                    "The twins had no knowledge of each other’s existence until they were well into their adult years after being recruited into Canada’s Department H. The moment they grasped hands, their mutant powers activated, and a powerful and blinding light emerged from their bodies, blasting them backward.",
                    "The twins decided to use their powers for the betterment of humanity. They joined the Canadian super-team Alpha Flight and spent most of the next decade adventuring together, making up for lost time.",
                    "The twins didn’t start living separate lives again until the founding of Krakoa drew them away from their Alpha Flight colleagues. These days, Jean-Paul runs Krakoa’s X-Factor Investigations team, while Jeanne-Marie acts as a member of the secretive Marauders."
                ],
                Personality =
                [
                    "In his youth, Jean-Paul won fame around the world as an Olympic-level skier. The sports media of the time portrayed him as the platonic ideal of a playboy: rich, handsome and a little stuck-up. While these accusations were not entirely false, they failed to paint a complete picture.",
                    "Jean-Paul can certainly be blustery when he wants to be, but he can also be kind, sensitive and even insecure. As a gay man, he spent many years struggling with his sexuality before finally coming out.",
                    "Jean-Paul cares deeply for his sister and for all of his teammates."
                ]
            },
            Source = BookSource.XMenExpansion
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
}
