using RPGManager.Desktop.Domain.Entities.ClassesEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class SubClassRepository : RepositoryBase<SubClass>, ISubClassRepository
{
    public SubClassRepository( Context context ) : base( context )
    {
    }
}
