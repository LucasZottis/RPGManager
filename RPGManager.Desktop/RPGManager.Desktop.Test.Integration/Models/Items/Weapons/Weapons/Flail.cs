namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.FLAIL )]
public class Flail : WeaponModel
{
    public Flail( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Mangual";
        Description = null;
        Cost = 10m;
        Weight = 1;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.BLUDGEONING ).Id,
                DamageDieCount = 1,
                DamageDieType = 8,
            }
        ];

        Properties =
        [
        ];
    }
}