namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponCategory : EntityBase
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }

    public GameSystem GameSystem { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
}