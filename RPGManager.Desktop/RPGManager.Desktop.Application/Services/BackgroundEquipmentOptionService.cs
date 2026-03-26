using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Application.Services;

public class BackgroundEquipmentOptionService : CrudServiceBase<BackgroundEquipmentOption, BackgroundEquipmentOptionRegisterDto, BackgroundEquipmentOptionQueryDto>, IBackgroundEquipmentOptionService
{
    public BackgroundEquipmentOptionService( IBackgroundEquipmentOptionRepository repository, IBackgroundEquipmentOptionMapper mapper ) : base( repository, mapper )
    {
    }
}
