using Microsoft.EntityFrameworkCore;
using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Infra.Db.Contexts;
using RPGManager.Desktop.Infra.Utils;
using System.Linq.Expressions;

namespace RPGManager.Desktop.Infra.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    protected ContextBase Context { get; private set; }

    public RepositoryBase( ContextBase context )
        => Context = context;

    protected async Task<TEntity?> GetEntity( Expression<Func<TEntity, bool>> expressao )
    {
        return await Context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync( expressao );
    }

    protected async Task<IEnumerable<TEntity>> GetEntityList( Expression<Func<TEntity, bool>> expression )
    {
        return await Context.Set<TEntity>().Where( expression ).AsNoTracking().ToListAsync();
    }

    public virtual async Task Add( TEntity entity )
    {
        ThrowHelper.ThrowNullEntity( entity );
        entity.Id = Guid.NewGuid();

        Context.Add( entity );
    }

    public async Task AddRange( IEnumerable<TEntity> entities )
    {
        foreach ( var entity in entities )
        {
            await Add( entity );
        }
    }

    public virtual async Task Update( TEntity entity )
    {
        ThrowHelper.ThrowNullEntity( entity );
        Context.Update( entity );
    }

    public virtual async Task Remove( TEntity entity )
    {
        ThrowHelper.ThrowNullEntity( entity );
        Context.Remove( entity );
    }

    public async Task RemoveRange( IEnumerable<TEntity> entities )
    {
        Context.Set<TEntity>().RemoveRange( entities );
    }

    public virtual async Task<TEntity?> GetById( Guid id )
    {
        return await GetEntity( e => e.Id == id );
    }

    public virtual async Task<IEnumerable<TEntity>> GetAll()
        => await Context.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().ToListAsync();

    public async Task SaveChanges()
    {
        Context.SaveChanges();
    }

    public virtual async Task<IEnumerable<TEntity>> GetByGameSystemId( Guid gameSystemId )
    {
        return await Context.Set<TEntity>()
            .Where( e => EF.Property<Guid>( e, "GameSystemId" ) == gameSystemId )
            .AsNoTracking()
            .IgnoreQueryFilters()
            .ToListAsync();
    }
}