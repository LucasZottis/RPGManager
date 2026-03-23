namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;

public class ClassFeatureAttributeLevel
{
    public Guid ClassFeatureAttributeId { get; set; }
    public Guid ClassLevelId { get; set; }
    public byte Value { get; set; }

    public ClassFeatureAttribute ClassFeatureAttribute { get; set; }
    public ClassLevel ClassLevel { get; set; }
}