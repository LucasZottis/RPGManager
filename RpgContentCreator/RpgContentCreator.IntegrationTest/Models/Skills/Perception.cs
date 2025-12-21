using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.IntegrationTest.Models.Skills;

public class Perception : SkillModel
{
    public Perception( GameSystemRules rules )
    {
        Name = "Percepção";
        Description = GetDescription();
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        //BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description perception"">
          <h3>Sabedoria (Percepção)</h3>

          <p>
            Um teste de Sabedoria (Percepção) permite observar, ouvir ou detectar a presença
            de alguma coisa de outra forma. A percepção mede a consciência geral do que está
            acontecendo ao seu redor e a acuidade de seus sentidos.
          </p>

          <p>
            Por exemplo, você pode tentar ouvir uma conversa através de uma porta fechada,
            bisbilhotar sob uma janela aberta ou ouvir monstros movendo-se furtivamente na
            floresta. Ou você pode tentar detectar coisas que são obscurecidas ou que
            normalmente passariam despercebidas, desde uma emboscada de orcs em uma estrada,
            bandidos escondidos nas sombras de um beco ou uma porta secreta fechada somente
            com a luz de velas.
          </p>

          <h4>ENCONTRANDO UM OBJETO ESCONDIDO</h4>

          <p>
            Quando seu personagem procura por um objeto escondido, como uma porta secreta
            ou uma armadilha, o Mestre normalmente pede para que você realize um teste de
            Sabedoria (Percepção).
          </p>

          <p>
            Esse teste pode ser usado para encontrar detalhes escondidos ou outras
            informações e dicas que você poderia ignorar.
          </p>

          <p>
            Na maioria dos casos, você precisa dizer o local onde ele está procurando para
            que o Mestre possa determinar suas chances de sucesso. Por exemplo, uma chave
            está escondida debaixo de um conjunto de roupas dobradas na gaveta de uma cômoda.
          </p>

          <p>
            Se você disser ao Mestre que está andando pela sala, olhando para as paredes e
            móveis em busca de pistas, você não terá chance de encontrar a chave,
            independentemente do resultado do seu teste de Sabedoria (Percepção).
          </p>

          <p>
            Você teria que especificar que estava abrindo as gavetas ou procurando na
            cômoda para ter alguma chance de sucesso.
          </p>
        </section>";
    }
}