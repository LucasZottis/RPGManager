namespace RPGManager.Desktop.Application.Mappers;

public class DamageTypeMapper : Mapper<DamageType, DamageTypeModel>, IDamageTypeMapper
{
    //private readonly GameSystemMapper _gameSystemMapper;

    //public DamageTypeMapper( GameSystemMapper gameSystemMapper )
    //{
    //    _gameSystemMapper = gameSystemMapper;
    //}

    //public DamageType ToEntity( DamageTypeModel model )
    //{
    //    var entity = new DamageType
    //    {
    //        Id = model.Id,
    //        Name = model.Name,
    //        GameSystem = _gameSystemMapper.ToEntity( model.GameSystem )
    //    };

    //    return entity;
    //}

    //public DamageTypeModel ToModel( DamageType entity )
    //{
    //    var model = new DamageTypeModel
    //    {
    //        Id = entity.Id,
    //        Name = entity.Name,
    //        GameSystem = _gameSystemMapper.ToModel( entity.GameSystem )
    //    };

    //    return model;
    //}
}