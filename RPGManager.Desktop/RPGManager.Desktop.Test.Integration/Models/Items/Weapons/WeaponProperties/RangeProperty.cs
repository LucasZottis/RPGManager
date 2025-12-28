namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.RANGE )]
public class RangeProperty : WeaponPropertyModel
{
    public RangeProperty(Dictionaries rules)
    {
        Name = "Distância";
        Description = "Uma arma que pode ser usada para realizar ataques à distância possui a distância mostrada entre parênteses após a propriedade munição ou arremesso. " +
            "A distância lista dois números. O primeiro é a distância normal da arma, o segundo indica a distância máxima da arma, ambos em metros. " +
            "Quando atacar um alvo que está além da distância normal da arma, você possui desvantagem na jogada de ataque. " +
            "Você não pode atacar um alvo que esteja além da distância máxima da arma.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}