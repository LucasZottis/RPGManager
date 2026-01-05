using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Domain.Entities;

public class AbilityScore : EntityBase
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }
    public string Name { get; set; }
    public string? Abbreviation { get; set; }
    public string? Description { get; set; }

    public ICollection<Skill> Skills { get; set; }
    public ICollection<Weapon> Weapons { get; set; }
    public ICollection<WeaponProperty> AlternativeAbilityScoreForWeaponProperties { get; set; }

    public GameSystem GameSystem { get; set; }
}