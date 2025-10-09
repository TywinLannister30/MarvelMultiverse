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
        allCharacters.AddRange(CharactersT.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(GetAllCharactersU());
        allCharacters.AddRange(GetAllCharactersV());
        allCharacters.AddRange(GetAllCharactersW());
        return allCharacters;
    }


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
