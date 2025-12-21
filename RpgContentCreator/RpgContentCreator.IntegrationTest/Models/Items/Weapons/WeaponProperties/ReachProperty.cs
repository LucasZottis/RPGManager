using RpgContentCreator.Domain.Models.Items.Weapons;
using System.Xml.Linq;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class ReachProperty : WeaponPropertyModel
{
    public ReachProperty()
    {
        Name = "Alcance";
        Description = "Essa arma adiciona 1,5 metro ao seu alcance quando você a usa para atacar. " +
            "Essa propriedade também determina seu alcance ao realizar ataques de oportunidade com uma arma de alcance.";
    }
}
