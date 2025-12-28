namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.TWO_HANDED )]
public class TwoHandedProperty : WeaponPropertyModel
{
    public TwoHandedProperty(Dictionaries rules)
    {
        Name = "Duas Mãos";
        Description = "Essa arma requer as duas mãos para ser usada. Essa propriedade só é relevante quando você ataca com a arma, não enquanto apenas a segura.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}