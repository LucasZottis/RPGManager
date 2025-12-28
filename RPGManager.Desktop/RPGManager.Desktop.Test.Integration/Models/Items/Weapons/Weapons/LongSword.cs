namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.LONGSWORD )]
public class LongSword : WeaponModel
{
    public LongSword( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Espada longa";
        Description = null;
        Cost = 15m;
        Weight = 1.5f;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.SLASHING ).Id,
                DamageDieCount = 1,
                DamageDieType = 8,
                AlternativeDamageDieCount = 1,
                AlternativeDamageDieType = 10
            },
        ];

        Properties =
        [
rules.WeaponProperty.Get( WeaponPropertyKey.VERSATILE )
        ];
    }
}