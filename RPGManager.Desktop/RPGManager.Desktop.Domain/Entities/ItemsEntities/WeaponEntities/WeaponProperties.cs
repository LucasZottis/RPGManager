namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponProperties
{
    public Guid WeaponId { get; set; }

    public Guid WeaponPropertyId { get; set; }

    public Weapon Weapon { get; set; }
    public WeaponProperty WeaponProperty { get; set; }
}