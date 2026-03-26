using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.FeatMappers;

public class FeatBenefitToolProficiencyEntityMapper : IEntityTypeConfiguration<FeatBenefitToolProficiency>
{
    public void Configure( EntityTypeBuilder<FeatBenefitToolProficiency> builder )
    {
        builder.Property( e => e.FeatBenefitId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.ToolId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.FeatBenefitId, e.ToolId } );

        builder.HasOne( e => e.FeatBenefit ).WithMany( e => e.ToolsProficiency ).HasForeignKey( e => e.FeatBenefitId );
        builder.HasOne( e => e.Tool ).WithMany().HasForeignKey( e => e.ToolId );
    }
}
