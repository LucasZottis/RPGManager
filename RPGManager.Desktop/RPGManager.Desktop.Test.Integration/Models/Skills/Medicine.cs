



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Medicine : SkillModel
{
    public Medicine( Dictionaries rules )
    {
        Name = "Medicina";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        //BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description medicine"">
              <h3>Sabedoria (Medicina)</h3>
              <p>
                Um teste de Sabedoria (Medicina) permite tentar estabilizar um companheiro que
                está morrendo ou diagnosticar uma doença.
              </p>
            </section>";
    }
}
