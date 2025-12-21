using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class ThrownProperty : WeaponPropertyModel
{
    public ThrownProperty()
    {
        Name = "Arremesso";
        Description = "Se uma arma possuir a propriedade arremesso, você pode arremessar a arma para realizar um ataque à distância. " +
            "Se essa arma for uma arma de ataque corpo-a-corpo, você usa o mesmo modificador de habilidade para as jogadas de ataque e " +
            "dano que usaria para realizar um ataque corpo-a-corpo com a arma. Por exemplo, se você arremessar uma machadinha, ele usa " +
            "seu modificador de Força, mas se arremessar uma adaga, você pode usar tanto seu modificador de Força quanto o de Destreza, " +
            "pois a adaga possui a propriedade acuidade.";
    }
}