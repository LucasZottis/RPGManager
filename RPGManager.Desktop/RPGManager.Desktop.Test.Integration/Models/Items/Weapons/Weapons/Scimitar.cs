namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.SCIMITAR )]
public class Scimitar : WeaponModel
{
    public Scimitar( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.MARTIAL ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.DEXTERITY ).Id;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Cimitarra";
        Description = null;
        Cost = 25m;
        Weight = 1.5f;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel
            {
                DamageTypeId = rules.DamageTypes.Get( DamageTypeKeys.SLASHING ).Id,
                DamageDieCount = 1,
                DamageDieType = 6,
            }
        ];

        Properties =
        [
            rules.WeaponProperty.Get( WeaponPropertyKey.FINESSE ),
            rules.WeaponProperty.Get( WeaponPropertyKey.LIGHT )
        ];
    }
}