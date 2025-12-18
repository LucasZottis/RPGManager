using RpgContentCreator.Application.Models;
using RpgContentCreator.IntegrationTest.Models.GameSystems;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Constitution : AbilityScoreModel
{
    public Constitution()
    {
        Name = "Constituição";
        Description = "Mede a resistência";
        Abbreviation = "CON";
        GameSystem = new DnD5e();
    }
}