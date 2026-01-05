namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.HAND_CROSSBOW )]
public class HandCrossbow : WeaponModel
{
    public HandCrossbow( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Besta de mão";
        Description = null;
        Price = 75m;
        Weight = 1.5f;
        RangeNormal = 9;
        RangeLong = 36;

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
rules.WeaponProperty.Get( WeaponPropertyKey.LIGHT ),
rules.WeaponProperty.Get( WeaponPropertyKey.LOADING ),
        ];
    }
}