using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Stealth : SkillModel
{
    public Stealth( GameSystemRules rules )
    {
        Name = "Furtividade";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        ////BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description stealth"">
              <h3>Destreza (Furtividade)</h3>

              <p>
                Um teste de Destreza (Furtividade) é realizado para tentar esconder-se de inimigos,
                esgueirar-se por guardas, escapar sem ser notado, ou aproximar-se de alguém sem ser
                visto ou ouvido.
              </p>
            </section>";
    }
}