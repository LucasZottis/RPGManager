using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class TrueNeutralAlignment : AlignmentModel
{
    public TrueNeutralAlignment( GameSystemRules rules )
    {
        Name = "Neutro";
        Description = "É a tendência daqueles que preferem manter distância de questões morais e não tomar partido, fazendo o que aparenta ser melhor conforme a situação.";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
    }
}