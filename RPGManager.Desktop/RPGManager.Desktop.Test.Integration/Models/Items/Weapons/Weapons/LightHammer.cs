namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.LIGHT_HAMMER )]
public class LightHammer : WeaponModel
{
    public LightHammer( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Martelo Leve";
        Description = null;
        Price = 2m;
        Weight = 1;
        RangeNormal = 6;
        RangeLong = 18;

        Damages =
        [
            new WeaponDamageModel {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.BLUDGEONING).Id,
                DamageDieCount = 1,
                DamageDieType = 4,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.LIGHT),
            rules.WeaponProperty.Get(WeaponPropertyKey.THROWN),
        ];
    }
}