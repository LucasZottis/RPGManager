namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.SPECIAL )]
public class SpecialProperty : WeaponPropertyModel
{
    public SpecialProperty(Dictionaries rules)
    {
        Name = "Especial";
        Description = "Uma arma com a propriedade especial possui regras diferenciadas que detalham seu uso, explicado na descrição da arma";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}