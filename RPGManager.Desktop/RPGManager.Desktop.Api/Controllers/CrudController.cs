using Microsoft.AspNetCore.Mvc;

namespace RPGManager.Desktop.Api.Controllers;

[ApiController]
public class CrudController<TEntity, TModel> : ControllerBase
{
    private readonly IServiceBase<TEntity, TModel> _service;

    public CrudController( IServiceBase<TEntity, TModel> service )
    {
        _service = service;
    }

    [HttpPost]
    [Route( "create" )]
    public async Task<IActionResult> Create( [FromBody] TModel model )
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
}