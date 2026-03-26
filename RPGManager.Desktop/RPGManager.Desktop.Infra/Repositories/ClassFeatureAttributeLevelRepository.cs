using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassFeatureAttributeLevelRepository : RepositoryBase<ClassFeatureAttributeLevel>, IClassFeatureAttributeLevelRepository
{
    public ClassFeatureAttributeLevelRepository( Context context ) : base( context )
    {
    }
}
