



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.SYLVAN )]
public class SylvanLanguage : LanguageModel
{
    public SylvanLanguage( Dictionaries rules )
    {
        Name = "Silvestre";
        Alphabet = "Élfico";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}