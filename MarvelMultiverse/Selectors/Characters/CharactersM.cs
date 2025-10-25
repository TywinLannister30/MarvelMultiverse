using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersM
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
            Name = "M",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 4, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Penance form"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = $"{PowerSetNames.MeleeWeapons} Blunt/Sharp",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.HitAndRun),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Monet St. Croix",
                Heights = [new() { Feet = 5, Inches = 7 }, new() { Feet = 5, Inches = 5 }],
                Weights = [125, 180],
                Gender = Gender.Female,
                Eyes = "Brown/Blue",
                Hair = "Black/Red",
                Size = Size.Average,
                DistinguishingFeatures = "Red, spiny Penance form",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.AvengersUnityDivision, TeamNames.GenerationX, TeamNames.XFactor, TeamNames.XForce, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a young girl, Monet St. Croix was trapped in the form of a mute and prickly red creature by Marius St. Croix, her evil older brother. Marius intended to keep Monet in such chains for the rest of her life, using the marrow in her bones to quell his insatiable hunger for mutant genetic material. But with the help of the mysterious mutant hero Gateway, Monet eventually managed to escape.",
                    "Gateway left Monet in the care of a team of young mutant super heroes known as Generation X. She became a successful member of the team, and they, in turn, helped free her from her alternate form (known as Penance). Finally back in her own body, Monet adopted the codename of M.",
                    "M went on to become a vital member of many important mutant teams, such as X-Force, X-Factor Investigations and the X-Men themselves. She later took up residence on Krakoa, not far from her rambunctious younger sisters Claudette and Nicole, who have frequently used their own powers to disguise themselves as Monet.",
                    "As the co-head of Krakoa’s X-Corp, M played a critical role in the maintenance of the island-nation’s finances. She has recently displayed the ability to voluntarily take on her old Penance form, though precisely how she managed this feat remains unknown."
                ],
                Personality =
                [
                    "The traumas M suffered in her early life led her to adopt the personality of a stuck-up snob. Afraid of letting anyone get too close, she spent much of her life purposefully pushing her friends away, treating them like her lessers.",
                    "M has mellowed out in her later years, but she is still a rather cold and ruthless person—which makes her a perfect fit for X-Corp."
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Alternate Form",
                        Description =
                        [
                            "M’s Penance form slightly changes the way her powers work. As Penance, M gains the Mighty 2 and Sturdy 1 powers. Her attacks become Sharp, and she loses her Brilliance 1 power. In her M form, she retains Mighty 1 and gains Brilliance 1 but loses Sturdy 1.",
                            "Numbers before a slash are for her regular human form, and numbers after a slash are for her Penance form."
                        ]
                    }
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Madame Masque",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Leverage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Submachine gun"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                        powerSelector.GetPower(PowerNames.FastStrikes),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Giuletta Kristina Nefaria",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Gray",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Scarred face beneath mask",
                Occupations = [OccupationName.Criminal, OccupationName.Spy],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Maggia],
                Base = "Mobile",
                History =
                [
                    "As a baby, Giuletta Nefaria was discarded by her father Count Nefaria—the one-time leader of the Maggia. She spent her youth believing she was the daughter of a pair of wealthy Wall Street fi nanciers. It was only after the death of her adoptive parents that Luchino re-entered Giuletta’s life.",
                    "Sensing potential in the young woman, Luchino coerced his daughter into joining the Maggia. He gave her special training in combat and forced her to act as a Maggia spy under the codename of Madame Masque. Although she eventually separated herself from her toxic father, Giuletta has continued to work as a Maggia agent.",
                ],
                Personality =
                [
                    "Unlike a lot of mafiosos, Madame Masque is not driven primarily by greed. She works for the Maggia because it’s the only way she knows to make a sound living. A well-conceived moral argument could convince her to compromise her criminal ways.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Madame Monstrosity",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 1, resilience: 5, vigilance: 3, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.UnusualSize, reminder: "Huge; reach 5"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.AdditionalLimbs, reminder: "tail"),
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlFire,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Melodia Stillwell",
                Heights = [new() { Feet = 21, Inches = 11 }],
                HeightReminder = "formerly 5'10\"",
                Weights = [7000],
                WeightReminder = "formerly 161 lbs.",
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Black with white streaks",
                Size = Size.Huge,
                SizeNotes = "formerly average",
                DistinguishingFeatures = "Dragon-like body with fur, stripes, claws, beak, pointy tail and vestigial wings",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "In hopes of catching the eye of the High Evolutionary, mad geneticist Madame Monstrosity kidnapped dozens of people off the streets of New York City and used experimental techniques to turn them into human-animal hybrids known as Humanimals. Unfortunately for her, her greatest creation—Spider-Boy—almost immediately escaped her clutches, leaving her without proof of her supposed genius.",
                    "Frustrated beyond all measure, Monstrosity sent her most trusted Humanimal agents to recover the boy. After years of fruitless effort, they finally managed to lure him back to her lab by kidnapping his best friend, Christina Xu.",
                    "Spider-Boy tried to surrender to Madame Monstrosity, but his mentor, Spider-Man (Peter Parker), noticed his absence and organized an Avengers raid of the geneticist’s compound. In a desperate attempt to fight back, Monstrosity turned herself into a horrifying amalgamation of dozens of creatures, but even this form stood no chance against the combined forces of Spider-Man and the Avengers.",
                    "Just as Monstrosity was about to be defeated, the High Evolutionary swooped in and kidnapped her. By transforming into a monster, she had finally garnered his interest—as a specimen.",
                ],
                Personality =
                [
                    "Madame Monstrosity styles herself after the mad scientists of Victorian-era sci-fi , particularly Dr. Frankenstein. Her actions may be disgusting, but her clothes, accent and vocabulary all reek of nineteenth-century high society. She is the kind of person to unironically toss the word poppycock into a sentence.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Madame Web",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 2, vigilance: 4, ego: 2, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Dependents, specialization: "Rachel Carpenter"),
                tagSelector.GetTag(TagNames.SecretIdentity),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.VisionIssues),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SixthSense,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DangerSense),
                        powerSelector.GetPower(PowerNames.Intuition),
                        powerSelector.GetPower(PowerNames.Precognition3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Levitation),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Julia Eugenia Cornwall Carpenter",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [140],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Magic, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.SpiderArmy, TeamNames.SpiderSociety],
                Base = "New York City",
                History =
                [
                    "As a single mom and divorcée, Julia Carpenter spent most of her life scrambling to make rent, so when an old college friend offered her a bucketload of money to participate in a short scientifi c study, Carpenter readily agreed.",
                    "A secretive government-backed research group known only as the Commission injected her with an experimental spider-serum, granting her a slew of spider-based super-powers. Government agents thereafter pressured her into joining the technically-legal-but-still-villainous Freedom Force, but once Carpenter saw how bad the team was, she fl ed government custody and started acting as a crimefi ghter for hire. As Spider- Woman, she established herself as one of the hardest-working heroes around, assisting dozens of super heroes in making the world a safer place to live, all while caring for her young daughter.",
                    "Carpenter was one of the only people present to witness the original Madame Web (Cassandra Webb) be mortally wounded in battle with the Kravinoff family. On the verge of death, Webb transferred her powers to Carpenter, blinding her but also granting her an extensive set of precognitive abilities. Carpenter subsequently adopted the codename of Madame Web and took the dead woman’s place as an advisor and organizer for Spider-People across the Multiverse.",
                ],
                Personality =
                [
                    "Carpenter has always been fairly stern and serious, and becoming Madame Web hasn’t loosened her up. She is a highly intelligent, experienced and all around excellent advisor, but just as with the original Madame Web, her advice often comes tinged with a bit of world-weary condescension. The only person she really opens up to is her daughter, Rachel.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Maddy Cho",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 0, vigilance: 1, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pistol"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
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
                RealName = "Madame Curie “Maddy” Cho",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [118],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.OlympusGroup],
                Base = "Mobile",
                History =
                [
                    "Despite having an intellect to rival the world’s top scientists, Maddy Cho spends most of her time acting as a caretaker for her younger brother Amadeus—the boy better known as Brawn. Maddy is one of the few people in the world who Amadeus truly respects. Her calm maturity helps to temper her brother’s fi ery and often unstable personality.",
                    "Maddy is, ostensibly, a student, but her vast intellect makes school a minimal concern. She spends most of her time either looking after her brother or working on some self-driven scientifi c project. She jumps at any opportunity to study mysterious scientifi c phenomena.",
                ],
                Personality =
                [
                    "Although she’s just a teenager herself, Maddy has a very serious personality. Since the death of their parents, she’s had to act more and more as a mother to her younger brother. Only on the rare occasions that she’s separated from Amadeus does Maddy relax her typically stern demeanor.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Madelyne Pryor",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 4, vigilance: 7, ego: 8, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Magic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BrainDrain),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.SummonPortal),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AstralForm),
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                        powerSelector.GetPower(PowerNames.TelepathicPossession),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Madelyne Jennifer Pryor",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "Eyes sometimes glow red",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery, OriginName.Mutant],
                Teams = [TeamNames.HellfireClub, TeamNames.SisterhoodOfMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Mister Sinister created a clone of Marvel Girl (Jean Grey) and implanted a false identity in her, causing her to believe she was a pilot named Madelyne Pryor. Working from the shadows, he ensured she would meet and fall in love with Cyclops and, eventually, have a child with him, one he hoped might become a world-ending weapon he could turn to his advantage.",
                    "Sinister did succeed in bringing Pryor and Cyclops together, but his plans spiraled outward from there. The child Pryor and Cyclops had was powerful—eventually becoming the time-traveling hero Cable—but he was not Sinister’s ultimate weapon. Sinister attempted to cover up his scheme by killing Pryor, only to end up accidentally activating her psychic powers.",
                    "Driven mad by her newfound power, Pryor turned on both Sinister and the X-Men, attacking them as the Goblin Queen. Although she eventually regained her sanity, Pryor retained her resentments toward Sinister and Cyclops for years afterward. Despite that, she struck up a long-term relationship with Cyclops’ brother Havok.",
                    "Pryor died but was later resurrected on Krakoa, after which Magik helped her become the new ruler of Limbo."
                ],
                Personality =
                [
                    "Madelyne Pryor is, in many ways, a photographic negative of Jean Grey. They may look identical, but Pryor has embraced the darker side of her psyche in a way that Grey usually refuses.",
                    "Grey does her best to be an upstanding, shining example for others, even under the direst of circumstances. Pryor cares only about getting the job done, often regardless of morals or optics."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Maestro",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 9, agility: 2, resilience: 8, vigilance: 5, ego: 3, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bruce Banner"),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.GreenDoor),
                tagSelector.GetTag(TagNames.Immunity, specialization: "Gamma Radiation"),
                tagSelector.GetTag(TagNames.Powerful),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Radioactive),
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
                        powerSelector.GetPower(PowerNames.Anger),
                        powerSelector.GetPower(PowerNames.Brawling),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty4),
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
                        powerSelector.GetPower(PowerNames.Jump2),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                        powerSelector.GetPower(PowerNames.UnrelentingSmash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Robert Bruce Banner",
                Heights = [new() { Feet = 7, Inches = 6 }],
                Weights = [1150],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Gray",
                Size = Size.Big,
                DistinguishingFeatures = "Large green Hulk form",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.WeirdScienceGammaMutate],
                Teams = [],
                Base = "Mobile (Earth-9200)",
                History =
                [
                    "On Earth-9200, the modern era ended in a nuclear holocaust that wiped out nearly every human and superhuman on the planet. The Hulk (Bruce Banner), however, was far enough away from the center of the destruction to actually benefit from the excess gamma radiation.",
                    "This supercharged version of the Hulk used his powers to take over the last surviving human city—Dystopia—and install himself as its supreme dictator or Maestro. For decades, he ruled uncontested over the people of Dystopia, living in tyrannical opulence, until a resistance group led by an elderly Rick Jones summoned the Hulk of Earth-616 from out of the timestream.",
                    "This younger Hulk—in his Professor Hulk form—helped the resistance launch a massive assault on the Maestro’s compound. Even then, their combined strength failed to match the Maestro’s own. Ultimately, the Hulk only defeated the Maestro by sending him back in time, to the center of the nuclear explosion that first created them both.",
                    "Though the Maestro later re-formed on Earth-616, the experience had weakened him enough for the Hulk to quickly dispatch him. Officially speaking, the Maestro has been dead for years now. Of course, gamma mutates have a way of coming back at unexpected moments."
                ],
                Personality =
                [
                    "The Maestro is a greedy despot who cares nothing for the rights of others, but he is not an incoherent madman. He is intelligent, eloquent, manipulative and cunning, perhaps more so than the Hulk of Earth-616 has ever been.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Maggia Tough",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 0, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Determination),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Pistols or clubs"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
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
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.SpecialTraining],
                Teams = [],
                Base = "Varies",
                History =
                [
                    "Born out of European crime syndicates that date back centuries, the modern Maggia are less a singular entity and more a group of criminal families who occasionally aid one another. They have no hidden bases or Helicarriers. They’re a bunch of racketeers who scratch each other’s backs.",
                    "Unlike Hydra or other fanatical criminal organizations, Maggia toughs are motivated primarily by profi t, not political ideology. Their pursuit of money often leads them to commit heinous crimes and even bankroll super villains, but they can be persuaded down more righteous paths—for the right price.",
                ],
                Personality =
                [
                    "Many members of the Maggia are suit-wearing wiseguys. Most high-ranking members gain their status by being born into one crime family or another. Regular toughs, on the other hand, come from all sorts of places. New recruits tend to be poor youths with few scruples, folks happy to join up with a well-established criminal outfit.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Magik",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 6, ego: 8, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
                tagSelector.GetTag(TagNames.Supernatural),
                tagSelector.GetTag(TagNames.XGene),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "The Soulsword"),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                        powerSelector.GetPower(PowerNames.Wisdom),
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
                        powerSelector.GetPower(PowerNames.CrimsonBandsOfCyttorak),
                        powerSelector.GetPower(PowerNames.DispelSpell),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.ShieldOfTheSeraphim),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelDimensional,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DimensionalTravel),
                        powerSelector.GetPower(PowerNames.DimensionalTravelOther),
                        powerSelector.GetPower(PowerNames.DimensionalTravelTogether),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    Name = "The Soulsword",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Discipline4, powerSelector.GetPower(PowerNames.Discipline4)),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Summonable),
                        iconicItemPowerSelector.GetIconicItemPower(IconicItemPowerNames.Weapon, reminder: "Range: Reach, Melee Damage Multiplier Bonus: +2."),
                    ],
                    Restrictions =
                    [
                        "Carried",
                        "Flashy",
                        "Discipline power only works against magical creatures."
                    ],
                    PowerValue = 3,
                    MeleeDamageModifier = 2,
                },
            ],
            Biography = new Biography
            {
                RealName = "Illyana Nikolievna Rasputina",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.MagicSorcery, OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.StrangeAcademy, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As the younger sister of Colossus, Illyana Rasputina was doomed never to live a normal life. At the age of 6, she was kidnapped by the evil sorcerer Belasco and dragged into the demonic dimension of Limbo.",
                    "Belasco kept her captive in Limbo for seven years, forcing her to act as his servant and apprentice. He was a cruel and abusive caretaker, but he taught Rasputina how to fight, and how to access Limbo’s sorcerous magics.",
                    "Colossus and the X-Men eventually managed to free Rasputina from Belasco’s clutches, but the damage had been done. She returned to Earth just moments after she had been taken, but seven years older and with a lifetime of trauma behind her.",
                    "Forever changed, Rasputina decided to use her new skills for the betterment of mutantkind. Following in her older brother’s footsteps, she took on the codename of Magik and joined the New Mutants.",
                    "In the years since her return from Limbo, Magik has proven herself to be at least as important and vital a mutant hero as her brother. As one of the Great Captains of Krakoa, she oversaw all operations taken on by younger mutant squadrons, including the New Mutants."
                ],
                Personality =
                [
                    "As a team leader and educator, Magik is strict, serious and focused. Doctor Strange himself would find it a challenge to beat her in a contest of magical prowess.",
                    "That said, Magik is still young. When she’s not fighting for her life or leading a team through enemy territory, she can be casual, snarky and even outright goofy. The elder leaders of Krakoa consider her to be something of a mischief maker."
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Magma",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 3, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.ElementalBarrage),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Supernova),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
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
                        powerSelector.GetPower(PowerNames.ElementalForm),
                        powerSelector.GetPower(PowerNames.ElementalProtection2),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.Supernova),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Amara Juliana Olivians Aquilla",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [131],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Hellions, TeamNames.NewMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Amara Aquilla was born into an important political family within the city of Nova Roma, a long-lost Roman colony hidden deep within the jungles of Brazil. She had minimal contact with the outside world until her teen years, when the sinister Black Priestess (Selene Gallio) launched a soft coup against the city’s leaders. Fearing for her life, Aquilla fled into the surrounding jungle, where she encountered the New Mutants.",
                    "Despite the team’s best efforts, the Black Priestess captured Aquilla and threw her into a pit of boiling lava. However, rather than dying, Aquilla discovered she could control the liquid rock and even merge with it. She used her new powers to defeat the Black Priestess, and as thanks for her help, the New Mutants offered her a place on their team. Aquilla accepted, and under the codename Magma, she began adventuring with the New Mutants.",
                    "Magma later served on other teams, including the X-Men, but she never strayed far from her New Mutant roots. She remains close friends with all of the original New Mutants, and although she has of late put her super-hero duties on the back burner to focus on herself, she is still considered a backup member of the team.",
                ],
                Personality =
                [
                    "Emotional outbursts can cause Magma’s powers to go berserk, to the point of summoning entire volcanoes. For the safety of those closest to her, she does her best to stay cool and collected at all times, maintaining a polite and reserved demeanor. Of course, those repressed emotions have to come out eventually. When Magma does get mad, she gets really mad.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Magneto",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 6, ego: 9, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Arabic, English, French, German, Hebrew, Polish, Russian, Ukrainian, Yiddish"),
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
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny4, isTech: true),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection4),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                        powerSelector.GetPower(PowerNames.ElementalSuffocation),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Max Eisenhardt",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Auschwitz I.D. #24005 tattoo on arm",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "Max Eisenhardt, going by the name Erik Lensherr, first met Charles Xavier (who would become Professor X) while working at a psychiatric hospital for Holocaust survivors, where they recognized each other’s mutant powers and had heated debates about mutant integration into normal society. As a Holocaust survivor himself, Eisenhardt struggled to accept that humanity would ever accept mutants.",
                    "Eisenhardt later became the villain Magneto and formed the Brotherhood of Evil Mutants in direct opposition to Xavier’s own X-Men. Eventually, Magneto put aside such methods and even led the X-Men himself for a while. He has long worked to establish a homeland for mutants, and with Krakoa, he feels that he and Charles may finally have succeeded."
                ],
                Personality =
                [
                    "Magneto has a strong sense of right and wrong. Periods of mental instability throughout his life have sometimes made him into a zealot willing to harm innocents in the pursuit of his dreams, but his righteous intentions have never wavered.",
                ]
            }
        },
        new()
        {
            Name = "Magneto (X-Men '97)",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 5, ego: 8, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Arabic, English, French, German, Hebrew, Polish, Russian, Ukrainian, Yiddish"),
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
                        powerSelector.GetPower(PowerNames.Discipline4),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection4),
                        powerSelector.GetPower(PowerNames.ElementalPush),
                        powerSelector.GetPower(PowerNames.ElementalReinforcement),
                        powerSelector.GetPower(PowerNames.ElementalSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Erik Lehnsherr",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [190],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Auschwitz I.D. #24005 tattoo on arm",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
                Base = "X-Mansion",
                History =
                [
                    "Erik Magnus Lehnsherr became embittered with humanity after losing his family during the Holocaust. After the war, Magnus befriended fellow mutant Charles Xavier, but Charles’ philosophy of peaceful coexistence between mutants and humans confl icted with his desire for mutant domination. Magnus married, but after he used his mutant powers to control magnetism violently, his wife, Magda, fled.",
                    "As Magneto, he gathered fellow mutants and began violent acts of terrorism against humanity. In the Antarctic Savage Land jungle, Magneto created a race of super-powered Mutates and became briefl y involved romantically with the mutant Rogue, struggling to control her powers. Magneto wore a special helmet to protect himself from Xavier’s psychic powers. Magneto’s forces clashed with Xavier’s X-Men team, as Magneto attempted to provoke world war with nuclear weapons but was opposed by giant Sentinel robots. Magneto and the X-Men joined forces to defeat the Sentinel-creating Master Mold.",
                    "Inviting all mutants to join him on the orbiting Asteroid M, Magneto’s dream to live completely independent of humanity failed after he was betrayed by false follower Fabian Cortez. When Xavier was seemingly killed, Magneto inherited leadership of the X-Men and was soon invited to lead the mutant island of Genosha. The living Sentinel Bastion launched a devastating attack on Genosha and captured Magneto. Escaping, Magneto would attack Bastion’s army with a global electromagnetic pulse that endangered humanity.",
                    "In the battle between Magneto, the Sentinels and the X-Men, Magneto pulled out Wolverine’s adamantium skeleton and Xavier damaged Magneto’s psyche. Xavier has pledged to repair the damage."
                ],
                Personality =
                [
                    "Magneto’s charisma is as powerful as his magnetic prowess. A stoic, inspirational leader, Magneto easily gathers followers despite his extremely cynical beliefs. Though respectful of Xavier, he travels his own path.",
                ]
            },
            Source = BookSource.XMen97Characters
        },
        new()
        {
            Name = "Magnitron",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 4, vigilance: 3, ego: 5, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.BreatheDifferent),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military (Kree Empire)"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Piloting),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy3),
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
                }
            ],
            Biography = new Biography
            {
                RealName = "Yon-Rogg",
                Heights = [new() { Feet = 6 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Auburn",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Military, OccupationName.Outsider],
                Origins = [OriginName.AlienKree],
                Teams = [TeamNames.ImperialKreeAmy],
                Base = "Hala",
                History =
                [
                    "As a young adult, Yon-Rogg enlisted in the Kree Imperial Army, where he befriended a man named Mar-Vell. At first, their friendship was solid, but as time wore on, Yon-Rogg became increasingly jealous of the admiration showered upon Mar-Vell by the other Kree, so he stabbed Mar-Vell in the back and abandoned him on Earth.",
                    "Tasked with expanding the Kree Empire, Yon- Rogg attempted to invade Earth time and time again, only to be defeated each time by Captain Marvel (Mar-Vell), who survived his treachery. Mar-Vell died years ago, but Yon-Rogg continues to hunt those who associated with him, including the current Captain Marvel (Carol Danvers). In more recent years, he gained new powers and assumed the codename Magnitron."
                ],
                Personality =
                [
                    "Yon-Rogg is normally a serious and competent soldier, but his hatred for Mar-Vell and the man’s legacy often drives him to irrational ends.",
                ]
            }
        },
        new()
        {
            Name = "Mainframe",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 3, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AI),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Avengers Mansion"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "known to allies"),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                    IsTech = true
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
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                    ],
                    IsTech = true,
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                    ],
                    IsTech = true,
                },
            ],
            Biography = new Biography
            {
                RealName = "Mainframe",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [325],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Sentient suit of yellow and black Iron Man armor",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.ANext],
                Base = "New York City (Earth-982)",
                History =
                [
                    "Before retiring from the hero business, the Iron Man (Tony Stark) of Earth-982 used his own brain patterns to create a weaponized android—called Mainframe—capable of taking his place in the field, should the need ever arise. To ensure that the droid’s A.I. could never be permanently destroyed, Stark placed dozens of droid bodies in an orbital satellite, backups into which the sentient program could upload itself at a moment’s notice.",
                    "Years passed without incident, but eventually, one of the Mainframe droid bodies was called into combat to help a group of young heroes foil a villainous scheme cooked up by Loki. After the fight, the droid and his young allies formed a new incarnation of the Avengers, colloquially referred to as A-Next.",
                    "Though Mainframe initially posed as a human in a suit, his teammates caught on to his true nature after one of his robotic bodies was torn apart in combat. Mainframe later destroyed most of his backup bodies while fighting Galactus, but despite his brush with mortality, he remains a dedicated and respected member of A-Next."
                ],
                Personality =
                [
                    "Perhaps because his brain is patterned off that of a much older man, Mainframe stands out from the other members of A-Next. He is a far sterner and more cynical individual than his teammates, though working with them has gradually softened his metal demeanor. He shares the responsibility of leading A-Next with American Dream.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Malekith",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 4, ego: 6, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weakness, specialization: "Iron"),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Mist"),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Sorcerous),
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
                        powerSelector.GetPower(PowerNames.Discipline3),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.SummonPortal),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
                        powerSelector.GetPower(PowerNames.WindsOfWatoomb),
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
                RealName = "Malekith",
                Heights = [new() { Feet = 6, Inches = 9 }],
                Weights = [185],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "Dark blue skin on right side of body, black on left",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Mythic],
                Teams = [TeamNames.DarkCouncil, TeamNames.DarkElves],
                Base = "Niffleheim",
                History =
                [
                    "Malekith was born in Svartalheim—the Asgardian realm of the dark elves—during a tumultuous period of war and suffering. He saw his whole family die in the fi ghting, only for his mother— his one remaining relative—to sell him off for a few sacks of food.",
                    "While in captivity, Malekith made the acquaintance of a wizard who taught him powerful spells. Together they plotted ways to escape their prison and bring an end to the war. Unfortunately, Malekith had already gone mad. At the last second he betrayed his magical compatriot. With his dying breath, the wizard used his remaining magic to permanently mar Malekith, turning half of his body pitch-black.",
                ],
                Personality =
                [
                    "War has been the defining feature of Malekith’s life, and he is in love with the chaos. While he is far more sadistic than Loki, Malekith frequently finds an ally in the god of mischief in his plots against Asgard itself.",
                ]
            }
        },
        new()
        {
            Name = "Mandarin",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 5, ego: 7, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Mandarin City"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.Sorcerous),
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
                        powerSelector.GetPower(PowerNames.Discipline3),
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
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MagicSorcery,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BoltsOfBalthakk),
                        powerSelector.GetPower(PowerNames.FlamesOfTheFaltine),
                        powerSelector.GetPower(PowerNames.IcyTendrilsOfIkthalon),
                        powerSelector.GetPower(PowerNames.ImagesOfIkonn),
                        powerSelector.GetPower(PowerNames.MistsOfMunnopor),
                        powerSelector.GetPower(PowerNames.VaporsOfValtorr),
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
                        powerSelector.GetPower(PowerNames.LegSweep),
                        powerSelector.GetPower(PowerNames.UnflappablePoise),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [215],
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.MagicSorcery],
                Teams = [TeamNames.TheHand, TeamNames.Triads],
                Base = "Mandarin City",
                History =
                [
                    "Born into a poor English family in the Chinese countryside, the future Mandarin was forced to flee his childhood home by the rising communist revolution. Wandering about, he stumbled upon the wreck of an alien spacecraft, inside of which he found ten magic rings that granted him unstoppable mystical powers. Enthralled by his new powers, the young man claimed the title of the Mandarin and began building himself into the greatest arms smuggler on the planet.",
                    "The Mandarin’s arms dealing frequently brings him into confl ict with Tony Stark (Iron Man), a reformed arms manufacturer himself. The Mandarin generally prefers to work against Stark through proxies, but he is plenty capable of holding his own against Iron Man when drawn out.",
                ],
                Personality =
                [
                    "Highly unstable and egotistical, the Mandarin has been racked by delusions of glory throughout his entire life. A conqueror at heart, he would see war and chaos spread across the globe.",
                ]
            }
        },
        new()
        {
            Name = "Mangaverse Spider-Man",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 1, vigilance: 2, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Aunt May Reilly"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
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
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ReverseMomentumThrow),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webslinging),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Peter Parker",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [120],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Magic, OriginName.SpecialTraining],
                Teams = [TeamNames.Avengers, TeamNames.SpiderArmy, TeamNames.SpiderClan, TeamNames.SpiderSociety],
                Base = "New York City (Earth-2301)",
                History =
                [
                    "In Earth-2301, the traditional heroes and villains of Earth-616 have been recast into roles heavily inspired by the aesthetics and tropes of early Japanese action manga. Giant robots, acrobatic ninja, noble samurai and cybernetic hackers all live alongside one another in a near-future incarnation of New York City.",
                    "In this Mangaverse, Peter Parker spent most of his childhood training in the ways of the Spider-Clan shinobi under his Uncle Ben. Shortly after young Parker entered high school, Ben’s long-lost son Venom returned home and—on orders from the criminal mastermind Kingpin—cut down his father. Determined to avenge his beloved teacher, Parker donned his uncle’s old mask and took to the streets as the unstoppable Spider-Man.",
                    "Along the way to Venom’s lair, Parker was possessed by a cursed symbiotic spirit living inside an amulet. It corrupted his mind and body, nearly killing him, but in a grand gesture of guilt and remorse, Venom sacrificed himself to destroy the cursed creature and save Spider-Man. Though the curse was over, Parker would forever retain the ability to make webs, a reminder of Venom’s sacrifice.",
                    "To pay tribute to both his cousin and his uncle, Parker vowed to keep being Spider-Man for as long as he lived. Alongside his classmate Mary Jane and his sometimes-love interest Felicia Hardy, he joined an upstart band of adventurers known as the Avengers.",
                    "Though Spider-Man does not yet know it, Hardy has been working behind the scenes with a dark version of Nick Fury to manipulate these new Avengers toward dubious ends."
                ],
                Personality =
                [
                    "Like a lot of early manga protagonists, Earth- 2301’s Peter Parker is a duty-bound yet fun-loving goo¼ all. He’s got little in the way of social skills, but he fi ghts for a righteous cause, and he does it with a smile on his face.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Maria Hill",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Presence),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Maria Hill",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.ForceWorks, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "Having gotten a taste of action on a tour of duty with the US Marine Corps, a young Maria Hill joined up with S.H.I.E.L.D. the moment she was able. Her determination to succeed and her natural ability to make hard decisions propelled her through the ranks of the organization. Within a few years, she became the right hand of S.H.I.E.L.D. director Nick Fury Sr. Soon after, she replaced Fury.",
                    "Although supported by her subordinates, many of Hill’s actions as director of S.H.I.E.L.D. remain controversial. The foundation of Pleasant Hill— an artifi cial-town prison designed to reform super villains through brainwashing—caused an international outcry. For her role in overseeing that project, Hill was booted from S.H.I.E.L.D. The organization itself dissolved shortly thereafter.",
                    "Despite her notoriety, Hill has found a second life as an agent for the CIA. She is wholly committed to the cause of making the world a safer place for regular people."
                ],
                Personality =
                [
                    "Hill’s ability to make tough calls makes her a strong leader, but it’s also her greatest fl aw. Like many members of S.H.I.E.L.D., her knack for working within ethical gray areas gets her in trouble as often as it helps her succeed. If she can be convinced that doing so is for the greater good, Hill can steel herself to commit atrocious deeds.",
                    "Despite her headstrong and driven nature, Hill is not above cracking the occasional joke. Her social circle consists almost entirely of former S.H.I.E.L.D. agents."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Marvel Boy",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
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
                        powerSelector.GetPower(PowerNames.Accuracy2),
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBarrage),
                        powerSelector.GetPower(PowerNames.ElementalBarrier),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                    ],
                    IsTech = true,
                },
            ],
            Biography = new Biography
            {
                RealName = "Noh-Varr",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "White",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Outsider],
                Origins = [OriginName.AlienKree, OriginName.WeirdScience],
                Teams = [TeamNames.GuardiansOfTheGalaxy, TeamNames.WestCoastAvengers, TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "Noh-Varr grew up in an alternate dimension where the Kree became almost incomprehensibly advanced. As a lowly ensign aboard the intergalactic vessel Marvel, he and his crewmates got lost in the Multiverse after sustaining heavy injuries in battle with cosmic gods. While trying to return home, they accidentally sent themselves to Earth-616, where their vessel was shot down by Midas, an ultra-wealthy madman looking to harvest the ship’s cosmic energy drive.",
                    "As the sole survivor of the crash, Noh-Varr vowed to avenge his teammates. With a few simple pieces of Kree tech, he took down both Midas and half of New York, before S.H.I.E.L.D. managed to capture him. After escaping jail, Noh-Varr’s first instinct was to destroy humanity and turn Earth into the center of a new Kree Empire, but the contemporary Kree leadership convinced him that he would be better off protecting the planet and making humans into allies. Believing that the Dark Avengers were a heroic team, Noh-Varr briefly joined their ranks, but left once he discovered the group’s secretly evil nature.",
                    "Since then, Noh-Varr has served in critical roles on many of Earth’s super-teams. He played a particularly large part in the second incarnation of the Young Avengers, where he helped his teammates Wiccan and Hulkling not only save Earth but forge a lasting peace between the Kree and Skrull empires. These days Noh-Varr spends most of his time adventuring across the universe with the Guardians of the Galaxy."
                ],
                Personality =
                [
                    "Noh-Varr lives his life like a twentieth-century rock star: fast and loud. He has a nasty tendency to fall in love with his teammates, only to quickly grow bored of them and move on. In his relatively short time in this dimension, he has dated no fewer than six people, including Hawkeye (Kate Bishop), Moonstone and Hercules.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Master of the World",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 4, vigilance: 2, ego: 4, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in battle suit"),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Discipline1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.MachineTelepathy),
                    ],
                },
            ],
            IconicItems =
            [
                new IconicItem
                {
                    IsBattlesuit = true,
                    Name = "Master of the World's Battle Suit",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrage} (Energy)", powerSelector.GetPower(PowerNames.ElementalBarrage, reminder: "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBarrier} (Energy)", powerSelector.GetPower(PowerNames.ElementalBarrier, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBlast} (Energy)", powerSelector.GetPower(PowerNames.ElementalBlast, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)", powerSelector.GetPower(PowerNames.ElementalBurst, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalPush} (Energy)", powerSelector.GetPower(PowerNames.ElementalPush, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Disguise, powerSelector.GetPower(PowerNames.Disguise)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Flight1, powerSelector.GetPower(PowerNames.Flight1)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Mighty2, powerSelector.GetPower(PowerNames.Mighty2)),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Sturdy2, powerSelector.GetPower(PowerNames.Sturdy2)),
                    ],
                    Restrictions =
                    [
                        "Worn",
                    ],
                    PowerValue = 11,
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Eshu",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [280],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [TeamNames.AlphaStrike, TeamNames.OmegaFlight],
                Base = "Weirdworld",
                History =
                [
                    "Eshu claims to have been born tens of thousands of years ago into a tribe of proto-humans who cast him out into the arctic wastes as punishment for being a bully and a tyrant. The earliest official records for him begin with him being committed to the Ravencroft Institute for the Criminally Insane in 1918.",
                    "Whatever his age, at some point Eshu stumbled upon the wreckage of the alien Plodex ship that brought Alpha Flight member Marrina Smallwood to Earth. The ship’s failing systems merged with Eshu, trapping him inside the vessel and driving him insane. Years later, he regained enough of his sanity to send a signal to lure Smallwood to his location. In the course of pursuing her, Alpha Flight destroyed the ship, allowing Eshu to finally escape.",
                    "Under the codename of the Master, Eshu set out on a lifelong campaign to destroy Alpha Flight and take over the world. More recently, he’s clashed with the Champions.",
                    "While spying on the Champions, Eshu wandered into the mystical dimension of Weirdworld. After conquering the local people, he declared himself the place’s monarch. The Champions drove him from his castle but ultimately failed to capture him."
                ],
                Personality =
                [
                    "Eshu fashions himself as a genius megalomaniacal conqueror in the mode of Doctor Doom or Kang. However, both Doom and Kang consider him to be a joke. He has considerable cunning, but he has never achieved a fraction of their success. He believes that if he can destroy Alpha Flight, the world will finally see him for the threat he is.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Mastermind",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 1, vigilance: 3, ego: 4, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.GrandMirage),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.Brilliance2),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.CloakGroup),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.GrandFool),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Jason Wyngarde",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [140],
                Gender = Gender.Male,
                Eyes = "Gray",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.HellfireClub, TeamNames.XCorp],
                Base = "Krakoa",
                History =
                [
                    "Despite being born with the power to create complex illusions, Jason Wyngarde spent most of his life in obscurity, working as a mentalist at a two-bit carnival. He didn’t understand the true potential of his powers until he was well into his graying years, when Magneto turned up at his carnival booth.",
                    "Magneto offered Wyngarde a founding position in his Brotherhood of Evil Mutants. Enticed by the prospect of worldwide recognition, Wyngarde readily accepted. He took on the codename of Mastermind and spent the next several years assisting Magneto in his battles against the X-Men.",
                    "Ironically, Wyngarde’s greatest victory came after he left the Brotherhood behind. As part of a bid to join the Hellfire Club, Wyngarde corrupted the mind of Jean Grey, turning her into the world-shattering Dark Phoenix. Jean eventually defeated Wyngarde, but his temporary victory left lasting scars, both on her and on the universe at large.",
                    "Wyngarde tried, desperately and repeatedly, to recreate his one great victory, only to end up getting himself killed. He was revived recently as part of Krakoa’s resurrection protocols, and despite the hopes of the mutant nation’s leaders, he quickly returned to his villainous ways."
                ],
                Personality =
                [
                    "Wyngarde is a hateful and manipulative old man. He hates the world for failing to recognize him, he hates the X-Men for defeating him, but most of all, he hates himself. He hates that he can’t recreate the success of his past, and that with each failing attempt, his body continues to grow older. These days he spends most of his time cloaked in an illusion that makes him look far younger.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Maximus",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 3, ego: 3, logic: 6
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Hunted),
                tagSelector.GetTag(TagNames.InhumanGenes),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Maximus Boltagon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.KreeImperium, TeamNames.LeagueOfEvilInhumans],
                Base = "New Arctilan",
                History =
                [
                    "A powerful psychic, Maximus was born the second son of the Inhuman royal family, preceded in the line of succession only by his brother, the hero Black Bolt. From a young age, Maximus came to resent his brother, repeatedly attempting to get the young Black Bolt into trouble, but it was only after Black Bolt ascended to the throne that Maximus went truly mad.",
                    "Determined to kill his brother and ascend to the position of Inhuman King, Maximus has launched coup attempt after coup attempt against Black Bolt. In recent years, Maximus has shown the ability to work with his fellow Inhumans, but his motivations are always suspect and can change at any moment.",
                ],
                Personality =
                [
                    "Maximus’ strongest desire has always been to take over as ruler of the Inhumans and make his brother suffer. How much of this is motivated by madness and how much by self-interest is hard to discern.",
                ]
            }
        },
        new()
        {
            Name = "May Parker",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 0, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.OutOfShape),
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
            ],
            Biography = new Biography
            {
                RealName = "Maybelle “May” Parker-Jameson",
                Heights = [new() { Feet = 5, Inches = 5 }],
                Weights = [110],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [],
                Origins = [],
                Teams = ["Howard T. Duck Private Investigations, Uncle Ben Foundation"],
                Base = "New York City",
                History =
                [
                    "May Parker’s early life was, for the most part, unremarkable. She was born into a poor and religious family that placed a high value on decency and responsibility. As an adult, she began dating a carnival barker named Ben Parker.",
                    "Ben was just as poor as May, if not more so, but he was kind and thoughtful. May valued that more than any riches in the world. Unable to have children themselves, Ben and May devoted their energies toward helping out with their nephew, Peter Parker.",
                    "After Peter’s parents died in a tragic plane crash, he came to live with his aunt and uncle full-time. Ben and May treated Peter like their own son, which only made it all the more di¸ cult for the boy when, a few short years later, Ben was gunned down in a robbery.",
                    "Ben’s tragic death inspired Peter to become the world-renowned super hero Spider-Man. For many years Peter hid this fact from his aunt, but May eventually discovered her nephew’s secret identity. Although she was wary at fi rst, May has come to accept who Peter is and even appreciate his heroics.",
                    "At one point, she married J. Jonah Jameson’s father, Jay, but he has since passed away."
                ],
                Personality =
                [
                    "Although she’s getting up there in years, May Parker believes she can still take care of herself. She is a proud woman, and she resents the idea that she would need help with basic tasks. However, her increasingly ailing state has forced her, bit by bit, to accept more and more assistance.",
                    "May’s greatest fear is that she will become a burden on Peter, the one person on Earth who she cares the most about."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Medusa",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 6, resilience: 3, vigilance: 3, ego: 2, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.InhumanGenes),
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
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy3),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = $"{PowerSetNames.Plasticity}",
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach1, reminder: "Reach 4"),
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
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Medusalith Amaquelin-Boltagon",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Average,
                DistinguishingFeatures = "Long, freely controllable hair",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.FantasticFour, TeamNames.HouseOfAgon, TeamNames.UniversalInhumans],
                Base = "Mobile",
                History =
                [
                    "Medusalith Amaquelin was born in the Inhuman city of Attilan into a family of royal nutritionists. As an infant, she was exposed to the Terrigen Mist and subsequently gained the power to control strands of her hair as if they were superstrong tendrils emerging from her head.",
                    "At a young age, Medusa developed close friendships with core members of the Inhuman Royal Family, particularly her second cousin, the Inhuman prince Black Bolt. Medusa later helped Black Bolt overthrow the cruel rulers of Attilan and establish himself as the king of all Inhumans.",
                    "As the years drew on, Medusa and Black Bolt grew closer and were married. Together, they’ve had one child, a boy named Ahura.",
                    "Following the tragic events wherein Black Bolt was forced to kill the bulk of the Inhuman population, Medusa and her husband began to grow apart. Although they remain close friends, they have functionally separated."
                ],
                Personality =
                [
                    "Medusa has exactly the personality one would expect of a powerful queen. She is headstrong, righteously vindictive and often a bit pompous. Her self-confi dence makes her an effective ruler and team leader, though in more interpersonal settings it can cause troubles.",
                    "Even more than Black Bolt, Medusa takes her role as an Inhuman leader with deadly seriousness. She is determined to live up to the title of queen, no matter the personal cost."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Melinda May",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 1, vigilance: 2, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.Leverage),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CounterstrikeTechnique),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Melinda May",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.FBI, TeamNames.SHIELD],
                Base = "Mobile",
                History =
                [
                    "As a skilled combatant and strategist, Melinda May was one of the best agents S.H.I.E.L.D. ever had. She came to be known as “The Cavalry.” In the years immediately prior to the organization’s dissolution, she worked closely with S.H.I.E.L.D. legends like Maria Hill and Phil Coulson, providing invaluable assistance to super-teams like the Avengers.",
                    "Despite having no super-powers, May helped to save the world countless times. Although she was left more than a little adrift when S.H.I.E.L.D. fell apart, she eventually took a position with the F.B.I.—but the Bureau isn’t nearly as exciting. Ironically, her position with Stark Unlimited’s board of directors has provided her with far more thrills lately than her actual law-enforcement job.",
                ],
                Personality =
                [
                    "May is a woman of few words. She rarely talks about her personal life and has never discussed her past or her combat record with any of her colleagues. She gets in, she does the job and she gets out. A pure professional.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Mettle",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 1, resilience: 3, vigilance: 3, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Ken Mack"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Mettle form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain Marvel (Carol Danvers)"),
                tagSelector.GetTag(TagNames.Mysterious),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Inspiration),
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
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Ken Mack",
                Heights = [new() { Feet = 6, Inches = 2 }, new() { Feet = 6, Inches = 3 }],
                Weights = [206,468],
                Gender = Gender.Male,
                Eyes = "Brown/red",
                Hair = "Black/none",
                Size = Size.Big,
                DistinguishingFeatures = "Red iridium alternate form",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Unknown],
                Teams = [TeamNames.AvengersAcademy],
                Base = "Avengers Academy",
                History =
                [
                    "Ken Mack was just a regular Hawaiian teenager until the day he took a speeding surfboard to the head. The blow should have killed him, but instead it peeled the skin off his face to reveal a layer of hard red iridium just beneath the surface.",
                    "As part of a plan to foment the next generation of super villains, the Green Goblin (Norman Osborn) captured Mack—along with several other young people with burgeoning powers—and subjected them to brutal experiments. Mack’s treatment was perhaps the worst, with Osborn painstakingly stripping the remainder of his skin from his body, leaving him in his iridium form.",
                    "The Avengers later freed the super-powered teens from Osborn’s clutches and, hoping to ensure that they would never become villains, enrolled the kids in a new training program: Avengers Academy.",
                    "As Mettle, not only did Mack prove himself to be one of the most valuable and genuinely heroic members of the freshman class, but he also earned the love and affection of his teammate, Hazmat. Unfortunately, their relationship was cut short when most of the class was kidnapped by Arcade and forced to fight one another to the death.",
                    "Because Mettle refused to abide by the rules of this death game, Arcade seemingly annihilated him—while actually selling him off as food to the psychic vampire Emplate. This ordeal somehow restored Mettle’s skin, allowing him to freely transform into his human form and back. Years later, the students of the second Avengers Academy rescued him from Emplate and Carol made him a new resident advisor for the class, conveniently returning him to Hazmat’s side."
                ],
                Personality =
                [
                    "All Mack ever wanted was to chill on the beach and live the good life, but fate forced him down another path. Thankfully, his big heart makes him a natural hero.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Mirage (Dani Moonstar)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 3, ego: 1, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "Grand Mirage"),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Brightwind"),
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Mammals"),
                        powerSelector.GetPower(PowerNames.ESP),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.MindInterrogation),
                        powerSelector.GetPower(PowerNames.MindReading),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Danielle “Dani” Moonstar",
                Heights = [new() { Feet = 5, Inches = 6 }],
                Weights = [123],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.NewMutants, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "As a teenager, Dani Moonstar discovered she had the ability to create powerful psychic illusions. When those illusions began to attack those closest to her, her grandfather—the shaman Black Eagle—asked Charles Xavier (Professor X) to train her in the use of her powers. Before Xavier could arrive, Black Eagle was assassinated by a madman bent on destroying mutantkind. As part of Xavier’s brand-new New Mutants team, Moonstar helped put an end to that madman’s plans.",
                    "For a while, Moonstar served as one of Asgard’s Valkyries, but today she lives on Krakoa, where she has joined a revived New Mutants team. She uses her powers to help other mutants process their trauma. Despite no longer being a Valkyrie, she still retains her bond with her Asgardian winged horse, Brightwind.",
                ],
                Personality =
                [
                    "Moonstar is a powerful and serious combatant, not the type to joke around during a mission. Away from battle, she is a highly intelligent and empathetic person. Her psychic abilities allow her to literally dig into the emotional problems of her teammates.",
                ]
            }
        },
        new()
        {
            Name = "Misery",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 6, resilience: 3, vigilance: 4, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics"),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Celebrities"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.Dependents, reminder: "Normie Osborn, Stanley Osborn"),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Rich),
                tagSelector.GetTag(TagNames.SecretIdentity),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AdditionalLimbs),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
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
                RealName = "Elizabeth “Liz” Allan",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Misery form has retractable claws, fangs and sharp tendrils",
                Occupations = [OccupationName.Tycoon],
                Origins = [OriginName.SymbioteVenom],
                Teams = [TeamNames.Alchemax],
                Base = "New York City",
                History =
                [
                    "Although she dated both Peter Parker and Flash Thompson in her high school years, Liz Allan wouldn’t fi nd her true love until years later, when she met Harry Osborn at a friend’s wedding. The pair had a whirlwind romance and, soon enough, they were wed. They had a child named Normie and a happy home life, but their bliss didn’t last long. Harry’s body gave out after he injected himself with a modifi ed version of his father’s Green Goblin formula, and though Allan enjoyed the married life again with a clone of her deceased husband, that clone died under similar circumstances.",
                    "Allan took over her husband’s stake in Alchemax, and after realizing the healing potential of symbiotes, she spearheaded the company’s new research division for studying the alien creatures. During an assault on Alchemax headquarters, one of these symbiotes—a gestalt creature made from pieces of the Anti-Venom and Carnage symbiotes—broke containment and bonded with Allan.",
                    "With the power of her symbiote, Allan now protects both her company and her family under the codename Misery. For the moment, she remains unaware of the fact that her son Normie has become a symbiote-powered hero himself, known as the Red Goblin.",
                ],
                Personality =
                [
                    "Allan spent much of her youth letting other people make her decisions for her, but her symbiote has helped her to take a more assertive stance in her life. The modern Liz Allan is a brilliant businesswoman and dedicated guardian of two kids, namely Normie and his half brother, Stanley. She’s a friendly person on good terms with just about everyone in her life, including Stanley’s mother, the Queen Cat (Lily Hollister).",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Mister Fantastic",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 2, ego: 2, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Enemy, specialization: "Doctor Doom"),
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
                        powerSelector.GetPower(PowerNames.Brilliance4),
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BodySphere),
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.FlexibleFingers),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.Rubberneck),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Reed Richards",
                Heights = [new() { Feet = 6, Inches = 1 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown, gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.FantasticFour, TeamNames.FutureFoundation],
                Base = "New York City",
                History =
                [
                    "Brilliant young physicist Reed Richards gambled his family’s considerable fortune on an experimental space mission, during which he and his crew were bombarded by cosmic rays, giving them super-powers. Back on Earth, with Richards as their leader, the crew formed the Fantastic Four.",
                    "Richards’ intellect is just as critical a component of his heroism as his powers. With eighteen separate doctorates, he is arguably the most brilliant scientist on the planet. Richards later married one of the crew—Susan Storm (Invisible Woman)— with whom he has two kids, and nothing is more important to him than his family and friends.",
                ],
                Personality =
                [
                    "Richards’ intense and calculating nature occasionally puts him at odds with his more outwardly emotional teammates, but at heart, he is a humanitarian. He believes that science has the potential to solve all of humanity’s problems, and nothing frustrates him more than an unsolvable problem.",
                ]
            },
            Source = BookSource.FantasticFourFromTheDepths
        },
        new()
        {
            Name = "Mister Negative",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 2, vigilance: 4, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.Backup, reminder: "Inner Demons"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Healing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CureAll),
                        powerSelector.GetPower(PowerNames.HealingHands),
                        powerSelector.GetPower(PowerNames.LetsGo),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.LegSweep),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.ChangeOfPlans),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.CorruptingTouch)
            ],
            Biography = new Biography
            {
                RealName = "Unknown, but often uses alias of Martin Li",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [180],
                Gender = Gender.Male,
                Eyes = "Brown, white (in alternate form)",
                Hair = "Black, white (in alternate form)",
                Size = Size.Average,
                DistinguishingFeatures = "Body and clothes appear photonegative (in alternate form)",
                Occupations = [OccupationName.Criminal],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.InnerDemons, TeamNames.Triads],
                Base = "New York City",
                History =
                [
                    "Years ago, Maggia goons kidnapped dozens of people—mostly homeless teens—off the streets of New York to use as lab rats for an experimental new narcotic. Nearly everyone who took the drug died within minutes.",
                    "Two of the survivors are well known. The drug gave Tyrone Johnson and Tandy Bowen control over the forces of dark and light, respectively, turning them into the super-hero duo of Cloak and Dagger.",
                    "Though few knew it, there was a third survivor: an up-and-coming Triad grunt captured by rivals in the Maggia. This survivor gained control over both light and dark, powers that split his mind in twain.",
                    "One half of him became Martin Li, a respectable philanthropist, healer and family man. The other half became Mister Negative, a super-powered Triad commander who corrupts all he touches.",
                    "Spider-Man (Peter Parker) first encountered him as Li, the founder and head of the F.E.A.S.T. charity center where Parker’s Aunt May volunteered. However, after a long investigation, Spider-Man uncovered Li’s alter ego and revealed it to the world.",
                    "Li has been on the run from the authorities ever since, lying low in Shanghai and popping back into New York City for major events, such as the massive gang war that recently consumed much of the city."
                ],
                Personality =
                [
                    "Mister Negative delights in corrupting others, agitating their base impulses and forcing them to confront the darkness lurking within their psyches. Martin Li, on the other hand, wants only to help people, but life as an outlaw has forced him to make a series of increasingly dire compromises with his negative half.",
                ],
                BiographySections =
                [
                    new()
                    {
                        Name = "Alternate Form",
                        Description =
                        [
                            "Mr. Negative’s forms affect his access to his powers. He can use his Healing powers only in Martin Li form, and his Corrupting Touch power can be used only by his Mr. Negative form."
                        ],
                    }
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Mister Sinister",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 3, vigilance: 5, ego: 4, logic: 8
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.EnduringConstitution),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.MutantAssociate),
                tagSelector.GetTag(TagNames.PublicIdentity),
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
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
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
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticBarrier),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                        powerSelector.GetPower(PowerNames.TelekineticProtection1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Cloak),
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Fool),
                        powerSelector.GetPower(PowerNames.GrandMirage),
                        powerSelector.GetPower(PowerNames.MemoryBlip),
                        powerSelector.GetPower(PowerNames.Mirage),
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                        powerSelector.GetPower(PowerNames.TelepathicNetwork),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Nathaniel Essex",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [285],
                Gender = Gender.Male,
                Eyes = "Varies, usually red",
                Hair = "Varies, usually black",
                Size = Size.Average,
                DistinguishingFeatures = "Pale, almost vampiric appearance, with a red diamond on his forehead",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.MutantArtificial],
                Teams = [TeamNames.Hellions, TeamNames.Marauders, TeamNames.QuietCouncilOfKrakoa],
                Base = "Krakoa",
                History =
                [
                    "For better and for worse, Victorian scientist Nathaniel Essex was unimaginably ahead of his time. He not only predicted the imminent and widespread emergence of mutants in mainstream society, but he also managed to implant himself with a powerful form of the X-Gene.",
                    "Unfortunately, these scientific successes went straight to his head. Essex quickly became convinced that he was the most important person in existence and that his sole mission in life should be to spread his own influence across the cosmos. To that end, he created dozens of clones of himself and imbued them each with a single principle: survival of the fittest—last clone standing is the winner.",
                    "Although the original Essex likely died ages ago, his clones have carried on, fighting both one another and the world at large in an unending quest to spread the influence of Essex.",
                    "A number of variations of Essex exist, but the most common clones have a red diamond on their foreheads and call themselves Mister Sinister. Collectively, these Sinisters have had a profound impact on the development of Earth-616 and its mutants. Sinister’s dark influence can be traced back to the creation of numerous important adventurers (such as Madelyne Pryor) and to the foundation and subsequent destruction of the mutant government on Krakoa."
                ],
                Personality =
                [
                    "The Sinisters are, one and all, insane megalomaniacs. They are perfectly capable of being polite—even charming—in social situations, but deep down, they hate everyone. They want nothing more than to rid the universe of everything outside of themselves. The rest of existence either has to go away or must become Sinister.",
                ]
            },
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = "Misty Knight",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 3, resilience: 3, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
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
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
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
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.BraceForImpact),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Mercedes “Misty” Knight",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [136],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Bionic arm",
                Occupations = [OccupationName.Investigator, OccupationName.LawEnforcer],
                Origins = [OriginName.HighTechCybernetics, OriginName.SpecialTraining],
                Teams = [TeamNames.AberrantCrimesDivisionOfTheFBI, TeamNames.DaughtersOfTheDragon, TeamNames.Defenders],
                Base = "Mobile",
                History =
                [
                    "Misty Knight was a talented rookie in the NYPD bomb squad—until the day her arm got blown off in the line of duty. Admiring the young woman’s heroism, billionaire Tony Stark personally commissioned a bionic arm to replace Knight’s lost limb.",
                    "Newly empowered, Knight quit her job with the NYPD and started a private detective agency called Nightwing Restorations. Her adventures as a private investigator have frequently brought her into the orbit of other heroes for hire, particularly Colleen Wing, Luke Cage and her longtime fl ame Danny Rand (Iron Fist)."
                ],
                Personality =
                [
                    "Although charming and coolheaded, Knight’s steadfast belief in the righteousness of the law sometimes leads her astray. She has little patience for those she believes to be criminals—and perhaps too much patience for those who claim to support the law. On more than one occasion, she’s hung up the title of P.I. to return to a career as a law enforcement officer.",
                ]
            }
        },
        new()
        {
            Name = "M.O.D.O.K.",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 0, agility: 2, resilience: 2, vigilance: 4, ego: 5, logic: 7
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.TechReliance),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
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
                        powerSelector.GetPower(PowerNames.Uncanny2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telekinesis,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelekineticAttack),
                        powerSelector.GetPower(PowerNames.TelekineticBarrier),
                        powerSelector.GetPower(PowerNames.TelekineticGrab),
                        powerSelector.GetPower(PowerNames.TelekineticManipulation),
                        powerSelector.GetPower(PowerNames.TelekineticProtection2),
                        powerSelector.GetPower(PowerNames.TelekineticSphere),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.Orders),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                }
            ],
            IconicItems =
            [
                new IconicItem
                {
                    IsBattlesuit = true,
                    Name = "M.O.D.O.K.'s Battle Suit",
                    Powers =
                    [
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBlast} (Energy)", powerSelector.GetPower(PowerNames.ElementalBlast, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower($"{PowerNames.ElementalBurst} (Energy)", powerSelector.GetPower(PowerNames.ElementalBurst, reminder : "Energy")),
                        iconicItemPowerSelector.GetPowersAsIconicItemPower(PowerNames.Flight1, powerSelector.GetPower(PowerNames.Flight1)),
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
                RealName = "George Tarleton",
                Heights = [new() { Feet = 12 }],
                Weights = [750],
                Gender = Gender.Male,
                Eyes = "White",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Massive cranium",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.HighTechBattleSuit, OriginName.WeirdScience],
                Teams = [TeamNames.AIM, TeamNames.Intelligencia],
                Base = "Mobile",
                History =
                [
                    "A low-level lab technician at Advanced Idea Mechanics, George Tarleton was forced by his superiors to undergo a dangerous mutagenic experiment so they could create a being intelligent enough to study the newly fashioned Cosmic Cube. To that end, A.I.M. scientists radically enlarged George’s head and placed his now-frail body into a weaponized hover chair.",
                    "The mutated George immediately turned on and slaughtered his superiors. Dubbing himself M.O.D.O.K. (Mental Organism Designed Only for Killing), Tarleton took control of A.I.M. and set the organization to the task of sowing chaos everywhere."
                ],
                Personality =
                [
                    "Although a frequent ally of Hydra and the Red Skull, M.O.D.O.K.’s evil is born more out of madness and egomania than any political agenda. He only really enjoys himself while engaging in or plotting mass murder. On the rare occasions he isn’t killing, M.O.D.O.K. wears a perpetual sneer upon his face.",
                ]
            }
        },
        new()
        {
            Name = "Mockingbird (Bobbi Morse)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 0, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Fighting batons (clubs)"),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Mighty1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.DoThisAllDay),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
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
                RealName = "Barbara “Bobbi” Morse",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Scientist],
                Origins = [OriginName.SpecialTraining, OriginName.WeirdScience],
                Teams = [TeamNames.Avengers, TeamNames.SHIELD, TeamNames.WestCoastAvengers],
                Base = "Mobile",
                History =
                [
                    "As a young but up-and-coming name in the world of biological science, Bobbi Morse was recruited by S.H.I.E.L.D. to act both as an agent and an on-staff scientist. Under the codename Mockingbird, she fought to keep the world safe from all manners of nefarious threats.",
                    "Morse eventually left S.H.I.E.L.D. to become an independent adventurer. In the years since, she has been an invaluable member of countless super-hero teams. Most famously, she has been a regular partner to the hero Hawkeye, to whom she was briefl y married.",
                    "For a long while, she was thought to be dead, killed by Mephisto while she was on a mission with the West Coast Avengers. It turned out that she had been kidnapped and replaced with a Skrull impersonator who had died in her place."
                ],
                Personality =
                [
                    "Much like her ex-husband, Hawkeye (Clint Barton), years of adventuring have tempered Morse’s attitude toward danger. Threats that would have terrifi ed her in her early days now elicit little more than an eye roll or a pained groan from her. Her years terrorizing the Skrulls as the Robed Witch—while temporarily escaped on their home planet—contributed to that.",
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Moira MacTaggert",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 1, vigilance: 1, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Community"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
            ],
            NarrativePowers =
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.Restart)
            ],
            Biography = new Biography
            {
                RealName = "Moira Ann Kinross MacTaggert",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [135],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.Educator],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.Orchis, TeamNames.XMen],
                Base = "Mobile",
                History =
                [
                    "When she was 13 years old, Moira MacTaggert gained the mutant power of reincarnation. The moment she dies, she returns to the start of her life, with her memories of her previous lives intact. MacTaggert spent her first life blissfully unaware of her powers, but once she realized what was happening, she spent her next eight lives playing mutants and machine life-forms, like Sentinels, off each other, searching for a future where she could live in peace.",
                    "Finally, in her tenth life, MacTaggert came up with the idea for a mutant nation on the island of Krakoa. She sought out Professor X and spent the next several years working with him, all the while manipulating events and individuals to prepare the way for Krakoa. To maintain secrecy, she eventually faked her death and went into hiding, revealing the truth to only a handful of mutant leaders.",
                    "MacTaggert’s role in Krakoa’s foundation did not become widely known until over a year later, when Destiny and Mystique dragged her out of hiding and forcibly depowered her. Having lost faith in Krakoa’s future, Moira switched sides. She uploaded her mind to a cybernetic body and began working to destroy Krakoa instead."
                ],
                Personality =
                [
                    "The weight of so many tragic lifetimes has made Moira MacTaggert cold. She no longer cares about mutants or machines. She just wants a world where she can live without interference.",
                    "Although she had a few romantic relationships in her tenth life, they never lasted. She learned long ago to maintain no strong attachments. Even her son, Proteus, has not seen her in some time."
                ]
            },
            Source = BookSource.XMenExpansion
        },
		new()
		{
			Name = "Mojo",
			Rank = 4,
			Abilities = new Abilities
			(
				melee: 2, agility: 1, resilience: 5, vigilance: 3, ego: 5, logic: 4
			),
			Traits =
			[
				traitSelector.GetTrait(TraitNames.Abrasive),
				traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
				traitSelector.GetTrait(TraitNames.ExtraOccupation),
				traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
				traitSelector.GetTrait(TraitNames.Famous),
				traitSelector.GetTrait(TraitNames.Presence),
				traitSelector.GetTrait(TraitNames.PublicSpeaking),
				traitSelector.GetTrait(TraitNames.TechReliance),
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
						powerSelector.GetPower(PowerNames.AdditionalLimbs, isTech: true),
						powerSelector.GetPower(PowerNames.Uncanny2),
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
					Name = PowerSetNames.Illusion,
					Powers =
					[
						powerSelector.GetPower(PowerNames.AnimatedIllusion),
						powerSelector.GetPower(PowerNames.GrandIllusion),
						powerSelector.GetPower(PowerNames.Illumination),
						powerSelector.GetPower(PowerNames.StaticIllusion),
					],
					IsTech = true
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.PowerControl,
					Powers =
					[
						powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Media Popularity"),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.SpiderPowers,
					Powers =
					[
						powerSelector.GetPower(PowerNames.Wallcrawling),
					],
                    IsTech = true
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
						powerSelector.GetPower(PowerNames.MachineTelepathy ,isTech: true),
						powerSelector.GetPower(PowerNames.TelepathicBlast),
						powerSelector.GetPower(PowerNames.TelepathicLink),
					],
				},
			],
			Biography = new Biography
			{
				RealName = "Mojo",
				Heights = [new() { Feet = 6, Inches = 9 }],
				Weights = [512],
				Gender = Gender.Male,
				Eyes = "Yellow eyes with orange irises and black pupils",
				Hair = "Cords resembling hair attached to head",
				Size = Size.Big,
				DistinguishingFeatures = "Bright yellow skin, twisted smile, spiderlike cybernetic legs, slender four-fingered hands",
				Occupations = [OccupationName.Entertainer, OccupationName.Leader],
				Origins = [OriginName.Alien, OriginName.HighTechCybernetics],
				Teams = [],
				Base = "Mojoworld",
				History =
				[
					"Mojo is one of a number of monstrous Spineless Ones, beings who inhabit the Mojoverse, a dimension outside regular time and space. As the supreme leader of Mojoworld, Mojo rules over a race of genetically engineered slaves. For untold years, he abused these slaves for his own amusement, forcing them into dire, life-or-death situations and filming the results for use in a series of sick and twisted TV shows.",
					"Then Longshot, one of Mojo’s slaves, rose up and rebelled against the Spineless Ones. Faced with overwhelming opposition from Mojo and his lackeys, Longshot fled to Earth-616, where he joined forces with the X-Men.",
					"Intrigued by the mutants and enticed by the prospect of making them into a spectacle, Mojo began to include the X-Men in his sadistic schemes. Over the years, he has captured Longshot and his mutant allies dozens of times and forced them to participate in one of his depraved television programs. Each time, they eventually found a way to escape.",
					"Although Mojo has, at times, been temporarily deposed, he has always managed to return to power and set rebel plans back to square one."
				],
				Personality =
				[
					"The term narcissist does not even begin to scratch the surface of Mojo’s self-absorbed insanity. He not only believes himself to be the center of the universe—he believes he is the only being of any value whatsoever across all of existence. He has a nasty habit of engraving his face onto other people and places, only to destroy them the moment he decides they are unworthy of his visage.",
				]
			},
			Source = BookSource.XMenExpansion
		},
        new()
        {
            Name = "Mole Man",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 0, resilience: 2, vigilance: 5, ego: -3, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.OutOfShape),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Subterranea"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.VisionIssues),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                        powerSelector.GetPower(PowerNames.IconicItem, specialization: "Staff (Mole Man’s staff acts as a remote control for the many Deviant technologies available to him in his Subterranean lair, as long as they have been prepared ahead of time.)"),
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
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Harvey Elder",
                Heights = [new() { Feet = 4, Inches = 10 }],
                Weights = [165],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Gray",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "Subterranea",
                History =
                [
                    "Despite his genius, Harvey Elder was shunned by society for his homely appearance. Desperate to find his place in the world, he searched far and wide, following rumors of an underground civilization that would accept him. He eventually stumbled upon Monster Island and explored the caverns beneath until finally discovering a tunnel into Subterranea. Despite being caught in an earthquake and blinded by the mystic Valley of Diamonds, he found abandoned Deviant technology and used it to lead many monsters and the underground race of Moloids.",
                    "Carving out his own domain, Elder became obsessed with getting revenge on the surface world, but the Fantastic Four thwarted his first attempts. Over the years, other Subterranean leaders like Tyrannus have threatened Elder’s dominance. The Mole Man now stands in an uneasy truce with the surface world he resents, but he is all too willing to attack any who endanger his world.",
                ],
                Personality =
                [
                    "Harvey Elder is deeply insecure about his looks and his stature and tries to make up for it with the power he now possesses. While this makes him angry and even unhinged most of the time, he can be kind and even helpful to those who others would deem monstrous— including the many giant beasts he lives with underground.",
                ]
            },
            Source = BookSource.FantasticFourFromTheDepths
        },
        new()
        {
            Name = "Moloids (Group)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 5, vigilance: 2, ego: 0, logic: -1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Clueless),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Stranger),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Headquarters, specialization: "Subterranea"),
                tagSelector.GetTag(TagNames.VisionIssues),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.HeightenedSenses2),
                    ],
                },
            ],
            IsHenchman = true,
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Moon Girl",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 1, resilience: 0, vigilance: 2, ego: 2, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.Brilliance3}"),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.InhumanGenes),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Devil Dinosaur"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "School"),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.VisionIssues),
                tagSelector.GetTag(TagNames.Young),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Brilliance3),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalBond, reminder: "Devil Dinosaur"),
                        powerSelector.GetPower(PowerNames.BorrowSenses),
                        powerSelector.GetPower(PowerNames.InformationUpload),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Lunella Louise Lafayette",
                Heights = [new() { Feet = 3, Inches = 9 }],
                Weights = [48],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Small,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Scientist, OccupationName.Student],
                Origins = [OriginName.Inhuman],
                Teams = [],
                Base = "New York City",
                History =
                [
                    "As a hyper-intelligent grade-schooler, Lunella Lafayette faced ridicule from her fellow students and even her teachers, all of whom were unable to comprehend the depths of her brilliance. Her life dragged on in a boring sort of way until the day she accidentally activated a portal to an alternate dimension.",
                    "From this portal emerged Devil Dinosaur, a highly intelligent red Tyrannosaurus rex. Lafayette and the dinosaur became fast friends and agreed to adventure together. Determined to explore the universe, Lafayette adopted the alter ego Moon Girl, reclaiming a name once thrown at her by schoolyard bullies."
                ],
                Personality =
                [
                    "Lafayette is a fun-loving kid with a strong sense of justice. She loves exploration and experimentation as much as she hates bullies. Lafayette will go far out of her way to stop people from pushing others around. The only bullies she has trouble standing up to are her own.",
                ]
            }
        },
        new()
        {
            Name = "Moon Knight",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 4, agility: 5, resilience: 3, vigilance: 2, ego: 2, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Police"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.IronWill),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Allspeak),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Poor),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Crescent-Darts (knife or thrown knife)"),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Truncheon (club)"),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Uncanny1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.ChainStrikes),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsBlunt,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Exploit),
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
                }
            ],
            Biography = new Biography
            {
                RealName = "Marc Spector",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Investigator, OccupationName.Military],
                Origins = [OriginName.Mythic],
                Teams = [TeamNames.Defenders, TeamNames.MidnightMission, TeamNames.MidnightSons],
                Base = "New York City",
                History =
                [
                    "Brutally beaten by his superiors for attempting to save the life of an innocent young woman, mercenary Marc Spector was left for dead in the Egyptian desert. Unconscious, Spector’s spirit was visited by Khonshu, the ancient Egyptian god of the moon, who struck a deal with the dying man. In exchange for entering into the lunar deity’s benevolent service, Khonshu saved Spector’s life and granted him divine powers. Donning a white costume, Spector declared himself Moon Knight and set out on a quest to make up for his muddled past as a mercenary.",
                ],
                Personality =
                [
                    "On account of being partially possessed by a god, Spector suffers from a condition similar to dissociative identity disorder. His main alter egos are cabbie Jake Lockley and fi nancier Steven Grant. While Spector is a decent guy who regrets his life as a mercenary and wishes to atone for his actions, he is sometimes motivated—at least partially by Khonshu (or the version of Khonshu in his head)—to use extreme methods as Moon Knight.",
                ]
            }
        },
        new()
        {
            Name = "Moonstone",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 4, resilience: 3, vigilance: 4, ego: 4, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Clinician),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FirstAid),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Convict),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.Sturdy1),
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
                    Name = PowerSetNames.Phasing,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.PhaseOther),
                        powerSelector.GetPower(PowerNames.PhaseSelf),
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
                }
            ],
            Biography = new Biography
            {
                RealName = "Karla Sofen",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [130],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Big,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Adventurer, OccupationName.HealthCareWorker],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.LethalLegion, TeamNames.MastersOfEvil, TeamNames.Thunderbolts],
                Base = "Mobile",
                History =
                [
                    "As the former psychiatric assistant to the sinister Doctor Faustus (Johann Fennhoff), Karla Sofen has spent much of her life working in mental health institutions. While outwardly a fairly successful psychiatrist, Sofen was a deeply power-hungry person who secretly tormented her patients for her benefit and amusement.",
                    "Adrift following the imprisonment of her former mentor, Sofen sought power of her own. To that end, she maneuvered her way into working with the super villain Moonstone (Lloyd Bloch), whom she tormented into giving up the strange cosmic stone that granted him his powers. Taking the stone for herself, Sofen became the new Moonstone.",
                    "Sofen has served on several super-villain teams throughout her career under several different identities, often mimicking Carol Danvers. Sofen notably took the mantle of Captain Marvel for Norman Osborn’s Dark Avengers and has served with several iterations of the Thunderbolts.",
                ],
                Personality =
                [
                    "Although Sofen has from time to time been on the right side of the law, she is seldom known to have been on the right side of history. A sociopath and expert manipulator, she is a deeply amoral person who craves power and is as fearsome with her words as her fists. You can’t trust anything that comes out of her mouth, but you can always bet on her to betray you when it serves her agenda.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Morbius",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 3, resilience: 3, vigilance: 1, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Monster),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Flight1),
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
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.CrushingGrip),
                        powerSelector.GetPower(PowerNames.QuickToss),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Command),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Michael Morbius",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [170],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Pale skin, fangs, retractable claws",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.MidnightSons, TeamNames.LegionOfMonsters],
                Base = "Mobile",
                History =
                [
                    "In a desperate bid to save himself from a terminal blood condition, Dr. Michael Morbius subjected himself to an experimental treatment using vampire bat DNA. The treatment saved Morbius’ life but transformed him into a hideous vampire. Horrified by his insatiable lust for blood, Morbius attempted to throw himself into the sea only to discover that his new form was seemingly unkillable. Forced to live, Morbius embarked on a blood-fueled rampage across New York.",
                    "In the years since, Morbius has found temporary cures for his condition, but he lives in constant fear of reverting into a bloodsucking monster.",
                ],
                Personality =
                [
                    "Highly eloquent and intelligent, Morbius still cares for those he left behind in his human life. In his more lucid moments, he does his best to redirect his feeding instincts toward violent criminals, particularly those who would do his loved ones harm.",
                ]
            }
        },
        new()
        {
            Name = "Morlun",
            Rank = 5,
            Abilities = new Abilities
            (
                melee: 7, agility: 5, resilience: 6, vigilance: 5, ego: 2, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.ExtremeAppearance),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Mighty3),
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
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BlazingFastFists),
                        powerSelector.GetPower(PowerNames.CatchBullets),
                        powerSelector.GetPower(PowerNames.LightningActions),
                        powerSelector.GetPower(PowerNames.SpeedRun2),
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
                    ],
                },
            ],
            PowerNotes =
            [
                "When Morlun uses Leech Life on an avatar of the Spider-Totem, he recovers the full amount of the damage dealt as Health. On a Fantastic success, he recovers twice that amount."
            ],
            Biography = new Biography
            {
                RealName = "Morlun",
                Heights = [new() { Feet = 6, Inches = 2 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Vampiric appearance, with fangs and red irises",
                Occupations = [OccupationName.Outsider],
                Origins = [OriginName.Magic],
                Teams = [TeamNames.Inheritors, TeamNames.SpiderArmy],
                Base = "Mobile",
                History =
                [
                    "Morlun is a member of the Inheritors, a family of vampiric predators who operated out of Loomworld (Earth-001). As the avatars of the Leech Totem, they feed o\u0084 the essences of other animal totems, particularly the Spider-Totem, which they consider the most delicious.",
                    "For untold eons, the Inheritors operated virtually uncontested, devouring the totems of countless worlds without incurring so much as a scratch. Then, one day, Morlun came to Earth-616.",
                    "With help from a Spider-Totem avatar named Ezekiel Sims, Spider-Man (Peter Parker) just barely managed to outsmart and kill Morlun. The Inheritors tried resurrecting Morlun and sending him back to Earth-616, but again and again, Spider-Man found a way to defeat the monster.",
                    "Frustrated and humiliated, the Inheritors went to war with Earth-616. To combat them, Spider- Man gathered a small army of Spider-Totems from across the Multiverse, kicking o\u0084 the fi rst Spider-Verse crisis.",
                    "All of the Inheritors, save for Morlun, were defeated and turned into infants by the Spider- Army. Sometime later, they were murdered by the Wasp Totem goddess Shathra. Morlun briefl y set aside his di\u0084 erences with the Spider-Totems to help defeat Shathra, only to disappear immediately a\u0091 er. His current whereabouts are unknown.",
                ],
                Personality =
                [
                    "Morlun and his whole family have consistently modeled themselves in the image of Victorian-era vampires. Dressed in the clothes of pompous nobles, they delighted in declaring themselves the most supreme, untouchable beings in the Multiverse—the literal Inheritors of all existence. As the last surviving member of this group, Morlun is beginning to learn just how wrong his family really was.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Ms. Marvel (Early Days)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 3, vigilance: 3, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Military"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Piloting),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Enemy, specialization: "Magnitron (Yon-Rogg)"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Arabic, English, Russian"),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Captain Mar-Vell"),
                tagSelector.GetTag(TagNames.SecretIdentity, reminder: "known to allies"),

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
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Flight1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty3),
                        powerSelector.GetPower(PowerNames.Sturdy2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperStrength,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BangingHeads),
                        powerSelector.GetPower(PowerNames.Clobber),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Carol Danvers",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [145],
                Gender = Gender.Female,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Journalist, OccupationName.Military],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Avengers, TeamNames.USAirForce],
                Base = "New York City",
                History =
                [
                    "While serving as a pilot for the U.S. Air Force and NASA, Carol Danvers became involved with Captain Mar-Vell, a super-powered visitor from the Kree Empire, and was caught in an explosion that she thought gave her super-powers too. She later discovered that the blast activated the Kree DNA that she was unaware she’d inherited from her mother.",
                    "Danvers soon joined the Avengers, but left the team after temporarily losing her powers to Rogue. She later rejoined, and since then, she has served as the team’s leader throughout many of its most turbulent periods.",
                    "Over the years, Danvers has struggled with fluctuating power levels, alcoholism, low self-confidence and identity crises of all kinds. After using the names Binary, Warbird and Ms. Marvel, Danvers finally settled into the identity of Captain Marvel, a name she took to honor her old mentor Mar-Vell, who had died of cancer.",
                    "This profile represents Danvers in the earliest days of her adventures, when Mar-Vell was still alive and she was known as Ms. Marvel. Back then, a combination of inexperience and partially inactive DNA left her capable of accessing only a meager fraction of her true powers. At the time, she spent her nights exploring her new abilities, and her days working under J. Jonah Jameson as a journalist for the Daily Bugle spin-off project Woman Magazine ."
                ],
                Personality =
                [
                    "In the future, Danvers will be not only a strong-willed and pragmatic leader, but a mentor to younger heroes like the new Ms. Marvel (Kamala Khan) and the students of Avengers Academy. However, right now, she’s just a rookie hero, still struggling to come to terms with her abilities. She cares for her friends deeply, but she’s not always sure how to protect them, or even protect herself.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Ms. Marvel (Kamala Khan)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 4, vigilance: 1, ego: 3, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Honest),
                traitSelector.GetTrait(TraitNames.QuickLearner),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.InhumanGenes),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.SlipFree),
                        powerSelector.GetPower(PowerNames.StiltSteps),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink2),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Kamala Khan",
                Heights = [new() { Feet = 5, Inches = 4 }],
                Weights = [125],
                Gender = Gender.Female,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Student],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.Champions, TeamNames.Protectors],
                Base = "Jersey City",
                History =
                [
                    "From a young age, Kamala Khan idolized Captain Marvel (Carol Danvers), who exemplifi ed a sort of uncomplicated femininity missing from Khan’s own life as the teenage daughter of Pakistani immigrants. One night, while sneaking out of her parents’ house to go to a party, Khan was exposed to a mysterious cloud of Terrigen Mist that activated the Inhuman DNA lurking in her system, giving her the power to grow, shrink and morph into whatever shape or appearance she pleased.",
                    "Donning a costume of her own, Khan adopted Carol Danvers’ former alias and became the new Ms. Marvel. In short order, she met her idol Carol and even joined the Avengers, but she later left them to form the new teenage Champions.",
                ],
                Personality =
                [
                    "Khan is a lovable and friendly nerd and a natural leader. She’s also a teenager still trying to fi gure out the specifi cs of who she is, but she’s gradually becoming more confident in herself and her identity.",
                ]
            }
        },
		new()
		{
			Name = "Multiple Man",
			Rank = 3,
			Abilities = new Abilities
			(
				melee: 3, agility: 2, resilience: 2, vigilance: 3, ego: 3, logic: 2
			),
			Traits =
			[
				traitSelector.GetTrait(TraitNames.Connections, reminder: "Police"),
				traitSelector.GetTrait(TraitNames.Connections, reminder: "Super Heroes"),
				traitSelector.GetTrait(TraitNames.Dealmaker),
				traitSelector.GetTrait(TraitNames.ExtraOccupation),
				traitSelector.GetTrait(TraitNames.Fearless),
				traitSelector.GetTrait(TraitNames.Interrogation),
				traitSelector.GetTrait(TraitNames.Investigation),
				traitSelector.GetTrait(TraitNames.TechReliance),
			],
			Tags =
			[
				tagSelector.GetTag(TagNames.BlackMarketAccess),
				tagSelector.GetTag(TagNames.EarlyBloomer),
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
						powerSelector.GetPower(PowerNames.Inspiration),
						powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
						powerSelector.GetPower(PowerNames.GrapplingTechnique),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.MeleeWeaponsBlunt,
					Powers =
					[
						powerSelector.GetPower(PowerNames.FastAttacks),
						powerSelector.GetPower(PowerNames.HitAndRun),
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
			],
            NarrativePowers = 
            [
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.DuplicateSelf, reminder: "Duplication trigger: Take at least 1 point of Health damage. Absorption trigger: Touch the duplicate.")
            ],
			Biography = new Biography
			{
				RealName = "James Arthur “Jamie” Madrox",
				Heights = [new() { Feet = 5, Inches = 11 }],
				Weights = [155],
				Gender = Gender.Male,
				Eyes = "Brown",
				Hair = "Brown",
				Size = Size.Average,
				DistinguishingFeatures = "None",
				Occupations = [OccupationName.Adventurer, OccupationName.Investigator],
				Origins = [OriginName.Mutant],
				Teams = [TeamNames.XCorp, TeamNames.XFactor, TeamNames.XMen],
				Base = "Krakoa",
				History =
				[
					"Jamie Madrox’s duplication powers activated shortly after his birth, long before he was capable enough to handle them. To keep him from duplicating endlessly, Professor X (Charles Xavier) created a power-dampening suit for the young Madrox. It began to malfunction years later, long after Madrox had grown up and forgotten its purpose. Duplicating out of control and driven into a state of temporary insanity, he terrorized the streets of New York City. In the end, it took both Professor X and the entire Fantastic Four to bring him back to his senses.",
					"Afterward, Professor X took Jamie in and taught him to control his powers without the suit. Despite displaying some crimefighting potential, Jamie refused to formally join any super-hero team until years later, when dire circumstances forced him to become part of X-Factor.",
					"Jamie enjoyed his time with X-Factor—enough to stick with the team through its next few incarnations, even helping found X-Factor Investigations. He fell in love with Layla Miller, one of his X-Factor teammates, and eventually retired to spend more time with her and with their son, Davey. Recently, Madrox un-retired to join X-Corp’s board of directors.",
				],
				Personality =
				[
					"The personalities of Madrox and his duplicates vary slightly from one another, but they all have a few things in common. They are laid-back, put-upon men with dry senses of humor and subtle manic-depressive tendencies.",
					"Most of Madrox’s “dupes” stick close to him and to Krakoa, but over the years, a select few have chosen to live independently. Some of these duplicates even have families of their own."
				]
			},
			Source = BookSource.XMenExpansion
		},
		new()
        {
            Name = "Mysterio",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 2, vigilance: 2, ego: 6, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Discipline1),
                        powerSelector.GetPower(PowerNames.Disguise, isTech: true),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.ElementalControlEnergy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ElementalBurst),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimatedIllusion),
                        powerSelector.GetPower(PowerNames.Darkness),
                        powerSelector.GetPower(PowerNames.Dazzle),
                        powerSelector.GetPower(PowerNames.Deafen),
                        powerSelector.GetPower(PowerNames.Flare),
                        powerSelector.GetPower(PowerNames.GrandIllusion),
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.MirrorImages),
                        powerSelector.GetPower(PowerNames.StaticIllusion),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Quentin Beck",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.SinisterSix],
                Base = "New York City",
                History =
                [
                    "A special effects designer of extraordinary skill, Quentin Beck grew frustrated with the lack of recognition he received from the public. Feeling that his expertise could be put to more profi table uses, he assumed the title of Mysterio, master illusionist, and began a life of crime.",
                    "Unfortunately, all of Mysterio’s earliest schemes were foiled by Spider-Man (Peter Parker), and his plans gradually became less about profi t and more about revenge. He has appeared to have been killed numerous times—and others have sometimes temporarily taken his place—but he has always managed to return from the grave."
                ],
                Personality =
                [
                    "Mysterio has an undying flair for the theatrical. Rather than attacking his enemies directly, he prefers to trick them into hurting themselves, or otherwise gaslight them into insanity. Years of media coverage have only heightened his delusions of grandeur. He might be persuaded to give up crime if he could be assured that he would still be famous.",
                ]
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Mystique",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 2, vigilance: 3, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Beguiling),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Espionage"),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Presence),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in true form"),
                tagSelector.GetTag(TagNames.Hounded),
                tagSelector.GetTag(TagNames.Krakoan),
                tagSelector.GetTag(TagNames.Linguist, specialization: "Czech, English, Farsi, French, German, Korean, Portuguese, Spanish, Swedish"),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty1),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                        powerSelector.GetPower(PowerNames.Uncanny1),
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
                        powerSelector.GetPower(PowerNames.FastStrikes),
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
                }
            ],
            Biography = new Biography
            {
                RealName = "Raven Darkhölme",
                Heights = [new() { Feet = 5, Inches = 10 }],
                Weights = [120],
                Gender = Gender.Female,
                Eyes = "Varies",
                Hair = "Varies",
                Size = Size.Average,
                DistinguishingFeatures = "Her true form has blue skin and yellow eyes",
                Occupations = [OccupationName.Spy],
                Origins = [OriginName.Mutant],
                Teams = [TeamNames.BrotherhoodOfEvilMutants, TeamNames.HellfireClub, TeamNames.XMen],
                Base = "Krakoa",
                History =
                [
                    "No one, save perhaps Raven Darkhölme herself, knows the true origins of Mystique. She has existed in some form or another for well over a hundred years. Before the turn of the previous century, she worked extensively with the precognitive mutant Irene Adler, who later became Destiny—and her wife.",
                    "In modern times, Mystique fi rst surfaced as a minor member of the Brotherhood of Evil Mutants, but circumstances quickly forced her to switch sides and join the X-Men. In the years since, she’s regularly fl ip-fl opped, sometimes working as a hero and other times as a villain. Her shape-shifting powers make her a perfect spy or double agent."
                ],
                Personality =
                [
                    "Mystique’s abnormally long life has granted her a world-weary coolheadedness her younger teammates could never achieve. Unfortunately, her jaded instincts frequently drive her down the path to villainy. She is happy to ignore ethics if she believes that doing so is for the betterment of mutants.",
                ]
            }
        },
    ];
}
