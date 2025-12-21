using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class LoadingProperty : WeaponPropertyModel
{
    public LoadingProperty()
    {
        Name = "Recarga";
        Description = "Devido o tempo necessário para recarregar essa arma, " +
            "você pode disparar apenas uma peça de munição da arma quando usa uma ação, ação bônus, " +
            "ou reação para disparar, não importando quantos ataques você possua.";
    }
}