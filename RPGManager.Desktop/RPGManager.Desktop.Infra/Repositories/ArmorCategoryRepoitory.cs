using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ArmorCategoryRepoitory : RepositoryBase<ArmorCategory>, IArmorCategoryRepository
{
    public ArmorCategoryRepoitory( Context context ) : base( context )
    {
    }
}