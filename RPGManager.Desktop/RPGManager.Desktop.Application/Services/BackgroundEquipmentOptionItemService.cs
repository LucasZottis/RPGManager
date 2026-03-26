using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Application.Services;

public class BackgroundEquipmentOptionItemService : CrudServiceBase<BackgroundEquipmentOptionItem, BackgroundEquipmentOptionItemRegisterDto, BackgroundEquipmentOptionItemQueryDto>, IBackgroundEquipmentOptionItemService
{
    public BackgroundEquipmentOptionItemService( IBackgroundEquipmentOptionItemRepository repository, IBackgroundEquipmentOptionItemMapper mapper ) : base( repository, mapper )
    {
    }
}
