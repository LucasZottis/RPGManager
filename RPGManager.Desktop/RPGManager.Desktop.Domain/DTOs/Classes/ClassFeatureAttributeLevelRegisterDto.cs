namespace RPGManager.Desktop.Domain.DTOs.Classes;

public class ClassFeatureAttributeLevelRegisterDto
{
    public Guid ClassFeatureAttributeId { get; set; }
    public Guid ClassLevelId { get; set; }
    public Guid? DiceTypeId { get; set; }
    public byte Value { get; set; }
}
