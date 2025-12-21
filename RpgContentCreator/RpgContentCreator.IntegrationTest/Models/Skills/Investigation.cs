using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Investigation : SkillModel
{
    public Investigation( GameSystemRules rules )
    {
        Name = "Investigação";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        //BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description investigation"">
          <h3>Inteligência (Investigação)</h3>

          <p>
            Quando você olha ao redor em busca de pistas e faz deduções com base nesses
            indícios, você realiza um teste de Inteligência (Investigação). Você pode deduzir 
            a localização de um objeto escondido, discernir, a partir da aparência de um 
            ferimento, que tipo de arma o causou, ou determinar o ponto mais fraco em um 
            túnel que poderia causar o seu colapso. Debruçar-se sobre pergaminhos antigos 
            em busca de um fragmento escondido de conhecimento também pode necessitar um 
            teste de Inteligência (Investigação).
          </p>
        </section>";
    }
}
