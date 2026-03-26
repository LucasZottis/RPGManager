using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.Languages;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface ILanguageService : ICrudServiceBase<Language, LanguageRegisterDto, LanguageQueryDto>
{
}
