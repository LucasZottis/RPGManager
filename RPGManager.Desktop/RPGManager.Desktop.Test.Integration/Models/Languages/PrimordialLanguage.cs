



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.PRIMORDIAL )]
public class PrimordialLanguage : LanguageModel
{
    public PrimordialLanguage( Dictionaries rules )
    {
        Name = "Primordial";
        Alphabet = "Dracônico";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}