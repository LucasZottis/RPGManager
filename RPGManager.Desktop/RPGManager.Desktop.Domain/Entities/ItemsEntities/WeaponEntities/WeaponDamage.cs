using RPGManager.Desktop.Domain.Entities;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponDamage
{
    public Guid WeaponId { get; set; }

    public Guid DamageTypeId { get; set; }

    public int? AttackIncrease { get; set; }

    public int? DamageIncrease { get; set; }

    public int? DamageDieCount { get; set; }

    public int? DamageDiceType { get; set; }

    public int? AlternativeDamageDieCount { get; set; }

    public int? AlternativeDamageDiceType { get; set; }

    public Weapon Weapon { get; set; }
    public DamageType DamageType { get; set; }
}