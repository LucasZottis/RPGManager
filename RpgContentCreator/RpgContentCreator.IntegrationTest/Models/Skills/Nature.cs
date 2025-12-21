using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Nature : SkillModel
{
    public Nature( GameSystemRules rules )
    {
        Name = "Natureza";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        //BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description nature"">
              <h3>Inteligência (Natureza)</h3>
              <p>
                Um teste de Inteligência (Natureza) mede o conhecimento sobre terreno, plantas e
                animais, clima e ciclos naturais.
              </p>
            </section>";
    }
}
