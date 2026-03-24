using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;

public class ClassStartingEquipmentChoice : EntityBase
{
    public Guid ClassId { get; set; }
    public byte OptionOrder { get; set; } // A=0, B=1, etc.

    public Class Class { get; set; }
    public ICollection<ClassStartingEquipmentItem> Items { get; set; }
}