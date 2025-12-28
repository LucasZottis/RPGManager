namespace RPGManager.Desktop.Test.Integration.Models.Items.Armor.ArmorCategories;

public class HeavyArmor : ArmorCategoryModel
{
    public HeavyArmor( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Name = "Armadura Pesada";
        Description = "De todas as categorias de armaduras, as armaduras pesadas oferecem a melhor proteção. " +
            "Essas armaduras cobrem todo o corpo e são projetadas para proteger quem as usa de uma grande variedade de ataques. " +
            "Só guerreiros proficientes podem gerir o seu peso e volume. Armaduras pesadas não permitem que o usuário adicione " +
            "seu modificador de Destreza na Classe de Armadura, mas também não o penaliza se seu modificador de Destreza for " +
            "negativo.";
    }
}