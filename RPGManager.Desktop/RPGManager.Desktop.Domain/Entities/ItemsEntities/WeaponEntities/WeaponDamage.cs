using RPGManager.Desktop.Domain.Entities;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponDamage : EntityBase
{
    public Guid WeaponId { get; set; }
    public Guid DamageTypeId { get; set; }

    //public byte? AttackIncrease { get; set; }
    //public byte? DamageIncrease { get; set; }

    public Weapon Weapon { get; set; }
    public DamageType DamageType { get; set; }

    public ICollection<WeaponDamageDiceType> DamageDiceTypes { get; set; }
}