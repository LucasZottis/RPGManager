using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class SleightOfHand : SkillModel
{
    public SleightOfHand( GameSystemModel gameSystem, AbilityScoreModel baseAbilityScore )
    {
        Name = "Prestidigitação";
        Description = GetDescription();
        GameSystem = gameSystem;
        BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description sleight-of-hand"">
          <h3>Destreza (Prestidigitação)</h3>

          <p>
            Sempre que você tentar realizar um ato de prestidigitação ou de trapaça manual,
            como plantar alguma coisa em outra pessoa ou esconder um objeto em sua roupa,
            você deve fazer um teste de Destreza (Prestidigitação).
          </p>

          <p>
            O Mestre também pode pedir um teste de Destreza (Prestidigitação) para determinar
            se você pode roubar uma bolsa de moedas de outra pessoa ou pegar algo do bolso de
            outra pessoa.
          </p>
        </section>";
    }
}
