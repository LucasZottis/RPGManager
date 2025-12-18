namespace RpgContentCreator.Domain.Entities.RaceEntities;

public class RaceFeature : EntityBase
{
    [Required]
    [HasColumn( nameof( RaceId ), ColumnType.Guid )]
    public Guid RaceId { get; set; }

    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn( nameof( Name ), ColumnType.LongText )]
    public string Name { get; set; }

    [Required]
    [HasColumn( nameof( Description ), ColumnType.LongText )]
    public string Description { get; set; }
}