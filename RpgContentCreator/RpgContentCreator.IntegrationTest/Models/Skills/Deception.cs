using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Deception : SkillModel
{
    public Deception( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Enganação";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description deception"">
          <h3>Carisma (Enganação)</h3>

          <p>
            Um teste de Carisma (Enganação) determina se você pode esconder a verdade de forma
            convincente, verbalmente ou através de suas ações. Esse engano pode abranger tudo,
            como iludir os outros através de uma mentira cheia de ambiguidade.
          </p>

          <p>
            Situações típicas incluem tentar ludibriar um guarda, iludir um comerciante, ganhar
            dinheiro através de jogos de azar, usar um disfarce, amenizar as suspeitas de alguém
            com falsas garantias ou manter uma cara séria ao contar uma mentira descarada.
          </p>
        </section>";
    }
}
