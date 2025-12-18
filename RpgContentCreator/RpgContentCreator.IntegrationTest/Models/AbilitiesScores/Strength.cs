using RpgContentCreator.Application.Models;
using RpgContentCreator.IntegrationTest.Models.GameSystems;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Strength : AbilityScoreModel
{
    public Strength()
    {
        Name = "Força";
        Description = "Mede o poder físico";
        Abbreviation = "FOR";
        GameSystem = new DnD5e();
    }
}