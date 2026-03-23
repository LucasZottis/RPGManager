using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassLevel
{
    public Guid ClassId { get; set; }
    public Guid LevelId { get; set; }

    public byte ProficiencyBonus { get; set; }

    public Class Class { get; set; }
    public Level Level { get; set; }

    public ICollection<ClassFeature> Features { get; set; }
    public ICollection<ClassFeatureAttributeLevel> AttributeLevels { get; set; }
}