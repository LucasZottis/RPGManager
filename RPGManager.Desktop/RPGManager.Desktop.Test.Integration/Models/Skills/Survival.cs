



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Survival : SkillModel
{
    public Survival( Dictionaries rules )
    {
        Name = "Sobrevivência";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        //BaseAbilityScore = baseAbilityScore;
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
