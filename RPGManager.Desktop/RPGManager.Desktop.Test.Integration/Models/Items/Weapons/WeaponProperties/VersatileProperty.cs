namespace RPGManager.Desktop.Test.Integration.Models.Items.Weapons.WeaponProperties;

[DictionaryKey( WeaponPropertyKey.VERSATILE )]
public class VersatileProperty : WeaponPropertyModel
{
    public VersatileProperty(Dictionaries rules)
    {
        Name = "Versátil";
        Description = "Essa arma pode ser usada com uma ou duas mãos. " +
            "Um valor de dano aparece entre parênteses com a propriedade " +
            "– é o dano da arma quando usada com as duas mãos para efetuar ataques corpo-a-corpo.";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        HasAlternativeDamage = true;
    }
}