namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.FINESSE )]
public class FinesseProperty : WeaponPropertyModel
{
    public FinesseProperty(Dictionaries rules)
    {
        Name = "Acuidade";
        Description = "Quando realizar um ataque com uma arma com a propriedade acuidade, " +
            "você pode escolher usar seu modificador de Força ou de Destreza para realizar " +
            "a jogada de ataque e de dano. Você precisa usar o mesmo modificador para ambas " +
            "as jogadas, ataque e dano.";

        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        //AllowsAttributeOverride = true;
    }
}