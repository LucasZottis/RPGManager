namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.LIGHT )]
public class LightProperty : WeaponPropertyModel
{
    public LightProperty(Dictionaries rules)
    {
        Name = "Leve";
        Description = "Uma arma leve é pequena e de fácil manuseio, tornando-a ideal para usar quando você está combatendo com duas armas.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}