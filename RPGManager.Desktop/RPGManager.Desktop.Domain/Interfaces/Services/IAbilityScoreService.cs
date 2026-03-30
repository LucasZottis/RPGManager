using RPGManager.Desktop.Domain.DTOs.AbilityScores;
using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IAbilityScoreService : ICrudServiceBase<AbilityScore, AbilityScoreRegisterDto, AbilityScoreQueryDto>
{
}
