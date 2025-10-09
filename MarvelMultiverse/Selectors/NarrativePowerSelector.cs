using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class NarrativePowerSelector : INarrativePowerSelector
{
	public NarrativePower GetNarrativePower(string name, string reminder = null)
	{
		var staticPower = GetAllNarrativePowers().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

		var power = staticPower.Clone() as NarrativePower;

		if (!string.IsNullOrEmpty(reminder))
		{
			power.Name += $" ({reminder})";
		}

		return power;
	}

	public List<NarrativePower> GetNarrativePowers()
    {
        return GetAllNarrativePowers();
    }

    private static List<NarrativePower> GetAllNarrativePowers() =>
    [
        new()
        {
            Name = NarrativePowerNames.CannotLose,
            Effect =
            [
                "The character cannot lose any challenge or contest in which they participate. This is not the same as winning, so if there is a possibility that they neither win nor lose, that satisfies the conditions of not losing.",
                "The character must be careful about picking sides in any conflict. Their influence means the side they pick is the one most likely to prevail. However, their power may also compel them to switch sides so they don’t lose, even if that’s not how they would prefer events to transpire. This prevents the character from simply choosing a winner in any conflict.",
                "The character cannot shut off this power, so it can sometimes feel more like a curse than a blessing."
            ],
            Examples = "Isca the Unbeaten",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = NarrativePowerNames.DNAManipulation,
            Effect =
            [
                "The character is able to identify, copy and manipulate DNA in themselves and others. They can use this to create a body from scratch that they can then occupy by using the Copy Psyche power.",
                "In addition, the character can cause latent mutant powers to manifest upon command, both in their own body and in that of others.",
                "They can also copy DNA from other people and insert it into their body to fool security systems into thinking that they are members of a particular genetic group or family line."
            ],
            Examples = "Cassandra Nova",
            Source = BookSource.XMenExpansion
        },
		new()
		{
			Name = NarrativePowerNames.DuplicateSelf,
			Effect =
			[
				"With this power the character can make copies of themself. The duplicates are full-fledged, identical copies of the original person, including all of their current clothing. They are indistinguishable from the original, right down to the genetic level.",
				"The number of duplicates a character can have is theoretically unlimited. As a practical matter, though, characters with this power prefer to keep track of their duplicates and don’t go to outrageous lengths with their numbers.",
				"While duplicates generally take orders from the character, they are independent people who may balk at doing things they would find painful or distasteful. Often, a duplicate highlights an aspect of the character’s personality, for good or bad, so they may act differently than the original would.",
				"There is no limit to the amount of time a duplicate can exist. They can operate entirely independently and can even have their own adventures throughout the Multiverse.",
				"The character has no direct control over their duplicates. They can generally trust them to work together, help the character and execute the character’s plans, but there can be exceptions. The character and the duplicates always know who the original character is, although others may have a hard time telling them apart.",
				"The character can absorb their duplicates back into their body. If the character or the duplicate has lost Health or Focus points, the original winds up with the average of their numbers when they absorb the duplicate. Absorbing injured duplicates can harm the character, but the converse is also true. Absorbing healthy duplicates can heal the character.",
				"When the character absorbs a duplicate, they gain all of the duplicate’s memories. This includes any tags the duplicate may have gained on their own. In the case of conflicting tags, the character’s tags normally take precedence over the duplicate’s, although it’s up to the Narrator to determine exactly how. On top of that, the character might have to deal with the consequences of their duplicate’s actions, for good or ill.",
				"The character cannot absorb the memories of a dead duplicate. Attempting to do so only traumatizes the character, knocking them down to 1 Focus.",
				"The duplicates can also make duplicates, but only the original character can absorb any of the duplicates, no matter their source. Duplicates usually don’t mind being absorbed, but some rare ones may refuse to go quietly and may even harbor deep resentment against the character and wish to harm them.",
				"Characters with this power have a trigger that activates it. When the trigger happens—and only when the trigger happens—the power automatically activates, whether they wish it to or not.",
				"Similarly, they must define their trigger to absorb duplicates. When this trigger happens, they must absorb the affected duplicate, whether they wish to or not.",
			],
			Examples = "Multiple Man",
			Source = BookSource.XMenExpansion
		},
		new()
        {
            Name = NarrativePowerNames.InstantEvolution,
            Effect =
            [
                "The character instantly adapts to any threats against them. They develop new powers or abilities that can protect them from the threat. However, they don’t have direct control over how this happens.",
                "For instance, if trapped in a dark room, they develop the ability to see in the dark. If being shot at, their power might give them bulletproof skin, allow them to turn intangible or perhaps break the gun. It’s up to the Narrator how the power works in any specific situation.",
                "The power always serves to save the character, but it doesn’t care about other people nearby, whether innocent bystanders or the character’s best friends. If a bomb is about to go off in a room, for example, this power might make the character bomb-proof or perhaps able to stop the bomb, or it might simply teleport them a safe distance away, leaving everyone else in danger.",
                "Once the specific danger to the character is over, the extra abilities disappear, as they are no longer needed. They never linger, no matter how much the character might want them to."
            ],
            Examples = "Darwin",
            Source = BookSource.XMenExpansion
        },
        new()
        {
            Name = NarrativePowerNames.MagicMasks,
            Effect =
            [
                "The character has a satchel that carries several magic masks that give the wearer the traits, tags and powers associated with that mask, both good and bad. For example, a werewolf mask transforms the character into an actual werewolf.",
                "The character can wear only one mask at a time. Switching between them requires a standard action.",
                "Wearing a mask usually does not change the character’s size, even if the thing they would be like is usually a different size. Powers granted by the mask ignore all prerequisites.",
                "See p.150-151 of the SpiderVerse expansion for a list of known masks",
                "Other masks can be summoned from the satchel as needed. These can allow the character to emulate anything the mask represents.",
                "The character can put the masks on other people. If the character drops any masks, they can be picked up and worn by others too. The character can remove any such masks from another person with a successful Melee attack that does at least 1 point of damage—or if the wearer permits it.",
            ],
            Examples = "Hallows’ Eve",
            Source = BookSource.SpiderverseExpansion
        },
        new()
        {
            Name = NarrativePowerNames.Restart,
            Effect =
            [
                "When the character dies, the entire timeline restarts from the moment of their first consciousness, and they retain the memories from their previous lives. This gives them the chance to start over multiple times, although they have to live through those years in real time.",
                "There may be a limit to the number of times the character can restart, but they might not know it. A character with precognition might be able to tell how many lives are ahead of them—or perhaps just give a range—but there’s no way to know for sure. It could be that they’ll restart their lives indefinitely, or their present life could be their last one.",
                "There’s only so much that one person can do when facing the grand sweep of history, but even one life’s knowledge can give a character a huge advantage for improving their personal situation. It’s easy to build wealth when you know what the future brings.",
                "This power should be used rarely, if at all. If the players go through an entire adventure only to have the timeline get reset out of the blue, they might feel like they’ve been cheated. On the other hand, if the point of an adventure is to reset a timeline to prevent a horrible thing from happening, that could transform it from a rug-pull into a moment of triumph.",
                "The Restart power supposedly demolishes the timeline that the previous life took place in. However, that doesn’t mean the old timelines no longer exist in the Multiverse. Every time a character with this power dies and restarts, there’s a universe out there somewhere in which the character didn’t have the power—or one in which the power finally failed—and such places can be reached by those traveling the Multiverse."
            ],
            Examples = "Moira MacTaggert",
            Source = BookSource.XMenExpansion
        },
    ];
}
