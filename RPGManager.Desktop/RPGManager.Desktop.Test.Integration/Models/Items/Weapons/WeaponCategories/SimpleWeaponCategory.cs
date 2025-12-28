



namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponCategories;

[DictionaryKey( WeaponCategoryKeys.SIMPLE )]
public class SimpleWeaponCategory : WeaponCategoryModel
{
    public SimpleWeaponCategory( Dictionaries rules )
    {
        Name = "Armas Simples";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}