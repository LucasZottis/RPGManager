namespace RPGManager.Desktop.Test.Integration.Models.DamageTypes;

[DictionaryKey( DamageTypeKeys.COLD )]
public class Cold : DamageTypeModel
{
    public Cold( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Cold";
    }
}