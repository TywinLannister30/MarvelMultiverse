namespace MarvelMultiverse.Models;

public class Abilities
{
    public Abilities(int melee, int agility, int resilience, int vigilance, int ego, int logic)
    {
        Melee = new Ability { Score = melee };
        Agility = new Ability { Score = agility };
        Resilience = new Ability { Score = resilience };
        Vigilance = new Ability { Score = vigilance };
        Ego = new Ability { Score = ego };
        Logic = new Ability { Score = logic };
    }

    public Ability Melee { get; set; }

    public Ability Agility { get; set; }

    public Ability Resilience { get; set; }

    public Ability Vigilance { get; set; }

    public Ability Ego { get; set; }

    public Ability Logic { get; set; }
}
