using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Backgrounds;

namespace RPGManager.Desktop.Infra.EntityMappers.BackgroundMappers;

public class BackgroundToolProficiencyEntityMapper : IEntityTypeConfiguration<BackgroundToolProficiency>
{
    public void Configure( EntityTypeBuilder<BackgroundToolProficiency> builder )
    {
        builder.Property( e => e.BackgroundId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.ToolId ).IsRequired();

        builder.HasKey( e => e.BackgroundId );

        builder.HasOne( e => e.Tool ).WithMany().HasForeignKey( e => e.ToolId );
    }
}
