using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class NarrativePowerSelector : INarrativePowerSelector
{
    public NarrativePower GetNarrativePower(string name)
    {
        return GetAllNarrativePowers().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<NarrativePower> GetNarrativePowers()
    {
        return GetAllNarrativePowers();
    }

    private static List<NarrativePower> GetAllNarrativePowers() =>
    [
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
    ];
}
