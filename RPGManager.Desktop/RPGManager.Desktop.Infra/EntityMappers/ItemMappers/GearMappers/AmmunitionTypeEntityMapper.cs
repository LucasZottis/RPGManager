using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.Seeds;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class AmmunitionTypeEntityMapper : ItemEntityMapper<AmmunitionType>
{
    private readonly DnD521Seed _dnD521Seed;

    public AmmunitionTypeEntityMapper( DnD521Seed dnD521Seed )
    {
        _dnD521Seed = dnD521Seed;
    }

    protected override void Map( EntityTypeBuilder<AmmunitionType> builder )
    {
        builder.Property( e => e.Amount ).IsRequired();
        builder.Property( e => e.Storage ).IsRequired().HasMaxLength( MaxLength.ShortName );

        builder.HasOne( e => e.GameSystemVersion ).WithMany( e => e.Ammunitions ).HasForeignKey( e => e.GameSystemVersionId );
        builder.HasOne( e => e.CostCurrencyType ).WithMany( e => e.AmmunitionTypes ).HasForeignKey( e => e.CostCurrencyTypeId );

        builder.HasData( _dnD521Seed.GetAmmunitionTypes() );
    }
}