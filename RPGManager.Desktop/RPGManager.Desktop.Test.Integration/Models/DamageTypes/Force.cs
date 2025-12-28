namespace RPGManager.Desktop.Test.Integration.Models.DamageTypes;

[DictionaryKey( DamageTypeKeys.FORCE )]
public class Force : DamageTypeModel
{
    public Force(Dictionaries rules)
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Força";
    }
}