using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponProperty : GameSystemEntityBase
{
    public Guid? AlternativeAbilityScoreId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool HasAlternativeDiceTypeDamage { get; set; }

    public AbilityScore? AlternativeAbilityScore { get; set; }

    public ICollection<WeaponPropertyAttribute> Weapons { get; set; }
}