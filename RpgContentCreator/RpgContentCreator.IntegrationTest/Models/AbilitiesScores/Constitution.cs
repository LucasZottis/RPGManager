using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Constitution : AbilityScoreModel
{
    public Constitution(GameSystemModel gameSystem)
    {
        Name = "Constituição";
        Description = GetDesciption();
        Abbreviation = "CON";
        GameSystem = gameSystem;
    }

    private string GetDesciption()
    {
        return @"<section class=""ability-description constitution"">
                  <p>
                    A <strong>Constituição</strong> mede a saúde, a resistência e a força vital.
                  </p>

                  <h3>Testes de Constituição</h3>
                  <p>
                    Testes de Constituição são incomuns e nenhuma perícia se aplica a eles, pois a resistência
                    representada por essa habilidade é, em grande parte, passiva, em vez de envolver um esforço
                    específico por parte de um personagem ou monstro.
                  </p>
                  <p>
                    No entanto, um teste de Constituição pode representar uma tentativa de você ir além dos limites
                    normais.
                  </p>

                  <p>
                    O Mestre pode pedir um teste de Constituição quando você tentar realizar uma das seguintes tarefas:
                  </p>

                  <ul>
                    <li>Segurar a respiração</li>
                    <li>Marchar ou trabalhar por horas sem descanso</li>
                    <li>Ficar sem dormir</li>
                    <li>Sobreviver sem comida ou água</li>
                    <li>Beber uma caneca de cerveja de uma só vez</li>
                  </ul>

                  <h3>Pontos de Vida</h3>
                  <p>
                    O modificador de Constituição contribui diretamente para os seus <strong>pontos de vida</strong>.
                    Normalmente, você adiciona seu modificador de Constituição para cada <strong>Dado de Vida</s
                ";
    }
}