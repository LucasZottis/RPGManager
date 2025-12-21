using RpgContentCreator.Domain.Models.Items.Weapons;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class HeavyProperty : WeaponPropertyModel
{
    public HeavyProperty()
    {
        Name = "Pesada";
        Description = "Criaturas pequenas têm desvantagem nas jogadas de ataque com estas armas. " +
            "O tamanho e o peso de uma arma pesada tornam-na muito grande para ser empunhada eficientemente por criaturas Pequenas.";
    }
}