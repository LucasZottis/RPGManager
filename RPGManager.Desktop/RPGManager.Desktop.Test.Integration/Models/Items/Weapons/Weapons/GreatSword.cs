namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.GREATSWORD )]
public class GreatSword : WeaponModel
{
    public GreatSword( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Espada grande";
        Description = null;
        Price = 50m;
        Weight = 3;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.SLASHING ).Id,
                DamageDieCount = 2,
                DamageDieType = 6,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.HEAVY ),
            rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED ),
        ];
    }
}