using RPGManager.Desktop.Domain.Entities.ItemsEntities.WeaponEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class WeaponCategoryRepository : RepositoryBase<WeaponCategory>, IWeaponCategoryRepository
{
    public WeaponCategoryRepository( Context context ) : base( context )
    {
    }
}