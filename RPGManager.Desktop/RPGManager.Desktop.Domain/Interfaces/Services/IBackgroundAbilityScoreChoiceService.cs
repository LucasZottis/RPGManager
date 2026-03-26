using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IBackgroundAbilityScoreChoiceService : ICrudServiceBase<BackgroundAbilityScoreChoice, BackgroundAbilityScoreChoiceRegisterDto, BackgroundAbilityScoreChoiceQueryDto>
{
}
