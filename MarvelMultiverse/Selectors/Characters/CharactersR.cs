using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersR
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
            Name = "Radioactive Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 1, resilience: 4, vigilance: 6, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "can be temporarily suppressed"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
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
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Dazzle),
                        powerSelector.GetPower(PowerNames.Flare),
                        powerSelector.GetPower(PowerNames.Illumination),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Chen Lu",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [290],
                Gender = Gender.Male,
                Eyes = "Brown, white when glowing",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Often glows green",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.LethalLegion, TeamNames.MastersOfEvil, TeamNames.Thunderbolts],
                Base = "Beijing",
                History =
                [
                    "Chinese scientist Chen Lu was tasked with finding a way to defend China from the rising threat of superhumans. Experimenting with radiation, Chen managed to give himself powers, turning himself into the Radioactive Man.",
                    "In his debut, the Radioactive Man came to blows with Thor Odinson during a skirmish on the border of China and was roundly defeated. The humiliation spawned a deep hatred for the Thunder God within Chen, and he has made many attempts to destroy Thor since.",
                    "A founding member of the original Masters of Evil and one of the Avengers’ oldest foes, Chen spent many years working as a villain for hire, often for his native government. At one point, China even lent him to the U.S.-based Thunderbolts. Unfortunately, his status as a walking, talking bomb makes him a considerable hazard to those around him, and he often makes people uneasy.",
                    "In recent days, Chen has taken a job with Roxxon, where he’s working with several other villains to bring down Thor once and for all."
                ],
                Personality =
                [
                    "Chen has a certain swagger, as befits someone who intentionally created their own super-powers. A brilliant scientist in his own right and a beloved hero to his people, Chen is a devout patriot who detests anyone the Chinese government proclaims an enemy.",
                    "Although Chen’s green skin and innate radiation often put those around him on edge, he tries to keep a sense of humor. He revels in the destructive capabilities of his powers and often is caught smiling in battle."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Rama-Tut",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 4, ego: 4, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Disguise, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
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
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimePortal),
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelOther),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Nathaniel Richards",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Anachronauts, TeamNames.CouncilOfKangs],
                Base = "Ancient Egypt",
                History =
                [
                    "Nathaniel Richards grew up in the near-utopian environment of the 30th century of Earth-6311. As an adult, he became sick of luxury and became determined to live a life of adventure in a more interesting era.",
                    "Disguising himself as the Pharaoh Rama-Tut, Richards built a time machine and set about conquering ancient Egypt. As the supreme ruler of Egyptian civilization, Richards sought to secure his reign over all the Earth. As such, he is constantly on the lookout for any who may have the power to oppose him, particularly the mutant conqueror known as Apocalypse.",
                    "He does not yet know it, but Apocalypse will be the least of his worries. He later takes on a number of other identities, the most famous of which is Kang the Conqueror.",
                ],
                Personality =
                [
                    "Richards is a megalomaniac and a narcissist of the highest order. He believes himself to be the most important being in existence, and he will go to any length to prove his own importance. He often speaks in the style of the old Greco-Roman conquerors.",
                    "Richards is not above meddling in anyone’s timeline, even his own. As a result, his early life has become shrouded in mystery and divergence. A number of alternate versions of him from across the Multiverse have had adventuring careers to rival Richards’ own."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Red Goblin",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain Marvel (Carol Danvers)"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Young),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Razorwebs),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
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
                RealName = "Norman Harold “Normie” Osborn",
                Heights = [new() { Feet = 3, Inches = 9 }],
                Weights = [45],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Small,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.SymbioteVenom],
                Teams = [TeamNames.AvengersAcademy],
                Base = "New York City",
                History =
                [
                    "As the son of the Green Goblin (Harry Osborn) and Misery (Liz Allan), Normie Osborn has been getting wrapped up in super-hero shenanigans since he was a toddler. Poisoned by the infl uence of his grandfather Norman, Normie wound up hating Spider-Man (Peter Parker) and everything the Web-Head stood for.",
                    "However, after Spider-Man saved Normie from Carnage, the boy’s outlook changed. Now eager to follow in the web-slinger’s footsteps, he allowed Venom (Dylan Brock) to bond him with Rascal—a modified offshoot of the Carnage symbiote weak enough for even a little kid to keep under control.",
                    "After helping Dylan to rescue his father, Eddie, Normie adopted the identity of the Red Goblin and quietly took to the streets to become New York City’s latest enigmatic crimefi ghting prodigy.",
                    "Despite having been a hero for only a matter of months, Normie has become a trusted ally to many of the city’s foremost defenders, including Spider-Man himself. When he’s not spending time with his mother, Liz, or his brother, Stanley, Normie attends Avengers Academy, learning the ropes of heroism alongside other up-and-coming young heroes like Moon Girl and Escapade."
                ],
                Personality =
                [
                    "Despite all he’s been through, Normie is still just a regular kid, and like a lot of kids his age, he’s a bundle of insecurities and nervous tics. He’s not good at opening up to others, much less counting on them. Ironically, his closest friend is probably his symbiote, Rascal. Unlike most of his species, Rascal is too rambunctious and simpleminded to ever be outright evil.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Red Guardian",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Red boomerangs (act as pistol)"),

            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Red Guardian’s Shield"),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.HurledShieldBash),
                        powerSelector.GetPower(PowerNames.Shield1, reminder: "Shield 2, with Iconic Weapon"),
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
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Red Guardian’s Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Stackable),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        "Requires: Shield 1 power"
                    ],
                    PowerValue = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Alexei Andreovitch Shostakov",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Thunderbolts, TeamNames.WinterGuard],
                Base = "Avengers Mountain",
                History =
                [
                    "Already a decorated war hero and test pilot, Alexei Shostakov seemed like a natural choice to replace the original Red Guardian after the Russian government had the old warrior killed for insubordination. Indeed, Shostakov initially was the perfect candidate, loyal to a fault, willing even to abandon his wife, Natasha Romanoff (later known as the Black Widow), in the pursuit of becoming Russia’s answer to Captain America (Steve Rogers).",
                    "When he finally met Captain America, though, things went wrong. Shostakov was strong, but his foe was stronger. Captain America was on the verge of defeating the Red Guardian when one of Shostakov’s superiors stabbed the First Avenger in the back. Unwilling to accept such a dishonorable victory, Shostakov defied his superiors and saved Captain America’s life, seemingly at the cost of his own.",
                    "Some years later, Shostakov briefly resurfaced as the third person to take on the identity of Ronin—after Maya Lopez (also known as Echo) and Hawkeye (Clint Barton)—before being arrested by S.H.I.E.L.D. The Russian government arranged for Shostakov to be broken out of prison and subsequently recruited him into their super-hero team, the Winter Guard. However, after discovering that fascists had infiltrated the Russian command structure, Shostakov once again abandoned his commitment to the government. He’s since joined his former Winter Guard teammate White Widow in helping the Winter Soldier’s new incarnation of the Thunderbolts root out the Red Skull and his allies once and for all."
                ],
                Personality =
                [
                    "Shostakov is a burly, bearded man and a hard drinker. Look beneath his exterior, though, and there’s a kind and principled warrior, every bit as committed to the well-being of the Russian people as Captain America is to Americans.",
                ]
            },
            Source = BookSource.QuickStartWithThunderboltsAdventure
        },
        new()
        {
            Name = "Red Hulk",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 3, resilience: 9, vigilance: 4, ego: 3, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (U.S. Air Force)"),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "“Thunderbolt” Ross"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Red Hulk form"),
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
                        powerSelector.GetPower(PowerNames.EnergyAbsorption, reminder: "limited to incorporeal forms of damage: energy, radiation, cosmic rays, etc."),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
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
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.FocusFire),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Thaddeus E. “Thunderbolt” Ross",
                Heights = [new() { Feet = 6, Inches = 1 }, new() { Feet = 7 }],
                Weights = [245,1200],
                Gender = Gender.Male,
                Eyes = "Blue/yellow",
                Hair = "White, formerly brown/black",
                Size = Size.Big,
                SizeNotes = "Average as Ross",
                DistinguishingFeatures = "Red Hulk form with orange blood and dark fingernails",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Avengers, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "As the head of the army base where Bruce Banner first became the Hulk, General Thaddeus Ross made it his mission in life to take the green monstrosity down at any cost. Of course, that mission proved impossible, and as the years dragged on, the cost only rose. In his relentless pursuit of the Hulk, the general lost his military commission, his dignity and even his relationship with his daughter Betty who—despite everything—still loved Banner.",
                    "At the end of his rope, Ross made a fateful decision. If he could not beat the Hulk as a man, maybe he could beat him as a monster. With the help of several of the Hulk’s greatest enemies, Ross stole and absorbed a portion of Banner’s gamma power, transforming himself into the Red Hulk.",
                    "Even with power comparable to Banner’s own, though, Ross simply couldn’t keep the Hulk down. Gradually, he came to regret his transformation, and in an effort to redeem himself, he began working with many of the Hulk’s own super-teams, including the Avengers. For a while, he even led his own incarnation of the Thunderbolts.",
                    "Though the Red Hulk’s appearances in the field have been sporadic as of late, he remains dedicated to making the world a safer place—by any means necessary."
                ],
                Personality =
                [
                    "He’s no longer an official member of the U.S. Air Force, but Ross is still a military man through and through. He is a proud patriot with unwavering respect for the chain of command, a man who treats every super-hero mission like a tactical military strike, never beginning a fight without multiple plans and backup plans in place.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Red Skull (Johann Shmidt)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 1, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
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
            Biography = new Biography
            {
                RealName = "Johann Shmidt",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [189],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Head is disfigured into a red skull",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "Declaring that he could turn anyone into the ideal Nazi soldier, Adolf Hitler selected a random bellboy by the name of Johann Shmidt to be his next secret agent. He personally trained Shmidt to be a killer and spy, transforming him into one of the deadliest soldiers in the Third Reich.",
                    "After World War II, the crimson-faced Shmidt carried the mad führer’s dream of a worldwide Nazi government into the modern age. Were he not so dangerous, it would be easy to write him off as a cackling madman. A regular ally or even commander of fascist organizations like Hydra, he’s capable of launching complex schemes that threaten to bring the entire planet beneath his heel.",
                ],
                Personality =
                [
                    "In his day-to-day interactions with others, the Red Skull shows himself to be little more than a fascist zealot and a madman. Despite this, he is an expert propagandist who deftly recruits crowds of bigots.",
                ]
            }
        },
        new()
        {
            Name = "Red Wolf",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 1, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.AnimalCommunication}"),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
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
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Wolves"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Red Wolf",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.SantaRosaSheriffsDepartment],
                Base = "Mobile",
                History =
                [
                    "Red Wolf was born to a community of Cheyenne natives in the old west of an alternate universe (Earth-51920). As a young man, he was sent to destroy a dam in Timely, a settler community that was diverting water from Cheyenne lands. Red Wolf made a deal with the townsfolk of Timely: in exchange for the destruction of their dam, he would take down their corrupt mayor, Wilson Fisk. With the help of some locals, Red Wolf killed Fisk and became the town’s sheriff.",
                    "Sometime later, Red Wolf fought a time-traveling super villain and wound up in the present day of Earth-616, where he has worked alongside Hawkeye (Clint Barton) and other heroes to help fi ght injustice.",
                ],
                Personality =
                [
                    "Red Wolf has a deep and abiding love for the communities he protects. While he enjoys his time in what he thinks of as the future—and especially the relationships he’s made there—he still wishes to return home.",
                ]
            }
        },
        new()
        {
            Name = "Rek-Rap",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 4, vigilance: 2, ego: 1, logic: -1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Gullible),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderSense),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 4, Inches = 10 }],
                HeightReminder = "7'1\" as Rek-Rap",
                Weights = [108],
                WeightReminder = "667 lbs. as Rek-Rap",
                Gender = Gender.Male,
                Eyes = "Red, white as Rek-Rap",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Rek-Rap form resembles Spider-Man costume with unnaturally huge mouth and tongue",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MagicDemonic, OriginName.SymbioteVenom],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "As part of Chasm and Madelyne Pryor’s demonic invasion of New York City, the pair kidnapped Spider-Man and took him to limbo, where they forced him to reenact twisted parodies of his own adventures. While working at a demonic version of the Daily Bugle, Parker saved the life of a pale little imp.",
                    "Inspired, the imp took up the wall-crawler’s heroic way of life, dressing like the Web-Head and calling himself Parker-Man. He confronted Chasm’s demonic Sinister Six parody—the Insidious Six—and attempted to “audition” for the role of their opponent, but the villains sent him packing.",
                    "Dejected, the imp sought out the assistance of an old alchemist friend, a minotaur-like creature who had recently come into possession of a small sample of an alien symbiote. The minotaur wove a ritual to bind the imp to the symbiote, transforming him into a hulking monstrosity.",
                    "Embracing his own backwardness, the imp took on the codename of Rek-Rap and helped Parker defeat the Insidious Six. After the invasion of Earth ended, Rek-Rap followed Spider-Man back to Earth, and in the days since, he’s helped him fend off a number of other threats, including the demon Re-Po and the resurgent Green Goblin (Norman Osborn)."
                ],
                Personality =
                [
                    "Rek-Rap adores Spider-Man, but he seems to have only a vague, backward sense of who the hero is and what he does. As he “web-whangs” around the city, Rek-Rap likes to crudely narrate his own adventures, framing them as episodes of The Rek-Rap Storytime Adventure! He is, on the whole, a lovable idiot who wants nothing more than to help people, have fun and eat flies.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Ren Kimura",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Razor Arms"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Razor Arms",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "On a Fantastic success, causes bleeding."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier Bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Awkward",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Ren Kimura",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [122],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.AsgardiansOfTheGalaxy, TeamNames.FearlessDefenders],
                Base = "New York City",
                History =
                [
                    "Growing up, Ren Kimura wanted to be a dancer. Unfortunately, her parents never approved of her aspirations or—for that matter—her homosexuality. She was forced to take up dancing (and dating) in secret, regularly sneaking away from home to spend long hours practicing at a local dance studio.",
                    "Because of this, Kimura was at the dance studio—not safe at home— when the Terrigen Bomb detonated over New York City. The Terrigen Mist activated the Inhuman DNA lurking inside her genes, transforming her arms into twisted masses of metal wire. With effort, Kimura discovered that she could make the wires float through the air like dancing ribbons, able to slice distant targets to pieces.",
                    "That night, super villains invaded New York City, looking to kidnap the newly awakened Inhumans. Kimura would have fallen prey to them were it not for the intervention of the Fearless Defenders.",
                    "Kimura joined the Defenders and fell deeply in love with one of her new teammates: Annabelle Riggs. Even after the Defenders fell apart, Riggs and Kimura stuck together. They became part of the Asgardians of the Galaxy, and later, Riggs helped Kimura form her own dance studio. Although they’ve officially retired from the adventuring business, they remain ready to answer any call to action."
                ],
                Personality =
                [
                    "Despite their mutual affection, Riggs and Kimura have diametrically opposed personalities. Riggs is bookish, shy and more than a little awkward, while Kimura is as outgoing and charming as a person can be. She adores the stage and the spotlight.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Reptil",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 5, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Dinosaur Forms"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Vicente Lopez"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Family"),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink2),
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
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Humberto “Berto” Lopez",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [142],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Dinosaur tail and limbs (when using powers)",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechPymParticles, OriginName.Magic],
                Teams = [TeamNames.AvengersAcademy],
                Base = "Los Angeles",
                History =
                [
                    "While out at a dig site with his paleontologist parents, Humberto Lopez stumbled upon a mystical fossilized amulet that gave him the power to shape-shift into prehistoric creatures, particularly dinosaurs. As a lifelong fan of super heroes, he leaped at this opportunity to become a hero himself, adopting the codename Reptil.",
                    "Shortly after Reptil began adventuring, his parents mysteriously disappeared. While he continued to search for them, he joined the Avengers Academy and became good friends with many of his fellow students. Although the academy is no more, he continues to do his best to help those in need.",
                ],
                Personality =
                [
                    "Reptil loves adventure, but he fears his own powers as much as he appreciates them. His reptilian transformations can occasionally send him into a berserker state, where he has little more reasoning power than a T. rex. He fears the possibility of accidentally lashing out at those closest to him.",
                ]
            }
        },
        new()
        {
            Name = "Rhino",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 0, resilience: 6, vigilance: 1, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Ram"),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
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
                        powerSelector.GetPower(PowerNames.Mighty3),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    IsBattlesuit = true,
                    Name = "Rhino's Battle Suit",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.GroundShakingStomp, powerSelector.GetPower(PowerNames.GroundShakingStomp)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy2, powerSelector.GetPower(PowerNames.Sturdy2)),
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
                RealName = "Aleksei Mikhailovich Sytsevich",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [710],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [TeamNames.Orchis, TeamNames.SinisterSix, TeamNames.Thunderbolts],
                Base = "New York City",
                History =
                [
                    "Russian scientists hoping to create a superpowered assassin snatched a small-time crook named Aleksei Sytsevich off the street and offered to grant him strength beyond his wildest dreams. They started by bombarding his body with gamma rays, which did grant him limited super-strength, but not enough for their purposes. To further augment his powers, they developed an armored rhino-like suit that allowed him to smash through any obstacle.",
                    "The scientists tried sending their “Rhino” to America to steal government secrets, but after being repeatedly defeated by both Spider-Man (Peter Parker) and the Hulk, Sytsevich turned on his handlers and abandoned Russia for good. He found an apartment in New York City and reinvented himself as a superhuman mercenary for hire.",
                    "Although the Rhino primarily works as a villain, he has occasionally teamed up with super heroes for the right cause. He has a long-running grudge against Spider-Man (Peter Parker), but he considers Spider-Man (Miles Morales) to be a decent guy, maybe even a friend.",
                ],
                Personality =
                [
                    "Despite his reputation as a reckless and destructive dimwit, the Rhino is one of the more reasonable super villains in New York City. He has family and connections, people he cares about, like his niece Tanya. He may be a criminal mercenary, but he’s not a cold-blooded killer. Stay out of his way, and he’ll stay out of yours.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
		{
			Name = "Rictor",
			Rank = 4,
			Abilities = new Abilities
			(
				melee: 1, agility: 4, resilience: 2, vigilance: 5, ego: 6, logic: 2
			),
			Traits =
			[
				traitSelector.GetTrait(TraitNames.CombatExpert),
				traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
				traitSelector.GetTrait(TraitNames.Fearless),
				traitSelector.GetTrait(TraitNames.Glibness),
				traitSelector.GetTrait(TraitNames.IronWill),
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
						powerSelector.GetPower(PowerNames.Discipline2),
						powerSelector.GetPower(PowerNames.Inspiration),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.ElementControlSound,
					Powers =
					[
						powerSelector.GetPower(PowerNames.ElementalBarrage),
						powerSelector.GetPower(PowerNames.ElementalBlast),
						powerSelector.GetPower(PowerNames.ElementalBurst),
						powerSelector.GetPower(PowerNames.ElementalPush),
						powerSelector.GetPower(PowerNames.ElementalRicochet),
						powerSelector.GetPower(PowerNames.Supernova),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.ElementControlEarth,
					Powers =
					[
						powerSelector.GetPower(PowerNames.ElementalBarrage),
						powerSelector.GetPower(PowerNames.ElementalBlast),
						powerSelector.GetPower(PowerNames.ElementalBurst),
						powerSelector.GetPower(PowerNames.ElementalGrab),
						powerSelector.GetPower(PowerNames.ElementalPrison),
						powerSelector.GetPower(PowerNames.ElementalProtection2),
						powerSelector.GetPower(PowerNames.ElementalPush),
					],
				},
			],
			Biography = new Biography
			{
				RealName = "Julio Esteban Richter",
				Heights = [new() { Feet = 5, Inches = 9 }],
				Weights = [145],
				Gender = Gender.Male,
				Eyes = "Brown",
				Hair = "Brown",
				Size = Size.Average,
				DistinguishingFeatures = "None",
				Occupations = [OccupationName.Adventurer],
				Origins = [OriginName.Mutant],
				Teams = [TeamNames.Excalibur, TeamNames.NewMutants, TeamNames.XFactor],
				Base = "Krakoa",
				History =
				[
					"Born into a Mexican cartel family, Julio Richter’s early life was marked by violence and chaos. After his father was murdered by Stryfe, Richter tried to run away from home, only to be kidnapped by the Right, an anti-mutant organization interested in his fledgling seismic powers.",
					"X-Factor freed him from the Right’s control and subsequently gave him a place among their trainees, the X-Terminators. Among mutants for the first time in his life, Richter excelled. Under the codename Rictor, he quickly graduated into the New Mutants and, from there, into X-Force.",
					"After losing his powers on M-Day, Rictor fell into a deep depression. To cheer him up, some of his old teammates invited him to help them form X-Factor Investigations. Shortly thereafter, Rictor came out as gay and began dating one of his teammates, Shatterstar. Once Rictor regained his powers, he and Shatterstar left X-Factor Investigations and began adventuring on their own. Following the foundation of Krakoa, the pair joined Excalibur, committing themselves to the protection of the island-nation."
				],
				Personality =
				[
					"Despite his dark past, Rictor is more laid-back than most mutant adventurers. He’s a generally cheery guy who doesn’t take himself too seriously. When referring to his teammates, he frequently uses words like “dude” and “bro.” Although he’s closer to Shatterstar than anyone else, Rictor has been around long enough for many mutants to consider him a valued friend and teammate.",
				]
			},
            Source = BookSource.XMenExpansion
		},
		new()
        {
            Name = "Rocket Racoon",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 4, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "2 Pistols"),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Rifle"),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
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
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.CombatSupport),
                        powerSelector.GetPower(PowerNames.FocusFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Rocket",
                Heights = [new() { Feet = 4 }],
                Weights = [55],
                Gender = Gender.Male,
                Eyes = "Brown (with tapetal reflection)",
                Hair = "Brown, black and white",
                Size = Size.Small,
                DistinguishingFeatures = "Raccoon-like alien",
                Occupations = [OccupationName.Criminal, OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Avengers, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Rocket is a genetically and cybernetically engineered extraterrestrial created to resemble an Earth raccoon and to work as one of the protectors of the Loonies, a group of criminally insane aliens sentenced to life on the prison planet Halfworld in the Keystone Quadrant. After leaving his position, Rocket made his way into the wider galaxy, where he wound up involved in questionable activities that landed him in a Kree prison. There, he met his best friend, Groot, and together, they helped form the Guardians of the Galaxy.",
                    "With the rest of the Guardians, Rocket saved the galaxy from being destroyed by the alien hive fl eet known as the Phalanx. After that, they decided to band together permanently, becoming a family as much as a team. Rocket has even stepped up to lead the team when Star-Lord wasn’t available.",
                ],
                Personality =
                [
                    "Rocket is sharp and conniving, one of the smartest people around, especially when it comes to tactics and logistics. He carries larceny in his heart and is always looking for a better angle on any problem that presents itself.",
                ]
            }
        },
		new()
		{
			Name = "Rogue",
			Rank = 4,
			Abilities = new Abilities
			(
				melee: 5, agility: 4, resilience: 4, vigilance: 3, ego: 3, logic: 1
			),
			Traits =
			[
				traitSelector.GetTrait(TraitNames.CombatReflexes),
				traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
				traitSelector.GetTrait(TraitNames.Fearless),
				traitSelector.GetTrait(TraitNames.Glibness),
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
						powerSelector.GetPower(PowerNames.Flight2),
						powerSelector.GetPower(PowerNames.Mighty3),
						powerSelector.GetPower(PowerNames.Sturdy2),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.PowerControl,
					Powers =
					[
						powerSelector.GetPower(PowerNames.ClonePowers),
						powerSelector.GetPower(PowerNames.CopyPower),
						powerSelector.GetPower(PowerNames.DampenPower),
						powerSelector.GetPower(PowerNames.ShutDownPowers),
						powerSelector.GetPower(PowerNames.StealPowers),
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
						powerSelector.GetPower(PowerNames.QuickToss),
						powerSelector.GetPower(PowerNames.Smash),
					],
				},
			],
            PowerNotes = 
            [
				"In order to activate any of her Power Control powers, Rogue must first grab or hit her target. If she spends her action on this, she can still activate the power in question with a reaction."
			],
			Biography = new Biography
			{
				RealName = "Anna Marie LeBeau",
				Heights = [new() { Feet = 5, Inches = 8 }],
				Weights = [135],
				Gender = Gender.Female,
				Eyes = "Green",
				Hair = "Brown with white streaks",
				Size = Size.Average,
				DistinguishingFeatures = "None",
				Occupations = [OccupationName.Adventurer],
				Origins = [OriginName.Mutant],
				Teams = [TeamNames.Avengers, TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
				Base = "Mobile",
				History =
				[
					"Born into a cold and neglectful family, Anna Marie fled from home at a young age. She spent some time working as a thief on the banks of the Mississippi, earning herself the nickname Rogue. Eventually, Mystique and Destiny—having precognitive knowledge of Rogue’s mutant status—took her in and raised her as their daughter. When Rogue’s mutant absorption powers activated suddenly and traumatically in her early teenage years, Mystique and Destiny were prepared to comfort Rogue—and to indoctrinate her into a life of mutant terrorism.",
					"Rogue eventually joined her adoptive mothers in the Brotherhood of Evil Mutants, but her time with the team was cut short after she accidentally absorbed the powers and psyche of Captain Marvel (Carol Danvers). On the edge of a dissociative breakdown, Rogue fled into the custody of Professor X, who helped her integrate Captain Marvel’s psyche into her own and subsequently allowed her to join the X-Men.",
					"Rogue excelled as a hero, quickly becoming a key part of the X-Men. She began a long-term romance with her teammate Gambit, and shortly before the foundation of Krakoa, the pair finally wed. Although they served as backup members of Krakoa’s Excalibur team, Gambit and Rogue made an effort to spend most of their recent time focusing on each other."
				],
				Personality =
				[
					"Rogue’s Power Control powers cause her to absorb a bit of her target’s mind, so in the heat of battle, her personality can vary wildly. However, at her core, she’s a kind and sensitive Southern belle, albeit one with a short fuse. She speaks in a thick Southern accent, often referring to people as “sugah.”",
				]
			},
			Source = BookSource.XMenExpansion
		},
        new()
        {
            Name = "Rogue (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 4, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ClonePowers),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.DampenPower),
                        powerSelector.GetPower(PowerNames.ShutDownPowers),
                        powerSelector.GetPower(PowerNames.StealPowers),
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
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            PowerNotes =
            [
                "In order to activate any of her Power Control powers, Rogue must first grab or hit her target. If she spends her action on this, she can still activate the power in question with a reaction."
            ],
            Biography = new Biography
            {
                RealName = "Anna Marie",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Brown with white streaks",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "A mutant with the power to absorb memories and super-powers upon touch, Rogue was disowned by her father after her first kiss put her boyfriend Cody into a coma. Shape-shifting mutant Mystique adopted the runaway Rogue. To help her control her powers, Mystique took Rogue to train under Magneto in the Savage Land. Magneto discovered he could touch Rogue, and the two became romantically involved for a time. As a part of Mystique’s Brotherhood of Mutants, Rogue performed illegal activities and permanently absorbed the strength, invulnerability and fl ying powers of Ms. Marvel (Carol Danvers), leaving Danvers comatose. As Danvers’ persona battled to control Rogue’s mind, Rogue fl ed to psychic mutant Charles Xavier for help. Finding peace after Xavier blocked Rogue’s memories, Rogue joined Xavier’s X-Men, having many heroic adventures.",
                    "She developed feelings for her flirtatious teammate Gambit, often infuriated knowing her powers prevented them from touching. Hoping to remove her mutant abilities, Rogue traveled to Scotland where Mystique posed as a mutant cure’s administrator. The ancient mutant Apocalypse secretly orchestrated the “treatment” to build a team. With Apocalypse thwarted, Rogue returned home, powers intact.",
                    "Rogue discovered Nightcrawler is Mystique’s son, making him like a brother. Cody returned, manipulated by aliens, but Rogue and the X-Men repelled the invasion. Invited by Magneto to co-lead Genosha, Rogue rejected Magneto for Gambit. But Gambit was killed and Genosha massacred by giant Sentinels. Heartbroken, Rogue joined Magneto in battling Bastion and the human-Sentinel hybrids responsible for the genocide."
                ],
                Personality =
                [
                    "With her distinctive striped hair, known for making playful, sometimes flirty, Southern metaphors, Rogue is a fiery and passionate woman. Though quick to protect those she loves, she can be emotionally distant knowing the dangers of her touch. This has often left her lonely, tending toward individualism.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Ronan the Accuser",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 4, vigilance: 2, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.BreatheDifferent),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
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
                RealName = "Ronan",
                Heights = [new() { Feet = 7, Inches = 5 }],
                Weights = [480],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Blue skin",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.AlienKree],
                Teams = [TeamNames.KreeEmpire],
                Base = "Kree-Lar",
                History =
                [
                    "A powerful warrior, Ronan rose through the ranks of the Kree military, eventually achieving the position of Supreme Accuser. Second only to the Emperor himself, Ronan was in charge of overseeing all Kree military operations.",
                    "Ronan has battled some of the deadliest warriors in the galaxy and personally led invasions of Earth, the Skrull Empire and the Inhuman homeland. After a coup resulted in the death of the Kree Emperor, Ronan himself was elected to the position. He later made peace with the Inhumans and entered into an arranged marriage with Crystal to cement it, but this didn’t last.",
                ],
                Personality =
                [
                    "A hulking mass of a warrior, Ronan demands respect from those around him, and any show of disrespect can cause him to erupt in a murderous rage. His proud loyalty to the Kree people outweighs his ferocious nature, though, and he tends to look down on those from “lesser races.”",
                ]
            }
        },
        new()
        {
            Name = "Ruby Thursday",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in true form"),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Head Orb"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Head Orb",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.AdditionalLimbs} (Tentacles)", powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder : "Tentacles")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ExtendedReach2} (Reach 10; only applies to tentacles)", powerSelector.GetPower(PowerNames.ExtendedReach2, reminder : "Reach 10; only applies to tentacles")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Webcasting, powerSelector.GetPower(PowerNames.Webcasting)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Webgrabbing, powerSelector.GetPower(PowerNames.Webgrabbing)),
                    ],
                    Restrictions =
                    [
                        "Flashy",
                        "Worn"
                    ],
                    PowerValue = 4,
                }
            ],
            Biography = new Biography
            {
                RealName = "Thursday Rubinstein",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "None visible",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Large red orb in place of head",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Headmen],
                Base = "New York City",
                History =
                [
                    "Ruby Thursday was once a leading scientist in the field of organic circuitry, right up until her head was replaced with a bright red orb of morph-able electronics, from which she can extend prehensile tentacles. She can even alter it to appear human, and she can separate it from her body without harm.",
                    "She fell in with a group of similarly disgruntled and disfigured scientists: the villainous Headmen. Although she was a late addition to the team, she quickly distinguished herself as one of the organization’s toughest and most capable members.",
                    "Unlike her teammates, Ruby Thursday has occasionally managed to make a career for herself as an independent mercenary. Her powerful red tentacles have allowed her to successfully hold her ground against the likes of Romulus and even She-Hulk. If the Headmen ever entirely fell apart, most of its members might return to civilian life, but Ruby and her villainy would endure.",
                ],
                Personality =
                [
                    "Ruby is as stoic and enigmatic as the orb that forms her head. She speaks succinctly and infrequently, preferring to let her tentacles do the talking.",
                    "Like all the Headmen, Ruby is driven by two things: money and a burning desire to show up those fools who laughed at her work."
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
    ];
}
