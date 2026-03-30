namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponPropertyAttributeQueryDto
{
    public Guid WeaponId { get; set; }
    public Guid WeaponPropertyId { get; set; }
    public Guid? AmmunitionTypeId { get; set; }
    public float? NormalRange { get; set; }
    public float? LongRange { get; set; }
    public string? Remarks { get; set; }
}
