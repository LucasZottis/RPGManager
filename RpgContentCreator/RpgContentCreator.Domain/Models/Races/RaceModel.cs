using RpgContentCreator.Domain.Entities.RaceEntities;

namespace RpgContentCreator.Domain.Models.Races;

public class RaceModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public RaceModel? ParentRace { get; set; }
    public GameSystemModel GameSystem { get; set; }

    public ICollection<RaceAbilitiesScoreModel> RaceAbilitiesScores { get; set; }

    public ICollection<RaceFeatureModel> RaceFeatures { get; set; }

    public ICollection<RaceLanguageModel> RaceLanguages { get; set; }

    public ICollection<RaceSkillProficiency> SkillProficiencies { get; set; }

    public ICollection<RaceWeaponProficiency> WeaponProficiencies { get; set; }

    public ICollection<RaceWeaponGroupProficiency> WeaponGroupProficiencies { get; set; }
}