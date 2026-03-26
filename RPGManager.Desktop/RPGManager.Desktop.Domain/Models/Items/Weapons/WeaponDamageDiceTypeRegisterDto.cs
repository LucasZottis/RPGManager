namespace RPGManager.Desktop.Domain.Models.Items.Weapons;

public class WeaponDamageDiceTypeRegisterDto
{
    public Guid WeaponDamageId { get; set; }
    public Guid DiceTypeId { get; set; }
    public byte Quantity { get; set; }
}
