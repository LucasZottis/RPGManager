using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.WeaponMappers;

public class WeaponMasteryPropertyEntityMapper : GameSystemBaseEntityMapper<WeaponMasteryProperty>
{
    protected override void Map( EntityTypeBuilder<WeaponMasteryProperty> builder )
    {
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired();
    }
}
