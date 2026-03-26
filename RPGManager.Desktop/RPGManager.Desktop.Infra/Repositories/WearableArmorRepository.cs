using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class WearableArmorRepository : RepositoryBase<WearableArmor>, IWearableArmorRepository
{
    public WearableArmorRepository( Context context ) : base( context )
    {
    }
}
