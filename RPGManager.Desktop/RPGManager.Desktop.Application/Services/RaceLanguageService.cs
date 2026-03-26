namespace RPGManager.Desktop.Application.Services;

public class RaceLanguageService : CrudServiceBase<RaceLanguage, RaceLanguageRegisterDto, RaceLanguageQueryDto>, IRaceLanguageService
{
    public RaceLanguageService( IRaceLanguageRepository repository, IRaceLanguageMapper mapper ) : base( repository, mapper )
    {
    }
}
