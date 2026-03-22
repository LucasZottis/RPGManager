using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class LevelUp : GameSystemEntityBase
{
    public byte LevelNumber { get; set; }
    public uint ExperiencePoints { get; set; }
    public byte ProficiencyBonus { get; set; }

    public ICollection<ClassLevelUp> ClassLevelUps { get; set; }
    public ICollection<ClassLevelUpFeature> ClassesLevelUpsFeatures { get; set; }
}