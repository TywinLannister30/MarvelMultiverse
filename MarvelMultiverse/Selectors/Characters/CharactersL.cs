using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersL
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
            Name = "Lady Deadpool",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 4, resilience: 4, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.MediaAwareness),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Katana"),
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
                        powerSelector.GetPower(PowerNames.Uncanny1),
                        powerSelector.GetPower(PowerNames.Wisecracker),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.FlyingDoubleKick),
                        powerSelector.GetPower(PowerNames.FocusedStrike),
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
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Wanda Wilson",
                Heights = [new() { Feet = 6 }],
                Weights = [169],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.DeadpoolCorps],
                Base = "Mobile",
                History =
                [
                    "In the fascist America of Earth-3010, Wanda Wilson, her reality’s Deadpool, was a disfigured, semiretired mercenary brought back into action by a rebel militia formed to topple America’s totalitarian government. Wanda fought numerous battles on the rebels’ behalf, earning her the enmity of the government’s Super-Soldier General America. Wade Wilson, Wanda’s male Earth-616 counterpart, recruited her into the Deadpool Corps, a cadre of multiversal Deadpool variants formed by the Elders of the Universe to confront the Awareness, a pre-Big Bang being capable of absorbing the consciousness of sentient beings on a planetary scale. After ending the Awareness’ rampage in a battle that saw the Corps exposed to their greatest fears and Wanda having her physical appearance restored, the Corps remained together as spacefaring mercenaries, though Wanda often clashed with Wade over methods and values despite sharing his penchant for mayhem. After being sent back to Earth-3010 by the Elders, Wanda and the Corps reunited to face an army of Deadpools amassed by the Deadpool of Earth- 12101 to eradicate every Deadpool in existence. Wanda sacrificed herself by crashing the Corps’ spacecraft, the Bea Arthur, into a Deadpool-Galactus variant serving Deadpool-12101, but she was later resurrected by the reality-manipulating Killville.",
                ],
                Personality =
                [
                    "Like many of her multiversal counterparts, Lady Deadpool is unafraid to dish out lethal violence and often speaks in endless strings of jocular pop-culture references that simultaneously distract foes and frustrates allies. Among the Deadpool Corps, Wanda shares the other members’ penchant for mayhem but is a shrewder figure who often acts as the voice of reason among the team, particularly against Deadpool-616 whose schemes often fail to account for negative consequences. Wanda nevertheless sufferes a severe need for belonging that makes her susceptible to joining causes beyond her own self-interest.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Lady Deathstrike",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 3, resilience: 4, vigilance: 5, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: PowerNames.FuriousAttacks),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "with claws out"),
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
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Adamantium Nails", isTech: true),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton, isTech: true),
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
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.UnstoppableAssault),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                    ],
                    IsTech = true
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "Adamantium Nails",
                    Powers =
                    [
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Adamantium),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier Bonus: +1."),
                    ],
                    Restrictions =
                    [
                        "Menacing",
                    ],
                    PowerValue = 1,
                    MeleeDamageModifier = 1,
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Yuriko Oyama",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [128],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Retractable adamantium nails",
                Occupations = [OccupationName.Assassin],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.Reavers, TeamNames.SisterhoodOfMutants, TeamNames.WeaponXForce],
                Base = "Mobile",
                History =
                [
                    "In an attempt to make money on the black market, mad scientist and Japanese nationalist Kenji Oyama developed a process for safely lacing human bones with adamantium. This process was invasive, requiring the installation of cybernetic implants, but it worked, and weapons dealers from around the world took note.",
                    "Kenji implemented his process only a few times before the super heroes of the world took him down. In his absence, his daughter Yuriko took up the cause of protecting her father’s legacy. She had her own body implanted with adamantium and set out to become a mercenary under the codename Lady Deathstrike.",
                    "More than anyone, Yuriko hates Wolverine (Logan). She believes his adamantium implants were possible only because of research stolen from her father, and that Wolverine’s very existence spits in the face of her late father’s work.",
                    "Yuriko’s longtime rivalry with the nigh-unkillable mutant has, at times, drawn her into conflict with the larger world of mutants. Because of that, it is not unknown for her to ally herself with mutant-hating bigots like William Stryker."
                ],
                Personality =
                [
                    "Lady Deathstrike is a grim and merciless combatant with an unflinching sense of duty. She pursues her targets relentlessly and without fail. Wolverine is one of the few people in existence to have bested her in direct combat.",
                    "She would hardly ever admit it, but Lady Deathstrike long ago lost track of her real reasons for hating Wolverine. She continues to fight him for the same reason that she continues her work as an assassin. It’s all she knows.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Lady Octopus",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 2, vigilance: 3, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Skeptical),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, isTech: true),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
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
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Carolyn Trainer",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Six mechanical arms",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Syndicate],
                Base = "New York City",
                History =
                [
                    "Though born the daughter of the brave geneticist and Spider-Man (Peter Parker) ally Seward Trainer, Carloyn Trainer was only ever interested in the accomplishments of her father’s old colleague Otto Octavius. She spent her entire adolescence studying under Doctor Octopus, and after he was killed by Kaine, she carried on his legacy.",
                    "As the new Doctor Octopus, she launched a series of revenge schemes against Kaine and his genetic brothers, Peter Parker and Ben Reilly. When the schemes all failed, she settled for the next best thing: undoing Kaine’s murder of her mentor altogether. With help from a sect of Hand ninja, Trainer resurrected Octavius and returned to her job as his assistant. Having gotten a taste for the thrill of adventuring solo, though, she quickly abandoned him to become the independent mercenary Lady Octopus.",
                    "These days, Lady Octopus primarily works with the all-female Syndicate led by the Beetle (Janice Lincoln). Though she rarely agrees with the way that Lincoln manages the team, she can’t deny that the Syndicate gets results."
                ],
                Personality =
                [
                    "Much like her mentor Octavius, Carloyn Trainer is an intelligent scientist with a huge but fragile ego. Her years of working as Doctor Octopus’ assistant did teach her some modicum of humility, but she still dislikes most of the ideas that her colleagues in the Syndicate come up with, and she is more than willing to tell them so.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Last Stand Spider-Man",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 6, resilience: 2, vigilance: 4, ego: 3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.OutOfShape),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hunted),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
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
                        powerSelector.GetPower(PowerNames.Webgliding),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [182],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "Brown, with gray temples",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.FantasticFour, TeamNames.SpiderArmy],
                Base = "New York City (Earth-312500)",
                History =
                [
                    "At the climax of Kraven the Hunter’s self-styled “Grim Hunt,” the Kravinoff family murdered Madame Web (Cassandra Webb), the close friend and advisor of Spider-Man (Peter Parker). Driven mad with rage, Spider-Man beat Kraven half to death before taking up a spear and threatening to cut him down once and for all.",
                    "In Earth-616, Parker pulled back from the edge of moral annihilation and let Kraven live, but in Earth-312500, he thrust his spear into the hunter’s heart.",
                    "Unwilling to abide a murderer, Parker’s family and friends slowly abandoned him. Rather than take this as a sign of bad times ahead, Parker sank inward, doubling down on his brutal new ethos by killing most of his old villains.",
                    "Branded a public menace, Parker spent most of the next several decades on the run from the authorities, only coming out of hiding to help the Spider-Army counter the occasional cosmiclevel threat.",
                    "Now an old man, Parker’s been getting reckless and revisiting old haunts. The New York Police Department is preparing to take him down, and some say the wall-crawler has already made his last stand—that he was shot down by the police while visiting the graves of his aunt and uncle, and the NYPD is simply waiting for the right time to make the news public."
                ],
                Personality =
                [
                    "Worn down by age and regret, this version of Spider-Man no longer cares whether he lives or dies. He knows that the murders he committed were unjustifi able, but he can’t bring himself to surrender. All he really wants now is to go down swinging.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Leader",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 3, vigilance: 4, ego: 4, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.GreenDoor),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.Uncanny3),
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
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Samuel “Sam” Sterns",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [144],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Enlarged cranium, green skin",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [TeamNames.Intelligencia, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "Samuel Sterns was once nothing more than a mild-mannered factory worker tasked with transporting canisters of nuclear waste. One day, during a routine disposal, a canister broke open and showered him in gamma radiation. The radiation mutated Sterns’ body, turning his skin green and enlarging his skull. Finding that he now had superhuman intelligence and psionic abilities, Sterns adopted the title of the Leader and set himself to the task of conquering the world.",
                    "Sterns’ evil plans have been thwarted again and again by the intervention of fellow gamma mutate the Hulk (Bruce Banner). He has become obsessed with defeating the Hulk, who he sees as the biggest obstacle on his path toward world domination.",
                ],
                Personality =
                [
                    "A megalomaniacal narcissist, the Leader believes that his brilliant intellect grants him the right to rule the world. It infuriates him that a being as dim-witted as the Hulk could possibly foil his schemes.",
                ]
            }
        },
        new()
        {
            Name = "Lizard",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 4, resilience: 4, vigilance: 2, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Lizard form"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Villainous, reminder: "in Lizard form"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder: "tail"),
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.Brilliance1),
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
                        powerSelector.GetPower(PowerNames.FuriousAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderDodge),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "reptiles"),
                    ],
                },
            ],
            PowerNotes =
            [
                "Though Curt Connors may currently be separated from his Lizard half, this profile represents the pair in their classic merged state."
            ],
            Biography = new Biography
            {
                RealName = "Curtis “Curt” Connors",
                Heights = [new() { Feet = 5, Inches = 11 }, new() { Feet = 6, Inches = 8 }],
                Weights = [175,550],
                Gender = Gender.Male,
                Eyes = "Blue, red (as Lizard)",
                Hair = "Brown, none (as Lizard)",
                Size = Size.Big,
                SizeNotes = $"{Size.Average} as human",
                DistinguishingFeatures = "Reptilelike green body with scales, tail, claws and fangs (as Lizard)",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "Having lost an arm while serving overseas in the U.S. military, Dr. Curt Connors became fascinated with the ability of certain reptiles to regrow lost limbs. Using lizard DNA, he developed a limb- restoring serum and immediately tested it on himself.",
                    "The experimental drink did restore his arm, but it also turned him into a megalomaniacal humanoid lizard bent on transforming all of humanity into reptile-human hybrids.",
                    "In one of the Lizard’s earliest outings, Spider-Man (Peter Parker) developed a counter-serum to transform Connors back into a human. However, the antidote was only a partial success, and in times of extreme stress, Connors often reverted to his Lizard form. Until a more permanent cure could be created, Spider-Man had to keep constant watch over Connors.",
                    "Grateful for the protection, Connors agreed to be Spider-Man’s partner in all things scientifi c. Whenever Spider-Man has a science problem he can’t solve, he goes to Connors for help.",
                    "After years of false starts, Connors recently managed to remove his Lizard half, turning it into a separate entity. If history is any indicator, Connors will likely return to being the Lizard someday, but for now, he and his family are safe."
                ],
                Personality =
                [
                    "When he’s in his human form, Curt Connors is a kind father, a loving husband and a generous scientist. When he’s in his Lizard form, anything goes.",
                    "Originally, the Lizard was a lot like Connors. He was roughly human-sized and had roughly human intelligence. However, years of repeated transformations and mutations have turned him into something larger and more monstrous. Now free of Connors, the Lizard runs on little more than reptilian instinct."
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Lockheed",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 1, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.UnusualSize, reminder: "Little"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 2, Inches = 6 }],
                Weights = [20],
                Gender = Gender.Male,
                Eyes = "Yellow",
                Hair = "None",
                Size = Size.Little,
                DistinguishingFeatures = "Looks like a tiny purple dragon",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Excalibur, TeamNames.Marauders, TeamNames.SWORD, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Lockheed was born into the Flock: an interstellar society of dragon-like aliens. His childhood was as normal as any childhood can be for an alien dragon. He grew up healthy and strong, and he made a name for himself among his people as a warrior in their eternal battle against the alien Brood.",
                    "It was a good life, but not one that Lockheed wanted. The day before he was bound to be wed, Lockheed ran into a group of captive X-Men trapped inside a Brood settlement. He helped to free them, and they allowed him to accompany them back to Earth. He has been with them ever since.",
                    "Lockheed likes all of the X-Men, but he has a particular affinity for Kate Pryde. They accompany each other on many of their adventures, and Lockheed often is seen perching atop her shoulders or neck. Kate treats Lockheed like the greatest pet she could have, and that’s just the way he likes it.",
                ],
                Personality =
                [
                    "Lockheed can understand and speak English to a limited degree, but he prefers to spend most of his time silent. He’s protective of the X-Men, particularly Kate Pryde, but his tiny body makes it hard for him to be of much use to them in combat. He tends to skirt around the edges of battles, scorching off-guard villains and goons from afar.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Lockjaw",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 3, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.Mute, reminder: "can only bark"),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelDimensional,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DimensionalTravel),
                        powerSelector.GetPower(PowerNames.DimensionalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelMultiversal,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MultiversalTravel),
                        powerSelector.GetPower(PowerNames.MultiversalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Teleportation,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Blink),
                        powerSelector.GetPower(PowerNames.Teleport2),
                        powerSelector.GetPower(PowerNames.TeleportBlind),
                        powerSelector.GetPower(PowerNames.TeleportObject),
                        powerSelector.GetPower(PowerNames.TeleportOther),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lockjaw",
                Heights = [new() { Feet = 5 }],
                Weights = [1240],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Giant bulldog with small tuning-fork-like antennae",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Inhuman, OriginName.WeirdScience],
                Teams = [TeamNames.HouseOfAgon, TeamNames.PetAvengers],
                Base = "Mobile",
                History =
                [
                    "Lockjaw is the fi nal result of a series of experiments on animals performed by Inhuman geneticists. He was implanted with Inhuman genes and exposed to the Terrigen Mist while still in the womb. As a result, he later grew to an immense size and gained the ability to teleport nearly unlimited distances.",
                    "The data from the experiments on Lockjaw was used to give the future Inhuman king Black Bolt his own powers. Mere days after Black Bolt was born, the young prince developed an attachment to the dog who had been mutated in the same manner as himself. Soon enough, Lockjaw had become the official pet of the Inhuman Royal Family.",
                    "Lockjaw accompanies the royals on nearly all of their adventures. Although his combat abilities are limited, his powers of teleportation make him an indispensable teammate. In the rare event that the Inhuman royals are outmatched by an opponent, they can always cling to Lockjaw and teleport away.",
                ],
                Personality =
                [
                    "Although more intelligent and observant than an average bulldog, Lockjaw is still an animal. He whines, barks, begs and behaves like any other dog.",
                    "Lockjaw can be rambunctious, and he has been known to run off on his own adventures from time to time. However, he is, above all else, loyal to Black Bolt. Any who make themselves an enemy of the Inhuman king must also contend with his dog."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Logos (of Earth-56438)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.LegalEagle),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Hounded, reminder: "outside ancient Egypt"),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Powerful, reminder: "within ancient Egypt"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Logos",
                Heights = [new() { Feet = 5 }],
                Weights = [125],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Mutant],
                Teams = ["Personal advisor to Rama-Tut Kang"],
                Base = "Ancient Egypt",
                History =
                [
                    "Having been born into a wealthy Egyptian family, Logos was raised from birth to act as an advisor within the pharaoh’s royal court. His brilliant mind and his preternatural ability to sense what others are thinking brought Logos prestige and renown. However, he obtained the status of grand vizier only after Kang’s arrival.",
                    "When Kang fi rst arrived in Egypt, he slaughtered most of the last pharaoh’s court. Logos is one of the few who Kang chose to spare.",
                    "Although he does not know it himself, Logos is a mutant, one of the earliest. He is a brilliant advisor, but Logos’ mutant status is the main reason Kang kept him around. Kang has been on the lookout for Apocalypse since the moment he set foot on Egyptian soil. Some part of him believes that by retaining control over one mutant, he can somehow draw in another.",
                ],
                Personality =
                [
                    "Logos was raised to have unquestioning loyalty to the pharaoh. However, Kang’s brutality has shaken his resolve. Logos remains committed to Kang’s service, and he treats any threats to the pharaoh’s well-being with deadly seriousness. However, he would be willing to assist an investigation into Kang’s true origins.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Loki",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 4, ego: 8, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.GodHeritage),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                        powerSelector.GetPower(PowerNames.SummonPortal),
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
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Loki Laufeyson",
                Heights = [new() { IsVariable = true }],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.Varies,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.MythicAsgardian],
                Teams = [TeamNames.DarkCouncil, TeamNames.GodsOfAsgard],
                Base = "Asgard",
                History =
                [
                    "Although born to a family of Frost Giants, Loki Laufeyson was rescued from a battlefi eld and adopted by Odin, the king of Asgard, who treated Loki as one of his own and raised him alongside his other son Thor. As the crafty god of mischief, Loki’s schemes have served as the inciting incident for many incredible adventures, including the formation of the original Avengers. He has been thought defeated many times, but he never fails to return, often even more cunning than ever.",
                    "Loki often plays the villain, but he’s served as a hero many times as well. His focus as a god has morphed many times too, including things like mischief, lies and stories.",
                ],
                Personality =
                [
                    "Feeling like an outsider to the Asgardian community, Loki harbors some resentment toward his brother, Thor, for his effortless ability to fit in. However, he’s willing to set everything aside in the name of a good prank. He delights in mischief above all else.",
                ]
            }
        },
        new()
        {
            Name = "Longshot",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 6, resilience: 3, vigilance: 5, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.MutantAssociate),
                tagSelector.GetTag(TagNames.PublicIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy3),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Luck,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CharmedLife),
                        powerSelector.GetPower(PowerNames.LuckyMe),
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
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DanceOfDeath),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Longshot",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [80],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Left eye glows when using powers; born with only eight fingers",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Exiles, TeamNames.XFactor, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "As the supreme leader of Mojoworld, the monstrous Mojo rules over a race of genetically engineered slaves that he abuses for his own amusement, forcing them into dire, life-or-death situations and filming the results for use in a series of sick and twisted TV shows. One of these slaves—a stuntman named Longshot—attempted to overthrow Mojo. As the result of a bizarre genetic experiment, Longshot had been born extremely lucky, and he came within a hair’s breadth of defeating Mojo once and for all before being mindwiped by Mojo’s lackeys.",
                    "The amnesiac Longshot fled to Earth-616, where he joined forces with the X-Men. He began a relationship with his teammate Dazzler and even had a son with her—who would become known as Shatterstar—before once again being captured and mindwiped by Mojo’s forces.",
                    "Eventually, the Exiles freed Longshot and invited him into their crew. After regaining most of his lost memories, he left the Exiles to join X-Factor Investigations and spend more time with Dazzler. Following the dissolution of X-Factor Investigations, Longshot all but disappeared.",
                    "Although a close mutant associate, Longshot is not a mutant himself, and he has been minimally involved in the Krakoan era. He is, presumably, still scouring the Multiverse for a way to defeat Mojo."
                ],
                Personality =
                [
                    "Because his mind is in shambles more often than not, Longshot operates almost entirely on sheer instinct. He trusts that his uncanny luck can lead him to where he needs to be and allow him to endure any troubles that may arise along the way.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Luke Cage",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 1, resilience: 5, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.Sturdy3}"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Harlem Apartment"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
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
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lucas “Luke” Cage; formerly Carl Lucas",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [425],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Bald",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Leader],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Defenders, TeamNames.HeroesForHire, TeamNames.MightyAvengers],
                Base = "New York City",
                History =
                [
                    "Imprisoned for a crime he didn’t commit, Carl Lucas was recruited by the prison’s doctor as a test subject for an experimental variant of the Super-Soldier Serum that empowered Captain America (Steve Rogers). Imbued with superhuman strength and durability, Lucas broke free of his prison and returned to the Harlem of his youth.",
                    "As a fugitive, Lucas adopted the name Luke Cage and began working as a Hero for Hire. Cage has been through a lot in the years since, sometimes teaming up with internationally recognized super-groups and sometimes returning to for-hire work, but he’s never stopped being a tireless fi ghter for the people of Harlem."
                ],
                Personality =
                [
                    "Cage is as sensitive and caring as he is tough and strong. Circumstances may force him into work as a paid hero, but he often helps those in need for free. Nothing is more important to him than his friends and family, including his wife, Jessica Jones, and their daughter, Danielle.",
                ]
            }
        },
    ];
}
