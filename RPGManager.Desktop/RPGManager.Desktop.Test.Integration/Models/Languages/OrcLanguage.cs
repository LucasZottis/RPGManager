



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.ORC )]
public class OrcLanguage : LanguageModel
{
    public OrcLanguage( Dictionaries rules )
    {
        Name = "Orc";
        Alphabet = "Anão";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}