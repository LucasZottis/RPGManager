using RPGManager.Desktop.Domain.Entities.Backgrounds;
using RPGManager.Desktop.Domain.Models.Backgrounds;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IBackgroundEquipmentOptionService : ICrudServiceBase<BackgroundEquipmentOption, BackgroundEquipmentOptionRegisterDto, BackgroundEquipmentOptionQueryDto>
{
}
