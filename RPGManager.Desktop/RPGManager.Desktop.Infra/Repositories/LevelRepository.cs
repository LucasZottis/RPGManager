using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class LevelRepository : RepositoryBase<Level>, ILevelRepository
{
    public LevelRepository( Context context ) : base( context )
    {
    }
}
