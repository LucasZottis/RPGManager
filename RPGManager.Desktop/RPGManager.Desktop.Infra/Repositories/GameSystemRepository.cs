using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories;

public class GameSystemRepository : RepositoryBase<GameSystem>, IGameSystemRepository
{
    public GameSystemRepository( Context context ) : base( context )
    {
    }
}