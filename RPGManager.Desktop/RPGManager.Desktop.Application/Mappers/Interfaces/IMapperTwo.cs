namespace RPGManager.Desktop.Application.Mappers.Interfaces;

public interface IMapperTwo<TEntity>
{
    TEntity ToEntity<T>( T model );
    T ToModel<T>( TEntity entity );
}