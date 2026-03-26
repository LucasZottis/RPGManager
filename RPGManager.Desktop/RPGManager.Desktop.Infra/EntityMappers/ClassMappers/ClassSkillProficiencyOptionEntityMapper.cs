using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.SkillProficiency;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassSkillProficiencyOptionEntityMapper : IEntityTypeConfiguration<ClassSkillProficiencyOption>
{
    public void Configure( EntityTypeBuilder<ClassSkillProficiencyOption> builder )
    {
        builder.Property( e => e.ClassSkillProficiencyChoiceId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.SkillId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.ClassSkillProficiencyChoiceId, e.SkillId } );

        builder.HasOne( e => e.ClassSkillProficiencyChoice ).WithMany( e => e.Options ).HasForeignKey( e => e.ClassSkillProficiencyChoiceId );
        builder.HasOne( e => e.Skill ).WithMany( e => e.ClassSkillProficiencies ).HasForeignKey( e => e.SkillId );
    }
}
