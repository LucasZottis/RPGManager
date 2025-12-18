using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Intelligence : AbilityScoreModel
{
    public Intelligence( GameSystemModel gameSystem )
    {
        Name = "Inteligência";
        Description = "Mede o raciocínio e a memória";
        Abbreviation = "INT";
        GameSystem = gameSystem;
    }
}