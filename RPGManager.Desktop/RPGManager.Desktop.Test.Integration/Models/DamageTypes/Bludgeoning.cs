namespace RPGManager.Desktop.Test.Integration.Models.DamageTypes;

[DictionaryKey( DamageTypeKeys.BLUDGEONING )]
public class Bludgeoning : DamageTypeModel
{
    public Bludgeoning( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Concussão";
    }
}