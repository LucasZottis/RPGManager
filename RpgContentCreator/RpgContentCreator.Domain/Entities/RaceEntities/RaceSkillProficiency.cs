namespace RpgContentCreator.Domain.Entities.RaceEntities;

[PrimaryKey( nameof( RaceId ), nameof( SkillId ) )]
public class RaceSkillProficiency
{
    [Required]
    [ForeignKey( nameof( Race ) )]
    [HasColumn( nameof( RaceId ), ColumnType.Guid )]
    public Guid RaceId { get; set; }

    [Required]
    [ForeignKey( nameof( Skill ) )]
    [HasColumn( nameof( SkillId ), ColumnType.Guid )]
    public Guid SkillId { get; set; }

    [Required]
    [HasColumn( nameof( IsExpertise ), ColumnType.Boolean )]
    public bool IsExpertise { get; set; }

    public Race Race { get; set; }

    public Skill Skill { get; set; }
}