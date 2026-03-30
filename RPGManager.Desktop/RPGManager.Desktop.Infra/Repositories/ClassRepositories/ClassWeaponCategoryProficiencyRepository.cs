using RPGManager.Desktop.Domain.Entities.ClassesEntities.WeaponProficiency;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.ClassRepositories;

public class ClassWeaponCategoryProficiencyRepository : RepositoryBase<ClassWeaponCategoryProficiency>, IClassWeaponCategoryProficiencyRepository
{
    public ClassWeaponCategoryProficiencyRepository( Context context ) : base( context )
    {
    }
}
