namespace RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

public class Weapon : EntityBase
{
    public Guid GameSystemId { get; set; }
    public Guid WeaponCategoryId { get; set; }
    public Guid BaseAbilityScoreId { get; set; }
    public Guid WeaponTypeId { get; set; }
    //public Guid? AlternativeAbilityScoreId { get; set; }
    public Guid? CurrencyTypeId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public float Weight { get; set; }
    public float? RangeNormal { get; set; }
    public float? RangeLong { get; set; }

    public GameSystem GameSystem { get; set; } = null!;
    public WeaponCategory WeaponCategory { get; set; } = null!;
    public WeaponType WeaponType { get; set; } = null!;
    public AbilityScore BaseAbilityScore { get; set; } = null!;
    //public AbilityScore? AlternativeAbilityScore { get; set; }
    public CurrencyType? CurrencyType { get; set; }

    public ICollection<WeaponProperties> WeaponProperties { get; set; }
}