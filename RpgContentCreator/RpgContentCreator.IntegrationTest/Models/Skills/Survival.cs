using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Survival : SkillModel
{
    public Survival( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Sobrevivência";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description survival"">
          <h3>Sabedoria (Sobrevivência)</h3>

          <p>
            Um teste de Sabedoria (Sobrevivência) é feito para seguir rastros, caçar, orientar
            o grupo através de terras congeladas, identificar sinais de que ursos-coruja vivem
            nas proximidades, prever o tempo, ou evitar areia movediça e outros perigos
            naturais.
          </p>
        </section>";
    }
}
