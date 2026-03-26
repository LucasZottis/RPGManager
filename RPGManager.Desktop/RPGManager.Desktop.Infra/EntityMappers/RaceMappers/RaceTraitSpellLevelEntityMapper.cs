using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Trait;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceTraitSpellLevelEntityMapper : IEntityTypeConfiguration<RaceTraitSpellLevel>
{
    public void Configure( EntityTypeBuilder<RaceTraitSpellLevel> builder )
    {
        builder.Property( e => e.RaceTraitSpellId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.LevelId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.RaceTraitSpellId, e.LevelId } );

        builder.HasOne( e => e.RaceTraitSpell ).WithMany( e => e.Levels ).HasForeignKey( e => e.RaceTraitSpellId );
        builder.HasOne( e => e.Level ).WithMany().HasForeignKey( e => e.LevelId );
    }
}
