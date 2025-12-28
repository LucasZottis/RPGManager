namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.THROWN )]
public class ThrownProperty : WeaponPropertyModel
{
    public ThrownProperty(Dictionaries rules)
    {
        Name = "Arremesso";
        Description = "Se uma arma possuir a propriedade arremesso, você pode arremessar a arma para realizar um ataque à distância. " +
            "Se essa arma for uma arma de ataque corpo-a-corpo, você usa o mesmo modificador de habilidade para as jogadas de ataque e " +
            "dano que usaria para realizar um ataque corpo-a-corpo com a arma. Por exemplo, se você arremessar uma machadinha, ele usa " +
            "seu modificador de Força, mas se arremessar uma adaga, você pode usar tanto seu modificador de Força quanto o de Destreza, " +
            "pois a adaga possui a propriedade acuidade.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
    }
}