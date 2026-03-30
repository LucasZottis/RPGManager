namespace RPGManager.Desktop.Domain.Interfaces.Mappers;

public interface IMapper
{
    TEntity ToEntity<TEntity, TDto>(TDto dto);
    TDto ToModel<TEntity, TDto>(TEntity entity);
}