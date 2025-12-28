namespace RPGManager.Desktop.Domain.Models.Items.Weapons;

public class WeaponModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }

    public Guid WeaponCategoryId { get; set; }
    public Guid? WeaponTypeId { get; set; }

    public Guid BaseAbilityScoreId { get; set; }
    public Guid? AlternativeAbilityScoreId { get; set; }
    public Guid? CurrencyTypeId { get; set; }

    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public decimal Cost { get; set; }
    public float Weight { get; set; }

    public float? RangeNormal { get; set; }
    public float? RangeLong { get; set; }

    public IList<WeaponPropertyModel> Properties { get; set; } = [];
    public IList<WeaponDamageModel> Damages { get; set; } = [];
}