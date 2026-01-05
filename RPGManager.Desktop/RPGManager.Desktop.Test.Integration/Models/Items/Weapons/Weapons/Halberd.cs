namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.HALBERD )]
public class Halberd : WeaponModel
{
    public Halberd( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Alabarda";
        Description = null;
        Price = 20m;
        Weight = 3;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.SLASHING ).Id,
                DamageDieCount = 1,
                DamageDieType = 10,
            }
        ];

        Properties =
        [
rules.WeaponProperty.Get( WeaponPropertyKey.HEAVY ),
rules.WeaponProperty.Get( WeaponPropertyKey.REACH ),
rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED ),
        ];
    }
}