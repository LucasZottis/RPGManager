using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RPGManager.Desktop.Domain.Entities.Base;
using RPGManager.Desktop.Infra.Db.Contexts;
using System.Linq.Expressions;
using System.Reflection;

namespace RPGManager.Desktop.Infra.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    protected ContextBase Context { get; private set; }

    public RepositoryBase(ContextBase context)
        => Context = context;

    private bool IsValidProperty(PropertyInfo propertyInfo)
    {
        return !propertyInfo.PropertyType.IsInterface
            && propertyInfo.PropertyType.BaseType != typeof(EntityBase)
            && propertyInfo.Name != "RegistrationDate"
            && propertyInfo.Name != "Guid"
            && propertyInfo.Name != "Id";
    }

    private EntityEntry<TEntity> AttachEntity(TEntity entity)
    {
        Context.Set<TEntity>().Attach(entity);
        return Context.Entry(entity);
    }

    private void UpdateCore(TEntity entity)
    {
        var entityEntry = AttachEntity(entity);
        var properties = typeof(TEntity).GetProperties();

        properties.Where(IsValidProperty)
            .ToList().ForEach(p => entityEntry.Property(p.Name).IsModified = true);
    }

    protected async Task<TEntity?> GetEntity(Expression<Func<TEntity, bool>> expressao)
    {
        return await Context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(expressao);
    }

    protected async Task<IEnumerable<TEntity>> GetEntityList(Expression<Func<TEntity, bool>> expression)
    {
        return await Context.Set<TEntity>().Where(expression).AsNoTracking().ToListAsync();
    }

    public virtual async Task Add(TEntity entity)
    {
        entity.Id = Guid.NewGuid();
        Context.Add( entity );
    }

    public async Task AddRange( IEnumerable<TEntity> entities )
    {
        entities.ForEach<TEntity>( e =>
        {
            Add( e );
        } );
    }

    public virtual async Task Update(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException("Entidade não pode ser nula.");

        //UpdateCore( entity );
        Context.Update(entity);
    }

    public virtual async Task Remove(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException("Entidade não pode ser nula.");

        Context.Remove( entity );
    }

    public async Task RemoveRange( IEnumerable<TEntity> entities )
    {
        Context.Set<TEntity>().RemoveRange( entities );
    }

    public virtual async Task<TEntity?> GetById(Guid id)
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