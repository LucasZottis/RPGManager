using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.GameSystemRepositories;

public class GameSystemVersionRepository : RepositoryBase<GameSystemVersion>, IGameSystemVersionRepository
{
    public GameSystemVersionRepository( Context context ) : base( context )
    {
    }
}
