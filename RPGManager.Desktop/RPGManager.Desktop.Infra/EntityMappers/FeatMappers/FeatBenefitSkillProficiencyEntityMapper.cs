using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Feats.FeatBenefits;

namespace RPGManager.Desktop.Infra.EntityMappers.FeatMappers;

public class FeatBenefitSkillProficiencyEntityMapper : IEntityTypeConfiguration<FeatBenefitSkillProficiency>
{
    public void Configure( EntityTypeBuilder<FeatBenefitSkillProficiency> builder )
    {
        builder.Property( e => e.FeatBenefitId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.SkillId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.FeatBenefitId, e.SkillId } );

        builder.HasOne( e => e.FeatBenefit ).WithMany( e => e.SkillsProficiency ).HasForeignKey( e => e.FeatBenefitId );
        builder.HasOne( e => e.Skill ).WithMany().HasForeignKey( e => e.SkillId );
    }
}
