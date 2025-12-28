



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.ABYSSAL )]
public class AbyssalLanguage : LanguageModel
{
    public AbyssalLanguage( Dictionaries rules )
    {
        Name = "Abissal";
        Alphabet = "Infernal";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}