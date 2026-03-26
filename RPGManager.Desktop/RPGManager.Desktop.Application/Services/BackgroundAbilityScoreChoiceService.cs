using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Application.Services;

public class BackgroundAbilityScoreChoiceService : CrudServiceBase<BackgroundAbilityScoreChoice, BackgroundAbilityScoreChoiceRegisterDto, BackgroundAbilityScoreChoiceQueryDto>, IBackgroundAbilityScoreChoiceService
{
    public BackgroundAbilityScoreChoiceService( IBackgroundAbilityScoreChoiceRepository repository, IBackgroundAbilityScoreChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
