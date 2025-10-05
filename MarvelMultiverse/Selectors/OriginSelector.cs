using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class OriginSelector : IOriginSelector
{
    public Origin GetOrigin(string name)
    {
        return GetAllOrigins().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<Origin> GetOrigins()
    {
        return GetAllOrigins();
    }

    private static List<Origin> GetAllOrigins() =>
    [
        new()
        {
            Name = OriginName.Alien,
            Description =
            [
                "The character is not human and probably not from Earth or at least Earth-616. The Marvel Multiverse features all sorts of di­fferent alien races. The most common of these—Kree, Skrulls and so on—have their own entries. If the character doesn’t fit one of those, then this origin applies.",
            ],
            Examples = "Devil Dinosaur, Gamora, Groot, Rocket Raccoon.",
            Tags= $"{TagNames.AlienHeritage}, {TagNames.ExtremeAppearance} (common).",
            SuggestedOccupation = OccupationName.Outsider
        },
        new()
        {
            Name = OriginName.AlienBrood,
            Description =
            [
                "The character is a member of the Brood, one of the most feared alien species in the galaxy. The Brood are insectoid creatures overseen by Brood Queens who all serve the Empress Brood. The Empress rules the entire Brood population through a hive mind that extends across the universe.",
                "Only Brood Queens (including the Empress) can implant a Brood embryo in creatures from other species, which is how the Brood reproduce. Queens prefer to implant embryos in an unconscious host to prevent the host from knowing about it. They often poison the host with their tail stinger and wait for them to fall before implanting the embryo, which neutralizes the poison.",
                "If a character is fully taken over by a Brood embryo implanted in them, they automatically gain this origin, along with the Extraordinary Origin trait."
            ],
            Examples = "Broo, Brood Drone, Brood Queen, Empress Brood.",
            Tags= $"{TagNames.AlienHeritage}, {TagNames.ExtremeAppearance}, {TagNames.Villainous}",
            Traits = $"{TraitNames.Fearless}, {TraitNames.HiveMind}, {TraitNames.Infector} (Brood implantation, Queens only), {TraitNames.Venomous}.",
            SuggestedOccupation = OccupationName.Military,
            Powers = $"{PowerNames.AdditionalLimbs}, {PowerNames.Flight1} (except for Queens), {PowerNames.Mighty1}, {PowerNames.Sturdy1}",
            MinimumRank = 2,
            Limitation = "Unless the Brood is a Queen, the character can only pick additional powers as if they had the Special Training origin.",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.AlienKree,
            Description =
            [
                "The character is a member of the Kree, a humanoid race from the planet Hala who formed the interstellar Kree Empire in the region of space known as the Large Magellanic Cloud. They resemble humans but are stronger and tougher. Many of them have blue skin, but a good number of them have pink skin.",
                "The air on Hala has much more nitrogen in it, and Kree who are raised in it (or something like it) have a hard time breathing the air on Earth."
            ],
            Examples = "Captain Marvel (Mar-Vell), Hulkling (half Skrull and half Kree), Magnitron (Yon-Rogg), Ronan the Accuser.",
            Tags= $"{TagNames.AlienHeritage}, {TagNames.ExtremeAppearance} (if blue-skinned).",
            Traits = $"{TraitNames.BreatheDifferent}, {TraitNames.EnhancedPhysique}.",
            SuggestedOccupation = OccupationName.Outsider
        },
        new()
        {
            Name = OriginName.AlienMarginalian,
            Description =
            [
                "The character is a Marginal, a species of asexually reproducing hermaphrodites who come from Marginalia, a space between universes. They are legless, shaped like a green potato with arms, and they get around by means of levitation.",
            ],
            Examples = "Doop.",
            Tags= $"{TagNames.AlienHeritage}, {TagNames.ExtremeAppearance}",
            Traits = $"{TraitNames.Weird}.",
            SuggestedOccupation = OccupationName.Outsider,
            Powers = $"{PowerNames.DimensionalPortal}, {PowerNames.DimensionalTravel}, {PowerNames.DimensionalTravelOther}, {PowerNames.DimensionalTravelTogether}, {PowerNames.Grow2}, {PowerNames.HealingFactor}, {PowerNames.Levitation}, {PowerNames.Shrink2}, {PowerNames.Sturdy2}, {PowerNames.Uncanny2}",
            MinimumRank = 3,
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.AlienShiar,
            Description =
            [
                "The character is a member of the Shi’ar, an avian humanoid race from the planet Chandilar who formed the interstellar Shi’ar Empire in the Shi’ar Galaxy. They resemble humans but are much stronger and have feathers instead of hair on their heads.",
            ],
            Examples = "Adam-X, Deathbird, Majestrix Lilandra Neramani.",
            Tags= $"{TagNames.AlienHeritage}, {TagNames.ExtremeAppearance}.",
            Traits = $"{TraitNames.EnhancedPhysique}.",
            SuggestedOccupation = OccupationName.Outsider
        },
        new()
        {
            Name = OriginName.AlienSkrull,
            Description =
            [
                "The character is a member of the Skrull, a reptilian humanoid race of shape-shifters who formed the interstellar Skrull Empire. In their natural form, they have green skin, red or green eyes, pointed ears and furrowed chins. They sprang from the planet Skrullos in the Andromeda Galaxy.",
                "The original Skrulls could not shape-shift, but the Celestials experimented on them to form Eternal Skrulls and Deviant Skrulls, much like they did with humans on Earth. The Deviant Skrulls became the dominant form of the species, driving the originals to extinction."
            ],
            Examples = "Hulkling (half Skrull and half Kree), Lyja, Super-Skrull (Kl’rt).",
            Tags= $"{TagNames.AlienHeritage}, {TagNames.ExtremeAppearance} (in theirnatural form).",
            Traits = $"{TraitNames.EnhancedPhysique}.",
            SuggestedOccupation = OccupationName.Outsider,
            Powers = $"{PowerNames.Disguise}, {PowerNames.ExtendedReach1}, {PowerNames.FlexibleBones1}, {PowerNames.ShapeShift}, {PowerNames.SlipFree}.",
        },
        new()
        {
            Name = OriginName.AlienTechnarch,
            Description =
            [
                "The character is a member of the alien species known as the Technarchy. These artificially intelligent techno-organic beings use a Transmode virus to infect other creatures and eventually take over a planet to prepare it to become part of the Phalanx or be devoured.",
            ],
            Examples = "Warlock, Magus.",
            Tags= $"{TagNames.AI}, {TagNames.AlienHeritage}, {TagNames.ExtremeAppearance}, {TagNames.Powerful}",
            Traits = $"{TraitNames.EnduringConstitution}, {TraitNames.FreshEyes}, {TraitNames.Infector} (Transmode virus).",
            SuggestedOccupation = OccupationName.Outsider,
            Powers = $"{PowerNames.BrainDrain}, {PowerNames.Disguise}, {PowerNames.EnvironmentalProtection}, {PowerNames.ExtendedReach1}, {PowerNames.FlexibleBones1}, {PowerNames.LeechLife}, {PowerNames.ShapeShift}",
            MinimumRank = 3,
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.Atlantean,
            Description =
            [
                "The character is a member Homo mermanus, a variant race of humanity. Atlanteans breathe water through gills on both sides of their neck, and they cannot breathe air for longer than ten minutes.",
                "If they live in the Atlantic Ocean, they likely have blue skin and hail from Atlantis. If they come from the Pacifi c Ocean, they likely have green skin and live in Lemuria."
            ],
            Examples = "Attuma, Sub-Mariner (Namor), Namora, Warlord Krang.",
            Tags= $"{TagNames.Amphibious}, {TagNames.ExtremeAppearance}.",
            Traits = $"{TraitNames.BreatheDifferent}, {TraitNames.EnhancedPhysique}.",
            SuggestedOccupation = OccupationName.Outsider,
            Powers = $"{PowerNames.HeightenedSenses1}, {PowerNames.SpeedSwim}.",
        },
        new()
        {
            Name = OriginName.Deviant,
            Description =
            [
                "The character is a member of Homo descendus, a variant race of humanity created by the Celestials. They are scattered across Earth, but they mainly live in underground cities beneath the Pacifi c Ocean, close to Lemuria.",
                "Only one hundred Deviants were originally created, but many more have been born over the millennia since then. They vary a great deal physically, coming in all sizes, shapes, colors and textures. Each is born with a unique physical mutation, and they have the latent genetic ability to develop powers, much like mutants.",
                "Eternals are compelled to kill Deviant mutates as part of their principle “Correct excess deviation.”"
            ],
            Examples = "Brother Tode, Karkas, Kro.",
            Tags= $"{TagNames.ExtremeAppearance}, {TagNames.Hunted}.",
            SuggestedOccupation = OccupationName.Outsider,
        },
        new()
        {
            Name = OriginName.Eternal,
            Description =
            [
                "The character is a member of Homo immortalis, a variant race of humanity created by the Celestials. They are scattered across Earth, but their headquarters lies in the city of Olympia, high in the mountains in Greece and folded into an echo dimension. Some live on Titan (a moon of Saturn) instead.",
                "The Eternals live by three principles:",
                "- Protect Celestials.",
                "- Protect the Machine (a sentient A.I. deeply connected with the Earth).",
                "- Correct excess deviation.",
                "Only one hundred Eternals were originally created, and only two have been born since: Thanos and Eros. The character is either one of the lesser-known one hundred or a new Eternal brought to life through extraordinary means.",
                "Through a ritual usually initiated by the Prime Eternal (their official leader), Eternals can be called to be part of a collective being known as the Uni-Mind."
            ],
            Examples = "Ikaris, Sersi, Sprite, Thanos, Thena.",
            Tags= $"{TagNames.EternallyImmortal}, {TagNames.MahdWyry}.",
            SuggestedOccupation = OccupationName.Outsider,
        },
        new()
        {
            Name = OriginName.HighTech,
            Description =
            [
                "The character’s powers arise from high-tech devices that are well beyond the limits of modern-day engineering. This can come in many forms.",
            ],
            Examples = "Doctor Octopus (Otto Octavius), Gauntlet (Joseph Green), Mysterio (Quentin Beck), the Trapster.",
            Traits = $"{TraitNames.TechReliance}.",
        },
        new()
        {
            Name = OriginName.HighTechAndroid,
            Description =
            [
                "The character is an artifi cial person. Their body (when they have one) is made of plastic, metal and circuitry rather than fl esh and blood. Their powers come from technology embedded in their artifi cial body.",
            ],
            Examples = "Human Torch (Jim Hammond), Jocasta, Machine Man, Vision.",
            Tags= $"{TagNames.AI}, {TagNames.ExtremeAppearance} (common).",
            Traits = $"{TraitNames.TechReliance}.",
            SuggestedOccupation = OccupationName.Outsider,
        },
        new()
        {
            Name = OriginName.HighTechBattleSuit,
            Description =
            [
                "The character wears a high-tech suit that grants them powers. When the battle suit is removed, the character no longer has access to the powers it grants. They are entirely—or at least mostly—normal underneath.",
                "Most characters with this origin have the Extreme Appearance tag when wearing their battle suit."
            ],
            Examples = "Iron Man (Tony Stark), Ironheart, War Machine",
            Tags= $"{TagNames.ExtremeAppearance} (common when in Battle Suit).",
            Traits = $"{TraitNames.TechReliance}.",
        },
        new()
        {
            Name = OriginName.HighTechCybernetics,
            Description =
            [
                "The character has high-tech, surgically embedded implants that grant them powers. These cannot be removed without great care or pain.",
                "If the implants are obvious, the character gets the Extreme Appearance tag. Otherwise, the implants have been hidden inside their body (as with the lacing of Wolverine’s skeleton with adamantium) and might be visible only when in use (like when Wolverine uses his claws), if then."
            ],
            Examples = "Deathlok (all of them), Sabretooth, Winter Soldier, Wolverine (Logan).",
            Tags= $"{TagNames.ExtremeAppearance} (common).",
            Traits = $"{TraitNames.TechReliance}.",
        },
        new()
        {
            Name = OriginName.HighTechPymParticles,
            Description =
            [
                "The character uses Pym Particles (named after their inventor, Henry Pym) to dramatically grow or shrink in size.",
                "After long-enough exposure to Pym Particles, many people are able to generate such particles on their own without the need of external aid. They may still need to use extra Pym Particles to reach extremely large or small sizes."
            ],
            Examples = "Ant-Man (Scott Lang), Giant-Man (Rax Malhotra), Wasp (Janet Van Dyne).",
            Traits = $"{TraitNames.TechReliance} (at first).",
            Powers = $"{PowerNames.Grow1} and/or {PowerNames.Shrink1} (at least).",
        },
        new()
        {
            Name = OriginName.Inhuman,
            Description =
            [
                "The character is a member of Homo sapiens inhumanus, a variant race of humanity genetically engineered by the Kree. For millennia, they lived isolated from the world, but they emerged in recent years, led by Black Bolt.",
                "All Inhumans carry a latent gene that can be activated by the Terrigen Mist. The explosion of a Terrigen Bomb spread the mist across the entire planet, revealing that many humans (including Kamala Khan) had Inhuman genetics. Black Bolt was later forced to destroy the Inhumans, leaving few outside of the royal family alive.",
                "The character is one of those rare Inhumans who survived."
            ],
            Examples = "Black Bolt, Crystal, Karnak, Lockjaw, Medusa, Ms. Marvel (Kamala Khan).",
            Tags= $"{TagNames.InhumanGenes}.",
        },
        new()
        {
            Name = OriginName.Magic,
            Description =
            [
                "The character’s powers arise from supernatural means. There are many di­fferent traditions within magic, each with their own teachings.",
            ],
            Examples = "Clea, Doctor Voodoo (Jericho Drumm), Enchantress.",
            Tags= $"{TagNames.Supernatural}.",
        },
        new()
        {
            Name = OriginName.MagicChaosMagic,
            Description =
            [
                "The character is able to use chaos magic, which allows them to bend reality to their will. It stems from the ancient god Chthon.",
            ],
            Examples = "Morgan Le Fay, Scarlet Witch, Wiccan.",
            Tags= $"{TagNames.Chaotic}, {TagNames.Supernatural}.",
        },
        new()
        {
            Name = OriginName.MagicDemonic,
            Description =
            [
                "The character taps into (or is cursed by) the powers of Hell. They may be a native of one of the Nine Circles of Hell, or their powers might simply come from a Hellish source.",
            ],
            Examples = "Belasco, Blackheart, Daimon Hellstrom, Dormammu.",
            Tags= $"{TagNames.Cursed}, {TagNames.Supernatural}.",
        },
        new()
        {
            Name = OriginName.MagicSorcery,
            Description =
            [
                "The character’s powers arise from the study and practice of sorcery.",
            ],
            Examples = "Agatha Harkness, Ancient One (Yao), Doctor Strange, Magik, Wong.",
            Tags= $"{TagNames.Sorcerous}, {TagNames.Supernatural}.",
        },
        new()
        {
            Name = OriginName.Monstrous,
            Description =
            [
                "The character is some kind of monster. They may have a human form—or may have once been human—but they get their powers from their unnatural monstrousness.",
            ],
            Examples = "Cullen Bloodstone, Living Mummy, Man-Thing.",
            Traits = $"{TraitNames.Monster}.",
        },
        new()
        {
            Name = OriginName.MonstrousMummudrai,
            Description =
            [
                "The character is a monster known as a Mummudrai, an evil twin spirit from the Astral Plane that each fetus must fight and defeat in the womb to be born. Few of them survive, but those who do can become terrifyingly powerful, as they can copy DNA and fashion physical forms for themselves.",
            ],
            Examples = "Cassandra Nova.",
            Traits = $"{TraitNames.Monster}.",
            SuggestedOccupation = OccupationName.Outsider,
            NarrativePowers = $"{NarrativePowerNames.DNAManipulation}.",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.MonstrousVampire,
            Description =
            [
                "The character was once alive but was embraced by a vampire and has risen from death as a vampire too. They can transmit this magical disease to victims of their choosing.",
                "When a character becomes a vampire, they go up one rank and gain the listed tags, traits and powers. They do not gain any additional powers or traits from this bump in rank, but they do gain 5 ability points and add +1 to their damage multiplier. If they have the Heroic tag, they also add 1 to their Karma."
            ],
            Examples = "Baron Blood, Dracula, Blade (half vampire).",
            Tags= $"{TagNames.AlternateForm} (Bat / Mist / Wolf), {TagNames.Deceased}, {TagNames.Imageless}.",
            Traits = $"{TraitNames.Anathema}: Garlic / Holy Symbols (including Holy Water) / Sunshine, {TraitNames.Bloodthirsty}, {TraitNames.Monster}, {TraitNames.Weakness}: Silver / Wood.",
            Powers = $"{PowerNames.AnimalCommunication}: Bats / Rodents, {PowerNames.Command}, {PowerNames.HealingFactor}, {PowerNames.LeechLife}, {PowerNames.Mighty1}, {PowerNames.Sturdy2}, {PowerNames.TelepathicLink}.",
            Limitation = "Unless the character has another origin, they cannot choose other powers."
        },
        new()
        {
            Name = OriginName.MonstrousWerewolf,
            Description =
            [
                "The character is afficted with lycanthropy, a magical disease that causes them to take on the shape of a werewolf during the three nights of the full moon. They can transmit this magical disease to victims of their choosing who survive their attacks.",
                "When a character becomes a werewolf, they gain the Lunar Transformation and Alternate Form tags. When the character takes on their werewolf form, they go up one rank and gain the rest of the listed tags, traits and powers. They do not gain any additional powers or traits from this bump in rank, but they do gain 5 ability points and add +1 to their damage multiplier. If they have the Heroic tag, they also add 1 to their Karma. When they return to human form, they lose the benefits of their werewolf form.",
                "The character can switch forms voluntarily at any point— except during the three nights that the moon is at its fullest. On those nights, while the moon is above the horizon, the character must transform into a werewolf and is ruled by their animal nature. They cannot help but hunt and attack any people or creatures they come across, no matter if they are friend or foe."
            ],
            Examples = "Werewolf by Night (Jack Russell), Werewolf by Night (Jake Gomez).",
            Tags= $"{TagNames.AlternateForm} (Werewolf / Wolf), {TagNames.ExtremeAppearance} (in werewolf form), {TagNames.LunarTransformation}.",
            Traits = $"{TraitNames.Berserker}, {TraitNames.Monster}, {TraitNames.Weakness}: Silver.",
            Powers = $"{PowerNames.Evasion}, {PowerNames.HealingFactor}, {PowerNames.HeightenedSenses1}, {PowerNames.Mighty1}, {PowerNames.Sturdy2}.",
            Limitation = "Unless the character has another origin, they cannot choose other powers."
        },
        new()
        {
            Name = OriginName.Mutant,
            Description =
            [
                "The character’s powers spring from them being a member of the subspecies Homo superior. They have a latent X-Gene that grants them powers, often triggered at adolescence.",
            ],
            Examples = "Cyclops, Jean Grey, Storm, Wolverine (Logan), Wolverine (Laura Kinney).",
            Tags = $"{TagNames.Hounded}, {TagNames.XGene}.",
            SuggestedTags = $"{TagNames.Arakkii}, {TagNames.Krakoan}.",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.MutantArtificial,
            Description =
            [
                "The character’s powers spring from DNA manipulation—or a natural, inherent condition—that makes them appear to be a true mutant. They believe themselves to be a mutant, or they did for years. However, they were not born with an X-Gene.",
            ],
            Examples = "Deadpool, Mister Sinister, Quicksilver, Scarlet Witch.",
            Tags = $"{TagNames.Hounded}, {TagNames.MutantAssociate}.",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.MutantExternal,
            Description =
            [
                "The character is a member of a rare and powerful subspecies of immortal mutants that stretches back thousands of years. Roughly a thousand years ago, the Externals formed a group called the High Lords that continues to influence the world’s destiny from behind the scenes. Some of them believe Cannonball to be the latest of their kind, although this is unconfirmed.",
            ],
            Examples = "Apocalypse, Selene.",
            Tags = $"{TagNames.ExternallyImmortal}, {TagNames.Hounded}, {TagNames.XGene}.",
            Traits = $"{TraitNames.ExternalAwareness}.",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = OriginName.Mythic,
            Description =
            [
                "The character is a creature or person of myth and legend. While they may appear human, they are something else.",
            ],
            Examples = "Angela (Aldrif Odinsdottir), Fairies, Malekith.",
            Tags= $"{TagNames.Supernatural}.",
            SuggestedOccupation = OccupationName.Outsider
        },
        new()
        {
            Name = OriginName.MythicAsgardian,
            Description =
            [
                "The character is a member of the Asgardian people, resembling the Norse gods. They call Asgard their home.",
                "The character can be one of the many gods who have been named throughout history, or they can be one of the lesser-known gods of Asgard. They should choose something that they are the god of."
            ],
            Examples = "Hela, Heimdall, Loki, Sif, Thor (Odinson).",
            Tags= $"{TagNames.Supernatural}, {TagNames.Worshipped}.",
            Traits = $"{TraitNames.EnhancedPhysique}, {TraitNames.GodHeritage}.",
        },
        new()
        {
            Name = OriginName.MythicOlympian,
            Description =
            [
                "The character is a member of the Olympian people, resembling the gods of Ancient Greece and Rome. They call Olympus their home.",
                "The character can be one of the many gods who have been named throughout history, or they can be one of the lesserknown gods of Olympus. They should choose something that they are the god of."
            ],
            Examples = "Ares, Athena, Hercules, Zeus.",
            Tags= $"{TagNames.Supernatural}, {TagNames.Worshipped}.",
            Traits = $"{TraitNames.EnhancedPhysique}, {TraitNames.GodHeritage}.",
        },
        new()
        {
            Name = OriginName.SpecialTraining,
            Description =
            [
                "The character’s powers come from long hours of practice. Their intense focus grants them abilities that would astonish most people.",
            ],
            Examples = "Hawkeye (Clint Barton), Hawkeye (Kate Bishop), Nick Fury Jr., Shang-Chi.",
            Traits = $"{TraitNames.Determination}.",
            Limitation = "Unless the character has another origin, they cannot choose powers that grant them superhuman abilities. Allowed power sets include Martial Arts, Melee Weapons, Ranged Weapons, Shield Bearer and Tactics. They can also choose basic powers a regular human could reasonably have. See the Basic powers list on page 80."
        },
        new()
        {
            Name = OriginName.SpiritOfVengeance,
            Description =
            [
                "The character has been possessed by a Spirit of Vengeance. Their purpose is to find sinners and impose penance.",
                "When a character becomes possessed by a Spirit of Vengeance, they gain the Alternate Form tag, which they can use voluntarily at any point. When the character takes on their Ghost Rider form, they gain access to the listed tags, traits and powers. When they return to human form, they lose the benefi ts of their Ghost Rider form."
            ],
            Examples = "Ghost Rider (Johnny Blaze), Ghost Rider (Danny Ketch), Ghost Rider (Robbie Reyes).",
            Tags= $"{TagNames.AlternateForm} (Ghost Rider), {TagNames.Cursed}, {TagNames.Supernatural}.",
            Powers = $"{PowerNames.ElementalProtection2}, {PowerNames.EnvironmentalProtection}, {PowerNames.HealingFactor}, {PowerNames.HellfireChains}, {PowerNames.Mighty2}, {PowerNames.PenanceStare}, {PowerNames.PossessVehicle}, {PowerNames.SenseSins}. They should select most of the rest of their powers from the Magic: Demonic and Elemental Control: Hellfire sets.",
            Limitation = "The character should be at least Rank 4. Unless the character has another origin, they cannot choose other powers."
        },
        new()
        {
            Name = OriginName.Symbiote,
            Description =
            [
                "The character has bonded with one of the Klyntar, a race of alien symbiotes created by the alien god Knull. Most of these creatures on Earth display spiderlike powers.",
                "When a character bonds with a symbiote, they go up one rank and gain the listed tags, traits and powers. Any remaining powers they select are often from the Spider-Powers set but do not have to be. Many symbiotes have the Disguise power.",
                "If the symbiote is Venom or one of its progeny, Spider-Man (Peter Parker) cannot gain any benefits from his Spider-Sense power against the bonded character."
            ],
            Examples = "Carnage, Venom (Eddie Brock), Shriek.",
            Traits = $"{TraitNames.Anathema}: Extreme Heat / Extreme Sonics.",
            Powers = $"{PowerNames.EnvironmentalProtection}, {PowerNames.Mighty1}",
        },
        new()
        {
            Name = OriginName.Unknown,
            Description =
            [
                "The character has developed powers but is not entirely sure how. It could be that the player or the Narrator knows, but the character does not, or maybe nobody else does either. Astonishing things happen all the time in the Marvel Multiverse, and there’s no way to classify them all.",
                "The source of these powers may be explained in time. It could turn out that the character actually has a standard type of origin, or it could be that they have an origin that’s utterly unique.",
            ],
            Examples = "Squirrel Girl, Taskmaster.",
            Tags= $"{TagNames.Mysterious}.",
        },
        new()
        {
            Name = OriginName.WeirdScience,
            Description =
            [
                "The character’s powers arose from a scientific experiment or accident that’s hard—if not impossible—to reproduce. Often, they had the latent genetic potential to develop powers and were somehow exposed to the right triggers—which would have likely killed most other people.",
                "These kinds of characters are sometimes called mutates. The di­fference between a mutate and a mutant is that a mutant’s powers come to them naturally, but a mutate’s powers require a triggering incident that might never happen. In this sense, Inhumans are all mutates who share a gene with a known trigger: the Terrigen Mist.",
            ],
            Examples = "Captain America (Steve Rogers), Daredevil (Matt Murdock), Invisible Woman, Jessica Jones, Luke Cage, Spider-Man (Miles Morales), Spider-Man (Peter Parker).",
            Traits = $"{TraitNames.Weird}.",
        },
        new()
        {
            Name = OriginName.WeirdScienceGammaMutate,
            Description =
            [
                "The character has a genetic mutation that gave them powers once they were exposed to enough gamma radiation, transforming them physically. This often gives them a monstrous appearance and changes their coloration drastically, usually to green, although some become red or even blue. They can often transform back into their original form as well.",
            ],
            Examples = "Doc Samson, Harpy (Betty Banner), Hulk (Bruce Banner), Red Hulk (Thaddeus “Thunderbolt” Ross).",
            Tags= $"{TagNames.ExtremeAppearance} (common in gamma mutate form), {TagNames.GreenDoor}, {TagNames.Immunity}: Gamma Radiation, {TagNames.Radioactive}.",
            Traits = $"{TraitNames.Weird}.",
        },
    ];
}
