using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersM
{
    public static List<Character> GetAllCharacters(
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
            Name = "Madame Mask",
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.IconicWeapon, specialization: "The Soulsword [Summonable. Provides a +4 Ego damage multiplier, but only against extra-dimensional creatures.]"),
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
                    Name = PowerSetNames.ElementControlFire,
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
                    Name = PowerSetNames.ElementControlIron,
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
                    Name = PowerSetNames.ElementControlEnergy,
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
                    Name = PowerSetNames.ElementControlEnergy,
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
            Name = "Mariah Hill",
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
                        powerSelector.GetPower(PowerNames.Disguise, isTech: true),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty2, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy2, isTech: true),
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
                        powerSelector.GetPower(PowerNames.ElementalPush),
                    ],
                    IsTech = true
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
                Base = "NYC",
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
            Name = "Mister Fantastic",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 4, resilience: 4, vigilance: 2, ego: 2, logic: 7
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
            }
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
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.Uncanny2),
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
            Name = "Mocking Bird (Bobbi Morse)",
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
                narrativePowerSelector.GetNarrativePower(NarrativePowerNames.DuplicateSelf)
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
            Name = "Mysterio (Quentin Beck)",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 0, agility: 0, resilience: 1, vigilance: 2, ego: 5, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: "(2) Grand Illusion, Mirror Images"),
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
                        powerSelector.GetPower(PowerNames.Discipline1),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimatedIllusion),
                        powerSelector.GetPower(PowerNames.Dazzle),
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
            }
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
