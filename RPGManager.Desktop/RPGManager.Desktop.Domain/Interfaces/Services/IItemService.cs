using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Models.Items;

namespace RPGManager.Desktop.Domain.Interfaces.Services;

public interface IItemService : ICrudServiceBase<Item, ItemRegisterDto, ItemQueryDto>
{
}
