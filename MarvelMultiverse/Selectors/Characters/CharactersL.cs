using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersL
{
    public static List<Character> GetAllCharacters(
       INarrativePowerSelector narrativePowerSelector,
       IPowerSelector powerSelector,
       ITagSelector tagSelector,
       ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "Lady Deathstrike",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 4, vigilance: 5, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.FuriousAttacks),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "with claws out"),
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
                        powerSelector.GetPower(PowerNames.Brawling),

                        powerSelector.GetPower(PowerNames.IconicWeapon,
                            specialization: "Adamantium nails [+1 Melee damage multiplier; ignores 1 level of DR]",
                            meleeDamageModifier: 1,
                            isTech: true),

                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
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
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                    IsTech = true
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
            ],
            Biography = new Biography
            {
                RealName = "Yuriko Oyama",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [128],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium nails",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.Reavers, TeamNames.SisterhoodOfMutants, TeamNames.WeaponXForce],
                Base = "Mobile",
                History =
                [
                    "In an attempt to make money on the black market, mad scientist and Japanese nationalist Kenji Oyama developed a process for safely lacing human bones with adamantium. This process was invasive, requiring the installation of cybernetic implants, but it worked, and weapons dealers from around the world took note.",
                    "Kenji implemented his process only a few times before the super heroes of the world took him down. In his absence, his daughter Yuriko took up the cause of protecting her father’s legacy. She had her own body implanted with adamantium and set out to become a mercenary under the codename Lady Deathstrike.",
                    "More than anyone, Yuriko hates Wolverine (Logan). She believes his adamantium implants were possible only because of research stolen from her father, and that Wolverine’s very existence spits in the face of her late father’s work.",
                    "Yuriko’s longtime rivalry with the nigh-unkillable mutant has, at times, drawn her into conflict with the larger world of mutants. Because of that, it is not unknown for her to ally herself with mutant-hating bigots like William Stryker."
                ],
                Personality =
                [
                    "Lady Deathstrike is a grim and merciless combatant with an unflinching sense of duty. She pursues her targets relentlessly and without fail. Wolverine is one of the few people in existence to have bested her in direct combat.",
                    "She would hardly ever admit it, but Lady Deathstrike long ago lost track of her real reasons for hating Wolverine. She continues to fight him for the same reason that she continues her work as an assassin. It’s all she knows.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Leader",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 3, vigilance: 4, ego: 4, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Samuel “Sam” Sterns",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [144],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Enlarged cranium, green skin",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Intelligencia, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "Samuel Sterns was once nothing more than a mild-mannered factory worker tasked with transporting canisters of nuclear waste. One day, during a routine disposal, a canister broke open and showered him in gamma radiation. The radiation mutated Sterns’ body, turning his skin green and enlarging his skull. Finding that he now had superhuman intelligence and psionic abilities, Sterns adopted the title of the Leader and set himself to the task of conquering the world.",
                    "Sterns’ evil plans have been thwarted again and again by the intervention of fellow gamma mutate the Hulk (Bruce Banner). He has become obsessed with defeating the Hulk, who he sees as the biggest obstacle on his path toward world domination.",
                ],
                Personality =
                [
                    "A megalomaniacal narcissist, the Leader believes that his brilliant intellect grants him the right to rule the world. It infuriates him that a being as dim-witted as the Hulk could possibly foil his schemes.",
                ]
            }
        },
        new()
        {
            Name = "Lockheed",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 1, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.UnusualSize, reminder: "Little"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 2, Inches = 6 }],
                Weights = [20],
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "None",
                Size = Size.Little,
                DistinguishingFeatures = "Looks like a tiny purple dragon",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Excalibur, TeamNames.Marauders, TeamNames.SWORD, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Lockheed was born into the Flock: an interstellar society of dragon-like aliens. His childhood was as normal as any childhood can be for an alien dragon. He grew up healthy and strong, and he made a name for himself among his people as a warrior in their eternal battle against the alien Brood.",
                    "It was a good life, but not one that Lockheed wanted. The day before he was bound to be wed, Lockheed ran into a group of captive X-Men trapped inside a Brood settlement. He helped to free them, and they allowed him to accompany them back to Earth. He has been with them ever since.",
                    "Lockheed likes all of the X-Men, but he has a particular affinity for Kate Pryde. They accompany each other on many of their adventures, and Lockheed often is seen perching atop her shoulders or neck. Kate treats Lockheed like the greatest pet she could have, and that’s just the way he likes it.",
                ],
                Personality =
                [
                    "Lockheed can understand and speak English to a limited degree, but he prefers to spend most of his time silent. He’s protective of the X-Men, particularly Kate Pryde, but his tiny body makes it hard for him to be of much use to them in combat. He tends to skirt around the edges of battles, scorching off-guard villains and goons from afar.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Lockjaw",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 3, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only bark"),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                    Name = PowerSetNames.OmniversalTravelDimensional,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DimensionalTravel),
                        powerSelector.GetPower(PowerNames.DimensionalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportBlind),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportOther),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lockjaw",
                Heights = [new() { Feet = 5 }],
                Weights = [1240],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Giant bulldog with small tuning-fork-like antennae",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Inhuman, OriginName.WeirdScience],
                Teams = [TeamNames.HouseOfAgon, TeamNames.PetAvengers],
                Base = "Mobile",
                History =
                [
                    "Lockjaw is the fi nal result of a series of experiments on animals performed by Inhuman geneticists. He was implanted with Inhuman genes and exposed to the Terrigen Mist while still in the womb. As a result, he later grew to an immense size and gained the ability to teleport nearly unlimited distances.",
                    "The data from the experiments on Lockjaw was used to give the future Inhuman king Black Bolt his own powers. Mere days after Black Bolt was born, the young prince developed an attachment to the dog who had been mutated in the same manner as himself. Soon enough, Lockjaw had become the official pet of the Inhuman Royal Family.",
                    "Lockjaw accompanies the royals on nearly all of their adventures. Although his combat abilities are limited, his powers of teleportation make him an indispensable teammate. In the rare event that the Inhuman royals are outmatched by an opponent, they can always cling to Lockjaw and teleport away.",
                ],
                Personality =
                [
                    "Although more intelligent and observant than an average bulldog, Lockjaw is still an animal. He whines, barks, begs and behaves like any other dog.",
                    "Lockjaw can be rambunctious, and he has been known to run off on his own adventures from time to time. However, he is, above all else, loyal to Black Bolt. Any who make themselves an enemy of the Inhuman king must also contend with his dog."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Logos (of Earth-56438)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Hounded, reminder: "outside ancient Egypt"),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Powerful, reminder: "within ancient Egypt"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Logos",
                Heights = [new() { Feet = 5 }],
                Weights = [125],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Mutant],
                Teams = ["Personal advisor to Rama-Tut Kang"],
                Base = "Ancient Egypt",
                History =
                [
                    "Having been born into a wealthy Egyptian family, Logos was raised from birth to act as an advisor within the pharaoh’s royal court. His brilliant mind and his preternatural ability to sense what others are thinking brought Logos prestige and renown. However, he obtained the status of grand vizier only after Kang’s arrival.",
                    "When Kang fi rst arrived in Egypt, he slaughtered most of the last pharaoh’s court. Logos is one of the few who Kang chose to spare.",
                    "Although he does not know it himself, Logos is a mutant, one of the earliest. He is a brilliant advisor, but Logos’ mutant status is the main reason Kang kept him around. Kang has been on the lookout for Apocalypse since the moment he set foot on Egyptian soil. Some part of him believes that by retaining control over one mutant, he can somehow draw in another.",
                ],
                Personality =
                [
                    "Logos was raised to have unquestioning loyalty to the pharaoh. However, Kang’s brutality has shaken his resolve. Logos remains committed to Kang’s service, and he treats any threats to the pharaoh’s well-being with deadly seriousness. However, he would be willing to assist an investigation into Kang’s true origins.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Loki",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 4, ego: 8, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
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
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Loki Laufeyson",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.DarkCouncil, TeamNames.GodsOfAsgard],
                Base = "Asgard",
                History =
                [
                    "Although born to a family of Frost Giants, Loki Laufeyson was rescued from a battlefi eld and adopted by Odin, the king of Asgard, who treated Loki as one of his own and raised him alongside his other son Thor. As the crafty god of mischief, Loki’s schemes have served as the inciting incident for many incredible adventures, including the formation of the original Avengers. He has been thought defeated many times, but he never fails to return, often even more cunning than ever.",
                    "Loki often plays the villain, but he’s served as a hero many times as well. His focus as a god has morphed many times too, including things like mischief, lies and stories.",
                ],
                Personality =
                [
                    "Feeling like an outsider to the Asgardian community, Loki harbors some resentment toward his brother, Thor, for his effortless ability to fit in. However, he’s willing to set everything aside in the name of a good prank. He delights in mischief above all else.",
                ]
            }
        },
        new()
        {
            Name = "Longshot",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 3, vigilance: 5, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MutantAssociate),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Luck,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CharmedLife),
                        powerSelector.GetPower(PowerNames.LuckyMe),
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
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DanceOfDeath),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Longshot",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [80],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Left eye glows when using powers; born with only eight fingers",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Exiles, TeamNames.XFactor, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "As the supreme leader of Mojoworld, the monstrous Mojo rules over a race of genetically engineered slaves that he abuses for his own amusement, forcing them into dire, life-or-death situations and filming the results for use in a series of sick and twisted TV shows. One of these slaves—a stuntman named Longshot—attempted to overthrow Mojo. As the result of a bizarre genetic experiment, Longshot had been born extremely lucky, and he came within a hair’s breadth of defeating Mojo once and for all before being mindwiped by Mojo’s lackeys.",
                    "The amnesiac Longshot fled to Earth-616, where he joined forces with the X-Men. He began a relationship with his teammate Dazzler and even had a son with her—who would become known as Shatterstar—before once again being captured and mindwiped by Mojo’s forces.",
                    "Eventually, the Exiles freed Longshot and invited him into their crew. After regaining most of his lost memories, he left the Exiles to join X-Factor Investigations and spend more time with Dazzler. Following the dissolution of X-Factor Investigations, Longshot all but disappeared.",
                    "Although a close mutant associate, Longshot is not a mutant himself, and he has been minimally involved in the Krakoan era. He is, presumably, still scouring the Multiverse for a way to defeat Mojo."
                ],
                Personality =
                [
                    "Because his mind is in shambles more often than not, Longshot operates almost entirely on sheer instinct. He trusts that his uncanny luck can lead him to where he needs to be and allow him to endure any troubles that may arise along the way.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Luke Cage",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 5, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.Sturdy3}"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Harlem Apartment"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
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
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lucas “Luke” Cage; formerly Carl Lucas",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [425],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Leader],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Defenders, TeamNames.HeroesForHire, TeamNames.MightyAvengers],
                Base = "New York City",
                History =
                [
                    "Imprisoned for a crime he didn’t commit, Carl Lucas was recruited by the prison’s doctor as a test subject for an experimental variant of the Super-Soldier Serum that empowered Captain America (Steve Rogers). Imbued with superhuman strength and durability, Lucas broke free of his prison and returned to the Harlem of his youth.",
                    "As a fugitive, Lucas adopted the name Luke Cage and began working as a Hero for Hire. Cage has been through a lot in the years since, sometimes teaming up with internationally recognized super-groups and sometimes returning to for-hire work, but he’s never stopped being a tireless fi ghter for the people of Harlem."
                ],
                Personality =
                [
                    "Cage is as sensitive and caring as he is tough and strong. Circumstances may force him into work as a paid hero, but he often helps those in need for free. Nothing is more important to him than his friends and family, including his wife, Jessica Jones, and their daughter, Danielle.",
                ]
            }
        },
    ];
}
