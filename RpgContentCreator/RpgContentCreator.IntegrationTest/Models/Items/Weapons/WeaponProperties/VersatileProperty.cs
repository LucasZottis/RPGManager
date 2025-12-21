using RpgContentCreator.Domain.Models.Items.Weapons;

namespace RpgContentCreator.IntegrationTest.Models.Items.Weapons.WeaponProperties;

public class VersatileProperty : WeaponPropertyModel
{
    public VersatileProperty()
    {
        Name = "Versátil";
        Description = "Essa arma pode ser usada com uma ou duas mãos. " +
            "Um valor de dano aparece entre parênteses com a propriedade " +
            "– é o dano da arma quando usada com as duas mãos para efetuar ataques corpo-a-corpo.";

        HasAlternativeDamage = true;
    }
}