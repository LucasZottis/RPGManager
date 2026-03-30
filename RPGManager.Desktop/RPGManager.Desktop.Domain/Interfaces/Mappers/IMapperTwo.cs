namespace RPGManager.Desktop.Domain.Interfaces.Mappers;

public interface IMapperTwo<TEntity> : IMapper
{
    TEntity ToEntity<T>( T model );
    T ToModel<T>( TEntity entity );
}