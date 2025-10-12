using MarvelMultiverse.Models;
using MarvelMultiverse.Selectors.Characters;

namespace MarvelMultiverse.Selectors;

public class CharacterSelector(
    IIconicItemPowerSelector iconicItemPowerSelector,
    INarrativePowerSelector narrativePowerSelector,
    IPowerSelector powerSelector,
    ITagSelector tagSelector,
    ITraitSelector traitSelector) : ICharacterSelector
{
    public Character GetCharacter(string name)
    {
        var character = GetAllCharacters().FirstOrDefault(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));

        if (character == null) return null;

        SetUpCharacter(character);

        return character;
    }

    public List<Character> GetCharacters()
    {
        var characters = GetAllCharacters();

        foreach (var character in characters)
        {
            SetUpCharacter(character);
        }

        return characters;
    }

    private static void SetUpCharacter(Character character)
    {
        character.SetDefences();
        character.SetHealth();
        character.SetFocus();
        character.SetKarma();
        character.SetInitiative();
        character.SetSpeed();
        character.SetNonCombatCheckModifiers();
        character.SetDamageModifiers();
    }

    private List<Character> GetAllCharacters()
    {
        var allCharacters = new List<Character>();
        allCharacters.AddRange(Characters0To9.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersA.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersB.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersC.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersD.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersE.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersF.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersG.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersH.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersI.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersJ.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersK.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersL.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersM.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersN.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersO.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersP.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersQ.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersR.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersS.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersT.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersU.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersV.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersW.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersZ.GetAllCharacters(narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        return allCharacters;
    }
}
