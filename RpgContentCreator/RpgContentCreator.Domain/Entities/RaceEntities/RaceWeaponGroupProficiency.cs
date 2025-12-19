using RpgContentCreator.Domain.Entities.Items.WeaponEntities;

namespace RpgContentCreator.Domain.Entities.RaceEntities;

[PrimaryKey( nameof( RaceId ), nameof( WeaponGroupId ) )]
public class RaceWeaponGroupProficiency
{
    [Required]
    [ForeignKey(nameof(Race))]
    [HasColumn(nameof(RaceId), ColumnType.Guid)]
    public Guid RaceId { get; set; }

    [Required]
    [ForeignKey( nameof( WeaponGroup) )]
    [HasColumn( nameof( WeaponGroupId ), ColumnType.Guid )]
    public Guid WeaponGroupId { get; set; }

    public Race Race { get; set; }

    public WeaponGroup WeaponGroup { get; set; }
}