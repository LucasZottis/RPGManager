using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Api.Controllers.Base;
using RPGManager.Desktop.Domain.DTOs.GameSystems;
using RPGManager.Desktop.Domain.Entities.GameSystems;

namespace RPGManager.Desktop.Api.Controllers;

[Route( "api/game-system" )]
[Authorize(Policy = "GameSystemControl" )]
public class GameSystemController : CrudController<GameSystem, GameSystemRegisterDto, GameSystemQueryDto>
{
    public GameSystemController( IGameSystemService service ) : base( service ) { }

    [HttpGet]
    [Route( "recover-by-id/{id}" )]
    public override async Task<IActionResult> RecoverByGameSystemId( [FromRoute] Guid id )
    {
        return await base.RecoverByGameSystemId( id );
    }

    [HttpGet]
    [Route( "{gameSystemId}/versions/recover" )]
    public async Task<IActionResult> GetVersions( [FromRoute] Guid gameSystemId )
    {
        var service = GetService<IGameSystemService>();
        var versions = await service.GetVersions( gameSystemId );

        return Ok( versions );
    }

    [HttpPost]
    [Route( "{gameSystemId}/versions/create" )]
    public async Task<IActionResult> CreateVersion( [FromRoute] Guid gameSystemId, [FromBody] GameSystemVersionRegisterDto gameSystemVersion )
    {
        var service = GetService<IGameSystemService>();
        var id = await service.CreateVersion( gameSystemId, gameSystemVersion );

        return Created( $"get-version/{id}", id );
    }

    [HttpGet]
    [Route( "versions/recover/{gameSystemVersionId}" )]
    public async Task<IActionResult> GetVersion( [FromRoute] Guid gameSystemVersionId )
    {
        var service = GetService<IGameSystemService>();
        var version = await service.GetVersionById( gameSystemVersionId );

        return Ok( version );
    }
}