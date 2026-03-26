using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class ToolEntityMapper : IEntityTypeConfiguration<Tool>
{
    public void Configure( EntityTypeBuilder<Tool> builder )
    {
        builder.Property( e => e.CheckAbilityScoreId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.MediumName );
        builder.Property( e => e.Description );

        builder.HasOne( e => e.Ability ).WithMany().HasForeignKey( e => e.CheckAbilityScoreId );
    }
}
