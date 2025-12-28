namespace RPGManager.Desktop.Application.Mappers;

public class AlignmentMapper : Mapper<Alignment, AlignmentModel>, IAlignmentMapper
{
    //private readonly GameSystemMapper _gameSystemMapper;

    //public AlignmentMapper( GameSystemMapper gameSystemMapper )
    //{
    //    _gameSystemMapper = gameSystemMapper;
    //}

    //public Alignment ToEntity( AlignmentModel model )
    //{
    //    var entity = new Alignment
    //    {
    //        Id = model.Id,
    //        Name = model.Name,
    //        Description = model.Description,
    //        GameSystem = _gameSystemMapper.ToEntity( model.GameSystem ),
    //    };

    //    return entity;
    //}

    //public AlignmentModel ToModel( Alignment entity )
    //{
    //    var model = new AlignmentModel
    //    {
    //        Id = entity.Id,
    //        Name = entity.Name,
    //        Description = entity.Description,
    //        GameSystem = _gameSystemMapper.ToModel( entity.GameSystem )
    //    };

    //    return model;
    //}
}