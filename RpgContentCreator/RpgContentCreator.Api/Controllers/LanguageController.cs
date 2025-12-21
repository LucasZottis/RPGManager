using Microsoft.AspNetCore.Mvc;
using RpgContentCreator.Domain.Interfaces.Services;
using RpgContentCreator.Domain.Models;

namespace RpgContentCreator.Api.Controllers;

[ApiController]
[Route( "api/language" )]
public class LanguageController : ControllerBase
{
    private readonly ILanguageService _service;

    public LanguageController( ILanguageService service )
    {
        _service = service;
    }

    [HttpPost]
    [Route("add")]
    public async Task<IActionResult> Add( [FromBody] LanguageModel model )
    {
        var result = await _service.Add( model );

        if ( result != null )
            return BadRequest();

        return Ok( result );
    }
}