using RPGManager.Desktop.Domain.DTOs.Languages;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ILanguageService : ICrudServiceBase<Language, LanguageRegisterDto, LanguageQueryDto>
{
}
