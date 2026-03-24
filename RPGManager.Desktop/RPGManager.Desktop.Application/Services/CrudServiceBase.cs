using RPGManager.Desktop.Domain.Entities.Base;
using System.Diagnostics.CodeAnalysis;

namespace RPGManager.Desktop.Application.Services;

public class CrudServiceBase<TEntity, TRegister, TQuery> : ICrudServiceBase<TEntity, TRegister, TQuery>
    where TEntity : EntityBase
    where TRegister : class
    where TQuery : class
{
    protected IRepositoryBase<TEntity> Repository { get; private set; }
    protected IMapperTwo<TEntity> Mapper { get; private set; }

    public CrudServiceBase( IRepositoryBase<TEntity> repository, IMapperTwo<TEntity> mapper )
    {
        Repository = repository;
        Mapper = mapper;
    }

    [DoesNotReturn]
    protected void ThrowIfEntityIsNull(TEntity entity)
    {
        if (entity == null)
            throw new Exception( "Registro não existe" );
    }

    public async Task<Guid> Create( TRegister model )
    {
        var entity = Mapper.ToEntity( model );

        await Repository.Add( entity );
        await Repository.SaveChanges();

        return entity.Id;
    }

    public async Task Delete( Guid id )
    {
        var entity = await Repository.GetById( id );

        ThrowIfEntityIsNull( entity );

        await Repository.Remove( entity );
        await Repository.SaveChanges();
    }

    public async Task<IEnumerable<TQuery>> Recover()
    {
        var entities = await Repository.GetAll();
        var models = new List<TQuery>();

        foreach ( var entity in entities )
            models.Add( Mapper.ToModel<TQuery>( entity ) );

        return models;
    }

    public async Task<IEnumerable<TQuery>> RecoverByGameSystemId( Guid gameSystemId )
    {
        var entities = await Repository.GetByGameSystemId(gameSystemId);
        var models = new List<TQuery>();

        foreach ( var entity in entities )
            models.Add( Mapper.ToModel<TQuery>( entity ) );

        return models;
    }

    public async Task Update( Guid id, TRegister model )
    {
        var entity = await Repository.GetById( id );
        ThrowIfEntityIsNull( entity );

        entity = Mapper.ToEntity( model );
        entity.Id = id;

        await Repository.Update( entity );
        await Repository.SaveChanges();
    }
}