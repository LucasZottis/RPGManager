namespace RpgContentCreator.Domain.Entities;

[PrimaryKey( nameof( Id ) )]
public class Language
{
    [HasColumn( nameof( Id ), ColumnType.Guid )]
    public Guid Id { get; set; }

    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }
    //public Guid RaceId { get; set; }

    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string Name { get; set; }

    [MaxLength( 20 )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string? Alphabet { get; set; }

    public GameSystem GameSystem { get; set; }
}