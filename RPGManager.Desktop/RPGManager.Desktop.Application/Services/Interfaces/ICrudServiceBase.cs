using RPGManager.Desktop.Domain.Entities;

namespace RPGManager.Desktop.Application.Services.Interfaces;

public interface ICrudServiceBase<TEntity, TRegister, TQuery>
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