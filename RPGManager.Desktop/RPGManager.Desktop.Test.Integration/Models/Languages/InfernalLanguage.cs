



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.INFERNAL )]
public class InfernalLanguage : LanguageModel
{
    public InfernalLanguage( Dictionaries rules )
    {
        Name = "Infernal";
        Alphabet = "Infernal";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}