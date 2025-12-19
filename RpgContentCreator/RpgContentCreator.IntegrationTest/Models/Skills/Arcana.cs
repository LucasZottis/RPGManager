using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Arcana : SkillModel
{
    public Arcana( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Arcanismo";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description arcana"">
              <h3>Inteligência (Arcanismo)</h3>
              <p>
                Um teste de Inteligência (Arcanismo) mede conhecimento sobre magias, itens mágicos,
                símbolos sobrenaturais, tradições mágicas, os planos de existência e os habitantes
                desses planos.
              </p>
            </section>";
    }
}
