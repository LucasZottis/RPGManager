using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ToolRepository : RepositoryBase<Tool>, IToolRepository
{
    public ToolRepository( Context context ) : base( context )
    {
    }
}
