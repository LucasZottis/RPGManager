



namespace RPGManager.Desktop.Test.Integration.Models.Languages;

[DictionaryKey( LanguageKey.GOBLIN )]
public class GoblinLanguage : LanguageModel
{
    public GoblinLanguage( Dictionaries rules )
    {
        Name = "Goblin";
        Alphabet = "Anão";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}