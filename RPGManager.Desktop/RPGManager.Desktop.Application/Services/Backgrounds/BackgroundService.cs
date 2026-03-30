using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Backgrounds;
using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Interfaces.Services.BackgroundServices;

namespace RPGManager.Desktop.Application.Services.Backgrounds;

public class BackgroundService : CrudServiceBase<Background, BackgroundRegisterDto, BackgroundQueryDto>, IBackgroundService
{
    public BackgroundService( IBackgroundRepository repository, IBackgroundMapper mapper ) : base( repository, mapper )
    {
    }
}