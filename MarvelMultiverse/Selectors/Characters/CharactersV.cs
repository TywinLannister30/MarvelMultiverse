using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersV
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
            Name = "Venom",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 5, resilience: 3, vigilance: 2, ego: 4, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Sources"),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Loner),
                traitSelector.GetTrait(TraitNames.Pundit),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
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
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
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
                RealName = "Edward Charles Allan “Eddie” Brock",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [260],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Blond",
                Size = Size.Average,
                DistinguishingFeatures = "Venom form has retractable claws, fangs and an unnaturally long tongue",
                Occupations = [OccupationName.Journalist],
                Origins = [OriginName.SymbioteVenom],
                Teams = [TeamNames.SinisterSix, TeamNames.SymbioteHive],
                Base = "New York City",
                History =
                [
                    "Eddie Brock was disgraced as a journalist after Spider-Man (Peter Parker) unknowingly discredited the biggest story of his career. Outcast and despondent, Eddie went to a church to pray for a way out. Unbeknownst to him, Spider-Man was there too, wrestling with an alien symbiote he’d been wearing as a costume. Once Spider-Man rid himself of the symbiote, it found and bonded itself to Eddie and the two vowed to take revenge on Spider-Man as Venom.",
                    "Eddie has since managed to rein in his anger and the symbiote’s murderous tendencies. For a while, he parted from Venom and bonded with other symbiotes spawned from it—Anti-Venom and Toxin—but he eventually returned to the original.",
                    "After defeating Knull, king of the symbiotes, Brock broke his bond with Venom to become the godlike King in Black, a throne he subsequently lost."
                ],
                Personality =
                [
                    "Although he can still be murderously unstable, Eddie has softened over the years. These days, he’s more concerned with becoming a hero in his own right and protecting his son, Dylan, who has also bonded with the Venom symbiote.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Venom (Earth-1048)",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 6, agility: 4, resilience: 4, vigilance: 2, ego: 1, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Anathema, specialization: "Extreme Heat / Extreme Sonics / Anti-Venom"),
                traitSelector.GetTrait(TraitNames.Audience),
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FreeRunning),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.ScientificExpertise),
                traitSelector.GetTrait(TraitNames.SymbioticSpiderBlinder),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in alternate form"),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.Rich),
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
                        powerSelector.GetPower(PowerNames.Brilliance1),
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.HealingFactor),
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SpiderPowers,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.SpiderStrike),
                        powerSelector.GetPower(PowerNames.Wallcrawling),
                        powerSelector.GetPower(PowerNames.Webcasting),
                        powerSelector.GetPower(PowerNames.Webgrabbing),
                        powerSelector.GetPower(PowerNames.Webslinging),
                        powerSelector.GetPower(PowerNames.Webtrapping),
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
                RealName = "Harold “Harry” Osborn",
                Heights = [new() { Feet = 6, Inches = 6 }],
                HeightReminder = "5'10\" as Harry",
                Weights = [542],
                WeightReminder = "169 lbs. as Harry",
                Gender = Gender.Male,
                Eyes = "Green",
                Hair = "Red",
                Size = Size.Big,
                SizeNotes = "Average as Harry",
                DistinguishingFeatures = "Venom form has retractable claws, fangs and an unnaturally long tongue",
                Occupations = [OccupationName.Scientist],
                Origins = [OriginName.SymbioteVenom],
                Teams = [TeamNames.SymbioteHive],
                Base = "New York City (Earth-1048)",
                History =
                [
                    "As lifelong best friends, Harry Osborn and Peter Parker promised each other that, when they grew up, they would use their scientifi c talents to make the world a better place.",
                    "Unfortunately, Osborn would be cursed with a life in stasis. Stricken with a rare and painful degenerative nerve disease, he did get to spend most of his adult life in a lab, but as a subject rather than a scientist.",
                    "All Harry really wanted to do was to get back to his work, but his father, Norman, was determined to cure the disease, no matter the cost. After multiple unsuccessful and disastrous attempts at developing a traditional cure, Norman was willing to try anything, even sticking his son into a vat with an alien symbiote.",
                    "Though the symbiote did initially seem to work as a treatment for Harry’s disease, it quickly abandoned him for a stronger host—Parker. By feeding off Parker’s abilities, it transformed itself into a powerful and autonomous entity capable of mass murder. Parker eventually managed to separate himself from the monstrous creature and contain it, but Harry, in a fi t of resentment, broke the symbiote’s container and bonded with it again.",
                    "In the resulting carnage, wide swaths of New York City were transformed into symbiotic monstrosities. Although Parker eventually freed Harry from the symbiote’s grasp, the strain of the whole incident put Harry into a coma."
                ],
                Personality =
                [
                    "Harry Osborn is a sweet man, a thoughtful scientist and, most of all, a good friend. The Venom symbiote manipulated his resentment over his health issues to put itself into a position to take over New York City, but Harry himself would never hurt a soul.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Venture 2099",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 3, vigilance: 4, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Flight1, isTech: true),
                        powerSelector.GetPower(PowerNames.HeightenedSenses1, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),

                    ],
                },
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
                        powerSelector.GetPower(PowerNames.FastHands),
                        powerSelector.GetPower(PowerNames.PointBlankParry),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Unknown",
                Heights = [new() { Feet = 6 }],
                Weights = [366],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Significant cybernetic implants replacing limbs, eyes and ears",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechCybernetics],
                Teams = [TeamNames.Alchemax],
                Base = "Nueva York (Earth-928)",
                History =
                [
                    "Venture is a psionically enhanced cyborg bounty hunter from Earth-928. He values human life very little, prefers technology and kills without hesitation. He is considered to be Alchemax’s best enforcer and one of the oldest foes of Spider-Man (Miguel O’Hara).",
                    "Shortly after the accident at Alchemax that gave Spider-Man his powers, company president Tyler Stone hired Venture to investigate. Wrongly believing that the new Spider-Man had broken into the lab, Stone sent the bounty hunter to capture him. Venture tracked O’Hara back to his apartment and forced a confrontation by threatening members of the Church of Thor who had tried to intervene, killing one of them. Although Venture was briefl y able to capture Spider-Man, the wall-crawler eventually broke free and defeated him.",
                    "Though he is an indisputably skilled bounty hunter, Venture’s tough-guy ego often prevents him from taking his enemies seriously, costing him in fights.",
                ],
                Personality =
                [
                    "Venture has the looks of a cowboy, but he lacks the heart of one. He kills with impunity, and how quickly he does so is determined only by how much he is getting paid. He thinks highly of himself and takes any chance he can to let everyone know how easy bounty hunting is for a consummate professional such as himself.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Vermin",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 5, agility: 5, resilience: 2, vigilance: 3, ego: 0, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
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
                        powerSelector.GetPower(PowerNames.HeightenedSenses1),
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
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "rodents)"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Edward Whelan",
                Heights = [new() { Feet = 6 }],
                Weights = [220],
                Gender = Gender.Male,
                Eyes = "Red",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Ratlike body with brown fur, tail, sharp claws and teeth",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [TeamNames.Hydra, TeamNames.TheVermin],
                Base = "New York City",
                History =
                [
                    "Baron Zemo and Arnim Zola kidnapped a random unhoused man named Edward Whelan o¦ a street in New York City and fused the man’s DNA with that of a rat found living on the same road. The experiment drove Whelan insane, so the fascists had no trouble convincing the newly anointed Vermin to attack their old enemy, Captain America (Steve Rogers). However, after several unsuccessful bouts with the first Avenger, Vermin went rogue and took to living in the sewers beneath Manhattan, hunting the people of the surface world for sustenance.",
                    "Since then, Vermin and his pet rats have fought with dozens of other super-powered individuals, most commonly Spider-Man (Peter Parker) and the web-slinger’s mortal enemy Kraven.",
                    "Appropriately enough, it was during Kraven’s self-proclaimed Great Hunt that Arcade injected Vermin with an experimental drug, causing him to spontaneously duplicate for a time. These days, dozens of copies of Vermin live in the New York sewers, popping up now and again to kidnap unsuspecting citizens from the streets above.",
                ],
                Personality =
                [
                    "Although he initially retained a near-human level of intelligence, years of sewer life have made Vermin into an increasingly vicious and animalistic creature. He speaks in short sentences, often no more than a few words long, with a soft, hissing voice akin to the sounds rats make. He remembers little of his life before becoming Vermin.",
                ],
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Veteran Mercenary",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 2, vigilance: 2, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.SituationalAwareness),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                    ],
                },
            ],
            IsHenchman = true,
            Source = BookSource.SpiderverseExpansion
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
                    Name = PowerSetNames.ElementalControlEnergy,
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
            Name = "Vision (Jonas)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 2, agility: 3, resilience: 2, vigilance: 3, ego: 0, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.EideticMemory),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
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
                        powerSelector.GetPower(PowerNames.Flight1),
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
                RealName = "Jonas",
                Heights = [new() { Feet = 5, Inches = 9 }],
                Weights = [210],
                Gender = Gender.Male,
                Eyes = "Gold",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "Bright red synthezoid skin",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechAndroid],
                Teams = [TeamNames.YoungAvengers],
                Base = "Mobile",
                History =
                [
                    "When the Scarlet Witch’s suppressed memories of her children re-emerged, her reality-altering powers went berserk, creating fluctuations that rocked the entire universe. One of these fluctuations killed the Vision. The other Avengers left his body in the wreckage of Avengers Mansion, where Iron Lad (Nathaniel Richards) later discovered it. He used parts of the Vision to craft a unique new A.I.—later named Jonas—who helped him put together the Young Avengers.",
                    "When Iron Lad later abandoned the team, he left his battle suit behind. The A.I. took over the suit and fashioned it into an autonomous android body, allowing him to take Iron Lad’s place on the team.",
                    "Declaring himself the new Vision, and later taking the name Jonas, the A.I. faithfully followed the Young Avengers through their next several adventures. Sadly, his time with the team was cut short when Iron Lad returned and destroyed the Vision in a fit of rage.",
                    "The original Vision returned to life soon after that, and for the next several years, nobody made any attempt to revive Jonas. Recently, however, a remorseful Iron Lad salvaged the Jonas A.I. and implanted it into his new Teen Immortus battle suit, effectively bringing him back to life. Jonas is once again without a body of his own, but this profile represents him as he was during his stint with the Young Avengers."
                ],
                Personality =
                [
                    "Though Jonas shares many of the original Vision’s heroic and caring qualities, he is even more coldly aloof and calculating than his predecessor. He rarely acts as a tactical leader, but he has a strong penchant for tactical games, particularly chess.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Void",
            Rank = 6,
            Abilities = new Abilities
            (
                melee: 5, agility: 8, resilience: 4, vigilance: 8, ego: 4, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.Bloodthirsty),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Villains"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Leverage),
                traitSelector.GetTrait(TraitNames.Sneaky),
                traitSelector.GetTrait(TraitNames.Weird),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Bob Reynolds"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Enemy, reminder: "The Sentry"),
                tagSelector.GetTag(TagNames.MentalHealthConditions),
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
                        powerSelector.GetPower(PowerNames.Disguise),
                        powerSelector.GetPower(PowerNames.EnvironmentalProtection),
                        powerSelector.GetPower(PowerNames.Evasion),
                        powerSelector.GetPower(PowerNames.Mighty4),
                        powerSelector.GetPower(PowerNames.ShapeShift),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Illusion,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimatedIllusion),
                        powerSelector.GetPower(PowerNames.Darkness),
                        powerSelector.GetPower(PowerNames.Illumination),
                        powerSelector.GetPower(PowerNames.MirrorImages),
                        powerSelector.GetPower(PowerNames.StaticIllusion),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BodySheet),
                        powerSelector.GetPower(PowerNames.BounceBack),
                        powerSelector.GetPower(PowerNames.CoilingCrush),
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                        powerSelector.GetPower(PowerNames.FlexibleBones2),
                        powerSelector.GetPower(PowerNames.ReversePunch),
                        powerSelector.GetPower(PowerNames.SlipFree),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.PowerControl,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CopyPower),
                        powerSelector.GetPower(PowerNames.PowerSlider, reminder: "Sentry’s Confidence Inverted"),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TelepathicBlast),
                        powerSelector.GetPower(PowerNames.TelepathicLink),
                    ],
                },
            ],
            PowerNotes =
            [
                "When killed or shattered, the Void becomes Bob (use the Average Civilian profile from the Core Rulebook), with 1 Health and 1 Focus. Bob can become the Sentry again when restored to full Health and Focus."
            ],
            Biography = new Biography
            {
                RealName = "Void",
                Heights = [new() { IsVariable = true},],
                Weights = [],
                VariableWieght = true,
                Gender = Gender.None,
                Eyes = "Varies",
                Hair = "None",
                Size = Size.Varies,
                DistinguishingFeatures = "Shape-shifting mass of darkness and despair",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.WeirdScience],
                Teams = [],
                Base = "Mobile",
                History =
                [
                    "In college, Bob Reynolds began to hear voices. Over time, they pushed him into drug abuse in an attempt to self-medicate. Looking for a new high, Reynolds broke into a local lab and drank a vial containing an experimental serum, granting himself incredible super-powers.",
                    "In response, Reynolds’ mind formed two new personalities. The more positive, hopeful side of his psyche became the super hero known as the Sentry, and his negative and self-destructive impulses formed into a dark cosmic entity called the Void.",
                    "The threat of the Void is so great that the Sentry has, at times, either deliberately depowered himself or willingly merged with the evil creature to keep it contained.",
                    "Recently, the Void merged with the symbiote king Knull, and together, they finally managed to kill the Sentry. Venom (Dylan Brock) seemingly destroyed both Knull and the Void shortly thereafter. However, the Sentry’s powers have since reconsolidated in Solarus (Mallory Gibbs).",
                    "This profile represents the Void back when the Sentry was a member of the Avengers."
                ],
                Personality =
                [
                    "The Void is the yang to the Sentry’s yin, the abyssal reflection of his shining light. Though the Void often chooses to appear human, it is a force of pure chaos and destruction with no true shape. It can look like a serial killer one moment and a dark cloud on the horizon the next.",
                ]
            },
            Source = BookSource.AvengersExpansion
        },
        new()
        {
            Name = "Vulture",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 2, vigilance: 2, ego: 0, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Abrasive),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.Gearhead),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.SignatureAttack, specialization: $"{PowerNames.GrapplingTechnique} [while flying]"),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.LabAccess),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Razor Feathers (act as knives; can be thrown)"),
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
                        powerSelector.GetPower(PowerNames.Flight2, isTech: true),
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
            ],
            Biography = new Biography
            {
                RealName = "Adrian Toomes",
                Heights = [new() { Feet = 5, Inches = 11 }],
                Weights = [175],
                Gender = Gender.Male,
                Eyes = "Hazel",
                Hair = "None",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Criminal, OccupationName.Engineer],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Orchis, TeamNames.SinisterSix, TeamNames.SinisterTwelve],
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
            },
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = "Vulture's Henchmen",
            Rank = 1,
            Abilities = new Abilities
            (
                melee: 1, agility: 1, resilience: 1, vigilance: 1, ego: 1, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: PowerNames.Flight1),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.Streetwise),
            ],
            Powers =
            [
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Basic,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Flight1),
                    ],
                },
            ],
            IsHenchman = true,
            Source = BookSource.SpiderverseExpansion
        },
    ];
}
