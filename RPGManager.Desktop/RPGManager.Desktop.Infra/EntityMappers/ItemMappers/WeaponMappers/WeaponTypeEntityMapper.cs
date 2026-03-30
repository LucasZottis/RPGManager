using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.WeaponMappers;

public class WeaponTypeEntityMapper : GameSystemVersionBaseEntityMapper<WeaponType>
{
    protected override void Map( EntityTypeBuilder<WeaponType> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
    }
}