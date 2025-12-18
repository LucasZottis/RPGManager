using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

internal class Charisma : AbilityScoreModel
{
    public Charisma( GameSystemModel gameSystem )
    {
        Name = "Carisma";
        Description = "Mede a força da personalidade";
        Abbreviation = "CAR";
        GameSystem = gameSystem;
    }
}