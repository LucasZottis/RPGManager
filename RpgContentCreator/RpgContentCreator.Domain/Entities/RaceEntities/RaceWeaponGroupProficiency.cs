using RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RpgContentCreator.Domain.Entities.RaceEntities;

[PrimaryKey( nameof( RaceId ), nameof( WeaponTypeId ) )]
public class RaceWeaponGroupProficiency
{
    [Required]
    [ForeignKey(nameof(Race))]
    [HasColumn(nameof(RaceId), ColumnType.Guid)]
    public Guid RaceId { get; set; }

    [Required]
    [ForeignKey( nameof( WeaponType ) )]
    [HasColumn( nameof( WeaponType ), ColumnType.Guid )]
    public Guid WeaponTypeId { get; set; }

    public Race Race { get; set; }

    public WeaponType WeaponType { get; set; }
}