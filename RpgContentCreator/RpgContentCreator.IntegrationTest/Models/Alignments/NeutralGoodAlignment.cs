using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class NeutralGoodAlignment : AlignmentModel
{
    public NeutralGoodAlignment(GameSystemModel gameSystem)
    {
        Name = "Neutro e Bom";
        Description = "É a tendência do povo que faz o melhor que pode para ajudar outros de acordo com suas " +
            "necessidades. Muitos celestiais, alguns gigantes das nuvens, e grande parte dos gnomos " +
            "são neutros e bons.";

        GameSystem = gameSystem;
    }
}