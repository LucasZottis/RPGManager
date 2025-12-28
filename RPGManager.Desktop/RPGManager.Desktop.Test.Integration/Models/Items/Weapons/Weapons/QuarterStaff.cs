namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.QUARTERSTAFF )]
public class Quarterstaff : WeaponModel
{
    public Quarterstaff( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.SILVER ).Id;
        Name = "Bordão";
        Description = null;
        Cost = 2m;
        Weight = 2;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.BLUDGEONING).Id,
                DamageDieCount = 1,
                DamageDieType = 6,
                AlternativeDamageDieCount = 1,
                AlternativeDamageDieType = 8,
            },
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.VERSATILE)
        ];
    }
}