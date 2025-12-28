namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.DART )]
public class Dart : WeaponModel
{
    public Dart( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.COPPER ).Id;

        Name = "Dardo";
        Description = null;
        Cost = 5m;
        Weight = 0.25f;
        RangeNormal = 6;
        RangeLong = 18;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.PIERCING ).Id,
                DamageDieCount = 1,
                DamageDieType = 4,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.FINESSE),
            rules.WeaponProperty.Get( WeaponPropertyKey.THROWN ),
        ];
    }
}