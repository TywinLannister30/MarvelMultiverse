using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersO
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
            Name = "Odin",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 6, vigilance: 9, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoostPowers),
                        powerSelector.GetPower(PowerNames.BumpPower),
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Need (represents the All-Power)"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                        powerSelector.GetPower(PowerNames.RallyOnMe),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "ravens Huginn and Muninn"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Odin Borson",
                Heights = [new() { Feet = 6, Inches = 9 }],
                Weights = [650],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Gray",
                Size = Size.Big,
                DistinguishingFeatures = "Missing right eye, covered with eyepatch",
                Occupations = [OccupationName.Leader, OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.AvengersOneMillionBC],
                Base = "Valhalla",
                History =
                [
                    "Odin claims that, in his youth, he and his godly brothers defeated the massive frost giant Ymir and that from Ymir’s body they fashioned all the ten realms, including the realm of the gods: Asgard. Some time later, one brother—Cul—turned on his siblings, and to beat him, Odin sacrificed his right eye to the world tree, Yggdrasil, which granted him vast wisdom. Following Cul’s defeat, Odin’s remaining brothers allowed him to claim the title of All-Father and to wield the associated All-Power, making him the ruler and patriarch over all the gods.",
                    "Over the subsequent millennia, Odin embarked on countless escapades. He rode with the Avengers of 1,000,000 B.C. on their missions to protect Earth from its earliest threats, and he had several children, such as the hero Thor and his adopted brother, Loki.",
                    "For untold eons, Odin stood as the uncontested leader of Asgard. Recently, however, a mysterious cosmic entity known as the God of Hammers possessed Thor’s hammer and nearly laid waste to all of Asgard. To defeat the entity, Odin willingly passed on into Valhalla and relinquished the All-Power to Thor. Though Thor is now officially the All-Father, he still consults his father for advice."
                ],
                Personality =
                [
                    "Though death has taught him some degree of humility, Odin was notorious throughout his life for being a cold and stubborn ruler. He was an intelligent and benevolent king, but he hated to explain himself and often expected blind obedience from his subjects, even his children.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Old Man Logan (Earth-21923)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 4, vigilance: 4, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.OutOfShape),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AuditoryIssues),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Hulk Gang"),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Sabretooth"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.VisionIssues),
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
                RealName = "James Howlett",
                Heights = [new() { Feet = 5, Inches = 3 }],
                Weights = [195],
                WeightReminder = "300 lbs. with adamantium",
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium claws, muttonchops",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTechCybernetics, OriginName.Mutant],
                Teams = [TeamNames.AlphaFlight, TeamNames.SHIELD, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "When “Old Man” Logan was not yet an old man, his world largely resembled Earth-616. He was Wolverine, and he lived with and fought alongside the X-Men. Then, one day, a massive and coordinated super-villain attack turned the planet into a wasteland.",
                    "Most of the world’s heroes were slaughtered in a single night. Logan himself participated in this slaughter, with Mysterio tricking him into killing the other X-Men. In the aftermath, the victorious villains divided the remnants of the world among themselves, and Logan spent the next several decades mournfully wandering those fallen wastes, trying to avenge his friends. He was on the verge of liberating his world once and for all when a freak anomaly sucked him onto Earth-616.",
                    "Logan spent the next few years working with the X-Men of Earth-616, helping to ensure that what happened on his world would never happen to them. Then he returned home to finish what he started.",
                    "Ultimately, Logan failed to liberate his home when he and the Sabretooth of his world killed each other on the field of battle. However, Logan’s allies continue to fight on in his honor, working to restore justice to their world one punch at a time."
                ],
                Personality =
                [
                    "Old Man Logan has the same basic personality as that of the Logan of Earth-616, just heightened by age and experience. If Logan is a cold-blooded killer, then Old Man Logan has blood made of ice. If there’s a hint of sadness in Logan’s eyes, then there’s an ocean of tragedy lurking beneath Old Man Logan’s eyelids.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Okoye",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 2, vigilance: 1, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Dora Milaje)"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup, reminder: "Dora Milaje"),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
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
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Okoye",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "Wakandan tribal tattoos",
                Occupations = [OccupationName.Military],
                Origins = [OriginName.HighTech, OriginName.SpecialTraining],
                Teams = [TeamNames.DoraMilaje],
                Base = "Wakanda",
                History =
                [
                    "Renowned for her capabilities as a warrior, Okoye was personally selected by the Black Panther (T’Challa) to be the head of his personal guard: the Dora Milaje. There is no one among the Dora Milaje who the Panther trusts more than Okoye. She assists him in nearly all of his heroic exploits, and she has personally put down rebellions against his government.",
                    "Due to her skills and her loyalty, Okoye helped found and became the director of the Agents of Wakanda, a team of heroes organized to support the Avengers during the Black Panther’s time as their leader.",
                ],
                Personality =
                [
                    "As a seasoned warrior, Okoye isn’t the type for small talk. As a bodyguard, she spends much of her time silently standing behind the Panther, looking intimidating. When battle inevitably breaks out, she focuses on communicating her orders clearly and effectively. She’s not above a rare bit of humor, but her jokes tend to be on the dry side.",
                ]
            }
        },
    ];
}
