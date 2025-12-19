using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Religion : SkillModel
{
    public Religion( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Religião";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description religion"">
              <h3>Inteligência (Religião)</h3>

              <p>
                Um teste de Inteligência (Religião) mede o conhecimento de lendas sobre divindades,
                rituais e orações, hierarquias religiosas, símbolos sagrados e práticas de cultos
                secretos.
              </p>
            </section>";
    }
}
