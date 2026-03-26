using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ShieldArmorRepository : RepositoryBase<ShieldArmor>, IShieldArmorRepository
{
    public ShieldArmorRepository( Context context ) : base( context )
    {
    }
}
