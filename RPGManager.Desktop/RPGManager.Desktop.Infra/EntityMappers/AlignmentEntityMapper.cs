using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class AlignmentEntityMapper : GameSystemVersionBaseEntityMapper<Alignment>
{
    private readonly DnD521Seed _dnD521Seed;

    public AlignmentEntityMapper( DnD521Seed dnD521Seed)
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Alignment> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Description ).IsRequired();

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Alignments ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetAlignments() );
    }
}