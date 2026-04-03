namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponDamage
{
    public Guid WeaponId { get; set; }
    public Guid DamageTypeId { get; set; }
    public Guid DiceTypeId { get; set; }

    public byte DiceQuantity { get; set; }

    public Weapon Weapon { get; set; }
    public DamageType DamageType { get; set; }
    public DiceType DiceType { get; set; }
}