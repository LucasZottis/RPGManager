using RPGManager.Desktop.Domain.Entities.RaceEntities;

namespace RPGManager.Desktop.Domain.Models.Races;

public class RaceModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public Guid? ParentRaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Speed { get; set; }

    public ICollection<RaceAbilitiesScoreModel> RaceAbilitiesScores { get; set; }

    public ICollection<RaceFeatureModel> RaceFeatures { get; set; }

    public ICollection<RaceLanguageModel> RaceLanguages { get; set; }

    public ICollection<RaceSkillProficiencyModel> SkillProficiencies { get; set; }

    public ICollection<RaceWeaponProficiencyModel> WeaponProficiencies { get; set; }

    public ICollection<RaceWeaponGroupProficiency> WeaponGroupProficiencies { get; set; }
}