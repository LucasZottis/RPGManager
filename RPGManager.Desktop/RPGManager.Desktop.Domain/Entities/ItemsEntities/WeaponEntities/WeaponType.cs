using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponType : GameSystemEntityBase
{
    public string Name { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
}