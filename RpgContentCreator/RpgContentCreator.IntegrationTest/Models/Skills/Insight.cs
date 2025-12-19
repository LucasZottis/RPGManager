using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Insight : SkillModel
{
    public Insight( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Intuição";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description insight"">
              <h3>Sabedoria (Intuição)</h3>
                <p>
                  Um teste de Sabedoria (Intuição) decide se você pode determinar as verdadeiras
                  intenções de uma criatura, perceber uma mentira ou prever o próximo movimento
                  de alguém. Fazer isso envolve recolher pistas a partir da linguagem corporal, 
                    os hábitos da fala e as mudanças nos maneirismos.
                </p>
            </section>";
    }
}
