namespace RpgContentCreator.Domain.Entities.Items.WeaponEntities;

public class Weapon : EntityBase
{
    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    public GameSystem GameSystem { get; set; }
}