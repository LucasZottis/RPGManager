using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class DamageTypeRepository : RepositoryBase<DamageType>, IDamageTypeRepository
{
    public DamageTypeRepository( Context context ) : base( context )
    {
    }
}