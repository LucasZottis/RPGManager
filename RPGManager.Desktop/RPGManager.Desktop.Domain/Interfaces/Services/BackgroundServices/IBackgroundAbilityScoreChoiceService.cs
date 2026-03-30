using RPGManager.Desktop.Domain.DTOs.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Backgrounds.BackgroundAbilityScores;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.BackgroundServices;

public interface IBackgroundAbilityScoreChoiceService : ICrudServiceBase<BackgroundAbilityScoreChoice, BackgroundAbilityScoreChoiceRegisterDto, BackgroundAbilityScoreChoiceQueryDto>
{
}
