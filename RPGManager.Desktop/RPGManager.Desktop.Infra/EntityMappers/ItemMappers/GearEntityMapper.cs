using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class GearEntityMapper : IEntityTypeConfiguration<Gear>
{
    public void Configure( EntityTypeBuilder<Gear> builder )
    {
        builder.Property( e => e.Description ).IsRequired();
    }
}
