namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.JAVELIN )]
public class Javelin : WeaponModel
{
    public Javelin( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.SILVER ).Id;
        Name = "Azagaia";
        Description = null;
        Price = 5m;
        Weight = 1;
        RangeNormal = 9;
        RangeLong = 36;

        Damages =
        [
            new WeaponDamageModel {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.PIERCING).Id,
                DamageDieCount = 1,
                DamageDieType = 6,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.THROWN)
        ];
    }
}