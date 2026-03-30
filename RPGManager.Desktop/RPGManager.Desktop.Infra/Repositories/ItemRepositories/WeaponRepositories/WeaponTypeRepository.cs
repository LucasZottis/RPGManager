using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.ItemRepositories.WeaponRepositories;

public class WeaponTypeRepository : RepositoryBase<WeaponType>, IWeaponTypeRepository
{
    public WeaponTypeRepository( Context context ) : base( context )
    {
    }
}