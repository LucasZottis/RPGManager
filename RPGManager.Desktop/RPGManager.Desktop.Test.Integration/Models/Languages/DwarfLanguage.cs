



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.DWARF )]
public class DwarfLanguage : LanguageModel
{
    public DwarfLanguage( Dictionaries rules )
    {
        Name = "Anão";
        Alphabet = "Anão";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}