using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities.ToolProficiency;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassToolProficiencyOptionEntityMapper : IEntityTypeConfiguration<ClassToolProficiencyOption>
{
    public void Configure( EntityTypeBuilder<ClassToolProficiencyOption> builder )
    {
        builder.Property( e => e.ClassToolProficiencyChoiceId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.ToolId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.ClassToolProficiencyChoiceId, e.ToolId } );

        builder.HasOne( e => e.ClassToolProficiencyChoice ).WithMany( e => e.Options ).HasForeignKey( e => e.ClassToolProficiencyChoiceId );
        builder.HasOne( e => e.Tool ).WithMany().HasForeignKey( e => e.ToolId );
    }
}
