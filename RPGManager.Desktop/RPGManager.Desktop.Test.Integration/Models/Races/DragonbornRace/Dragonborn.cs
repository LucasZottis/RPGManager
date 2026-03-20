using RPGManager.Desktop.Test.Integration.Tests;

namespace RPGManager.Desktop.Test.Integration.Models.Races.DragonbornRace;

[DictionaryKey( RaceKey.DRAGONBORN )]
[DependsOn(typeof(GameSystemIntegrationTest))]
public class Dragonborn : RaceQueryDto
{
    public Dragonborn( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND521E ).Id;
        Name = "Dragonborn";
        Speed = 9f;
        //Description = GetDescription();
        //RaceFeatures = GetFeatures();
        //RaceAbilitiesScores = GetRaceAbilitiesScores( rules );
        //WeaponProficiencies = GetWeaponProficiencies( rules );
        //SkillProficiencies = GetSkillsProficiencies( rules );
        //RaceLanguages = GetRaceLanguages( rules );
    }
}