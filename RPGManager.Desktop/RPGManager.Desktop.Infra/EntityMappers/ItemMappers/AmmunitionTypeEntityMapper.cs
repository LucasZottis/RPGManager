using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class AmmunitionTypeEntityMapper : IEntityTypeConfiguration<AmmunitionType>
{
    public void Configure( EntityTypeBuilder<AmmunitionType> builder )
    {
        builder.Property( e => e.Amount ).IsRequired();
        builder.Property( e => e.Storage ).IsRequired().HasMaxLength( MaxLength.MediumName );
    }
}
