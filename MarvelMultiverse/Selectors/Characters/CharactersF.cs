using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersF
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
            Name = "Falcon (Joaquin Torres)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain America (Sam Wilson)"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection, isTech: true),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Redwing"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Joaquin Torres",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [160],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Human/falcon hybrid with wings and talons",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Champions],
                Base = "Mobile",
                History =
                [
                    "As an immigrant, Joaquin Torres considered it his duty to make the deadly passage across the U.S. southern border desert easier for those who came after him. He stuck his neck out to deliver food and water to people in desperate need, and in exchange for his troubles, both he and the people he was trying to help were kidnapped by the Sons of the Serpent and turned into human-animal hybrids.",
                    "Torres’ DNA was spliced with that of Redwing, the pet falcon of Captain America (Sam Wilson). Wilson himself later liberated the Serpent compound, and in time, all the subjects of the experiments reverted to their original forms—except for Torres.",
                    "Wilson took Torres on as his apprentice, and Torres in turn adopted Wilson’s old codename, the Falcon. Together, the pair discovered that Redwing had been carrying a weakened form of the virus that causes vampirism, and that the virus was preventing Torres from returning to normal.",
                    "Driven by a desire to help others, Torres kept on as Wilson’s apprentice and even joined the Champions in their fight against the Secret Empire. Later, while preventing a terrorist attack, Torres was dosed with poison that activated the weakened form of the vampirism virus he’d inherited. This made him more powerful and volatile until he reluctantly accepted treatment from Wakandan scientists. With his mutations under control, Falcon is now Wilson’s permanent partner."
                ],
                Personality =
                [
                    "Despite the darkness that he’s faced with every day, Falcon always manages to stay positive. In fact, he’s overjoyed to have been given a chance to push back against the evil he sees in the world. He and Wilson have similarly dry senses of humor, and their rapport as partners is unmatched.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Falcon (Sam Wilson)",
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
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.FocusedStrike),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                    "Wilson gradually developed a prowess in battle to rival Rogers’ own. At times when Rogers has been unwilling or unable to take up the mantle of Captain America, Wilson has taken his place. Nowadays, both Wilson and Rogers go by the codename of Captain America.",
                    "This profile represents Wilson before he donned the Stars and Stripes, back when he was known as the Falcon."
                ],
                Personality =
                [
                    "Even more so than Rogers, Wilson’s defi ning trait is his love for the downtrodden. His one goal in life is to use his powers for the protection of the weak and the oppressed.",
                    "Although Wilson is generally a serious man, he has a soft spot for those closest to him, particularly his avian companion Redwing."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Fang (Akihiro)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 4, vigilance: 3, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bone claws (act as knives)"),
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
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Akihiro",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [167],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable bone claws",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.AlphaFlight, TeamNames.Marauders, TeamNames.XFactor],
                Base = "Mobile",
                History =
                [
                    "After World War II, Wolverine (Logan) moved to a small village in the Japanese countryside, where he met and married a local villager named Itsu. She was on the verge of giving birth to their child when the mutant warlord Romulus ordered her assassination, which was carried out by the then-brainwashed Winter Soldier.",
                    "Unaware that his child had survived, Wolverine left Japan, and the infant was taken in by a local couple who named him Akihiro. The couple was rich but cold, and they treated his burgeoning powers with disdain. The local kids treated him no better, bullying him with calls of “Daken,” the Japanese word for mongrel.",
                    "In a fit of teenage rage, Akihiro killed his adoptive mother. He took on the codename Daken and fled into the custody of Romulus to begin training as an assassin. Unaware that his mentor had ordered his mother’s murder, Akihiro spent years working as a hit man for Romulus. These missions eventually brought him into contact with Wolverine, who showed his long-lost son the truth.",
                    "Together, Akihiro and Wolverine defeated Romulus. Although Akihiro returned to assassination work for a while, Wolverine’s heroic spirit slowly rubbed off on him. He eventually took on a new codename—Fang—and joined Krakoa’s Marauders in their efforts to save mutant refugees."
                ],
                Personality =
                [
                    "Much like his father, Fang is prone to going berserk. He fights with a combination of rage and raw instinct. In his youth, he spent nearly every moment on the edge of a murderous frenzy. As he’s gotten older, he has developed a soft spot for a select few people—in particular, the other members of the Wolverine family.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Fantomex",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 6, resilience: 3, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.MutantAssociate),
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
                        powerSelector.GetPower(PowerNames.Accuracy3),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "E.V.A."),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [174],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MutantArtificial],
                Teams = [TeamNames.HellfireClub, TeamNames.XForce, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "In an attempt to speed up normal evolutionary processes, scientists working for the secretive Weapon Plus program created the World: a captive community of ordinary people sealed inside an accelerated-time bubble. The theory was that, with enough time, the inhabitants of the World would naturally produce a powerful mutant, one whom the program’s shady government financiers could weaponize.",
                    "The World did indeed produce a powerful mutant—just not one Weapon Plus could control. One day, out of the blue, a man calling himself Fantomex broke free of the World. He immediately outwitted his captors and escaped, fleeing into the custody of the X-Men.",
                    "Fantomex spent the next several years working alongside the X-Men to utterly dismantle the Weapon Plus program. He battled leagues of evil mutants, boatloads of hideous monstrosities and even clones of himself, all on his way to destroy the program once and for all.",
                    "Then, just as suddenly as he arrived, Fantomex was gone. Shortly after the founding of Krakoa, he re-entered the World on a quest to defend the people he had left behind. No one on the outside has seen him since."
                ],
                Personality =
                [
                    "Fantomex prides himself on his ability to fade into the background, to create new identities for himself and to be as stealthy as he is deadly. He spends most of his time inside a full-body suit that conceals everything except his eyes.",
                    "Fantomex is generally a rather gruff and hyper-focused individual. He does, however, have a soft spot for E.V.A.—a flying, intelligent, Techno-Organic ship spawned from his own nervous system. Whatever she feels, he feels too."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Forge",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 4, vigilance: 3, ego: 5, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6 }],
                Weights = [179],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bionic leg and hand",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechCybernetics, OriginName.MagicSorcery, OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a powerful Cheyenne shaman and an equally brilliant inventor, the young Forge joined the military and had a traumatic tour of duty, during which he lost his right hand and leg. He went on to work in the field of advanced weapons research. On behalf of the U.S. government, Forge built a gun that could temporarily neutralize super-powers.",
                    "When Forge saw that his weapon was being used by S.H.I.E.L.D. agents to target mutants like himself, he abandoned his government job and took up adventuring with the X-Men. While he occasionally goes out adventuring on his own, Forge most enjoys serving as a technician for his fellow X-Men, equipping them with all kinds of powerful gadgets.",
                ],
                Personality =
                [
                    "Forge revels in his abilities as an inventor to “make the impossible real” as he has called it. He can be both a proud inventor and a soft - hearted romantic, proven by his long on-againoff -again relationship with fellow mutant and super hero Storm.",
                ]
            }
        },
        new()
        {
            Name = "Frog-Man",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 1, vigilance: 0, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in suit"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitAndRun),
                    ],
                },
            ],
            IconicItems =
            [
                new()
                {
                    Name = "Frog Man's Battle Suit",
                    IsBattlesuit = true,
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Jump1, powerSelector.GetPower(PowerNames.Jump1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.SpiderDodge, powerSelector.GetPower(PowerNames.SpiderDodge)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy1, powerSelector.GetPower(PowerNames.Sturdy1)),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 3,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Eugene Paul Patilio",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.ActionPack, TeamNames.SpaceFriends],
                Base = "New York City",
                History =
                [
                    "Vincent Patilio was a penniless inventor who thought he could make a quick buck by building a super-suit that would allow him to make a quick escape from any heist. Donning a frog-themed costume, Vincent Patilio made his debut upon the world stage as the villain Leap-Frog.",
                    "He was almost immediately arrested by Daredevil.",
                    "From then on, Vincent’s life only got worse. Despite having sworn off crime, the public continued to see him as little more than a petty menace. He and his son Eugene fell further and further into poverty.",
                    "Eventually, Eugene became sick of people bad-mouthing his father. He dug up his dad’s old suit and vowed to clear the name of frog-themed adventurers everywhere. Under the title of Frog- Man, he wages a one-amphibian war on crime."
                ],
                Personality =
                [
                    "Eugene has a good heart, but his own bumbling and awkward nature has kept him from achieving his dreams. Despite having been an adventurer for a few years, he has yet to make much of a name for himself. He often falls back on his old job as a busboy to make rent.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
    ];
}
