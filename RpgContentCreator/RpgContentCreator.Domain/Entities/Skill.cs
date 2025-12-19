namespace RpgContentCreator.Domain.Entities;

public class Skill : EntityBase
{
    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [Required]
    [ForeignKey( nameof( BaseAbilityScore ) )]
    [HasColumn( nameof( BaseAbilityScoreId ), ColumnType.Guid )]
    public Guid BaseAbilityScoreId { get; set; }

    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string Name { get; set; }

    [HasColumn( nameof( Description ), ColumnType.ShortText )]
    public string Description { get; set; }

    public GameSystem GameSystem { get; set; }
    public AbilityScore BaseAbilityScore { get; set; }
}