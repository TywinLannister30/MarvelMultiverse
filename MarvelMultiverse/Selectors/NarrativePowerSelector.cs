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
    ];
}
