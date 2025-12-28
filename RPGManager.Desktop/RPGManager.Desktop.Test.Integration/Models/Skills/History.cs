



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class History : SkillModel
{
    public History( Dictionaries rules )
    {
        Name = "História";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        //BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description history"">
          <h3>Inteligência (História)</h3>
          <p>
            Um teste de Inteligência (História) mede o conhecimento sobre eventos históricos,
            pessoas lendárias, reinos antigos, disputas passadas, guerras recentes e
            civilizações perdidas.
          </p>
        </section>";
    }
}
