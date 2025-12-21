using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Arcana : SkillModel
{
    public Arcana( GameSystemRules rules )
    {
        Name = "Arcanismo";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        //BaseAbilityScore = baseAbilityScore;
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
