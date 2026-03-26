using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;

namespace RPGManager.Desktop.Infra.EntityMappers;

public class CurrencyConversionRateEntityMapper : IEntityTypeConfiguration<CurrencyConversionRate>
{
    public void Configure( EntityTypeBuilder<CurrencyConversionRate> builder )
    {
        builder.Property( e => e.FromCurrencyTypeId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.ToCurrencyTypeId ).IsRequired().ValueGeneratedNever();
        builder.Property( e => e.Rate ).IsRequired();

        builder.HasKey( e => new { e.FromCurrencyTypeId, e.ToCurrencyTypeId } );

        builder.HasOne( e => e.FromCurrencyType ).WithMany( e => e.FromCurrencyRates ).HasForeignKey( e => e.FromCurrencyTypeId );
        builder.HasOne( e => e.ToCurrencyType ).WithMany( e => e.ToCurrencyRates ).HasForeignKey( e => e.ToCurrencyTypeId );
    }
}
