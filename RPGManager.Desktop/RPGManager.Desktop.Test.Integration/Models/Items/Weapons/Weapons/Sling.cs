namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.SLING )]
public class Sling : WeaponModel
{
    public Sling( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.SILVER ).Id;

        Name = "Funda";
        Description = null;
        Price = 1m;
        Weight = 0;
        RangeNormal = 9;
        RangeLong = 36;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.BLUDGEONING ).Id,
                DamageDieCount = 1,
                DamageDieType = 4,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.AMMUNITION )
        ];
    }
}