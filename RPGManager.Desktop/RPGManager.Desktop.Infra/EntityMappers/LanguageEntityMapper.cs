using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class LanguageEntityMapper : EntityBaseEntityMapper<Language>
{
    protected override void Map( EntityTypeBuilder<Language> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Alphabet ).HasMaxLength( 20 );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.Languages ).HasForeignKey( e => e.GameSystemId );
    }
}