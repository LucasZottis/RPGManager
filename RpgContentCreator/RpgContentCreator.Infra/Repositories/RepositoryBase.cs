using DevToolz.Library.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RpgContentCreator.Domain.Entities;
using RpgContentCreator.Domain.Interfaces.Repositories;
using RpgContentCreator.Infra.Db;
using RpgContentCreator.Library.Interfaces;
using System.Linq.Expressions;
using System.Reflection;
using IDeactivatableEntity = RpgContentCreator.Library.Interfaces.IDeactivatableEntity;

namespace RpgContentCreator.Infra.Repositories;

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
        if (entity is IRegistrableEntity)
            //if ( typeof( TEntity ).IsAssignableFrom( typeof( IRegistrableEntity ) ) )
            Context.Register(entity);
        else
            Context.Add(entity);
    }

    public virtual async Task Update(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException("Entidade não pode ser nula.");

        //UpdateCore( entity );

        Context.Update(entity);
    }

    public virtual async Task Deactivate(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException("Entidade não pode ser nula.");

        Context.Deactivate(entity);
    }

    public virtual async Task Reactivate(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException("Entidade não pode ser nula.");

        Context.Reactivate(entity);
    }

    public virtual async Task Remove(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException("Entidade não pode ser nula.");

        if (typeof(TEntity).IsAssignableFrom(typeof(IDeactivatableEntity)))
            Context.Deactivate(entity);
        else
            Context.Remove(entity);
    }

    public virtual async Task<TEntity?> GetById(int id)
    {
        if (typeof(TEntity).IsAssignableFrom(typeof(IIdentifiableEntity)))
            return await GetEntity(e => ((IIdentifiableEntity)e).Id == id);

        return null;
    }

    public virtual async Task<TEntity?> GetByGuid(Guid guid)
        => await GetEntity(e => e.Id == guid);

    public virtual async Task<IEnumerable<TEntity>> GetByRegistrationDate(DateTime registerDate)
    {
        if (typeof(TEntity).IsAssignableFrom(typeof(IRegistrableEntity)))
            return await GetEntityList(e => ((IRegistrableEntity)e).RegistrationDate == registerDate);

        return new List<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllByDeactivationDate()
    {
        if (typeof(TEntity).IsAssignableFrom(typeof(IDeactivatableEntity)))
            await GetEntityList(e => ((IDeactivatableEntity)e).DeactivationDate.HasValue);

        return new List<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAll()
        => await Context.Set<TEntity>().AsNoTracking().IgnoreQueryFilters().ToListAsync();

    public async Task SaveChanges()
    {
        Context.SaveChanges();
    }

    public async Task AddRange(IEnumerable<TEntity> entities)
    {
        entities.ForEach<TEntity>( e =>
        {
            Add( e );
        } );
    }

    public async Task RemoveRange(IEnumerable<TEntity> entities)
    {
        Context.Set<TEntity>().RemoveRange(entities);
    }
}