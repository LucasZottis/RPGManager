using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Infra.EntityMappers.Base;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers;

public abstract class ItemEntityMapper<TEntity> : EntityBaseEntityMapper<TEntity>
    where TEntity : Item
{
    protected override void Map( EntityTypeBuilder<TEntity> builder )
    {
        builder.UseTpcMappingStrategy();

        builder.Property( e => e.GameSystemVersionId ).IsRequired();
        builder.Property( e => e.CostCurrencyTypeId );
        builder.Property( e => e.Name ).IsRequired().HasMaxLength( MaxLength.MediumName );
        builder.Property( e => e.Cost ).IsRequired();
        builder.Property( e => e.Weight );
    }
}
