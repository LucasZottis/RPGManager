namespace RPGManager.Desktop.Test.Integration.Models.CurrencyTypes;

[DictionaryKey( CurrencyTypeKey.PLATINUM )]
public class Platinum : CurrencyTypeModel
{
    public Platinum(Dictionaries rules)
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Platina";
        Abbreviation = "pl";
    }
}