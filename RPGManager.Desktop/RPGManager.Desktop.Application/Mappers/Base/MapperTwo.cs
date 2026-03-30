using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Application.Mappers.Base;

public class MapperTwo<TEntity> : Mapper, IMapperTwo<TEntity>
    where TEntity : EntityBase
{
    public virtual TEntity ToEntity<TDto>( TDto model )
    {
        return base.ToEntity<TEntity, TDto>( model );
    }

    public virtual TDto ToModel<TDto>( TEntity entity )
    {
        return base.ToModel<TEntity, TDto>( entity );
    }
}