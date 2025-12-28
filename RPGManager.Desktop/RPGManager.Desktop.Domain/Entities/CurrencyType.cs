using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class CurrencyType : EntityBase
{
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }

    public GameSystem GameSystem { get; set; }

    public ICollection<Weapon> Weapons { get; set; }
}