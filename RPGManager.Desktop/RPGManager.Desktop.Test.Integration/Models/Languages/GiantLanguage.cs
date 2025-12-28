



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.GIANT )]
public class GiantLanguage : LanguageModel
{
    public GiantLanguage( Dictionaries rules )
    {
        Name = "Gigante";
        Alphabet = "Anão";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}