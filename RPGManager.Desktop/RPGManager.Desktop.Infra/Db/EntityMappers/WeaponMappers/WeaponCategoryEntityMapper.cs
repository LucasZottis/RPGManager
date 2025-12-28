using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;

namespace RPGManager.Desktop.Infra.Db.EntityMappers.WeaponMappers;

public class WeaponCategoryEntityMapper : EntityBaseEntityMapper<WeaponCategory>
{
    protected override void Map( EntityTypeBuilder<WeaponCategory> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.WeaponCategories ).HasForeignKey( e => e.GameSystemId );
    }
}