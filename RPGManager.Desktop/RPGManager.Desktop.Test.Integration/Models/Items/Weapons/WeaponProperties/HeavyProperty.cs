namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.HEAVY )]
public class HeavyProperty : WeaponPropertyModel
{
    public HeavyProperty(Dictionaries rules)
    {
        Name = "Pesada";
        Description = "Criaturas pequenas têm desvantagem nas jogadas de ataque com estas armas. " +
            "O tamanho e o peso de uma arma pesada tornam-na muito grande para ser empunhada eficientemente por criaturas Pequenas.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}