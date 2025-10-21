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
        character.SetImageUrl();
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
        allCharacters.AddRange(CharactersG.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersH.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersI.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersJ.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersK.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersL.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersM.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersN.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersO.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersP.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersQ.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersR.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersS.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersT.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersU.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersV.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersW.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        allCharacters.AddRange(CharactersZ.GetAllCharacters(iconicItemPowerSelector, narrativePowerSelector, powerSelector, tagSelector, traitSelector));
        return allCharacters;
    }
}
