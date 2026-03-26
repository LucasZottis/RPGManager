using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds;

namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

public class BackgroundSkillProficiencyEntityMapper : IEntityTypeConfiguration<BackgroundSkillProficiency>
{
    public void Configure( EntityTypeBuilder<BackgroundSkillProficiency> builder )
    {
        builder.Property( e => e.BackgroundId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.SkillId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.BackgroundId, e.SkillId } );

        builder.HasOne( e => e.Background ).WithMany( e => e.SkillProficiencies ).HasForeignKey( e => e.BackgroundId );
        builder.HasOne( e => e.Skill ).WithMany().HasForeignKey( e => e.SkillId );
    }
}
