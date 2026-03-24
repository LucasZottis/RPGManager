using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Application.Services;

public class ServiceBase<TEntity, TModel> : IServiceBase<TEntity, TModel>
    where TEntity : EntityBase
    where TModel : class
{
    protected IRepositoryBase<TEntity> Repository { get; private set; }
    protected IMapper<TEntity, TModel> Mapper { get; private set; }

    public ServiceBase( IRepositoryBase<TEntity> repository, IMapper<TEntity, TModel> mapper )
    {
        Repository = repository;
        Mapper = mapper;
    }

    public virtual async Task<Guid> Create( TModel model )
    {
        var entity = Mapper.ToEntity( model );

        await Repository.Add( entity );
        await Repository.SaveChanges();

        //return Mapper.ToModel( entity );
        return entity.Id;
    }
     
    public virtual async Task<IEnumerable<TModel>> Recover()
    {
        var entities = await Repository.GetAll();
        var models = new List<TModel>();

        foreach ( var entity in entities )
            models.Add( Mapper.ToModel( entity ) );

        return models;
    }
}