



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Performance : SkillModel
{
    public Performance( Dictionaries rules )
    {
        Name = "Atuação";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        ////BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description performance"">
              <h3>Carisma (Atuação)</h3>

              <p>
                Um teste de Carisma (Atuação) determina o quão bem você pode entreter uma plateia
                com música, dança, atuação, contando histórias ou alguma outra forma de
                entretenimento.
              </p>
            </section>";
    }
}