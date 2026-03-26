using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Models.Items.Gears;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IAmmunitionTypeService : ICrudServiceBase<AmmunitionType, AmmunitionTypeRegisterDto, AmmunitionTypeQueryDto>
{
}
