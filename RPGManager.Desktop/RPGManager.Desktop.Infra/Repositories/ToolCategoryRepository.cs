using RPGManager.Desktop.Domain.Entities.ItemsEntities.ToolEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ToolCategoryRepository : RepositoryBase<ToolCategory>, IToolCategoryRepository
{
    public ToolCategoryRepository( Context context ) : base( context )
    {
    }
}
