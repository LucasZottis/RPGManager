using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class ChaoticNeutralAlignment : AlignmentModel
{
    public ChaoticNeutralAlignment(GameSystemModel gameSystem)
    {
        Name = "Caótico e Neutro";
        Description = "É a tendência das criaturas que seguem seus caprichos, mantendo sua liberdade pessoal acima de tudo. Muitos bárbaros e ladinos, e alguns bardos, são caóticos e neutros.";
        GameSystem = gameSystem;
    }
}