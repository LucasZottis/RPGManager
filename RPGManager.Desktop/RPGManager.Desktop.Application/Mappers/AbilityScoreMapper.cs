namespace RPGManager.Desktop.Application.Mappers;

public class AbilityScoreMapper : Mapper<Background, AbilityScoreModel>, IAbilityScoreMapper
{
    ////private readonly GameSystemMapper _gameSystemMapper;
    //private readonly SkillMapper _skillMapper;

    ////public AbilityScoreMapper( GameSystemMapper gameSystemMapper, SkillMapper skillMapper )
    //public AbilityScoreMapper( SkillMapper skillMapper )
    //{
    //    //_gameSystemMapper = gameSystemMapper;
    //    _skillMapper = skillMapper;
    //}

    //public AbilityScore ToEntity( AbilityScoreModel model )
    //{
    //    var entity = new AbilityScore
    //    {
    //        Id = model.Id,
    //        Name = model.Name,
    //        Abbreviation = model.Abbreviation,
    //        Description = model.Description,
    //        GameSystemId = model.GameSystemId,
    //        Skills = [ .. model.Skills.Select(  _skillMapper.ToEntity  ) ],
    //    };

    //    return entity;
    //}

    //public AbilityScoreModel ToModel( AbilityScore entity )
    //{
    //    var model = new AbilityScoreModel
    //    {
    //        Id = entity.Id,
    //        Name = entity.Name,
    //        Abbreviation = entity.Abbreviation,
    //        Description = entity.Description,
    //        GameSystem = _gameSystemMapper.ToModel( entity.GameSystem ),
    //        Skills = [ .. entity.Skills.Select(  _skillMapper.ToModel  ) ],
    //    };

    //    return model;
    //}
}