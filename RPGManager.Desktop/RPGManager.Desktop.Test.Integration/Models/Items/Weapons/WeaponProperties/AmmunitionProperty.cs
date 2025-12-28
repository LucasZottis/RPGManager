namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.AMMUNITION )]
public class AmmunitionProperty : WeaponPropertyModel
{
    public AmmunitionProperty(Dictionaries rules)
    {
        Name = "Munição";
        Description = "Você pode usar uma arma que tenha a propriedade munição para realizar um ataque à distância, " +
            "apenas se possuir munição para disparar a arma. Cada vez que você atacar com a arma, você gasta uma peça " +
            "de munição. Sacar a munição de uma aljava, bolsa, ou outro recipiente faz parte do ataque. No fim da batalha, " +
            "você pode recuperar metade de sua munição gasta, se tiver um minuto para procurar pelo campo de batalha. " +
            "Recarregar uma arma de uma mão requer uma mão livre.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}