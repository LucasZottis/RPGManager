using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Application.Services;

public class BackgroundService : CrudServiceBase<Background, BackgroundRegisterDto, BackgroundQueryDto>, IBackgroundService
{
    public BackgroundService( IBackgroundRepository repository, IBackgroundMapper mapper ) : base( repository, mapper )
    {
    }
}