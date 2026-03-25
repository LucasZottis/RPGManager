using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.Backgrounds.Equipments;

public class BackgroundEquipmentOption : EntityBase
{
    public Guid BackgroundId { get; set; }

    public byte OptionOrder { get; set; }

    public Background Background { get; set; }

    public ICollection<BackgroundEquipmentOptionItem> Items { get; set; }
}