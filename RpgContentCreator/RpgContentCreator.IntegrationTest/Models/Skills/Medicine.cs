using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Medicine : SkillModel
{
    public Medicine( GameSystemRules rules )
    {
        Name = "Medicina";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
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
