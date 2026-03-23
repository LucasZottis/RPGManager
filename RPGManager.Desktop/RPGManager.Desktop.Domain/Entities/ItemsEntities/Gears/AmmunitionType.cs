using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

public class AmmunitionType : Gear
{
    public byte Amount { get; set; }
    public string Storage { get; set; }

    public ICollection<WeaponPropertyAttribute> WeaponPropertyAttributes { get; set; }
}