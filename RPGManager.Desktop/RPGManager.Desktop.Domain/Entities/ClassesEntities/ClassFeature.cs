namespace RPGManager.Desktop.Domain.Entities.ClassesEntities;

public class ClassFeature
{
    public Guid ClassId { get; set; }
    public Guid FeatureId { get; set; }

    //public byte UsageAmount { get; set; }

    public Class Class { get; set; }
    public Feature Feature { get; set; }
}