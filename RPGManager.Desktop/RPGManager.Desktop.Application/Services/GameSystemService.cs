

namespace RPGManager.Desktop.Application.Services;

public class GameSystemService : ServiceBase<GameSystem, GameSystemModel>, IGameSystemService
{
    public GameSystemService( IGameSystemRepository repository, IGameSystemMapper mapper ) : base( repository, mapper )
    {
    }
}