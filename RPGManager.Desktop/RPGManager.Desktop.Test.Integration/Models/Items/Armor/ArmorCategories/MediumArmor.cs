

namespace RPGManager.Desktop.Test.Integration.Models.Items.Armor.ArmorCategories;

public class MediumArmor : ArmorCategory
{
    public MediumArmor( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Armadura Média";
        Description = "Armaduras médias oferecem mais proteção do que armaduras leves, mas também prejudicam mais o movimento. " +
            "Se o personagem usar uma armadura média, ele adiciona seu modificador de Destreza, até um máximo de 2, ao número base " +
            "de seu tipo de armadura para determinar a sua Classe de Armadura.";
    }
}