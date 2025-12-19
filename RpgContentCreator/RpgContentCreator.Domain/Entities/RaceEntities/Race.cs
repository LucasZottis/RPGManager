namespace RpgContentCreator.Domain.Entities.RaceEntities;

public class Race : EntityBase
{
    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [ForeignKey( nameof( ParentRace ) )]
    [HasColumn( nameof( ParentRaceId ), ColumnType.Guid )]
    public Guid? ParentRaceId { get; set; }

    [Required]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    [MaxLength( MaxLength.LongName )]
    public string Name { get; set; }

    [Required]
    [HasColumn( nameof( Description ), ColumnType.LongText )]
    public string Description { get; set; }

    [Required]
    [HasColumn( nameof( Speed ), ColumnType.Double )]
    public double Speed { get; set; }

    //public bool IsSubRace { get; set; }

    public ICollection<RaceAbilityScore> AbilityScores { get; set; }
    public ICollection<RaceFeature> Features { get; set; }
    public ICollection<RaceLanguage> Languages { get; set; }

    public GameSystem GameSystem { get; set; }
    public Race ParentRace { get; set; }
}