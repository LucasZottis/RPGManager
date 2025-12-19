using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Performance : SkillModel
{
    public Performance( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Atuação";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description performance"">
              <h3>Carisma (Atuação)</h3>

              <p>
                Um teste de Carisma (Atuação) determina o quão bem você pode entreter uma plateia
                com música, dança, atuação, contando histórias ou alguma outra forma de
                entretenimento.
              </p>
            </section>";
    }
}