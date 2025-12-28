namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.MACE )]
public class Mace : WeaponModel
{
    public Mace( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.GOLD ).Id;
        Name = "Maça";
        Description = null;
        Cost = 5m;
        Weight = 2;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.BLUDGEONING).Id,
                DamageDieCount = 1,
                DamageDieType = 6,
            }
        ];
    }
}