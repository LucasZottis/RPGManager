namespace RPGManager.Desktop.Test.Integration.Models.CurrencyTypes;

[DictionaryKey( CurrencyTypeKey.SILVER )]
public class Silver : CurrencyTypeModel
{
    public Silver( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Prata";
        Abbreviation = "pp";
    }
}