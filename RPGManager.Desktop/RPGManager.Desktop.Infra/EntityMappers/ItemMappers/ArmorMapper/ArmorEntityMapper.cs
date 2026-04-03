using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.EntityMappers.ItemMappers.ArmorMapper;

public abstract class ArmorEntityMapper<TEntity> : ItemEntityMapper<TEntity>
    where TEntity : Armor
{
    protected override void Map( EntityTypeBuilder<TEntity> builder )
    {
        builder.Property( e => e.ArmorCategoryId ).IsRequired();
        builder.Property( e => e.RequiredAbilityScoreId );

        builder.Property( e => e.RequiredAbilityScoreMinimum ).IsRequired().HasDefaultValue( 0 );
        builder.Property( e => e.DisadvantageOnStealth ).IsRequired().HasDefaultValue( false );
    }
}