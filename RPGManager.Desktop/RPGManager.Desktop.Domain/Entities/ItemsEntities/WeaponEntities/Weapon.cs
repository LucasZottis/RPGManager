using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class Weapon : Item
{
    public Guid WeaponCategoryId { get; set; }
    public Guid WeaponTypeId { get; set; }
    public Guid WeaponMasteryPropertyId { get; set; }
    public Guid BaseAbilityScoreId { get; set; }

    //public string? Description { get; set; }
    //public bool IsMagicWeapon { get; set; }

    public WeaponCategory WeaponCategory { get; set; } = null!;
    public WeaponType WeaponType { get; set; } = null!;
    public WeaponMasteryProperty WeaponMasteryProperty { get; set; } = null!;
    public AbilityScore BaseAbilityScore { get; set; } = null!;

    public ICollection<WeaponPropertyAttribute> Properties { get; set; }
    public ICollection<WeaponDamage> Damages { get; set; }
}