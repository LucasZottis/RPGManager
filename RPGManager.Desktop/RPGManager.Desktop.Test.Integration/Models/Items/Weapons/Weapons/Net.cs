namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.NET )]
public class Net : WeaponModel
{
    public Net( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Rede";
        Description = null;
        Price = 1m;
        Weight = 1.5f;
        RangeNormal = 1.5f;
        RangeLong = 4.5f;

        Damages = [];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.SPECIAL ),
rules.WeaponProperty.Get( WeaponPropertyKey.THROWN )
        ];
    }
}