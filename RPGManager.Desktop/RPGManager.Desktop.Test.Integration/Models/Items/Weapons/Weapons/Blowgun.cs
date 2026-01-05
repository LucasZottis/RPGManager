namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.BLOWGUN )]
public class Blowgun : WeaponModel
{
    public Blowgun( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Zarabatana";
        Description = null;
        Price = 10m;
        Weight = 0.5f;
        RangeNormal = 7.5f;
        RangeLong = 30;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.PIERCING ).Id,
                DamageDieCount = 1,
                DamageDieType = 1,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.AMMUNITION ),
            rules.WeaponProperty.Get( WeaponPropertyKey.LOADING ),
        ];
    }
}