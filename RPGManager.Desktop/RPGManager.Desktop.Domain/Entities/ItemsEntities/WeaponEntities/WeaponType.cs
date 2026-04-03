namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponType : GameSystemVersionEntityBase
{
    public string Name { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
}