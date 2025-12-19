using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

internal class Charisma : AbilityScoreModel
{
    public Charisma( GameSystemModel gameSystem )
    {
        Name = "Carisma";
        Description = GetDescription();
        Abbreviation = "CAR";
        GameSystem = gameSystem;
    }

    private string GetDescription()
    {
        return @"<section class=""ability-description charisma"">
  <p>
    O Carisma mede a capacidade de interagir eficazmente com os outros. Ele inclui
    fatores como confiança e eloquência, e pode representar uma personalidade
    encantadora ou dominadora.
  </p>

  <h4>TESTES DE CARISMA</h4>

  <p>
    Um teste de Carisma pode surgir quando você tenta influenciar ou entreter os
    outros, quando tenta expor uma opinião ou dizer uma mentira convincente, ou quando
    estiver em uma situação social complicada. As perícias Atuação, Enganação,
    Intimidação, e Persuasão refletem aptidão em certos tipos de testes de Carisma.
  </p>

  <h4>HABILIDADE DE CONJURAÇÃO</h4>

  <p>
    Bardos, Bruxos, Feiticeiros e Paladinos usam Carisma como sua habilidade para
    conjurar magias, o que ajuda a determinar a CD dos testes de resistência de suas
    magias.
  </p>
</section>";
    }

}