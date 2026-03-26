using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class CurrencyTypeEntityMapper : EntityBaseEntityMapper<CurrencyType>
{
    protected override void Map( EntityTypeBuilder<CurrencyType> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.ShortName );
        builder.Property( e => e.Abbreviation ).HasMaxLength( 5 );
        builder.Property( e => e.IsBaseCurrency ).IsRequired();

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.CurrencyTypes ).HasForeignKey( e => e.GameSystemVersionId );
    }
}