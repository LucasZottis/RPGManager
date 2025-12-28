namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IServiceBase<TEntity, TModel>
{
    Task<Guid> Create( TModel model );
    Task<IEnumerable<TModel>> Recover();
}