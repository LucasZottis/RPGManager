using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class LanguageEntityMapper : GameSystemVersionBaseEntityMapper<Language>
{
    private readonly DnD521Seed _seed;

    public LanguageEntityMapper( DnD521Seed dnD521Seed )
    {
        _seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<Language> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Alphabet ).IsRequired( false ).HasMaxLength( 20 );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( gsv => gsv.Languages ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _seed.GetLanguages() );
    }
}