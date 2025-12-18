namespace RpgContentCreator.Domain.Entities;

public class AbilityScore : EntityBase
{
    [Required]
    [HasColumn( nameof( Id ), ColumnType.Guid )]
    public Guid Id { get; set; }

    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string Name { get; set; }

    [MaxLength( 3 )]
    [HasColumn( nameof( Abbreviation ), ColumnType.ShortText )]
    public string? Abbreviation { get; set; }

    [HasColumn( nameof( Description ), ColumnType.LongText )]
    public string? Description { get; set; }

    public GameSystem GameSystem { get; set; }
}