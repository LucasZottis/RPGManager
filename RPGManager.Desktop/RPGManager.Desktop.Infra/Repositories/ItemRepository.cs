using RPGManager.Desktop.Domain.Entities.ItemsEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ItemRepository : RepositoryBase<Item>, IItemRepository
{
    public ItemRepository( Context context ) : base( context )
    {
    }
}
