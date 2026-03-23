using RPGManager.Desktop.Domain.Entities.ClassesEntities.StartingEquipment;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities;

public class Item : GameSystemEntityBase
{
    public Guid? CostCurrencyTypeId { get; set; }

    public string Name { get; set; }
    public decimal Cost { get; set; }
    public float? Weight { get; set; }

    public CurrencyType? CostCurrencyType { get; set; }
    public Weapon? Weapon { get; set; }
    public Armor? Armor { get; set; }

    public ICollection<ClassStartingEquipmentItem> ClassStartingEquipmentItems { get; set; }
}