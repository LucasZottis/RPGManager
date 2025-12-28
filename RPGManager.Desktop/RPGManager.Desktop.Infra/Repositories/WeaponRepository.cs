using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class WeaponRepository : RepositoryBase<Weapon>, IWeaponRepository
{
    public WeaponRepository( Context context ) : base( context )
    {
    }
}