using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.RaceEntities.Ancestry;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.RaceMappers;

public class RaceAncestrySpellEntityMapper : EntityBaseEntityMapper<RaceAncestrySpell>
{
    protected override void Map( EntityTypeBuilder<RaceAncestrySpell> builder )
    {
        builder.Property( e => e.RaceAncestryId ).IsRequired();
        builder.Property( e => e.SpellId ).IsRequired();

        builder.HasOne( e => e.RaceAncestry ).WithMany( e => e.Spells ).HasForeignKey( e => e.RaceAncestryId );
        builder.HasOne( e => e.Spell ).WithMany().HasForeignKey( e => e.SpellId );
    }
}
