using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class SizeRepository : RepositoryBase<Size>, ISizeRepository
{
    public SizeRepository( Context context ) : base( context )
    {
    }
}
