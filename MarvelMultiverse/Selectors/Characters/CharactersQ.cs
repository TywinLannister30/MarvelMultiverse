using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersQ
{
    public static List<Character> GetAllCharacters(
      INarrativePowerSelector narrativePowerSelector,
      IPowerSelector powerSelector,
      ITagSelector tagSelector,
      ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "Quasar",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 4, vigilance: 6, ego: 8, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Discipline3),
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
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalGrab),
                        powerSelector.GetPower(PowerNames.ElementalPrison),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Wendell Elvis Vaughn",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "As a young man, Wendell Vaughn successfully completed the special-agent training course at S.H.I.E.L.D. Academy only to be rejected for fi eld duty by higher-ups who believed he was too kind and caring to be a serious agent. Instead, Vaughn was assigned to guard duty outside the containment chamber of the legendary Quantum Bands, mystic artifacts designed to protect life throughout the universe. These bands contain such incredible power that they annihilated most people who attempted to wield them.",
                    "Vaughn performed his duties diligently until the day an A.I.M. attack overran the base where he was stationed. Desperate to escape the slaughter, Vaughn took a chance and donned the Quantum Bands. Incredibly, the kindness in his heart soothed the cosmic energies within the bands and transformed him into Quasar, Protector of the Universe.",
                    "As Quasar, Vaughn has achieved things beyond his wildest dreams and gone places S.H.I.E.L.D. could never have taken him. He has helped to end galaxy-spanning wars and fought with evil creatures the size of planets. Today, he numbers among the most powerful heroes in existence."
                ],
                Personality =
                [
                    "Quasar wields phenomenal power, but he prefers to solve his problems peacefully whenever possible. He treats defeated enemies gracefully, with an eye toward reform. On at least one occasion, Quasar has faked his own death to peacefully satisfy a vengeful opponent.",
                    "If Quasar has a flaw, it is his tendency to defer to established authority. He has assisted in many of S.H.I.E.L.D.’s operations, not all of them strictly ethical."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Queen Goblin",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 3, vigilance: 4, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "goblin form"),
                tagSelector.GetTag(TagNames.Clone),
                tagSelector.GetTag(TagNames.Cursed),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
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
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Pumpkin Scepter [Inflicts hellfire damage on a Fantastic success, splitting the damage equally between Health and Focus; otherwise acts as an ordinary club]"),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementControlHellfire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBlast),
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicDemonicMagic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PenanceStare, reminder: "referred to as Goblin Gaze"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
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
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ashley Kafka",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Blue (yellow in goblin form)",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Goblin form has scaly red skin, sharp claws and teeth",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.MagicDemonic],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "Ashley Kafka a began her career as a researcher and psychologist at the Ravencroft Institute for the Criminally Insane, providing mental-health services to many enemies of Spider-Man (Peter Parker). Her methods yielded some promising results, but before she could make serious progress, she was murdered by one of her own patients: the villain Massacre.",
                    "Years later, as part of a plan to torture Spider-Man with the faces of those he had failed to save, the Jackal (Ben Reilly) created clones of dozens of the wall-crawler’s dead friends, including two clones of Kafka a. The first fell victim to cellular degeneration and perished almost immediately, but the second was stable enough to assume Kafka a’s old life.",
                    "This new Kafka a got a job working for the Beyond Corporation as the personal psychologist for their captive hero, Ben Reilly. She tried to help Reilly escape, but the corporation found out and imprisoned her. Hoping to make her their own captive villain, Beyond exposed Kafka a to the concentrated, liquified sins of Norman Osborn, turning her into Queen Goblin.",
                    "Kafka a used her new powers to escape from Beyond, and shortly thereafter, she exorcised Osborn’s sins from her body. For reasons unknown, though, this did not remove her powers or her newly villainous attitude."
                ],
                Personality =
                [
                    "Kafka a spent most of her life trying to help people by stabilizing the bodies and minds of convicted villains. Since becoming Queen Goblin, her desires have inverted. All she wants now is to drive heroes like Ben Reilly and Peter Parker over the edge—to make them as unstable and violent as herself.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Quicksilver",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 7, resilience: 3, vigilance: 4, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.InstantReplay),
                        powerSelector.GetPower(PowerNames.TimeOut),
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
                        powerSelector.GetPower(PowerNames.RunOnWater),
                        powerSelector.GetPower(PowerNames.SpeedBlast),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Pietro Django Maximoff",
                Heights = [new() { Feet = 6 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Silver",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.BrotherhoodOfEvilMutants, TeamNames.XFactor],
                Base = "Mobile",
                History =
                [
                    "As infants, Pietro Maximoff and his twin sister, Wanda, were subjected to dangerous experiments, and as they aged, they began to exhibit strange powers. Pietro developed superhuman speed, while Wanda developed powerful magic. Superstitious villagers were about to kill the twins when Magneto saved them and invited them to join his Brotherhood of Evil Mutants as Quicksilver and the Scarlet Witch.",
                    "The twins later renounced such evil and became early members of the Avengers. Like the Scarlet Witch, Quicksilver is a hero at heart. He cares deeply for his sister and is ready to give his life to defend her, and he considers his work as a hero a form of atonement for the years he spent living as a terrorist.",
                ],
                Personality =
                [
                    "Due to his powers, Quicksilver is often impatient with others to the point of condescension, and he can come across as humorless. When he’s able to cut loose, though, he smiles with joy.",
                ]
            }
        },
    ];
}
