using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.ItemRepositories.ArmorRepositories;

public class ShieldArmorRepository : RepositoryBase<ShieldArmor>, IShieldArmorRepository
{
    public ShieldArmorRepository( Context context ) : base( context )
    {
    }
}
