using RPGManager.Desktop.Domain.Entities.ItemsEntities.Gears;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class GearRepository : RepositoryBase<Gear>, IGearRepository
{
    public GearRepository( Context context ) : base( context )
    {
    }
}
