namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.GREATCLUB )]
public class GreatClub : WeaponModel
{
    public GreatClub( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.SILVER ).Id;

        Name = "Clava Grande";
        Description = null;
        Cost = 2m;
        Weight = 5;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.BLUDGEONING).Id,
                DamageDieCount = 1,
                DamageDieType = 8,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.TWO_HANDED),
            rules.WeaponProperty.Get(WeaponPropertyKey.HEAVY),
        ];
    }
}
