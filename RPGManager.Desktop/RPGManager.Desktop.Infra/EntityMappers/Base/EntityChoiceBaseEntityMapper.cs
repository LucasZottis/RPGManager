using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Desktop.Domain.Entities.Base;
using System.Linq.Expressions;

namespace RPGManager.Desktop.Infra.EntityMappers.Base
{
    public abstract class EntityChoiceBaseEntityMapper<TEntity> : EntityBaseEntityMapper<TEntity>
        where TEntity : EntityChoiceBase
    {
        private void ConfigureEntity( EntityTypeBuilder<TEntity> builder )
        {
            builder.Property( e => e.AllowedChoices ).IsRequired();

            //// Busca no GameSystem uma propriedade ICollection<TEntity>
            //var collectionProperty = typeof( GameSystem )
            //    .GetProperties()
            //    .FirstOrDefault( p =>
            //        p.PropertyType.IsGenericType &&
            //        p.PropertyType.GetGenericTypeDefinition() == typeof( ICollection<> ) &&
            //        p.PropertyType.GetGenericArguments()[ 0 ] == typeof( TEntity )
            //    );

            //if ( collectionProperty is not null )
            //{
            //    // Monta: gs => gs.NomeDaColeção  (ex: gs => gs.AbilityScores)
            //    var gsParam = Expression.Parameter( typeof( EntityChoiceBase ), "gs" );
            //    var propertyAccess = Expression.Property( gsParam, collectionProperty );
            //    var lambda = Expression.Lambda<Func<GameSystem, IEnumerable<TEntity>>>( propertyAccess, gsParam );

            //    builder.HasOne( e => e.GameSystem )
            //           .WithMany( lambda )
            //           .HasForeignKey( e => e.GameSystemId );
            //}
            //else
            //{
            //    // Nenhuma coleção encontrada — sem navegação inversa
            //    builder.HasOne( e => e.GameSystem )
            //           .WithMany()
            //           .HasForeignKey( e => e.GameSystemId );
            //}
        }

        public override void Configure( EntityTypeBuilder<TEntity> builder )
        {

            base.Configure( builder );
        }
    }
}