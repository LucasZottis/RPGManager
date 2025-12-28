namespace RPGManager.Desktop.Test.Integration.Models.CurrencyTypes;

[DictionaryKey( CurrencyTypeKey.GOLD )]
public class Gold : CurrencyTypeModel
{
    public Gold( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Ouro";
        Abbreviation = "po";
    }
}