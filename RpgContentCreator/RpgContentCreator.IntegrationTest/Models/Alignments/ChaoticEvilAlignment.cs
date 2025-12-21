using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class ChaoticEvilAlignment : AlignmentModel
{
    public ChaoticEvilAlignment( GameSystemRules rules )
    {
        Name = "Caótico e Mau";
        Description = "É a tendência de criaturas que agem com violência arbitrária, estimulada por sua ganância, ódio ou sede de sangue. Demônios, dragões vermelhos e orcs são caóticos e maus.";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}