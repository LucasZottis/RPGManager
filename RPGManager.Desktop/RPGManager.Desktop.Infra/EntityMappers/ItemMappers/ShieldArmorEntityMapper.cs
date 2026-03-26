using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class ShieldArmorEntityMapper : IEntityTypeConfiguration<ShieldArmor>
{
    public void Configure( EntityTypeBuilder<ShieldArmor> builder )
    {
        builder.Property( e => e.ArmorClassBonus ).IsRequired();
    }
}
