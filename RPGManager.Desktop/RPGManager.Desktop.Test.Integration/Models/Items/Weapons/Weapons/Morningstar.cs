namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.MORNINGSTAR )]
public class Morningstar : WeaponModel
{
    public Morningstar( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Maça-estrela";
        Description = null;
        Cost = 15m;
        Weight = 2;
        RangeNormal = null;
        RangeLong = null;

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
        ];
    }
}