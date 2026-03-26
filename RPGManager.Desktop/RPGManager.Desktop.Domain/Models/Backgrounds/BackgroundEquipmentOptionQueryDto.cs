namespace RPGManager.Desktop.Domain.Models.Backgrounds;

public class BackgroundEquipmentOptionQueryDto
{
    public Guid Id { get; set; }
    public Guid BackgroundId { get; set; }
    public byte OptionOrder { get; set; }
}
