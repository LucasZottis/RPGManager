using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class TwoHandedProperty : WeaponPropertyModel
{
    public TwoHandedProperty()
    {
        Name = "Duas Mãos";
        Description = "Essa arma requer as duas mãos para ser usada. Essa propriedade só é relevante quando você ataca com a arma, não enquanto apenas a segura.";
    }
}