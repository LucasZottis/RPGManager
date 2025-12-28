



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.DRACONIC )]
public class DraconicLanguage : LanguageModel
{
    public DraconicLanguage( Dictionaries rules )
    {
        Name = "Dracônico";
        Alphabet = "Dracônico";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}