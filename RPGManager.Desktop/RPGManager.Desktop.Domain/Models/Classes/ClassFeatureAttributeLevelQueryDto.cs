namespace RPGManager.Desktop.Domain.Models.Classes;

public class ClassFeatureAttributeLevelQueryDto
{
    public Guid ClassFeatureAttributeId { get; set; }
    public Guid ClassLevelId { get; set; }
    public Guid? DiceTypeId { get; set; }
    public byte Value { get; set; }
}
