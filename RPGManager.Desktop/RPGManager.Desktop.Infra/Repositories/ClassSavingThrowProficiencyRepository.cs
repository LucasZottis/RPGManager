using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassSavingThrowProficiencyRepository : RepositoryBase<ClassSavingThrowProficiency>, IClassSavingThrowProficiencyRepository
{
    public ClassSavingThrowProficiencyRepository( Context context ) : base( context )
    {
    }
}
