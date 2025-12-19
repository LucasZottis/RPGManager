using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RpgContentCreator.Domain.Entities.Items.WeaponEntities;

namespace RpgContentCreator.Domain.Entities.ItemsEntities.WeaponEntities;

[PrimaryKey( nameof( WeaponId ), nameof( DamageTypeId ) )]
public class WeaponDamage
{
    [Required]
    [ForeignKey( nameof( Weapon ) )]
    [HasColumn( nameof( WeaponId ), ColumnType.Guid )]
    public Guid WeaponId { get; set; }

    [Required]
    [ForeignKey( nameof( DamageType ) )]
    [HasColumn( nameof( DamageTypeId ), ColumnType.Guid )]
    public Guid DamageTypeId { get; set; }

    [HasColumn( nameof( AttackIncrease ), ColumnType.Integer )]
    public int? AttackIncrease { get; set; }

    [HasColumn( nameof( DamageIncrease ), ColumnType.Integer )]
    public int? DamageIncrease { get; set; }

    [HasColumn( nameof( DamageDieCount ), ColumnType.Integer )]
    public int? DamageDieCount { get; set; }

    [HasColumn( nameof( DamageDiceType ), ColumnType.Integer )]
    public int? DamageDiceType { get; set; }

    [HasColumn( nameof( AlternativeDamageDieCount ), ColumnType.Integer )]
    public int? AlternativeDamageDieCount { get; set; }

    [HasColumn( nameof( AlternativeDamageDiceType ), ColumnType.Integer )]
    public int? AlternativeDamageDiceType { get; set; }

    public Weapon Weapon { get; set; }
    public DamageType DamageType { get; set; }
}