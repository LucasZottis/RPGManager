using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Domain.Models.Items;

namespace RPGManager.Desktop.Application.Services;

public class ItemService : CrudServiceBase<Item, ItemRegisterDto, ItemQueryDto>, IItemService
{
    public ItemService( IItemRepository repository, IItemMapper mapper ) : base( repository, mapper )
    {
    }
}
