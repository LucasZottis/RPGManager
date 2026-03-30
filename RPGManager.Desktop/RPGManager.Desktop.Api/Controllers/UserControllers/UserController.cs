using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPGManager.Desktop.Domain.DTOs.Auth.User;
using RPGManager.Desktop.Domain.Interfaces.Services.Auth;

namespace RPGManager.Desktop.Api.Controllers.UserControllers;

[Route( "api/user" )]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController( IUserService service )
    {
        _service = service;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Create( [FromBody] UserRegisterDto model )
    {
        var id = await _service.CreateUser( model );
        return Ok( id );
    }
}