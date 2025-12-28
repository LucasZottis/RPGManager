namespace RPGManager.Desktop.Test.Integration.Models.DamageTypes;

[DictionaryKey( DamageTypeKeys.LIGHTNING )]
public class Lightning : DamageTypeModel
{
    public Lightning( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Elétrico";
    }
}