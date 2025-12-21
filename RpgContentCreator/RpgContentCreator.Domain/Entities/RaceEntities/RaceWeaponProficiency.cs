using RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RpgContentCreator.Domain.Entities.RaceEntities;

[PrimaryKey( nameof( RaceId ), nameof( WeaponId ) )]
public class RaceWeaponProficiency
{
    [Required]
    [ForeignKey( nameof( Race ) )]
    [HasColumn( nameof( RaceId ), ColumnType.Guid )]
    public Guid RaceId { get; set; }

    [Required]
    [ForeignKey( nameof( Weapon ) )]
    [HasColumn( nameof( WeaponId ), ColumnType.Guid )]
    public Guid WeaponId { get; set; }

    public Race Race { get; set; }

    public Weapon Weapon { get; set; }
}