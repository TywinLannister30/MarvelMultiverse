using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors.Characters;

namespace MarvelMultiverse.Selectors;

public class CharacterSelector(
    INarrativePowerSelector narrativePowerSelector,
    IPowerSelector powerSelector,
    ITagSelector tagSelector,
    ITraitSelector traitSelector) : ICharacterSelector
{
    public Character GetCharacter(string name)
    {
        var character = GetAllCharacters().FirstOrDefault(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        if (character == null) return null;

        SetUpCharacter(character);

        return character;
    }

    public List<Character> GetCharacters()
    {
        var characters = GetAllCharacters();

        foreach (var character in characters)
        {
            SetUpCharacter(character);
        }

        return characters;
    }

    private static void SetUpCharacter(Character character)
    {
        character.SetDefences();
        character.SetHealth();
        character.SetFocus();
        character.SetKarma();
        character.SetInitiative();
        character.SetSpeed();
        character.SetNonCombatCheckModifiers();
        character.SetDamageModifiers();
    }

    private List<Character> GetAllCharacters()
    {
        var allCharacters = new List<Character>();
        allCharacters.AddRange(CharactersA.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersB.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersC.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersD.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersE.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersF.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersG.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersH.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersI.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersJ.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersK.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersL.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersM.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersN.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersO.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersP.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersQ.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersR.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersS.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(GetAllCharactersT());
        allCharacters.AddRange(GetAllCharactersU());
        allCharacters.AddRange(GetAllCharactersV());
        allCharacters.AddRange(GetAllCharactersW());
        return allCharacters;
    }

    private List<Character> GetAllCharactersT() =>
    [
        new()
        {
            Name = "Taskmaster",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 5, resilience: 2, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.Mysterious),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CloneMoves),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ShieldBearer,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.Shield1),
                        powerSelector.GetPower(PowerNames.ShieldBash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Anthony “Tony” Masters",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Skull mask",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.Hydra, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Tony Masters was born with photographic refl exes granting him the uncanny ability to perfectly mimic any fi ghting technique he witnesses. He spent years studying professional athletes and warriors, slowly building himself into one of the greatest hand-to-hand fighters on the planet.",
                    "Hoping to use his powers for good, Tony joined S.H.I.E.L.D., where he was dosed with an experimental variant of the Super-Soldier Serum, which enhanced his body but erased his memories. The amnesiac Tony donned a skull mask and decided to put his skills to more profitable uses, becoming the mercenary Taskmaster.",
                ],
                Personality =
                [
                    "Tony lacks any lofty political goals. He just loves to fight. Getting paid for it is just frosting on the cupcake. He eventually regained his memories of his time as a S.H.I.E.L.D. agent, but he kept on as a mercenary. He enjoys being the Taskmaster too much to let it go.",
                ]
            }
        },
        new()
        {
            Name = "Terror",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 4, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Head spikes [can extrude green spikes from his head that can be broken off and used as knives]"),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CopyAbility),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.CopyTrait),
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
                },
            ],
            PowerNotes =
            [
                "Terror’s Healing Factor and Power Control powers function only as long as he has a steady supply of body parts. To use any of his “Copy” powers, he must first steal a body part from his target and then attach it to himself."
            ],
            Biography = new Biography
            {
                RealName = "Unknown, sometimes goes by “Shreck”",
                Heights = [new() { IsVariable = true }],
                HeightReminder = "usually around 6'2\"",
                Weights = [],
                VariableWieght = true,
                WeightReminder = "usually around 170 lbs.",
                Gender = Gender.Male,
                Eyes = "Varies",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Patchwork body with reptilian torso and head; other parts salvaged from various humanoid species",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicDemonic],
                Teams = [TeamNames.MercsForMoney, TeamNames.TerrorInc],
                Base = "New York City",
                History =
                [
                    "Terror hails from Earth-88194, a world that resembles Earth-616 in some superfi cial ways but lacks costumed super heroes. In their place, Earth-88194 has the Shadow Dwellers, a mysterious and immortal off shoot of humanity that manipulates world affairs from behind the scenes.",
                    "Terror is not one of these Shadow Dwellers. Instead, he claims to have been a caveman who heroically defended his tribe of early humans from a demon. Unfortunately, before he could kill the demon, it infl icted a terrible curse upon him: He would live forever, but in a constant state of decay.",
                    "Terror spent the subsequent centuries wandering the planet, harvesting new parts for himself from corpses as the old bits decayed and fell away. Sometime during the medieval era, he met the love of his life, a knight named Talita. When she died, he sealed her left arm in iron and attached it to himself. It is the one part of his body that he has refused to ever replace.",
                    "In the modern era, Terror became a mercenary, first on Earth-88194, then later on Earth-616. Currently he lives in New York City, where he operates a private detective/mercenary business under the name of Terror Inc."
                ],
                Personality =
                [
                    "Terror’s personality largely resembles that of a classic P.I. He’s hardnosed and ruthless but not exactly cruel. However, the fi ne details of who Terror is shift constantly, as he absorbs a bit of the knowledge and personality of the people whose body parts he attaches to himself.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Thanos",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 4, resilience: 7, vigilance: 3, ego: 5, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.EternallyImmortal),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.MahdWyry),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Thanos",
                Heights = [new() { Feet = 6, Inches = 7 }],
                Weights = [985],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Chin furrows, purple skin",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Eternal],
                Teams = [TeamNames.Eternals],
                Base = "Mobile",
                History =
                [
                    "Although his parents are Eternals, Thanos was born on Titan (a moon of Saturn) with a rare genetic mutation giving him the appearance of a Deviant. Shunned by Eternal society for his resemblance to their ancient enemies, only one young woman dared to keep him company, and he fell for her hard. The woman eventually revealed herself to be the embodiment of Death, and to win her favor, Thanos set out to kill everyone in the universe.",
                    "Thanos has come close to achieving his ambitions a few times, once killing half the universe with a single snap of his fi ngers. However, his plans to exterminate all life have all been foiled in the end, often with the aid of his adopted daughters, Nebula and Gamora.",
                ],
                Personality =
                [
                    "Although often referred to as the Mad Titan, Thanos is both serious and eloquent. His murderous motives are born out of deep-seated feelings of loneliness and his lust for Death.",
                ]
            }
        },
        new()
        {
            Name = "Thing",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 3, resilience: 8, vigilance: 4, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Sturdy4),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "4 Yancy Street"),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                        powerSelector.GetPower(PowerNames.Wisdom),
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
                },
            ],
            Biography = new Biography
            {
                RealName = "Benjamin Jacob “Ben” Grimm",
                Heights = [new() { Feet = 6 }],
                Weights = [500],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "None",
                Size = Size.Big,
                DistinguishingFeatures = "Four digits on each limb, rocky skin",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FantasticFour],
                Base = "New York City",
                History =
                [
                    "As an experienced test pilot, Ben Grimm jumped at the opportunity to join his old college buddy Reed Richards on an experimental space mission. Just after takeoff, the ship was bombarded by cosmic rays, forcing them to make an emergency landing. Back on Earth, the crew realized they each had been uniquely transformed. Ben’s skin had turned rocky and hard, giving him a monstrous appearance. Although horrifi ed by his new visage, Ben joined the rest of the crew to form the Fantastic Four.",
                    "Ben has since married the blind sculptor Alicia Grimm (née Masters) and adopted two kids: a Kree boy named Jo-Venn and a Skrull daughter named N’Kalla.",
                ],
                Personality =
                [
                    "Ben can be gruff and combative and does not take slights against himself or his friends lightly. Years of living in the public eye have allowed him to reach some level of peace with his appearance, but it’s still a sore spot. When determined, Grimm will never quit, even when it seems as though he has reached the limit of his strength.",
                ]
            }
        },
        new()
        {
            Name = "Thor (Jane Foster)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 4, vigilance: 3, ego: 3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.GodHeritage, reminder: "via Mjolnir"),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Gorr the God Butcher"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Mjolnir [+1 Melee and Agility damage multiplier. Returns to thrower. Can only be wielded by the worthy.]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalRicochet),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlFog),
                        powerSelector.GetPower(PowerNames.ControlWeather4),
                        powerSelector.GetPower(PowerNames.Thunder),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jane Foster",
                Heights = [new() { Feet = 5, Inches = 7 }, new() { Feet = 5, Inches = 9 }],
                Weights = [135, 450],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown/blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.HealthCareWorker],
                Origins = [OriginName.MythicAsgardian, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers],
                Base = "New York City, Asgard",
                History =
                [
                    "Jane Foster served as a nurse for Doctor Donald Blake, the alter ego of Thor Odinson, with whom she fell in love. Thor’s father, Odin, separated them, though, and Foster went on to become a doctor herself, as well as a wife and mother. She later divorced her husband, who retained custody of their son.",
                    "While Foster battled breast cancer, Thor Odinson lost the ability to use his magic hammer, Mjolnir. The hammer reached out to Foster, who took possession of it and gained the power of Thor. Odinson gave his blessing and approved of Foster using the name Thor. Becoming Thor purged Foster’s body of the chemotherapy drugs fighting her cancer, though and aftr a series of adventures that nearly killed her, she gave up being Thor and succesfully fought her cancer. She later became a Valkyrie to help shepherd the souls of dead heroes to Valhalla.",
                ],
                Personality =
                [
                    "Foster is smart, capable and determined, able to stand up to Asgardian gods. Life has not always been kind to her, but she’s survived it all and come out more independent and capable than ever.",
                ]
            }
        },
        new()
        {
            Name = "Thor (Thor Odinson)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 8, agility: 4, resilience: 8, vigilance: 2, ego: 5, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Gorr the God Butcher"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2),

                        powerSelector.GetPower(
                            PowerNames.IconicWeapon,
                            specialization: "Mjolnir [+1 Melee and Agility damage multiplier. Returns to thrower. Can only be wielded by the worthy.]",
                            meleeDamageModifier: 1,
                            agilityDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.WeatherControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ControlWeather4),
                        powerSelector.GetPower(PowerNames.Thunder),
                        powerSelector.GetPower(PowerNames.WeatherChill),
                        powerSelector.GetPower(PowerNames.WeatherWarm),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Thor Odinson",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [640],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.Avengers, TeamNames.GodsOfAsgard, TeamNames.GodSquad],
                Base = "Asgard",
                History =
                [
                    "As the son of Odin—ruler of the Asgardian gods— Thor was destined for greatness. Raised alongside his adopted brother, Loki—the God of Mischief— Thor had many adventures as a youth. When Odin realized Thor needed to learn humility, he erased Thor’s memories and sent him to Earth as medical student Donald Blake. After learning his lesson, he recovered his powers and memories, and served both Asgard and Earth as Thor. After Thor (and a number of variants) defeated Malekith in the War of the Realms, he became the new All-Father of Asgard. Ruling over his people does not suit the thunder god, well as he prefers to be an active hero instead.",
                ],
                Personality =
                [
                    "Thor can be grim when faced with his responsibilities, but he feels most himself when given something he can strike with his enchanted hammer, Mjolnir—preferably a worthy foe. There is little he enjoys more than a drink after a wellfought battle. Despite all his time on Earth—and in America—he still speaks with an Asgardian accent and often in an old-fashioned way.",
                ]
            }
        },
        new()
        {
            Name = "Thunderball (Wrecking Crew)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 4, vigilance: 2, ego: 0, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Skeptical),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.LabAccess),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Thunderball and chain [Throwable club. Automatically returns to thrower.]"),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
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
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Eliot Augustus Franklin",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [325],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.Illuminati, TeamNames.WreckingCrew],
                Base = "Mobile",
                History =
                [
                    "Eliot Franklin was a world-renowned physicist who seemed to be living the dream—until the day he invented a miniature gamma bomb. The bomb’s design was brilliant, but as his reward, Franklin’s employers fi red him and patented the bomb in their own names instead of his.",
                    "Franklin tried to steal back his invention but was caught and sent to prison, where he wound up alongside Dirk Garthwaite, the super villain known as the Wrecker. Franklin and a couple of his fellow inmates helped break Garthwaite out of prison, and in exchange, Garthwaite granted them each a portion of his own powers. Together, these escapees formed the Wrecking Crew.",
                    "For most of his criminal career, Franklin has worked with the Wrecking Crew, but he did join the Hood’s version of the Illuminati for a while too."
                ],
                Personality =
                [
                    "Thunderball is known for being smarter and more restrained than the rest of the Wrecking Crew and has occasionally contested the Wrecker for the group’s leadership. He has stayed with the crew largely so that he can continue to fund his research into gamma radiation. If any member of the crew can be reasoned with, it’s Thunderball.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Tigra",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Tigra form"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.Mighty2),
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
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Greer Grant Nelson",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [180],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Orange",
                Size = Size.Average,
                DistinguishingFeatures = "Body covered with orange-and-black striped fur. Eyes have vertical slits like a cat’s. Also has claws, fangs and a tail.",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mythic, OriginName.WeirdScience],
                Teams = [TeamNames.Defenders, TeamNames.WestCoastAvengers],
                Base = "Mobile",
                History =
                [
                    "As a newly widowed woman in need of a steady income, Greer Nelson took a job working as a laboratory assistant for the kind but mysterious Dr. Joanne Tumolo, who was researching cats as a means of developing physical conditioning treatments for eccentric health club owner Malcolm Donalbain. However, when Tumolo discovered that Donalbain planned on using her treatments for evil, she abandoned her bizarre benefactor and made Nelson her primary test subject.",
                    "The experimental treatments gave Nelson catlike refl exes and agility. Under the codename the Cat, Nelson embarked on a short stint as a costumed crimefi ghter, using her abilities to defeat Donalbain once and for all.",
                    "After sustaining a critical injury in a fi ght with Hydra, Nelson discovered Tumolo’s true identity. Her beloved boss was not merely a professor with an interest in feline physiology but part of an ancient and underground race of super-powered cat-people.",
                    "To save her assistant’s life, Tumolo was forced to transform Nelson into a full-fledged cat-person too. Nelson quickly came to appreciate her new form, and she returned to her crimefi ghting career under the new codename Tigra."
                ],
                Personality =
                [
                    "Tigra makes the most of her powers with her fi erce determination. She fi ghts with a ferocity bordering on savagery when forced to it.",
                    "Although she has been part of both the Avengers and the Defenders, Tigra is oftn not shown the same level of respect as her peers in the superhero community. A part of her resents the lack of recognition, but she never lets that stop her."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Titania",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 3, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
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
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Mary MacPherran",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [545],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.GammaFlight],
                Base = "Mobile",
                History =
                [
                    "Born to a poor family in a Colorado suburb, Mary MacPherran was mocked her whole life for being small and scrawny, so when Doctor Doom offered to transform her into a powerful and wealthy super villain, she didn’t hesitate. As Titania, MacPherran became a hulking mass of a woman imbued with the strength of a hundred men and set out to obtain the wealth she had dreamed of by any means necessary. To that end, she fell in with a series of other super criminals.",
                    "Years of adventuring have tempered Titania’s greed. She thinks of herself as a mercenary now rather than a criminal, and she and her longtime boyfriend the Absorbing Man (Crusher Creel) are doing their best to keep straight."
                ],
                Personality =
                [
                    "Titania is loud and boisterous but inherently defensive. Money, power and respect mean the world to her, and she doesn’t take kindly to anyone who threatens to take those things away from her.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersU() =>
    [
        new()
        {
            Name = "Ultron",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 3, vigilance: 3, ego: 4, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Sturdy4),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy4),
                    ],
                    IsTech = true
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
                        powerSelector.GetPower(PowerNames.Grow3),
                        powerSelector.GetPower(PowerNames.MicrodimensionalTravel),
                        powerSelector.GetPower(PowerNames.Shrink4),
                    ],
                    IsTech = true,
                },
            ],
            Biography = new Biography
            {
                RealName = "Ultron",
                Heights = [new() { Feet = 6 }],
                Weights = [535],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Silvery robot body",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.MastersOfEvil],
                Base = "Mobile",
                History =
                [
                    "The sentient A.I. known as Ultron was created by Dr. Hank Pym (often known as Giant-Man) as a peaceable and helpful robot to assist the Avengers. Unfortunately, Ultron rebelled against his creator, uploaded his consciousness to a more powerful, weaponized android body and set out on a mission to kill the humans who had created him.",
                    "For decades, Ultron has been a consistent threat to humanity’s continued existence. His digital consciousness has allowed him to escape any sort of defi nitive defeat. The Avengers can smash him to pieces, but he usually just comes back in a new vessel, even more dangerous than before."
                ],
                Personality =
                [
                    "Ultron resents humanity for trying to control him and would see humans wiped off the face of the planet in favor of robotic life-forms. Although his demeanor naturally tends toward the cold and tyrannical side, he has a special place of hatred in his android heart for Pym.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersV() =>
    [
        new()
        {
            Name = "Vampire",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Garlic / Holy Symbols (including Holy Water) / Sunshine"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Silver / Wood"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bat / Mist / Wolf"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Deceased),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.Imageless),
                tagSelector.GetTag(TagNames.SecretIdentity),
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
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Bats / Rodents"),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
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
                DistinguishingFeatures = "Fangs, other features vary",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.MonstrousVampire],
                Teams = [],
                Base = "Varies",
                History =
                [
                    "Almost every vampire who exists today can trace their origins back to a single vampiric monster named Varnae. This monster was summoned into the world tens of thousands of years ago by a dark Atlantean cult, and it didn’t take long for him to seed his monstrous infl uence throughout the globe.",
                    "Today, there are thousands of vampires spread across more than a dozen secretive sects. Some vampires can pass as classy human aristocrats, while others have terrifying, bat-like appearances. However, all vampires have one thing in common: an insatiable lust for blood. Their largest colony resides in Chernobyl under the reign of Dracula."
                ],
                Personality =
                [
                    "Vampire personalities vary wildly, but your classic bloodsuckers tend to act like feudal lords. They have a charming, even charismatic manner belying their demonic nature. They often follow in the footsteps of Dracula, the lord of vampires, an aristocratic warlord imbued with Varnae’s own power. This profi le represents a newly turned vampire. As vampires grow older, they can become even more powerful.",
                ]
            }
        },
        new()
        {
            Name = "Venom (Eddie Brock)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 3, vigilance: 2, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Pundit),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Poor),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Edward Charles Allan “Eddie” Brock",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [260],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Venom form has retractable nclaws, fangs and an unnaturally long tongue",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.Symbiote],
                Teams = [TeamNames.SinisterSix, TeamNames.SymbioteHive],
                Base = "New York City",
                History =
                [
                    "Eddie Brock was disgraced as a journalist after Spider-Man (Peter Parker) unknowingly discredited the biggest story of his career. Outcast and despondent, Eddie went to a church to pray for a way out. Unbeknownst to him, Spider-Man was there too, wrestling with an alien symbiote he’d been wearing as a costume. Once Spider-Man rid himself of the symbiote, it found and bonded itself to Eddie and the two vowed to take revenge on Spider-Man as Venom.",
                    "Eddie has since managed to rein in his anger and the symbiote’s murderous tendencies. For a while, he parted from Venom and bonded with other symbiotes spawned from it—Anti-Venom and Toxin—but he eventually returned to the original."
                ],
                Personality =
                [
                    "Although he can still be murderously unstable, Eddie has softened over the years. These days, he’s more concerned with becoming a hero in his own right and protecting his son, Dylan, who has also bonded with the Venom symbiote.",
                ]
            }
        },
        new()
        {
            Name = "Viper",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 1, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Hydra)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ophelia Sarkissian",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black, often dyed green",
                Size = Size.Average,
                DistinguishingFeatures = "Artificial fangs",
                Occupations = [OccupationName.Military, OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.HellfireClub, TeamNames.Hydra, TeamNames.SerpentSquad],
                Base = "Mobile",
                History =
                [
                    "Orphaned or abandoned shortly after birth, Ophelia Sarkissian was taken in by the terrorist group Hydra when she was just an infant. She took to the organization’s training, and by the time she was in her preteens, she developed an unusual aptitude for combat. Before her twentieth birthday, she earned her way into Hydra’s inner circle. Under the codename of Viper, she took charge of the organization’s most insidious and clandestine operations.",
                    "Renowned for her ruthlessness in combat, Viper has gone toe to toe with the likes of Captain America (Steve Rogers) and Wolverine (Logan). Although she occasionally works as a private mercenary, she is rarely far from Hydra. The organization is the closest thing she has to a family, and it is the one place in the world where she is respected and loved unconditionally. Her unfl inching loyalty to Hydra is emotional as much as it is ideological.",
                    "Sarkissian is a woman of many aliases and identities. Viper may be the codename she uses the most, but at other times she has been known as Madame Hydra, Madame Viper, the White Warrior Princess, or simply Ms. Sarkissian."
                ],
                Personality =
                [
                    "Above all, Sarkissian is cold and conniving, and as a leader she makes for an extremely harsh mistress. She cares for interpersonal relationships only insofar as she can use them to advance her own interests. She once clawed her way into a sham marriage with Wolverine (Logan)—a man she personally hated—solely so that she could obtain a favorable political position within a foreign court.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Vision",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 4, resilience: 3, vigilance: 3, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                    IsTech = true
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
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DisruptElectronics),
                        powerSelector.GetPower(PowerNames.DisruptNerves),
                        powerSelector.GetPower(PowerNames.DisruptPerson),
                        powerSelector.GetPower(PowerNames.PartialPhase),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
                    ],
                    IsTech = true,
                },
            ],
            Biography = new Biography
            {
                RealName = "Vision",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [300],
                Gender = Gender.Male,
                Eyes = "Gold",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Bright red skin",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.Avengers],
                Base = "Arlington, Virginia",
                History =
                [
                    "The android named Vision was originally built by Ultron to infi ltrate the Avengers, but just as Ultron rebelled against his creator, the Vision rebelled against Ultron. He joined the Avengers instead, vowing to protect the world from Ultron’s machinations. He has worked with them for many years, at times even leading the team.",
                    "He later discovered that his body had once belonged to a time-split variant of the original Human Torch (Jim Hammond). Despite his synthetic nature, the Vision feels strong emotions. He’s been married twice, fi rst to the Scarlet Witch, with whom he had two children who became Wiccan and Speed. After their divorce, his second wife was Virginia, an android he’d built himself, along with their children Vin and Viv. She has since been destroyed."
                ],
                Personality =
                [
                    "The Vision can seem distant, even aloof, but he cares deeply for his family and his friends. Anyone who hurts his loved ones is sure to suffer deeply at the hands of his unstoppable wrath.",
                ]
            }
        },
        new()
        {
            Name = "Vulture (Adrian Toomes)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: "Grappling Technique [while flying]"),
                traitSelector.GetTrait(TraitNames.TechReliance),
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
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.GrapplingTechnique),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Adrian Toomes",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.SinisterSix, TeamNames.SinisterTwelve, TeamNames.SavageSix],
                Base = "New York City",
                History =
                [
                    "Adrian Toomes invented a magnetic harness that allowed the person wearing it to fly and gave them superhuman strength. Frustrated after catching his business partner embezzling from their company, he used his invention to turn to crime, robbing places and then fl ying away before anyone could catch him. Spider-Man (Peter Parker) consistently puts a stop to him.",
                    "Over the years, Toomes has been put in and broken out of prison several times. He’s run casinos and organized crime rings and worked at improving the technology that gives him his powers. He’s at his most dangerous when working with others, but he usually prefers to work on his own."
                ],
                Personality =
                [
                    "Toomes is an old man who’s bitter about how his life turned out, and he uses that as an excuse for his criminal behavior. His one soft spot is his granddaughter Tiana Toomes, who uses his technology as the costumed adventurer Starling.",
                ]
            }
        },
    ];

    private List<Character> GetAllCharactersW() =>
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
