using RpgContentCreator.Domain.Models;
using RpgContentCreator.IntegrationTest.Models.GameSystems;
using RpgContentCreator.IntegrationTest.Models.Skills;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Dexterity : AbilityScoreModel
{
    public Dexterity( GameSystemRules rules )
    {
        Name = "Destreza";
        Description = GetDescription();
        Abbreviation = "DES";
        GameSystem = rules.GetGameSystem( GameSystemKey.DND5E );
        Skills = GetSkillList( rules );
    }

    private string GetDescription()
    {
        return @"<section class=""ability-description dexterity"">
              <p>
                A <strong>Destreza</strong> mede a agilidade, os reflexos e o equilíbrio.
              </p>

              <h3>Testes de Destreza</h3>
              <p>
                Um teste de Destreza representa a tentativa de se mover com agilidade, rapidez ou em silêncio,
                ou evitar cair ao caminhar por uma estrada traiçoeira. As perícias
                <strong>Acrobacia</strong>, <strong>Furtividade</strong> e <strong>Prestidigitação</strong>
                refletem aptidão em certos tipos de testes de Destreza.
              </p>

              <p>
                O Mestre pode pedir um teste de Destreza quando você tentar realizar uma das seguintes tarefas:
              </p>

              <ul>
                <li>Controlar uma carruagem muito carregada em uma ladeira</li>
                <li>Dirigir uma biga em uma curva acentuada</li>
                <li>Abrir uma fechadura</li>
                <li>Desarmar uma armadilha</li>
                <li>Amarrar um prisioneiro com segurança</li>
                <li>Escapar de amarras</li>
                <li>Tocar um instrumento de cordas</li>
                <li>Criar um objeto pequeno ou detalhado</li>
              </ul>

              <h3>Jogadas de Ataque e Dano</h3>
              <p>
                Você adiciona seu modificador de Destreza às jogadas de ataque e dano quando estiver atacando com
                armas à distância, como uma funda ou um arco longo.
              </p>
              <p>
                Você também pode adicionar seu modificador de Destreza às jogadas de ataque e dano quando estiver
                atacando com uma arma corpo-a-corpo que possua a propriedade <strong>acuidade</strong>, como uma
                adaga ou uma rapieira.
              </p>

              <h3>Escondendo-se</h3>
              <p>
                Quando você tenta se esconder, deve realizar um teste de <strong>Destreza (Furtividade)</strong>.
                Até que você seja descoberto ou pare de se esconder, o resultado desse teste é resistido por um
                teste de <strong>Sabedoria (Percepção)</strong> de qualquer criatura que procure ativamente por
                sinais de sua presença. O Mestre decide quando as circunstâncias são apropriadas.
              </p>

              <p>
                Você não pode se esconder de uma criatura que possa vê-lo claramente, e se fizer algum barulho
                (como gritar um aviso ou derrubar um vaso), sua posição é denunciada. Uma criatura invisível não
                pode ser vista e, portanto, sempre pode tentar se esconder, embora sinais de sua passagem ainda
                possam ser notados.
              </p>

              <p>
                Em combate, a maioria das criaturas está alerta para perigos ao redor. Assim, se você sair de seu
                esconderijo e se aproximar de uma criatura, ela normalmente o verá. Em determinadas circunstâncias,
                o Mestre pode permitir que você permaneça escondido ao se aproximar de uma criatura distraída,
                concedendo vantagem em um ataque antes de ser visto.
              </p>

              <h4>Percepção Passiva</h4>
              <p>
                Mesmo que uma criatura não esteja procurando ativamente, ela ainda pode perceber você escondido.
                Para isso, o Mestre compara o resultado do seu teste de
                <strong>Destreza (Furtividade)</strong> com a
                <strong>Sabedoria (Percepção) Passiva</strong> da criatura,
                que é igual a <strong>10 + o modificador de Sabedoria</strong>,
                acrescido de quaisquer bônus ou penalidades.
              </p>
              <p>
                Se a criatura tiver vantagem, adicione <strong>+5</strong>. Em caso de desvantagem, subtraia
                <strong>5</strong>.
              </p>

              <p>
                Por exemplo, um personagem de 1º nível, com bônus de proficiência +2, Sabedoria 15
                (modificador +2) e proficiência em Percepção, possui Sabedoria (Percepção) Passiva igual a
                <strong>14</strong>.
              </p>

              <p>
                Um dos principais fatores para determinar se você pode encontrar uma criatura ou objeto escondido
                é o quão bem ele pode enxergar na área, variando de escuridão leve até escuridão densa.
              </p>

              <h3>Classe de Armadura</h3>
              <p>
                Dependendo da armadura utilizada, você pode adicionar parte ou todo o seu modificador de
                Destreza à sua <strong>Classe de Armadura</strong>, conforme descrito no capítulo 5.
              </p>

              <h3>Iniciativa</h3>
              <p>
                No início de todos os combates, você joga sua iniciativa realizando um teste de
                <strong>Destreza</strong>. A iniciativa determina a ordem dos turnos das criaturas envolvidas no
                combate.
              </p>
            </section>";
    }

    private List<SkillModel> GetSkillList( GameSystemRules rules )
    {
        return new List<SkillModel> {
            new Acrobatics( rules ),
            new SleightOfHand( rules ),
            new Stealth( rules ),
        };
    }
}