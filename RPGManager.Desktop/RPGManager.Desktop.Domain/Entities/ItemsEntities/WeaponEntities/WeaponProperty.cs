namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponProperty : EntityBase
{
    public Guid GameSystemId { get; set; }
    public Guid? AlternativeAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool HasAlternativeDiceTypeDamage { get; set; }

    public GameSystem GameSystem { get; set; } = null!;
    public Background? AlternativeAbilityScore { get; set; }

    public ICollection<WeaponProperties> Weapons { get; set; }
}