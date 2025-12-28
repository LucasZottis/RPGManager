



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Arcana : SkillModel
{
    public Arcana( Dictionaries rules )
    {
        Name = "Arcanismo";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
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
