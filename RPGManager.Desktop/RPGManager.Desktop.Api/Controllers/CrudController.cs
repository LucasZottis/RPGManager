using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.Entities.Base;

namespace RPGManager.Desktop.Api.Controllers;

[ApiController]
public class CrudController<TEntity, TRegister, TQuery> : ControllerBase
    where TEntity : EntityBase
    where TRegister : class
    where TQuery : class
{
    private readonly ICrudServiceBase<TEntity, TRegister, TQuery> _service;

    public CrudController( ICrudServiceBase<TEntity, TRegister, TQuery> service )
    {
        _service = service;
    }

    [HttpPost]
    [Route( "create" )]
    public async Task<IActionResult> Create( [FromBody] TRegister model )
    {
        var result = await _service.Create( model );
        return Ok( result );
    }

    [HttpGet]
    [Route( "recover" )]
    public async Task<IActionResult> Recover()
    {
        var result = await _service.Recover();
        return Ok( result );
    }

    [HttpGet]
    [Route( "recover-by-game-system-id/{gameSystemId}" )]
    public virtual async Task<IActionResult> RecoverByGameSystemId( [FromRoute] Guid gameSystemId)
    {
        var result = await _service.Recover();
        return Ok( result );
    }


    [HttpPut]
    [Route( "update/{id}" )]
    public async Task<IActionResult> Update( [FromRoute] Guid id, [FromBody] TRegister model )
    {
        await _service.Update( id, model );
        return Ok();
    }

    [HttpDelete]
    [Route( "delete/{id}" )]
    public async Task<IActionResult> Delete( [FromRoute] Guid id )
    {
        await _service.Delete( id );
        return Ok();
    }
}