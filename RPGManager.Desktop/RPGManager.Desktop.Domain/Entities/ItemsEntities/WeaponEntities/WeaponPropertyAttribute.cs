namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponPropertyAttribute
{
    public Guid WeaponId { get; set; }
    public Guid WeaponPropertyId { get; set; }
    public Guid? AmmunitionTypeId { get; set; }

    public float? NormalRange { get; set; }
    public float? LongRange { get; set; }
    public string? Remarks { get; set; }

    public Weapon Weapon { get; set; }
    public WeaponProperty WeaponProperty { get; set; }
    public AmmunitionType AmmunitionType { get; set; }
}