namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponDamageDiceType
{
    public Guid WeaponDamageId { get; set; }
    public Guid DiceTypeId { get; set; }

    public byte Quantity { get; set; }

    public WeaponDamage WeaponDamage { get; set; }
    public DiceType DiceType { get; set; }
}