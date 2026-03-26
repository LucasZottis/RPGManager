using RPGManager.Desktop.Domain.Entities;
using RPGManager.Desktop.Domain.Models.AbilityScores;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IAbilityScoreService : ICrudServiceBase<AbilityScore, AbilityScoreRegisterDto, AbilityScoreQueryDto>
{
}
