using RpgContentCreator.Application.Models;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Wisdom : AbilityScoreModel
{
    public Wisdom( GameSystemModel gameSystem )
    {
        Name = "Sabedoria";
        Description = "Mede a percepção e a intuição";
        Abbreviation = "SAB";
        GameSystem = gameSystem;
    }
}