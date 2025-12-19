using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class LawfulGoodAlignment : AlignmentModel
{
    public LawfulGoodAlignment(GameSystemModel gameSystem)
    {
        Name = "Leal e Bom";
        Description = "É a tendência de criaturas que se pode contar para fazer o que é correto como é " +
            "esperado pela sociedade. Dragões dourados, paladinos e muitos anões são leais e bons.";

        GameSystem = gameSystem;
    }
}