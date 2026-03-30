using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

public interface ICrudServiceBase<TEntity, TRegister, TQuery> : IServiceBase
    where TEntity : EntityBase
    where TRegister : class
    where TQuery : class
{
    Task<Guid> Create( TRegister model );
    Task<IEnumerable<TQuery>> Recover();
    Task<IEnumerable<TQuery>> RecoverByGameSystemId( Guid gameSystemId );
    Task Update( Guid id, TRegister model );
    Task Delete( Guid id );
}