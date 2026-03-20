using RPGManager.Desktop.Domain.Models.GameSystems;

namespace RPGManager.Desktop.Application.Services;

public class GameSystemService : CrudServiceBase<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>, IGameSystemService
{
    public GameSystemService( IGameSystemRepository repository, IGameSystemMapper mapper ) : base( repository, mapper )
    {
    }
}