using RPGManager.Desktop.Domain.DTOs.Races;
using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.RaceServices;

public interface IRaceLanguageService : ICrudServiceBase<RaceLanguage, RaceLanguageRegisterDto, RaceLanguageQueryDto>
{
}
