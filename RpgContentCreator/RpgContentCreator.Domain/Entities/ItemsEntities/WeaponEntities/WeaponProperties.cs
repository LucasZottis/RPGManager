namespace RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

[PrimaryKey( nameof( WeaponId ), nameof( WeaponPropertyId ) )]
public class WeaponProperties
{
    [Required]
    [HasColumn( nameof( WeaponId ), ColumnType.Guid )]
    public Guid WeaponId { get; set; }

    [Required]
    [HasColumn( nameof( WeaponPropertyId ), ColumnType.Guid )]
    public Guid WeaponPropertyId { get; set; }
}