using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/game-system" )]
public class GameSystemController : CrudController<GameSystem, GameSystemModel>
{
    public GameSystemController( IGameSystemService service ) : base( service )
    {
    }
}