using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.ItemRepositories.WeaponRepositories;

public class WeaponPropertyRepository : RepositoryBase<WeaponProperty>, IWeaponPropertyRepository
{
    public WeaponPropertyRepository( Context context ) : base( context )
    {
    }
}