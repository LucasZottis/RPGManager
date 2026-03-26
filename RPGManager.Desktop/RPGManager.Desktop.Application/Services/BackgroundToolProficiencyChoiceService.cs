using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Application.Services;

public class BackgroundToolProficiencyChoiceService : CrudServiceBase<BackgroundToolProficiencyChoice, BackgroundToolProficiencyChoiceRegisterDto, BackgroundToolProficiencyChoiceQueryDto>, IBackgroundToolProficiencyChoiceService
{
    public BackgroundToolProficiencyChoiceService( IBackgroundToolProficiencyChoiceRepository repository, IBackgroundToolProficiencyChoiceMapper mapper ) : base( repository, mapper )
    {
    }
}
