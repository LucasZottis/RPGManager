

namespace RPGManager.Desktop.Application.Mappers;

public class SkillMapper : Mapper<Skill, SkillModel>, ISkillMapper
{
    //private readonly GameSystemMapper _gameSystemMapper;

    //public SkillMapper( GameSystemMapper gameSystemMapper )
    //{
    //    _gameSystemMapper = gameSystemMapper;
    //}


    //public Skill ToEntity( SkillModel model )
    //{
    //    var entity = new Skill
    //    {
    //        Name = model.Name,
    //        Description = model.Description,
    //        //GameSystemId = model.GameSystem.Id,
    //        GameSystem = _gameSystemMapper.ToEntity( model.GameSystem )
    //    };

    //    return entity;
    //}

    //public SkillModel ToModel( Skill entity )
    //{
    //    var model = new SkillModel
    //    {
    //        Name = entity.Name,
    //        Description = entity.Description,
    //        GameSystem = _gameSystemMapper.ToModel( entity.GameSystem )
    //    };

    //    return model;
    //}
}