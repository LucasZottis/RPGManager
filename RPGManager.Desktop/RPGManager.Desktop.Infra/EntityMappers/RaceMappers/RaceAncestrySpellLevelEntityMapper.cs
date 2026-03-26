using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceAncestrySpellLevelEntityMapper : IEntityTypeConfiguration<RaceAncestrySpellLevel>
{
    public void Configure( EntityTypeBuilder<RaceAncestrySpellLevel> builder )
    {
        builder.Property( e => e.RaceAncestrySpellId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.LevelId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.RaceAncestrySpellId, e.LevelId } );

        builder.HasOne( e => e.RaceAncestrySpell ).WithMany( e => e.Levels ).HasForeignKey( e => e.RaceAncestrySpellId );
        builder.HasOne( e => e.Level ).WithMany().HasForeignKey( e => e.LevelId );
    }
}
