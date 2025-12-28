namespace RPGManager.Desktop.Domain.Interfaces.Mappers;

public interface IMapper<TEntity, TModel>
{
    TEntity ToEntity(TModel model);
    TModel ToModel(TEntity entity);
}