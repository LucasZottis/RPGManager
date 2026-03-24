using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;

namespace RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;

public class ClassStartingEquipmentItem : EntityBase
{
    public Guid StartingEquipmentOptionId { get; set; }
    public Guid? ItemId { get; set; }
    public Guid? CurrencyTypeId { get; set; } // referência à moeda
    public byte Quantity { get; set; }

    public ClassStartingEquipmentChoice Option { get; set; }
    public Item? Item { get; set; }
    public CurrencyType? Currency { get; set; }
}