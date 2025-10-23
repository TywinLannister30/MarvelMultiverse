using MarvelMultiverse.Constants;
using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class IconicItemPower : ICloneable
{
    public IconicItemPower()
    {
        Source = BookSource.Core;
    }

    public string Name { get; set; }

	public List<string> Effect { get; set; }

    [JsonIgnore]
    public bool FlySpeed { get; set; }

    [JsonIgnore]
    public bool SwinglineSpeed { get; set; }

    public Power Power { get; set; }

    public string Source { get; set; }

	public object Clone()
	{
		return new IconicItemPower
        {
			Name = this.Name,
			Effect = [.. this.Effect],
			FlySpeed = this.FlySpeed,
            SwinglineSpeed = this.SwinglineSpeed,
            Power = this.Power,
            Source = this.Source
		};
	}
}
