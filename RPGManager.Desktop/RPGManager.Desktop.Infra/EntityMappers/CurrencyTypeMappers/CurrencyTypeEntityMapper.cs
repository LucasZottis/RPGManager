using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.CurrencyTypeMappers;

public class CurrencyTypeEntityMapper : EntityBaseEntityMapper<CurrencyType>
{
    private readonly DnD521Seed _dnD521Seed;

    public CurrencyTypeEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<CurrencyType> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Abbreviation ).HasMaxLength( 5 );
        builder.Property( e => e.IsBaseCurrency ).HasDefaultValue( false ).IsRequired();

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.CurrencyTypes ).HasForeignKey( e => e.GameSystemVersionId );

        builder.HasData( _dnD521Seed.GetCurrencyTypes() );
    }
}