using DevToolz.Library.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RpgContentCreator.Domain.Entities;
using RpgContentCreator.Domain.Interfaces;

namespace RpgContentCreator.Infra.Db;

public static class EntityMapperBuilder
{
    public static void Map<TEntityMapper, TEntity>( EntityTypeBuilder<TEntity> entityTypeBuilder )
        where TEntity : EntityBase
    {
        var mapper = typeof( TEntityMapper ).CreateInstance( [entityTypeBuilder] );

        if ( mapper.IsNull() )
            return;

        ( ( IEntityMapper ) mapper ).Map();
    }

    public static void MapUsingEntityModelMapper( ModelBuilder modelBuilder )
    {
        //var typeList = TypeHelper.GetEntityMapperImplementationList();

        var typeList = new List<Type>();

        if ( !typeList.Any() )
            return;

        typeList.ToList().ForEach( type =>
        {
            var argumentType = type.BaseType.GetGenericArguments().FirstOrDefault();
            var entityGenericMethod = modelBuilder.GetType()
                .GetGenericMethod( nameof( modelBuilder.Entity ) )?
                .MakeGenericMethod( [argumentType] );

            if ( entityGenericMethod.IsNull() )
                return;

            var entityTypeBuider = entityGenericMethod.Invoke( modelBuilder, null );
            var mapper = Activator.CreateInstance( type, new object[] { entityTypeBuider } );

            if ( mapper.IsNull() )
                return;

            ( ( IEntityMapper ) mapper ).Map();
        } );
    }
}