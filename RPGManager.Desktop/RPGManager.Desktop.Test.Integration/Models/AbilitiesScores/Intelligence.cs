using RPGManager.Desktop.Test.Integration.Models.Skills;

namespace RPGManager.Desktop.Test.Integration.Models.AbilitiesScores;

[DictionaryKey( AbilityScoreKeys.INTELLIGENCE )]
public class Intelligence : AbilityScoreModel
{
    public Intelligence( Dictionaries rules )
    {
        Name = "Inteligência";
        Description = GetDescription();
        Abbreviation = "INT";
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        Skills = GetSkillList( rules );
    }

    private string GetDescription()
    {
        return @"<section class=""ability-description intelligence"">
                  <p>
                    A Inteligência mede a acuidade mental, precisão da memória e a habilidade de
                    raciocinar.
                  </p>

                  <h4>TESTES DE INTELIGÊNCIA</h4>

                  <p>
                    Um teste de Inteligência entra em jogo quando você precisa usar a lógica, estudo,
                    memória ou raciocínio dedutivo. As perícias Arcanismo, História, Investigação,
                    Natureza e Religião refletem aptidão em certos tipos de testes de Inteligência.
                  </p>

                  <p>
                    <strong>Outros Testes de Inteligência.</strong> O Mestre pode pedir um teste de
                    Inteligência quando você tentar realizar uma das seguintes tarefas:
                  </p>

                  <ul>
                    <li>Comunicar-se com uma criatura sem usar palavras</li>
                    <li>Estimar o valor de um item precioso</li>
                    <li>Conseguir um disfarce para fazer-se passar por um guarda da cidade</li>
                    <li>Forjar um documento</li>
                    <li>Recordar conhecimento sobre um ofício ou profissão</li>
                    <li>Vencer um jogo de habilidade</li>
                  </ul>

                  <h4>HABILIDADE DE CONJURAÇÃO</h4>

                  <p>
                    Magos usam Inteligência como sua habilidade para conjurar magias, o que ajuda a
                    determinar a CD dos testes de resistência de suas magias.
                  </p>
                </section>";
    }

    private List<SkillModel> GetSkillList( Dictionaries rules )
    {
        return new List<SkillModel> {
            new Arcana( rules ),
            new History( rules ),
            new Investigation( rules ),
            new Nature( rules ),
            new Religion( rules ),
        };
    }
}