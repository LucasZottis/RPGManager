namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.PIKE )]
public class Pike : WeaponModel
{
    public Pike( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Lança longa";
        Description = null;
        Cost = 5m;
        Weight = 4;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.PIERCING ).Id,
                DamageDieCount = 1,
                DamageDieType = 10,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.HEAVY ),
            rules.WeaponProperty.Get( WeaponPropertyKey.REACH ),
rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED )
        ];
    }
}