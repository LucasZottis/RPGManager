using RPGManager.Desktop.Application.DTOs.GameSystems;
using RPGManager.Desktop.Application.Services.Interfaces;

namespace RPGManager.Desktop.Application.Services;

public class GameSystemService : CrudServiceBase<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>, IGameSystemService
{
    public GameSystemService( IGameSystemRepository repository, IGameSystemMapper mapper ) : base( repository, mapper )
    {
    }
}