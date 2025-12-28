namespace RPGManager.Desktop.Test.Integration.Models.CurrencyTypes;

[DictionaryKey( CurrencyTypeKey.ELECTRUM )]
public class Electrum : CurrencyTypeModel
{
    public Electrum(Dictionaries rules)
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Electrum";
        Abbreviation = "pe";
    }
}