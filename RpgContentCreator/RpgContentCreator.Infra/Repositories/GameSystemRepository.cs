namespace RpgContentCreator.Infra.Repositories;

public class GameSystemRepository : RepositoryBase<GameSystem>, IGameSystemRepository
{
    public GameSystemRepository( Context context ) : base( context )
    {
    }
}