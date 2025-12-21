using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class SpecialProperty : WeaponPropertyModel
{
    public SpecialProperty()
    {
        Name = "Especial";
        Description = "Uma arma com a propriedade especial possui regras diferenciadas que detalham seu uso, explicado na descrição da arma";
    }
}