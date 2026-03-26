namespace RPGManager.Desktop.Domain.Models.Classes;

public class ClassStartingEquipmentChoiceQueryDto
{
    public Guid Id { get; set; }
    public Guid ClassId { get; set; }
    public byte OptionOrder { get; set; }
}
