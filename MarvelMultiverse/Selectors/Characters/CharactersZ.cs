using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersZ
{
    public static List<Character> GetAllCharacters(
      INarrativePowerSelector narrativePowerSelector,
      IPowerSelector powerSelector,
      ITagSelector tagSelector,
      ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "Za, the Rat King",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 9, resilience: 9, vigilance: 3, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.UnusualSize, specialization: "Tiny"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup, reminder: "Rats"),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pizza slice"),
                tagSelector.GetTag(TagNames.Mute),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(
                            PowerNames.IconicWeapon, 
                            specialization: "Pizza slice [+1 Melee multiplier; If struck by pizza, target is disgusted for remainder of combat and has trouble on all rolls]",
                            meleeDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SlipFree),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Rats"),
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Rats"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Za",
                Heights = [new() { Inches = 5 }],
                HeightReminder = "when standing on back legs",
                Weights = [2],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Brown",
                Size = Size.Tiny,
                DistinguishingFeatures = "Fights with a slice of pizza",
                Occupations = [],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "Prano’s Restaurant, Little Italy, New York City",
                History =
                [
                    "Za was once a normal rat, striving to make a rathole of his own in the sewers of New York City. In his early years, he witnessed a cousin rat killed by a fi re-breathing monster who had been shrunk down to rat size. He later was involved in a rat attack on the frogs of Central Park but was terrifi ed at seeing a frog with the powers of a god. He was one of many rats controlled by Vermin in an attack on Spider-Man. Later still, he witnessed the deaths of many mutants who were killed in the sewers by the Marauders.",
                    "These events would give Za a dim view of humanity, mutants and especially superhumans.",
                    "Moving from the sewers to fi nd a small hole in the alley behind Prano’s Restaurant in Little Italy, Za was happy for a time. But that all changed when the restaurant closed and agents of Hydra built an interdimensional portal near his home. A small group of heroes ended up closing the portal, causing an explosion that empowered the rat. Za suddenly found himself with cosmic-level power and the ability to control the minds of other rats."
                ],
                Personality =
                [
                    "Za is no different from the average New York City rat, he wants a cozy hole, ready access to food and safety from the dangers of superhumans. He especially loves pizza and has gone to extraordinary lengths to always have a slice at his side. Now with great power, Za must decide what he should do with it.",
                ]
            }
        },
    ];
}
