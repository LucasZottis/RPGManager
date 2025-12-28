

namespace RPGManager.Desktop.Application.Mappers;

public class LanguageMapper : Mapper<Language, LanguageModel>, ILanguageMapper
{
    //private readonly GameSystemMapper _gameSystemMapper;

    //public LanguageMapper( GameSystemMapper gameSystemMapper )
    //{
    //    _gameSystemMapper = gameSystemMapper;
    //}

    //public Language ToEntity( LanguageModel model )
    //{
    //    var entity = new Language
    //    {
    //        Id = model.Id,
    //        Name = model.Name,
    //        Alphabet = model.Alphabet,
    //        GameSystem = _gameSystemMapper.ToEntity( model.GameSystem )
    //    };

    //    return entity;
    //}

    //public LanguageModel ToModel( Language entity )
    //{
    //    var model = new LanguageModel
    //    {
    //        Id = entity.Id,
    //        Name = entity.Name,
    //        Alphabet = entity.Alphabet,
    //        GameSystem = _gameSystemMapper.ToModel( entity.GameSystem )
    //    };

    //    return model;
    //}
}