namespace RPGManager.Desktop.Domain.DTOs.Items.Weapons;

public class WeaponDamageDiceTypeRegisterDto
{
    public Guid WeaponDamageId { get; set; }
    public Guid DiceTypeId { get; set; }
    public byte Quantity { get; set; }
}
