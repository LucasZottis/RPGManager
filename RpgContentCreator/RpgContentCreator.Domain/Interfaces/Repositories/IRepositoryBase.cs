using RpgContentCreator.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace RpgContentCreator.Domain.Interfaces.Repositories;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    Task Add( TEntity entity );
    Task AddRange( IEnumerable<TEntity> entities );

    Task Update( [NotNull] TEntity entity );

    Task Deactivate( TEntity entity );

    Task Reactivate( TEntity entity );

    Task Remove( TEntity entity );
    Task RemoveRange( IEnumerable<TEntity> entities );

    Task<IEnumerable<TEntity>> GetAll();

    Task<TEntity?> GetById( int id );

    Task<TEntity?> GetByGuid( Guid guid );

    Task<IEnumerable<TEntity>> GetByRegistrationDate( DateTime registerDate );

    Task<IEnumerable<TEntity>> GetAllByDeactivationDate();

    Task SaveChanges();
}