using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.ItemRepositories.WeaponRepositories;

public class WeaponMasteryPropertyRepository : RepositoryBase<WeaponMasteryProperty>, IWeaponMasteryPropertyRepository
{
    public WeaponMasteryPropertyRepository( Context context ) : base( context )
    {
    }
}
