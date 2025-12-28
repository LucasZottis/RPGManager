



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Stealth : SkillModel
{
    public Stealth( Dictionaries rules )
    {
        Name = "Furtividade";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
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