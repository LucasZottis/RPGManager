using RPGManager.Desktop.Domain.Entities.ClassesEntities.WeaponProficiency;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassWeaponCategoryProficiencyConditionRepository : RepositoryBase<ClassWeaponCategoryProficiencyCondition>, IClassWeaponCategoryProficiencyConditionRepository
{
    public ClassWeaponCategoryProficiencyConditionRepository( Context context ) : base( context )
    {
    }
}
