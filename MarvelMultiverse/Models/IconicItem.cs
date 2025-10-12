using System.Text.Json.Serialization;

namespace MarvelMultiverse.Models;

public class IconicItem
{
    public IconicItem()
    {
        GrantedPowerReminders = [];
    }

    public bool IsBattlesuit { get; set; }

    public string Name { get; set; }

    public List<IconicItemPower> Powers { get; set; }


    public List<Power> GrantedPowerReminders { get; set; }

    public List<string> Restrictions { get; set; }

    public int PowerValue { get; set; }

    public string PowerValueReminder { get; set; }

    public bool IsMagicItem { get; set; }

    public bool IsTech { get; set; }

    [JsonIgnore]
    public int MeleeDamageModifier { get; set; }

    [JsonIgnore]
    public int AgilityDamageModifier { get; set; }
}
