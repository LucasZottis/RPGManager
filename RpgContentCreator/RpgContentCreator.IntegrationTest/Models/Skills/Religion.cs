using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Religion : SkillModel
{
    public Religion( GameSystemRules rules )
    {
        Name = "Religião";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        //BaseAbilityScore = baseAbilityScore;
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
