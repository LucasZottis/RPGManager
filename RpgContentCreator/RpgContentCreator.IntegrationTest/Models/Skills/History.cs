using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class History : SkillModel
{
    public History( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "História";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description history"">
          <h3>Inteligência (História)</h3>
          <p>
            Um teste de Inteligência (História) mede o conhecimento sobre eventos históricos,
            pessoas lendárias, reinos antigos, disputas passadas, guerras recentes e
            civilizações perdidas.
          </p>
        </section>";
    }
}
