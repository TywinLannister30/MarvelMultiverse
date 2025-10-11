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
                Base = "New York City",
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
            Name = "Jackal",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 2, vigilance: 3, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Jackal form"),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.Riposte),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
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
            ],
            Biography = new Biography
            {
                RealName = "Miles Warren",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Gray, none (as Jackal)",
                Size = Size.Average,
                DistinguishingFeatures = "Green, goblin-like appearance with retractable claws and fangs (as Jackal)",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "Once a promising young bioengineer held in top regard by no less an authority than the High Evolutionary, Miles Warren fell into disgrace after a genetically modifi ed jackal of his own design killed most of his family.",
                    "Unable to procure another job, Warren fell back into the safety net of so many failed scientists: higher education. Working as a biochemistry professor at New York’s Empire State University, he became increasingly obsessed with student Gwen Stacy, to the point that after she died, he attempted to clone both her and her boyfriend, Peter Parker. Only after the fact did he realize that Parker was Spider-Man.",
                    "Sensing an opportunity to create incredible havoc and get revenge on one of the men he held responsible for Stacy’s death, Warren created several more clones of Parker. In the guise of the Jackal, he tormented Parker and his doubles with an increasingly complex series of mind games, deliberately manipulating them into harming and even killing one another.",
                    "Though Spider-Man and his clones eventually managed to unravel Warren’s initial treachery, the scientist’s mind games never really ended. After imbuing himself with the ability to assume a Jackal-like alternate form, he began creating clones of himself to torment the wall-crawler. At any given moment, a dozen or more clones of the Jackal, each believing himself to be the original, may be plotting to ruin the lives of Peter Parker and his allies.",
                ],
                Personality =
                [
                    "The Jackal is a chaos lover and sadist. It’s not enough for him to simply torture someone, though he’s certainly not above the act. Lacking any solid identity of his own, he feels a desperate need to make his victims question their own identities.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
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
            Name = "Jean Grey (X-Men '97)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 1, agility: 2, resilience: 3, vigilance: 5, ego: 7, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
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
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.EditMemory),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MentalPunch),
                        powerSelector.GetPower(PowerNames.MentalShelter),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
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
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "One of Professor X’s first X-Men, the mutant telepath Jean Grey shared a lengthy romance with teammate Scott Summers. Although their relationship was troubled by Jean’s attraction to Wolverine, Jean and Scott were eventually married. The obsessive geneticist Mister Sinister captured Jean briefly during her honeymoon. Jean’s life would change dramatically during a mission to outer space. During a difficult re-entry into Earth’s atmosphere, the cosmic Phoenix Force occupied Jean’s body, giving her immense power and saving her life. Shortly afterward, Mastermind and the Hellfi re Club tried to mind-control her; she eventually broke free, but the Phoenix’s evil side had been unleashed, transforming Jean into the Dark Phoenix. She went on a rampage before Jean reasserted control and seemingly destroyed herself to avoid harming her friends and her world. Jean survived, however, and the X-Men all sacrifi ced part of their life force to the Phoenix to return her to life. At some point, Jean was abducted by Sinister and replaced with a clone; unaware of her true nature, the clone believed she was the real Jean, and gave birth to Scott’s child, Nathan. Jean escaped from Sinister’s clutches and returned to the X-Men; the clone struck off on her own as “Madelyne Pryor,” while Nathan was sent to the future with Bishop to recover from Sinister’s experiments. Scott and Jean are attempting to pick up the pieces amid a worldwide war on mutantkind.",
                ],
                Personality =
                [
                    "Jean is the emotional center of the X-Men and is a calming influence on her teammates; however, her placid exterior conceals her strong will. She maintains enormous discipline to keep her psychic powers in check.",
                ]
            },
            Source = BookSource.XMen97Characters
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
            Name = "Jubilee (X-Men '97)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 5, logic: 1
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
                        powerSelector.GetPower(PowerNames.Discipline2),
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
                Teams = [TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "Jubilation Lee, alias Jubilee, was a normal, albeit rebellious, teenager until her mutant explosiveenergy- generating powers developed. Her foster parents alerted the authorities, who then sent the robotic Sentinels to apprehend her at her favorite hangout, the local mall. Jubilee was saved by the X-Men and was soon brought into their fold, becoming the newest member of the mutant hero team. The team helped her to master her powers and explore her mutant nature; she came to see the team as the family she never had, especially the otherwise-gruff Canadian mutant Wolverine. She has grown and matured during her tenure with the team; she successfully prevented the immortal mutant despot Apocalypse from using her as his new host body and handled herself admirably when she had to keep a group of children calm during a cave-in below the Xavier Mansion. Recently, she has connected with the X-Men’s newest recruit, the teenage Brazilian mutant Sunspot, and a romance between the two has blossomed. The duo was sucked into a virtualreality video game by the interdimensional media mogul Mojo, where Jubilee met Abscissa, an aged virtual-reality duplicate of herself who helped the two of them escape. Unfortunately, her nascent romance with Sunspot was cut short when he joined Rogue in defecting to Magneto’s side in his upcoming war on humanity. The two would-be lovers subsequently battled on Magneto’s Asteroid M.",
                ],
                Personality =
                [
                    "Jubilee is energetic, fun-loving and eager to learn more about her growing mutant powers. As a teenager, she is immature and a tad selfcentered, and sometimes fails to grasp the gravity of the X-Men’s mission. Despite her age and inexperience, she refuses to be underestimated or excluded from “grown-up” X-Men operations. She is very close to her X-Men teammates, especially her mentor Wolverine.",
                ]
            },
            Source = BookSource.XMen97Characters
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
