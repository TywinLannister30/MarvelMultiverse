using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersG
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
            Name = "Gambit",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 4, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
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
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bo staff (+1 melee damage multiplier bonus; range: reach +1)"),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Charged cards [These act as knives, usually thrown. Using Elemental Infusion on them costs 0 Focus. Cards function only for Gambit.]"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
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
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
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
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Remy Étienne LeBeau",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [179],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Black eyes with red irises",
                Occupations = [OccupationName.Adventurer, OccupationName.Criminal],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Excalibur, TeamNames.ThievesGuild, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "After being rejected by his biological parents, infant Remy LeBeau was adopted by members of the international criminal organization known as the Thieves’ Guild. LeBeau quickly took up the profession of his caretakers, and by the time he was a young man, he had become one of the greatest thieves on the planet.",
                    "In the midst of one heist, LeBeau encountered the mutant hero Storm in a vulnerable position, having been de-aged into a child by agents of the Shadow King. Having once been a vulnerable child himself, LeBeau helped Storm defeat the Shadow King, and she, in return, invited him to join the X-Men.",
                    "Although he was not as invested in mutant politics as his colleagues, LeBeau found life among the X-Men thrilling and rewarding. As Gambit, he spent years adventuring alongside the mutant heroes, all the while romancing his teammate Rogue.",
                    "Shortly before the foundation of Krakoa, Gambit and Rogue finally got married. Although they acted as backup members of Krakoa’s Excalibur team, Rogue and Gambit have spent most of their time since their marriage focusing on each other and adventuring together across the globe."
                ],
                Personality =
                [
                    "In his younger years, Gambit was known as a smooth-talking ladies’ man. As a married man, he’s not as much of a flirt as he used to be, but he’s still a notoriously persuasive and charming individual. He speaks in a thick New Orleans accent and often peppers bits of Cajun French into his regular English speech.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Gambit (X-Men '97)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 6, resilience: 2, vigilance: 3, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Bo staff (+1 melee damage multiplier bonus; range: reach +1)"),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Charged cards [These act as knives, usually thrown. Using Elemental Infusion on them costs 0 Focus. Cards function only for Gambit.]"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
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
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
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
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Remy Étienne LeBeau",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [179],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Black eyes with red irises",
                Occupations = [OccupationName.Adventurer, OccupationName.Criminal],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "The roguish Cajun thief Remy LeBeau, alias Gambit, hails from the bayous of Louisiana. He and his family are members of the Thieves Guild, an ancient organization locked in an eternal rivalry with the Assassins Guild; both guilds vie for the favor of the powerful X-Ternal. Unlike his brethren in the Thieves Guild, LeBeau is a mutant, with the ability to charge any object he touches with energy, turning it into a dangerous explosive; he carries packs of playing cards to use as throwing weapons. He was betrothed to the Assassins Guild’s Bella Donna Boudreaux, but left her and the guild wars behind to join the X-Men. There, he pursued a romance with fellow Southerner Rogue; the attraction was mutual, but her mutant power left her unable to have physical contact with others, complicating their relationship. His past came back to haunt him when he had to journey back to Louisiana to save his brother, Bobby, which was part of Boudreaux’s plot to trap Gambit into marriage; with Rogue’s help, he saved Bobby, but vowed never to return. Recently, his and Rogue’s relationship was complicated by the arrival of Magneto as the X-Men’s new leader. Magneto had a past relationship with Rogue, and his control over the electromagnetic spectrum allowed the two of them to touch. The two reconnected, leaving Gambit feeling leftout. Subsequently, LeBeau was in Genosha when it was attacked by Sentinels under Bastion’s control; LeBeau sacrifi ced himself to save Rogue and the attack’s other survivors.",
                ],
                Personality =
                [
                    "Gambit is a charming, arrogant scoundrel who cares more about his friends than he lets on. He initially kept his distance from his teammates, but has gradually come to trust them and is a loyal member of the X-Men. He occasionally refers to himself in the third person.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Gamora",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 6, resilience: 5, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Nebula"),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
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
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedRun1),
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
                RealName = "Gamora Zen Whoberi Ben Titan",
                Heights = [new() { Feet = 6 }],
                Weights = [170],
                Gender = Gender.Female,
                Eyes = "Yellow",
                Hair = "Dark green",
                Size = Size.Average,
                DistinguishingFeatures = "Light green skin with yellow area around the eyes",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Graces, TeamNames.GuardiansOfTheGalaxy, TeamNames.UnitedFront],
                Base = "Mobile",
                History =
                [
                    "Gamora came from a possible future (Earth-7528) in which she was the last survivor of the Zen Whoberi race, which the Universal Church of Truth wiped out. Thanos brought her back to Earth-616 and adopted her so that he could forge her into the ultimate assassin and send her to kill the Magus, the founder of the Universal Church of Truth. After helping the Magus, her time loop changed so that the Badoon killed the Zen Whoberis instead.",
                    "Gamora later helped Adam Warlock stop Thanos from destroying the universe and then set out on her own. After helping end the Annihilation War, she joined the Guardians of the Galaxy. Since then, she’s been a key part of the team, often leaving it but always rejoining.",
                ],
                Personality =
                [
                    "Gamora is sharp and focused, brooking no nonsense, the way that Thanos trained her. She often carries a great deal of anger and can be cold and intimidating to those around her, but she can also be intensely loyal to those few people she considers friends.",
                ]
            }
        },
        new()
        {
            Name = "Ghost Rider (Johnny Blaze)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 5, resilience: 5, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Johnny Blaze"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlHellfire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HellfireChains),
                        powerSelector.GetPower(PowerNames.PenanceStare),
                        powerSelector.GetPower(PowerNames.PossessVehicle),
                        powerSelector.GetPower(PowerNames.SenseSins),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Johnathon “Johnny” Blaze",
                Heights = [new() { Feet = 5, Inches = 10 }, new() { Feet = 6, Inches = 2 }],
                Weights = [180,220],
                Gender = Gender.Male,
                Eyes = "Blue/none ",
                Hair = "Blond/none",
                Size = Size.Average,
                DistinguishingFeatures = "Flaming skull for a head when transformed.",
                Occupations = [OccupationName.Adventurer, OccupationName.Engineer],
                Origins = [OriginName.SpiritOfVengeance],
                Teams = [TeamNames.SavageAvengers, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "To cure his adoptive father Crash Simpson’s terminal illness, Johnny Blaze summoned Mephisto and made him an offer: save Simpson’s life in exchange for Blaze’s eternal servitude. Mephisto agreed, but as with all deals with the devil, there was a catch. Mere days later, not knowing that he had been cured, Simpson decided to go out in a blaze of glory and died attempting to perform a nearly impossible motorcycle stunt.",
                    "Blaze, unfortunately, still had to hold up his end of the bargain. Mephisto imbued his new servant with an ancient Spirit of Vengeance named Zarathos, turning him into the brimstone daredevil known as Ghost Rider. Unable to fully control his dangerous new form, Blaze abandoned his remaining loved ones and began a lonely life on the road, traveling aimlessly from town to town and meting out justice to every criminal and demon foolish enough to cross his path.",
                    "Over the years, Blaze’s travels have taken him just about everywhere. He’s fought alongside the likes of the Avengers and seen the sun rise in distant dimensions. On one adventure, he even managed to depose Mephisto and install himself as the King of Hell.",
                    "Blaze has been depowered, repowered, killed and resurrected, and he’s reigned in Hell and served in Heaven. But no matter what happens to him, he always returns to the status quo: just him and Zarathos riding into the unknown."
                ],
                Personality =
                [
                    "For many years, Blaze and Zarathos resented each other. Blaze wanted to live a normal life, while the spirit wanted to wreak vengeance everywhere. Eventually, they reached something of an equilibrium. Blaze has resigned himself to the life of a Ghost Rider, and Zarathos holds back his thirst for vengeance when Blaze asks.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Ghost Rider (Robbie Reyes)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 5, vigilance: 2, ego: 7, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.PartialPhase),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.PhaseSelf),            
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Ghost Rider Form"),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Form"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Gabe Reyes"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty4),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlHellfire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalInfusion),
                        powerSelector.GetPower(PowerNames.ElementalProtection3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HellfireChains),
                        powerSelector.GetPower(PowerNames.PenanceStare),
                        powerSelector.GetPower(PowerNames.PossessVehicle),
                        powerSelector.GetPower(PowerNames.SenseSins),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpeedRun1),
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
                RealName = "Robbie Reyes",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Flaming skull for a head when transformed.",
                Occupations = [OccupationName.Engineer],
                Origins = [OriginName.SpiritOfVengeance],
                Teams = [TeamNames.Avengers, TeamNames.SpiritsOfVengeance],
                Base = "Los Angeles",
                History =
                [
                    "Robbie Reyes was just a poor kid living in East L.A. when he was gunned down by gangsters. Reyes would have died were it not for a nearby vengeful spirit. The ghost of a serial killer, a man named Eli, had been secretly haunting Robbie’s car. Eli possessed Reyes, healing the boy’s wounds and transforming him into a Ghost Rider.",
                    "Reyes’ good nature was matched only by Eli’s bloodthirst. The two fought for control of Reyes’ body until a bit of assistance from another Ghost Rider (Johnny Blaze) allowed Reyes to finally get the best of Eli. Free of Eli’s influence, Reyes joined the Avengers and vowed to help rid the world of evil.",
                ],
                Personality =
                [
                    "As an orphan, Reyes’ primary motivation in life is to act as a guide and protector to his younger brother, Gabe. Around others, Reyes can be anxious and distant, but in Gabe’s presence, Reyes always puts up a tough front.",
                ]
            }
        },
        new()
        {
            Name = "Ghost-Spider",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity, reminder: "Earth-65"),
                tagSelector.GetTag(TagNames.Radioactive),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "Earth-616"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalPortal),
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderSense),
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
                RealName = "Gwen Stacy",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Symbiote, OriginName.WeirdScience],
                Teams = [TeamNames.SpiderArmy, TeamNames.SpiderSociety, TeamNames.WebWarriors],
                Base = "New York City",
                History =
                [
                    "On Earth-65, teenager Gwen Stacy was bitten by a genetically engineered spider and gained spider-based powers. Soon after, she became her world’s costumed crime-fighting Spider-Woman. In an early adventure, she battled her friend Peter Parker—who had not acquired spider-powers in this universe but had turned himself into the Lizard in an attempt to become a hero like Spider-Woman—and accidentally killed him, a mistake she has been trying to make up for since.",
                    "After being drawn into the multiversal battle of Spider-Totems against the murderous Inheritors, Stacy began traveling among worlds, particular between her own and Earth-616. After surviving the battle with the Inheritors, she took on the name Ghost-Spider. Her identity has become public in her universe, but she enjoys the anonymity she often finds in other worlds. At one point, Stacy lost her spider-powers, but she regained them after bonding with a sentient costume made of synthetic spiders. She also has pendant/bracelet called the Ticket to the Multiverse that allows her to move between worlds.",
                    "Recently, after her own world was devastated by a mysterious disaster, Stacy moved to Earth-616 on what appears to be a more permanent basis. With the help of her Earth-616 friends, she seems to be gradually getting her life back in order."
                ],
                Personality =
                [
                    "Stacy is smart and friendly, an independent free spirit who enjoys playing drums in her rock band, the Mary Janes. Growing up the daughter of police detective George Stacy helped instill a strong sense of justice in her, and she tries to live up to her own ideals every day. She doesn’t always manage it, but she’s determined to keep making the effort.",
                    "When Ghost-Spider first bonded to her symbiotic costume, it briefly made her aggressive, feeding upon her existing anger and frustration. Though it hasn’t overtly affected her emotions since that initial incident, the suit could still come back to bite her, given the right circumstances."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Giant-Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 4, ego: 2, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                        powerSelector.GetPower(PowerNames.MacrodimensionalTravel),
                        powerSelector.GetPower(PowerNames.MicrodimensionalTravel),
                        powerSelector.GetPower(PowerNames.ResizeObject),
                        powerSelector.GetPower(PowerNames.ResizeOther),
                        powerSelector.GetPower(PowerNames.Shrink4),
                        powerSelector.GetPower(PowerNames.ShrinkingDodge),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "insects"),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Henry Jonathan “Hank” Pym",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually 6'",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually 185 lbs.",
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.Avengers],
                Base = "Avengers Mansion",
                History =
                [
                    "A brilliant young scientist, Hank Pym lost his first wife, Maria, when she was gunned down by members of the Hungarian secret police. Determined to create a world free of senseless violence, he vowed to use his scientific prowess for the betterment of all humanity.",
                    "Pym’s first major discovery came in the form of Pym Particles, a mysterious substance that allows any who touch it to grow and shrink at will. Armed with these powers, Pym and his eventual second wife, the Wasp (Janet Van Dyne), became founding members of the heroic Avengers.",
                    "Later on in life, a combination of stress and exposure to unstable Pym Particles sent Pym into a nervous breakdown, during which he struck the Wasp and became the first member of the Avengers to be formally removed from the team. The pair subsequently divorced. Though Pym’s mind eventually recovered, his past acts continued to haunt him, despite his struggles to redeem himself.",
                    "Pym has gone by a number of titles over the years—Ant-Man, Yellowjacket, Goliath and even Wasp—but this profile represents him during his halcyon days, back when he was simply Giant-Man."
                ],
                Personality =
                [
                    "Pym’s blind ambition often drives him to create things the world would be better off without, including, most famously, the super villain Ultron. He’s spent countless hours trying to unmake the evil robot, but more often than not, his proposed solutions have only created more problems.",
                    "In his best moments, Pym is a thoughtful inventor and a fearless hero. But in his worst, he can end up putting himself, and the people around him, in real danger."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Giant-Man (Raz Malhotra)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 2, vigilance: 3, ego: 2, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
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
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Raz Malhotra",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechPymParticles],
                Teams = [TeamNames.AgentsOfAtlas],
                Base = "Mobile",
                History =
                [
                    "Raz Malhotra spent his whole life studying the science of artificial intelligence, only to graduate from college during an unprecedented wave of anti-A.I. sentiment. Unable to find any career opportunities in A.I., Malhotra reluctantly took a tech-support job with the shady and reclusive Dr. Elihas Starr.",
                    "Unfortunately, Starr was secretly a madman bent on taking over the world. He brainwashed Malhotra and forced him to build evil robot duplicates of the Avengers. Malhotra eventually broke free of Starr’s influence and teamed up with Hank Pym—the original Giant-Man—to help destroy the robots. When Pym later seemingly died fighting Ultron, Malhotra was entrusted with the title of Giant-Man.",
                ],
                Personality =
                [
                    "Although still technically a novice adventurer, Malhotra has the confi dence and wit of a seasoned hero. He’s not the type to flinch in the heat of battle, even with a gun pointed at his head.",
                ]
            }
        },
        new()
        {
            Name = "Giganto",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 6, resilience: 7, vigilance: 6, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.UnusualSize, specialization: "Gigantic"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Subterranea"),
                tagSelector.GetTag(TagNames.Mute),
                tagSelector.GetTag(TagNames.Mysterious),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.FocusedFury),
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
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
                RealName = "Giganto",
                Heights = [new() { Feet = 45 }],
                Weights = [],
                WeightReminder = "40 tons",
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "None",
                Size = Size.Gigantic,
                DistinguishingFeatures = "Giant, scaly bipedal monster",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Monstrous],
                Teams = [],
                Base = "Subterranea",
                History =
                [
                    "Members of the Deviant race created huge mutates to aid them in their battles against the Eternals. When their plot was discovered, the mutates were abandoned on Monster Island and the tunnels below. They were later found and now serve the Mole Man. Giganto, one of the largest of these mutates, became Mole Man’s greatest defender and weapon.",
                    "A large, powerful, semi-reptilian creature that can burrow through the earth with ease, Giganto was used by Mole Man in one of his first attacks on the surface world, undermining power plants and even cities. He and the Mole Man were defeated by the Fantastic Four in their first adventure.",
                ],
                Personality =
                [
                    "Giganto is basically a wild animal that has a certain amount of affection for and subservience to the Mole Man. He has a similar looking female mate, and the two were present during a scheme to control the Inorganic Technotroid, though the artificial being was “born” within the hands of Giganto’s mate, thus imprinting her as its “mother.”",
                ]
            },
            Source = BookSource.FantasticFourFromTheDepths
        },
        new()
        {
            Name = "Gorgon",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 3, resilience: 5, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Inhuman Royal Guard)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                        powerSelector.GetPower(PowerNames.Jump1),
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
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Gorgon Petragon",
                Heights = [new() { Feet = 6, Inches = 8 }],
                Weights = [485],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Hooved feet",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.HouseOfAgon, TeamNames.InhumanRoyalGuard],
                Base = "Mobile",
                History =
                [
                    "Born into an off shoot of the royal House of Agon, Gorgon Petragon was taught from a young age to revere and respect Inhuman royalty. As a young man, he befriended the future Inhuman king, Black Bolt, pledging his loyalty to the young prince. In the years since, Gorgon has never strayed far from Black Bolt or his queen, Medusa.",
                    "As the head of the Inhuman Royal Guard and the personal bodyguard of the royals themselves, Gorgon has been entrusted with the protection and preservation of the House of Agon. This is a job he takes with deadly seriousness, one he continued to perform even after Black Bolt was forced to kill the bulk of the Inhuman population.",
                    "If he can be convinced that doing so would be in the Royal Family’s best interests, Gorgon has sometimes been known to work against the royals’ wishes. On multiple occasions, the Inhuman villain Maximus has used this fact to manipulate Gorgon into attacking those he was sworn to protect.",
                ],
                Personality =
                [
                    "Gorgon’s unfl inching loyalty to the House of Agon is both his greatest strength and his greatest weakness. He stops at nothing to ensure the safety of the Inhuman Royal Family. In times of relative unity, this dedication has been an immense boon for the royals. In times of division and confusion, Gorgon can be as much a danger as an asset.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Gorgon (Tomi Shishido)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 3, vigilance: 4, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.FocusedFury),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Tomi Shishido",
                Heights = [new() { Feet = 6, Inches = 4 }],
                Weights = [215],
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Glowing yellow eyes, pale-gray undead skin",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.GreatCaptainsOfKrakoa, TeamNames.TheHand, TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "Unlike most mutants, Tomi Shishido’s powers began to manifest almost immediately after his birth. As a mere toddler, Shishido had the skills to rival the world’s greatest artists. His intelligence advanced so quickly and erratically that by the time he was a teenager, something fundamental within his psyche could no longer bear the strain. He became increasingly despondent and, eventually, violent.",
                    "At the age of eighteen, Shishido killed his entire family. Shortly thereafter, he took control of the Hand and merged the ninja organization’s already considerable resources with those of Hydra. As the mighty Gorgon—high commander of both Hydra and the Hand—Shishido committed himself to sowing death and destruction across the globe.",
                    "For the good of mutantkind, the founders of Krakoa convinced Shishido to put aside his evil ways. However, few doubt that he could return to his old patterns under different circumstances.",
                    "As a man who cares deeply about the well-being of Japan, Wolverine (Logan) keeps tabs on Shishido. He has already foiled Gorgon’s plots for world domination several times, and if and when the time comes, he will be prepared to do so again."
                ],
                Personality =
                [
                    "Unlike most members of Hydra, Gorgon is not a fascist. Rather, he is an extreme nihilist. He sees the world as only a cruel joke played by an unloving god. In his heart, he desires nothing more than to wipe the slate clean and destroy all of creation. Hydra and the Hand are simply means to that end.",
                    "Rumors hold that—like the monster of Greek myth from which he takes his name—Gorgon can turn a person to stone with a single glance. However, no one has witnessed this happen for a long time, and it may be that Gorgon himself is the source of these rumors."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Gorr the God Butcher",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 6, resilience: 8, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "All-Black the Necrosword [without All-Black, Gorr is powerless]"),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
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
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Gorr",
                Heights = [new() { IsUnknown = true }],
                Weights = [],
                UnknownWieght = true,
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Pale white skin covered in morphing black marks.",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien, OriginName.Symbiote],
                Teams = [],
                Base = "Black World of Gorr",
                History =
                [
                    "Born in a religious community on an inhospitable planet, Gorr’s life was marked by misfortune and starvation. As a child, he had to watch his parents die. As an adult, he formed his own family only to see them too be picked off one by one.",
                    "Gorr came to doubt the existence of the gods and was on the verge of giving up his faith altogether when a chance encounter with the dark god Knull imbued him with power of All-Black the Necrosword. Newly empowered, Gorr vowed to take revenge on the gods who had neglected him so.",
                ],
                Personality =
                [
                    "Gorr believes that the universe would be better off without gods, who all sat around in luxury while the people of his planet suffered. Why should they get to continue living while his own family had to die?",
                    "As powerful as he is vengeful, Gorr’s quest for the complete eradication of the gods has only ever been hampered by the thunder god Thor—and by his own self-doubt."
                ]
            }
        },
        new()
        {
            Name = "Green Goblin (Early Days)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 2, vigilance: 2, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Spider-Man"),
                tagSelector.GetTag(TagNames.Headquarters),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
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
                        powerSelector.GetPower(PowerNames.QuickToss),
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
                RealName = "Norman Osborn",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Tycoon],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "From an early age, Norman Osborn had a relentless drive to succeed. Using notes stolen from his business partner, Osborn developed the Goblin formula to give himself superhuman powers. It also transformed Osborn into the Green Goblin— and set him on the road to insanity. He decided to use these powers to establish himself as the criminal leader of New York City. While doing so, he became enemies with Spider-Man (Peter Parker), who he later discovered to be his son Harry’s best friend. Although he seems to have died several times, Osborn keeps returning, apparently fated to be a constant thorn in Spider-Man’s side.",
                    "Though Norman Osborn was recently cleansed of the darker parts of his personality and is no longer the Green Goblin, this profi le represents him in his earliest days, before he had his Goblin Glider or many of his later gadgets, back when he was still trying to establish himself in New York City’s underworld. He has some basic weapons and a fl ying broomstick, but he has yet to become the Green Goblin that everyone knows."
                ],
                Personality =
                [
                    "Osborn is a smooth operator, a wealthy, powerful and sharp schemer who is often several steps ahead of his foes. He is often cool and collected— right up until something frustrates his plans, at which point he becomes unhinged.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Green Goblin (Earth-1610)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 1, resilience: 5, vigilance: 3, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
                tagSelector.GetTag(TagNames.Headquarters),
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
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
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump2),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Norman Osborn",
                Heights = [new() { Feet = 5, Inches = 11 }],
                HeightReminder = "7' (in Goblin form)",
                Weights = [185],
                WeightReminder = "1,000 lbs. (in Goblin form)",
                Gender = Gender.Male,
                Eyes = "Blue, red (in Goblin form)",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Hulking green goblin form with horns, spikes and orange blood",
                Occupations = [OccupationName.Criminal, OccupationName.Tycoon],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.UltimateSix],
                Base = "New York City (Earth-1610)",
                History =
                [
                    "With backing from S.H.I.E.L.D., Norman Osborn and his Oscorp researchers were able to accomplish Osborn’s lifelong dream: the creation of a Super-Soldier formula that could usher in the next stage in human evolution. An early version of this formula, fi ltered through the blood of an arachnid test subject, found its way into the body of Peter Parker. However, the first true human subject for the fi nished Oz formula was Osborn himself.",
                    "The formula enhanced Osborn’s body, allowing him to take on a hulking goblin-like form at will, but it also enhanced his narcissism and delusions of godhood. The knowledge that Parker existed— that there was another person with powers like him—was too much for Osborn to handle. In a bout of rage, he butchered his own family and then set out to murder Parker.",
                    "As Spider-Man, Parker narrowly managed to defeat Osborn and remand him into S.H.I.E.L.D. custody. After several further bouts with the wallcrawler, Norman put together a plan to leverage all the abilities of his Ultimate Six team and take out Parker once and for all. Parker ultimately won the fight, but in the process, both he and Osborn were killed.",
                    "Many months later, the formula in their blood brought both Osborn and Parker back to life, and they resumed their old rivalry."
                ],
                Personality =
                [
                    "Osborn is obsessed with the idea of perfection, of becoming a godlike being free of human concepts like morality and justice. But as much as he would like to be, he is not entirely free of guilt. He regrets having killed his son, Harry, though with the Oz formula fl owing through Harry’s veins too, that death may not be as permanent as Osborn thinks.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Green Goblin (Norman Osborn)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 4, vigilance: 2, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Spider-Man"),
                tagSelector.GetTag(TagNames.Headquarters),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pumpkin Bombs (act as frag grenades)"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
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
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
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
            Biography = new Biography
            {
                RealName = "Norman Osborn",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Tycoon],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DarkAvengers, TeamNames.GoblinNation, TeamNames.SinisterSix, TeamNames.Thunderbolts],
                Base = "New York City",
                History =
                [
                    "From an early age, Norman Osborn had a relentless drive to succeed. Using notes stolen from his business partner, Osborn developed the Goblin formula to give himself superhuman powers. It also transformed Osborn into the Green Goblin— and set him on the road to insanity. He decided to use these powers to establish himself as the criminal leader of New York City. While doing so, he became enemies with Spider-Man (Peter Parker), who he later discovered to be his son Harry’s best friend. Although he seems to have died several times, Osborn keeps returning, apparently fated to be a constant thorn in Spider-Man’s side.",
                ],
                Personality =
                [
                    "Osborn is a smooth operator, a wealthy, powerful and sharp schemer who is often several steps ahead of his foes. He is often cool and collected— right up until something frustrates his plans, at which point he becomes unhinged.",
                ]
            }
        },
        new()
        {
            Name = "Greycrow",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 5, resilience: 3, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.Sniping),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
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
                    ],
                    IsTech = true
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
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "John Greycrow",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Grey",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Various cybernetic attachments",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.Hellions, TeamNames.Marauders],
                Base = "Krakoa",
                History =
                [
                    "Despite being an experienced combat veteran, John Greycrow was nearly unknown in the mutant community until he joined the mercenary squadron known as the Marauders. There, Greycrow forged the fledgling team into a lethal force capable of rivaling a small military and set them to work.",
                    "On orders from Mister Sinister, Greycrow and his band tracked down the Morlocks, a society of mutant rejects living in the sewers beneath New York City. In an event known as the Mutant Massacre, Greycrow’s Marauders slaughtered nearly every Morlock.",
                    "The X-Men tracked Greycrow down and executed him, but the damage had been done. In the coming years, his name became synonymous with the term “mass murderer.”",
                    "Greycrow was eventually resurrected by the Krakoan government, but only so they could make him part of the new Hellions: a secret strike team of former villains. Ironically, being forced to work as a hero finally led Greycrow to regret his life as a villain.",
                    "Greycrow knows he can never atone for his past, but now that his sentence with the Hellions has been served, he hopes to live out the rest of his days in relative peace."
                ],
                Personality =
                [
                    "Although he might appear to be nothing more than another serious, hard-talking, cigar-smoking merc, Greycrow has some deep insecurities hidden within his psyche. He became a killer not out of a love of violence, but because he believed that it was the only thing a person as worthless as him could be any good at.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Groot",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 6, vigilance: 2, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mute, reminder: "Can only say “I am Groot.”"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BodySphere),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.StiltSteps),
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
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Groot",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Black",
                Hair = "Branches",
                Size = Size.Average,
                DistinguishingFeatures = "Plantlike alien",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Groot hails from Planet X and is an alien member of the Flora colossi race, a people who resemble trees and educate their young via photosynthesis. After rebelling against the way his people treated other intelligent species, Groot was banished from his homeworld, and he took to adventuring around the galaxy. There, he met his best friend, Rocket Raccoon, and along with him, joined the Guardians of the Galaxy led by Star-Lord (Peter Quill).",
                    "Groot has nearly been killed a number of times, but on each occasion, he managed to regrow himself from as little remaining of himself as a splinter. He seems dedicated to helping others, especially Rocket and their fellow teammates in the Guardians."
                ],
                Personality =
                [
                    "Groot is talkative and intelligent, but due to his stiff and inflexible larynx, it appears to others that he can only say “I am Groot.” In actuality, those with a trained ear can discern what Groot is saying in the subtle sigh and breeze under the words.",
                ]
            }
        },
        new()
        {
            Name = "Growing Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 2, resilience: 5, vigilance: 2, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
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
                        powerSelector.GetPower(PowerNames.EnergyAbsorption),
                        powerSelector.GetPower(PowerNames.Mighty3),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow4),
                        powerSelector.GetPower(PowerNames.GrowingAttack),
                        powerSelector.GetPower(PowerNames.MacrodimensionalTravel),
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
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                    IsTech = true
                },
            ],
            PowerNotes =
            [
                "Whenever possible, the Growing Man uses the Energy Absorption power as a reaction. Every time he successfully uses this power, he automatically grows one size. He cannot willingly return to his default size."
            ],
            Biography = new Biography
            {
                RealName = "Varies",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Male,
                Eyes = "Varies",
                Hair = "None",
                Size = Size.Small,
                DistinguishingFeatures = "Robotic humanoid with bright orange skin",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.HighTechAndroid],
                Teams = ["Ally to Kang the Conqueror", TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "As part of his usual plans to cement himself as ruler of the known multiverse, Kang the Conqueror created the world’s fi rst stimuloid: an artifi cial human with the ability to absorb kinetic energy and turn it into mass. Kang proudly named his creation the Growing Man, and he buried it in Earth’s ancient past for safekeeping.",
                    "In the early twenty-first century, a group of archaeologists working out of Manhattan inadvertently uncovered this stimuloid, awakening it much earlier than Kang had wished. Without the guidance of his creator, the Growing Man embarked on a wild rampage that drew Kang to that period of time. In the end, it took Thor himself to stop both the Growing Man and Kang himself.",
                    "Kang has rebuilt the Growing Man several times, only to see the stimuloid defeated again and again. He long ago abandoned any hope that the Growing Man would be his ultimate weapon, and these days he mostly uses the android as a bodyguard."
                ],
                Personality =
                [
                    "The Growing Man is intelligent, but only at the level of a toddler. Though he does not really understand why, he has an instinctive loyalty to his creator. Nothing bothers him more than the idea that Kang may have betrayed or otherwise abandoned him.",
                    "The Growing Man’s control over his own powers is limited, and a slow and steady beating can force him into a spiral of uncontrollable growth. Whenever the Growing Man is in the fi eld, Kang carries a “De-Energizer” gun capable of instantly reverting the stimuloid to his default size of small."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Guardian",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 4, vigilance: 3, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "covered by suit"),
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
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy3, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "James MacDonald Hudson",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.AlphaFlight, TeamNames.OmegaFlight, TeamNames.RCMP],
                Base = "Ottawa",
                History =
                [
                    "Canadian patriot James Hudson got sucked into the world of super heroes while working for a multinational oil conglomerate. Hudson developed an exosuit that would allow workers to safely and easily search for oil underground. Rather than using this suit for its intended purpose, Hudson’s employers attempted to steal his designs and sell them to the American military.",
                    "As quickly as he could, Hudson blew the whistle on his bosses and fled into the custody of the Canadian government. The government offered Hudson their complete protection, on the condition that he use his suit in the defense of Canada.",
                    "Under the codename Guardian, Hudson worked with the government to form a super-team capable of defending Canada against any threat. He called this team Alpha Flight.",
                    "Almost continuously since then, Hudson has been the leader of Alpha Flight. He’s had to install a number of cybernetic implants in himself over the years to keep up with the times, but his commitment to Alpha Flight—and to Canada—has never been in question.",
                ],
                Personality =
                [
                    "Guardian represents the ideals of Canada in the same way that Captain America represents the ideals of the United States. He’s soft-spoken, strong, and, above all, kind to those around him.",
                    "Hudson’s unflinching loyalty to the Canadian government has, on occasion, led him astray, but in the end, his commitment to justice always puts him back on the right track.",
                    "Although he is not a mutant, many of Hudson’s teammates are, and he often gets mixed up in the world of mutant politics. The mutant hero Wolverine (Logan) was among the earliest members of Alpha Flight."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Gwenpool",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.FreshEyes),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MediaAwareness),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
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
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.RealityManipulation)
            ],
            Biography = new Biography
            {
                RealName = "Gwendolyn “Gwen” Poole",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond, with dyed pink tips",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.GwenHive, TeamNames.MODOK, TeamNames.WestCoastAvengers],
                Base = "Mobile",
                History =
                [
                    "Gwendolyn Poole grew up in a world much like our own, in which the heroes and villains of Earth-616 exist only as fictional characters. As a high-school dropout with few prospects in life, she spent her days holed up in her room, reading hundreds of comics, all the while wishing that she could be a Marvel character herself.",
                    "Then, somehow, it happened. Poole was sucked onto the real Earth-616, where she immediately threw on a costume and began working her way up the ranks of the underworld as the unbelievable Gwenpool.",,
                    "Poole’s awareness of Marvel tropes allowed her to quickly propel herself into a position of power, but success brought her no satisfaction. Eventually, she sought out her brother, Teddy, who tried to return them to their homeworld, but only stranded them in a similar-looking comic book dimension.",
                    "Through sheer willpower, Poole pierced the veil of this false world and gained the ability to traverse the spaces between panels and rewrite the reality of comic books themselves. Shocked by the implications of her new powers, Poole returned to Earth-616 and rededicated herself to the life of a hero. Since then, she’s worked with the West Coast Avengers, the X-Men and even other versions of herself."
                ],
                Personality =
                [
                    "In her early days, Gwenpool was violent at best and outright murderous at worst. It took a long time for her to begin thinking of the denizens of Earth-616 as real people rather than fictional fodder.",
                    "However, she’s since learned the error of her ways, and the super-hero community now knows her for what she is: an excitable nerd with a good heart. Though she loves romance stories, Poole personally identifies as asexual and aromantic."
                ]
            },
            Source = BookSource.AvengersExpansion
        },
    ];
}
