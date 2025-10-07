using MarvelMultiverse.Constants;

namespace MarvelMultiverse.Models;

public class NarrativePower : ICloneable
{
    public NarrativePower()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

	public List<string> Effect { get; set; }

    public string Examples { get; set; }

    public string Source { get; set; }

	public object Clone()
	{
		return new NarrativePower
		{
			Name = this.Name,
			Effect = [.. this.Effect],
			Examples = this.Examples,
			Source = this.Source
		};
	}
}
