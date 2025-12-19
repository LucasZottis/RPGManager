using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Intimidation : SkillModel
{
    public Intimidation( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Intimidação";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description intimidation"">
          <h3>Carisma (Intimidação)</h3>

          <p>
            Ao tentar influenciar alguém através de ameaças abertas, ações hostis e violência
            física, o Mestre pode pedir a realização de um teste de Carisma (Intimidação).
            Exemplos incluem tentar arrancar informações de um prisioneiro, convencer
            bandidos de rua a recuar de um confronto ou usar uma garrafa quebrada para
            convencer um vizir sarcástico a reconsiderar uma decisão.
          </p>
        </section>";
    }
}