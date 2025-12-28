



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Nature : SkillModel
{
    public Nature( Dictionaries rules )
    {
        Name = "Natureza";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
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
