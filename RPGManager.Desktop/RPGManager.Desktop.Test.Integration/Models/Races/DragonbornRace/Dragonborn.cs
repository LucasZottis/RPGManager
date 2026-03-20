namespace RPGManager.Desktop.Test.Integration.Models.Races.DragonbornRace;

public class Dragonborn : RaceQueryDto
{
    public Dragonborn( Dictionaries rules )
    {
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
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