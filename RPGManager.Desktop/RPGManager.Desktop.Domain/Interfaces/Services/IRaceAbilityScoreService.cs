using RPGManager.Desktop.Domain.Entities.RaceEntities;
using RPGManager.Desktop.Domain.Models.Races;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IRaceAbilityScoreService : ICrudServiceBase<RaceAbilityScore, RaceAbilityScoreRegisterDto, RaceAbilityScoreQueryDto>
{
}
