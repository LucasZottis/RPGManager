namespace RPGManager.Desktop.Test.Integration.Models.CurrencyTypes;

[DictionaryKey( CurrencyTypeKey.COPPER )]
public class Copper : CurrencyTypeModel
{
    public Copper( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Cobre";
        Abbreviation = "pc";
    }
}