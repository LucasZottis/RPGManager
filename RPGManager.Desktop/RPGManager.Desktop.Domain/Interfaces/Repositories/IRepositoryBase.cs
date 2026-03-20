using RPGManager.Desktop.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace RPGManager.Desktop.Domain.Interfaces.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    Task Add( TEntity entity );

    Task AddRange( IEnumerable<TEntity> entities );

    Task Update( [NotNull] TEntity entity );

    Task Remove( TEntity entity );

    Task RemoveRange( IEnumerable<TEntity> entities );

    Task<IEnumerable<TEntity>> GetAll();

    Task<IEnumerable<TEntity>> GetByGameSystemId( Guid gameSystemId );

    Task<TEntity?> GetById( Guid id );

    Task SaveChanges();
}