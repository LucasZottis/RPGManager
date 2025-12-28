namespace RPGManager.Desktop.Test.Integration.Models.DamageTypes;

[DictionaryKey( DamageTypeKeys.RADIANT )]
public class Radiant : DamageTypeModel
{
    public Radiant( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Radiante";
    }
}