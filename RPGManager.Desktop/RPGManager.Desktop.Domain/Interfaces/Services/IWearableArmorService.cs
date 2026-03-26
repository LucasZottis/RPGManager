using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Domain.Models.Items.Armor;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IWearableArmorService : ICrudServiceBase<WearableArmor, WearableArmorRegisterDto, WearableArmorQueryDto>
{
}
