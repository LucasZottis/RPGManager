using RPGManager.Desktop.Domain.Entities.GameSystems;
using RPGManager.Desktop.Infra.Db.Contexts;

namespace RPGManager.Desktop.Infra.Repositories.GameSystemRepositories;

public class GameSystemRepository : RepositoryBase<GameSystem>, IGameSystemRepository
{
    public GameSystemRepository( Context context ) : base( context )
    {
    }

    public override async Task<IEnumerable<GameSystem>> GetByGameSystemId( Guid gameSystemId )
    {
        return await base.GetEntityList( g => g.Id == gameSystemId );
    }
}