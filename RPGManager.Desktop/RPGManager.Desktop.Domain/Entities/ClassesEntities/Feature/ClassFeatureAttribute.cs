namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;

public class ClassFeatureAttribute : EntityBase
{
    public Guid ClassFeatureId { get; set; }
    public string Name { get; set; }

    public ClassFeature ClassFeature { get; set; }

    public ICollection<ClassFeatureAttributeLevel> AttributeLevels { get; set; }
}