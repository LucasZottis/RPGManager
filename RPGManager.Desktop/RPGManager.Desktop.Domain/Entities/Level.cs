using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class Level : GameSystemVersionEntityBase
{
    public byte LevelNumber { get; set; }
    public uint ExperiencePoints { get; set; }
    public byte ProficiencyBonus { get; set; }

    public ICollection<ClassLevel> ClassesLevels { get; set; }
}