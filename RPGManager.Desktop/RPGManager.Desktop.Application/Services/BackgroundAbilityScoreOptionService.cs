using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Application.Services;

public class BackgroundAbilityScoreOptionService : CrudServiceBase<BackgroundAbilityScoreOption, BackgroundAbilityScoreOptionRegisterDto, BackgroundAbilityScoreOptionQueryDto>, IBackgroundAbilityScoreOptionService
{
    public BackgroundAbilityScoreOptionService( IBackgroundAbilityScoreOptionRepository repository, IBackgroundAbilityScoreOptionMapper mapper ) : base( repository, mapper )
    {
    }
}
