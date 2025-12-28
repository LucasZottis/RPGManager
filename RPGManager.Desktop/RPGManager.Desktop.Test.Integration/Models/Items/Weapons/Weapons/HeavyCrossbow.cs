namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.HEAVY_CROSSBOW )]
public class HeavyCrossbow : WeaponModel
{
    public HeavyCrossbow( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Besta pesada";
        Description = null;
        Cost = 50m;
        Weight = 4.5f;
        RangeNormal = 30;
        RangeLong = 120;

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
rules.WeaponProperty.Get( WeaponPropertyKey.AMMUNITION ),
rules.WeaponProperty.Get( WeaponPropertyKey.HEAVY ),
rules.WeaponProperty.Get( WeaponPropertyKey.LOADING ),
rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED ),
        ];
    }
}