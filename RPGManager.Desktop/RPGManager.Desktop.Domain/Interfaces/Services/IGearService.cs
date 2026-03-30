using RPGManager.Desktop.Domain.DTOs.Items.Gears;
using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IGearService : ICrudServiceBase<Gear, GearRegisterDto, GearQueryDto>
{
}
