using RpgContentCreator.Application.Models;
using RpgContentCreator.IntegrationTest.Models.GameSystems;

namespace RpgContentCreator.IntegrationTest.Models.AbilitiesScores;

public class Dexterity : AbilityScoreModel
{
    public Dexterity()
    {
        Name = "Destreza";
        Description = "Mede a agilidade";
        Abbreviation = "DES";
        GameSystem = new DnD5e();
    }
}