



namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponCategories;

[DictionaryKey( WeaponCategoryKeys.MARTIAL )]
public class MartialWeaponCategory : WeaponCategoryModel
{
    public MartialWeaponCategory( Dictionaries rules )
    {
        Name = "Armas Marciais";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}