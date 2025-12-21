using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class RangeProperty : WeaponPropertyModel
{
    public RangeProperty()
    {
        Name = "Distância";
        Description = "Uma arma que pode ser usada para realizar ataques à distância possui a distância mostrada entre parênteses após a propriedade munição ou arremesso. " +
            "A distância lista dois números. O primeiro é a distância normal da arma, o segundo indica a distância máxima da arma, ambos em metros. " +
            "Quando atacar um alvo que está além da distância normal da arma, você possui desvantagem na jogada de ataque. " +
            "Você não pode atacar um alvo que esteja além da distância máxima da arma.";
    }
}