namespace RPGManager.Desktop.Domain.Interfaces.Mappers;

public interface IMapperTwo<TEntity>
{
    TEntity ToEntity<T>( T model );
    T ToModel<T>( TEntity entity );
}