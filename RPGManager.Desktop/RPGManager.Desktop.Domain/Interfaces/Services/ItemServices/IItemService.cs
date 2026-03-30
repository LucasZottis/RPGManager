using RPGManager.Desktop.Domain.DTOs.Items;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.BaseServices;

namespace RPGManager.Desktop.Domain.Interfaces.Services.ItemServices;

public interface IItemService : ICrudServiceBase<Item, ItemRegisterDto, ItemQueryDto>
{
}
