using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Models.Races;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IRaceLanguageService : ICrudServiceBase<RaceLanguage, RaceLanguageRegisterDto, RaceLanguageQueryDto>
{
}
