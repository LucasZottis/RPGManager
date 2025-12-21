using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class ChaoticGoodAlignment : AlignmentModel
{
    public ChaoticGoodAlignment( GameSystemRules rules )
    {
        Name = "Caótico e Bom";
        Description = "É a tendência de criaturas que agem de acordo com sua própria consciência, se " +
            "importando pouco com as expectativas dos outros. Dragões de cobre, muitos elfos " +
            "e unicórnios são caóticos e bons.";

        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}