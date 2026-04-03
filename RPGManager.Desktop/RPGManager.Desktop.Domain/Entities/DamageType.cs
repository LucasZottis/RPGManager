using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities;

public class DamageType : GameSystemVersionEntityBase
{
    public string Name { get; set; }

    public ICollection<WeaponDamage> WeaponDamages { get; set; }
}