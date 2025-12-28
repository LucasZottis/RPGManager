namespace RPGManager.Desktop.Test.Integration.Models.Items.Armor.ArmorCategories;

public class LightArmor : ArmorCategoryModel
{
    public LightArmor( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Armadura Leve";
        Description = "Feitas a partir de materiais flexíveis e finos, armaduras leves favorecem aventureiros ágeis, " +
            "uma vez que oferecem alguma proteção sem sacrificar sua mobilidade. Se você vestir uma armadura leve, ele " +
            "adiciona seu modificador de Destreza ao número base de seu tipo de armadura para determinar sua Classe de Armadura.";
    }
}