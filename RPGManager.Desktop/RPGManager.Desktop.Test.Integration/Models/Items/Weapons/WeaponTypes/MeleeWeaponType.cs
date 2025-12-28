namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponTypes;

[DictionaryKey( WeaponTypeKeys.MELEE )]
public class MeleeWeaponType : WeaponTypeModel
{
    public MeleeWeaponType( Dictionaries rules )
    {
        Name = "Corpo-a-corpo";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}