namespace RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

public class WeaponType : EntityBase
{
    [Required]
    [ForeignKey( nameof( GameSystem ) )]
    [HasColumn( nameof( GameSystemId ), ColumnType.Guid )]
    public Guid GameSystemId { get; set; }

    [Required]
    [MaxLength( MaxLength.ShortName )]
    [HasColumn( nameof( Name ), ColumnType.ShortText )]
    public string Name { get; set; }

    public GameSystem GameSystem { get; set; }
}
