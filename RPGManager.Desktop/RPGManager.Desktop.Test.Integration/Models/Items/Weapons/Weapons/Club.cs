namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.Weapons;

[DictionaryKey( WeaponKey.CLUB )]
public class Club : WeaponModel
{
    public Club( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        WeaponCategoryId = rules.WeaponCategories.Get( WeaponCategoryKeys.SIMPLE ).Id;
        WeaponTypeId = rules.WeaponTypes.Get( WeaponTypeKeys.MELEE ).Id;
        BaseAbilityScoreId = rules.Abilities.Get( AbilityScoreKeys.STRENGTH ).Id;
        AlternativeAbilityScoreId = null;
        CurrencyTypeId = rules.CurrencyTypes.Get( CurrencyTypeKey.SILVER ).Id;
        Name = "Porrete";
        Description = null;
        Cost = 1m;
        Weight = 1;
        RangeNormal = null;
        RangeLong = null;

        Damages =
        [
            new WeaponDamageModel() {
                DamageTypeId = rules.DamageTypes.Get(DamageTypeKeys.BLUDGEONING).Id,
                DamageDieCount = 1,
                DamageDieType = 4,
            },
        ];

        Properties =
        [
            rules.WeaponProperty.Get(WeaponPropertyKey.LIGHT),
        ];
    }
}