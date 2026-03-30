using RPGManager.Desktop.Application.Services.Base;
using RPGManager.Desktop.Domain.DTOs.Items;
using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Interfaces.Services.ItemServices;

namespace RPGManager.Desktop.Application.Services.ItemServices;

public class ItemService : CrudServiceBase<Item, ItemRegisterDto, ItemQueryDto>, IItemService
{
    public ItemService( IItemRepository repository, IItemMapper mapper ) : base( repository, mapper )
    {
    }
}
