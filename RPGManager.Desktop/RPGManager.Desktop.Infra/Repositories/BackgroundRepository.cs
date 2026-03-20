using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class BackgroundRepository : RepositoryBase<Background>, IBackgroundRepository
{
    public BackgroundRepository( Context context ) : base( context )
    {
    }
}