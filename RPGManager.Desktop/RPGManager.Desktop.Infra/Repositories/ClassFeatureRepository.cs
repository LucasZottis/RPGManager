using RPGManager.Desktop.Domain.Entities.ClassesEntities.Feature;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ClassFeatureRepository : RepositoryBase<ClassFeature>, IClassFeatureRepository
{
    public ClassFeatureRepository( Context context ) : base( context )
    {
    }
}
