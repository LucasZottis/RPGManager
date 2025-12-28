



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.GNOMISH )]
public class GnomishLanguage : LanguageModel
{
    public GnomishLanguage( Dictionaries rules )
    {
        Name = "Gnômico";
        Alphabet = "Anão";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}
