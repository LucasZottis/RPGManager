

namespace RPGManager.Desktop.Application.Services;

public class DamageTypeService : ServiceBase<DamageType, DamageTypeModel>, IDamageTypeService
{
    //private readonly IDamageTypeRepository _repository;

    //public DamageTypeService( IDamageTypeRepository repository )
    //{
    //    _repository = repository;
    //}

    //public async Task<DamageTypeModel> Create( DamageTypeModel model )
    //{
    //    var entity = new DamageType
    //    {
    //        Name = model.Name,
    //    };

    //    await _repository.Add( entity );
    //    await _repository.SaveChanges();

    //    model.Id = entity.Id;

    //    return model;
    //}

    public DamageTypeService( IDamageTypeRepository repository, IDamageTypeMapper mapper ) : base( repository, mapper )
    {
    }
}