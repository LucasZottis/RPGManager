using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Strength : AbilityScoreModel
{
    public Strength(GameSystemModel gameSystem )
    {
        Name = "Força";
        Description = GetDescription();
        Abbreviation = "FOR";
        GameSystem = gameSystem;
    }

    private string GetDescription()
    {
        return @"<section class=""ability-description strength"">
            <p>
            A <strong>Força</strong> mede a potência física, o treinamento atlético e a extensão da força bruta
            que você pode exercer.
            </p>

            <h3>Testes de Força</h3>
            <p>
            Um teste de Força representa qualquer tentativa de levantar, empurrar, puxar ou quebrar alguma coisa,
            forçar seu corpo através de um espaço ou outra forma de aplicar a força bruta para resolver uma situação.
            A perícia <strong>Atletismo</strong> reflete aptidão em certos tipos de testes de Força.
            </p>

            <p>
            O Mestre também pode pedir um teste de Força quando você tenta realizar uma das seguintes tarefas:
            </p>

            <ul>
            <li>Forçar para abrir uma porta emperrada, trancada ou bloqueada</li>
            <li>Libertar-se de amarras</li>
            <li>Forçar-se através de um túnel que é muito pequeno</li>
            <li>Segurar-se em um vagão enquanto é arrastado atrás dele</li>
            <li>Tombar uma estátua</li>
            <li>Impedir uma grande pedra de rolar</li>
            </ul>

            <h3>Jogadas de Ataque e Dano</h3>
            <p>
            Você adiciona seu modificador de Força em suas jogadas de ataque e dano quando estiver atacando com
            uma arma corpo-a-corpo, tal como uma maça, um machado de guerra ou uma azagaia.
            </p>
            <p>
            Você usa armas corpo-a-corpo para realizar ataques em combate corpo-a-corpo, e algumas dessas armas
            podem ser arremessadas para realizar ataques à distância.
            </p>

            <h3>Erguendo e Carregando</h3>
            <p>
            Seu valor de Força determina a quantidade de peso que você pode suportar. Os termos a seguir definem
            o que você pode levantar ou carregar.
            </p>

            <h4>Capacidade de Carga</h4>
            <p>
            Sua capacidade de carga máxima é igual a <strong>7,5 vezes o seu valor de Força</strong>. Esse é o
            peso em quilogramas que você pode carregar, normalmente alto o suficiente para que a maioria dos
            personagens não precise se preocupar com isso.
            </p>

            <h4>Puxar, Arrastar e Levantar</h4>
            <p>
            Você pode arrastar, puxar ou erguer um peso em kg de até <strong>duas vezes a sua capacidade de carga</strong>
            (ou 15 vezes o seu valor de Força). Ao empurrar ou arrastar um peso superior à sua capacidade de carga,
            seu deslocamento é reduzido para <strong>1,5 metro</strong>.
            </p>

            <h4>Tamanho e Força</h4>
            <p>
            Criaturas grandes podem suportar mais peso, enquanto criaturas Miúdas podem carregar menos. Para cada
            categoria de tamanho acima de Médio, a capacidade de carga da criatura é dobrada, assim como o peso
            que ela pode empurrar, puxar ou levantar. Para criaturas Miúdas, esses valores são reduzidos pela metade.
            </p>

            <h3>Variação: Sobrecarga</h3>
            <p>
            As regras para erguer e carregar são intencionalmente simples. Caso você queira regras mais detalhadas
            para determinar como o peso do equipamento afeta um personagem, utilize esta variação. Ao usá-la,
            ignore a coluna Força da tabela de Armaduras.
            </p>

            <ul>
            <li>
                Se você carregar um peso em kg superior a <strong>2,5 vezes</strong> o seu valor de Força, você está
                em <strong>sobrecarga</strong>, o que reduz seu deslocamento em <strong>3 metros</strong>.
            </li>
            <li>
                Se você carregar um peso em kg superior a <strong>5 vezes</strong> o seu valor de Força, até a sua
                capacidade de carga máxima (<strong>7,5 vezes</strong> o valor de Força), você está em
                <strong>sobrecarga pesada</strong>. Nessa condição, seu deslocamento é reduzido em
                <strong>6 metros</strong> e você tem desvantagem em testes de habilidade, jogadas de ataque e testes
                de resistência que usem Força, Destreza ou Constituição.
            </li>
            </ul>
        </section>
        ";
    }
}