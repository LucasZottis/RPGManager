namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.SHORTBOW )]
public class Shortbow : WeaponModel
{
    public Shortbow( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Arco curto";
        Description = null;
        Cost = 25m;
        Weight = 1;
        RangeNormal = 24;
        RangeLong = 96;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.PIERCING ).Id,
                DamageDieCount = 1,
                DamageDieType = 6,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.AMMUNITION ),
            rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED )
        ];
    }
}