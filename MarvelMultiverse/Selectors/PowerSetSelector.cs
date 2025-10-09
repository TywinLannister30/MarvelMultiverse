using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class PowerSetSelector : IPowerSetSelector
{
    public PowerSet GetPowerSet(string name)
    {
        return GetAllPowerSets().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<PowerSet> GetPowerSets()
    {
        return GetAllPowerSets();
    }

    private static List<PowerSet> GetAllPowerSets() =>
    [
        new()
        {
            Name = PowerSetNames.ElementControl,
            Description =
            [
                "When a character selects an Elemental Control power, they must select the type of element their power uses, as shown in the list below. Most characters stick to a single type of element, but this is not required.",
                "Each type of element has its own special e­ffect associated with it that’s triggered by Fantastic successes on checks made with that power. The special effects are as follows:",
                "- Air: Target is knocked prone for one round.",
                "- Chemical: The target is corroding.",
                "- Earth: Target moves at half speed for one round.",
                "- Electricity: Stuns target for one round.",
                "- Energy: Blinds target for one round.",
                "- Fire: Sets target ablaze.",
                "- Force: Target has trouble on all actions for one round.",
                "- Hellfire: Splits damage equally between Health and Focus.",
                "- Ice: Paralyzes target for one round.",
                "- Iron: Pins target for one round.",
                "- Sound: Deafens target for one round.",
                "- Swarm: The target is frightened.",
                "- Toxin: The target is poisoned.",
                "- Water: Surprises target until the end of the next round.",
                "The character’s power produces or locates each of these elements as necessary.",
                "Force is an invisible but hard material, the sort of thing a force-fi eld is made from.",
                "Hellfire is a demonic form of fire. Only characters with the Cursed tag can use it.",
                "The power to control iron is actually the power to control magnetism—which requires a solid element (iron) to a­ ect.",
                "Energy, in this case, serves as a catchall term for all kinds of energy. This can be any sort of powerful energy, from Cyclops’ eye-beams to Dazzler’s displays to the energy that Captain Marvel (Carol Danvers) fires.",
                "We use the generic elemental terms in the rulebook for clarity, but you don’t have to be bound by such restrictions. When referring to these powers in the game or on your character sheet, you can substitute in your chosen element for the word Elemental. You can even change it to other words that fit the character better. Just make sure that the Narrator knows what you mean.",
            ]
        },
        new()
        {
            Name = PowerSetNames.Healing,
            Description =
            [
                "This power set allows the character to heal both physical and mental damage. This ranges from stopping bleeding all the way up to resuscitating someone who is technically dead. Characters like Elixir and Healer often use such powers. While such characters often aren’t a direct help in a fight, they can get the bruisers on their team patched up and right back into a brawl. Some of them can reverse their healing powers to cause damage to people instead.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerSetNames.Illusion,
            Description =
            [
                "When a character casts an illusion, the player should describe the illusion in detail. What does it look like? If it makes sound, what does it sound like? If it can move, how does it move?",
                "Most characters believe in the illusions they witness. If they have a reason to, they can try to disbelieve an illusion. This requires a Logic check made against the Ego defense of the character who created the illusion. If the check succeeds, the character sees through the illusion. If they communicate this to others, those characters get an edge on any Logic check to see through the illusion as well. On a Fantastic success on any such Logic check, the illusion ends.",
                "The Illusion power set also includes things like invisibility and other powers that hamper or block the senses. You can’t disbelieve such things. However, you can still attack things in the dark or things that are invisible— as long as you have any indication that there’s something there. Characters that attempt to do so have trouble on their attack checks.",
                "Invisible characters have an edge on Agility checks to sneak past people, and enemies have trouble on Vigilance checks to perceive them. It’s even harder to spot things that are invisible but aren’t moving. Characters must be actively trying to do so to be able to make a Vigilance check.",
            ]
        },
        new()
        {
            Name = PowerSetNames.Luck,
            Description =
            [
                "This power set gives a character the ability to influence probability, both for good and for bad. This can cause the most unlikely of things to happen—although not the impossible. Domino and Longshot are examples of heroes who use such powers to their own advantage. Conversely, Black Cat uses her powers to inflict bad luck on those who cross her path.",
                "Remember that edges due to the same factor do not stack. This means that a character can have only one edge from a Luck power at a time. This is true whether the Luck powers belong to the same character or different characters."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerSetNames.Magic,
            Description =
            [
                "Magic is a complex power set with all sorts of wild powers in it. Players and Narrators should be careful with such powers, as they can be easier to abuse than others. Remember that no matter what the rules might say, all players should try to play in the spirit of the game.",
                "Magic powers generally rely on Ego for their checks, so if you’re building a character that focuses on this power set, be sure to put some points into the Ego ability too.",
                "There are four basic types of magic:",
                "Chaos Magic: To use this, a character must have the Chaotic tag. These powers arise from some kind of contact with the dark lord Chthon, and they can be unpredictable. In times of incredible emotional distress, they can be enough to change the world. Such universe-altering powers aren’t covered in this book, though, as they should be as rare as they are powerful.",
                "The Scarlet Witch is the best-known user of Chaos Magic, although there are others who manage it as well.",
                "Demonic Magic: To use this, a character must have the Cursed tag. These powers arise from a relationship with demons and other dark fi gures. Most users of Demonic Magic are tormented by their powers and have complicated feelings about them. The various Ghost Riders are good examples of such characters.",
                "Sorcery: To use this, a character must have the Sorcerous tag. This means that they’ve spent time studying this sort of magic and understand its underlying principles. Many of the powers listed here are actually well-known and battletested spells that many sorcerers wield.",
                "Doctor Strange and Wong are some of the best-known sorcerers around.",
                "Ritual Magic: This sort of magic is not covered in this book, as the topic is far too broad. It includes the kinds of spells that take hours, if not days, to cast, and they often involve the use of special ingredients and rare and powerful tomes. Most characters would not encounter such things on a daily basis—not even Doctor Strange as the Sorcerer Supreme—but they can be the basis of important adventures.",
                "Such tomes are more like powerful artifacts on their own than simple spell books. A good example of this would be the legendary Darkhold, an indestructible book in which Chthon inscribed his works.",
                "Most magic-based powers fall under Chaos Magic, Demonic Magic or Sorcery. However, it’s possible for a character with the Magic origin to pick other powers with the idea that they are provided to the character by magic.",
            ]
        },
        new()
        {
            Name = PowerSetNames.MartialArts,
            Description =
            [
                "The Martial Arts power set covers all sorts of unarmed combat. There are plenty of di­ erent disciplines that could be named here—kung fu, karate, tae kwon do, jiu-jitsu and such—so the powers are meant to be more about the results of various moves rather than the actual techniques.",
                "This is one of the power sets that anyone can use, including those with the Special Training origin, so powers from it crop up often. If you have a character with extra powers to pick, this is an excellent place to improve their combat abilities without warping their character concept by adding in powers that don’t match up well.",
            ]
        },
        new()
        {
            Name = PowerSetNames.MeleeWeapons,
            Description =
            [
                "The Melee Weapons power set covers di­ erent ways to use all sorts of weapons employed in hand-to-hand combat. Note that the weapons themselves can a­ ect the attacks they make, but this is covered in Chapter 4. This power set is about how those weapons get used.",
                "When a character selects a Melee Weapons power, they get a melee weapon to use with it. In addition, they must select the type of weapon their power uses—either blunt or sharp—as shown below. Most characters stick to a single type of weapon, but feel free to mix and match.",
                "Each type of weapon has its own special e­ ect associated with it that’s triggered by Fantastic successes on checks made with that power:",
                "- Blunt: Target is stunned for one round.",
                "- Sharp: Target is bleeding.",
                "In general, sharp weapons have blades, points or other vicious tips or edges. Blunt weapons do not.",
                "Again, this is a power set that is open to anyone, including characters with the Special Training origin. Many heroes don’t use weapons of any kind, but doing so can add a bit of fl air to the character and help distinguish them from others.",
                "Imagine Wolverine without his claws. His weapons play a big part in defi ning him as a character.",
                "While a shield can be used as a blunt weapon, there’s a whole power set—Shield Bearer—dedicated to that particular bit of equipment. If you want your character to use a shield, look there too.",
            ]
        },
        new()
        {
            Name = PowerSetNames.OmniversalTravel,
            Description =
            [
                "There are three di­ erent types of Omniversal Travel incorporated into the power set. They all allow a character to move between di­ erent dimensions, but the key di­ erence comes down to which dimensions the character has access to.",
                "If the character wants to move through space in a single dimension, they should look to the Teleportation power set instead.",
                "Dimensional: These powers allow the character to move between dimensions that are attached to their current universe. This can include places like Limbo, Beyond and the Negative Zone.",
                "While it’s true that some fundamental dimensions connect to multiple universes, when a character travels to one of these dimensions with these powers, they return to their own universe, not one of the others in the Multiverse. If they want to jump to a di­ erent universe, they should have multiversal powers instead.",
                "Multiversal: These powers permit the character to travel between di­ erent universes—from, say, Earth-616 to Earth-65. These are usually universes that are closely aligned with Earth-616. They might differ in details—even vitally important ones—but the way the universes work generally remains the same.",
                "If the character wishes to move into di­ erent dimensions attached to one of these universes, they should have dimensional powers instead.",
                "Time: Traveling through time is technically a multiversaltravel power, as it moves people from their universe to one that looks like it but is set at a di­ erent time. Traveling into the future moves the character into a possible future, and the farther out that future is, the less certain it is. Traveling ten years into the future, for instance, allows for lots of points of substantial divergence, while traveling ten seconds into the future usually does not.",
                "Players and Narrators should be extremely cautious with all of these powers, but especially with time-travel powers. They are ripe for abuse by both the unethical and the wellintentioned. Without care, characters can fi nd themselves trapped in a time or place that di­ ers fundamentally from the one they wished to be in.",
                "Characters are not allowed to time-travel to a previous time in a battle, as doing so at such a crucial juncture would transport them into an alternate universe instead.",
                "At the Narrator’s discretion, characters that abuse their time-travel powers can expect a visit from the Time Variance Authority, Kang the Conqueror or any number of other powerful time-travelers who don’t appreciate someone mucking around with the timeline. Those who fail to mend their ways can expect such visits to be anything but friendly."
            ]
        },
        new()
        {
            Name = PowerSetNames.Phasing,
            Description =
            [
                "Phasing powers are for characters that can walk through things like a ghost. Kate Pryde is the archetypal example of this. However, it also works for the Vision when he lowers his body’s density. When he increases his density, that’s the equivalent of taking levels of Sturdy instead.",
                "You can use phasing powers to replicate other sorts of intangibility. They would work well for ghosts, for instance.",
            ]
        },
        new()
        {
            Name = PowerSetNames.Plasticity,
            Description =
            [
                "While the Plasticity power set seems tailor-made for stretchy characters like Mister Fantastic, it also works for characters of any type who are able to contort, stretch or reshape their forms. This includes characters like Ms. Marvel (Kamala Khan) and Groot.",
                "Many characters with Plasticity powers also take the Disguise power—a basic power—as their flexibility allows them to alter their finer features as well as their bodies.",
            ]
        },
        new()
        {
            Name = PowerSetNames.PowerControl,
            Description =
            [
                "The Power Control power set is essentially a collection of meta-powers: powers that a­ ect other powers. Characters that rely on this power set work best with a decentsized team of other super-powered characters whose powers they can amplify or borrow.",
                "For a character to be able to use or affect an item that belongs to someone else (a power, ability, trait and so on), they have to fi rst know about the item. If they’ve seen it in action, that’s enough. They don’t need to have seen it in person, though. Watching a video of the target who has the original item using it—or even hearing or reading about it—works too.",
                "If a particular power to be duplicated requires a higher rank than the character’s rank, the character must make a Challenging Ego check to be able to use it. They have trouble for every rank they would need to meet the rank requirement. For example, if they are Rank 2 and wish to copy a power with a Rank 4 prerequisite, they have double trouble.",
                "This power set can be tricky for players. The character can sometimes feel like they’re not terribly unique, as they must rely on access to other characters. They’re great for building redundancy into a team, though, and for amping up powers for climactic moments."
            ]
        },
        new()
        {
            Name = PowerSetNames.RangedWeapons,
            Description =
            [
                "The Ranged Weapons power set covers all sorts of di­ erent things that characters can do with ranged weapons. This applies to fi rearms, obviously, but also to archery, thrown knives and other means of ranged attacks. When using this power set, the character should try to choose powers that fit well with their chosen weaponry, whatever it might happen to be.",
                "Those who select any power from this set get at least one ranged weapon to use with it. They can focus on using one kind of ranged weapon or switch it up as they like.",
                "This is a power set that anyone can use, including those with the Special Training origin. Note that few Marvel heroes use lethal ranged weapons, as heroes abhor killing. However, many villains make of use this power set, particularly lowrank hirelings.",
            ]
        },
        new()
        {
            Name = PowerSetNames.Resize,
            Description =
            [
                "The Resize power set allows characters to grow and shrink dramatically at will. The most common way for this to happen in the Marvel Multiverse is by use of Pym Particles, named after the scientist who discovered and developed them: Hank Pym (Ant-Man, Goliath, Yellowjacket and so on). When using Pym Particles to shrink, a character’s extra mass is displaced into a pocket dimension. Because of this, the character retains many of the same qualities they have at their full size, like their strength and durability.",
                "Pym Particles are usually stored and dispensed to the character via a mask or kit, which gives them the Tech Reliance trait. However, after repeated exposure to Pym Particles the bodies of some characters begin to produce them spontaneously, removing that trait. When creating a character, you can pick which way you’d like to go, but higher-rank characters are more likely to go without the Tech Reliance trait than lower-rank ones",
                "The Resize E­ ects table shows which powers it takes to achieve various sizes. It also shows the modifi er to the character’s Melee and Agility defenses at that size, the damage multiplier the character gets to add to their Melee attacks at that size, and the e­ ect their size has on many other things.",
                "The defense modifi er can also be applied to other checks where size makes a di­ erence, like someone trying to spot the character while they’re sneaking or hiding. If the character is tiny size, for example, they add the +3 defense modifier to their Agility defense when people try to spot them.",
                "Damage multiplier bonuses from size do not stack with other damage multiplier bonuses. Apply the biggest modifier instead.",
                "For simplicity’s sake, don’t worry about resized characters’ relative sizes, like a gigantic-size character versus a miniature-size character. Just apply their regular defense modifi ers and damage multipliers as listed.",
                "Apply a character’s size multiplier to their reach, the number of spaces they occupy, their speed and their throwing ranges (as shown on the Objects & Sizes table at the end of Chapter 4). A character that is little-size or smaller doesn’t occupy a full space. Because of that, they can share a space with other creatures. In fact, if they want to make a close attack, they must be in the same space with their target, as they cannot reach outside of it.",
                "The number of spaces a character occupies is the length in spaces on each side of the cube they occupy. A huge-size character, for instance, occupies a cube that is 5 spaces on a side. Characters can come in di­fferent proportions, of course, and the Narrator should make adjustments for ones that are longer, taller and so on.",
            ]
        },
        new()
        {
            Name = PowerSetNames.ShieldBearer,
            Description =
            [
                "This is a power set that anyone can use, including characters with the Special Training origin. However, this isn’t too common, as the Shield Bearer power set is clearly meant for Captain America—in almost all of the character’s di­ erent varieties. Other characters have used similar shields, though, ranging from U.S.Agent to Taskmaster.",
                "Those who select any power from this set get a shield to use with it. When selecting this power set, take some time to describe the shield the character uses. What shape is it? What color or colors? Does it have a design or some kind of symbol on it? If so, what do those things mean?",
                "The shield should be iconic, something that others can use to identify the character immediately. However, it’s possible that the character isn’t entirely aware of all of the shield’s symbolism—which a crafty Narrator might be able to make use of later.",
            ]
        },
        new()
        {
            Name = PowerSetNames.SixthSense,
            Description =
            [
                "This power set covers the knowledge of things that have already happened, are currently happening or will happen at some point in the future. This can range from the content of someone’s DNA all the way up to the death of a star on the far side of a galaxy. It also can help you figure out what happened in a particular place or—perhaps more importantly—what’s likely to happen in the near future.",
                "If possible, the Narrator and the player should work out a way to communicate such information secretly. This could be as simple as passing notes back and forth or sending private messages electronically. This way the player can decide what to do with the knowledge their power grants them, including if and when to reveal it.",
                "Characters don’t have to tell the other members of their team the truth about what’s going to happen. After they establish proof of their power, they can use that earned trust however they like.",
                "Tinkering with visions of the future is always fraught with challenges. Any future events that a character sees or knows about are not set in stone. They present only the most likely outcome. Characters can try to prevent these events from coming about, although they might not succeed. In fact, their attempts might unintentionally cause the feared events to happen."
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerSetNames.SpiderPowers,
            Description =
            [
                "The Spider-Powers power set is meant for characters like Spider-Man (in all his variations) and related spider-type characters. If the character would likely be part of the next Spider-Verse event, then they should probably have some of these powers.",
                "Note that few characters have all of the powers in this set. There are lots of them, and that gives room for plenty of variation even among spiderlike characters.",
                "Webbing appears as a part of many of these powers. Breaking free from webbing requires a Melee check (target number 20). Characters paralyzed by webbing can try to break it as a reaction right after being paralyzed by it—assuming they still have a reaction left that round.",
            ]
        },
        new()
        {
            Name = PowerSetNames.SuperSpeed,
            Description =
            [
                "The Super-Speed power set is meant for speedsters like Quicksilver, but other characters can make use of it too. Players and Narrators should take care with this power set, as it can easily become overpowered. A more r ealistic version o f many o f the powers might allow such characters to finish battles before they started.",
            ]
        },
        new()
        {
            Name = PowerSetNames.SuperStrength,
            Description =
            [
                "Super-strength is a fairly common kind of power among super heroes. That’s why the Mighty powers—which represent raw strength—aren’t part o f t his p ower s et but a re i nstead b asic powers. The Super-Strength power set is more about the kinds of things that characters can pull o­ when they have amazing strength, so if you want your character to be able to manage these things, be sure to line up some of those Mighty powers too.",
            ]
        },
        new()
        {
            Name = PowerSetNames.Tactics,
            Description =
            [
                "The Tactics power set is less about super-powers and more about having the ability to lead people who have such powers. Characters that focus on this power set are best o­ leading a decent-sized team of super heroes, as that’s when their leadership skills can really shine. They might not be the ones who land the winning blows, but they are often the ones who help set it up.",
                "This is a power set that any character can have, even those with the Special Training origin. If you want such a character to shine, picking a few of these powers can help make them feel like an integral part of the team."
            ]
        },
        new()
        {
            Name = PowerSetNames.Telekinesis,
            Description =
            [
                "Telekinesis is one of the two power sets that relies on Logic. The other is Telepathy, just below. With it, the character uses the power of their mind to physically a­ ect things in the world.",
                "This is related—although not identical—to how characters manipulate things with Elemental Control. That is an e­ ort of will (Ego), though, and telekinesis (sometimes abbreviated as TK) is an e­ ort of the mind (Logic)."
            ]
        },
        new()
        {
            Name = PowerSetNames.Telepathy,
            Description =
            [
                "Telepathy is one of the two power sets that relies on Logic. The other is Telekinesis, right above. With it, the character uses their mind to a­ ect the minds of those around them. They can read thoughts, wipe memories and more.",
                "To see through a telepathic mirage of any kind requires a Logic check made against the Logic defense of the character who created the mirage. If the check succeeds, the character sees through the mirage. If they communicate this to others a­ ected by the mirage, those characters get an edge on any Logic check to see through the mirage as well. On a Fantastic success on any such Logic check, the mirage ends.",
                "While all heroes need to pay attention to acting ethically, that’s even more important with a character who uses Telepathy. It’s far too easy to use it to do awful and invasive things, even for admirable ends."
            ]
        },
        new()
        {
            Name = PowerSetNames.Teleportation,
            Description =
            [
                "Whereas Omniversal Travel moves characters between universes, dimensions and even time, Teleportation moves them from place to place instead. This can gain the character quick entry to places that are normally shut o­ to others, so their players must take care with them.",
                "Conversely, Narrators must take teleportation into account when designing encounters. When a character can simply teleport past physical fortifi cations, there should be other means to keep them from stampeding wherever they wish. The main deterrent, of course, is that characters that teleport blindly into places run the risk of teleporting into solid matter, which can be painful and potentially fatal.",
            ]
        },
        new()
        {
            Name = PowerSetNames.Translation,
            Description =
            [
                "With this power set, a character can understand and translate different forms of communication, written, spoken or otherwise. This can include languages of all kinds but also raw data, body language, facial expressions and more. They can also break codes and other sorts of encryption.",
                "This power set might not seem all that important when the character is in the middle of a battle, but when it comes to diplomacy and helping people (even sentient islands like Krakoa) understand each other, it’s invaluable. Cypher is the ultimate example of a character with these powers.",
                "If a character fails a translation check, they can attempt it again either after one day or after a full hour of dedicated study.",
            ],
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = PowerSetNames.WeatherControl,
            Description =
            [
                "Many of the power sets are directly useful in combat, but that’s not generally so with Weather Control. While it can help with such things, this power set is more about establishing credentials and a­ ecting things on a larger scale than a single skirmish. This power set requires Ego to manipulate things, so be sure to focus on that with the character’s abilities as well. Keep in mind also that Weather Control matches up well with Elemental Control powers that a­ffect air and lightning.",
            ]
        },
    ];
}
