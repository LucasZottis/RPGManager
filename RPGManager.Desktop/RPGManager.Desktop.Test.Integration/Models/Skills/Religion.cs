



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Religion : SkillModel
{
    public Religion( Dictionaries rules )
    {
        Name = "Religião";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
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
