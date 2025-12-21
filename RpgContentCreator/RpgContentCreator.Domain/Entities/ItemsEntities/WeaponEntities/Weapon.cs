namespace RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

public class Weapon : EntityBase
{
    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [Required]
    [ForeignKey( nameof( WeaponCategory ) )]
    [HasColumn( nameof( WeaponCategoryId ), ColumnType.Guid )]
    public Guid WeaponCategoryId { get; set; }

    [ForeignKey( nameof( WeaponType ) )]
    [HasColumn( nameof( WeaponTypeId ), ColumnType.Guid )]
    public Guid? WeaponTypeId { get; set; }

    [Required]
    [ForeignKey( nameof( BaseAbilityScore ) )]
    [HasColumn( nameof( BaseAbilityScoreId ), ColumnType.Guid )]
    public Guid BaseAbilityScoreId { get; set; }

    [Required]
    [ForeignKey( nameof( BaseAbilityScore ) )]
    [HasColumn( nameof( AlternativeAbilityScore ), ColumnType.Guid )]
    public Guid AlternativeAbilityScoreId { get; set; }

    [Required]
    [MaxLength( MaxLength.MediumName )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string Name { get; set; }

    [HasColumn( nameof( Description ), ColumnType.LongText )]
    public string? Description { get; set; }

    [Required]
    [HasColumn( nameof( Price ), ColumnType.Money )]
    public decimal Price { get; set; }

    [Required]
    [HasColumn( nameof( Weight ), ColumnType.Float )]
    public float Weight { get; set; }

    [HasColumn( nameof( RangeNormal ), ColumnType.Integer )]
    public int RangeNormal { get; set; }

    [HasColumn( nameof( RangeLong ), ColumnType.Integer )]
    public int RangeLong { get; set; }

    public GameSystem GameSystem { get; set; }
    public WeaponCategory WeaponCategory { get; set; }
    public WeaponType WeaponType { get; set; }
    public AbilityScore BaseAbilityScore { get; set; }
    public AbilityScore AlternativeAbilityScore { get; set; }
}
