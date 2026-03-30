namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponDamageDiceTypeQueryDto
{
    public Guid WeaponDamageId { get; set; }
    public Guid DiceTypeId { get; set; }
    public byte Quantity { get; set; }
}
