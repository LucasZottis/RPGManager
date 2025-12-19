using RpgContentCreator.Domain.Entities.ItemsEntities.ToolEntities;

namespace RpgContentCreator.Domain.Entities.RaceEntities;

[PrimaryKey( nameof( RaceId ), nameof( ToolId ) )]
public class RaceToolProficiency
{
    [Required]
    [ForeignKey( nameof( Race ) )]
    [HasColumn( nameof( RaceId ), ColumnType.Guid )]
    public Guid RaceId { get; set; }

    [Required]
    [ForeignKey( nameof( Tool ) )]
    [HasColumn( nameof( ToolId ), ColumnType.Guid )]
    public Guid ToolId { get; set; }

    public Race Race { get; set; }

    public Tool Tool { get; set; }
}