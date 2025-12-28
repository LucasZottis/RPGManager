using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public class CurrencyTypeEntityMapper : EntityBaseEntityMapper<CurrencyType>
{
    protected override void Map( EntityTypeBuilder<CurrencyType> builder )
    {
        builder.Property( e => e.GameSystemId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Abbreviation ).IsRequired().HasMaxLength( 5 );

        builder.HasOne( e => e.GameSystem ).WithMany( e => e.CurrencyTypes ).HasForeignKey( e => e.GameSystemId );
    }
}