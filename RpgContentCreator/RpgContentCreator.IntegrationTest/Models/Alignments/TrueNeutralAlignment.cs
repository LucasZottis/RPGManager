using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Alignments;

public class TrueNeutralAlignment : AlignmentModel
{
    public TrueNeutralAlignment(GameSystemModel gameSystem)
    {
        Name = "Neutro";
        Description = "É a tendência daqueles que preferem manter distância de questões morais e não tomar partido, fazendo o que aparenta ser melhor conforme a situação.";
        GameSystem = gameSystem;
    }
}