namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

public class AmmunitionType : Item
{
    public byte Amount { get; set; }
    public string Storage { get; set; }

    public ICollection<WeaponPropertyAttribute> WeaponPropertyAttributes { get; set; }
}