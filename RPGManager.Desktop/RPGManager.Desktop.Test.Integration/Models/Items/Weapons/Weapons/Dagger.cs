namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.DAGGER )]
public class Dagger : WeaponModel
{
    public Dagger( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;

        Name = "Adaga";
        Description = null;
        Price = 2m;
        Weight = 0.5f;
        RangeNormal = 6;
        RangeLong = 18;

        Damages =
        [
            new WeaponDamageModel {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.PIERCING).Id,
                DamageDieCount = 1,
                DamageDieType = 4,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.FINESSE),
            rules.WeaponProperty.Get(WeaponPropertyKey.LIGHT),
            rules.WeaponProperty.Get(WeaponPropertyKey.THROWN),
        ];
    }
}
