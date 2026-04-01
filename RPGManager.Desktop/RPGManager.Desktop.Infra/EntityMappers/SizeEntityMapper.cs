using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class SizeEntityMapper : GameSystemVersionBaseEntityMapper<Size>
{
    private readonly DnD521Seed _dnD521Seed;

    public SizeEntityMapper(DnD521Seed dnD521Seed)
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Size> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.MinHeight ).IsRequired();
        builder.Property( e => e.MaxHeight ).IsRequired(false);

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Sizes ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetSizes() );
    }
}
