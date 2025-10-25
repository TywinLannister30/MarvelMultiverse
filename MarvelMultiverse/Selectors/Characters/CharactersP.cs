using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersP
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
            Name = "Paladin",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 3, vigilance: 2, ego: 3, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mysterious),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Stun Gun"),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Stun Gun",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "On a Fantastic success, stuns the target rather than causing bleeding."),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: 10 spaces, Agility Damage Multiplier Bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Only usable by Paladin",
                    ],
                    PowerValue = 1,
                    AgilityDamageModifier = 1,
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.HeroesForHire, TeamNames.VillainsForHire],
                Base = "Mobile",
                History =
                [
                    "Paladin’s past is a secret to everyone except maybe the man himself, and he isn’t forthcoming with details. S.H.I.E.L.D.’s archives on Paladin date back only as far as a few years ago when, during a mission to capture the Purple Man, he fought with Daredevil. Although Paladin was already a moderately well-established mercenary by this point, no one knows for sure what jobs he had completed before facing off against the Man Without Fear.",
                    "Although Paladin ultimately failed to capture the Purple Man, his ability to hold his own against Daredevil made him famous overnight. Job offers came pouring in, from both super heroes and super villains.",
                    "For a while, Paladin sold his services exclusively to the highest bidder. Some days he was a hero, and other days he was a villain. He is one of the few people who can truthfully claim to have fought on both sides of the superhuman Civil War.",
                    "As the years drew on, though, Paladin’s duplicitousness began to gnaw at his conscience. There was no single moment of reform and repentance, but slowly, he stopped accepting villainous jobs. These days, he works primarily as an independent hero for hire."
                ],
                Personality =
                [
                    "Ninety percent amoral mercenary and ten percent big-hearted softy, Paladin has a strangely charming aura. He’s had a number of romantic relationships within the super-hero community, most notably with the Wasp. Even his enemies regard him as a gentleman and a consummate professional.",
                    "Paladin’s need to make money exists in perpetual confl ict with his conscience. He has, on several occasions, dropped well-paying assassination jobs at the last moment because he couldn’t bear to kill his target."
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Patriot",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 2, vigilance: 3, ego: 3, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Patriot’s shield (acts as a regular shield)"),

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
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.Shield1),
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
                        powerSelector.GetPower(PowerNames.HitTheDirt),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Elijah “Eli” Bradley",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [206],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "In an attempt to re-create the Super-Soldier Serum that gave Captain America (Steve Rogers) his powers, the U.S. government subjected hundreds of Black soldiers to brutal experiments. Only one man—Isaiah Bradley—survived these experiments, and he immediately took the title of Captain America for himself and ran off to fight in World War II. Rather than reward Bradley for his heroism, the government imprisoned him for insubordination and struck his name from the history books.",
                    "Decades later, Bradley’s grandson Elijah learned of his grandfather’s legacy, and despite having no powers of his own, he became determined to live up to the legacy of the first Black Captain America. By using Mutant Growth Hormone, Elijah managed to simulate super-strength well enough to become not only a founding member, but the leader of the Young Avengers. His ruse was only discovered after he took a nearly lethal blow in battle, but thankfully, his grandfather stepped in at the last moment and gave him a life-saving blood transfusion, granting Elijah the powers he had wanted all along.",
                    "However, the shame for using MGH stuck with Patriot, and after a particularly devastating battle with Doctor Doom, he retired from the world of super heroes altogether. Elijah now spends most of his time doing quiet activist work, though other heroes like the new Patriot (Rayshaun Lucas) have occasionally convinced him to return to the field for a good cause."
                ],
                Personality =
                [
                    "Equal parts commanding and intelligent, Bradley makes for an excellent team leader. His abilities are tempered only by his own insecurities and the incessant pressure he puts on himself to be a perfect hero.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Patriot (Rayshaun Lucas)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 1, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Falcon (Sam Wilson)"),
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
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Patriot’s Shield", isTech: true),
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
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Shield2),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                        powerSelector.GetPower(PowerNames.ShieldDeflection),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Patriot’s Shield",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)", powerSelector.GetPower(PowerNames.ElementalBurst, reminder : "Energy")),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Glider),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.PsychicLink),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Shield1, powerSelector.GetPower(PowerNames.Shield1)   ),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        $"Requires: {PowerNames.Shield1} power",
                    ],
                    PowerValue = 1,
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Rayshaun “Shaun” Lucas",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [200],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.Champions],
                Base = "New York City",
                History =
                [
                    "As a young teenager, Rayshaun Lucas was an active participant in the protests that followed the wrongful arrest of the super hero Rage. The connections he made during those protests led him further into the world of super heroes, and during the rise of Hydra’s plot to take over the USA with the help of a twisted version of Captain America (Steve Rogers), he helped provide vital intel to the resistance.",
                    "The leaders of the resistance later rewarded Lucas for his noble efforts. Iron Man built him a hightech shield based on Lucas’ own designs, and the Falcon (Sam Wilson) took him on as a super-heroin- training. Ever since, Lucas has fought crime and injustice—often alongside the Champions— under the codename Patriot.",
                    "Lucas is the latest hero by the name Patriot. The original was Jeffrey Mace, who became a replacement Captain America in the late 1940s. More recently was Elijah Bradley, a member of the Young Avengers, who has since given up the codename."
                ],
                Personality =
                [
                    "Lucas is young and inexperienced in battle, but he has an unfl inching sense of justice that transcends the law. He refuses to let any authority stand between him and doing the right thing.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Phoenix",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 5, vigilance: 4, ego: 8, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.AuditoryIssues),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                        powerSelector.GetPower(PowerNames.Supernova),
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
                Origins = [OriginName.Mythic, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.DaughtersOfLiberty],
                Base = "Mobile",
                History =
                [
                    "When Maya Lopez was a child, her father was gunned down by his own boss: the Kingpin (Wilson Fisk). Seeing the young girl’s potential, Fisk took her in, giving her special training and eventually tricking her into believing that Daredevil had killed her father.",
                    "Eventually, Lopez discovered the Kingpin’s deception and turned on him. Her quest for vengeance resolved, she became a tireless fi ghter for justice around the world. Under the codename Echo, she fought to keep the streets of Hell’s Kitchen safe.",
                    "Recently, Echo took part in a contest held by the Phoenix Force, a primordial entity of fire and instability older than the universe itself. The Phoenix Force gathered heroes from around the globe and pitted them against each other to determine who would best serve as a host for its unfathomable power.",
                    "Echo lost her bout to the Sub-Mariner (Namor). However, the Phoenix Force admired Echo’s unflinching determination in battle and decided to take her as its host anyway. With the power of the Phoenix Force within her, Maya Lopez has quickly advanced from a neighborhood vigilante to a defender of entire worlds."
                ],
                Personality =
                [
                    "As a deaf woman and a member of the Cheyenne Nation, Lopez’s life has been full of struggles. Despite it all, she generally manages to stay upbeat. She has a particular love for the theatrical arts, having become a concert pianist and an expert dancer.",
                    "The Phoenix Force has, at times, threatened to turn Lopez into an unstoppable berserker. However, her strong sense of right and wrong helps her keep the primordial entity under control."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Photon (Monica Rambeau)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 5, resilience: 4, vigilance: 4, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Weird),
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
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Monica Rambeau",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.Thunderbolts, TeamNames.Ultimates],
                Base = "Mobile",
                History =
                [
                    "Monica Rambeau was a lieutenant with the New Orleans Harbor Patrol when she stumbled upon an experimental energy weapon hidden aboard a Roxxon oil rig. In the process of destroying the weapon, her body was bathed in extradimensional energy, giving her the power to transform her body into powerful forms of electromagnetic radiation. Embracing her new abilities, Rambeau quit her job and became the new Captain Marvel. She’s since gone by a number of aliases, including Photon, Pulsar and Spectrum, but she’s recently returned to Photon.",
                    "Rambeau has often been a part of the Avengers and has even led the team. Her powers and her leadership skills put her in high demand.",
                ],
                Personality =
                [
                    "Although generally agreeable, Rambeau has a short fuse when it comes to people messing with her. She knows her abilities make her one of the most powerful people in the universe, and she expects to be treated as such. She does not suffer condescension or discrimination from anyone.",
                ]
            }
        },
        new()
        {
            Name = "Piledriver (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 2, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Fearless),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
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
            Biography = new Biography
            {
                RealName = "Brian Phillip Calusky",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [310],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Giant hands",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "As a teenager in the countryside, Brian Calusky turned to a life of crime more out of boredom than anything else. Calusky’s initial infractions were minor, but over the course of a decade, he managed to build himself a solid rap sheet. Eventually, he was sentenced to an extended stay in the maximum-security prison on Ryker’s Island.",
                    "It was at Ryker’s that Calusky met the super villain Wrecker. Along with a couple other inmates, Calusky helped the Wrecker escape from Ryker’s. Out of gratitude, the Wrecker granted his allies a portion of his own powers, and together, they formed the Wrecking Crew.",
                    "Calusky has been with the super-villain group ever since. At one point, he mentored his son, Rick Calusky, who become the criminal known as Excavator."
                ],
                Personality =
                [
                    "Outside of the Wrecker himself, Piledriver might be the most unhinged member of the Wrecking Crew. He can be utterly reckless, both in a battle and outside of it. Unlike his allies, Piledriver prefers to fi ght without weapons or armor, smashing his opponents with his giant bare fists.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Polaris",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 3, vigilance: 5, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Skeptical),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlIron,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
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
                RealName = "Lorna Sally Dane",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [115],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Green",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Investigator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XFactor, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Throughout her childhood, Lorna Dane never suspected that she was the daughter of the infamous mutant Magneto. She was raised by her aunt and uncle and had no contact with the world of super heroes until the age of 19, when she was kidnapped by Mesmero.",
                    "Mesmero activated Dane’s latent mutant powers and attempted to turn her into a weapon he could use to conquer Earth. Thankfully, his plan was foiled by the X-Men, who, in the aftermath, invited Dane into their ranks.",
                    "Dane took on the codename of Polaris and gradually became a regular face around X-Men headquarters. She worked hard to uncover her true parentage and to eventually reconnect with her long-lost father.",
                    "For many years, Polaris was in a relationship with Havok (Alex Summers). Although their romance ended in a messy breakup, they managed to patch things up well enough to continue working together.",
                    "Although she isn’t on any Krakoan councils, Polaris is a highly respected member of the mutant nation. She currently acts as a backup for both X-Factor and the X-Men."
                ],
                Personality =
                [
                    "Polaris has experienced more than her share of being kidnapped, brainwashed or otherwise possessed. All this suffering and confusion has worn the edges off her heroic spirit, but she still tries to help out where she can. She’s not the type to hold grudges, and despite Magneto’s abandonment of her, she’s on good terms with him. She is widely considered to be both a good friend and a skilled investigator.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "President Norman Osborn",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 1, resilience: 4, vigilance: 4, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
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
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
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
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Norman “Ozzy” Osborn",
                Heights = [new() { Feet = 7, Inches = 2 }],
                Weights = [880],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Symbiote-bonded head, kept alive in a massive cyborg body",
                Occupations = [OccupationName.Leader, OccupationName.Tycoon],
                Origins = [OriginName.HighTechCybernetics, OriginName.SymbioteVenom],
                Teams = [TeamNames.ThunderboltPoliceDepartment],
                Base = "Washington, DC (Earth-138)",
                History =
                [
                    "At some point in Earth-138’s past, corporatebacked totalitarian fascism took over the United States. Oscorp C.E.O. Norman “Ozzy” Osborn declared himself President for Life and, to cement his rule, created V.E.N.O.M.— a powerful symbiotic mesh that rendered him and his cronies in the Thunderbolt Department virtually indestructible.",
                    "Osborn’s rule dragged on for years until resistance leaders Spider-Punk and Captain Anarchy used the sonic energy generated by a massive pile of amplifi ers to temporarily disable V.E.N.O.M. and give Spider-Punk the chance to destroy the president.",
                    "Unbeknownst to the resistance, Osborn’s followers took his dying head and used V.E.N.O.M. to revive their leader in a cybernetic body.",
                    "Spider-Punk and his Spider-Band of heroes went to Washington, DC, to clean up the remnants of Osborn’s empire, only to fi nd Osborn waiting for them. He captured the core band and was about to execute them on the steps of the Lincoln Memorial when the Spider-Band’s backup members intervened, allowing Spider-Punk to escape and destroy Osborn again.",
                    "Spider-Punk’s world is safe from Osborn—at least for now. The former president still has plenty of followers, and if there is any way to bring him back again, they’re sure to fi nd it."
                ],
                Personality =
                [
                    "This version of Norman Osborn closely resembles the exact sort of regressive politician that so much of the original punk movement was directed against. He’s an elderly yet sadistic narcissist with a slight Southern accent and a tone that could not be more condescending and bigoted.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Professor X (Charles Xavier)",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 2, vigilance: 9, ego: 9, logic: 9
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.CloakGroup),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.GrandFool),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.InformationUpload),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                        powerSelector.GetPower(PowerNames.TelepathicPossession),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Charles Francis Xavier",
                Heights = [new() { Feet = 6 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Educator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a mutant, Charles Xavier was gifted with powerful psychic abilities. Although he hid his own status as a mutant in his youth, Xavier decided to become an activist for mutant rights. He turned his old family mansion into a School for Gifted Youngsters and began recruiting young mutants across the globe.",
                    "It was within this school that Xavier founded the X-Men, a team of mutant heroes dedicated to showing the world just how helpful mutants can be. He later went on to expand the school and the number of mutant hero teams. He recently helped found a mutant homeland on the living island of Krakoa.",
                ],
                Personality =
                [
                    "Xavier’s greatest flaw is paternalism. He has the well-earned right to feel pride for his accomplishments, but his belief that he knows best leads him to occasionally make decisions for other people rather than leaving them to their own devices.",
                ]
            }
        },
        new()
        {
            Name = "Prowler",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 2, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
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
                    Name = "Prowler's Battle Suit",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)", powerSelector.GetPower(PowerNames.ElementalBurst, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalInfusion} (Energy)", powerSelector.GetPower(PowerNames.ElementalInfusion, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Jump1, powerSelector.GetPower(PowerNames.Jump1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty2, powerSelector.GetPower(PowerNames.Mighty2)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy1, powerSelector.GetPower(PowerNames.Sturdy1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Wallcrawling, powerSelector.GetPower(PowerNames.Wallcrawling)),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 7,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Aaron Davis",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [195],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Brothers Aaron Davis and Jeff Morales were thieves and gangsters in their teen years, but whereas Morales eventually escaped the life, Davis never did. In fact, he only got better at being a thief, moving up from small-time holdups to major heists, acquiring newer and better technology along the way.",
                    "Soon enough, he had a whole battle suit and alter ego. Under the codename Prowler, Davis became one of the most feared criminals in all of New York City. He loved being a master thief, right up until his job forced him to fi ght his beloved nephew, Spider-Man (Miles Morales).",
                    "Unwilling to kill his nephew or give himself up to the authorities, Davis settled for repeatedly sparring with Spider-Man, forcing their fi ghts into draws. After several of these tussles, Davis’ equipment backfi red and exploded, killing him.",
                    "When most of the Multiverse was destroyed and rebuilt, Spider-Man and his entire family, including Davis, were taken from their home universe of Earth-1610 and reincorporated into Earth-616. Having been given a second chance at life, Davis resolved to turn over a new leaf. After a few false starts, he quit the criminal life for good and became a force for justice, working alongside his nephew.",
                ],
                Personality =
                [
                    "Aaron Davis still doesn’t care much for the government or the law. For him, being a criminal just meant taking back what he deserved, getting righteous revenge on a world that was stacked against him since day one.",
                    "However, he does care for his nephew. Now that Davis has gone straight, he’s doing all he can to make Miles proud."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Prowler (Hobie Brown)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 1, resilience: 1, vigilance: 2, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
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
            ],
            IconicItems =
            [
                new IconicItem
                {
                    IsBattlesuit = true,
                    Name = "Prowler's Battlesuit",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.FastAttacks, powerSelector.GetPower(PowerNames.FastAttacks)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Jump1, powerSelector.GetPower(PowerNames.Jump1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty1, powerSelector.GetPower(PowerNames.Mighty1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy1, powerSelector.GetPower(PowerNames.Sturdy1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.ViciousAttack, powerSelector.GetPower(PowerNames.ViciousAttack)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Wallcrawling, powerSelector.GetPower(PowerNames.Wallcrawling)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.WhirlingFrenzy, powerSelector.GetPower(PowerNames.WhirlingFrenzy)),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 7,
                    IsTech = true
                }
            ],
            PowerNotes =
            [
                "Hobie Brown later develops a more powerful battle suit and adopts a new codename: Hornet. This profile represents Brown before that transformation."
            ],
            Biography = new Biography
            {
                RealName = "Hobart “Hobie” Brown",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Engineer],
                Origins = [OriginName.HighTechBattleSuit],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "Hobie Brown had a brilliant mind for inventions, but since he was from a poor family with no prospects, investors refused to take him seriously. Eventually, he was forced to get a job as a window washer just to put food on the table.",
                    "To make the job easier on himself, Brown developed custom equipment that would allow him to crawl up walls and blast cleaning liquid straight out of his hands. These inventions were decades ahead of their time, but Brown’s bosses considered them little more than an annoyance.",
                    "For Brown, this was the last straw. He made some modifications to his cleaning equipment and attempted to embark on a life of crime as the fearsome Prowler. However, before he could actually steal anything, Brown was defeated by Spider-Man (Peter Parker).",
                    "Spider-Man took pity on Brown and agreed to let him go, with the understanding that Brown would walk a more righteous path. From that day forward, Hobie dedicated himself to making NYC a better place.",
                    "Since then, Brown has made a name for himself as a super hero in his own right. He frequently works with Spider-Man, having even stood in for the infamous wall-crawler on a few occasions."
                ],
                Personality =
                [
                    "Hobie Brown is, fundamentally, a good guy. He disdains unnecessary violence, and although he can fi ght when he feels it’s unavoidable, Brown’s ideal super-hero patrol is one without any combat at all. He’s at his happiest when he is simply helping the people in his community get through the day.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Proxima Midnight",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 6, vigilance: 5, ego: 3, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Thanos’ army)"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Proxima Midnight’s Spear", isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Proxima Midnight’s Spear",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrage} (Energy)", powerSelector.GetPower(PowerNames.ElementalBarrage, reminder: "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBlast} (Energy)", powerSelector.GetPower(PowerNames.ElementalBlast, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)", powerSelector.GetPower(PowerNames.ElementalBurst, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalGrab} (Energy)", powerSelector.GetPower(PowerNames.ElementalGrab, reminder : "Energy")),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach + 1/10, Melee/Agility Damage Multiplier bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Large",
                    ],
                    PowerValue = 3,
                    MeleeDamageModifier = 1,
                    AgilityDamageModifier = 1
                }
            ],
            Biography = new Biography
            {
                RealName = "Proxima Midnight",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [190],
                Gender = Gender.Female,
                Eyes = "White",
                Hair = "Blue",
                Size = Size.Average,
                DistinguishingFeatures = "No irises, blue skin and hair",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.BlackOrder],
                Base = "Mobile",
                History =
                [
                    "Proxima Midnight and her husband, Corvus Glaive, were among Thanos’ earliest followers, and to this day, they remain among his most beloved subjects. They were the first to join the Mad Titan’s coveted inner circle—his Black Order—and it is they who have kept the Order running, even in the Titan’s absence.",
                    "Midnight serves as the proverbial tip of the Black Order’s spear. She is their battlefield commander and, more often than not, their functional leader. Her blade has tasted the blood of uncountable innocents, and her armies have sucked the life from entire planets.",
                    "Corvus Glaive is a masterful tactician, but his abilities in combat are limited. It would be nigh impossible for him, or Thanos, to execute their galaxy-conquering schemes without Midnight to lead the troops in battle.",
                    "Following Glaive’s recent resurrection, Midnight rebuilt the Black Order into a group of rogue mass murderers for hire, but the team has since returned to Thanos’ service."
                ],
                Personality =
                [
                    "Proxima Midnight is a military general through and through. Her speech is curt and formal, and when she moves in combat, she moves without mercy, slicing through her opponents with mathematical precision. As much as she enjoys battle, her face rarely wears any other expression than a scowl.",
                    "Despite her hard exterior, Midnight does have a soft spot for her husband. She has, at times, considered giving up the Black Order and settling down with Glaive."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Psylocke (Kwannon)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: $"{PowerNames.MentalPunch}"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.Flight2),
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
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MentalPunch),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Kwannon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [155],
                Gender = Gender.Female,
                Eyes = "Purple",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Marauders, TeamNames.TheHand, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Kwannon was raised from birth by the shadowy Hand organization to become a super-powered assassin, but she balked at the cold-blooded murder of innocents. It wasn’t long before she turned against her handlers, slaughtering them and escaping to Japan.",
                    "Shortly thereafter, Kwannon suffered an accident that left her comatose. While she slept, Betsy Braddock—another mutant psychic on the verge of death—swapped bodies with Kwannon. Only recently did Kwannon manage to regain control over her own body. In the short career she’s had since, she has already proven herself as a capable leader among the X-Men.",
                ],
                Personality =
                [
                    "Although the traumatic events of her past have filled Kwannon with some deep-seated anger and resentment, she retains a cool head for battle. She’s an effective tactical leader, and she’s well trained in focusing her fury at those who most deserve it.",
                ]
            }
        },
        new()
        {
            Name = "Public Eye Agent",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.TechReliance),
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Energy Pistol", isTech: true),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Energy Pistol",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.EffectOptions, reminder: "Stuns target on a Fantastic success"),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: 10, Agility Damage Multiplier bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Small",
                    ],
                    PowerValue = 1,
                    AgilityDamageModifier = 1,
                    IsTech = true
                }
            ],
            IsHenchman = true,
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Puck",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 4, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Small),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.Heroic),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Eugene Milton Judd",
                Heights = [new() { Feet = 3, Inches = 6 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Small,
                DistinguishingFeatures = "Unusually short and buff stature, slightly deformed right ear",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicDemonic],
                Teams = [TeamNames.AlphaFlight, TeamNames.BetaFlight, TeamNames.GammaFlight],
                Base = "Mobile",
                History =
                [
                    "Eugene Judd made a name for himself in the early twentieth century as a mercenary and a fortune hunter, specializing in the acquisition of supernatural items. Then one day, Judd uncovered a dark blade he was hired to seek that would change the course of his entire life.",
                    "The blade contained a dark and malevolent spirit that entered Judd’s body, imbuing him with incredible strength and longevity, but at a price. He was shrunken down and filled with chronic pains that would plague him the rest of his days.",
                    "Judd spent the next several decades in and out of jail, struggling to find work, only to eventually stumble into the same social circles as Guardian (James Hudson). Sensing potential in the mercenary, Guardian recommended Judd for Canada’s premier super-hero team, Alpha Flight. Under the codename Puck, Judd spent most of the next decade adventuring with the Alpha Flight crew, helping to protect Canada from threats around the world.",
                    "These days, Judd and several of his old Alpha Flight comrades spend most of their time working with Gamma Flight, an experimental program dedicated to protecting the world from Gamma-radiation-related threats.",
                ],
                Personality =
                [
                    "Puck is the epitome of a classic twentieth-century, hypermasculine, hard-drinking, thrill-seeking, book-reading adventurer, in the style of Ernest Hemingway. He can do a dozen somersaults in a row while quoting the Bard, and he regularly does, just to show off.",
                    "Although he can be a bit old-fashioned at times, Puck is a valuable and reliable friend. His teammates in Alpha Flight and Gamma Flight consider him an essential member of the crew."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Purifier",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 0, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Purifiers)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Mini-flamethrowers (can fire Elemental Burst (Fire))"),
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
                    Name = PowerSetNames.ElementalControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.Purifiers],
                Base = "Varies",
                History =
                [
                    "As an up-and-coming U.S. Army sergeant, William Stryker’s mind broke when his wife gave birth to a mutant child. He stabbed the child and murdered his wife, then dropped out of the army to become an anti-mutant preacher. He quickly amassed a massive and puritanical following, and using his old army training, he trained a handful of his closest followers into a militia.",
                    "Intent on cleansing the Earth of all mutant life, Stryker began referring to his militarized followers as the Purifiers. He directed them to kidnap Professor X and force him to psychically destroy every mutant on the planet. They came within a hair’s breadth of succeeding before the X-Men defeated them and sent Stryker to prison.",
                    "Stryker attempted several times to return and rebuild the Purifiers. The X-Men beat him again and again, but every time, he came back stronger and in a less-human form. Eventually, Sabretooth tracked down Stryker in Hell and annihilated his soul, ending him once and for all.",
                    "Stryker may be dead, but his cult lives on. Most of the remaining Purifiers have allied themselves with newer anti-mutant groups like the Homines Verendi and Orchis."
                ],
                Personality =
                [
                    "While personalities of individual Purifiers may vary, they are united in their hatred of mutantkind. They claim to believe they have been anointed—either by God or some other higher power—to cleanse the world of mutants and usher in a golden age for humanity. But most of the Purifiers know, deep down, that they are simply bigots using religion to justify heinous deeds.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Pyro",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 3, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "St. John “Johnny” Allerdyce",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [150],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Black, skull-shaped face tattoo",
                Occupations = [OccupationName.Adventurer, OccupationName.Criminal],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.Marauders],
                Base = "Krakoa",
                History =
                [
                    "As a renowned novelist, journalist and adventurer, Johnny Allerdyce scarcely felt the need to exercise his mutant powers. Then one day, Mystique approached him, promising to show him adventures unlike any he’d seen before—on the condition that he’d agree to join her terrorist group, the Brotherhood of Evil Mutants.",
                    "Allerdyce accepted. Under the codename Pyro, he followed Mystique from the Brotherhood to Freedom Force and back to the Brotherhood again, all the while enjoying a luxurious life of crime and international intrigue.",
                    "Pyro finally encountered an enemy he could not simply incinerate: the Legacy Virus. Terminally ill and stricken with grief, he did his best to make amends before succumbing to the disease.",
                    "In a test of the mutant resurrection protocols, Pyro became one of the first mutants to be brought back to life on Krakoa. Outraged by the experimental nature of his revival, Pyro snuck aboard the Marauders’ flagship, fully intending to hijack the vessel, only to end up falling asleep there and getting drafted onto the team. Luckily, the lifestyle of a globe-trotting Marauder suited him well.",
                ],
                Personality =
                [
                    "Pyro is, above all other things, a thrill seeker. He became a villain because he thought it might be fun. When that got boring, he became a hero instead. One night, when he was drunk and a little depressed, he got a massive black skull tattooed on his face.",
                    "On the whole, Pyro is a fast-talking adrenaline junkie with little respect for anyone who wouldn’t be willing to jump off a cliff with him at a moment’s notice."
                ]
            },
            Source = BookSource.XMenExpansion
        },
    ];
}
