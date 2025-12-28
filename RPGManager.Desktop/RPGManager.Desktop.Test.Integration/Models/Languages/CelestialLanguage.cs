namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.CELESTIAL )]
public class CelestialLanguage : LanguageModel
{
    public CelestialLanguage( Dictionaries rules )
    {
        Name = "Celestial";
        Alphabet = "Celestial";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}