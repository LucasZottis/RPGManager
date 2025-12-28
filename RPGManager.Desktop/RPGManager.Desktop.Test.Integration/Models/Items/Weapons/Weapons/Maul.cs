namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.MAUL )]
public class Maul : WeaponModel
{
    public Maul( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Malho";
        Description = null;
        Cost = 10m;
        Weight = 5;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.BLUDGEONING ).Id,
                DamageDieCount = 2,
                DamageDieType = 6,
            }
        ];

        Properties =
        [
rules.WeaponProperty.Get( WeaponPropertyKey.HEAVY ),
rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED )
        ];
    }
}