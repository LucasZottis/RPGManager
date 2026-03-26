using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.CurrencyTypeEntities;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public class ItemEntityMapper : GameSystemVersionBaseEntityMapper<Item>
{
    protected override void Map( EntityTypeBuilder<Item> builder )
    {
        builder.Property( e => e.CostCurrencyTypeId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.MediumName );
        builder.Property( e => e.Cost ).IsRequired();
        builder.Property( e => e.Weight );

        builder.HasOne( e => e.CostCurrencyType ).WithMany( e => e.Items ).HasForeignKey( e => e.CostCurrencyTypeId );
    }
}
