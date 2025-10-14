using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersH
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
            Name = "Hallow's Eve",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Skeptical),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
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
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.MagicMasks)
            ],
            Biography = new Biography
            {
                RealName = "Elizabeth Tyne (now mainly goes by Janine Godbe)",
                Heights = [new() { Feet = 5, Inches = 9}],
                Weights = [145],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.BeyondCorporation, TeamNames.BloodHunters, TeamNames.ForcesOfLimbo],
                Base = "New York City",
                History =
                [
                    "After suffering years of brutal abuse at the hands of her father, Elizabeth Tyne shot him dead and fl ed to Utah. Under the pseudonym of Janine Godbe (a name she has been using ever since), she got a job as a waitress at a small-time diner and started dating a handsome drifter named Ben Reilly. Godbe revealed her dark past to Reilly, and in exchange, he revealed his own origins as a clone of Spider-Man (Peter Parker).",
                    "Shortly thereafter, Godbe was kidnapped by another of Parker’s clones: Kaine. Reilly eventually saved her from Kaine’s clutches, but the whole incident shook her up so much that she decided to turn herself in to the police.",
                    "Years later, as a means of obtaining leverage over Reilly, the Beyond Corporation arranged for Godbe’s early release from prison. Together, Reilly and Godbe attempted to escape Beyond’s custody, but while Godbe got away clean, Reilly was captured and robbed of his memories, turning him into Chasm.",
                    "Despite Reilly’s unstable mind, Godbe stuck by his side. She helped him find refuge in the company of Madelyne Pryor, and in exchange, Pryor granted Godbe a mystic bag of masks, each of which imbues their wearer with unique super-powers. As the mysterious Hallows’ Eve, Godbe now spends her days adventuring alongside Reilly, helping to guide him back to his old heroic self."
                ],
                Personality =
                [
                    "Understandably, Godbe has a hard time trusting others. She would go to the end of the world and back for Reilly, but she cares little for anyone else. That said, she’s not a cruel person, and becoming Hallows’ Eve has allowed her to fi nd a place as a hero in her own right.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Hammerhead",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 4, vigilance: 3, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Ram"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
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
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable, isTech: true),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 5, Inches = 10}],
                Weights = [265],
                Gender = Gender.Varies,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Unusually large, flat and tough head",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.Maggia],
                Base = "New York City",
                History =
                [
                    "One night, mad scientist Jonas Harrow stumbled upon the body of a small-time Maggia enforcer who had been shot in the head and left for dead in an alleyway beneath a poster for an Al Capone movie. Sensing an opportunity to experiment, Harrow took the dying man back to his lab and reconstructed his cranium, replacing the gangster’s skull with ultra-hard steel.",
                    "Harrow’s subject awoke to find that he had forgotten nearly everything about himself— except for the fact that he wanted to be like Al Capone. Under the codename Hammerhead, he used his unbreakable skull to fi ght his way through to the upper echelons of the underworld. Soon enough, he became the head of his own Capone-style family.",
                    "Hammerhead’s rapid rise through the underworld drew the attention of Spider-Man (Peter Parker). Though the hardheaded gangster was rarely the web-slinger’s foremost concern, he and Hammerhead duked it out dozens of times over the subsequent years, typically in the midst of larger gang wars.",
                    "During one such war, Kingpin’s men riddled Hammerhead with bullets, pushing him once again to the brink of death. However, in exchange for some favors, Mister Negative not only saved Hammerhead’s life but agreed to pay for the gangster’s entire skeleton to be laced with adamantium.",
                    "The improved Hammerhead’s prospects soared— at least, for a little while. Along with most of the old Maggia leaders, Hammerhead was deposed from power during Tombstone’s recent takeover of the New York City underworld."
                ],
                Personality =
                [
                    "Despite having been born and raised in Russia, Hammerhead fashions himself and his organization after Italian crime families. He wears a pin-striped suit and talks with a stereotypical gangster accent.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Hand Ninja",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 0, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Snap Shooting"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SnapShooting),
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
                DistinguishingFeatures = "Bright red ninja outfits",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.TheHand],
                Base = "Japan",
                History =
                [
                    "The Hand is a cult composed entirely of dangerous ninja assassins, first formed in feudal Japan. Members of the Hand worship an elder god known only as the Beast. Manipulating the world from the shadows, they sow chaos wherever they roam.",
                    "For centuries, the Hand’s machinations have been opposed primarily by a rival ninja organization: the Chaste. Many of the world’s most famous ninja have at some point joined forces with either the Hand or the Chaste.",
                ],
                Personality =
                [
                    "Members of the Hand are fanatical and dedicated killers. Behind closed doors, the leaders of the Hand give loud and raving religious sermons, but your average Hand ninja is a professional— soft-spoken on the job and communicating only when absolutely necessary.",
                ]
            }
        },
        new()
        {
            Name = "Havok",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 3, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.HitTheDirt),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                        powerSelector.GetPower(PowerNames.RallyOnMe),
                        powerSelector.GetPower(PowerNames.Scatter),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Alexander “Alex” Summers",
                Heights = [new() { Feet = 6 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.AvengersUnityDivision, TeamNames.Hellions, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a young boy, Alex Summers and his brother Scott were on their family’s small plane when it was attacked by an alien spacecraft. Alex got away largely uninjured, but Scott spent the next several years in a coma. The brothers were not reunited until they were well into their adult years. By that point, Alex had become a budding geophysicist, while Scott had become Cyclops, the leader of the X-Men.",
                    "Despite his desire to live a normal life, Alex increasingly was drawn further from his studies and closer to the mutant society his brother inhabited. Soon enough, Alex displayed powers of his own—powers that mirrored those of his brother.",
                    "Alex spent the next several years, on and off, as backup for Scott and the other X-Men. He’s fully capable of taking Scott’s place as team leader, but he prefers to spend most of his time in the background and let his brother handle the more serious threats.",
                    "Following the founding of Krakoa, Alex agreed to take on a supervisory role with the Hellions, a group composed largely of former super villains."
                ],
                Personality =
                [
                    "Unlike his brother, Alex has never felt he was meant for super-heroics. He would like nothing more than to live a quiet life in the countryside with his loved ones, but his obligations to the world—and to his brother—have kept him from achieving that dream.",
                    "At this point, Alex has come to accept that adventuring will be a permanent aspect of his life, but he’s not always happy about it. He’s currently in a long-term relationship with Madelyne Pryor (A.K.A. the Goblin Queen)."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Hawkeye (Clint Barton)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 2, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AuditoryIssues),
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
                        powerSelector.GetPower(PowerNames.Accuracy3),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Hawkeye’s Trick Quiver", isTech: true),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
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
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Hawkeye’s Trick Quiver",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Toolkit),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "Each arrow the character shoots can have a different elemental effect of their choice."),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 1,
                }
            ],
            Biography = new Biography
            {
                RealName = "Clinton Francis “Clint” Barton",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Entertainer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.Thunderbolts],
                Base = "Brooklyn, New York City",
                History =
                [
                    "After his parents were killed in a tragic car accident, Clint Barton ran away to join the circus. Naturally talented, he quickly made a name as Hawkeye, one of the premier archers. Barton might have stayed a performer into his old age if a chance encounter hadn’t brought Iron Man to his circus. Inspired by the hero’s exploits, Barton created a costume and began fighting crime as Hawkeye.",
                    "Although Barton sometimes operates solo, he’s best known for his work with the Avengers. After years of such adventures, he trained and mentored Kate Bishop, the second Hawkeye.",
                    "This profile represents the original sharpshooting Avenger at the height of his powers, fully decked out with a quiver of trick arrows."
                ],
                Personality =
                [
                    "Clint Barton is well aware that his lack of super-powers places the upper limits of his abilities well below those of most super heroes. He sometimes puts on an arrogant attitude to cover his insecurities. Barton can be led astray by his passions, but his conscience always brings him back to the fight for justice.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Hawkeye (Earth-1610)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 2, vigilance: 4, ego: 0, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bow and arrow (acts as pistol)"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2, isTech: true),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1, isTech: true),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
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
                        powerSelector.GetPower(PowerNames.Headshot),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Clint Barton",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining],
                Teams = [TeamNames.SHIELD, TeamNames.Ultimates],
                Base = "Mobile (Earth-1610)",
                History =
                [
                    "At some point in his youth, Clint Barton got involved in a government Super-Soldier Program that gave him cybernetic eyes capable of perceiving targets from miles away. Though the implants were an unadulterated success, the program decided to cut Barton loose and move on to other attempts.",
                    "In need of new employment, Barton used his enhanced eyes to become a world-renowned Olympic archer. Then, at the height of his fame, a mysterious incident landed him on death row for murder.",
                    "To avoid execution, Barton joined S.H.I.E.L.D., where he became partners with the former Russian spy Black Widow (Natasha Romanov). The pair worked together for years and eventually joined S.H.I.E.L.D.’s super-team, the Ultimates.",
                    "Unfortunately for Hawkeye, Black Widow’s true loyalties were to her homeland. In an attempt to dismantle the Ultimates from within, she attacked Hawkeye in his home and framed the assault on Captain America. Barton narrowly made it out of the encounter alive, but his wife, Laura, and their three young children—Callum, Lewis and Nicole—were all killed.",
                    "Hawkeye later tracked Black Widow down and shot her dead, but revenge brought him no solace. He spent the next several months taking on increasingly dangerous and reckless assignments, hoping he’d get himself killed. Eventually, enough time passed for Hawkeye to return to his usual duties and even to accept a new Black Widow (Monica Chang) as part of the Ultimates, but the loss of his family still haunts him every second of the day."
                ],
                Personality =
                [
                    "Though not entirely humorless, Clint Barton is a far darker person than his freewheeling Earth-616 counterpart. He’s fought in multiple wars, and he’s a master of black ops.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Hawkeye (Kate Bishop)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Hawkeye (Clint Barton)"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bow and arrow"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
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
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Katherine Elizabeth “Kate” Bishop",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Investigator],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.WestCoastAvengers, TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "When Kate Bishop was a young girl, she was kidnapped by a super villain named El Matador. After being rescued by the Avengers, she developed an abiding admiration for the team, especially Hawkeye (Clint Barton), who fought for justice despite his lack of super-powers.",
                    "Bishop decided to follow in Hawkeye’s footsteps. As a teenager, she adopted Hawkeye’s codename and began fighting crime as a member of the Young Avengers, with whom she has had numerous adventures. In the years since taking on the codename Hawkeye, she has worked several times with the original Hawkeye, who has made her his o¸ cial protege, and she even took over ownership of his dog, Lucky. She recently started her own detective agency: Hawkeye Investigations.",
                ],
                Personality =
                [
                    "Despite her outwardly casual and sometimes flighty attitude, Bishop has a strong and determined sense of justice. She wouldn’t hesitate to put herself in harm’s way to save another, even if it risked certain death.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Headpool",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 4, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.MediaAwareness),
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.Exploit),
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wade Wilson",
                Heights = [new() { Inches = 11 }],
                Weights = [10],
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Decaying skull in a Deadpool mask",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DeadpoolCorps],
                Base = "Mobile",
                History =
                [
                    "The Wade Wilson of Earth-2149, Deadpool had a similar history to his Earth-616 counterpart until his Earth was infested with a zombie virus, transforming most of its inhabitants into the cannibalistic living dead. Deadpool succumbed to the virus himself, which robbed him of his healing factor. He was transported to Earth-616 via the Nexus of All Realities and fought the super-hero team the Command; during the battle, his body was destroyed, leaving him an undead head, later dubbed “Headpool.” He was imprisoned by the reality-monitoring organization A.R.M.O.R. but escaped with mystical zombie Simon Garth. He found that losing his body had cured his insatiable hunger for flesh. After nearly unleashing a worldwide zombie plague, Headpool was set adrift in a rowboat and washed up in the Savage Land, where Earth-616’s Deadpool found him. After a multiversal adventure with Deadpool, Headpool ended up in mad scientist Dr. Killcraven’s lab. Headpool talked one of Killcraven’s henchmen into equipping him with a mechanical skullcap with a miniature helicopter blade, allowing him to move through flight. Deadpool-616 then recruited him into the Deadpool Corps, a team of Deadpool variants that was sponsored by the Elders of the Universe and meant to protect the Multiverse. Instead, however, the Deadpool Corps became a spacefaring crew of mercenaries; eventually, the disappointed Elders sent them back to their home dimensions. Later, Headpool was microwaved to death by an agent of the Evil Deadpool Corps but was later resurrected by the reality-manipulating Killville.",
                ],
                Personality =
                [
                    "Headpool has the same mordant sense of humor and flippant attitude as his Earth-616 counterpart; due to the zombie virus and the loss of his body, however, he is even more unhinged and prone to nonsensical rambling.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Hela",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 4, resilience: 6, vigilance: 3, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.Worshipped),
                tagSelector.GetTag(TagNames.Villainous),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.SummonPortal),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimeTravel),
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
            ],
            Biography = new Biography
            {
                RealName = "Hela",
                Heights = [new() { Feet = 7 }],
                Weights = [500],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Big,
                DistinguishingFeatures = "Covered by illusions, the left side of her body is dead",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.BlackOrder, TeamNames.GodsOfAsgard, TeamNames.HellLords],
                Base = "Hel",
                History =
                [
                    "The current incarnation of the Asgardian god of death was born under mysterious circumstances, half dead and half alive. Just as Thor must wield his hammer to operate at full power, Hela must wear her green cloak lest she return to her half-dead state.",
                    "As the god of death, Hela has had a tumultuous relationship with her fellow Asgardians. She can kill even a god with her touch, so other Asgardians tend to avoid her company. Despite this, she rarely attacks healthy Asgardians, preferring to swoop in and reap the souls of the injured and dying.",
                ],
                Personality =
                [
                    "Though not above the occasional bit of queenly mercy, Hela’s actions naturally trend toward destruction. While she’s usually content scheming up ways to capture the souls of her fellow Asgardians, Hela has been known to commit mass murder upon regular people, often with help from powerful villains like Thanos or Loki.",
                ]
            }
        },
        new()
        {
            Name = "Hellcat",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 2, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
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
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Patricia “Patsy” Walker",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.Defenders, TeamNames.PatsyWalkerTempAgency],
                Base = "Brooklyn, New York City",
                History =
                [
                    "When she was just a teenager, Patsy Walker’s mother created a comic-book series based on her daughter’s exploits. The series was a huge success, and by the time Walker was 18, she was already a household name.",
                    "Despite her history, Walker had a greater interest in super heroes than teenage drama. A chance encounter led her to discover the Beast’s secret identity, which she used to leverage his assistance in becoming a super hero. Donning a battle suit once worn by the Cat (Greer Nelson), Walker became Hellcat. Aided by her suit, Walker underwent extensive martial arts training and joined the Defenders. More recently she’s been partnering directly with Iron Man.",
                ],
                Personality =
                [
                    "A star from a young age, Walker is a lot more media savvy than most super heroes. Highly charismatic, she can befriend just about anyone. Hellcat’s love life has frequently been marked by misfortune, but she always manages to stay brave and cheerful no matter the circumstances.",
                ]
            }
        },
        new()
        {
            Name = "H.E.R.B.I.E (Security Unit)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 3, resilience: 1, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Opti-Blaster (works like a regular pistol, but blinds the target on a Fantastic success)"),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                    IsTech = true
                },
            ],
            PowerNotes =
            [
                "Not all H.E.R.B.I.E. units are equipped with weapons. Such non-security units can fly but are otherwise no more powerful than an average civilian (see that profile in the Core Rulebook)."
            ],
            Biography = new Biography
            {
                RealName = "Humanoid Experimental Robot, B-type, Integrated Electronics",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 2'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 70 lbs.",
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Child-sized metallic robot with screen for a face",
                Occupations = [OccupationName.Educator, OccupationName.Scientist],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "The fi rst prototype H.E.R.B.I.E. was created by Mister Fantastic (Reed Richards) of the Fantastic Four to aid in the search for Galactus and to act as his personal laboratory assistant. HERBIE was designed to be smart, helpful and generally cheerful. Incredibly, he actually turned out to be all those things.",
                    "In fact, the H.E.R.B.I.E. project was such a success that Richards slowly began to produce more H.E.R.B.I.E.s. Within a few years, H.E.R.B.I.E. units were running almost all of the day-to-day activities at the Fantastic Four’s headquarters.",
                    "H.E.R.B.I.E. units sometimes accompany the Fantastic Four on their adventures across time and space. However, the average H.E.R.B.I.E.’s duties are far more pedestrian. For example, a specialized H.E.R.B.I.E. unit often acts as the personal caretaker to Richards’ two children, Franklin and Valeria."
                ],
                Personality =
                [
                    "For the most part, H.E.R.B.I.E. units are thoughtful and chipper. Built with a heroic spirit, they are quick to offer a hand in assistance to any who need one.",
                    "Some H.E.R.B.I.E.s, particularly those assigned to menial and boring tasks, harbor some resentment for their creator, but they rarely let it show. Only a select few H.E.R.B.I.E. units have ever chosen to leave the Fantastic Four behind."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hercules",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 7, vigilance: 2, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                        powerSelector.GetPower(PowerNames.SpinAndThrow),
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
                        powerSelector.GetPower(PowerNames.Jump2),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Hercules Panhellenios",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [325],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.MythicOlympian],
                Teams = [TeamNames.Avengers, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "As the illegitimate son of the Greek god Zeus and the Thebian princess Alcmena, Hercules’ early life was filled with trials and tribulations. Shunned by Zeus and under constant attack from the thunder god’s wife, Hera, his every day was a fight for survival. However, after Hercules completed twelve legendary labors, Zeus finally acknowledged his son and inducted the demigod into the Greek pantheon.",
                    "Having achieved his dreams, Hercules seldom returned to the mortal world—at least, not until the modern era, when the Enchantress brainwashed him into attacking the Avengers. Though Hercules eventually freed himself from her thrall and joined the Avengers in defeating her, Zeus nonetheless decided to punish his son by temporarily banishing him to Earth.",
                    "Eager for new adventures, Hercules took up with the Avengers and became one of the team’s most valued and beloved members. Though Zeus eventually allowed him access to Olympus again, Hercules returned to the Avengers on and off throughout the subsequent years.",
                    "Not long ago, the goddess Nyx destroyed Olympus and brought its inhabitants back to life as dark versions of themselves. As one of the only uncorrupted Olympians, Hercules joined the Guardians of the Galaxy in destroying this evil Olympus. He’s since returned to join the Avengers once again."
                ],
                Personality =
                [
                    "Hercules’ blustering playboy persona is born more out of feelings of inadequacy than a genuine desire to sleep around, though he did do plenty of that in his younger years. His more recent relationships have been driven more by a desire for genuine companionship, such as his current partnership with his teammate, Marvel Boy.",
                    "On the whole, the champion of Olympus is a courageous and empathetic man, and though he’s had a bit of a rivalry with Thor over the years, the two gods are more alike than different.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "High Evolutionary",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 4, vigilance: 5, ego: 1, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Levitation),
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    IsBattlesuit = true,
                    Name = "High Evolutionary’s Armor",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.Accuracy1}"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrier} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBlast} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalProtection2} (Energy)"),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.EnvironmentalProtection),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.HealingFactor),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty1),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy1),
                    ],
                    GrantedPowerReminders =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.ElementalBarrier, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBlast, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalBurst, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.ElementalProtection2, reminder: "Energy"),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                    Restrictions =
                    [
                        "Menacing",
                        "Worn",
                    ],
                    PowerValue = 8,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Herbert Edgar Wyndham",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [],
                Base = "Counter-Earth",
                History =
                [
                    "Herbert Wyndham’s genetics work was so far ahead of its time that his colleagues ostracized him from the world of respectable science, forcing him to take up residence in a remote research compound on Wundagore Mountain. Wyndham spent decades working tirelessly in his lab, engaging in all sorts of terrifying experiments, until—with some help from the Jackal (Miles Warren)—he finally arrived at his masterpiece: a treatment capable of artificially advancing the stature and intelligence of any creature.",
                    "Aided by a high-tech super-suit, Wyndham created the New Men: a race of intelligent humanoids fashioned from ordinary animals. Though many of these New Men later turned on him, Wyndham kept on with his experiments, going so far as to create an entire planetoid—Counter-Earth—just to contain his myriad creations.",
                    "Wyndham has modified his own genetic code several times, and his desire to spread his genetic treatments to the rest of humanity—whether they want it or not—has frequently brought him into conflict with super-teams like the Avengers. That said, he has often been an ally to the heroes of Earth and has played key roles in the development of multiple super heroes, including Adam Warlock and Spider-Woman (Jessica Drew).",
                ],
                Personality =
                [
                    "Herbert Wyndham’s brilliance is matched only by his ego. He believes that his research is the most important development in the history of humanity, if not the universe, and he’s not about to let trifling things like ethics and safety guidelines get in the way of his work.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Hit Monkey",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 2, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.DanceOfDeath),
                traitSelector.GetTrait(TraitNames.Small),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only make monkey noises"),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
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
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "None",
                Heights = [new() { Feet = 2, Inches = 5 }],
                Weights = [31],
                Gender = Gender.Male,
                Eyes = "Amber",
                Hair = "Gray",
                Size = Size.Small,
                DistinguishingFeatures = "Small Japanese macaque who o« en stands on two legs and wears a suit",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.MercsForMoney, TeamNames.STAKE],
                Base = "Mobile",
                History =
                [
                    "As a young macaque, Hit-Monkey grew up among a tribe of his species hidden deep within the mountains of Japan. Life was peaceful until, one day, a dying hit man stumbled into the tribe’s territory. Hit-Monkey demanded that the murderous man be cast back out into the snowy wastes, but the other macaques refused to listen. Determined to have his way, Hit-Monkey lashed out at the tribe’s leader, injuring him. As punishment, the leader sent Hit-Monkey into exile. On the same day that exile began, a group of hired mercenaries came to the mountainside, looking for the hit man. They slaughtered him—along with every one of the macaques protecting him.",
                    "Filled with rage upon discovering the fate of his tribe, Hit-Monkey took up the dead man’s weapons and destroyed the mercenaries. He then set out for vengeance upon the men who’d hired those killers.",
                    "In short order, Hit-Monkey had his revenge, but it brought him little solace, as he had no home to return to. To keep on living, he became a hit man himself.",
                    "In the years since, Hit-Monkey has taken on and defeated some of the best mercenaries on the planet, including Deadpool. Many consider him the greatest contract killer to ever live. The upper echelons of the underworld utter his name only in hushed whispers."
                ],
                Personality =
                [
                    "Although Hit-Monkey understands human speech, he cannot speak any human language. He can communicate only with normal simian grunts and screeches. He has a hair-trigger temper, and in the heat of battle, he all but perpetually screams.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Hive",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 1, resilience: 4, vigilance: 2, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only speak in eldritch gibberih"),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Hive",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "typically around 7'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "typically around 340 lbs.",
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Humanoid hive of parasitic organisms",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "The Hive is a living bioweapon, the result of experiments performed by Hydra researchers on some of the world’s deadliest creatures. These maniacal scientists sought to create a living monster that was also a physical representation of everything Hydra stands for. In the many-tentacled Hive, they found their champion.",
                    "Just like Hydra, the Hive is conniving, amoral and parasitic. It can survive only by regularly bonding with a host—that it takes over entirely—and feeding upon innocent people. If left isolated for an extended period, the Hive dissolves back down into its original form: a pathetic and squirming pile of prehensile appendages.",
                    "The Hive’s innate loyalty to Hydra as an organization is the only thing that keeps it in check. For high-ranking members of Hydra, the Hive has been known to sacrifi ce pieces of itself, merging with its allies in order to extend their lifespans."
                ],
                Personality =
                [
                    "Although the Hive is thought to be intelligent, it cannot speak any known human language. It can understand English, but its own speech consists of a garbled mess of undersea squeals and eldritch burbling. A few select members of Hydra have learned to decipher this language, and they serve as the Hive’s handlers.",
                    "The Hive needs to feed on a new human only once every few years, but it prefers to feast on a daily basis. It can bond with persons of any gender, but it tends to present as male."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hobgoblin",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 4, resilience: 4, vigilance: 2, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pumpkin Bombs (act as frag grenades)"),
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
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
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
            Biography = new Biography
            {
                RealName = "Roderick Kingsley",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Gray, formerly blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Tycoon],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "The first time that the Green Goblin (Norman Osborn) faked his death, he was unprepared. He rushed to flee the country, abandoning dozens of secret stashes of Goblin technology throughout New York City.",
                    "A ruthless but unsuccessful fashion designer named Roderick Kingsley discovered one of these stashes and decided to use the gear to further his career. Under the codename Hobgoblin, Kingsley embarked on a series of covert attacks against his biggest competitors.",
                    "Kingsley was careful. He employed multiple agents and body doubles, killing anyone who threatened to expose his identity. In the end, he was still unmasked and defeated by Spider-Man (Peter Parker).",
                    "Unable to return to life as a fashion designer, Kingsley threw himself wholly into the world of super-villainy. He and Spider-Man clashed again many times in the subsequent years, sometimes directly and sometimes through proxies like Ned Leeds. Despite the wall-crawler’s best efforts, Kingsley always managed to slip away and return to fight another day.",
                    "Many people have held the title of Hobgoblin, but Kingsley was the first and the most successful."
                ],
                Personality =
                [
                    "Roderick Kingsley may model himself after Norman Osborn, but he lacks Osborn’s mental instability. He is clever, conniving and, above all things, patient. In this way, he can often be a greater threat than Osborn himself.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Hood",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 1, vigilance: 3, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Invisibility),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
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
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Parker Davis Robbins",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.Illuminati],
                Base = "Mobile",
                History =
                [
                    "With a pregnant wife at home and an ailing mother in the hospital, Parker Robbins turned to a life of crime to make ends meet. Off a tip from his cousin, Robbins broke into a warehouse that was supposed to contain a large shipment of valuable foreign goods.",
                    "Robbins found no such riches. What he discovered instead was a summoning circle and a terrifying cloaked demon spawned from the depths of hell.",
                    "More out of panic than malice, Robbins riddled the demon with bullets. In a frenzy, he stole the creature’s clothes and made off into the night.",
                    "Only after the fact did Robbins realize that the garments had special powers. Using them, he could turn invisible, walk on air and even shoot bolts of lightning from his hands.",
                    "Under the codename of the Hood, Robbins set out to turn his newly found powers toward the pursuit of personal profi t. He found that he had a talent for villainy and, after a few rocky capers, his crimes began to pay for themselves. Today, the Hood oversees a crime syndicate worthy of the Kingpin himself."
                ],
                Personality =
                [
                    "Despite his many crimes, Robbins still sees himself as basically a good person, a misunderstood man of the people. He rarely fl aunts his wealth, stowing most of it away for the future benefi t of an infant son he hardly ever sees.",
                    "Largely estranged from his family, Robbins spends most of his time drinking heavily and skulking around his own gambling dens."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hope Summers",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 3, agility: 7, resilience: 4, vigilance: 7, ego: 5, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
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
                        powerSelector.GetPower(PowerNames.Accuracy4),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.FocusedStrike),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.Headshot),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoostPowers),
                        powerSelector.GetPower(PowerNames.BumpPower),
                        powerSelector.GetPower(PowerNames.ClonePowers),
                        powerSelector.GetPower(PowerNames.CopyAbility),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.DampenPower),
                        powerSelector.GetPower(PowerNames.ShutDownPowers),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Hope Summers",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [106],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.TheFive, TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As the first mutant to be born after M-Day, Hope Summers had a target on her back from the moment she opened her eyes. Her parents were killed just days after her birth, a fate from which only the intervention of Cable spared her. Cable and Hope spent the next several years on the run, avoiding potential assassins by hiding out in different points in the timestream. By the time the pair returned to the present, Hope had grown into a mature and combat-ready teenager.",
                    "After taking on the power of the Phoenix, Hope gave it up to help repower the planet’s mutants. Later, as part of the Five, she helped establish Krakoa’s resurrection protocols, causing Earth’s mutant population to explode.",
                    "As the head of the Five, Hope was responsible for imbuing the spark of life into every resurrected mutant. From her seat on Krakoa’s governing Quiet Council, she represented the interests of the Five as a whole.",
                    "Hope’s legendary status as a life-giving mutant has led many mutants to treat her with reverence. The most fanatical of her admirers believe her to be the “Mutant Messiah,” a prophesied savior of all mutantkind."
                ],
                Personality =
                [
                    "Hope may be more mature and capable than normal human teenagers, but she is still just a teenager. She is energetic, instinctively rebellious and occasionally a bit rude. She dislikes being held up to other people’s standards and finds the religious cult that has formed around her to be more annoying than flattering.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Hulk (Professor Hulk)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 3, resilience: 6, vigilance: 3, ego: 2, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bruce Banner"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Abomination"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Leader"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "as Professor Hulk"),
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
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
                        powerSelector.GetPower(PowerNames.Jump3),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Robert Bruce Banner",
                Heights = [new() { Feet = 7, Inches = 6 }],
                Weights = [1150],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Green",
                Size = Size.Big,
                DistinguishingFeatures = "Large green Hulk form",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Bruce Banner was just a mild-mannered nuclear physicist until the day he stepped out onto a bomb-testing range to save a young man (Rick Jones) who had wandered onto the site. Jones escaped unharmed, but the bomb blasted Banner with gamma rays. The radiation should have killed him, but instead, he gained the ability to transform into the Hulk—an unstoppable monster brought out by the scientist’s own rage.",
                    "Highly powerful and just as unstable, the Hulk has been involved in more major international incidents than just about any super-powered person in existence. Some people consider him a hero. Others consider him a threat worth waging war over."
                ],
                Personality =
                [
                    "Banner suffers from dissociative identity disorder. Depending on the circumstances, he can manifest any one of a half dozen separate personalities, each with their own corresponding Hulk transformation. Banner’s default personality is cool, collected and deeply empathetic. The rest are all over the map. Some are impressively cunning, while others are more like angry children.",
                    "The Hulk has, for brief periods, managed to make peace with the disparate personalities warring inside his body and emerge as a single, stable person with the intelligence of Banner and most of the Hulk’s regular strength. This profile represents this uniquely balanced form, often referred to as Professor Hulk."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Hulk (Savage)",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 6, resilience: 9, vigilance: 6, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bruce Banner"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Abomination"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Leader"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "as Savage Hulk"),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
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
                        powerSelector.GetPower(PowerNames.Anger),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.Jump3),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Robert Bruce Banner",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "7' to 8' (depending on Anger levels)",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "1,000 to 1,400 lbs. (depending on Anger levels)",
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Green",
                Size = Size.Big,
                DistinguishingFeatures = "Massive green body",
                Occupations = [OccupationName.Adventurer],
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
                    "This Hulk, commonly referred to as the Savage Hulk or Child Hulk, is the one that most people know best, the one with the intelligence and emotional regulation ability of a toddler. If left alone or treated with a kind and gentle hand, this Hulk can be sweet and friendly. But make him angry, and he’ll fly into the sort of violent tantrum that tears worlds apart."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Hulkling",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage, reminder: "2"),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in true form"),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Theodore “Teddy” Kaplan-Altman (sometimes addressed as Emperor Dorrek-Vell)",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually around 6'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually around 170 lbs.",
                Gender = Gender.Male,
                Eyes = "Varies, usually blue",
                Hair = "Varies, usually blond",
                Size = Size.Average,
                DistinguishingFeatures = "Battle form usually has green skin",
                Occupations = [OccupationName.Adventurer, OccupationName.Leader],
                Origins = [OriginName.AlienKree, OriginName.AlienSkrull],
                Teams = [TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "During the original Kree/Skrull war, the Kree captain Mar-Vell was captured by the opposing forces and imprisoned in the royal palace, where he secretly sired a son with the Skrull princess Anelle. Fearing for the child’s life, the parents quietly ushered the boy away to Earth, leaving him in the hands of Anelle’s loyal servant Antalya.",
                    "Both Mar-Vell and Anelle died shortly thereafter, but Antalya took on the pseudonym of Mary-Jo Altman and raised the boy as Teddy Altman.",
                    "In Teddy’s teenage years, his alien biology caused him to develop powers, though he had no idea of their source. However, he was a huge fan of the Hulk (Bruce Banner), so he took on the codename Hulkling and joined his magically gifted boyfriend Wiccan in forming the Young Avengers.",
                    "Both the Kree and the Skrull governments sent agents who killed Antalya and attempted to force Hulkling into joining one of their empires, though once it became clear that he had the Avengers’ protection, both sides agreed to temporarily relinquish their claims on the boy.",
                    "Much later, Hulkling married Wiccan and joined the new Kree/ Skrull Alliance. He repelled their ancient rivals, the Cotati, and was crowned the Alliance’s ruler."
                ],
                Personality =
                [
                    "Equal parts sweet, sensitive and strong, Hulkling is the ideal ruler, not to mention husband.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Human Torch (Johnny Storm)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 4, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Flame form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "4 Yancy Street"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Fire"),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption, reminder: "Only work with fire"),
                        powerSelector.GetPower(PowerNames.Flight2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Jonathan Lowell Spencer “Johnny” Storm",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
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
                    "As an ambitious young test pilot, Johnny Storm was invited aboard an experimental space mission led by his older sister Sue’s boyfriend, Reed Richards. Shortly after takeoff , Storm and the crew were bombarded by cosmic rays, granting them each fantastical abilities. Together, they formed the Fantastic Four and vowed to use their new powers for the good of all humanity.",
                    "As the Human Torch, Storm has control over the forces of heat and flame. He can spontaneously burst into flames, shoot fire from his hands, fly and even assume an ultra-hot nova form in times of great need."
                ],
                Personality =
                [
                    "While good at heart, Johnny Storm has always been a natural hothead. It doesn’t help that as the youngest member of the Fantastic Four, he has a hard time being taken seriously by his fellow adventurers. Part of that might arise from the fact that he delights in teasing and playing pranks on his older and grumpier teammate, the Thing.",
                ]
            },
            Source = BookSource.FantasticFourFromTheDepths
        },
        new()
        {
            Name = "Hydra Agent",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
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
                DistinguishingFeatures = "The green-and-yellow Hydra uniform",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Secret",
                History =
                [
                    "Hydra has reportedly been around in one form or another since the days of Ancient Egypt, and it’s evolved into one of the most dangerous criminal organizations on Earth. The latest incarnation sprang from the ruins of World War II-era Germany and Japan, and various factions of it have wavered back and forth between organized crime and fascist power.",
                    "Hydra recruits agents all around the world. In public, they know each other by secret signals and whispers of “Hail Hydra.” In secret, they don their green-and-yellow uniforms and chant the Hydra oath: “Hail, Hydra! Immortal Hydra! We shall never be destroyed! Cut off one head, two more shall take its place! We serve none but the Master—as the world shall soon serve us! Hail Hydra!”",
                ],
                Personality =
                [
                    "Agents join Hydra for a number of reasons that usually boil down to money and power. They believe that Hydra can take over any organization or government, and they want to be on the winning side, no matter what they have to do to manage it. The Hydra uniform makes them mostly anonymous, fi tting well with their oath to replace one fallen agent with two more just like them.",
                ]
            }
        },
        new()
        {
            Name = "Hydra Officer",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
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
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
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
                DistinguishingFeatures = "The green-and-yellow Hydra uniform",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Secret",
                History =
                [
                    "Hydra tends to treat its lowest-level recruits (Hydra Agents) as cannon fodder, foot soldiers who can be spent or lost without hesitation. After all, there never seems to be a lack of disaffected people looking to join up with the fascist organization to do their part for world domination. As the Hydra oath goes, “Cut off a limb and two more shall take its place!”",
                    "Those agents who survive long enough—or are ambitious enough—find themselves promoted to positions of leadership within their hierarchical organization. Often they’re the leaders of independent cells sequestered from the rest of Hydra for operational security, and the fact that they’ve survived to that point means (at least to them) that they must be doing something right.",
                ],
                Personality =
                [
                    "While Hydra agents like to follow orders, Hydra officers have developed a taste for giving them. They like to shout at their underlings and boss them around, and many of them harbor aspirations of one day becoming the Supreme Hydra themselves. They tend to be mean and merciless— to outsiders, to their subordinates and most especially to those they see as rivals. Many of them see the fact that they’ve risen in the ranks as the proof of their superiority, and because of this, they tend to be cocky as well.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Hydro-Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 6, vigilance: 4, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Earth (particularly soil, dirt and dust)"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.Villainous),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlWater,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSuffocation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.SlipFree),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedSwim),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Morris “Morrie” Bench",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually around 6'2\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually around 265 lbs.",
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FrightfulFour, TeamNames.Maggia, TeamNames.SinisterSix],
                Base = "Mobile",
                History =
                [
                    "At the request of some local engineers, Spider-Man (Peter Parker) agreed to supervise the fi rst test of a new hydroelectric generator in the seas outside of New York City. During the test, an electrical cable snapped, and Spider-Man—in his rush to mitigate the damage—accidentally pushed smalltime sailor and ex-con Morris Bench overboard.",
                    "The energy from the generator turned Bench into a living liquid, capable of not only becoming water, but controlling it in the same way that the Sandman controls sand. Upset about his new condition, Bench set out to get revenge on Spider-Man, tracking him across New York City before attempting to wash the spider out once and for all.",
                    "Spider-Man literally mopped up the newly anointed Hydro-Man with nothing more than a stack of newspapers, but Bench, ever the optimist, remained undeterred. In the years since their fi rst encounter, Bench has made dozens of further attempts on the wall-crawler’s life, each more disastrous and poorly conceived than the last.",
                    "In many ways, this quest has consumed Bench’s entire life. Although he occasionally takes regular criminal jobs to pay the bills, his only real passion is taking down Spider-Man. He lost track of his original reasons for hating the hero long ago, but he still feels an instinctual need for vengeance.",
                ],
                Personality =
                [
                    "Morrie Bench was an unscrupulous and greedy crook long before he became Hydro-Man, and gaining incredible powers certainly hasn’t helped balance him out. He is, on the whole, a dull individual driven almost entirely by his personal grievances and impulses. To call him temperamental would be a vast understatement.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Hyperion",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 6, vigilance: 3, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MahdWyry),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
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
                RealName = "Marcus “Marc” Milton",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [460],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Auburn",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.AlphaFlight, TeamNames.Avengers, TeamNames.SquadronSupreme],
                Base = "Mobile",
                History =
                [
                    "Marcus Milton was born in an alternate universe— Earth-13034—as the sole survivor of a dying world of Eternals. His people sent him to Earth, where he was raised by a humble family of ordinary people.",
                    "Under the codename Hyperion, Milton worked to make that Earth into a utopia. Sadly, his home, his family and every other member of his universe were destroyed by the incursion of another reality, leaving him—once again—the sole survivor.",
                    "Hyperion was pulled from the void of his dead universe to Earth-616 by a group of A.I.M. scientists experimenting with multiversal travel. The Avengers freed Hyperion from A.I.M. containment, and for a while, he traveled with them on their adventures. However, he eventually tired of hero work, abandoned his identity as Hyperion and took up a job as a trucker, hoping to learn more about his new home.",
                    "Events outside of his control have occasionally forced Milton to return to his super-hero identity, but he continues to spend most of his time living on the road."
                ],
                Personality =
                [
                    "Milton struggles with his identity. He is not even the fi rst version of himself to be pulled from another universe into Earth-616. The original Hyperion—Mark Milton of Earth-712—died shortly after this Milton’s arrival.",
                    "Having survived so much death and destruction, Milton sometimes feels like fi ghting for justice may be a futile effort when, at any second, his whole world could be destroyed or reset. Still, he can’t help but answer the call to action when he sees a person in need."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
    ];
}
