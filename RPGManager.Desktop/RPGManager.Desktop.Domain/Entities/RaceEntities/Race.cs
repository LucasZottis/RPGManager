namespace RPGManager.Desktop.Domain.Entities.RaceEntities;

public class Race : EntityBase
{
    public Guid GameSystemId { get; set; }
    public Guid? ParentRaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Speed { get; set; }

    public ICollection<RaceAbilityScore> AbilityScores { get; set; }
    public ICollection<RaceFeature> Features { get; set; }
    public ICollection<RaceLanguage> Languages { get; set; }
    public ICollection<RaceWeaponProficiency>? WeaponProficiencies { get; set; }
    public ICollection<RaceWeaponGroupProficiency>? WeaponGroupProficiencies { get; set; }
    public ICollection<RaceArmorProficiency>? ArmorProficiencies { get; set; }
    public ICollection<RaceToolProficiency>? ToolProficiencies { get; set; }
    public ICollection<RaceProficiencyChoice>? ProficiencyChoices { get; set; }

    public GameSystem GameSystem { get; set; }
    public Race ParentRace { get; set; }
}