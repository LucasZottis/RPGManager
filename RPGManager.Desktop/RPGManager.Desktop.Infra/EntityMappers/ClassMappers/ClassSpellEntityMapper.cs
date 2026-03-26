using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.ClassesEntities;

namespace RPGManager.Desktop.Infra.EntityMappers.ClassMappers;

public class ClassSpellEntityMapper : IEntityTypeConfiguration<ClassSpell>
{
    public void Configure( EntityTypeBuilder<ClassSpell> builder )
    {
        builder.Property( e => e.ClassId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.SpellId ).IsRequired().ValueGeneratedNever();

        builder.HasKey( e => new { e.ClassId, e.SpellId } );

        builder.HasOne( e => e.Class ).WithMany( e => e.Spells ).HasForeignKey( e => e.ClassId );
        builder.HasOne( e => e.Spell ).WithMany().HasForeignKey( e => e.SpellId );
    }
}
