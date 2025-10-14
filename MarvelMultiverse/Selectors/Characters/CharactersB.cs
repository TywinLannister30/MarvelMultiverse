using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersB
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
            Name = "Bank Robber",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 1, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Streetwise),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Evasion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlForce,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
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
                DistinguishingFeatures = "Varies",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.BankRobberyGang],
                Base = "Varies",
                History =
                [
                    "This group of criminals desperately needed cash, so they decided to rob a bank.",
                ],
                Personality =
                [
                    "This group of bank robbers lucked into finding a cache of super-tech weapons that were intended for delivery to an A.I.M. base. They decided to use these new super guns to rob a bank. They’re ultimately cowards, looking for a quick buck. They would rather go to jail than face down superhumans for too long. That said, they are desperate, and they think their new guns will allow them to get away with just about anything.",
                ]
            },
            Source = BookSource.RevengeOfTheSuperSkrull
        },
        new()
        {
            Name = "Banshee",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 2, vigilance: 3, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Investigation),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlSound,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Sean Cassidy",
                Heights = [new() { Feet = 6 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GenerationX, TeamNames.XCorp, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "After serving as an officer for Interpol, Sean Cassidy fell in with a group of nefarious blackmailers who forced him to use his powers publicly for the first time in his life. Luckily for Cassidy, the X-Men managed to free him from these villainous handlers. The X-Men offered Cassidy a position within their ranks, and he eventually took the deal, joining them as a member of their second lineup.",
                    "Sadly, Cassidy’s time with the X-Men did not last. Weighed down by injuries sustained on the field of battle, he left the organization less than a year into his tenure to focus on spending more time with his daughter, Theresa, who eventually became the hero known as Siryn.",
                    "Once his daughter was older, Cassidy returned to the X-Men and ended up dying in action.",
                    "The next several years of Cassidy’s life—or death, as it may be—were hell. He was resurrected on several occasions, each time by a villain who wanted to use him for their own purposes—and each time being killed again.",
                    "He was recently resurrected on Krakoa, to a much happier life."
                ],
                Personality =
                [
                    "In his youth, Cassidy was the stereotypical picture of a romantic, fun-loving, hard-drinking Irishman. He still has some of that spirit in him, but with the traumas he’s sustained over the last decade, that part of his personality has become muted.",
                    "Cassidy’s new world-weary outlook does have a silver lining. He had a long-standing rivalry with his cousin, Black Tom Cassidy, but now that they’ve gotten older and become a lot more like one another, they’ve mostly managed to bury the hatchet."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Baron Mordo",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 5, ego: 8, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Flight1),
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
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
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
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                        powerSelector.GetPower(PowerNames.UntouchablePosition),
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
                RealName = "Karl Amadeus Mordo",
                Heights = [new() { Feet = 6 }],
                Weights = [250],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bright green and yellow robes, goatee",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery],
                Teams = [],
                Base = "Castle Mordo",
                History =
                [
                    "Starting in his youth, Mordo studied the mystic arts under the tutelage of the Ancient One. A greedy and resentful man, he sought magic power primarily as a means to restore the Transylvania of his youth to its once-great feudal status.",
                    "Mordo eventually got sick of the Ancient One’s mystic methods and betrayed him in favor of the power offered by the dread demon Dormammu instead. In the years since, Mordo has spent much of his time serving Dormammu and butting heads with the Ancient One’s most famous disciple: Doctor Strange.",
                ],
                Personality =
                [
                    "Boastful, zealous and often verging on insane, Baron Mordo is not the type to make friends. More than anything, he desires the power to prove to the world that he is the greatest sorcerer in existence. He has returned from death and madness on multiple occasions to continue his pursuit of ultimate power.",
                ]
            }
        },
        new()
        {
            Name = "Baron Zemo (Helmut Zemo)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 1, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Villainous),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Adhesive X"),

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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Helmut Zemo",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [183],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blonde",
                Size = Size.Average,
                DistinguishingFeatures = "Heavily scarred face, covered with a mask",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra, TeamNames.MastersOfEvil, TeamNames.Thunderbolts],
                Base = "Tower Zemo",
                History =
                [
                    "Helmut Zemo was born the son of Heinrich Zemo, a Nazi scientist and super villain. Heinrich spent years seeking the destruction of America and the resurrection of fascist Germany but ultimately died in a rockslide while fighting with Captain America. Helmut, furious, chose to follow in his father’s footsteps.",
                    "Helmut has long served as a key figure among fascist organizations, acting as an ally to the likes of the Red Skull and Hydra. Over the years, he’s personally founded and led a number of super teams, including multiple incarnations of the Masters of Evil and the Thunderbolts.",
                ],
                Personality =
                [
                    "Despite being a fascist zealot bent on world domination, Zemo has a good head for battle. He lacks extensive super-powers, relying instead on careful scheming to best his opponents. His duplicitous nature makes him a danger both to his enemies and his supposed allies.",
                ]
            }
        },
        new()
        {
            Name = "Beak",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 0, vigilance: 1, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Gullible),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Flight1),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Dependents, reminder: "More than a dozen young children"),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitAndRun),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Barnell “Barry” Bohusk",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Black",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "Birdlike physique and appearance, with a beak, talons and feathers",
                Occupations = [],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewWarriors, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Barnell Bohusk was once an ordinary teenager. Then his mutant powers kicked in.",
                    "Practically overnight, his entire appearance changed. His hands and feet curled into talons, and feathers began to sprout all over his body. His skin took on a more wrinkled and pinkish tone, and his bones shrank and hollowed.",
                    "Unable to continue a normal life in human society, Beak fled from home and into the welcoming arms of Charles Xavier’s school for mutants. It was at this school that he met Angel Salvadore (codename: Tempest), a girl with insectoid powers mirroring his own. They began a whirlwind romance of the highest order. Within a year, they had married and had five kids.",
                    "Beak and Tempest have both acted as super heroes from time to time, more out of necessity than a desire to change the world. Neither of them has a particular desire to be part of a battle team, preferring to concentrate on raising their children instead.",
                ],
                Personality =
                [
                    "Although he has, on occasion, been manipulated or threatened into committing evil deeds, Beak doesn’t have a mean bone in his body. He cares deeply for others, especially those he considers family. After the formation of the nation of Krakoa, he delayed his move there for months so he could take care of his ailing father.",
                    "Despite appearances, Beak is actually quite timid and easily embarrassed. Thankfully, his wife is as assertive as Beak is shy. They balance each other nicely."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Beast (Hank McCoy)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 2, vigilance: 2, ego: 3, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Jump1),
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
            Biography = new Biography
            {
                RealName = "Henry Philip “Hank” McCoy",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [402],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Covered with blue fur",
                Size = Size.Big,
                DistinguishingFeatures = "Pointed teeth and ears, claws, blue fur",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Avengers, TeamNames.XMen, TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "Despite his obvious brilliance, Hank McCoy was expelled from college because of his mutant status. Shortly thereafter, he was recruited by Professor Xavier to become a founding member of the X-Men.",
                    "Hank was born with super-strength, agility and intelligence, but he acquired his trademark blue fur during a brief sabbatical from the X-Men, when he ingested an experimental serum designed to activate latent mutations. He’s temporarily morphed into other forms since, but he always seems to return to the bushy blue Beast he’s best known as.",
                    "Hank is widely regarded as one of the world’s greatest scientists and super heroes. In recent years, he’s taken on more of a leadership role among the X-Men and mutant society at large, becoming the leader of X-Force."
                ],
                Personality =
                [
                    "Though something of a hothead in his youth, Hank developed a more stringently logical demeanor. If anything, the modern Beast has become impersonal, seeing his allies more as assets than people.",
                ]
            }
        },
        new()
        {
            Name = "Beast (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 2, vigilance: 2, ego: 2, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Jump1),
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
            Biography = new Biography
            {
                RealName = "Henry Philip “Hank” McCoy",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [402],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Covered with blue fur",
                Size = Size.Big,
                DistinguishingFeatures = "Pointed teeth and ears, claws, blue fur",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "Hank McCoy, alias the Beast, was one of the first mutants Professor X assembled to form the X-Men. Initially, he merely had enlarged hands and feet to go with his enhanced strength and agility, but eventually, his mutation progressed, giving him a blue-furred, bestial appearance. While many of his teammates have since come and gone, the Beast remains a stalwart with the team, and is the X-Men’s resident scientist. Shortly after Jubilee joined the team, he was captured during a raid on a Sentinel factory and imprisoned for a time. After the X-Men saved Senator Robert Kelly from assassination by the rogue Sentinels, he was released with a full pardon and became an important public advocate for mutant rights. He briefly romanced a patient of his, Carly Crocker, despite opposition from her bigoted father. She was subsequently kidnapped by the anti-mutant hate group the Friends of Humanity; although an enraged Hank saved her, he ended their relationship before she could be endangered again. Recently, he began developing a relationship with Trish Tilby, but they drifted apart after she conducted a hostile interview with his teammate Cyclops; he later had to battle her when Bastion transformed her into a cybernetic Prime Sentinel.",
                ],
                Personality =
                [
                    "Despite his fearsome appearance, the Beast is a gentle soul. He is a brilliant scientist in a number of different disciplines and maintains the X-Men’s advanced technology, including the Danger Room and the Blackbird jet. He is also extremely well-read and frequently peppers his speech with quotes from classical literature. He prefers to fi nd nonviolent solutions to the X-Men’s problems; however, when he is called upon to fight, he does so with ferocity. He is a true believer in Xavier’s dream and is beloved by his teammates.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Beetle",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 2, ego: 3, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection, isTech: true),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalPush),
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
                RealName = "Janice Lincoln",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [135],
                WeightReminder = "205 lbs. (in battle suit)",
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Lawyer],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.SinisterSix, TeamNames.Syndicate],
                Base = "New York City",
                History =
                [
                    "Unsatisfi ed with life as a lawyer, Janice Lincoln resolved to follow in the footsteps of her father, Tombstone, and become a super-powered criminal. In exchange for help with a legal dispute, Baron Zemo commissioned a powerful beetle-themed battle suit for Lincoln, based on the outfi t worn by the original Beetle, Abner Jenkins.",
                    "Although Lincoln’s initial impulse was to try battling some of Baron Zemo’s enemies—primarily Captain America (Steve Rogers)—she quickly gravitated back toward her home in New York City and its foremost defender: Spider-Man (Peter Parker). After testing the waters with Boomerang’s incarnation of the Sinister Six, she formed her own organization, a Syndicate made up entirely of young, up-and-coming female villains like herself. Ironically, the Syndicate’s fi rst mission was to capture Boomerang, and while searching for the sharpshooter, Lincoln fell in love with his roommate, Randy Robertson.",
                    "After a whirlwind romance, Lincoln was on the verge of giving up the villain life and marrying Robertson when their wedding ceremony was attacked and Randy was injured in a subsequent attack. These assaults on her loved ones led Janice to become embroiled in a gang war that drove a wedge between her and Tombstone, who would have killed her if not for the intervention of Spider-Man.",
                ],
                Personality =
                [
                    "Though Janice Lincoln identifi es as a fiercely independent and strongheaded woman, she has a nasty habit of contorting herself to conform to what she thinks other people want from her. Despite the fact that Tombstone explicitly warned her away from a criminal life, she became a super villain, in large part because she believes that’s what he secretly wants from her.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Beta Ray Bill",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 3, resilience: 8, vigilance: 2, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin, reminder: "2"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage, reminder: "via Twilight Sword"),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "regular Korbinite form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped, reminder: "as Thor"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Twilight Sword"),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Twilight Sword",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.AsgardianTransformation),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "On a Fantastic success, the Twilight Sword can count as a fire attack rather than a sharp attack."),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty4),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy2),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier Bonus: +2."),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2)
                    ],
                    Restrictions =
                    [
                        "Can only be used by the worthy.",
                        "Carried"
                    ],
                    PowerValue = 7,
                    PowerValueReminder = "Beta Ray Bill already has Mighty 2 and Sturdy 2, so for him, the Power Value is 3.",
                    MeleeDamageModifier = 2,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Beta Ray Bill",
                Heights = [new() { Feet = 6, Inches = 7 }],
                Weights = [480],
                Gender = Gender.Male,
                Eyes = "No irises",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Bright orange skin, horse-like head",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.Alien, OriginName.HighTechCybernetics, OriginName.MythicAsgardian],
                Teams = [TeamNames.Annihilators, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Years ago, the demonic Surtur of Muspelheim unleashed his minions upon the planet of Korbin. Korbinite civilization was annihilated, and the few who survived fled across the cosmos.",
                    "Korbinite scientists performed torturous experiments upon their own people, hoping to create a champion capable of fi ghting the demons. Only one subject named Bill survived the transformation, but even his newfound powers were not enough to hold back the demons.",
                    "All hope was lost until a chance encounter with Thor Odinson led Bill into an alliance with Asgard. Impressed by Bill’s strength, Odin himself granted the Korbinite a hammer with a set of powers to match Thor’s own. Together, Bill and Thor pushed the demons back into Muspelheim.",
                    "Much later, Bill invaded Muspelheim and defeated Surtur once and for all. He abandoned Odin’s gifts and claimed Surtur’s Twilight Sword as his own. Although he is still revered in Asgard, Bill now focuses most of his energies on caring for his people."
                ],
                Personality =
                [
                    "Beta Ray Bill’s noble and serious demeanor matches well with those of the gods of Asgard. The Asgardians accept him as one of their own—more so than his fellow Korbinites, who are largely frightened by his monstrous form. Bill can use his sword to disguise himself as a regular Korbinite, and he tends to stay in this disguise when among his own.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Bishop",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 4, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
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
                RealName = "Lucas Bishop",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [275],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Tattoo over right eye in the shape of the letter “M”",
                Occupations = [OccupationName.Adventurer, OccupationName.Investigator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GreatCaptainsOfKrakoa, TeamNames.XMen, TeamNames.XSE],
                Base = "Krakoa",
                History =
                [
                    "Lucas Bishop grew up in a dark possible future (Earth-1191) driven by anti-mutant sentiments. He spent most of his childhood in a mutant concentration camp, watching a combination of poverty and disease slowly consume the lives of his loved ones.",
                    "In Bishop’s preteen years, a bloody rebellion allowed him to escape the camp. He spent the next several years lying low, and by the time he was an adult, the law had loosened up enough to allow mutants to live freely, albeit in squalor.",
                    "Desperate for money, Bishop joined up with the X.S.E., a police squad of mutants charged with arresting powerful mutant criminals. During the pursuit of one such criminal, he stepped through a wormhole and became trapped on Earth-616.",
                    "In the hope of preventing his dark future from coming about, Bishop joined up with Earth-616’s X-Men. He’s been with them ever since.",
                    "On Krakoa, Bishop was made the Captain Commander, the person in charge of Krakoa’s Great Captains and for overseeing the island-nation’s military efforts."
                ],
                Personality =
                [
                    "Bishop enjoys fighting and giving orders but not much else. While he has a reputation as a loner, he has a close and complicated relationship with at least one person: Hope Summers.",
                    "Bishop used to believe that Hope Summers was the legendary villain responsible for making his home reality so awful. He spent ages trying to kill both her and her caretaker, Cable (Nathan Summers). Although Bishop has since seen the error of his ways and tried to make amends, his relationships with Hope and Cable remain strained."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Bishop (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 4, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
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
                RealName = "Lucas Bishop",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [275],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Tattoo over right eye in the shape of the letter “M”",
                Occupations = [OccupationName.Adventurer, OccupationName.Investigator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "Varies",
                History =
                [
                    "In Lucas Bishop’s timeline, Sentinels have ravaged humans and mutants alike by the year 2055. Despite being a mutant himself with the power to absorb energy, Bishop worked as a bounty hunter for the Sentinels, hunting down renegade mutants. However, when the Sentinels turned on him, he defected and joined a band of mutant rebels inspired by the legendary X-Men. The rebels sent him to the past to prevent Gambit from betraying the X-Men and assassinating Senator Robert Kelly, leading to a worldwide war on mutants. Once he arrived in the past, he eventually learned the real assassin was the shape-shifting Mystique disguised as Gambit; even though Kelly was saved, Bishop returned to find his future unchanged. Now occasionally joined by his sister, Shard, he made subsequent jaunts to the past to prevent the Friends of Humanity from releasing a deadly plague, to stop Trevor Fitzroy from assassinating Charles Xavier before he could form the X-Men and to defeat Apocalypse before he could remake reality in his own image. Later, he returned to the present for some time to adventure with the X-Men. When Mister Sinister infected Cyclops’ infant son, Nathan, with a Techno-Organic virus, Bishop returned to his future with the boy, hoping that a cure could be found. Sometime later, after the X-Men disappeared following a battle with Bastion, Bishop returned to the present and joined forces with Forge to hunt the time-lost mutants down.",
                ],
                Personality =
                [
                    "Bishop is a harsh man from a harsh time. He is a battle-hardened, experienced warrior. Although he was initially self-centered enough to side against mutantkind, he was eventually swayed to fight for what’s right. Inspired by the legendary X-Men of the past, Bishop fi ghts valiantly for mutantkind, knowing all too well what horrors could be unleashed if they fail.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Black Ant",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 4, vigilance: 3, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                    IsTech = true
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
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.ResizeObject),
                        powerSelector.GetPower(PowerNames.Shrink4),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, specialization: "bugs"),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Eric O’Grady",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "normally 5'9\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "normally 168 lbs.",
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechAndroid, OriginName.HighTechPymParticles],
                Teams = [TeamNames.LethalLegion, TeamNames.SecretAvengers],
                Base = "Mobile",
                History =
                [
                    "During a brief period when the second Ant-Man (Scott Lang) was thought dead, S.H.I.E.L.D. hired the original Ant-Man (Hank Pym) to create a new version of the hero. The organization planned to hold tryouts among their top members to pick a new Ant-Man based on their performance, but before S.H.I.E.L.D. could make a decision, an unscrupulous low-level agent named Eric O’Grady stole Pym’s Ant-Man suit and ran off, dreaming of evading the law while achieving fame and fortune as an independent adventurer. He ultimately failed on both counts, though after he was captured and brought back home, S.H.I.E.L.D. decided to let him keep being Ant-Man.",
                    "During a mission with the Secret Avengers, O’Grady was killed by a race of evil androids known as the Descendants and secretly replaced with a robotic replica. Going under the codename Black Ant, this evil version of O’Grady attempted to wipe out the Avengers, but before he could, Valkyrie (Brunnhilde) uncovered the deception and destroyed him.",
                    "Black Ant was later rebuilt by the Mad Thinker and briefly enlisted into the Hood’s Illuminati before being betrayed by his own team and once again destroyed. He later reappeared in the employ of Taskmaster, working as a mercenary."
                ],
                Personality =
                [
                    "Even when he was a human, Black Ant was a creature of greed and opportunism driven primarily by his hedonistic impulses. He struggles with his existence as a Life-Model Decoy and grows increasingly disillusioned with his lot in life every time his body is rebuilt.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Bolt",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 8, resilience: 4, vigilance: 4, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Mute, reminder: "Cannot speak without activating sonic blasts."),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.ElementalPush),
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
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Blackagar Boltagon",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.HouseOfAgon, TeamNames.UniversalInhumans],
                Base = "Attilan",
                History =
                [
                    "Blackagar Boltagon was born into the House of Agon, the Inhuman royal family. Because he was exposed to the Terrigen Mists while still in utero, his powers surpass those of most Inhumans.",
                    "Black Bolt cannot speak normally. He has other methods of communicating, but any vocal noise he makes becomes a massive sonic blast. He was kept in a soundproof chamber for most of his youth, only being released shortly before he took the mantle of Inhuman monarch.",
                    "Black Bolt’s primary goals have always been to preserve the Inhuman homeland and to foil those who would usurp his rule. No one has been a more regular threat to Black Bolt than his own brother, Maximus, a madman who often would rather the Inhumans be wiped out by the Kree than allow Black Bolt to stay on the throne."
                ],
                Personality =
                [
                    "While generally considered by his people to be a benevolent ruler, Black Bolt can come off as a bit aloof, especially to non-Inhumans.",
                ]
            }
        },
        new()
        {
            Name = "Black Cat",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 4, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Luck,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EvilEye),
                        powerSelector.GetPower(PowerNames.JinxYou),
                        powerSelector.GetPower(PowerNames.JinxYouAll),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
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
                    ],
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
            ],
            Biography = new Biography
            {
                RealName = "Felicia Sara Hardy",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Criminal],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining],
                Teams = [TeamNames.HeroesForHire, TeamNames.ThievesGuild, TeamNames.SecretDefenders],
                Base = "New York City",
                History =
                [
                    "Felicia Hardy’s father, Walter, might have been a legendary thief, but to her, he was never anything more than a good dad. So when a group of corrupt cops threw him in jail for a crime he didn’t actually commit, Felicia flew into a rage. She spent the rest of her youth tirelessly preparing to break her father out, training her body and mind in the ways of a master thief and even augmenting her body with a cybernetic probability generator. As a tribute to her father’s life as a cat burglar, she equipped herself with a pair of sharp claws and took on the codename Black Cat.",
                    "When Hardy fi nally did break her father out of prison, Spider-Man (Peter Parker) tried to stop her. However, after he realized that Walter Hardy was on death’s door, Parker allowed Felicia to take her father home. He tried to apprehend her after the fact, only for her to slip away.",
                    "This chance encounter sparked a long relationship between the cat burglar and the web-slinger. In the coming years, they became many things to each other. Sometimes, they were enemies. Sometimes, they were partners. Sometimes, they were lovers. No matter the circumstances, they were always important to each other.",
                    "Currently, the pair are just good friends. Black Cat is an independent crimefi ghter, but she’s always willing to help out Spider-Man, and she’s even had adventures with another ex of his: Mary Jane Watson."
                ],
                Personality =
                [
                    "Black Cat is best known for the flirty, femme fatale persona she puts on whenever she’s interacting with Parker, but her playful, blasé exterior belies a deeply empathetic, if not heroic, interior. She has been a thief for the good of others just as often as she’s been a thief for herself.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Black Dwarf",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 1, resilience: 6, vigilance: 4, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Thanos’ army)"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureItem, specialization: "Ax (acts as sword)"),
                tagSelector.GetTag(TagNames.Villainous),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HitAndRun),
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
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump2),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Black Dwarf",
                Heights = [new() { Feet = 7, Inches = 3 }],
                Weights = [669],
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "None (brown tendrils on head resemble hair)",
                Size = Size.Big,
                DistinguishingFeatures = "Bright yellow eyes, scaly skin, spiked fists, sharpened teeth, tendrils for hair",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.BlackOrder],
                Base = "Mobile",
                History =
                [
                    "Despite being the largest and angriest member of Thanos’ Black Order, Black Dwarf may have the worst track record of all the Titan’s generals. During Thanos’ last invasion of Earth, Dwarf led a costly and ultimately pointless campaign into Wakanda. In an attempt to make up for his mistakes, Dwarf tried to take on the Avengers all on his own. He was almost immediately killed.",
                    "Months later, Dwarf was resurrected, long after Thanos himself had perished. With nowhere else to go, Dwarf returned to the company of his old comrades in the Black Order.",
                    "These days, the Order works as mass killers for hire. They take any job that pays and at least piques their interest."
                ],
                Personality =
                [
                    "Black Dwarf cares little for what may be technically correct on a tactical level. If the other members of the Black Order are scalpels, Dwarf is a hammer. He overwhelms his enemies with raw strength, attacking with reckless and joyful abandon.",
                    "Although he may have a short temper, Dwarf is not, as many have assumed him to be, stupid. Like all of Thanos’ former generals, he speaks in a sophisticated and formal manner and maintains a subtle air of superiority at all times."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Knight",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 3, vigilance: 4, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.MagicItemReliance),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Ebony Blade"),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
             IconicItems =
            [
                new IconicItem
                {
                    Name = "Ebony Blade\r\n",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.BoltsOfBalthakk),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.DispelSpell),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty2),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.PowerSlider} (Blood Curse)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.SenseSupernatural),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.ShieldOfTheSeraphim),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Summonable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Unkillable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier bonus: +2."),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Blood Curse: If the user gets a Fantastic success on an attack with this weapon and causes bleeding, their powers are boosted. However, they also gain the Bloodthirsty trait. If they kill someone while Bloodthirsty, they lose their Heroic tag."),
                        powerSelector.GetPower(PowerNames.SenseSupernatural),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Menacing",
                        "Unkillable power usable only by descendants of King Arthur"
                    ],
                    PowerValue = 7,
                    MeleeDamageModifier = 2,
                    IsMagicItem = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Dane Whitman",
                Heights = [new() { Feet =6 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.Avengers, TeamNames.Defenders, TeamNames.SavageAvengers],
                Base = "Garrett Castle",
                History =
                [
                    "Centuries ago, the great wizard Merlin, having either forged or found the cursed Ebony Blade (stories differ), gifted the weapon to the one man he trusted to wield it: the loyal Sir Percival. True to his word, Percival faithfully executed the will of King Arthur as the brutal but noble Black Knight.",
                    "When Percival died, he passed the blade down to his descendants, and they onto theirs, and so on into the modern era, when it passed into the hands of the unscrupulous Nathan Garrett.",
                    "Though the blade rejected Garrett, he nonetheless took on the title of Black Knight and set out to seek fame and fortune with the Masters of Evil. Shortly thereafter, he sustained fatal injuries battling Iron Man (Tony Stark) and, having seen the error of his ways, used his final hours to transfer all his possessions to his nephew: a humble scientist named Dane Whitman. Determined to redeem his family’s name, Whitman took up the Ebony Blade and, in the guise of his uncle, infiltrated the Masters of Evil and destroyed it from within, earning himself a place of honor among the Avengers.",
                    "Since then, Whitman’s adventures have taken him to strange places all across time and space, leaving him little opportunity for a personal life. However, he recently reconnected with his long-lost daughter, Jackie Chopra, and he now shares with her the title of Black Knight."
                ],
                Personality =
                [
                    "Though his noble heart forces him to continue onward, Whitman does not actually like being the Black Knight. The burden of wielding the Ebony Blade, which constantly pushes him to commit terrible violence, causes him endless stress. To help keep himself levelheaded, he often speaks in an affected medieval accent.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Knights / Fenris Twins",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 2, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight1, reminder: "adjacent"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast, reminder: "adjacent"),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "adjacent"),
                        powerSelector.GetPower(PowerNames.ElementalPush, reminder: "adjacent"),
                        powerSelector.GetPower(PowerNames.ElementalRicochet, reminder: "adjacent"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            PowerNotes =
            [
                "The Fenris Twins are two mechanically identical characters. They can move separately, but several of their abilities work only when the twins are close enough to touch. These powers bear the label “(adjacent).”"
            ],
            Biography = new Biography
            {
                RealName = "Andrea and Andreas von Strucker",
                Heights = [new() { Feet = 5, Inches = 9 }],
                HeightReminder = "both",
                Weights = [],
                WeightReminder = "110 lbs. (Andrea), 165 lbs. (Andreas)",
                Gender = Gender.Varies,
                GenderReminder = "Female (Andrea), Male (Andreas)",
                Eyes = "Blue (both)",
                Hair = "Blond (both)",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Mutant, OriginName.WeirdScience],
                Teams = [TeamNames.HellfireTradingCompany, TeamNames.Hydra],
                Base = "Krakoa",
                History =
                [
                    "Decades ago, fascist leader Baron von Strucker forced his pregnant wife to undergo experimental treatments developed by the brilliant but evil Dr. Arnim Zola. The genomes of the twin embryos were modifi ed to include a number of unusual genes, including the X-Gene of mutant fame.",
                    "Andrea and Andreas von Strucker displayed few symptoms of this meddling at birth, but as young adults their powers began to emerge. The twins could fl y, perform incredible feats of acrobatics, and shoot blasts of energy from their fi sts—but only while in direct contact with each other.",
                    "Under the codename Fenris, the twins went into business for themselves as super-powered mercenaries. They have spent most of their adult lives menacing the rest of mutantkind, attacking super heroes for profi t and pleasure.",
                    "Although the Fenris Twins were granted permission to live on Krakoa—despite the artifi cial nature of their mutant status—most other mutants do not regard them with respect. As the Black Knights of the Hellfi re Club, they act as personal bodyguards for the villainous Sebastian Shaw."
                ],
                Personality =
                [
                    "The Fenris Twins are almost comically spoiled. They grew up in the lap of luxury, their every whim attended to by a squadron of servants. From a young age, they were taught to understand that they were better than other people and to violently oppose any who gainsaid that idea.",
                    "Like their father, both of the Fenris Twins are committed fascists and white supremacists. However, their fi rst and greatest loyalty is to money. They do terrible things not out of a commitment to an ideology but out of a desire to maintain their opulent lifestyle."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Black Panther (Shuri)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 3, vigilance: 4, ego: 2, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Wakanda"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Black Panther’s Claws", isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
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
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Black Panther’s Claws",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.AntiMetal),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier bonus: +1."),
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
                RealName = "Shuri",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [127],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader, OccupationName.Scientist],
                Origins = [OriginName.HighTech, OriginName.Magic],
                Teams = [TeamNames.PantherCult],
                Base = "Wakanda",
                History =
                [
                    "As the lone daughter of the Wakandan royal family, Shuri was narrowly defeated by her brother, T’Challa, in a contest to determine the next Wakandan regent, the Black Panther. Although she had long dreamed of becoming the Panther, Shuri did not let her envy consume her. Instead, she set out to make a name for herself in her own right.",
                    "Shuri’s brilliant mind and natural combat skills make her a fighter on par with T’Challa. In times of national upheaval, she has temporarily accepted the title of Black Panther, but more often, she works as an advocate for the Wakandan people under her own name—and to great success. This profile, however, represents Shuri during periods when she has taken on the mantle of the Panther and the responsibility of defending her country in battle.",
                ],
                Personality =
                [
                    "Shuri sometimes resents the disproportionate amount of attention and power given to her brother, but her love for him and the Wakandan people outweighs all that. Eloquent, personable and incredibly sharp, she has proven herself an excellent leader.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Panther (T’Challa)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 3, vigilance: 4, ego: 2, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Killmonger"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Wakanda"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.Supernatural),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Black Panther’s Claws", isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AlwaysReady),
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
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                        powerSelector.GetPower(PowerNames.OperationsCenter),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Black Panther’s Claws",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.AntiMetal),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier bonus: +1."),
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
                RealName = "T’Challa",
                Heights = [new() { Feet = 6 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech, OriginName.Magic],
                Teams = [TeamNames.AgentsOfWakanda, TeamNames.Avengers, TeamNames.FantasticFour, TeamNames.PantherCult, TeamNames.Ultimates],
                Base = "Impossible City",
                History =
                [
                    "As the young heir of Wakanda, T’Challa went through a grueling series of tests to prove his worthiness to become the Black Panther and lead his nation, the most technologically advanced country on the planet. At one point, he lost the powers given to him as the Black Panther by the heart-shaped herb, but he regained them by pledging himself to the panther god Bast and becoming King of the Dead, ruler of the Necropolis under Wakanda.",
                    "In the years since his ascension to the throne, T’Challa has served as an astoundingly effective leader, not only for Wakanda but also for international super-teams like the Avengers. After introducing democracy to Wakanda in the form of a parliament that he oversaw as king, T’Challa suffered a series of public embarrassments and a brief spat with the Avengers that led to the parliament ousting T’Challa and abolishing the throne.",
                    "Though T’Challa is still a member of the Avengers, he’s been going on long away missions as of late, so as to avoid any awkward confrontations with his teammate and ex-wife, Storm."
                ],
                Personality =
                [
                    "T’Challa is serious, competent and regal. He takes nothing for granted, especially his responsibilities, the greatest of which is the welfare of his people. He has an unrivaled mind for tactics and can hold his own in a contest of wits with the smartest people on the planet.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Priestess",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 4, vigilance: 5, ego: 7, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExternalAwareness),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExternallyImmortal),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BrainDrain),
                        powerSelector.GetPower(PowerNames.SenseSupernatural),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.SummonPortal),
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
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Selene Gallio",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Variable",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic, OriginName.MutantExternal],
                Teams = [TeamNames.Externals, TeamNames.HellfireClub, TeamNames.QuietCouncilOfKrakoa],
                Base = "Krakoa",
                History =
                [
                    "Selene Gallio is one of the Externals, a group of naturally immortal mutants who share a mysterious psychic connection. She is a psychic vampire who sustains herself on the psionic energy of others. Any human can suffice, but telepaths taste the best.",
                    "Few details about Gallio’s early life have been confirmed, but her presence in the historical record goes back over 15,000 years. Her first appearance in the modern era dates back to when she turned up in Brazil, posing as a priestess to manipulate the people of Nova Roma—a long-lost Roman colony—into acting as her servants.",
                    "The New Mutants uncovered Gallio’s plot and drove her out of Brazil, leading her to develop a lasting grudge against them and the X-Men. In the years since, she’s spent most of her time working with various villainous organizations to bring the mutant heroes down.",
                    "Gallio did declare a temporary truce with her old enemies to obtain a place on Krakoa, but after being denied a spot on the ruling Quiet Council, she called the whole thing off and summoned a giant monster onto the island-nation. Thankfully, the Krakoans put a quick stop to her efforts. Later, she did manage to join the Quiet Council, replacing Mister Sinister.",
                ],
                Personality =
                [
                    "If Gallio ever had a heart, it was buried long ago beneath centuries of ruthless murder. The modern Gallio is a creature of pure ego who cares only about herself and advancing her own position in the world. She sees other sentient beings as little more than food, but sometimes she enjoys toying with them before devouring them.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Black Swan",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 4, vigilance: 6, ego: 3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Linguist, specialization: "English, various alien languages"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
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
                RealName = "Yabbat Ummon Turru",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [145],
                Gender = Gender.Female,
                Eyes = "Blue (glow red when using powers)",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "Unnaturally pale skin",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.BlackOrder],
                Base = "Mobile",
                History =
                [
                    "Yabbat Tarru was raised as the youngest princess of a strict and oppressive royal family on an alternate Earth where the stars never shine and the last vestiges of intelligent life in the universe have fled underground. As grim as her reality was, it took a significant turn for the worse when an army of interdimensional warriors known as Black Swans slaughtered all the people of her planet.",
                    "The leader of the invading army—secretly Doctor Doom—spared her from death, but only so that she too could one day become a Black Swan. The final remnants of Tarru’s world were swallowed up by an incursion, so with nowhere else to go, she assented to Doom’s demands and entered into his service.",
                    "Many years later, when Doom finally turned his army on Earth-616, Tarru took the opportunity to abandon him for another warlord: Thanos. Proving herself in battle against Doom, she quickly earned a position within the Mad Titan’s inner circle—the Black Order—and though Thanos was killed shortly after she joined the organization, she stuck with the Black Order for a time."
                ],
                Personality =
                [
                    "Unlike the rest of the Black Order, Swan is not wholly committed to Thanos or to his mission of mass murder. Her particular brand of evil emerges more from a place of nihilistic sorrow than bloodthirstiness. She seeks power because she believes it is the only way to protect herself from an uncaring and merciless universe.",
                    "Swan may maintain the self-superior air of an otherworldly princess, but her every word is tinged with insecurity and quiet melancholy. If any member of the Black Order can be reasoned with, it is her."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Tom Cassidy",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 2, vigilance: 2, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Evasion),
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
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Krakoa"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Thomas “Tom” Samuel Eamon Cassidy",
                Heights = [new() { Feet = 6 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.HellfireClub, TeamNames.XForce],
                Base = "Krakoa",
                History =
                [
                    "Tom Cassidy and his cousin Sean Cassidy grew up together in the Irish countryside. As boys, the two were inseparable, but as they entered their teen years, they began growing apart. They fought over women, money and anything else they could think of. Eventually, they split for good and set off on two very different paths in life.",
                    "Under the codename of Banshee, Sean became a member of the X-Men. Tom, conversely, joined the Brotherhood of Evil Mutants as Black Tom Cassidy.",
                    "Black Tom and Banshee spent the next several years floating around within their respective social spheres, only ever meeting up to butt heads. It wasn’t until the day of Krakoa’s founding as a nation that the pair finally agreed to set their differences aside and work together again.",
                    "Black Tom’s powers grant him a special affinity with plant life and thus with the island of Krakoa itself. As the head of Krakoan security, he spends most of his time mentally and physically merged with Krakoa, helping the island detect intruders.",
                ],
                Personality =
                [
                    "Black Tom used to be the complete opposite of his cousin. Where Banshee was cool and collected, Black Tom was manic and chaotic. Where Banshee was responsible and kind, Black Tom was reckless and cruel.",
                    "However, time and distance have slowly brought the two closer in line with each other. Weighed down by years of adventuring, Banshee became less of an active hero, while Black Tom became less of an active villain. The modern Black Tom is a mostly reasonable guy, content with his position on Krakoa."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Black Widow (Natasha Romanoff)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 2, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Sneaky),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese, English, French, German, Japanese, Russian"),
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
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
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
                        powerSelector.GetPower(PowerNames.CombatSupport),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Natasha Romanoff",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [131],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.InfinityWatch, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Trained from a young age to be a Russian special agent, Natasha Romanoff defected to the United States after clashing with the Avengers. Since then, Natasha has served as a vital ally to many of the most powerful organizations on the planet, particularly S.H.I.E.L.D. and the Avengers.",
                    "Natasha spent much of her career as a solo mercenary, doing high-level black ops for paying clients. She tries to never take a job she believes to be immoral, but in the world of espionage, things are not always so clear-cut.",
                ],
                Personality =
                [
                    "Charming and cool-headed, Natasha’s personality makes her an excellent spy. A life of espionage has made her slow to trust others, but those closest to her consider her a good friend and an exceptional team leader.",
                ]
            }
        },
        new()
        {
            Name = "Black Widow (with Symbiote)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 3, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Chinese, English, French, German, Japanese, Russian"),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Widow’s Bite", isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
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
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "These blasts can count as either Electricity attacks or Force attacks."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: 10 spaces, Agility Damage Multiplier bonus: +1."),
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
                RealName = "Natasha Romanoff",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [131],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.SpecialTraining, OriginName.Symbiote],
                Teams = [TeamNames.Avengers, TeamNames.InfinityWatch, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Trained from a young age to be a Russian special agent, Natasha Romanoff defected to the United States after clashing with the Avengers. Since then, Natasha has served as a vital ally to many of the most powerful organizations on the planet, particularly S.H.I.E.L.D. and the Avengers.",
                    "Natasha spent much of her career as a solo mercenary, doing high-level black ops for paying clients. She tries to never take a job she believes to be immoral, but in the world of espionage, things are not always so clear-cut.",
                    "Recently, while investigating the corporate conglomerate Alchemax, Romanoff encountered an offshoot of the Venom symbiote named Sliver and willingly bonded with it, making the creature her new partner in crime. Though Sliver later disappeared while helping her defeat other Alchemax experimental symbiotes, this profile represents Romanoff and Sliver when they were together, at the height of their powers."
                ],
                Personality =
                [
                    "Charming and cool-headed, Natasha’s personality makes her an excellent spy. A life of espionage has made her slow to trust others, but those closest to her consider her a good friend and an exceptional team leader.",
                    "Her partner, Sliver, is soft-spoken and cooperative—unusually so for a symbiote. It’s a young organism with a lot to learn, and it looks up to Romanoff as an almost mother-like figure."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Black Widow (Earth-1610)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
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
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
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
                    IsBattlesuit = true,
                    Name = "Black Widow’s Battle Suit",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrage} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBlast} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Flight2),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty1),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy1),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Wallcrawling),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBlast, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                    Restrictions =
                    [
                        "Flashy",
                        "Worn",
                    ],
                    PowerValue = 6,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Natasha Romanoff",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.HighTechBattleSuit, OriginName.SpecialTraining],
                Teams = [TeamNames.Liberators, TeamNames.Ultimates],
                Base = "Mobile",
                History =
                [
                    "On Earth-1610, Natasha Romanov pretended to defect from Russia as part of a ploy to infiltrate S.H.I.E.L.D. and take down the organization from within. While working for S.H.I.E.L.D., she became partners with Hawkeye (Clint Barton).",
                    "At first, S.H.I.E.L.D. seemed impossible for Black Widow to destroy, but then came the Ultimates and, with them, chaos. Although initially enlisted as a backup member for the super-team, Romanov eventually wriggled her way onto the main roster, seduced Iron Man (Tony Stark) and convinced him to build her a battle suit. In the meantime, she funneled intel to an underground group of anti-imperialist terrorists called the Liberators.",
                    "In advance of a massive Liberator attack, Romanov helped turn the Ultimates against one another by murdering Hawkeye’s family and framing Captain America. When the Liberators’ coordinated assault launched, she tried to kill Iron Man too, but Stark managed to turn the tables and incapacitate her. The authorities arrested her and took her to a local hospital, where Hawkeye shot her down in cold blood.",
                    "Romanov has seemingly been dead for years now, but this profile represents her at the height of her powers, armed with a top-of-the-line battle suit."
                ],
                Personality =
                [
                    "Romanov is a die-hard Russian patriot who despises the United States and romanticizes the Soviet Union. She would do anything to restore her home country to what she perceives as its former glory.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Blade",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Monster),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Deceased),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Imageless),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Sword"),
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
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Eric Brooks",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [215],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Back tattoos, fangs",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MonstrousVampire, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.MI13, TeamNames.MidnightSons],
                Base = "Mobile",
                History =
                [
                    "Eric Brooks’ mother was attacked by a vampire while he was still in the womb. She died, but he survived, transformed into a half vampire.",
                    "As a dhampir, Brooks has all the strengths of a vampire, but none of their weaknesses. Aided by his powers, he underwent extensive training in swordplay and acrobatics, vowing to rid the world of the kind of monsters who killed his mother.",
                    "Blade has teamed up with other super heroes from time to time, but he’s never lost sight of the goal which has driven him his entire life. No one poses more of a threat to the vampire world than him."
                ],
                Personality =
                [
                    "Blade is a no-nonsense operator focused on his grim mission to rid the world of the undead. He can sometimes come across as cocky, but he can be warm to his allies and friends, though he has little time to make either.",
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Dhampir",
                        Description =
                        [
                            "As half-human/half-vampire, Blade does not have all of the powers of vampires, nor all their traits and tags."
                        ]
                    }
                ]
            }
        },
        new()
        {
            Name = "Blindspot (Sam Chung)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Daredevil (Matt Murdock)"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Steel pole (club)"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Invisibility),
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
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Samuel “Sam” Chung",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Black eyes with glowing blue irises",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.TheHand],
                Base = "New York City",
                History =
                [
                    "When Sam Chung was just a boy, he and his family emigrated from China to the United States. With a prodigious mind and a strong admiration for the super heroes of New York City, Chung spent much of his childhood working on designs for an invisibility suit.",
                    "As soon as he was able, Chung built his suit and began to fight crime on the streets of New York’s Chinatown under the codename Blindspot. Later, the super villain Muse tore out his eyes. They were eventually replaced with mystic counterparts, but his new glowing eyes have made maintaining his secret identity difficult.",
                ],
                Personality =
                [
                    "Chung is a bit of a loner and a cynic. His mentor, Daredevil, is one of the few people on Earth he genuinely admires.",
                    "As an undocumented immigrant, Chung displays trepidation around law-enforcement o¸ cers."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Blink (Earth-295)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 3, vigilance: 5, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Glibness),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Blink’s Displacement-Field Daggers"),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.BlinkBarrage),
                        powerSelector.GetPower(PowerNames.BlinkDefense),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportBlind),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportOther),
                        powerSelector.GetPower(PowerNames.TeleportTogether),
                    ],
                }
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Blink’s Displacement-Field Daggers",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Constructable),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.TeleportObject),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.TeleportOther),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/5, Melee/Agility Damage Multiplier Bonus: +1."),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportOther),
                    ],
                    Restrictions =
                    [
                        "Does no actual damage",
                        $"May use {PowerNames.TeleportObject} or {PowerNames.TeleportOther} hit with the Dagger."
                    ],
                    PowerValue = 3,
                    PowerValueReminder = "Blink already has Teleport Object and Teleport Other, so for her, the Power Value is 1.",
                }
            ],
            Biography = new Biography
            {
                RealName = "Clarice Ferguson",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "No pupils",
                Hair = "Purple",
                Size = Size.Average,
                DistinguishingFeatures = "Pointed ears, bright pinkish-purple skin and hair, several prominent facial markings",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Exiles, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Clarice Ferguson grew up in a mutant slave camp in the grim alternate future of Earth-295, a timeline known as the Age of Apocalypse. Sometime in her teenage years, her camp was liberated by her timeline’s X-Men, who allowed her to join their ranks.",
                    "As Blink, Ferguson spent some time working with those X-Men, but just as their Age of Apocalypse was coming to an end, she was sucked through a freak wormhole into a desolate place between universes. There, an emissary of a mysterious multiversal group called the Timebreakers offered to guide her and several other displaced heroes back to their home universes, but in exchange, he wanted help repairing a number of timelines the Timebreakers had inadvertently ruined.",
                    "Blink and the others agreed, forming the Exiles. She enjoyed their adventures together so much that she endeavored to keep the team going even after they were released from the Timebreakers’ service. The roster of the Exiles has changed a lot over the years, but to this day, Blink has consistently been their main leader."
                ],
                Personality =
                [
                    "Although Blink was a bit shy in her youth, she long ago grew into her own as a team leader. Today, she is capable and charismatic, both on and off the battlefield. She is a fearless commander, fully willing to confront even gods in the name of justice.",
                    "Unlike some team leaders, Blink is far from cold or unemotional. She considers her teammates in the Exiles to be her best friends in the world, and they do the same."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Blob",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 7, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                        powerSelector.GetPower(PowerNames.Wisdom),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.FlexibleBones1),
                        powerSelector.GetPower(PowerNames.SlipFree),
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
            Biography = new Biography
            {
                RealName = "Frederick J. “Fred” Dukes",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [510],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Unusually large and heavy",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.FreedomForce],
                Base = "Krakoa",
                History =
                [
                    "As with most mutants, Frederick Dukes’ powers began to manifest when he was in his early teens. Almost overnight, he grew from a spry young boy into a hulking mass of flesh and muscle. Shortly thereafter, he fled from home and joined the circus.",
                    "Under the pseudonym of “the Blob,” Dukes gained worldwide renown as a circus performer. His strange physique drew the attention of the newly formed X-Men, who correctly deduced that he was a mutant.",
                    "The X-Men approached Dukes and offered him membership in their organization, but uninterested in a life of heroism, he refused. To preserve their anonymity, the X-Men attacked Dukes and erased his memories of their existence.",
                    "This memory wipe did not last long. With the help of the Brotherhood of Evil Mutants, Dukes tried and failed to take his revenge on the heroes who messed with his mind.",
                    "Utterly defeated, Dukes returned to the circus. He spent the next several years bouncing between various jobs—and occasionally butting heads with the X-Men—before settling down in a quiet life on Krakoa.",
                    "Dukes currently works as the head bartender at the Green Lagoon on Krakoa. He has, for the most part, let go of his resentments toward the X-Men."
                ],
                Personality =
                [
                    "In his youth, Dukes was as much of a diva as a circus performer can be. He was arrogant and gruff, with a short vocabulary and an even shorter temper.",
                    "It took years of tribulation for Dukes to mature to where he is today. The modern Dukes is a thoughtful man and a great bartender, always willing to lend an ear or a helping hand. Many of those who live on Krakoa consider him a friend."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Blue Marvel",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 5, resilience: 6, vigilance: 3, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Neutronium"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Family"),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
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
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                        powerSelector.GetPower(PowerNames.Supernova),
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
            ],
            Biography = new Biography
            {
                RealName = "Adam Bernard Brashear",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Educator, OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.Ultimates],
                Base = "New York City",
                History =
                [
                    "Adam Brashear already had an extensive combat career as a Marine in the Korean War when he was blasted by an experimental machine designed to create a bridge to the Negative Zone. This accident made Adam into the Blue Marvel, one of the most powerful men on Earth, but it also turned his friend Connor Sims into Anti-Man, his nemesis.",
                    "Adam has been a major part of hero operations since the 1960s, but because of his status as an African American, his heroic deeds at the time were covered up. His identity was only revealed to the world recently, long after he had retired from adventuring to become a teacher. Now accepted by the wider world, Adam has become Blue Marvel once again.",
                ],
                Personality =
                [
                    "Despite a lifetime of discrimination weighing on his soul, Adam has always managed to be a loyal friend and a good teacher. His students consider him to be charming and personable.",
                ]
            }
        },
        new()
        {
            Name = "Boomerang",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 2, vigilance: 4, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Boomerang’s Boomerangs"),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Boomerang’s Boomerangs",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.ReturnsWhenThrown),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "Each boomerang the character throws can have a different elemental effect of their choice."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach/10, Melee/Agility Damage Multiplier Bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Flashy",
                        "Worn"
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Frederick “Fred” Myers",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.MastersOfEvil, TeamNames.SecretEmpire, TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Indefi nitely suspended from Major League Baseball for his part in a bribery scandal, star pitcher Fred Myers found new employment as a covert agent for a Hydra subsidiary known as the Secret Empire. The leaders of this enigmatic organization outfi tted Myers with a series of hightech prosthetics and boomerang- shaped grenades, turning him into a weaponized pitching machine.",
                    "Myers proved to be a capable secret agent, but after his disappointing showings against the Hulk and the Defenders, the Secret Empire released him from their service. In need of a new job, he attempted to garner fame throughout the underworld by taking down Spider- Man (Peter Parker), only to be roundly and repeatedly defeated by the web-slinger.",
                    "For the next several years, Myers bounced back and forth between mercenary organizations— some good, some bad—occasionally taking time off from work to try fi ghting Spider- Man again.",
                    "By offering his meager assistance to the Underground during Hydra’s takeover of the United States of America, Myers eventually found the cultural cachet he needed to insert himself into the Web- Head’s life fully, fi rst as Peter Parker’s roommate, then later as Spider-Man’s crimefi ghting partner. Although Boomerang ultimately betrayed Spider-Man to earn the Kingpin’s favor, he continued to harbor real feelings of friendship for both the web-slinger and his civilian persona. In fact, just a few months later, he sacrifi ced himself to save Spider- Man from the deadly grasp of Morlun. Fortunately for him, he was able to shake that off thanks to his friend the Shocker, the Resurrection Stone and the Venom War."
                ],
                Personality =
                [
                    "Boomerang’s long and largely unsuccessful career as a mercenary forced him to reconsider his greedy and self -centered behavior. This selfrefl ection did not quite turn him into a hero—at least, not until the day of his death—but for a while, it did make him a better, more thoughtful and more ethical criminal.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Brawn (Amadeus Cho)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 4, vigilance: 2, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Gamma Forms"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Amadeus Cho",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [117],
                Gender = Gender.Male,
                Eyes = "Black",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Green skin (while using powers)",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.AgentsOfAtlas, TeamNames.Champions],
                Base = "Mobile",
                History =
                [
                    "By the time Amadeus Cho was a teenager, he was being hunted by international organizations desperate to harness his abnormal intelligence. Forced into a life on the run, Cho fell into the occasional company of another roaming hyper-intelligent scientist—Bruce Banner (the Hulk)—and the two became fast friends.",
                    "When a radioactive meltdown threatened to turn Bruce into a nuclear bomb, Cho built a machine to transfer the excess radiation out of Bruce and into himself. The radiation imbued Cho with a sizable portion of the Hulk’s powers. For a while, Cho took up the title of Hulk himself, but in more recent days, he’s come to prefer the codename Brawn.",
                ],
                Personality =
                [
                    "Like many gamma mutates, Cho has struggled with anger issues, but compared to Bruce Banner, Cho is as cool as an ice cube. Cho’s super-intelligence is matched with an emotional immaturity that can land him in over his head in certain situations. Thanks to his Champions teammates and his brilliant sister, Maddy, Cho has begun to navigate the world more thoughtfully.",
                ]
            }
        },
        new()
        {
            Name = "Brood",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 1, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Brood fleet)"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.HiveMind),
                traitSelector.GetTrait(TraitNames.Infector, reminder: "Brood implantation, Queens only"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Venomous),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Flight1, reminder: "except for Queens"),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Varies (most lack individual identities)",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "typically around 8'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "typically around 350 lbs.",
                Gender = Gender.Female,
                Eyes = "Yellow",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Big, locustlike brown alien with many teeth and tentacles",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.AlienBrood],
                Teams = [TeamNames.LivingArmada],
                Base = "Mobile",
                History =
                [
                    "The first known Brood came to Earth-616 millennia ago, slipping in through a wormhole created by the death of another universe. The Kree Empire captured them and attempted to turn the insectoid creatures into living weapons for their fight against the rival Shi’ar Empire. The fleet did immense damage to the Shi’ar, but they refused to follow Kree orders. The innumerable Shi’ar ships and outposts the Brood captured spawned a new problem: the Brood Empire.",
                    "The Brood Empire’s endless quest for power ultimately led them to Earth and its mutant heroes, the X-Men. In an attempt to create super-powered mutant Brood, a Brood Queen captured several of the X-Men and implanted embryos inside them. Although the X-Men eventually defeated the Queen and removed her embryos, the Brood armada as a whole remained a threat.",
                    "In the years since, the Brood have made countless attempts to capture Earth and its heroes. Intervention by the new Brood king—Broo—led to a temporary armistice between the Brood and Earth, but no one knows how long this state of affairs can last.",
                ],
                Personality =
                [
                    "Brood embryos absorb the thoughts and memories of the people in whose bodies they spawn. Young Brood are driven almost entirely by instinct, while older and more experienced Brood often have minds on par with, if not greater than, humans.",
                    "Two desires unite all Brood: to feed, and to obey their biologically designated leader. Broodlings always obey their leader, even if it costs them their lives."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Bruce Banner",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 0, vigilance: 1, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "gamma forms"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Abomination"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Leader"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "gamma forms"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
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
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Robert Bruce Banner",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [128],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD, TeamNames.USHulkOperations],
                Base = "Mobile",
                History =
                [
                    "Bruce Banner was just a mild-mannered nuclear physicist until the day he stepped out onto a bomb-testing range to save a young man (Rick Jones) who had wandered onto the site. Jones escaped unharmed, but the bomb blasted Banner with gamma rays. The radiation should have killed him, but instead, he gained the ability to transform into the Hulk—an unstoppable monster brought out by the scientist’s own rage.",
                    "Highly powerful and just as unstable, the Hulk has been involved in more major international incidents than just about any super-powered person in existence. Some people consider him a hero. Others consider him a threat worth waging war over."
                ],
                Personality =
                [
                    "Banner suffers from dissociative identity disorder. Depending on the circumstances, he can manifest any one of a half dozen separate personalities, each with their own corresponding Hulk transformation. Banner’s default personality is cool, collected and deeply empathetic. The rest are all over the map. Some are impressively cunning, while others are more like angry children.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Bulldozer (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 3, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Ram"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                },
            ],
            Biography = new Biography
            {
                RealName = "Henry Camp",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [325],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Abandoned on a trash heap when he was just 2 days old, Henry Camp grew up in an orphanage. Following a dishonorable discharge from the U.S. Army, he turned to a life of crime. After being picked up on burglary charges multiple times, he was sentenced to an extended stay on Ryker’s Island.",
                    "In prison, Camp met Dirk Garthwaite, A.K.A. the villainous Wrecker. Along with a couple of other inmates, Camp helped Garthwaite escape from Ryker’s. In exchange, Garthwaite granted Camp and his compatriots a portion of his own super-powers. Together, they formed the super-villain group known as the Wrecking Crew, and they’ve been in each other’s orbits ever since.",
                    "At times when Henry Camp is not available, his daughter, Marci Camp, takes his place in the Wrecking Crew as the new Bulldozer."
                ],
                Personality =
                [
                    "Henry Camp’s outwardly cool and tough demeanor conceals an inner bitterness. He harbors a burning resentment toward the government, society and the world at large, stemming from how they all failed him his entire life. It is this resentment that drives him forward in his criminal activities.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Bullseye",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 4, resilience: 3, vigilance: 2, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Sniping"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Lester",
                Heights = [new() { Feet = 6 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Bull’s-eye scar on forehead",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining, OriginName.HighTechCybernetics],
                Teams = [TeamNames.DarkAvengers, TeamNames.FiskIndustries, TeamNames.TheHand],
                Base = "Hell’s Kitchen, New York City",
                History =
                [
                    "Beyond his first name, the world knows next to nothing about the man who became Bullseye. He trained for some period as a mercenary with the United States government, eventually resurfacing in New York as Bullseye, extortionist and killer for hire.",
                    "Hell’s Kitchen has long been Bullseye’s base of choice, regularly putting him into conflict with Daredevil. Besides the Kingpin himself, Bullseye may be Daredevil’s most dangerous nemesis. His superhuman ability to hit any target from any angle makes him a perfect match for the swift and acrobatic Man Without Fear.",
                ],
                Personality =
                [
                    "Bullseye is a madman who enjoys killing above all else. He’s generally not the type to be reasoned with, though he has been persuaded to cooperate",
                ]
            }
        },
    ];
}
