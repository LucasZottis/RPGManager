namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponTypes;

[DictionaryKey( WeaponTypeKeys.RANGED )]
public class RangedWeaponType : WeaponTypeModel
{
    public RangedWeaponType(Dictionaries rules)
    {
        Name = "À distância";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}