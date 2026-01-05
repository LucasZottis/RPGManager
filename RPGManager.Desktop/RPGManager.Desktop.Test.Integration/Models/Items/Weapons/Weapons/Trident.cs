namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.TRIDENT )]
public class Trident : WeaponModel
{
    public Trident( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Tridente";
        Description = null;
        Price = 5m;
        Weight = 2;
        RangeNormal = 6;
        RangeLong = 18;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.PIERCING ).Id,
                DamageDieCount = 1,
                DamageDieType = 6,
                AlternativeDamageDieCount = 1,
                AlternativeDamageDieType = 8
            },
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.THROWN ),
            rules.WeaponProperty.Get( WeaponPropertyKey.VERSATILE )
        ];
    }
}