namespace RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponProperty : EntityBase
{
    [Required]
    [ForeignKey( nameof( AbilityScore ) )]
    [HasColumn( nameof( AlterantiveAbilityScoreId ), ColumnType.Guid )]
    public Guid AlterantiveAbilityScoreId { get; set; }

    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string Name { get; set; }

    [Required]
    [HasColumn( nameof( Description ), ColumnType.LongText )]
    public string Description { get; set; }

    //[Required]
    //[HasColumn( nameof( AltersDamage ), ColumnType.Boolean )]
    //public bool AltersDamage { get; set; }

    //[Required]
    //[HasColumn( nameof( RequiresAlternativeDamage ), ColumnType.Boolean )]
    //public bool RequiresAlternativeDamage { get; set; }

    [Required]
    [HasColumn( nameof( HasAlternativeDiceTypeDamage ), ColumnType.Boolean )]
    public bool HasAlternativeDiceTypeDamage { get; set; }

    //[Required]
    //[HasColumn( nameof( AllowsAttributeOverride ), ColumnType.Boolean )]
    //public bool AllowsAttributeOverride { get; set; }

    public GameSystem GameSystem { get; set; }
}