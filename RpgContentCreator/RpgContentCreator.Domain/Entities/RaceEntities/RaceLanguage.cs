namespace RpgContentCreator.Domain.Entities.RaceEntities;

[PrimaryKey( nameof( RaceId ), nameof( LanguageId ) )]
public class RaceLanguage
{
    [Required]
    [HasColumn( nameof( RaceId ), ColumnType.Guid )]
    public Guid RaceId { get; set; }

    [Required]
    [HasColumn( nameof( LanguageId ), ColumnType.Guid )]
    public Guid LanguageId { get; set; }
}