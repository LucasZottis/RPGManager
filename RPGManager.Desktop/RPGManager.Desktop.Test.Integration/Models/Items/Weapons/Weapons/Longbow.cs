namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.LONGBOW )]
public class Longbow : WeaponModel
{
    public Longbow( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.RANGED ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Arco longo";
        Description = null;
        Cost = 50m;
        Weight = 1;
        RangeNormal = 45;
        RangeLong = 180;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.PIERCING ).Id,
                DamageDieCount = 1,
                DamageDieType = 8,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.AMMUNITION ),
            rules.WeaponProperty.Get( WeaponPropertyKey.HEAVY ),
rules.WeaponProperty.Get( WeaponPropertyKey.TWO_HANDED ),
        ];
    }
}