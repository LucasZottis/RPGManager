using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RPGManager.Desktop.Infra.Db.EntityMappers;

public abstract class EntityBaseEntityMapper<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : EntityBase
{
    protected EntityBaseEntityMapper()
    {

    }

    private void ConfigurePrimaryKey( EntityTypeBuilder<TEntity> builder )
    {
        builder.HasKey( entity => entity.Id );
    }

    private void InitialConfiguration( EntityTypeBuilder<TEntity> builder )
    {
        builder.Property( e => e.Id ).IsRequired();
        ConfigurePrimaryKey( builder );
    }

    protected abstract void Map( EntityTypeBuilder<TEntity> builder );

    public void Configure( EntityTypeBuilder<TEntity> builder )
    {
        InitialConfiguration( builder );
        Map( builder );
    }
}