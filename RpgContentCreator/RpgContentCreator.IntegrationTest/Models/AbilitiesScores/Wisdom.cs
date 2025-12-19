using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Wisdom : AbilityScoreModel
{
    public Wisdom( GameSystemModel gameSystem )
    {
        Name = "Sabedoria";
        Description = GetDescription();
        Abbreviation = "SAB";
        GameSystem = gameSystem;
    }

    private string GetDescription()
    {
        return @"<section class=""ability-description wisdom"">
  <p>
    A Sabedoria reflete como você está em sintonia com o mundo ao seu redor e
    representa percepção e intuição.
  </p>

  <h4>TESTES DE SABEDORIA</h4>

  <p>
    Um teste de Sabedoria pode refletir um esforço para ler a linguagem corporal,
    entender os sentimentos de alguém, perceber coisas sobre o meio ambiente ou
    cuidar de uma pessoa ferida. As perícias Adestrar Animais, Intuição, Medicina,
    Percepção e Sobrevivência refletem aptidão em certos tipos de testes de Sabedoria.
  </p>

  <p>
    <strong>Outros Testes de Sabedoria.</strong> O Mestre pode pedir um teste de
    Sabedoria quando você tentar realizar uma das seguintes tarefas:
  </p>

  <ul>
    <li>Obter um pressentimento sobre o que fazer</li>
    <li>Discernir se uma criatura, morta ou viva, é um morto-vivo</li>
  </ul>

  <h4>HABILIDADE DE CONJURAÇÃO</h4>

  <p>
    Clérigos usam Sabedoria como sua habilidade para conjurar magias, o que ajuda a
    determinar a CD dos testes de resistência de suas magias.
  </p>
</section>";
    }

}