namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.REACH )]
public class ReachProperty : WeaponPropertyModel
{
    public ReachProperty(Dictionaries rules)
    {
        Name = "Alcance";
        Description = "Essa arma adiciona 1,5 metro ao seu alcance quando você a usa para atacar. " +
            "Essa propriedade também determina seu alcance ao realizar ataques de oportunidade com uma arma de alcance.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}
