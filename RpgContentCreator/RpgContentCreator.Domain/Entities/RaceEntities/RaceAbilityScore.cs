namespace RpgContentCreator.Domain.Entities.RaceEntities;

public class RaceAbilityScore : EntityBase
{
    [Required]
    [ForeignKey( nameof( Race ) )]
    [HasColumn( nameof( RaceId ), ColumnType.Guid )]
    public Guid RaceId { get; set; }

    [ForeignKey( nameof( AbilityScore ) )]
    [HasColumn( nameof( AbilityScoreId ), ColumnType.Guid )]
    public Guid AbilityScoreId { get; set; }

    [Required]
    [HasColumn( nameof( Increase ), ColumnType.Integer )]
    public int Increase { get; set; } = 1;

    public Race Race { get; set; }
    public AbilityScore AbilityScore { get; set; }
}