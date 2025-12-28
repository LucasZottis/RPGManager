namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponProperty : EntityBase
{
    public Guid AlterantiveAbilityScoreId { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool HasAlternativeDiceTypeDamage { get; set; }

    public GameSystem GameSystem { get; set; }

    public ICollection<WeaponProperties> Weapons { get; set; }
}