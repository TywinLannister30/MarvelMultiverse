namespace MarvelMultiverse.Models;

public class CharacterPowerSet
{

    public string Name { get; set; }

    public List<Power> Powers { get; set; }

    public bool IsTech { get; set; }

    public bool IsMagicItem { get; set; }
}
