using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Application.DTOs.GameSystems;
using RPGManager.Desktop.Application.Services.Interfaces;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/game-system" )]
public class GameSystemController : CrudController<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>
{
    public GameSystemController( IGameSystemService service ) : base( service )
    {
    }

    [HttpGet]
    [Route( "recover-by-id/{id}" )]
    public override Task<IActionResult> RecoverByGameSystemId( [FromRoute] Guid id )
    {
        return base.RecoverByGameSystemId( id );
    }
}