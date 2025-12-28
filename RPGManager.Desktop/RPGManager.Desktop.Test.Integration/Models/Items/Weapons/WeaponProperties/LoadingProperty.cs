namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.LOADING )]
public class LoadingProperty : WeaponPropertyModel
{
    public LoadingProperty(Dictionaries rules)
    {
        Name = "Recarga";
        Description = "Devido o tempo necessário para recarregar essa arma, " +
            "você pode disparar apenas uma peça de munição da arma quando usa uma ação, ação bônus, " +
            "ou reação para disparar, não importando quantos ataques você possua.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}