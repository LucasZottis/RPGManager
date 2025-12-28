

namespace RPGManager.Desktop.Application.Services;

public class LanguageService : ServiceBase<Language, LanguageModel>, ILanguageService
{
    //private readonly ILanguageRepository _repository;

    //public LanguageService( ILanguageRepository repository )
    //{
    //    _repository = repository;
    //}

    //public async Task<LanguageModel> Add( LanguageModel model )
    //{
    //    var entity = new Language
    //    {
    //        Name = model.Name,
    //        Alphabet = model.Alphabet,
    //        GameSystemId = model.GameSystem.Id,
    //    };

    //    await _repository.Add( entity );
    //    await _repository.SaveChanges();

    //    return model;
    //}

    public LanguageService( ILanguageRepository repository, ILanguageMapper mapper ) : base( repository, mapper )
    {
    }
}