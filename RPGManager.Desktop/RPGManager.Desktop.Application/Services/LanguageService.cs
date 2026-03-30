

using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Languages;

namespace RPGManager.Desktop.Application.Services;

public class LanguageService : CrudServiceBase<Language, LanguageRegisterDto, LanguageQueryDto>, ILanguageService
{
    public LanguageService( ILanguageRepository repository, ILanguageMapper mapper ) : base( repository, mapper )
    {
    }
}