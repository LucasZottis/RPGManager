using Microsoft.AspNetCore.Mvc;
using RpgContentCreator.Domain.Interfaces.Services;
using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.Api.Controllers;

[Route( "api/game-system" )]
[ApiController]
public class GameSystemController : ControllerBase
{
    private readonly IGameSystemService _service;
    private readonly ILogger _logger;

    //public GameSystemController( IGameSystemService service, ILogger logger )
    public GameSystemController( IGameSystemService service )
    {
        _service = service;
        //_logger = logger;
    }

    [HttpPost]
    [Route( "create" )]
    public async Task<IActionResult> Create( [FromBody] GameSystemModel model )
    {
        var gameSystem = await _service.Create( model );

        if ( gameSystem == null )
            return NotFound();

        //return Created( "", gameSystem );
        return Ok( gameSystem );
    }
}