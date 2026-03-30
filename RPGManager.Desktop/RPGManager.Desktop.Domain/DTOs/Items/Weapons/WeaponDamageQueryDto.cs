namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponDamageQueryDto
{
    public Guid Id { get; set; }
    public Guid WeaponId { get; set; }
    public Guid DamageTypeId { get; set; }
}
