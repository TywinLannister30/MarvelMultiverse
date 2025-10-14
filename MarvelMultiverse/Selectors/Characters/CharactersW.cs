using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersW
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
            Name = "War Machine",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Stark Tower"),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
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
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
                        powerSelector.GetPower(PowerNames.KillZone),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James Rupert “Jim” Rhodes",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [240],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD],
                Base = "New York City",
                History =
                [
                    "While working as an army pilot, James Rhodes was forced to make an emergency landing, deep in the Sin-Cong jungle, where he ran into Tony Stark, who had just escaped the Sin-Cong prison where he had fashioned his original Iron Man suit. Together, they fought their way out.",
                    "Rhodey quickly became one of Tony’s closest friends and has even taken over as Iron Man on occasion. Eventually, he wound up with his own suit of Stark-designed armor as War Machine. He was killed in action during the second superhuman Civil War, but Tony later restored him to life."
                ],
                Personality =
                [
                    "Although Rhodey is perfectly personable around his friends and family, he takes battle seriously and isn’t the type to fire off quips while fighting a super villain. He serves as a coolheaded and focused counterpart to the off en-erratic Tony.",
                ]
            }
        },
        new()
        {
            Name = "Warlock",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 2, ego: 4, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Infector, reminder: "Transmode virus"),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BrainDrain),
                        powerSelector.GetPower(PowerNames.LeechLife),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BodySphere),
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Warlock",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Varies, typically black",
                Hair = "Varies, typically black with yellow highlights",
                Size = Size.Average,
                DistinguishingFeatures = "Gooey, Techno-Organic body",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.AlienTechnarch, OriginName.Mutant],
                Teams = [TeamNames.Excalibur, TeamNames.NewMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a child of the alien species known as the Technarchy, Warlock was expected to do one of two things when he came of age. He was to either kill Magus, his father, or else die by his father’s hand. Refusing to do either, Warlock fled to Earth. Injured and alone, he wandered onto the premises of Xavier’s School for Gifted Youngsters, then the home of the New Mutants.",
                    "In a haze of confusion and fear, Warlock attacked the young heroes. Thankfully, with the help of their linguistically gifted associate Doug Ramsey (Cypher), the New Mutants eventually made peace with Warlock and convinced him to join their team.",
                    "In the years since, Warlock has become a trusted and world-renowned hero. Although his adventures have, at times, taken him across the galaxy, he’s never strayed far from the company of the New Mutants, who love him with all their hearts.",
                    "Warlock remains particularly close with Doug Ramsey and has spent some stretches of his life fully or partially merged with him. In their fused state, Ramsey and Warlock are referred to collectively as Douglock."
                ],
                Personality =
                [
                    "Warlock speaks in a strange and robotic dialect unique to members of the Technarchy. He does not use the pronoun “I,” instead referring to himself only as “Warlock” or “Self.” When speaking of others, he often compounds names with other terms. For instance, he might refer to his friend Doug Ramsey as “selffriend” or “Doug-friend.”",
                    "Despite his alien mannerisms, Warlock is as kind and gentle a soul as exists on Earth. On Krakoa, he spent much of his time entertaining the children there with wacky acts of shape-shifting."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Warlock (Adam Warlock)",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 5, vigilance: 4, ego: 9, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.Supernova),
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
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Adam Warlock",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [240],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "eyes and bright golden skin",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.InfinityWatch],
                Base = "Mobile",
                History =
                [
                    "Adam Warlock was created by a group of evil geneticists known only as the Enclave. This shadowy organization sought to create the perfect human being—an all-powerful creature they could use to control the world. They succeeded in creating a very powerful creature, just not one that they could control.",
                    "Adam Warlock emerged from his biomechanical cocoon a fully grown adult. He instantly sensed the evil in the hearts of his creators and destroyed them. Then he set off across the cosmos to find his purpose.",
                    "In the years since his birth, Warlock has been at the center of several galaxy-spanning confl icts. He has contended with forces that threatened to consume all of existence, including the mad titan Thanos and the insatiable Hunger. Warlock has, on several occasions, died fi ghting for justice only to rise again, stronger than before.",
                    "Warlock’s already considerable powers are frequently augmented by the Soul Stone, one of the six Infi nity Gems. Although Warlock currently lacks a fully powered Soul Stone, he is still regarded as one of the toughest beings in the known universe."
                ],
                Personality =
                [
                    "Warlock’s early days were filled with anger and confusion. He had incredible power but only the most basic grasp of right and wrong. Years passed before he could form a coherent identity for himself. Only then was he ready to become the hero the world knows today.",
                    "The modern Warlock is a humble and determined warrior. He seeks to preserve life across the universe and to defeat evil wherever it may be."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Warpath",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 3, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James “Jimmy” Proudstar",
                Heights = [new() { Feet = 7, Inches = 2 }],
                Weights = [350],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.XForce, TeamNames.XMen],
                Base = "Arizona",
                History =
                [
                    "Jimmy Proudstar grew up on an Apache reservation in southern Arizona alongside his brother, John. The boys were born with similar mutant super-powers lurking in their DNA, but John, as the older of the two, had his manifest first.",
                    "Having always dreamed of being a hero, John left home and joined the X-Men under the codename Thunderbird, only to be tragically killed on one of his first missions. Blaming the X-Men for his brother’s death, Jimmy took on the codename Warpath and attempted to annihilate the mutant hero team.",
                    "Jimmy eventually made peace with the X-Men and even agreed to join their organization, but his anger over his brother’s death never fully went away. Even as years passed and Jimmy gradually became a veteran member of many important super-teams, his resentment lingered.",
                    "Only with the foundation of Krakoa and John’s subsequent resurrection did Jimmy finally begin to forgive and forget.",
                    "Both of the Proudstar brothers remain active heroes, but lately, John has been spending most of his time taking care of their ailing grandmother in Arizona. Jimmy, on the other hand, splits his time between helping his grandmother and acting as a mentor to the New Mutants."
                ],
                Personality =
                [
                    "As opposed to his more levelheaded brother, Warpath has a no-nonsense attitude and a penchant for bouts of righteous rage. Age has somewhat tempered his harder edges, but his sheer determination for obtaining justice, no matter the cost, continues to make him a key component of more militant mutant groups. Few mutants can claim as much experience in battle as Warpath.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Wasp (Janet Van Dyne)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 3, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, French, Hungarian, Italian, Spanish"),
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                        powerSelector.GetPower(PowerNames.Shrink3),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
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
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Janet Van Dyne",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Auburn",
                Size = Size.Varies,
                DistinguishingFeatures = "Cybernetic wings",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.AgentsOfWakanda, TeamNames.Avengers],
                Base = "Mobile",
                History =
                [
                    "Born a wealthy heiress, Janet Van Dyne caught the eye of brilliant scientist Hank Pym. The two quickly became partners, in both crimefi ghting and romance. Hank developed a special substance called Pym Particles, allowing him to grow and shrink his body mass at will. Using them, Hank and Janet became the super heroes known as Ant-Man and the Wasp, founding members of the Avengers.",
                    "Eventually, the pair split, their marriage irreparably broken by Hank’s often unstable and abusive behavior, but Janet never stopped being the Wasp. Over the years, she’s become a shining example of true heroism for people everywhere, far surpassing her ex-husband as a trusted leader in the super-hero community.",
                ],
                Personality =
                [
                    "Raised as a pampered socialite, Janet makes a surprisingly effective battle leader. However, her social skills also make her an excellent administrator. She takes an empathetic, understanding approach to tackling the problems of her allies and her friends.",
                ]
            }
        },
        new()
        {
            Name = "Wasp (Nadia Van Dyne)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 3, ego: 3, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese (Mandarin), English, French, Italian, Japanese, Russian, Spanish"),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlElectricity,
                    Powers =
                    [
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
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow1),
                        powerSelector.GetPower(PowerNames.ResizeObject),
                        powerSelector.GetPower(PowerNames.ResizeOther),
                        powerSelector.GetPower(PowerNames.Shrink3),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
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
                RealName = "Nadia Van Dyne",
                Heights = [new() { Feet = 5, Inches = 2 }],
                Weights = [100],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Varies,
                SizeNotes = "normally average",
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.HighTechPymParticles, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.Champions, TeamNames.GIRL],
                Base = "Mobile",
                History =
                [
                    "When Hank Pym’s first wife, Maria Trovaya, was killed by Hungarian secret police, he assumed that the daughter she was carrying—Nadia—had died as well. In reality, Trovaya was kept alive just long enough to give birth so they could enroll her infant into their Red Room spy-training program.",
                    "Nadia’s handlers tried to turn her into a shrinking superspy, but they made the mistake of telling her about her origins. As soon as she was old enough to effectively use Pym Particles, she turned on her superiors and fled back to the United States.",
                    "Hank Pym was, at the time, thought to be dead, so Nadia sought out his old partner, the Wasp (Janet Van Dyne). Van Dyne generously adopted the wayward girl, and Nadia in turn became her new mother’s apprentice, taking on both her last name and her codename.",
                    "In just a few short years, the new Wasp has distinguished herself as one of the most capable and inventive young heroes on the planet. She’s played key roles with both the Avengers and the Champions, though these days she spends most of her time working with G.I.R.L.—an all-female research group of her own creation."
                ],
                Personality =
                [
                    "The Wasp has a bit of both Janet Van Dyne and Hank Pym in her. She’s a natural leader and a loyal friend. She’s also a relentlessly dedicated scientist, perhaps even more so than her father, given that she is entirely uninterested in sex and romance.",
                    "Unfortunately, in addition to her father’s mind, the Wasp also inherited his mental health issues and suffers from bouts of bipolar disorder."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Whiplash",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Convict),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
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
                    IsBattlesuit = true,
                    Name = "Whiplash’s Armor",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Flight1),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.IconicItem} (Whiplash’s Energy Whips)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty1),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy2),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Summonable),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Whiplash’s Energy Whips"),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                    Restrictions =
                    [
                        "Menacing",
                        "Worn",
                    ],
                    PowerValue = 4,
                    IsTech = true
                },
                new IconicItem
                {
                    Name = "Whiplash’s Energy Whips",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "These energy whips can count as either Energy attacks or Sharp attacks."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach+1, Melee Damage Multiplier bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Anton Igorevich Vanko",
                Heights = [new() { Feet = 6 }],
                Weights = [235],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Dyed green, originally black",
                Size = Size.Average,
                DistinguishingFeatures = "Several prosthetic fingers on right hand",
                Occupations = [OccupationName.Engineer],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.MastersOfEvil, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "A brilliant young engineer, Anton Vanko saw his Russian village destroyed and his father murdered at the hands of a man in an Iron Man suit. Seeking revenge, Anton built his own battle suit from leftover pieces of Stark technology and set out to kill Iron Man. He chose to do so under the codename Whiplash, which a number of Iron Man’s other foes had adopted in the past.",
                    "Tony Stark eventually proved that the Iron Man who attacked Vanko’s village was an impostor, but this did little to satiate the hatred in Vanko’s heart. He still blames Stark for building the Iron Man technology in the first place and continues to thirst for vengeance.",
                    "Vanko has spent most of the last several years either in prison or working for one of a number of for-hire mercenary groups, like the Thunderbolts.",
                ],
                Personality =
                [
                    "The destruction of his childhood home permanently traumatized Whiplash. He can remain cool and collected most of the time, but the slightest mention of Tony Stark or Stark Industries sends him into an uncontrollable rage. The flailing energy whips he uses in battle mirror his own erratic behavior.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Whirlwind",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 2, vigilance: 4, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlAir,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
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
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedBlast),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "David “Dave” Cannon",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Criminal],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.LethalLegion, TeamNames.MastersOfEvil],
                Base = "New York City",
                History =
                [
                    "David Cannon has been a selfish bully since he was a teenager, and his attitude certainly didn’t improve after he developed mutant powers of super-speed. He could have used his abilities to become a world-renowned athlete or a beloved hero. Instead, he chose to spend his days robbing banks as the Human Top.",
                    "Cannon’s criminal activities ultimately drew the attention of Giant-Man (Hank Pym) and the Wasp (Janet Van Dyne), and though it took them a few tries, they successfully brought the Human Top to justice. Determined to have his revenge, Cannon created two new identities for himself. First, he dropped the Human Top title and rebranded himself as Whirlwind. Then he weaseled his way into a job as the Wasp’s limo driver under the pseudonym Charles Matthews.",
                    "This allowed Cannon to spy on her and her allies in the Avengers throughout the day, then come back and exploit what he had learned to attack them at night. It even allowed him to open the doors of Avengers Mansion to villains like the Masters of Evil.",
                    "Though Giant-Man and the Wasp eventually figured out their driver’s true identity, that has not stopped Cannon from trying to attack them at their weakest moments, or from employing similarly deceitful tactics against their allies."
                ],
                Personality =
                [
                    "Whirlwind is an entitled bully perpetually fixated on everything and everyone that he can’t have. At certain points, he became so violently obsessed with the Wasp that he deluded himself into believing he loved her. She, on the other hand, considers him a ridiculous stalker and a minor annoyance at best.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "White Rabbit",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup, reminder: "the Menagerie"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Mini Carrot Missiles (acts as a rifle)"),
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
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
                        powerSelector.GetPower(PowerNames.LegSweep),
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
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Lorina Dodson",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.TheMenagerie, TeamNames.Syndicate, TeamNames.Tombstonesgang],
                Base = "New York City",
                History =
                [
                    "Lorina Dodson was born into money and grew up wanting for nothing. Finding her life to be a horrible bore, she took refuge in the family library and became particularly fond of Alice in Wonderland. In her early twenties, her parents married her off to a rich older man, but after finding married life to be just as dull, she murdered her husband and used his money to finance a new life of crime, thrills and intrigue.",
                    "As the gadget-laden White Rabbit, Dodson attempted to rob a fast-food restaurant, and in the process, she nearly killed local defender Frog- Man. Spider-Man (Peter Parker) arrived at the last minute to save Frog-Man’s life, and together, they took the White Rabbit down.",
                    "In return, Dodson developed a lifelong grudge against both Spider-Man and Frog-Man. In the subsequent years, she and her gang of Alice in Wonderland-styled goons made dozens of vain attempts to defeat the wall-crawler and his amphibian friend.",
                    "Dodson dislikes being subordinate to others, but after so many defeats, she has learned to occasionally swallow her pride and work with other villains outside of her own gang. These days, she spends most of her time helping the all-female Syndicate led by the Beetle (Janice Lincoln) establish itself as a powerhouse in New York’s underworld."
                ],
                Personality =
                [
                    "Though often treated as a laughingstock by New Yorkers and super villains alike, White Rabbit should not be taken lightly. Her villainy is pure and unbridled. She has no need for money. She robs and maims simply for the love of the game. Though not typically prone to killing, she would break her best friend’s legs in a heartbeat if she thought she could get a thrill out of it.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "White Tiger (Ava Ayala)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
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
                RealName = "Ava Ayala",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [131],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.AvengersAcademy, TeamNames.DaughtersOfLiberty, TeamNames.HeroesForHire],
                Base = "Mobile",
                History =
                [
                    "After her family was murdered by the super villain Gideon Mace, Ava Ayala was left with no choice but to take hold of an old family heirloom, the mystical White Tiger Amulet. In years past, both her older brother and her niece had made use of the divine amulet’s powers, fi ghting for justice under the codename White Tiger. Now it was her turn.",
                    "Bent on revenge and determined to continue the legacy of the White Tiger, Ava left home and began training at the Avengers Academy. She quickly became a skilled and capable combatant. Despite recently having the powers of the amulet ripped away, she remains a powerful hero.",
                ],
                Personality =
                [
                    "Ava is a strongly determined person. She pursues her goals with unwavering conviction, and she expects others to do the same. She has very little time or patience for those whom she perceives not to be doing their utmost.",
                ]
            }
        },
        new()
        {
            Name = "White Widow",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Clone),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Widow’s Bite", isTech: true),
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
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Widow’s Bite",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "These blasts can count as either electricity attacks or force attacks."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: 10 spaces, Agility Damage Multiplier Bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 1,
                    AgilityDamageModifier = 1,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Yelena Belova",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.AIM, TeamNames.SHIELD, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "Much to her own dismay, Yelena Belova’s life has run in eerie parallel to that of the famous superspy Natasha Romanoff. Both were raised by the Russian government as part of the punishing and secretive Red Room training program. Both acted as government spies under the codename Black Widow before eventually defecting to the United States. Both went on to work together at S.H.I.E.L.D., where they took part in an operation that required them to temporarily switch identities.",
                    "However, that last job sent Belova into an identity crisis so deep that she abandoned government work entirely and took a new job with A.I.M., whose scientists turned her into a living weapon called a Super-Adaptoid. Unfortunately, these same scientists proved less capable at keeping track of Belova in the field, and not long after her transformation, they mistakenly shot her dead.",
                    "The Red Room later created several weaponized, amnesiac clones of Belova to hunt down Romanoff, and though Romanoff killed most of these clones, she managed to restore the original Belova’s memories to one. Profoundly grateful for a second chance at life, this new Belova took on the codename White Widow and returned to working with Romanoff. These days, both Black Widow and White Widow often work with the Winter Soldier as part of his new incarnation of the Thunderbolts."
                ],
                Personality =
                [
                    "Much like Black Widow, White Widow is a coolheaded and charismatic spy capable of talking her way through the toughest situations. However, perhaps on account of her less tumultuous career, White Widow is a bit more easygoing and trusting than her darker counterpart.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Wiccan",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 2, vigilance: 6, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Chaotic),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.GroupFlight),
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
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicChaosMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HexBolt),
                        powerSelector.GetPower(PowerNames.Jinx),
                        powerSelector.GetPower(PowerNames.PowerfulHex),
                        powerSelector.GetPower(PowerNames.ProtectionHex),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.CrimsonBandsOfCyttorak),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "William “Billy” Kaplan-Altman",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [155],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicChaosMagic, OriginName.Mutant],
                Teams = [TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "Unable to conceive children naturally with her android husband (the Vision), the Scarlet Witch unconsciously stole fragments of Mephisto’s demonic essence and transmogrified them into twin boys. Mephisto discovered the theft and had the children killed. Despite his efforts, their souls eluded his grasp and were reincarnated as William Kaplan and Thomas Shepherd.",
                    "Years later, the magic Kaplan inherited from his original mother emerged. Determined to use his powers for good, Kaplan took the codename Wiccan and joined his boyfriend, Hulkling, and a handful of other young heroes in forming the Young Avengers. On one mission, the team freed Shepherd from a juvenile detention center for super-powered teens. After realizing they looked nearly identical, Shepherd and Kaplan pieced together their origins. For a while, Kaplan and Shepherd worked together. However, Kaplan recently left to elope with Hulkling and join him in overseeing the new Kree/Skrull Empire.",
                    "Prophecy predicts that Wiccan will transform into a being called the Demiurge and forever change the nature of magic. Kaplan has no idea if that day will ever come, but he has felt the Demiurge’s influence in his own time."
                ],
                Personality =
                [
                    "In times of peace, Wiccan struggles to summon the willpower necessary to wield his powers. But when the people he cares about are in danger, there’s not a force in the Multiverse that can stop him. As an insecure and big-hearted Avengers fanboy, he takes the task of living up to the team’s legacy very seriously.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Wild Child",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 3, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Kyle Gibney",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [152],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Minor wolflike features (pointy ears and teeth, claws, etc.)",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Hellions, TeamNames.GammaFlight],
                Base = "Krakoa",
                History =
                [
                    "Kyle Gibney’s mutant powers give him the proportional strength and agility of a wolf, but left untreated, they also give him the mind of a wolf. These powers manifested suddenly in his early childhood, and by the time agents of the Canadian government discovered him living alone on the streets, he had gone almost entirely feral.",
                    "Scientists within Canada’s secretive Department H developed a treatment for Gibney’s condition, allowing him to retain some semblance of intelligence. In exchange for this treatment, Gibney agreed to join Gamma Flight, which was then the department’s super-hero trainee program.",
                    "The original Gamma Flight disbanded shortly after Gibney joined it, but his friends in Alpha Flight managed to pick up where the government left off, training him and administering his medication.",
                    "Gibney eventually left Alpha Flight, feeling himself unworthy of a position in their ranks. He’s spent the time since bouncing around between various shady agencies and organizations, working for anyone who could provide his treatments. He currently works for the Krakoan strike team known as the Hellions, alongside other mutants with hard-to-control powers."
                ],
                Personality =
                [
                    "When he’s taking his meds, Gibney can be softhearted and sensitive. The moment he stops, though, that all fades. Slowly but surely, he becomes an angry, ruthless predator. He is then prone to lash out at anything and anyone in his immediate proximity. In this state, he can speak only in grunts and roars.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Winter Soldier (Bucky Barnes)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
                        powerSelector.GetPower(PowerNames.AttackStance),
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
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
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
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.KGB, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Toward the end of World War II, the aerial explosion that sent Captain America (Steve Rogers) into the north Atlantic where he froze into a block of ice seemingly killed his sidekick, the young Bucky (Bucky Barnes). He was captured by Soviet scientists, who replaced a missing arm with a bionic prosthetic and brainwashed him to become a Russian assassin codenamed the Winter Soldier, after which he was kept in suspended animation for decades, only released to kill and then returned to sleep again.",
                    "Cap eventually discovered who the Winter Soldier was and successfully undid Bucky’s brainwashing. During a period when Rogers was dead, Bucky took up the shield and replaced him as Captain America, but he has since returned to being the Winter Soldier and trying to use his skills for good.",
                ],
                Personality =
                [
                    "Bucky is a deadly serious and world-weary vet. The remorse he feels for his time as an assassin weighs on him every day.",
                ]
            }
        },
        new()
        {
            Name = "Wolfsbane",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "in alternate form; Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "werewolf/wolf"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
            ],
            Biography = new Biography
            {
                RealName = "Rahne Sinclair",
                Heights = [new() { Feet = 5, Inches = 2 }, new() { Feet = 8 }],
                Weights = [110, 410],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Big,
                SizeNotes = "Average in normal form",
                DistinguishingFeatures = "Werewolf-like appearance (in alternate form)",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.XFactor, TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Rahne Sinclair’s lycanthropic powers manifested suddenly in her teen years, and the religious zealots who ran the insular Scottish community where she grew up did not take kindly to her new appearance. She was forced to flee her hometown, but she wound up in the relative safety and security of Xavier’s School for Gifted Youngsters.",
                    "Early in her stay at the school, Sinclair and a few other students helped to save Professor X from a plot that threatened his life. He was so impressed with the conduct of his charges that he formed a junior super-hero squadron just for them: the New Mutants.",
                    "To this day, the friends Sinclair made in the New Mutants are the most important people in her life. After they graduated from Xavier’s school, many of them followed Sinclair into X-Force, becoming founding members of yet another super-hero team.",
                    "Sinclair was tragically beaten to death by mutant bigots, but the founding of Krakoa ensured that the time she spent dead was short. Since her revival, Sinclair has spent most of her time on Krakoa, palling around with her old comrades and lobbying for the resurrection of her son, Tier."
                ],
                Personality =
                [
                    "In her human form, Sinclair is shy and softhearted, but in her wolf form, she is vicious, uncommunicative and prone to bouts of rage. Her greatest worry is that she might, in one of her berserker states, lash out at the ones she loves. Raised Catholic, she sometimes still wrestles with fears that her powers were a gift from Satan.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Wolverine (Laura Kinney)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Adamantium Claws [+1 Melee damage multiplier]",
                            meleeDamageModifier: 1,
                            isTech: true),

                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Laura Kinney",
                Heights = [new() { Feet = 5, Inches = 1 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium claws in hands and feet",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Laura Kinney was created as part of a secret attempt to re-create the experiment that gave the original Wolverine (Logan) his adamantium skeleton. She’s a partial clone of Logan himself, with DNA mixed in from Sarah Kinney, the geneticist who created her.",
                    "The shadowy figures funding this experiment intended for Laura to be an assassin, but Sarah Kinney took pity on her creation and helped Laura escape from their clutches. Free from her captors, Laura tracked down her genetic father and became his protégé. Now she fights alongside Logan, both of them acting under the codename Wolverine.",
                ],
                Personality =
                [
                    "Although the people who funded her creation did their best to erase her humanity, Laura Kinney has grown into a mature and empathetic young woman. She serves as a levelheaded counterpart to her younger, freewheeling genetic twin sister, Gabrielle Kinney (Scout).",
                ]
            }
        },
        new()
        {
            Name = "Wolverine (Logan)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 5, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Sabretooth"),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Adamantium Claws [+1 Melee damage multiplier; ignores 1 level of DR]]",
                            meleeDamageModifier: 1,
                            isTech: true),

                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
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
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James Howlett (a.k.a. Logan)",
                Heights = [new() { Feet = 5, Inches = 3 }],
                Weights = [195],
                WeightReminder = "300 lbs. with adamantium",
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium claws, muttonchops",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.Avengers, TeamNames.FantasticFour, TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa, Summer House (the Blue Area of the Moon)",
                History =
                [
                    "Born in Canada in the late 1800s, James Howlett wandered the world under the name Logan. At one point, the Weapon X program captured him and bonded adamantium metal to his entire skeleton, including his retractable claws; his mutant healing factor enabled him to survive the experience. He escaped, but with large gaps in his memory.",
                    "Logan later joined the X-Men and became a valued member of various X-teams. Over time, he recovered most of his memories. He was killed in recent years, but returned to life in time to help establish a new mutant nation on the island of Krakoa.",
                ],
                Personality =
                [
                    "Logan can be cold-blooded and slow to trust others, but the restoration of his memory blunted those edges. He’s still a no-nonsense man, but that’s tempered with the wisdom age brings. After living as a loner for so long, he treasures his found family.",
                ]
            }
        },
        new()
        {
            Name = "Wolverine (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 6, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Sabretooth"),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Adamantium Claws [+1 Melee damage multiplier; ignores 1 level of DR]]",
                            meleeDamageModifier: 1,
                            isTech: true),

                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
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
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "James Howlett (a.k.a. Logan)",
                Heights = [new() { Feet = 5, Inches = 3 }],
                Weights = [195],
                WeightReminder = "300 lbs. with adamantium",
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium claws, muttonchops",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "The origins, past and full name of the Canadian mutant named Logan, alias Wolverine, are unknown. Thanks to his mutant healing factor, he is extremely long-lived; he was first known to be active during World War II, when he aided Captain America in battling the Red Skull. Decades later, he was subjected to experimentation by the Weapon X program that bonded adamantium with his skeleton and gave him retractable metal claws, as well as modifying his memories; another Weapon X test subject, Sabretooth, would become his lifelong rival. He eventually escaped from Weapon X, resulting in the death of its chief scientist, Kenji Oyama. Oyama’s daughter and Logan’s ex-lover Yuriko Oyama would later stalk Logan as the adamantium-clawed Lady Deathstrike. Mac and Heather Hudson took in the fugitive Logan; he would later join Mac in the Canadian super-team Alpha Flight before leaving to join the X-Men. Although his solitary nature kept most of his teammates at a distance, he did befriend the eccentric Morph and was enraged when he was seemingly killed by Sentinels. He has continued to serve as a stalwart X-Man, mentoring new X-Men member Jubilee and helping the revived Morph rejoin the team. Recently, the X-Men’s archenemy Magneto tore the adamantium out of Wolverine’s body.",
                ],
                Personality =
                [
                    "A loner by nature, Wolverine often chooses to operate solo. His advanced age has given him years of experience, and he is an unmatched fi ghter and tracker. In battle, he often lapses into a feral rage, making him a danger to friend and foe alike. Nevertheless, his attitude toward his fellow X-Men has softened over time, and he has become a valued teammate. He has feelings for Jean Grey; combined with his natural distrust of authority, this often puts him at odds with X-Men leader Cyclops.",
                ],
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Wonder Man",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 5, vigilance: 4, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
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
                RealName = "Simon Williams",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [380],
                Gender = Gender.Male,
                Eyes = "Red void, usually disguised as gray",
                Hair = "Gray, usually dyed black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.MastersOfEvil, TeamNames.WestCoastAvengers],
                Base = "Mobile",
                History =
                [
                    "Desperate to save the engineering firm his father built, Simon Williams turned to financial crimes, which quickly landed him in court. Baron Zemo and the Masters of Evil bailed him out and offered him a chance at revenge against the much more successful Tony Stark.",
                    "Zemo subjected Williams to an experimental treatment that made him super-strong but would eventually destroy him. If he wanted to live, Williams would have to do the evil team’s bidding forever. Rebelling, the newly christened Wonder Man joined the Avengers and helped take down the Masters of Evil instead.",
                    "Williams seemingly died, but the raging forces inside his body rebuilt him into a being of pure energy. When he finally came back to life, he pursued Hollywood stardom. However, making it as an actor proved harder than Williams expected, and he returned to the Avengers on their new West Coast team.",
                    "After working with several more super-teams, Williams turned on the Avengers again, declaring them ineffectual as saviors. But after a brief fight and a much longer period of self-reflection, he apologized for his actions and dedicated himself to a life of pacificism. Though he no longer fights villains directly, Williams still does disaster response work with the Avengers’ backup squadron."
                ],
                Personality =
                [
                    "Williams is an easygoing playboy who loves luxuriating in attention and sipping boat drinks by the beach. However, his relaxed lifestyle in no way indicates thoughtlessness or selfishness. He’s a kind and gentle man, with a penchant for philosophy.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Wong",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 7, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wong",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.MidnightSons],
                Base = "New York City",
                History =
                [
                    "Wong is the latest in a long ancestral line of Tibetan monks who have vowed to serve and protect the Earth’s Sorcerer Supreme. In that role, Wong has acted as an assistant to Doctor Strange for most of his adult life.",
                    "Years of working closely together have led to no small amount of friction between Wong and Doctor Strange. Strange's distant, intense and sometimes condescending personality matches poorly with Wong’s laid-back nature. The pair remain allies, though Wong has learned to take some breaks from Strange’s service, making time to strike out as a hero in his own right.",
                ],
                Personality =
                [
                    "Wong and Strange couldn’t be more different as people. Strange is generally sharp and sometimes abrasive to those around him, rarely cracking jokes. Wong, conversely, is a charming and humble man who has an easy time empathizing with the struggles of others.",
                ]
            }
        },
        new()
        {
            Name = "Wraith (Earth-1048)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 1, vigilance: 2, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Whip (acts as spear)"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Yuriko “Yuri” Watanabe",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.NYPD],
                Base = "New York City (Earth-1048)",
                History =
                [
                    "Yuri Watanabe always had somewhat nontraditional views on law enforcement. For years, she was a secret contact within the New York police force for Spider-Man (Peter Parker), quietly feeding the vigilante information on jobs that were too tough for the cops to handle. But after half her unit was massacred by Hammerhead’s Maggia goons, she went completely rogue. She shot Hammerhead in the head, nearly killing him, and resigned her commission. Rebranding herself as the private mercenary Wraith, Watanabe took to the streets, determined to take out the rest of the Maggia.",
                    "In the days since, Wraith has enacted a campaign of mass murder across the city’s underworld. Her old friend Spider-Man has been trying his best to apprehend her, but to no avail.",
                    "Currently, Wraith has set her sights on the Flame (Cletus Kasady)—the enigmatic leader of a pyromaniac doomsday cult. Spider-Man’s efforts to prevent Wraith from assassinating the man have had the unfortunate side effect of allowing the cult leader to steal a piece of the Venom symbiote from Oscorp. Kasady may be lying low for the moment, but when he returns, carnage is sure to follow in his wake.",
                ],
                Personality =
                [
                    "Watanabe is a grim person with a soft spot for her friends—including, despite it all, Spider-Man. But she has absolutely no sympathy for anyone else. Her only goal in life now is to take down killers, and she refuses to let anyone get in her way, not even her friends.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Wrecker (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 5, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Gullible),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Magic crowbar [Throwable club. Automatically returns to thrower.]"),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
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
                RealName = "Dirk Garthwaite",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [320],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Dirk Garthwaite was just a small-time thief with a crowbar until the day he was accidentally granted magical powers originally meant for Loki. As the Wrecker, Garthwaite used his new powers to embark on a one-man crime spree across New York City, and it took the intervention of Thor to end his villainous rampage.",
                    "Garthwaite wound up serving time in Ryker’s Island. He eventually escaped, but only with the help of a few of his fellow inmates. Out of gratitude, he granted a portion of his own power to each of them, and they formed the nefarious Wrecking Crew.",
                    "Under the Wrecker’s leadership, the Wrecking Crew has committed countless crimes, often in the employ of smarter, more ambitious or more powerful villains."
                ],
                Personality =
                [
                    "Even before he had powers, Garthwaite was prone to fits of anger and violence. Most people consider him an impulsive man in need of some serious psychiatric help. He is admired by the other members of his crew—if by no one else.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
    ];
}
