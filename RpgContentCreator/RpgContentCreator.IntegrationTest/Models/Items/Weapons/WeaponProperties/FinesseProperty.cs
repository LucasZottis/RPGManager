using RpgContentCreator.Domain.Models.Items.Weapons;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class FinesseProperty : WeaponPropertyModel
{
    public FinesseProperty()
    {
        Name = "Acuidade";
        Description = "Quando realizar um ataque com uma arma com a propriedade acuidade, " +
            "você pode escolher usar seu modificador de Força ou de Destreza para realizar " +
            "a jogada de ataque e de dano. Você precisa usar o mesmo modificador para ambas " +
            "as jogadas, ataque e dano.";
        //AllowsAttributeOverride = true;
    }
}