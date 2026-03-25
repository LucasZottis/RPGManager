using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.WeaponMappers;

public class WeaponTypeEntityMapper : EntityBaseEntityMapper<WeaponType>
{
    protected override void Map( EntityTypeBuilder<WeaponType> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.WeaponTypes ).HasForeignKey( e => e.GameSystemId );
    }
}