using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersJ
{
    public static List<Character> GetAllCharacters(
       INarrativePowerSelector narrativePowerSelector,
       IPowerSelector powerSelector,
       ITagSelector tagSelector,
       ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "J. Jonah Jameson",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 0, resilience: 0, vigilance: 1, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.Skeptical),
            ],
            Tags =
            [
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "John Jonah Jameson Jr.",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [181],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black with gray temples",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.TheDailyBugle, TeamNames.TNM],
                Base = "NYC",
                History =
                [
                    "Determined to make the world a better place, J. Jonah Jameson spent his childhood studying the art of journalism. As a mere high school student, he wriggled his way into a position as a junior reporter with the Daily Bugle. Jameson’s stellar reporting on civil rights issues, alongside his thrilling exposés on organized crime, rocketed him to the top of the paper’s lineup.",
                    "Eventually, Jameson found the resources to buy the Daily Bugle and install himself as the editor in chief. Practically overnight, Jameson turned the Bugle from a failing local rag into an internationally respected news organization.",
                    "More than anything, Jameson is renowned for his editorial stance against costumed super heroes. As a man dedicated to the truth, he despises anyone whom he believes has something to hide. He has a particular sore spot for Spider-Man, who operates in the Bugle’s direct vicinity.",
                    "Jameson lost control of the Daily Bugle and was forced to get a job as a regular reporter again. He even became mayor of New York City for a while. He has since returned to his fi rst love: the news."
                ],
                Personality =
                [
                    "While he can come off as charming on camera, Jameson’s employees know him as the gruff and abrasive man he really is. Although he retains the strong sense of justice he had in his youth, years of dangerous reporting work have turned Jameson into an angry cynic. He spends his days alternately shouting at his reporters to work harder and brooding in his office, scheming ways to keep his latest venture in the black.",
                    "Jameson has a soft spot for his son, John Jameson (A.K.A. Man-Wolf), whose heroics as an astronaut earned him worldwide recognition."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Jean Grey",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 3, vigilance: 7, ego: 8, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Fearless),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Levitation),
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticBarrier),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                        powerSelector.GetPower(PowerNames.TelekineticProtection2),
                        powerSelector.GetPower(PowerNames.TelekineticReinforcement),
                        powerSelector.GetPower(PowerNames.TelekineticSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.CloakGroup),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Domination),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
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
                RealName = "Jean Grey-Summers",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.XForce, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "Jean Grey’s mutant psychic abilities awakened when she was just 10 years old, after she witnessed her best friend die in a hit-and-run. With Jean traumatized and unable to control her nascent powers, her parents did the only thing they could think of. They entered her into the care of psychic professor Charles Xavier, better known as Professor X.",
                    "Not long thereafter, Xavier formed the original X-Men and installed Grey as a founding member, under the codename Marvel Girl. In the years since, Grey has become one of the most famous and powerful mutants—if not heroes—in existence. Along with the rest of the X-Men, she has fought against existential threats to the universe itself.",
                    "Additionally, Grey has hosted the Phoenix Force, an ineffable entity of light and fire older than the cosmos. Although the Phoenix Force has currently bound itself to another, Grey remains extremely powerful.",
                    "Two of Grey’s future children that she has yet to have with Cyclops (Scott Summers)—who she is in a long-term relationship with—have become X-Men on their own: Rachel Summers and X-Man (Nate Grey)."
                ],
                Personality =
                [
                    "Grey’s powers are limited by her ability to control her mental state. She has rarely been completely stable on a psychic level, and repeatedly acting as the host of the sentient Phoenix Force has only served to further damage her. When she is stable, though, Grey is known for her kind and caring nature. Grey’s teammates have long been a driving force in helping her to maintain her sanity, particularly Cyclops.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Jessica Jones",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 3, vigilance: 2, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Harlem Apartment"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Jessica Campbell Jones",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [124],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Investigator],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Defenders],
                Base = "New York City",
                History =
                [
                    "Jessica Campbell’s entire family was killed when their car hit a truck carrying dangerous radioactive chemicals. Jessica survived, but the chemicals gave her super-powers. Adopted by a new family, she changed her last name to Jones and began fighting crime as the costumed hero Jewel, but after being captured and mind-controlled by the Purple Man for months, she hung up her mask.",
                    "Jones later opened up Alias Investigations, a forprofit P.I. firm, using her powers to help people— but without a costume. She has since married her love Luke Cage, with whom she has a little girl, Danielle."
                ],
                Personality =
                [
                    "Jones’ hard life has made her more than a little world-weary, but despite her travails she remains a strongly caring person. She may work for profit, but still she strives to deliver the best possible outcomes for her clients, going out of her way to ensure that they get the justice they pay for.",
                ]
            }
        },
        new()
        {
            Name = "Jubilee",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 3, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Dependents, reminder: "Shogo"),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.ElementalPush),
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
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BangingHeads),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jubilation Lee",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [115],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Excalibur, TeamNames.GenerationX, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Jubilation Lee’s parents were killed when she was just a teenager. Unwilling to spend the rest of her childhood in an orphanage, she took to living in the back rooms of a shopping mall. It was around this time that Lee’s mutant powers began to manifest. She used her newfound control over light energy to become a busker, living on donations from local shoppers.",
                    "Soon enough, an anti-mutant militia caught wind of Lee’s superhuman performances and attempted to run her out of the mall. Thankfully, a group of X-Men managed to rescue her from the bigots.",
                    "Lee’s rescuers offered her a position within their ranks. She accepted, and for a time, she was an active member of the main team. However, as a younger person, Lee never felt fully accepted by her older teammates. She eventually left the X-Men to form Generation X, a team consisting entirely of mutant teenagers.",
                    "Lee and the other Generation X members eventually got older and went their separate ways, but they still remain close. With the help of her former teammate Jono Starsmore (A.K.A. Chamber), Lee adopted and is currently raising a young boy she named Shogo."
                ],
                Personality =
                [
                    "Lee has been a hero long enough now to consider herself a seasoned adventurer. That said, she still emanates a certain kind of endearing dorkiness. Her favorite activities include going to the arcade and LARPing with her friends.",
                    "Despite the hardships she’s been through, Lee is as enduringly upbeat as her first name would imply. She is also a caring mother, always putting Shogo’s safety first, something that’s often proved a real challenge."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Juggernaut",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 7, agility: 2, resilience: 7, vigilance: 3, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "Sturdy 4"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "Crimson Gem of Cyttorak [Any attack which deals less than 30 points of damage to the user of the Crimson Gem is instantly negated.]"),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.Sturdy4),
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
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Cain Marko",
                Heights = [new() { Feet = 6, Inches = 10 }],
                Weights = [900],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Red",
                Size = Size.Big,
                DistinguishingFeatures = "Unnatural strength and bulk as result of powers",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "While not a mutant himself, Cain Marko’s fate was permanently bound to that of mutant society the day that Charles Xavier—the future Professor X—became his stepbrother. As boys, they had a rocky relationship, with Marko resenting Xavier’s obvious brilliance.",
                    "While serving as a U.S. soldier, Marko stumbled upon the Crimson Gem of Cyttorak, a mystical artifact that infused his body with superhuman strength and size. Seeing a chance to get the better of his stepbrother, Marko became the new Juggernaut and used his power for super-villainy."
                ],
                Personality =
                [
                    "Marko and Xavier have slowly managed to repair their relationship, and in recent years, the Juggernaut has been more often a force for good than evil. Although a bit dense by nature, Marko has shown surprising moments of intelligence and humility. The main thing that still manages to set him off is Xavier, who struggles to fully trust him.",
                ]
            }
        },
    ];
}
