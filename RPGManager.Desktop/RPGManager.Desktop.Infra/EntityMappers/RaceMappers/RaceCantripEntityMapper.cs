using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceCantripEntityMapper : IEntityTypeConfiguration<RaceCantrip>
{
    public void Configure( EntityTypeBuilder<RaceCantrip> builder )
    {
        builder.Property( e => e.RaceId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.SpellId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.RaceId, e.SpellId } );

        builder.HasOne( e => e.Race ).WithMany().HasForeignKey( e => e.RaceId );
    }
}
