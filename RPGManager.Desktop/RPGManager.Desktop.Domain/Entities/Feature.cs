using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class Feature : GameSystemEntityBase
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<ClassFeature> Features { get; set; }
    public ICollection<ClassLevelUpFeature> ClassFeatureLevelUps { get; set; }
}