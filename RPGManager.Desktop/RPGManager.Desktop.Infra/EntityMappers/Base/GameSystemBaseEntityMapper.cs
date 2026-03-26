using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Domain.Entities.GameSystems;
using System.Linq.Expressions;

namespace RPGManager.Desktop.Infra.EntityMappers.Base;

public abstract class GameSystemVersionBaseEntityMapper<TEntity> : EntityBaseEntityMapper<TEntity>
    where TEntity : GameSystemVersionEntityBase
{
    public GameSystemVersionBaseEntityMapper()
    {
    }

    private void ConfigureGameSystem( EntityTypeBuilder<TEntity> builder )
    {
        builder.Property( e => e.GameSystemVersionId ).IsRequired();

        // Busca no GameSystem uma propriedade ICollection<TEntity>
        var collectionProperty = typeof( GameSystemVersion )
            .GetProperties()
            .FirstOrDefault( p =>
                p.PropertyType.IsGenericType &&
                p.PropertyType.GetGenericTypeDefinition() == typeof( ICollection<> ) &&
                p.PropertyType.GetGenericArguments()[ 0 ] == typeof( TEntity )
            );

        if ( collectionProperty is not null )
        {
            // Monta: gs => gs.NomeDaColeção  (ex: gs => gs.AbilityScores)
            var gsParam = Expression.Parameter( typeof( GameSystemVersion ), "gs" );
            var propertyAccess = Expression.Property( gsParam, collectionProperty );
            var lambda = Expression.Lambda<Func<GameSystemVersion, IEnumerable<TEntity>>>( propertyAccess, gsParam );

            builder.HasOne( e => e.GameSystemVersion )
                   .WithMany( lambda )
                   .HasForeignKey( e => e.GameSystemVersionId );
        }
        else
        {
            // Nenhuma coleção encontrada — sem navegação inversa
            builder.HasOne( e => e.GameSystemVersion )
                   .WithMany()
                   .HasForeignKey( e => e.GameSystemVersionId );
        }
    }

    public override void Configure( EntityTypeBuilder<TEntity> builder )
    {
        ConfigureGameSystem( builder );
        base.Configure( builder );
    }
}