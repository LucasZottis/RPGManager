using RPGManager.Desktop.Domain.Entities.ItemsEntities.ArmorEntities;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class ArmorRepository : RepositoryBase<Armor>, IArmorRepository
{
    public ArmorRepository( Context context ) : base( context )
    {
    }
}
