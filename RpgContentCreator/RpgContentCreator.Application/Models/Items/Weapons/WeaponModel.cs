namespace RpgContentCreator.Application.Models.Items.Weapons;

public class WeaponModel
{
    public Guid Id { get; set; }
    public Guid GameSystemId { get; set; }

    public Guid WeaponCategoryId { get; set; }
    public Guid? WeaponGroupId { get; set; }

    public Guid BaseAbilityScoreId { get; set; }
    public Guid? AlternativeAbilityScoreId { get; set; }

    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    public decimal Cost { get; set; }
    public float Weight { get; set; }

    public int? RangeNormal { get; set; }
    public int? RangeLong { get; set; }

    public IList<WeaponPropertiesModel> WeaponProperties { get; set; } = [];
    public IList<WeaponDamageModel> Damages { get; set; } = [];
}