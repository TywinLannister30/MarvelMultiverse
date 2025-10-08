using MarvelMultiverse.Constants;
using MarvelMultiverse.Enums;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors.Characters;

public class CharactersR
{
    public static List<Character> GetAllCharacters(
      INarrativePowerSelector narrativePowerSelector,
      IPowerSelector powerSelector,
      ITagSelector tagSelector,
      ITraitSelector traitSelector) =>
    [
        new()
        {
            Name = "Rama-Tut",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 2, agility: 2, resilience: 3, vigilance: 4, ego: 4, logic: 5
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.FontOfInformation),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Powerful),
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
                        powerSelector.GetPower(PowerNames.Discipline2),
                        powerSelector.GetPower(PowerNames.Disguise, isTech: true),
                        powerSelector.GetPower(PowerNames.Mighty1, isTech: true),
                        powerSelector.GetPower(PowerNames.Sturdy1, isTech: true),
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
                        powerSelector.GetPower(PowerNames.ElementalProtection1),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                        powerSelector.GetPower(PowerNames.DefenseStance),
                        powerSelector.GetPower(PowerNames.FastStrikes),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.OmniversalTravelTime,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.TimePortal),
                        powerSelector.GetPower(PowerNames.TimeTravel),
                        powerSelector.GetPower(PowerNames.TimeTravelOther),
                        powerSelector.GetPower(PowerNames.TimeTravelTogether),
                    ],
                    IsTech = true
                }
            ],
            Biography = new Biography
            {
                RealName = "Nathaniel Richards",
                Heights = [new() { Feet = 6, Inches = 3 }],
                Weights = [230],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.HighTech],
                Teams = [TeamNames.Anachronauts, TeamNames.CouncilOfKangs],
                Base = "Ancient Egypt",
                History =
                [
                    "Nathaniel Richards grew up in the near-utopian environment of the 30th century of Earth-6311. As an adult, he became sick of luxury and became determined to live a life of adventure in a more interesting era.",
                    "Disguising himself as the Pharaoh Rama-Tut, Richards built a time machine and set about conquering ancient Egypt. As the supreme ruler of Egyptian civilization, Richards sought to secure his reign over all the Earth. As such, he is constantly on the lookout for any who may have the power to oppose him, particularly the mutant conqueror known as Apocalypse.",
                    "He does not yet know it, but Apocalypse will be the least of his worries. He later takes on a number of other identities, the most famous of which is Kang the Conqueror.",
                ],
                Personality =
                [
                    "Richards is a megalomaniac and a narcissist of the highest order. He believes himself to be the most important being in existence, and he will go to any length to prove his own importance. He often speaks in the style of the old Greco-Roman conquerors.",
                    "Richards is not above meddling in anyone’s timeline, even his own. As a result, his early life has become shrouded in mystery and divergence. A number of alternate versions of him from across the Multiverse have had adventuring careers to rival Richards’ own."
                ]
            },
            Source = BookSource.TheCataclysmOfKang
        },
        new()
        {
            Name = "Red Skull (Johann Shmidt)",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 3, agility: 3, resilience: 2, vigilance: 1, ego: 3, logic: 3
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Inventor),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Authority),
                tagSelector.GetTag(TagNames.Backup),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Hunted),
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
                        powerSelector.GetPower(PowerNames.Accuracy1),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AttackStance),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.CoveringFire),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.ReturnFire),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.KeepMoving),
                        powerSelector.GetPower(PowerNames.OnYourFeet),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Johann Shmidt",
                Heights = [new() { Feet = 6, Inches = 5 }],
                Weights = [189],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Brown",
                Size = Size.Average,
                DistinguishingFeatures = "Head is disfigured into a red skull",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.Hydra],
                Base = "Mobile",
                History =
                [
                    "Declaring that he could turn anyone into the ideal Nazi soldier, Adolf Hitler selected a random bellboy by the name of Johann Shmidt to be his next secret agent. He personally trained Shmidt to be a killer and spy, transforming him into one of the deadliest soldiers in the Third Reich.",
                    "After World War II, the crimson-faced Shmidt carried the mad führer’s dream of a worldwide Nazi government into the modern age. Were he not so dangerous, it would be easy to write him off as a cackling madman. A regular ally or even commander of fascist organizations like Hydra, he’s capable of launching complex schemes that threaten to bring the entire planet beneath his heel.",
                ],
                Personality =
                [
                    "In his day-to-day interactions with others, the Red Skull shows himself to be little more than a fascist zealot and a madman. Despite this, he is an expert propagandist who deftly recruits crowds of bigots.",
                ]
            }
        },
        new()
        {
            Name = "Red Wolf",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 1, agility: 3, resilience: 2, vigilance: 1, ego: 1, logic: 2
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.Determination),
                traitSelector.GetTrait(TraitNames.Interrogation),
                traitSelector.GetTrait(TraitNames.Investigation),
                traitSelector.GetTrait(TraitNames.SurprisingPower, reminder: $"{PowerNames.AnimalCommunication}"),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MeleeWeaponsSharp,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastAttacks),
                        powerSelector.GetPower(PowerNames.Riposte),
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
                        powerSelector.GetPower(PowerNames.StoppingPower),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Telepathy,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.AnimalCommunication, reminder: "Wolves"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Red Wolf",
                Heights = [new() { Feet = 6, Inches = 6 }],
                Weights = [225],
                Gender = Gender.Male,
                Eyes = "Brown",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.LawEnforcer],
                Origins = [OriginName.SpecialTraining],
                Teams = [TeamNames.SantaRosaSheriffsDepartment],
                Base = "Mobile",
                History =
                [
                    "Red Wolf was born to a community of Cheyenne natives in the old west of an alternate universe (Earth-51920). As a young man, he was sent to destroy a dam in Timely, a settler community that was diverting water from Cheyenne lands. Red Wolf made a deal with the townsfolk of Timely: in exchange for the destruction of their dam, he would take down their corrupt mayor, Wilson Fisk. With the help of some locals, Red Wolf killed Fisk and became the town’s sheriff.",
                    "Sometime later, Red Wolf fought a time-traveling super villain and wound up in the present day of Earth-616, where he has worked alongside Hawkeye (Clint Barton) and other heroes to help fi ght injustice.",
                ],
                Personality =
                [
                    "Red Wolf has a deep and abiding love for the communities he protects. While he enjoys his time in what he thinks of as the future—and especially the relationships he’s made there—he still wishes to return home.",
                ]
            }
        },
        new()
        {
            Name = "Ren Kimura",
            Rank = 2,
            Abilities = new Abilities
            (
                melee: 3, agility: 2, resilience: 2, vigilance: 1, ego: 2, logic: 0
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Famous),
                traitSelector.GetTrait(TraitNames.Glibness),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.InhumanGenes),
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

                        powerSelector.GetPower(PowerNames.IconicWeapon,
                            specialization: "Razor arms [hands act as melee weapons; +1 Melee damage multiplier]",
                            meleeDamageModifier: 1),

                        powerSelector.GetPower(PowerNames.Inspiration),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.MartialArts,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.FastStrikes),
                        powerSelector.GetPower(PowerNames.ViciousAttack),
                        powerSelector.GetPower(PowerNames.WhirlingFrenzy),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Plasticity,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.ExtendedReach2, reminder: "Reach 10"),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ren Kimura",
                Heights = [new() { Feet = 5, Inches = 8 }],
                Weights = [122],
                Gender = Gender.Female,
                Eyes = "Green",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "None",
                Occupations = [OccupationName.Entertainer],
                Origins = [OriginName.Inhuman],
                Teams = [TeamNames.AsgardiansOfTheGalaxy, TeamNames.FearlessDefenders],
                Base = "New York City",
                History =
                [
                    "Growing up, Ren Kimura wanted to be a dancer. Unfortunately, her parents never approved of her aspirations or—for that matter—her homosexuality. She was forced to take up dancing (and dating) in secret, regularly sneaking away from home to spend long hours practicing at a local dance studio.",
                    "Because of this, Kimura was at the dance studio—not safe at home— when the Terrigen Bomb detonated over New York City. The Terrigen Mist activated the Inhuman DNA lurking inside her genes, transforming her arms into twisted masses of metal wire. With effort, Kimura discovered that she could make the wires float through the air like dancing ribbons, able to slice distant targets to pieces.",
                    "That night, super villains invaded New York City, looking to kidnap the newly awakened Inhumans. Kimura would have fallen prey to them were it not for the intervention of the Fearless Defenders.",
                    "Kimura joined the Defenders and fell deeply in love with one of her new teammates: Annabelle Riggs. Even after the Defenders fell apart, Riggs and Kimura stuck together. They became part of the Asgardians of the Galaxy, and later, Riggs helped Kimura form her own dance studio. Although they’ve officially retired from the adventuring business, they remain ready to answer any call to action."
                ],
                Personality =
                [
                    "Despite their mutual affection, Riggs and Kimura have diametrically opposed personalities. Riggs is bookish, shy and more than a little awkward, while Kimura is as outgoing and charming as a person can be. She adores the stage and the spotlight.",
                ]
            },
            Source = BookSource.DeadpoolRolePlaysTheMarvelUniverse
        },
        new()
        {
            Name = "Reptil",
            Rank = 3,
            Abilities = new Abilities
            (
                melee: 4, agility: 2, resilience: 5, vigilance: 2, ego: 1, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.Berserker),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
                traitSelector.GetTrait(TraitNames.ExtraordinaryOrigin),
                traitSelector.GetTrait(TraitNames.Fearless),
                traitSelector.GetTrait(TraitNames.QuickLearner),
                traitSelector.GetTrait(TraitNames.TechReliance),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlternateForm, reminder: "Dinosaur Forms"),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance, reminder: "in Alternate Forms"),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.Mentor, specialization: "Vicente Lopez"),
                tagSelector.GetTag(TagNames.Obligation, specialization: "Family"),
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
                        powerSelector.GetPower(PowerNames.Mighty2),
                    ],
                    IsTech = true
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Resize,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Grow2),
                        powerSelector.GetPower(PowerNames.Shrink2),
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
                        powerSelector.GetPower(PowerNames.GroundShakingStomp),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Jump1),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                    IsTech = true
                },
            ],
            Biography = new Biography
            {
                RealName = "Humberto “Berto” Lopez",
                Heights = [new() { Feet = 5, Inches = 7 }],
                Weights = [142],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Black",
                Size = Size.Average,
                DistinguishingFeatures = "Dinosaur tail and limbs (when using powers)",
                Occupations = [OccupationName.Adventurer],
                Origins = [OriginName.HighTechPymParticles, OriginName.Magic],
                Teams = [TeamNames.AvengersAcademy],
                Base = "Los Angeles",
                History =
                [
                    "While out at a dig site with his paleontologist parents, Humberto Lopez stumbled upon a mystical fossilized amulet that gave him the power to shape-shift into prehistoric creatures, particularly dinosaurs. As a lifelong fan of super heroes, he leaped at this opportunity to become a hero himself, adopting the codename Reptil.",
                    "Shortly after Reptil began adventuring, his parents mysteriously disappeared. While he continued to search for them, he joined the Avengers Academy and became good friends with many of his fellow students. Although the academy is no more, he continues to do his best to help those in need.",
                ],
                Personality =
                [
                    "Reptil loves adventure, but he fears his own powers as much as he appreciates them. His reptilian transformations can occasionally send him into a berserker state, where he has little more reasoning power than a T. rex. He fears the possibility of accidentally lashing out at those closest to him.",
                ]
            }
        },
		new()
		{
			Name = "Rictor",
			Rank = 4,
			Abilities = new Abilities
			(
				melee: 1, agility: 4, resilience: 2, vigilance: 5, ego: 6, logic: 2
			),
			Traits =
			[
				traitSelector.GetTrait(TraitNames.CombatExpert),
				traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
				traitSelector.GetTrait(TraitNames.Fearless),
				traitSelector.GetTrait(TraitNames.Glibness),
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
						powerSelector.GetPower(PowerNames.Accuracy1),
						powerSelector.GetPower(PowerNames.Discipline2),
						powerSelector.GetPower(PowerNames.Inspiration),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.ElementControlSound,
					Powers =
					[
						powerSelector.GetPower(PowerNames.ElementalBarrage),
						powerSelector.GetPower(PowerNames.ElementalBlast),
						powerSelector.GetPower(PowerNames.ElementalBurst),
						powerSelector.GetPower(PowerNames.ElementalPush),
						powerSelector.GetPower(PowerNames.ElementalRicochet),
						powerSelector.GetPower(PowerNames.Supernova),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.ElementControlEarth,
					Powers =
					[
						powerSelector.GetPower(PowerNames.ElementalBarrage),
						powerSelector.GetPower(PowerNames.ElementalBlast),
						powerSelector.GetPower(PowerNames.ElementalBurst),
						powerSelector.GetPower(PowerNames.ElementalGrab),
						powerSelector.GetPower(PowerNames.ElementalPrison),
						powerSelector.GetPower(PowerNames.ElementalProtection2),
						powerSelector.GetPower(PowerNames.ElementalPush),
					],
				},
			],
			Biography = new Biography
			{
				RealName = "Julio Esteban Richter",
				Heights = [new() { Feet = 5, Inches = 9 }],
				Weights = [145],
				Gender = Gender.Male,
				Eyes = "Brown",
				Hair = "Brown",
				Size = Size.Average,
				DistinguishingFeatures = "None",
				Occupations = [OccupationName.Adventurer],
				Origins = [OriginName.Mutant],
				Teams = [TeamNames.Excalibur, TeamNames.NewMutants, TeamNames.XFactor],
				Base = "Krakoa",
				History =
				[
					"Born into a Mexican cartel family, Julio Richter’s early life was marked by violence and chaos. After his father was murdered by Stryfe, Richter tried to run away from home, only to be kidnapped by the Right, an anti-mutant organization interested in his fledgling seismic powers.",
					"X-Factor freed him from the Right’s control and subsequently gave him a place among their trainees, the X-Terminators. Among mutants for the first time in his life, Richter excelled. Under the codename Rictor, he quickly graduated into the New Mutants and, from there, into X-Force.",
					"After losing his powers on M-Day, Rictor fell into a deep depression. To cheer him up, some of his old teammates invited him to help them form X-Factor Investigations. Shortly thereafter, Rictor came out as gay and began dating one of his teammates, Shatterstar. Once Rictor regained his powers, he and Shatterstar left X-Factor Investigations and began adventuring on their own. Following the foundation of Krakoa, the pair joined Excalibur, committing themselves to the protection of the island-nation."
				],
				Personality =
				[
					"Despite his dark past, Rictor is more laid-back than most mutant adventurers. He’s a generally cheery guy who doesn’t take himself too seriously. When referring to his teammates, he frequently uses words like “dude” and “bro.” Although he’s closer to Shatterstar than anyone else, Rictor has been around long enough for many mutants to consider him a valued friend and teammate.",
				]
			},
            Source = BookSource.XMenExpansion
		},
		new()
        {
            Name = "Rocket Racoon",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 3, agility: 5, resilience: 3, vigilance: 4, ego: 1, logic: 4
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.CombatReflexes),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Criminal"),
                traitSelector.GetTrait(TraitNames.Connections, specialization: "Outsiders"),
                traitSelector.GetTrait(TraitNames.Dealmaker),
                traitSelector.GetTrait(TraitNames.ExtraOccupation),
                traitSelector.GetTrait(TraitNames.FreshEyes),
                traitSelector.GetTrait(TraitNames.Small),
                traitSelector.GetTrait(TraitNames.Stranger),
            ],
            Tags =
            [
                tagSelector.GetTag(TagNames.AlienHeritage),
                tagSelector.GetTag(TagNames.BlackMarketAccess),
                tagSelector.GetTag(TagNames.ExtremeAppearance),
                tagSelector.GetTag(TagNames.Heroic),
                tagSelector.GetTag(TagNames.PublicIdentity),
                tagSelector.GetTag(TagNames.Streetwise),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "2 Pistols"),
                tagSelector.GetTag(TagNames.SignatureWeapon, specialization: "Rifle"),
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
                        powerSelector.GetPower(PowerNames.CombatTrickery),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.ReinforcedSkeleton),
                        powerSelector.GetPower(PowerNames.SlowMotionDodge),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.RangedWeapons,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.DanceOfDeath),
                        powerSelector.GetPower(PowerNames.DoubleTap),
                        powerSelector.GetPower(PowerNames.SlowMotionShootDodge),
                        powerSelector.GetPower(PowerNames.SnapShooting),
                        powerSelector.GetPower(PowerNames.Sniping),
                        powerSelector.GetPower(PowerNames.StoppingPower),
                        powerSelector.GetPower(PowerNames.SuppressiveFire),
                        powerSelector.GetPower(PowerNames.WeaponsBlazing),
                    ],
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
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Rocket",
                Heights = [new() { Feet = 4 }],
                Weights = [55],
                Gender = Gender.Male,
                Eyes = "Brown (with tapetal reflection)",
                Hair = "Brown, black and white",
                Size = Size.Small,
                DistinguishingFeatures = "Raccoon-like alien",
                Occupations = [OccupationName.Criminal, OccupationName.Outsider],
                Origins = [OriginName.Alien],
                Teams = [TeamNames.Avengers, TeamNames.GuardiansOfTheGalaxy],
                Base = "Mobile",
                History =
                [
                    "Rocket is a genetically and cybernetically engineered extraterrestrial created to resemble an Earth raccoon and to work as one of the protectors of the Loonies, a group of criminally insane aliens sentenced to life on the prison planet Halfworld in the Keystone Quadrant. After leaving his position, Rocket made his way into the wider galaxy, where he wound up involved in questionable activities that landed him in a Kree prison. There, he met his best friend, Groot, and together, they helped form the Guardians of the Galaxy.",
                    "With the rest of the Guardians, Rocket saved the galaxy from being destroyed by the alien hive fl eet known as the Phalanx. After that, they decided to band together permanently, becoming a family as much as a team. Rocket has even stepped up to lead the team when Star-Lord wasn’t available.",
                ],
                Personality =
                [
                    "Rocket is sharp and conniving, one of the smartest people around, especially when it comes to tactics and logistics. He carries larceny in his heart and is always looking for a better angle on any problem that presents itself.",
                ]
            }
        },
		new()
		{
			Name = "Rogue",
			Rank = 4,
			Abilities = new Abilities
			(
				melee: 5, agility: 4, resilience: 4, vigilance: 3, ego: 3, logic: 1
			),
			Traits =
			[
				traitSelector.GetTrait(TraitNames.CombatReflexes),
				traitSelector.GetTrait(TraitNames.Connections, specialization: "Super Heroes"),
				traitSelector.GetTrait(TraitNames.Fearless),
				traitSelector.GetTrait(TraitNames.Glibness),
				traitSelector.GetTrait(TraitNames.Presence),
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
						powerSelector.GetPower(PowerNames.Flight2),
						powerSelector.GetPower(PowerNames.Mighty3),
						powerSelector.GetPower(PowerNames.Sturdy2),
					],
				},
				new CharacterPowerSet
				{
					Name = PowerSetNames.PowerControl,
					Powers =
					[
						powerSelector.GetPower(PowerNames.ClonePowers),
						powerSelector.GetPower(PowerNames.CopyPower),
						powerSelector.GetPower(PowerNames.DampenPower),
						powerSelector.GetPower(PowerNames.ShutDownPowers),
						powerSelector.GetPower(PowerNames.StealPowers), //TODO
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
						powerSelector.GetPower(PowerNames.QuickToss),
						powerSelector.GetPower(PowerNames.Smash),
					],
				},
			],
            PowerNotes = 
            [
				"In order to activate any of her Power Control powers, Rogue must first grab or hit her target. If she spends her action on this, she can still activate the power in question with a reaction."
			],
			Biography = new Biography
			{
				RealName = "Anna Marie LeBeau",
				Heights = [new() { Feet = 5, Inches = 8 }],
				Weights = [135],
				Gender = Gender.Female,
				Eyes = "Green",
				Hair = "Brown with white streaks",
				Size = Size.Average,
				DistinguishingFeatures = "None",
				Occupations = [OccupationName.Adventurer],
				Origins = [OriginName.Mutant],
				Teams = [TeamNames.Avengers, TeamNames.BrotherhoodOfEvilMutants, TeamNames.XMen],
				Base = "Mobile",
				History =
				[
					"Born into a cold and neglectful family, Anna Marie fled from home at a young age. She spent some time working as a thief on the banks of the Mississippi, earning herself the nickname Rogue. Eventually, Mystique and Destiny—having precognitive knowledge of Rogue’s mutant status—took her in and raised her as their daughter. When Rogue’s mutant absorption powers activated suddenly and traumatically in her early teenage years, Mystique and Destiny were prepared to comfort Rogue—and to indoctrinate her into a life of mutant terrorism.",
					"Rogue eventually joined her adoptive mothers in the Brotherhood of Evil Mutants, but her time with the team was cut short after she accidentally absorbed the powers and psyche of Captain Marvel (Carol Danvers). On the edge of a dissociative breakdown, Rogue fled into the custody of Professor X, who helped her integrate Captain Marvel’s psyche into her own and subsequently allowed her to join the X-Men.",
					"Rogue excelled as a hero, quickly becoming a key part of the X-Men. She began a long-term romance with her teammate Gambit, and shortly before the foundation of Krakoa, the pair finally wed. Although they served as backup members of Krakoa’s Excalibur team, Gambit and Rogue made an effort to spend most of their recent time focusing on each other."
				],
				Personality =
				[
					"Rogue’s Power Control powers cause her to absorb a bit of her target’s mind, so in the heat of battle, her personality can vary wildly. However, at her core, she’s a kind and sensitive Southern belle, albeit one with a short fuse. She speaks in a thick Southern accent, often referring to people as “sugah.”",
				]
			},
			Source = BookSource.XMenExpansion
		},
		new()
        {
            Name = "Ronan the Accuser",
            Rank = 4,
            Abilities = new Abilities
            (
                melee: 5, agility: 2, resilience: 4, vigilance: 2, ego: 6, logic: 1
            ),
            Traits =
            [
                traitSelector.GetTrait(TraitNames.BattleReady),
                traitSelector.GetTrait(TraitNames.Big, reminder: "Reach 2"),
                traitSelector.GetTrait(TraitNames.BreatheDifferent),
                traitSelector.GetTrait(TraitNames.CombatExpert),
                traitSelector.GetTrait(TraitNames.EnhancedPhysique),
                traitSelector.GetTrait(TraitNames.Presence),
                traitSelector.GetTrait(TraitNames.PublicSpeaking),
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
                        powerSelector.GetPower(PowerNames.Flight2),
                        powerSelector.GetPower(PowerNames.Inspiration),
                        powerSelector.GetPower(PowerNames.Mighty2),
                        powerSelector.GetPower(PowerNames.Sturdy2),
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
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.SuperSpeed,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.Clobber),
                        powerSelector.GetPower(PowerNames.Immovable),
                        powerSelector.GetPower(PowerNames.Smash),
                    ],
                },
                new CharacterPowerSet
                {
                    Name = PowerSetNames.Tactics,
                    Powers =
                    [
                        powerSelector.GetPower(PowerNames.BattlePlan),
                        powerSelector.GetPower(PowerNames.FocusFire),
                        powerSelector.GetPower(PowerNames.KeepMoving),
                    ],
                },
            ],
            Biography = new Biography
            {
                RealName = "Ronan",
                Heights = [new() { Feet = 7, Inches = 5 }],
                Weights = [480],
                Gender = Gender.Male,
                Eyes = "Blue",
                Hair = "Brown",
                Size = Size.Big,
                DistinguishingFeatures = "Blue skin",
                Occupations = [OccupationName.Leader],
                Origins = [OriginName.AlienKree],
                Teams = [TeamNames.KreeEmpire],
                Base = "Kree-Lar",
                History =
                [
                    "A powerful warrior, Ronan rose through the ranks of the Kree military, eventually achieving the position of Supreme Accuser. Second only to the Emperor himself, Ronan was in charge of overseeing all Kree military operations.",
                    "Ronan has battled some of the deadliest warriors in the galaxy and personally led invasions of Earth, the Skrull Empire and the Inhuman homeland. After a coup resulted in the death of the Kree Emperor, Ronan himself was elected to the position. He later made peace with the Inhumans and entered into an arranged marriage with Crystal to cement it, but this didn’t last.",
                ],
                Personality =
                [
                    "A hulking mass of a warrior, Ronan demands respect from those around him, and any show of disrespect can cause him to erupt in a murderous rage. His proud loyalty to the Kree people outweighs his ferocious nature, though, and he tends to look down on those from “lesser races.”",
                ]
            }
        },
    ];
}
