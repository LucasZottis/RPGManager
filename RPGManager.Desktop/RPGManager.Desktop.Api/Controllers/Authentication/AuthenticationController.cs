using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Api.Controllers.Base;
using RPGManager.Desktop.Domain.DTOs.Auth;
using RPGManager.Desktop.Domain.Interfaces.Services.Auth;

namespace RPGManager.Desktop.Api.Controllers.Authentication;

[Route( "api/authentication" )]
[ApiController]
public class AuthenticationController : AnonymousControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController( IAuthenticationService authenticationService )
    {
        _authenticationService = authenticationService;
    }

    [HttpPost]
    [Route( "authenticate" )]
    public async Task<IActionResult> Authenticate( [FromBody] AuthenticateUserDto authentication )
    {
        var result = await _authenticationService.ValidateLogin( authentication );
        return Ok( result );
    }
}